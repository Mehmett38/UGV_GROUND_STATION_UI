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
        public int numberOfSatellite { get; set; }
        public int second { get; set; }
        public float longitudeSecond { get; set; }
        public float speed { get; set; }
        public float aX { get; set; }
        public float aY { get; set; }
        public float temperature { get; set; }
        public float kalmanX { get; set; }
        public float kalmanY { get; set; }
        public int minute { get; set; }
        public int hour { get; set; }
        public int day { get; set; }
        public int month { get; set; }
        public Location locationLat { get; set; }
        public Location locationLong{ get; set; }
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

    public enum Location
    {
        NORTH,
        SOUTH,
        EAST,
        WEST
    }

}
