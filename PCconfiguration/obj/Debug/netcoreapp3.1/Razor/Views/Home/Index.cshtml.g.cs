#pragma checksum "C:\Users\Zah\source\repos\PCconfiguration\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddfe0867d589cd59c64793965ce0f7b4306d4d80"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Zah\source\repos\PCconfiguration\Views\_ViewImports.cshtml"
using PCconfiguration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Zah\source\repos\PCconfiguration\Views\Home\Index.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Zah\source\repos\PCconfiguration\Views\Home\Index.cshtml"
using PCconfiguration.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddfe0867d589cd59c64793965ce0f7b4306d4d80", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"739473a6226514f6ba81fc44bf4f772782aa11a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PCconfiguration.View_Models.PartsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("myForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Zah\source\repos\PCconfiguration\Views\Home\Index.cshtml"
  

    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Build Your PC!</h1>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ddfe0867d589cd59c64793965ce0f7b4306d4d804274", async() => {
                WriteLiteral("\r\n\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 15 "C:\Users\Zah\source\repos\PCconfiguration\Views\Home\Index.cshtml"
       Write(Html.DropDownListFor(m => m.Cases, new SelectList(Model.Cases, "Id", "Name"), "Select Case", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 20 "C:\Users\Zah\source\repos\PCconfiguration\Views\Home\Index.cshtml"
       Write(Html.DropDownListFor(m => m.Motherboards, new SelectList(Model.Motherboards, "Id", "Name"), "Select Motherboard", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 25 "C:\Users\Zah\source\repos\PCconfiguration\Views\Home\Index.cshtml"
       Write(Html.DropDownListFor(m => m.GraphicsCards, new SelectList(Model.GraphicsCards, "Id", "Name"), "Select GPU", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 30 "C:\Users\Zah\source\repos\PCconfiguration\Views\Home\Index.cshtml"
       Write(Html.DropDownListFor(m => m.Processors, new SelectList(Model.Processors, "Id", "Name"), "Select CPU", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 35 "C:\Users\Zah\source\repos\PCconfiguration\Views\Home\Index.cshtml"
       Write(Html.DropDownListFor(m => m.PowerSupplies, new SelectList(Model.PowerSupplies, "Id", "Name"), "Select PSU", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 40 "C:\Users\Zah\source\repos\PCconfiguration\Views\Home\Index.cshtml"
       Write(Html.DropDownListFor(m => m.HardDrives, new SelectList(Model.HardDrives, "Id", "Name"), "Select a Hard Drive", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 45 "C:\Users\Zah\source\repos\PCconfiguration\Views\Home\Index.cshtml"
       Write(Html.DropDownListFor(m => m.Rams, new SelectList(Model.Rams, "Id", "Name"), "Select RAM", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 50 "C:\Users\Zah\source\repos\PCconfiguration\Views\Home\Index.cshtml"
       Write(Html.DropDownListFor(m => m.Coolings, new SelectList(Model.Coolings, "Id", "Name"), "Select a Cooling System", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 55 "C:\Users\Zah\source\repos\PCconfiguration\Views\Home\Index.cshtml"
       Write(Html.DropDownListFor(m => m.CpuCoolings, new SelectList(Model.CpuCoolings, "Id", "Name"), "Select a CPU Cooler", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 60 "C:\Users\Zah\source\repos\PCconfiguration\Views\Home\Index.cshtml"
       Write(Html.DropDownListFor(m => m.CdDvds, new SelectList(Model.CdDvds, "Id", "Name"), "Select Optical Device", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 65 "C:\Users\Zah\source\repos\PCconfiguration\Views\Home\Index.cshtml"
       Write(Html.DropDownListFor(m => m.SoundCards, new SelectList(Model.SoundCards, "Id", "Name"), "Select a Sound Card", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 70 "C:\Users\Zah\source\repos\PCconfiguration\Views\Home\Index.cshtml"
       Write(Html.DropDownListFor(m => m.OperatingSystems, new SelectList(Model.OperatingSystems, "Id", "Name"), "Select Operating System", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        </div>\r\n\r\n\r\n\r\n        <button id=\"btnSubmit\" type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n\r\n\r\n\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    <div id=\"resultArea\"></div>\r\n</div>\r\n\r\n<script>\r\n\r\n    document.getElementById(\"btnSubmit\").addEventListener(\"click\", function (event) {\r\n\r\n        event.preventDefault();\r\n\r\n        var form = $(\'#myForm\').serialize();\r\n\r\n        $.post(\'");
#nullable restore
#line 93 "C:\Users\Zah\source\repos\PCconfiguration\Views\Home\Index.cshtml"
           Write(Url.Action("Calculate", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\', form)\r\n            .done(function(response) {\r\n               $(\"#resultArea\").html(\"The total price of the selected products is : \" + response + \"$\");\r\n            });\r\n    });\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PCconfiguration.View_Models.PartsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
