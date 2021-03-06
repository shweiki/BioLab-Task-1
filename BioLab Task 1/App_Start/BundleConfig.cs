using System.Web;
using System.Web.Optimization;

namespace BioLab_Task_1
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
         bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/popper.min.js",
                         "~/Scripts/perfect-scrollbar.jquery.min.js",
                         "~/Scripts/waves.js",
                         "~/Scripts/sidebarmenu.js",
                         "~/Scripts/sticky-kit.min.js",
                         "~/Scripts/jquery.sparkline.min.js",
                         "~/Scripts/custom.min.js"
                        ));
        bundles.Add(new Bundle("~/bundles/bootstrap").Include(
                         "~/Scripts/bootstrap.min.js"
                         ));

         bundles.Add(new ScriptBundle("~/bundles/plugins").Include(
                        "~/Scripts/switchery/dist/switchery.min.js",
                        "~/Scripts/select2/dist/js/select2.full.min.js",
                        "~/Scripts/bootstrap-select/bootstrap-select.min.js",
                        "~/Scripts/bootstrap-tagsinput/dist/bootstrap-tagsinput.min.js",
                        "~/Scripts/bootstrap-touchspin/dist/jquery.bootstrap-touchspin.js",
                        "~/Scripts/dff/dff.js",
                        "~/Scripts/multiselect/js/jquery.multi-select.js",
                        "~/Scripts/moment/moment.js",
                        "~/Scripts/clockpicker/dist/jquery-clockpicker.min.js",
                        "~/Scripts/jquery-asColor/dist/jquery-asColor.js",
                        "~/Scripts/jquery-asGradient/dist/jquery-asGradient.js",
                        "~/Scripts/jquery-asColorPicker-master/dist/jquery-asColorPicker.min.js",
                        "~/Scripts/bootstrap-datepicker/bootstrap-datepicker.min.js",
                        "~/Scripts/timepicker/bootstrap-timepicker.min.js",
                        "~/Scripts/daterangepicker/daterangepicker.js"   ,
                        "~/Scripts/Custom/FixedParameter.js",
                        "~/Scripts/Custom/InstallSalariesAndSocialSecurity.js",
                        "~/Scripts/Custom/PremiumsDiscountsStaff.js"
                         ));

      
         bundles.Add(new StyleBundle("~/Content/css").Include(
                        "~/Content/bootstrap.min.css",
                        "~/Content/bootstrap-material-datetimepicker/css/bootstrap-material-datetimepicker.css",
                        "~/Content/clockpicker/dist/jquery-clockpicker.min.css",
                        "~/Content/jquery-asColorPicker-master/dist/css/asColorPicker.css",
                        "~/Content/bootstrap-datepicker/bootstrap-datepicker.min.css",
                        "~/Content/select2/dist/css/select2.min.css",
                        "~/Content/switchery/dist/switchery.min.css",
                        "~/Content/bootstrap-select/bootstrap-select.min.css",
                        "~/Content/bootstrap-tagsinput/dist/bootstrap-tagsinput.css",
                        "~/Content/bootstrap-touchspin/dist/jquery.bootstrap-touchspin.min.css",
                        "~/Content/multiselect/css/multi-select.css",
                        "~/Content/timepicker/bootstrap-timepicker.min.css",
                        "~/Content/daterangepicker/daterangepicker.css",
                        "~/Content/css/style.css",
                        "~/Content/css/pages/tab-page.css",
                        "~/Content/css/colors/default.css"
                        ));
        }
    }
}
