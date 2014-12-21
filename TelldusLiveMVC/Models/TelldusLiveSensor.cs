using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelldusLiveMVC.Models
{
    public class TelldusLiveSensors
    {
        public List<TelldusLiveSensor> sensor { get; set; }
    }
    public class TelldusLiveSensor
    {
        // {"sensor":[{"id":"2468083","name":"Temp1","lastUpdated":1419148181,"ignored":0,"client":"139579","clientName":"Tellstick Net Hemma","online":"1","editable":1}]}

        public int id { get; set; }
        public string name { get; set;  }
        public string lastUpdated { get; set; }
        public int ignored { get; set; }
        public int client { get; set; }
        public string clientName { get; set; }
        public int online { get; set; }
        public int editable { get; set; }
    }
}