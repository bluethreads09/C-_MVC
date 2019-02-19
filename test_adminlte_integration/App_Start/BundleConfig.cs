using System.Web;
using System.Web.Optimization;

namespace test_adminlte_integration
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
                      "~/Content/css/Site.css"));


            bundles.Add(new StyleBundle("~/AdminLTE/css").Include(
                    "~/AdminLTE/css/AdminLTE.min.css",
                     "~/AdminLTE/css/_all-skins.min.css",
                    "~/AdminLTE/css/bootstrap-datepicker.min.css",
                    "~/AdminLTE/css/bootstrap.css",
                    "~/AdminLTE/css/bootstrap.min.css",
                    "~/AdminLTE/css/daterangepicker.css",
                    "~/AdminLTE/css/font-awesome.css",
                    "~/AdminLTE/css/font-awesome.min.css",
                    "~/AdminLTE/css/ionicons.css",
                    "~/AdminLTE/css/ionicons.min.css",
                    "~/AdminLTE/css/jquery-jvectormap.css",
                    "~/AdminLTE/css/morris.css"));


            bundles.Add(new ScriptBundle("~/AdminLTE/js").Include(
                 "~/AdminLTE/js/jquery.min.js",
             "~/AdminLTE/js/adminlte.min.js",
             "~/AdminLTE/js/bootstrap-datepicker.min.js",
             "~/AdminLTE/js/bootstrap.min.js",
             "~/AdminLTE/js/dashboard.js",
             "~/AdminLTE/js/daterangepicker.js",
             "~/AdminLTE/js/demo.js",
             "~/AdminLTE/js/fastclick.js",
             "~/AdminLTE/js/jquery-jvectormap.js",
             "~/AdminLTE/js/jquery-ui.min.js",
             "~/AdminLTE/js/jquery.knob.min.js",
            
             "~/AdminLTE/js/jquery.slimscroll.min.js",
             "~/AdminLTE/js/jquery.sparkline.min.js",
             "~/AdminLTE/js/moment.js",
             "~/AdminLTE/js/morris.min.js",
             "~/AdminLTE/js/raphael.min.js"));









        }
    }
}
