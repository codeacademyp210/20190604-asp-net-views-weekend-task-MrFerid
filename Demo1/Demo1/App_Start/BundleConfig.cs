using System.Web;
using System.Web.Optimization;

namespace Demo1
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/wp-content").Include(
                        "~/Content/wp-content/themes/fortun/js/script5152.js",
                         "~/Content/wp-content/themes/fortun/js/fortune-plugins5152.js",
                        "~/Content/wp-content/plugins/contact-form-7/includes/js/jquery.form.mind03d.js",
                        "~/Content/wp-content/plugins/js_composer/assets/js/dist/js_composer_front.min972f.js"));

            bundles.Add(new ScriptBundle("~/bundles/wp-includes").Include(
                        "~/Content/wp-includes/js/wp-embed.min1f93.js"
                        ));


            bundles.Add(new ScriptBundle("~/bundles/wp-include-up").Include(
                "~/Content/wp-includes/js/jquery/jqueryb8ff.js",
                "~/Content/wp-includes/js/jquery/jquery-migrate.min330a.js"
                        ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/wp-content/plugins/contact-form-7/includes/css/stylesc1f9.css",
                      "~/Content/wp-content/themes/fortun-child/style1f93.css",
                      "~/Content/wp-content/themes/fortun/css/ionicons.min7406.css",
                      "~/Content/wp-content/plugins/js_composer/assets/lib/bower/font-awesome/css/font-awesome.min972f.css",
                      "~/Content/wp-content/themes/fortun/css/Pe-icon-7-stroke.min7359.css",
                      "~/Content/wp-content/themes/fortun/css/Pe-icon-7-filled.min7359.css",
                      "~/Content/wp-content/themes/fortun/css/linea-arrows.min5152.css",
                      "~/Content/wp-content/themes/fortun/css/linea-basic.min5152.css",
                      "~/Content/wp-content/themes/fortun/css/linea-elaboration.min5152.css",
                      "~/Content/wp-content/themes/fortun/css/linea-ecommerce.min5152.css",
                      "~/Content/wp-content/themes/fortun/css/linea-software.min5152.css",
                      "~/Content/wp-content/themes/fortun/css/linea-music.min5152.css",
                      "~/Content/wp-content/themes/fortun/css/linea-weather.min5152.css",
                      "~/Content/wp-content/themes/fortun/css/wfmi-style.min5152.css",
                      "~/Content/wp-content/themes/fortun/css/fortune-plugins1f93.css",
                      "~/Content/wp-content/themes/fortun/css/fortune1f93.css",
                      "~/Content/wp-content/themes/fortun-child/style5152.css",
                      "~/Content/wp-content/themes/fortun/css/demo145152.css",
                      "~/Content/wp-content/themes/fortun/css/responsive5152.css",
                      "~/Content/Style.css",
                      "~/Content/wp-content/plugins/js_composer/assets/css/js_composer.min972f.css"
                      ));
        }
    }
}
