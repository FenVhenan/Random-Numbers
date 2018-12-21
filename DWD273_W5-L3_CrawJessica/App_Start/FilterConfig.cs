using System.Web;
using System.Web.Mvc;

namespace DWD273_W5_L3_CrawJessica
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
