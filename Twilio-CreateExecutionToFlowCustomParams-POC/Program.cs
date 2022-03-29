using System;
using System.Collections.Generic;

using Twilio;
using Twilio.Rest.Studio.V2.Flow;

namespace Twilio_CreateExecutionToFlowCustomParams_POC
{
    class Program
    {
        static void Main(string[] args)
        {
            const string accountSid = "AC1aa8e96d96a5fa1f2da662b17d79133d";
            const string authToken = "8f92f12ae74047a2afb37d22fc127490";
            TwilioClient.Init(accountSid, authToken);
            var parameters = new Dictionary<string, Object>()
        {
            {"foo", "bar"}
        };

            var execution = ExecutionResource.Create(
                parameters: parameters,
                 to: new Twilio.Types.PhoneNumber("+919989900848"),
                from: new Twilio.Types.PhoneNumber("+16062680172"),
                pathFlowSid: "FW04c5eec75817c059cb5010ae756047d0"
            );

            Console.WriteLine(execution.Sid);
        }
    }
}
