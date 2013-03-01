using System.Web.Mvc;

namespace DSH.Intranet.Web.Areas.MenuAdmin
{
    public class MenuAdminAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "MenuAdmin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "MenuAdmin_default",
                "MenuAdmin/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
