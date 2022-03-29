using System;

using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace Twilio_AMD_Execution
{
    class Program
    {
        static void Main(string[] args)
        {
            const string accountSid = "AC1aa8e96d96a5fa1f2da662b17d79133d";
            const string authToken = "8f92f12ae74047a2afb37d22fc127490";
            TwilioClient.Init(accountSid, authToken);
            var call = CallResource.Create(
                machineDetection: "Enable",
                url: new Uri("https://handler.twilio.com/twiml/EH8ccdbd7f0b8fe34357da8ce87ebe5a16"),
                to: new Twilio.Types.PhoneNumber("+919989900848"),
                from: new Twilio.Types.PhoneNumber("+16062680172")
            );

            Console.WriteLine(call.Sid);
        }
    }
}
