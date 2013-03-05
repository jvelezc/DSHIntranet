using System.Web.Mvc;

namespace DSH.Intranet.Web.Areas.ErrorHandler
{
    public class ErrorHandlerAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "ErrorHandler";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "ErrorHandler_default",
                "ErrorHandler/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
