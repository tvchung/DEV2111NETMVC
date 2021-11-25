using System.Web;
using System.Web.Mvc;

namespace Lesson02_2_ControllerDemo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
