using System.Web.Mvc;

namespace DSH.Intranet.Web.Areas.Patton
{
    public class PattonAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Patton";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Patton_default",
                "Patton/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
