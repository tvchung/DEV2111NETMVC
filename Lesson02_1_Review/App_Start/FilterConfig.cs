using System.Web;
using System.Web.Mvc;

namespace Lesson02_1_Review
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
