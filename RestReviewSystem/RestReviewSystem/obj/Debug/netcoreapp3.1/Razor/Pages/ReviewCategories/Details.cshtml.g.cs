#pragma checksum "C:\Users\chand\source\repos\prafullp151\Project\RestReviewSystem\RestReviewSystem\Pages\ReviewCategories\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7f25f823b8fca271cc580383c45325f3e648170"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RestReviewSystem.Pages.ReviewCategories.Pages_ReviewCategories_Details), @"mvc.1.0.razor-page", @"/Pages/ReviewCategories/Details.cshtml")]
namespace RestReviewSystem.Pages.ReviewCategories
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\chand\source\repos\prafullp151\Project\RestReviewSystem\RestReviewSystem\Pages\_ViewImports.cshtml"
using RestReviewSystem;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7f25f823b8fca271cc580383c45325f3e648170", @"/Pages/ReviewCategories/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d405815728a30f1cf9d76e0bad4e43bc941f3fe", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ReviewCategories_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\chand\source\repos\prafullp151\Project\RestReviewSystem\RestReviewSystem\Pages\ReviewCategories\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7f25f823b8fca271cc580383c45325f3e6481704041", async() => {
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Review Category</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\chand\source\repos\prafullp151\Project\RestReviewSystem\RestReviewSystem\Pages\ReviewCategories\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ReviewCategory.CustomerReviewId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\chand\source\repos\prafullp151\Project\RestReviewSystem\RestReviewSystem\Pages\ReviewCategories\Details.cshtml"
       Write(Html.DisplayFor(model => model.ReviewCategory.CustomerReviewId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\chand\source\repos\prafullp151\Project\RestReviewSystem\RestReviewSystem\Pages\ReviewCategories\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerReview.Customer.CustomerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\chand\source\repos\prafullp151\Project\RestReviewSystem\RestReviewSystem\Pages\ReviewCategories\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerReview.Customer.CustomerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\chand\source\repos\prafullp151\Project\RestReviewSystem\RestReviewSystem\Pages\ReviewCategories\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerReview.Restaurant.RestaurantName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\chand\source\repos\prafullp151\Project\RestReviewSystem\RestReviewSystem\Pages\ReviewCategories\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerReview.Restaurant.RestaurantName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Users\chand\source\repos\prafullp151\Project\RestReviewSystem\RestReviewSystem\Pages\ReviewCategories\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ReviewCategory.FoodQuality));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 42 "C:\Users\chand\source\repos\prafullp151\Project\RestReviewSystem\RestReviewSystem\Pages\ReviewCategories\Details.cshtml"
             for (int i = 0; i < (Model.ReviewCategory.FoodQuality); i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"glyphicon glyphicon-star\"></span>\r\n");
#nullable restore
#line 45 "C:\Users\chand\source\repos\prafullp151\Project\RestReviewSystem\RestReviewSystem\Pages\ReviewCategories\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\chand\source\repos\prafullp151\Project\RestReviewSystem\RestReviewSystem\Pages\ReviewCategories\Details.cshtml"
             for (int i = Model.ReviewCategory.FoodQuality; i < 5; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"glyphicon glyphicon-star-empty\"></span>\r\n");
#nullable restore
#line 49 "C:\Users\chand\source\repos\prafullp151\Project\RestReviewSystem\RestReviewSystem\Pages\ReviewCategories\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 52 "C:\Users\chand\source\repos\prafullp151\Project\RestReviewSystem\RestReviewSystem\Pages\ReviewCategories\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ReviewCategory.Service));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 55 "C:\Users\chand\source\repos\prafullp151\Project\RestReviewSystem\RestReviewSystem\Pages\ReviewCategories\Details.cshtml"
             for (int i = 0; i < (Model.ReviewCategory.Service); i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"glyphicon glyphicon-star\"></span>\r\n");
#nullable restore
#line 58 "C:\Users\chand\source\repos\prafullp151\Project\RestReviewSystem\RestReviewSystem\Pages\ReviewCategories\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\chand\source\repos\prafullp151\Project\RestReviewSystem\RestReviewSystem\Pages\ReviewCategories\Details.cshtml"
             for (int i = Model.ReviewCategory.Service; i < 5; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"glyphicon glyphicon-star-empty\"></span>\r\n");
#nullable restore
#line 62 "C:\Users\chand\source\repos\prafullp151\Project\RestReviewSystem\RestReviewSystem\Pages\ReviewCategories\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 65 "C:\Users\chand\source\repos\prafullp151\Project\RestReviewSystem\RestReviewSystem\Pages\ReviewCategories\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ReviewCategory.Cleanliness));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 68 "C:\Users\chand\source\repos\prafullp151\Project\RestReviewSystem\RestReviewSystem\Pages\ReviewCategories\Details.cshtml"
             for (int i = 0; i < (Model.ReviewCategory.Cleanliness); i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"glyphicon glyphicon-star\"></span>\r\n");
#nullable restore
#line 71 "C:\Users\chand\source\repos\prafullp151\Project\RestReviewSystem\RestReviewSystem\Pages\ReviewCategories\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\chand\source\repos\prafullp151\Project\RestReviewSystem\RestReviewSystem\Pages\ReviewCategories\Details.cshtml"
             for (int i = Model.ReviewCategory.Cleanliness; i < 5; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"glyphicon glyphicon-star-empty\"></span>\r\n");
#nullable restore
#line 75 "C:\Users\chand\source\repos\prafullp151\Project\RestReviewSystem\RestReviewSystem\Pages\ReviewCategories\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7f25f823b8fca271cc580383c45325f3e64817012882", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 80 "C:\Users\chand\source\repos\prafullp151\Project\RestReviewSystem\RestReviewSystem\Pages\ReviewCategories\Details.cshtml"
                           WriteLiteral(Model.ReviewCategory.ReviewCategoryId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7f25f823b8fca271cc580383c45325f3e64817015092", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RestReviewSystem.Pages.ReviewCategories.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RestReviewSystem.Pages.ReviewCategories.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RestReviewSystem.Pages.ReviewCategories.DetailsModel>)PageContext?.ViewData;
        public RestReviewSystem.Pages.ReviewCategories.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
