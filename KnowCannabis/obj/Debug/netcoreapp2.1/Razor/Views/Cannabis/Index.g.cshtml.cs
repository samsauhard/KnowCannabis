#pragma checksum "C:\Users\owner\Downloads\KnowCannabis\KnowCannabis\KnowCannabis\Views\Cannabis\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be0a53e0aa4e396571062ae437f1fa304797b51a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cannabis_Index), @"mvc.1.0.view", @"/Views/Cannabis/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cannabis/Index.cshtml", typeof(AspNetCore.Views_Cannabis_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\owner\Downloads\KnowCannabis\KnowCannabis\KnowCannabis\Views\_ViewImports.cshtml"
using KnowCannabis;

#line default
#line hidden
#line 2 "C:\Users\owner\Downloads\KnowCannabis\KnowCannabis\KnowCannabis\Views\_ViewImports.cshtml"
using KnowCannabis.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be0a53e0aa4e396571062ae437f1fa304797b51a", @"/Views/Cannabis/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d945bc9b8864f74f55698508503a09f907e4127", @"/Views/_ViewImports.cshtml")]
    public class Views_Cannabis_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<KnowCannabis.Models.Cannabis>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\owner\Downloads\KnowCannabis\KnowCannabis\KnowCannabis\Views\Cannabis\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(93, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(122, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8fff32cb3c241139c0db8c127a1e3f2", async() => {
                BeginContext(145, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(159, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(252, 38, false);
#line 16 "C:\Users\owner\Downloads\KnowCannabis\KnowCannabis\KnowCannabis\Views\Cannabis\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(290, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(346, 40, false);
#line 19 "C:\Users\owner\Downloads\KnowCannabis\KnowCannabis\KnowCannabis\Views\Cannabis\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(386, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(442, 40, false);
#line 22 "C:\Users\owner\Downloads\KnowCannabis\KnowCannabis\KnowCannabis\Views\Cannabis\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(482, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(538, 44, false);
#line 25 "C:\Users\owner\Downloads\KnowCannabis\KnowCannabis\KnowCannabis\Views\Cannabis\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PostedBy));

#line default
#line hidden
            EndContext();
            BeginContext(582, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(638, 46, false);
#line 28 "C:\Users\owner\Downloads\KnowCannabis\KnowCannabis\KnowCannabis\Views\Cannabis\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PostedDate));

#line default
#line hidden
            EndContext();
            BeginContext(684, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(740, 39, false);
#line 31 "C:\Users\owner\Downloads\KnowCannabis\KnowCannabis\KnowCannabis\Views\Cannabis\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Thc));

#line default
#line hidden
            EndContext();
            BeginContext(779, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(835, 39, false);
#line 34 "C:\Users\owner\Downloads\KnowCannabis\KnowCannabis\KnowCannabis\Views\Cannabis\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Cbd));

#line default
#line hidden
            EndContext();
            BeginContext(874, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(930, 47, false);
#line 37 "C:\Users\owner\Downloads\KnowCannabis\KnowCannabis\KnowCannabis\Views\Cannabis\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SideEffects));

#line default
#line hidden
            EndContext();
            BeginContext(977, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1033, 40, false);
#line 40 "C:\Users\owner\Downloads\KnowCannabis\KnowCannabis\KnowCannabis\Views\Cannabis\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.High));

#line default
#line hidden
            EndContext();
            BeginContext(1073, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1129, 48, false);
#line 43 "C:\Users\owner\Downloads\KnowCannabis\KnowCannabis\KnowCannabis\Views\Cannabis\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PainReliever));

#line default
#line hidden
            EndContext();
            BeginContext(1177, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1233, 48, false);
#line 46 "C:\Users\owner\Downloads\KnowCannabis\KnowCannabis\KnowCannabis\Views\Cannabis\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EaseMigraine));

#line default
#line hidden
            EndContext();
            BeginContext(1281, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1337, 49, false);
#line 49 "C:\Users\owner\Downloads\KnowCannabis\KnowCannabis\KnowCannabis\Views\Cannabis\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ReduceAnxiety));

#line default
#line hidden
            EndContext();
            BeginContext(1386, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1442, 51, false);
#line 52 "C:\Users\owner\Downloads\KnowCannabis\KnowCannabis\KnowCannabis\Views\Cannabis\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IncreaseApetite));

#line default
#line hidden
            EndContext();
            BeginContext(1493, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 58 "C:\Users\owner\Downloads\KnowCannabis\KnowCannabis\KnowCannabis\Views\Cannabis\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1611, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1660, 37, false);
#line 61 "C:\Users\owner\Downloads\KnowCannabis\KnowCannabis\KnowCannabis\Views\Cannabis\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1697, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1753, 39, false);
#line 64 "C:\Users\owner\Downloads\KnowCannabis\KnowCannabis\KnowCannabis\Views\Cannabis\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1792, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1848, 39, false);
#line 67 "C:\Users\owner\Downloads\KnowCannabis\KnowCannabis\KnowCannabis\Views\Cannabis\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Type));

#line default
#line hidden
            EndContext();
            BeginContext(1887, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1943, 43, false);
#line 70 "C:\Users\owner\Downloads\KnowCannabis\KnowCannabis\KnowCannabis\Views\Cannabis\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PostedBy));

#line default
#line hidden
            EndContext();
            BeginContext(1986, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2042, 45, false);
#line 73 "C:\Users\owner\Downloads\KnowCannabis\KnowCannabis\KnowCannabis\Views\Cannabis\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PostedDate));

#line default
#line hidden
            EndContext();
            BeginContext(2087, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2143, 38, false);
#line 76 "C:\Users\owner\Downloads\KnowCannabis\KnowCannabis\KnowCannabis\Views\Cannabis\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Thc));

#line default
#line hidden
            EndContext();
            BeginContext(2181, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2237, 38, false);
#line 79 "C:\Users\owner\Downloads\KnowCannabis\KnowCannabis\KnowCannabis\Views\Cannabis\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cbd));

#line default
#line hidden
            EndContext();
            BeginContext(2275, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2331, 46, false);
#line 82 "C:\Users\owner\Downloads\KnowCannabis\KnowCannabis\KnowCannabis\Views\Cannabis\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SideEffects));

#line default
#line hidden
            EndContext();
            BeginContext(2377, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2433, 39, false);
#line 85 "C:\Users\owner\Downloads\KnowCannabis\KnowCannabis\KnowCannabis\Views\Cannabis\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.High));

#line default
#line hidden
            EndContext();
            BeginContext(2472, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2528, 47, false);
#line 88 "C:\Users\owner\Downloads\KnowCannabis\KnowCannabis\KnowCannabis\Views\Cannabis\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PainReliever));

#line default
#line hidden
            EndContext();
            BeginContext(2575, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2631, 47, false);
#line 91 "C:\Users\owner\Downloads\KnowCannabis\KnowCannabis\KnowCannabis\Views\Cannabis\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EaseMigraine));

#line default
#line hidden
            EndContext();
            BeginContext(2678, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2734, 48, false);
#line 94 "C:\Users\owner\Downloads\KnowCannabis\KnowCannabis\KnowCannabis\Views\Cannabis\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ReduceAnxiety));

#line default
#line hidden
            EndContext();
            BeginContext(2782, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2838, 50, false);
#line 97 "C:\Users\owner\Downloads\KnowCannabis\KnowCannabis\KnowCannabis\Views\Cannabis\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IncreaseApetite));

#line default
#line hidden
            EndContext();
            BeginContext(2888, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2944, 52, false);
#line 100 "C:\Users\owner\Downloads\KnowCannabis\KnowCannabis\KnowCannabis\Views\Cannabis\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new {  id=item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(2996, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(3017, 57, false);
#line 101 "C:\Users\owner\Downloads\KnowCannabis\KnowCannabis\KnowCannabis\Views\Cannabis\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id=item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(3074, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(3095, 55, false);
#line 102 "C:\Users\owner\Downloads\KnowCannabis\KnowCannabis\KnowCannabis\Views\Cannabis\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id=item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(3150, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 105 "C:\Users\owner\Downloads\KnowCannabis\KnowCannabis\KnowCannabis\Views\Cannabis\Index.cshtml"
}

#line default
#line hidden
            BeginContext(3189, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<KnowCannabis.Models.Cannabis>> Html { get; private set; }
    }
}
#pragma warning restore 1591
