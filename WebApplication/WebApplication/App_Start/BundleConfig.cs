using System.Web;
using System.Web.Optimization;

namespace cequam
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/libs/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/libs/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/script").Include(
                       "~/Scripts/libs/modernizr-2.0.6.min.js", 
                       "~/Scripts/mylibs/jquery.validate.js", 
                       "~/Scripts/mylibs/jquery.jgrowl.js", 
                       "~/Scripts/mylibs/jquery.checkbox.js",
                       "~/Scripts/plugins.js",  
                       "~/Scripts/script.js" 
                    ));

            

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/Theme/css").Include(
                        "~/Content/Theme/css/style.css",
                        "~/Content/Theme/css/content.css", 
                        "~/Content/Theme/css/footer.css",
                        "~/Content/Theme/css/header.css",
                        "~/Content/Theme/css/icons.css", 
                        "~/Content/Theme/css/ie.fixes.css",
                        "~/Content/Theme/css/navigation.css",
                        "~/Content/Theme/css/plugin.calendar.css", 
                        "~/Content/Theme/css/plugin.charts.css", 
                        "~/Content/Theme/css/plugin.fileexplorer.css", 
                        "~/Content/Theme/css/plugin.wysiwyg.css",
                        "~/Content/Theme/css/sidebar.css",
                        "~/Content/Theme/css/special-page.css",
                        "~/Content/Theme/css/sprite.forms.css",
                        "~/Content/Theme/css/sprite.gallery.css",
                        "~/Content/Theme/css/sprite.lists.css",
                        "~/Content/Theme/css/sprite.tables.css",
                        "~/Content/Theme/css/sprite.wizard.css", 
                        "~/Content/Theme/css/sprites.css", 
                        "~/Content/Theme/css/typographics.css"));
        }
    }
}