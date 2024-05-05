using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvionicsInstrumentControlDemo
{
    public class UgvDatas
    {
        public int azimuth { get; set; }
        public int latitudeDegree { get; set; }
        public int latitudeMinute { get; set; }
        public float latitudeSecond { get; set; }
        public int longitudeDegree { get; set; }
        public int longitudeMinute { get; set; }
        public float longitudeSecond { get; set; }

        public int numberOfSatellite { get; set; }
        public float speed { get; set; }
        public int MyProperty { get; set; }

        public LedStates ledState{ get; set; }
        public GpsState gpsState { get; set; }
    }

    public enum LedStates
    {
        LEDS_OFF,
        FRONT_LED_ON,
        ALL_LED_ON,
    }

    public enum GpsState
    {
        NO_CONNECTION,
        WRONG_DATA,
        POSITION_FIXED,
    }

}
