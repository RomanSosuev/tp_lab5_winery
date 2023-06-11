using System.Web;
using System.Web.Mvc;

namespace WebApplicationLab5True
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
