using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace TelldusLiveMVC.Helpers
{
    public class ConfigHelper
    {
        public static string TelldusLiveConsumerKey
        {
            get
            {
                return ConfigurationManager.AppSettings["TelldusLiveConsumerKey"].ToString();
            }
        }

        public static string TelldusLiveConsumerSecret
        {
            get
            {
                return ConfigurationManager.AppSettings["TelldusLiveConsumerSecret"].ToString();
            }
        }
    }
}