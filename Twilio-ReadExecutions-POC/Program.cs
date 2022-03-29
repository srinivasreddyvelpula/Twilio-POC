using System;

using Twilio;
using Twilio.Rest.Studio.V2.Flow;

namespace Twilio_ReadExecutions_POC
{
    class Program
    {
        static void Main(string[] args)
        {
            const string accountSid = "AC1aa8e96d96a5fa1f2da662b17d79133d";
            const string authToken = "8f92f12ae74047a2afb37d22fc127490";
            TwilioClient.Init(accountSid, authToken);

            var executions = ExecutionResource.Read(
                pathFlowSid: "FW04c5eec75817c059cb5010ae756047d0",
                limit: 20
            );

            foreach (var record in executions)
            {
                Console.WriteLine(record.Sid);
            }
        }
    }
}
