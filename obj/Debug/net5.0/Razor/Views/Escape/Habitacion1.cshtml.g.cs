#pragma checksum "C:\xampp\htdocs\files\ORT\tp07\tp7\Views\Escape\Habitacion1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b985195e86bd220922bdcaae6c60b0388e709953"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Escape_Habitacion1), @"mvc.1.0.view", @"/Views/Escape/Habitacion1.cshtml")]
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
#line 1 "C:\xampp\htdocs\files\ORT\tp07\tp7\Views\_ViewImports.cshtml"
using tp7;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\xampp\htdocs\files\ORT\tp07\tp7\Views\_ViewImports.cshtml"
using tp7.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b985195e86bd220922bdcaae6c60b0388e709953", @"/Views/Escape/Habitacion1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0d99a9ef3632202d523765a31f98ea6ef60ba88", @"/Views/_ViewImports.cshtml")]
    public class Views_Escape_Habitacion1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\xampp\htdocs\files\ORT\tp07\tp7\Views\Escape\Habitacion1.cshtml"
  
    ViewData["Title"] = "Habitacion 1";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b985195e86bd220922bdcaae6c60b0388e7099533750", async() => {
                WriteLiteral("\r\n        <label>\r\n            Clave\r\n            <input name=\"clave\" class=\"form-control\">\r\n            <input class=\"btn btn-success\" type=\"submit\" value=\"Enviar\">\r\n        </label>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#nullable restore
#line 8 "C:\xampp\htdocs\files\ORT\tp07\tp7\Views\Escape\Habitacion1.cshtml"
AddHtmlAttributeValue("", 151, Url.Action("Habitacion1", "Escape"), 151, 36, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 16 "C:\xampp\htdocs\files\ORT\tp07\tp7\Views\Escape\Habitacion1.cshtml"
Write(ViewBag.Clave);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 18 "C:\xampp\htdocs\files\ORT\tp07\tp7\Views\Escape\Habitacion1.cshtml"
      
        if(ViewBag.Error != ""){

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""modal fade"" id=""modal"">
                <div class=""modal-dialog"">
                    <div class=""modal-content"">
                        <div class=""modal-header"">
                            <h5 class=""modal-title"">Términos y condiciones</h5>
                            <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal""></button>
                        </div>

                        <div class=""modal-body"">
                            ");
#nullable restore
#line 29 "C:\xampp\htdocs\files\ORT\tp07\tp7\Views\Escape\Habitacion1.cshtml"
                       Write(ViewBag.Error);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                        
                        <div class=""modal-footer"">
                            <button type=""button"" class=""btn btn-primary"" data-bs-dismiss=""modal"">Aceptar</button>         
                        </div>
                    </div>
                </div>
            </div>
");
#nullable restore
#line 38 "C:\xampp\htdocs\files\ORT\tp07\tp7\Views\Escape\Habitacion1.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n <script>\r\n    const modal = new bootstrap.Modal(document.getElementById(\'modal\'), {\r\n        keyboard: false,\r\n        backdrop: \'static\'\r\n    });\r\n\r\n    modal.show();\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591