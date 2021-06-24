using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApp.Models
{
    public class ClimacellResponse
    {
        public double lat { get; set; }
        public double lon { get; set; }
        public Hashtable temp { get; set; }
        public Hashtable precipitation { get; set; }
        public Hashtable observation_time { get; set; }
    }
}
