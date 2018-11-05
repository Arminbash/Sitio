using System.Web;
using System.Web.Optimization;

namespace muestra
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, consulte http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));
            //bundles de la libreria JS
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                        "~/Scripts/js/libraries/jquery.min.js",
                        "~/Scripts/js/ui/tether.min.js",
                        "~/Scripts/js/libraries/bootstrap.min.js",
                        "~/Scripts/js/ui/perfect-scrollbar.jquery.min.js",
                        "~/Scripts/js/ui/unison.min.js",
                        "~/Scripts/js/ui/blockUI.min.js",
                        "~/Scripts/js/ui/jquery.matchHeight-min.js",
                        "~/Scripts/js/ui/screenfull.min.js",
                        "~/Scripts/js/extensions/pace.min.js",
                        "~/Scripts/js/charts/chart.min.js",
                        "~/Scripts/js/app-menu.js",
                        "~/Scripts/js/app.js",
                        "~/Scripts/js/line.js",
                        "~/Scripts/js/pages/dashboard-lite.js"
                        ));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información sobre los formularios. De este modo, estará
            // preparado para la producción y podrá utilizar la herramienta de compilación disponible en http://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            //bundles de la libreria Style
            bundles.Add(new StyleBundle("~/Content/style").Include(
                      "~/Content/styles/bootstrap.css",
                      "~/Content/styles/fonts/font-awesome.min.css",
                      "~/Content/styles/extensions/pace.css",
                      "~/Content/styles/bootstrap-extended.css",
                      "~/Content/styles/app.css",
                      "~/Content/styles/colors.css",
                      "~/Content/styles/menu/vertical-menu.css",
                      "~/Content/styles/menu/vertical-overlay-menu.css",
                      "~/Content/styles/colors/palette-gradient.css",
                      "~/Content/styles/style.css"));
        }
    }
}
