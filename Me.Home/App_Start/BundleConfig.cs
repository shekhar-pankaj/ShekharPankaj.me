using System.Web;
using System.Web.Optimization;

namespace Me.Home
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            #region Theme
            bundles.Add(new StyleBundle("~/Content/Theme/Nature").Include(
                    "~/Content/Custom/Theme/Nature.css"));
            #endregion

             bundles.Add(new StyleBundle("~/Content/Animation").Include(
                    "~/Content/Custom/animation.css"));


            bundles.Add(new StyleBundle("~/Content/font-awesome").Include(
                "~/fonts/font-awesome-4.7.0/css/font-awesome.css"));


            bundles.Add(new StyleBundle("~/bundles/LayoutViewStyles").Include(
                "~/Content/Custom/Shared/Layout.css"));

        }
    }
}
