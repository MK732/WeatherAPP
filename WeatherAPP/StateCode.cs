using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAPP
{
    public class StateCode
    {
        public class places
        {
            [JsonProperty(PropertyName = "state abbreviation")]
            public string? stateabrv { get; set; }
        }

        public class root
        {
           
            public List<places>? places { get; set; }
        }
    }
}
