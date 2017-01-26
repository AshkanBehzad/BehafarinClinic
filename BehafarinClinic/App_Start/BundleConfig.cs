using System.Web;
using System.Web.Optimization;

namespace BehafarinClinic
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/app.css",
                      "~/Content/site.css"));



            //Persian Datepicker
            bundles.Add(new ScriptBundle("~/bundles/persian-datepicker").Include(
                "~/Scripts/persian-date.js",
                "~/Scripts/persian-datepicker-0.4.5.min.js"));
            bundles.Add(new StyleBundle("~/Content/persian-datepicker").Include(
                "~/Content/persian-datepicker-blue.css",
                "~/Content/persian-datepicker-0.4.5.min.css"));

            //app-sb
            bundles.Add(new ScriptBundle("~/bundles/app-sb").Include(
               "~/Scripts/app-sb.js"));
            bundles.Add(new StyleBundle("~/Content/app-sb").Include(
                "~/Content/app-sb.css"));

            //font-awsome
            bundles.Add(new StyleBundle("~/Content/font-awsome").Include(
               "~/Content/fonts/font-awesome/font-awesome.min.css"));
            //metisMenu
            bundles.Add(new ScriptBundle("~/bundles/metisMenu").Include(
               "~/Scripts/metisMenu.min.js"));
            
        }
        
    
   

    }
}
