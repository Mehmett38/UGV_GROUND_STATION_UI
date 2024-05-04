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
            if (buffer[head] == '\n')
            {
                if (CircularBuffer.isPreviousCarriage())
                {
                    return CircularBuffer.isCrcCorrect();
                }
            }
            return false;
        }

        public static bool isPreviousCarriage()
        {
            if (head == 0)
            {
                return (buffer[255] == '\r');
            }
            else
            {
                return buffer[head - 1] == '\r';
            }
        }

        public static bool isCrcCorrect()
        {
            byte[] tempBuffer = new byte[dataLenght];

            for(int i = 0; i < dataLenght; i++)
            {
                tempBuffer[i] = buffer[((tail + i + 1) % dataLenght)];
            }

            tail = head;

            ushort crcVal = (ushort)((tempBuffer[21] << 0) | (tempBuffer[22] << 8));
            ushort calculatedCrc = crc.AE_PEC15(tempBuffer, 21);
            if (crcVal == calculatedCrc)
            {
                return true;
            }

            return false;
        }
    }
}
