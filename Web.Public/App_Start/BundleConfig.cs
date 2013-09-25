using System.Web.Optimization;

// ReSharper disable CheckNamespace
namespace Web.Public
// ReSharper restore CheckNamespace
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            RegisterStyleBundles(bundles);
            RegisterJavascriptBundles(bundles);
        }

        private static void RegisterStyleBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/assets/css/all")
                            .Include("~/assets/css/bootstrap.css")
                            .Include("~/assets/css/site.css"));
        }

        private static void RegisterJavascriptBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/bootstrap")
                //.Include("~/assets/lib/bootstrap/js/transition.js")
                //.Include("~/assets/lib/bootstrap/js/alert.js")
                //.Include("~/assets/lib/bootstrap/js/button.js")
                //.Include("~/assets/lib/bootstrap/js/carousel.js")
                .Include("~/assets/lib/bootstrap/js/collapse.js")
                .Include("~/assets/lib/bootstrap/js/dropdown.js")
                //.Include("~/assets/lib/bootstrap/js/modal.js")
                //.Include("~/assets/lib/bootstrap/js/tooltip.js")
                //.Include("~/assets/lib/bootstrap/js/popover.js")
                //.Include("~/assets/lib/bootstrap/js/scrollspy.js")
                //.Include("~/assets/lib/bootstrap/js/tab.js")
                //.Include("~/assets/lib/bootstrap/js/affix.js")
                .Include("~/assets/lib/bootstrap/js/dropdown-hover.js"));
        }
    }
}