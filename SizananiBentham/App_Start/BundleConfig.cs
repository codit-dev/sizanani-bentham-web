using System.Web;
using System.Web.Optimization;

namespace SizananiBentham
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Scripts
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-3.3.1.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/popper").Include(
                      "~/Scripts/popper*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap*"));

            bundles.Add(new ScriptBundle("~/bundles/magnific-popup").Include(
                      "~/Scripts/jquery.magnific-popup*"));

            bundles.Add(new ScriptBundle("~/bundles/owl-carousel").Include(
                      "~/Scripts/owl.carousel*"));

            bundles.Add(new ScriptBundle("~/bundles/rangeslider").Include(
                      "~/Scripts/rangeslider*"));

            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                      "~/Scripts/custom.js"));

            // Stylesheets
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap*",
                      "~/Content/font-awesome/css/font-awesome.min.css",
                      "~/Content/magnific-popup.css",
                      "~/Content/OwlCarousel/owl.carousel.css",
                      "~/Content/OwlCarousel/owl.theme.css",
                      "~/Content/rangeslider.css",
                      "~/Content/style.css",
                      "~/Content/responsive.css",
                      "~/Content/custom-styles.css"));
        }
    }
}
