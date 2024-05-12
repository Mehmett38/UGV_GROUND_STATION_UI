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
        private static int bufferSize = 512;
        private static int dataLenght = 52;
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
                index = (tailIndex - 51 + i) % bufferSize;

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

            ushort crcVal = (ushort)((tempBuffer[48] << 0) | (tempBuffer[49] << 8));
            ushort calculatedCrc = crc.AE_PEC15(tempBuffer, 48);
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
            ugvDatas.numberOfSatellite = dataBuffer[10];
            ugvDatas.second = dataBuffer[11];

            u8Tou32 = (dataBuffer[12] << 0) | (dataBuffer[13] << 8) | (dataBuffer[14] << 16) | (dataBuffer[15] << 24);
            ugvDatas.longitudeSecond = hexToFloat(u8Tou32);

            u8Tou32 = (dataBuffer[16] << 0) | (dataBuffer[17] << 8) | (dataBuffer[18] << 16) | (dataBuffer[19] << 24);
            ugvDatas.speed = hexToFloat(u8Tou32);

            u8Tou32 = (dataBuffer[20] << 0) | (dataBuffer[21] << 8) | (dataBuffer[22] << 16) | (dataBuffer[23] << 24);
            ugvDatas.aX = hexToFloat(u8Tou32);

            u8Tou32 = (dataBuffer[24] << 0) | (dataBuffer[25] << 8) | (dataBuffer[26] << 16) | (dataBuffer[27] << 24);
            ugvDatas.aY = hexToFloat(u8Tou32);

            u8Tou32 = (dataBuffer[28] << 0) | (dataBuffer[29] << 8) | (dataBuffer[30] << 16) | (dataBuffer[31] << 24);
            ugvDatas.temperature = hexToFloat(u8Tou32);

            u8Tou32 = (dataBuffer[32] << 0) | (dataBuffer[33] << 8) | (dataBuffer[34] << 16) | (dataBuffer[35] << 24);
            ugvDatas.kalmanX = hexToFloat(u8Tou32);

            u8Tou32 = (dataBuffer[36] << 0) | (dataBuffer[37] << 8) | (dataBuffer[38] << 16) | (dataBuffer[39] << 24);
            ugvDatas.kalmanY = hexToFloat(u8Tou32);

            ugvDatas.minute = dataBuffer[40];
            ugvDatas.hour = dataBuffer[41];
            ugvDatas.day = dataBuffer[42];
            ugvDatas.month = dataBuffer[43];

            ugvDatas.locationLat = (Location)dataBuffer[44];
            ugvDatas.locationLong = (Location)dataBuffer[45];
            ugvDatas.ledState = (LedStates)dataBuffer[46];
            ugvDatas.gpsState = (GpsState)dataBuffer[47];

            return ugvDatas;
        }

        private static float hexToFloat(int number)
        {
            byte[] bytes = BitConverter.GetBytes(number);

            return BitConverter.ToSingle(bytes, 0);
        }
    }
}
