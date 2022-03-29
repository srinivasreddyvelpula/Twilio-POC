
namespace Twilio_Gatherinput_POC.Controllers
{
    // In Package Manager, run:
    // Install-Package Twilio.AspNet.Mvc -DependencyVersion HighestMinor

    using System.Web.Mvc;
    using Twilio.AspNet.Common;
    using Twilio.TwiML;
    using System;
    using Twilio.AspNet.Core;

    public class VoiceController : TwilioController
    {
        [HttpPost]
        public TwiMLResult Index()
        {
            var response = new VoiceResponse();

            // Use the <Gather> verb to collect user input
            response.Gather(numDigits: 1)
                            .Say("For srinivas, press 1. For reddy, press 2.");
            // If the user doesn't enter input, loop
            response.Redirect(new Uri("/voice", UriKind.Relative));

            return TwiML(response);
        }
    }

}