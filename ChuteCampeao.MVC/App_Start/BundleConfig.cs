using System.Web;
using System.Web.Optimization;

namespace ChuteCampeao.MVC
{
    public class BundleConfig
    {
        // Para obter mais informações sobre o agrupamento, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-3.3.1.min.js",
                        "~/Scripts/jquery-ui-1.12.1.min.js",
                        "~/Scripts/jquery.maskedinput.min.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/moment").Include(
                        "~/Scripts/moment.min.js",
                        "~/Scripts/moment-with-locales.min.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*",
                        "~/Scripts/custom_methods_validation.js"
                        ));

            // Use a versão em desenvolvimento do Modernizr para desenvolver e aprender. Em seguida, quando estiver
            // pronto para a produção, utilize a ferramenta de build em https://modernizr.com para escolher somente os testes que precisa.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/time").Include(
                       "~/Scripts/time.js"
                       ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/themes/base/all.css",
                      "~/Content/site.css"
                      ));

            bundles.Add(new StyleBundle("~/Content/datatables").Include(
                      "~/Content/DataTables/css/dataTables.bootstrap4.min.css",
                      "~/Content/DataTables/css/responsive.bootstrap4.min.css"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/datatables").Include(
                        "~/Scripts/DataTables/jquery.dataTables.min.js",
                        "~/Scripts/DataTables/dataTables.bootstrap4.min.js",                       
                        "~/Scripts/DataTables/dataTables.responsive.min.js",
                         "~/Scripts/DataTables/responsive.bootstrap4.min.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                        "~/Scripts/bootstrap.min.js"
                        ));


            bundles.Add(new ScriptBundle("~/bundles/sweetalerts").Include(
                        "~/Scripts/promise-polyfill.js",
                        "~/Scripts/sweetalert2.all.min.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/utils").Include(
                        "~/Scripts/utils.js"
                        ));
        }
    }
}
