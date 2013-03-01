using System.Web.Mvc;

namespace DSH.Intranet.Web.Areas.Metro
{
    public class MetroAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Metro";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Metro_default",
                "Metro/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
