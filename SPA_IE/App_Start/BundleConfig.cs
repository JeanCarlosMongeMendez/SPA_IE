using System.Web.Optimization;

namespace SPA_IE
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jqueryajax").Include(
                        "~/Scripts/jquery.unobtrusive*"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                        "~/Content/js/jquery.js",
                        "~/Content/js/bootstrap.min.js",
                        "~/Content/js/owl.carousel.min.js",
                        "~/Content/js/smoothscroll.js",
                        "~/Content/js/custom.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/css/template").Include(
                        "~/Content/css/bootstrap.min.css",
                        "~/Content/css/font-awesome.min.css",
                        "~/Content/css/owl.carousel.css",
                        "~/Content/css/owl.theme.default.min.css",
                        "~/Content/css/templatemo-style.css"));
        }
    }
}
