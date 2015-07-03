using System.Web;
using System.Web.Mvc;

namespace CIT.ERP.Solucion
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
