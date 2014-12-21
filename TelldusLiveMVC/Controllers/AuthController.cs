using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TelldusLiveMVC.Helpers;

namespace TelldusLiveMVC.Controllers
{
    public class AuthController : Controller
    {
        //
        // GET: /Auth/

        private const string OAuthTokenKey = "oauth_token";
        private const string OAuthTokenSecretKey = "oauth_token_secret";

        string baseUrl = "http://api.telldus.com/";
        
        public ActionResult Index()
        {
            // if request url is null, leave. resharper
            if (Request.Url == null)
            {
                return RedirectToAction("index", "home");
            }

            // build callback url
            var callBack = Url.Action("callback", "auth", routeValues: null, protocol: Request.Url.Scheme);

            var client = new RestClient(baseUrl);

            client.Authenticator = OAuth1Authenticator.ForRequestToken(ConfigHelper.TelldusLiveConsumerKey, ConfigHelper.TelldusLiveConsumerSecret, callBack);

            var request = new RestRequest("oauth/requestToken", Method.POST);
            var response = client.Execute(request);

            var qs = HttpUtility.ParseQueryString(response.Content);
            var oauth_token = qs["oauth_token"];
            var oauth_token_secret = qs["oauth_token_secret"];

            TelldusLiveHelper.OAuthToken = oauth_token;
            TelldusLiveHelper.OAuthTokenSecret = oauth_token_secret;

            request = new RestRequest("oauth/authorize");
            request.AddParameter("oauth_token", oauth_token);

            var url = client.BuildUri(request).ToString();

            // send to singly
            return Redirect(url);
        }

        public ActionResult Callback(string oauth_token, string oauth_verifier)
        {
            string oauth_token_secret = TelldusLiveHelper.OAuthTokenSecret;

            // setup rest request for oauth token
            var client = new RestClient(baseUrl);

            client.Authenticator = OAuth1Authenticator.ForAccessToken(ConfigHelper.TelldusLiveConsumerKey, ConfigHelper.TelldusLiveConsumerSecret, oauth_token, oauth_token_secret, oauth_verifier);

            var request = new RestRequest("oauth/accessToken", Method.POST);

            // execute rest request
            var response = client.Execute(request);
            var content = response.Content;
            
            var qs = HttpUtility.ParseQueryString(response.Content);
            oauth_token = qs["oauth_token"];
            oauth_token_secret = qs["oauth_token_secret"];

            TelldusLiveHelper.OAuthToken = oauth_token;
            TelldusLiveHelper.OAuthTokenSecret = oauth_token_secret;

            // send them to dashboard
            return RedirectToAction("ListDevices", "TelldusLive");
        }
    }
}