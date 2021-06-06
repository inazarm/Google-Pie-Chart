using System.Web;
using System.Web.Mvc;

namespace Google_Pie_Chart_Report_App
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
