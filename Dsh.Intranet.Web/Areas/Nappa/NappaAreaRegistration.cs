using System.Web.Mvc;

namespace DSH.Intranet.Web.Areas.Nappa
{
    public class NappaAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Nappa";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Nappa_default",
                "Nappa/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
