using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using XCare.DMS.Receiving.MessageService;

namespace XCare.DMS.Receiving.Api
{
    // 注意: 有关启用 IIS6 或 IIS7 经典模式的说明，
    // 请访问 http://go.microsoft.com/?LinkId=9394801
    /// <summary>
    /// 
    /// </summary>
    public class MvcApplication : HttpApplication
    {
        /// <summary>
        /// 
        /// </summary>
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            MessagePublisher.Start();
        }

        /// <summary>
        /// 
        /// </summary>
        protected void Application_End()
        {
            MessagePublisher.Stop();
        }
    }
}