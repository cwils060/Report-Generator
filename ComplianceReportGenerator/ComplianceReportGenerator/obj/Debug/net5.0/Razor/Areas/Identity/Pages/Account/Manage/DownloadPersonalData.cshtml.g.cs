#pragma checksum "/Users/erbuc_000/Desktop/Report-Generator/ComplianceReportGenerator/ComplianceReportGenerator/Areas/Identity/Pages/Account/Manage/DownloadPersonalData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63a7db14925b4f0b52986d45f1af05ec174d2902"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_Manage_DownloadPersonalData), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Manage/DownloadPersonalData.cshtml")]
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
#nullable restore
#line 1 "/Users/erbuc_000/Desktop/Report-Generator/ComplianceReportGenerator/ComplianceReportGenerator/Areas/Identity/Pages/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/erbuc_000/Desktop/Report-Generator/ComplianceReportGenerator/ComplianceReportGenerator/Areas/Identity/Pages/_ViewImports.cshtml"
using ComplianceReportGenerator.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/erbuc_000/Desktop/Report-Generator/ComplianceReportGenerator/ComplianceReportGenerator/Areas/Identity/Pages/_ViewImports.cshtml"
using ComplianceReportGenerator.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/erbuc_000/Desktop/Report-Generator/ComplianceReportGenerator/ComplianceReportGenerator/Areas/Identity/Pages/Account/_ViewImports.cshtml"
using ComplianceReportGenerator.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/erbuc_000/Desktop/Report-Generator/ComplianceReportGenerator/ComplianceReportGenerator/Areas/Identity/Pages/Account/Manage/_ViewImports.cshtml"
using ComplianceReportGenerator.Areas.Identity.Pages.Account.Manage;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63a7db14925b4f0b52986d45f1af05ec174d2902", @"/Areas/Identity/Pages/Account/Manage/DownloadPersonalData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c61223ed65be083bffa7092a46bcc5b5b7e91809", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"346b17639af1f9a09b79556810bb2800d4ce7603", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a15b06f21ee2373350de18936bf0f357a7ccf57", @"/Areas/Identity/Pages/Account/Manage/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Manage_DownloadPersonalData : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/erbuc_000/Desktop/Report-Generator/ComplianceReportGenerator/ComplianceReportGenerator/Areas/Identity/Pages/Account/Manage/DownloadPersonalData.cshtml"
  
    ViewData["Title"] = "Download Your Data";
    ViewData["ActivePage"] = ManageNavPages.PersonalData;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h4>");
#nullable restore
#line 8 "/Users/erbuc_000/Desktop/Report-Generator/ComplianceReportGenerator/ComplianceReportGenerator/Areas/Identity/Pages/Account/Manage/DownloadPersonalData.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "63a7db14925b4f0b52986d45f1af05ec174d29025669", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DownloadPersonalDataModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DownloadPersonalDataModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DownloadPersonalDataModel>)PageContext?.ViewData;
        public DownloadPersonalDataModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591