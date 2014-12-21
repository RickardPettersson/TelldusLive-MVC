using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelldusLiveMVC.Models
{
    public class TelldusLiveDevices
    {
        public List<TelldusLiveDevice> device { get; set; }
    }
    public class TelldusLiveDevice
    {
        // "{\"device\":[{\"id\":\"692028\",\"clientDeviceId\":\"1\",\"name\":\"Golvlampa Vardagsrum\",\"state\":0,\"statevalue\":\"0\",\"methods\":0,\"type\":\"device\",\"client\":\"139579\",\"clientName\":\"Tellstick Net Hemma\",\"online\":\"1\",\"editable\":1}]}"

        public int id { get; set; }
        public int clientDeviceId { get; set; }
        public string name { get; set;  }
        public int state { get; set; }
        public int statevalue { get; set; }
        public int methods { get; set; }
        public string type { get; set; }
        public int client { get; set; }
        public string clientName { get; set; }
        public int online { get; set; }
        public int editable { get; set; }
    }
}