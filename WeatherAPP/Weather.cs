using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAPP
{
    public class Weather
    {
       // public string? name { get; set; }
      

        public class coord 
        {
            public double lon { get; set; }
            public double lat { get; set; }
        }
        public class weather
        {
            public int id { get; set; }
            public string? main { get; set; }
            public string? description { get; set; }
            public string? icon { get; set; }

        }
        public class main
        {
            public double temp { get; set; }
            public double feels_like { get; set; }
            public double temp_min { get; set; }
            public double temp_max { get; set; }
            public int pressure { get; set; }
            public int humidity { get; set; }
        }

        public class wind
        {
            public double speed { get; set; }
            public int deg { get; set; }
        }
        public class sys
        {
            public int cod { get; set; }
            
        }


        public class root
        {
            public coord? coord { get; set; }
            public List <weather>? Weather { get; set; }
            public main? main { get; set; }
            public sys? sys { get; set; }
            public string? name { get; set; }
           
        }
    }
}
