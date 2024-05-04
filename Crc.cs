using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvionicsInstrumentControlDemo
{
    public class Crc
    {
        private const ushort CRC15_POLY = 0x4599;
        private ushort[] pec15Table = new ushort[256];
            
        public Crc()
        {
            ushort remainder;
            ushort bit;
            for (ushort i = 0; i < 256; i++)
            {
                remainder = (ushort)(i << 7);
                for (bit = 8; bit > 0; --bit)
                {
                    if ((remainder & 0x4000) != 0)
                    {
                        remainder = (ushort)((remainder << 1) ^ CRC15_POLY);
                    }
                    else
                    {
                        remainder = (ushort)(remainder << 1);
                    }
                }
                pec15Table[i] = (ushort)(remainder & 0xFFFF);
            }
        }

        public ushort AE_PEC15(byte[] data, ushort len)
        {
            ushort remainder = 16; // PEC seed
            ushort address;
            for (int i = 0; i < len; i++)
            {
                address = (ushort)(((remainder >> 7) ^ data[i]) & 0xFF); // calculate PEC table address 
                remainder = (ushort)((remainder << 8) ^ pec15Table[address]);
            }
            return (ushort)(remainder * 2); // The CRC15 has a 0 in the LSB so the final value must be multiplied by 2
        }
    }
}
