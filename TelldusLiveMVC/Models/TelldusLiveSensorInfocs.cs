using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelldusLiveMVC.Models
{
    public class TelldusLiveSensorInfo
    {
        public int id { get; set; }
        public string clientName { get; set; }
        public string name { get; set; }
        public string lastUpdated { get; set; }
        public int ignored { get; set; }
        public int editable { get; set; }
        public string protocol { get; set; }
        public int sensorId { get; set; }
        public int timezoneoffset { get; set; }
        public List<TelldusLiveSensorInfoData> data { get; set; }
    }

    public class TelldusLiveSensorInfoData
    {
        public string name { get; set; }
        public string value { get; set; }
    }
}