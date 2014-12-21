using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelldusLiveMVC.Helpers
{
    public class TelldusLiveHelper
    {
        public static string OAuthToken
        {
            get
            {
                if (HttpContext.Current.Request.Cookies.AllKeys.Contains("TelldusLiveOAuthToken"))
                {
                    return HttpContext.Current.Request.Cookies["TelldusLiveOAuthToken"].Value;
                }
                else
                {
                    return string.Empty;
                }
            }
            set
            {
                if (HttpContext.Current.Request.Cookies.AllKeys.Contains("TelldusLiveOAuthToken"))
                {
                    HttpCookie cookie = HttpContext.Current.Request.Cookies["TelldusLiveOAuthToken"];
                    cookie.Value = value;
                    HttpContext.Current.Response.SetCookie(cookie);
                }
                else
                {
                    HttpCookie cookie = new HttpCookie("TelldusLiveOAuthToken", value);

                    HttpContext.Current.Response.Cookies.Add(cookie);
                }
            }
        }

        public static string OAuthTokenSecret
        {
            get
            {
                if (HttpContext.Current.Request.Cookies.AllKeys.Contains("TelldusLiveOAuthTokenSecret"))
                {
                    return HttpContext.Current.Request.Cookies["TelldusLiveOAuthTokenSecret"].Value;
                }
                else
                {
                    return string.Empty;
                }
            }
            set
            {
                if (HttpContext.Current.Request.Cookies.AllKeys.Contains("TelldusLiveOAuthTokenSecret"))
                {
                    HttpCookie cookie = HttpContext.Current.Request.Cookies["TelldusLiveOAuthTokenSecret"];
                    cookie.Value = value;
                    HttpContext.Current.Response.SetCookie(cookie);
                }
                else
                {
                    HttpCookie cookie = new HttpCookie("TelldusLiveOAuthTokenSecret", value);

                    HttpContext.Current.Response.Cookies.Add(cookie);
                }
            }
        }
    }
}