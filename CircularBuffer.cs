using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvionicsInstrumentControlDemo
{
    static public class CircularBuffer
    {
        static Crc crc = new Crc();
        private static int bufferSize = 256;
        private static int dataLenght = 25;
        private static byte[] buffer = new byte[bufferSize];
        private static int head;
        private static int tail;
        static private UgvDatas ugvDatas = new UgvDatas();
        static private byte[] dataBuffer = new byte[dataLenght];

        public static void pushData(byte [] bytes, int dataLen)
        {
            for(int i = 0; i < dataLen; i++)
            {
                buffer[(head + 1) % bufferSize] = bytes[i];
                head = (head + 1) % bufferSize;
            }
        }

        public static bool isDataReady()
        {
            while(tail != head)
            {
                if(buffer[(tail + 1) % bufferSize] == '\r')
                {
                    if (buffer[(tail + 2) % bufferSize] == '\n')
                    {
                        if(isCrcCorrect(tail + 2))
                        {
                            tail = head;
                            return true;
                        }
                        tail = head;
                        return false;
                    }
                }
                tail = (tail + 1) % bufferSize;
            }

            tail = head;

            //if (buffer[head] == '\n')
            //{
            //    if (CircularBuffer.isPreviousCarriage())
            //    {
            //        return CircularBuffer.isCrcCorrect();
            //    }
            //}
            return false;
        }

        //public static bool isNextNewline()
        //{
        //    if (head == 0)
        //    {
        //        return (buffer[255] == '\r');
        //    }
        //    else
        //    {
        //        return buffer[head - 1] == '\r';
        //    }
        //}

        public static bool isCrcCorrect(int tailIndex)
        {
            byte[] tempBuffer = new byte[dataLenght];
            int index = 0;

            for(int i = 0; i < dataLenght; i++)
            {
                index = (tailIndex - 24 + i) % bufferSize;

                if(index < 0)
                {
                    tempBuffer[i] = buffer[bufferSize + index];
                }
                else
                {
                    tempBuffer[i] = buffer[index];
                }
            }

            tail = head;

            ushort crcVal = (ushort)((tempBuffer[21] << 0) | (tempBuffer[22] << 8));
            ushort calculatedCrc = crc.AE_PEC15(tempBuffer, 21);
            if (crcVal == calculatedCrc)
            {
                dataBuffer = tempBuffer;
                return true;
            }

            return false;
        }

        public static UgvDatas getParsedDatas()
        {
            int u8Tou32;

            ugvDatas.azimuth = (dataBuffer[0] << 0) | (dataBuffer[1] << 8);
            ugvDatas.latitudeDegree = dataBuffer[2];
            ugvDatas.latitudeMinute = dataBuffer[3];

            u8Tou32 = (dataBuffer[4] << 0) | (dataBuffer[5] << 8) | (dataBuffer[6] << 16) | (dataBuffer[7] << 24);
            ugvDatas.latitudeSecond = hexToFloat(u8Tou32);

            ugvDatas.longitudeDegree = dataBuffer[8];
            ugvDatas.longitudeMinute = dataBuffer[9];

            u8Tou32 = (dataBuffer[10] << 0) | (dataBuffer[11] << 8) | (dataBuffer[12] << 16) | (dataBuffer[13] << 24);
            ugvDatas.longitudeSecond = hexToFloat(u8Tou32);

            ugvDatas.numberOfSatellite = dataBuffer[14];

            u8Tou32 = (dataBuffer[15] << 0) | (dataBuffer[16] << 8) | (dataBuffer[17] << 16) | (dataBuffer[18] << 24);
            ugvDatas.speed = hexToFloat(u8Tou32);

            ugvDatas.ledState = (LedStates)dataBuffer[19];
            ugvDatas.gpsState = (GpsState)dataBuffer[20];

            return ugvDatas;
        }

        private static float hexToFloat(int number)
        {
            byte[] bytes = BitConverter.GetBytes(number);

            return BitConverter.ToSingle(bytes, 0);
        }
    }
}
