using System.Web;
using System.Web.Optimization;

namespace DSH.Intranet.Web
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Force optimization to be on or off, regardless of web.config setting
            //BundleTable.EnableOptimizations = false;
            bundles.UseCdn = false;

            // .debug.js, -vsdoc.js and .intellisense.js files 
            // are in BundleTable.Bundles.IgnoreList by default.
            // Clear out the list and add back the ones we want to ignore.
            // Don't add back .debug.js.
            bundles.IgnoreList.Clear();
            bundles.IgnoreList.Ignore("*-vsdoc.js");
            bundles.IgnoreList.Ignore("*intellisense.js");

            // Modernizr goes separate since it loads first
            bundles.Add(new ScriptBundle("~/bundles/modernizr")
                .Include("~/Scripts/modernizr-{version}.js"));

            // jQuery
            bundles.Add(new ScriptBundle("~/bundles/jquery")
                .Include("~/Scripts/jquery-{version}.min.js"));

            // jQuery UI
            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
            "~/Scripts/jquery-ui-{version}.min.js"));

            // jQuery Validation
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            "~/Scripts/jquery.unobtrusive*",
            "~/Scripts/jquery.validate*"));

            //BootStrap JS -basic javascript functionality
            bundles.Add(new ScriptBundle("~/bundles/bootstrap.js").Include("~/Scripts/bootstrap.min.js"));
        


            // 3rd Party JavaScript files
            bundles.Add(new ScriptBundle("~/bundles/jsextlibs")
                .Include(
                    "~/Scripts/json2.js", // IE7 needs this

                    // jQuery plugins
                    "~/Scripts/TrafficCop.js",
                    "~/Scripts/jquery.ba-hashchange.min.js",
                    "~/Scripts/jquery.blockUI.js",

                    // Knockout and its plugins
                    "~/Scripts/knockout-{version}.js",
                    "~/Scripts/infuser.min.js",
                    "~/Scripts/koExternalTemplateEngine_all.js",

                    // Other 3rd party libraries
                    "~/Scripts/jquery.easing.1.3.js",
                    "~/Scripts/jquery.dateFormat-1.0.js"
                    ));

            // Author application JS files
            bundles.Add(new ScriptBundle("~/bundles/jsapplibs")

                .Include(

                // Application startup JS goes first to declare global my namespace
                "~/Scripts/custom/DSHIntranet.startup.js",

                // Other application JS
                "~/Scripts/custom/DSHIntranet.dataservice.js",
                "~/Scripts/custom/DSHIntranet.model.js",
                "~/Scripts/custom/DSHIntranet.viewmodel.js",
                "~/Scripts/custom/DSHIntranet.serializer.js",

                // Application initialize JS goes last
                "~/Scripts/custom/DSHIntranet.initialize.js"

                ));

            // HTML Boilerplate styles
            bundles.Add(new StyleBundle("~/Content/boilerplate-css")
                .Include(
                "~/Content/boilerplate/boilerplate-main.css",
                "~/Content/boilerplate/boilerplate-normalize.css"
                ));

            // Author styles   +  //BootStrap CSS
            bundles.Add(new StyleBundle("~/Content/css")
                .Include(
                "~/Content/site.css",
                "~/Content/bootstrap/bootstrap.min.css",
                "~/Content/bootstrap/bootstrap-responsive.min.css"
                ));

            // jQuery UI styles
            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));
        }
    }
}