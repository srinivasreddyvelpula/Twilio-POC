using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Twilio.AspNet.Mvc;
using Twilio.TwiML;

namespace Twilio_RecieveCalls_POC.Controllers
{
    public class VoiceController : TwilioController
    {
        [HttpPost]
        public ActionResult Index()
        {
            var response = new VoiceResponse();
            response.Say("Thank you for calling reddy! Have a great day.");
            return TwiML(response);
        }
    }
}