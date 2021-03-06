#pragma checksum "C:\Users\h--sa\Desktop\mvc_products\WebApplication2\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "399aa897053350ed2eda953cfaee57897cf088ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Index), @"mvc.1.0.view", @"/Views/Products/Index.cshtml")]
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
#line 1 "C:\Users\h--sa\Desktop\mvc_products\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\h--sa\Desktop\mvc_products\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"399aa897053350ed2eda953cfaee57897cf088ff", @"/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bdedfabdfa7237c5ca96b8518be22f225c2ea5a", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\h--sa\Desktop\mvc_products\WebApplication2\Views\Products\Index.cshtml"
  
    Layout = "_Layout1Web";
    var products = (List<Product>) ViewData["products"];
    var backgroundcolor = (string) ViewData["color"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "399aa897053350ed2eda953cfaee57897cf088ff3572", async() => {
                WriteLiteral(@"
    <title>title</title>
    <style>
    table {
      font-family: arial, sans-serif;
      border-collapse: collapse;
      width: 100%;
    }
    
    td, th {
      border: 1px solid #dddddd;
      text-align: center;
      padding: 8px;
}
    </style>
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "399aa897053350ed2eda953cfaee57897cf088ff4808", async() => {
                WriteLiteral("\r\n<div>\r\n    <table class=\"table table-striped table-dark\"");
                BeginWriteAttribute("style", " style=\"", 530, "\"", 609, 7);
                WriteAttributeValue("", 538, "width:", 538, 6, true);
                WriteAttributeValue(" ", 544, "100%", 545, 5, true);
                WriteAttributeValue(" ", 549, ";", 550, 2, true);
                WriteAttributeValue(" ", 551, "align-content:", 552, 15, true);
                WriteAttributeValue(" ", 566, "center;", 567, 8, true);
                WriteAttributeValue(" ", 574, "background-color:", 575, 18, true);
#nullable restore
#line 28 "C:\Users\h--sa\Desktop\mvc_products\WebApplication2\Views\Products\Index.cshtml"
WriteAttributeValue(" ", 592, backgroundcolor, 593, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        <tr>\r\n            <th>id</th>\r\n            <th>name</th>\r\n            <th>price</th>\r\n            <th>image</th>\r\n            <th>page</th>\r\n            \r\n        </tr>\r\n");
#nullable restore
#line 37 "C:\Users\h--sa\Desktop\mvc_products\WebApplication2\Views\Products\Index.cshtml"
         foreach (var p in products)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 40 "C:\Users\h--sa\Desktop\mvc_products\WebApplication2\Views\Products\Index.cshtml"
               Write(p.id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 41 "C:\Users\h--sa\Desktop\mvc_products\WebApplication2\Views\Products\Index.cshtml"
               Write(p.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 42 "C:\Users\h--sa\Desktop\mvc_products\WebApplication2\Views\Products\Index.cshtml"
               Write(p.price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>\r\n                    <img");
                BeginWriteAttribute("src", " src=\"", 1005, "\"", 1017, 1);
#nullable restore
#line 44 "C:\Users\h--sa\Desktop\mvc_products\WebApplication2\Views\Products\Index.cshtml"
WriteAttributeValue("", 1011, p.img, 1011, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"width: 100px; height: 100px\">\r\n                </td>\r\n                <td>\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 1124, "\"", 1154, 2);
                WriteAttributeValue("", 1131, "/products/Details/", 1131, 18, true);
#nullable restore
#line 47 "C:\Users\h--sa\Desktop\mvc_products\WebApplication2\Views\Products\Index.cshtml"
WriteAttributeValue("", 1149, p.id, 1149, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><button class=\"btn-outline-dark\">Details</button></a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 50 "C:\Users\h--sa\Desktop\mvc_products\WebApplication2\Views\Products\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </table>\r\n</div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
