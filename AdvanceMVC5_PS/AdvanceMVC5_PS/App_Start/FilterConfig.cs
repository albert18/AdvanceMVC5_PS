using System.Web;
using System.Web.Mvc;

namespace AdvanceMVC5_PS
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
