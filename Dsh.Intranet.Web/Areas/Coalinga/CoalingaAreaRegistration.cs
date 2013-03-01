using System.Web.Mvc;

namespace DSH.Intranet.Web.Areas.Coalinga
{
    public class CoalingaAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Coalinga";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {

            context.MapRoute(
                "Coalinga_default",
                "Coalinga/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
