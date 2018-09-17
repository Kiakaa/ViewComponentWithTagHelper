using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Winter.Component
{
    public class WinterTasksTagHelper : TagHelper
    {

        public string Message { get; set; }

        private readonly IViewComponentHelper _viewComponentHelper;

        [HtmlAttributeNotBound]
        [ViewContext]
        public ViewContext ViewContext { get; set; }
        public WinterTasksTagHelper(IViewComponentHelper viewComponentHelper)
        {
            _viewComponentHelper = viewComponentHelper;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            //((IViewContextAware)_viewComponentHelper).Contextualize(ViewContext);

            //var content = _viewComponentHelper.InvokeAsync(typeof(Tasks), new { message = "messxsxx" }).Result;
            //var viewContent = _viewComponentHelper.InvokeAsync("Tasks", Message);

            //output.TagName = null;
            ////output.Content.AppendHtml($"<h4>{Message}</h4>");
            //output.Content.SetContent(viewContent.ToString());


            output.Content.AppendHtml($"<h4>{Message}</h4>");
        }
    }
}

