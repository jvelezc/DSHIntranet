using System.Web.Mvc;

namespace DSH.Intranet.Web.Areas.Atascadero
{
    public class AtascaderoAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Atascadero";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Atascadero_default",
                "Atascadero/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
