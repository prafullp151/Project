#pragma checksum "C:\Users\chand\Source\Repos\prafullp151\Project\RestReviewSystem\RestReviewSystem\Pages\Restaurants\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92f8d37bda062a60e69d01d4c62e8b037b1c94ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RestReviewSystem.Pages.Restaurants.Pages_Restaurants_Details), @"mvc.1.0.razor-page", @"/Pages/Restaurants/Details.cshtml")]
namespace RestReviewSystem.Pages.Restaurants
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
#line 1 "C:\Users\chand\Source\Repos\prafullp151\Project\RestReviewSystem\RestReviewSystem\Pages\_ViewImports.cshtml"
using RestReviewSystem;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92f8d37bda062a60e69d01d4c62e8b037b1c94ad", @"/Pages/Restaurants/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d405815728a30f1cf9d76e0bad4e43bc941f3fe", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Restaurants_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\chand\Source\Repos\prafullp151\Project\RestReviewSystem\RestReviewSystem\Pages\Restaurants\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Restaurant</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\chand\Source\Repos\prafullp151\Project\RestReviewSystem\RestReviewSystem\Pages\Restaurants\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Restaurant.RestaurantName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\chand\Source\Repos\prafullp151\Project\RestReviewSystem\RestReviewSystem\Pages\Restaurants\Details.cshtml"
       Write(Html.DisplayFor(model => model.Restaurant.RestaurantName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\chand\Source\Repos\prafullp151\Project\RestReviewSystem\RestReviewSystem\Pages\Restaurants\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Restaurant.AvgRating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\chand\Source\Repos\prafullp151\Project\RestReviewSystem\RestReviewSystem\Pages\Restaurants\Details.cshtml"
       Write(Html.DisplayFor(model => model.AvgRatings));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\chand\Source\Repos\prafullp151\Project\RestReviewSystem\RestReviewSystem\Pages\Restaurants\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Restaurant.Avgcostofmeal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\chand\Source\Repos\prafullp151\Project\RestReviewSystem\RestReviewSystem\Pages\Restaurants\Details.cshtml"
       Write(Html.DisplayFor(model => model.Restaurant.Avgcostofmeal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\chand\Source\Repos\prafullp151\Project\RestReviewSystem\RestReviewSystem\Pages\Restaurants\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Restaurant.VegChoices));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\chand\Source\Repos\prafullp151\Project\RestReviewSystem\RestReviewSystem\Pages\Restaurants\Details.cshtml"
       Write(Html.DisplayFor(model => model.Restaurant.VegChoices));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Users\chand\Source\Repos\prafullp151\Project\RestReviewSystem\RestReviewSystem\Pages\Restaurants\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Restaurant.BarAavialable));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Users\chand\Source\Repos\prafullp151\Project\RestReviewSystem\RestReviewSystem\Pages\Restaurants\Details.cshtml"
       Write(Html.DisplayFor(model => model.Restaurant.BarAavialable));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "C:\Users\chand\Source\Repos\prafullp151\Project\RestReviewSystem\RestReviewSystem\Pages\Restaurants\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Restaurant.NoOFEmployees));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\Users\chand\Source\Repos\prafullp151\Project\RestReviewSystem\RestReviewSystem\Pages\Restaurants\Details.cshtml"
       Write(Html.DisplayFor(model => model.Restaurant.NoOFEmployees));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "C:\Users\chand\Source\Repos\prafullp151\Project\RestReviewSystem\RestReviewSystem\Pages\Restaurants\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Restaurant.OpeningTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "C:\Users\chand\Source\Repos\prafullp151\Project\RestReviewSystem\RestReviewSystem\Pages\Restaurants\Details.cshtml"
       Write(Html.DisplayFor(model => model.Restaurant.OpeningTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "C:\Users\chand\Source\Repos\prafullp151\Project\RestReviewSystem\RestReviewSystem\Pages\Restaurants\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Restaurant.ClosingTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "C:\Users\chand\Source\Repos\prafullp151\Project\RestReviewSystem\RestReviewSystem\Pages\Restaurants\Details.cshtml"
       Write(Html.DisplayFor(model => model.Restaurant.ClosingTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "C:\Users\chand\Source\Repos\prafullp151\Project\RestReviewSystem\RestReviewSystem\Pages\Restaurants\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Restaurant.TypeOfCuisine));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "C:\Users\chand\Source\Repos\prafullp151\Project\RestReviewSystem\RestReviewSystem\Pages\Restaurants\Details.cshtml"
       Write(Html.DisplayFor(model => model.Restaurant.TypeOfCuisine));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 69 "C:\Users\chand\Source\Repos\prafullp151\Project\RestReviewSystem\RestReviewSystem\Pages\Restaurants\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Restaurant.PaymentMode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 72 "C:\Users\chand\Source\Repos\prafullp151\Project\RestReviewSystem\RestReviewSystem\Pages\Restaurants\Details.cshtml"
       Write(Html.DisplayFor(model => model.Restaurant.PaymentMode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 75 "C:\Users\chand\Source\Repos\prafullp151\Project\RestReviewSystem\RestReviewSystem\Pages\Restaurants\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Restaurant.DeliveryAvailable));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 78 "C:\Users\chand\Source\Repos\prafullp151\Project\RestReviewSystem\RestReviewSystem\Pages\Restaurants\Details.cshtml"
       Write(Html.DisplayFor(model => model.Restaurant.DeliveryAvailable));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 81 "C:\Users\chand\Source\Repos\prafullp151\Project\RestReviewSystem\RestReviewSystem\Pages\Restaurants\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Restaurant.BuffetAvailable));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 84 "C:\Users\chand\Source\Repos\prafullp151\Project\RestReviewSystem\RestReviewSystem\Pages\Restaurants\Details.cshtml"
       Write(Html.DisplayFor(model => model.Restaurant.BuffetAvailable));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 87 "C:\Users\chand\Source\Repos\prafullp151\Project\RestReviewSystem\RestReviewSystem\Pages\Restaurants\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Restaurant.CafeAvailable));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 90 "C:\Users\chand\Source\Repos\prafullp151\Project\RestReviewSystem\RestReviewSystem\Pages\Restaurants\Details.cshtml"
       Write(Html.DisplayFor(model => model.Restaurant.CafeAvailable));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92f8d37bda062a60e69d01d4c62e8b037b1c94ad13643", async() => {
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
#line 95 "C:\Users\chand\Source\Repos\prafullp151\Project\RestReviewSystem\RestReviewSystem\Pages\Restaurants\Details.cshtml"
                           WriteLiteral(Model.Restaurant.RestaurantId);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92f8d37bda062a60e69d01d4c62e8b037b1c94ad15840", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RestReviewSystem.Pages.Restaurants.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RestReviewSystem.Pages.Restaurants.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RestReviewSystem.Pages.Restaurants.DetailsModel>)PageContext?.ViewData;
        public RestReviewSystem.Pages.Restaurants.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
