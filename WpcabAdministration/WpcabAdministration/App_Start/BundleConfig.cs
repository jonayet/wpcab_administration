using System.Web;
using System.Web.Optimization;

namespace WpcabAdministration
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
                      "~/Content/site.css"));

            /******** Mullti column theme *******/
            bundles.Add(new StyleBundle("~/Content/css-multicolumn").Include(
                      "~/Content/bootstrap-2.1.0-multicolumn/bootstrap.css",
                      "~/Content/bootstrap-2.1.0-multicolumn/bootstrap-responsive.css"));

            bundles.Add(new ScriptBundle("~/bundles/js-multicolumn").Include(
                      "~/Scripts/bootstrap-2.1.0-multicolumn/bootstrap.min.js",
                      "~/Scripts/bootstrap-2.1.0-multicolumn/jquery-1.8.0.min.js"));
            /******** Mullti column theme *******/

            /******** Date Time picker *******/
            bundles.Add(new StyleBundle("~/Content/css-datetimepicker").Include(
                "~/Content/datetimepicker/jquery.datetimepicker.css"));

            bundles.Add(new ScriptBundle("~/bundles/js-datetimepicker").Include(
                "~/Scripts/datetimepicker/jquery.datetimepicker.js"));           
            /******** Date Time picker *******/

            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = true;
        }
    }
}
