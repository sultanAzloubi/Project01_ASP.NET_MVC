#pragma checksum "C:\Users\sulta\RiderProjects\Project01_ASP.NET_MVC\DotNetProject1\DotNetProject1\Views\Books\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fba16a47adc146a3e282458cd59f528eaec05f26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_Index), @"mvc.1.0.view", @"/Views/Books/Index.cshtml")]
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
#line 1 "C:\Users\sulta\RiderProjects\Project01_ASP.NET_MVC\DotNetProject1\DotNetProject1\Views\_ViewImports.cshtml"
using DotNetProject1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sulta\RiderProjects\Project01_ASP.NET_MVC\DotNetProject1\DotNetProject1\Views\_ViewImports.cshtml"
using DotNetProject1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fba16a47adc146a3e282458cd59f528eaec05f26", @"/Views/Books/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf395a4fe07fd8d3752a167a0820deedbd011a3f", @"/Views/_ViewImports.cshtml")]
    public class Views_Books_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\sulta\RiderProjects\Project01_ASP.NET_MVC\DotNetProject1\DotNetProject1\Views\Books\Index.cshtml"
  
    var booksList = (List<BooksModel>) ViewData["BooksList"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fba16a47adc146a3e282458cd59f528eaec05f263416", async() => {
                WriteLiteral(@"
<div class=""container"">
    <h1>here are the list of the books we provide:</h1>
</div>
<table class=""table text-center table-striped"">
    <tr>
        <th>ID</th>
        <th>Description</th>
        <th>author</th>
        <th>Image</th>
        <th>Price</th>
    </tr>
");
#nullable restore
#line 17 "C:\Users\sulta\RiderProjects\Project01_ASP.NET_MVC\DotNetProject1\DotNetProject1\Views\Books\Index.cshtml"
     foreach (var book in booksList)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <tr>\r\n            <td class=\"align-middle\">");
#nullable restore
#line 20 "C:\Users\sulta\RiderProjects\Project01_ASP.NET_MVC\DotNetProject1\DotNetProject1\Views\Books\Index.cshtml"
                                Write(book.id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td class=\"align-middle\"><a");
                BeginWriteAttribute("href", " href=\"", 514, "\"", 545, 2);
                WriteAttributeValue("", 521, "./Books/Details/", 521, 16, true);
#nullable restore
#line 21 "C:\Users\sulta\RiderProjects\Project01_ASP.NET_MVC\DotNetProject1\DotNetProject1\Views\Books\Index.cshtml"
WriteAttributeValue("", 537, book.id, 537, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 21 "C:\Users\sulta\RiderProjects\Project01_ASP.NET_MVC\DotNetProject1\DotNetProject1\Views\Books\Index.cshtml"
                                                                   Write(book.description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></td>\r\n            <td class=\"align-middle\">");
#nullable restore
#line 22 "C:\Users\sulta\RiderProjects\Project01_ASP.NET_MVC\DotNetProject1\DotNetProject1\Views\Books\Index.cshtml"
                                Write(book.author);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td class=\"align-middle\"> <img");
                BeginWriteAttribute("src", " src=", 673, "", 689, 1);
#nullable restore
#line 23 "C:\Users\sulta\RiderProjects\Project01_ASP.NET_MVC\DotNetProject1\DotNetProject1\Views\Books\Index.cshtml"
WriteAttributeValue("", 678, book.image, 678, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" height=\"100\" width=\"100\"");
                BeginWriteAttribute("alt", " alt=\"", 714, "\"", 720, 0);
                EndWriteAttribute();
                WriteLiteral("/> </td>\r\n            <td class=\"align-middle\">");
#nullable restore
#line 24 "C:\Users\sulta\RiderProjects\Project01_ASP.NET_MVC\DotNetProject1\DotNetProject1\Views\Books\Index.cshtml"
                                Write(book.price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n        <br/>\r\n");
#nullable restore
#line 27 "C:\Users\sulta\RiderProjects\Project01_ASP.NET_MVC\DotNetProject1\DotNetProject1\Views\Books\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("</table>\r\n");
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
