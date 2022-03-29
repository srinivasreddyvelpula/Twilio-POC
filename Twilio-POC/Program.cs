using System;

using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace Twilio_POC
{
    class Program
    {
        static void Main(string[] args)
        {
            const string accountSid = "AC1aa8e96d96a5fa1f2da662b17d79133d";
            const string authToken = "8f92f12ae74047a2afb37d22fc127490";
            TwilioClient.Init(accountSid, authToken);

            var to = new PhoneNumber("+919989900848");
            var from = new PhoneNumber("+16062680172");
            var call = CallResource.Create(to, from,
                url: new Uri("http://demo.twilio.com/docs/voice.xml"));

            Console.WriteLine(call.Sid);
        }
    }
}
