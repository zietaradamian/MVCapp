using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCapp.Helpers
{
    public static class ImageHelper
    {

        public static MvcHtmlString Image(this HtmlHelper helper, string id, string url, string tekstAltrernatywny)
        {
            return Image(helper,id,url,tekstAltrernatywny,null);
        }
        public static MvcHtmlString Image(this HtmlHelper helper, string id, string url, string tekstAltrernatywny, object htmlAttributes)
        {
            var bulider = new TagBuilder("img");
            bulider.GenerateId(id);
            bulider.MergeAttribute("src", url);
            bulider.MergeAttribute("alt", tekstAltrernatywny);
            bulider.MergeAttributes(new RouteValueDictionary(htmlAttributes));

            return new MvcHtmlString(bulider.ToString(TagRenderMode.SelfClosing));

        }
    }
}