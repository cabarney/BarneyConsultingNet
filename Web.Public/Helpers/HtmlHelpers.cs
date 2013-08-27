using System;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace Web.Public.Helpers
{
    public static class HtmlHelpers
    {
        public static MvcHtmlString MenuLink(this HtmlHelper htmlHelper, string linkText, string actionName, string controllerName)
        {
            var currentAction = htmlHelper.ViewContext.RouteData.GetRequiredString("action");
            var currentController = htmlHelper.ViewContext.RouteData.GetRequiredString("controller");

            var builder = new TagBuilder("li")
                              {
                                  InnerHtml = htmlHelper.ActionLink(linkText, actionName, controllerName).ToHtmlString()
                              };

            if (currentController.Equals(controllerName, StringComparison.CurrentCultureIgnoreCase) && currentAction.Equals(actionName, StringComparison.CurrentCultureIgnoreCase))
                builder.AddCssClass("active");

            return new MvcHtmlString(builder.ToString());
        }

        public static bool IsActive(this HtmlHelper htmlHelper, string actionName, string controllerName)
        {
            var currentAction = htmlHelper.ViewContext.RouteData.GetRequiredString("action");
            var currentController = htmlHelper.ViewContext.RouteData.GetRequiredString("controller");


            return currentController.Equals(controllerName, StringComparison.CurrentCultureIgnoreCase) &&
                   (currentAction.Equals(actionName, StringComparison.CurrentCultureIgnoreCase) || string.IsNullOrWhiteSpace(actionName));
        }
    }
}
