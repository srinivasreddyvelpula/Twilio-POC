using System.Web;
using System.Web.Mvc;

namespace Twilio_RecieveCalls_POC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
