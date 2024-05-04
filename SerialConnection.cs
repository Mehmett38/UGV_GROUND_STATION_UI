using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvionicsInstrumentControlDemo
{
    public class SerialConnection
    {
        public string portName { get; set; }
        public int baudrate { get; set; }
        public int dataBits { get; set; }
        public Parity parity{ get; set; }
        public StopBits stopBit { get; set; }
    }
}
