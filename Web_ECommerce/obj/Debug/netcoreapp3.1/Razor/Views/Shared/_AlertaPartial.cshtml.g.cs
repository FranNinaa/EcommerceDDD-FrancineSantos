#pragma checksum "C:\Users\Fran\Desktop\clone git\Estudos C#\EcommerceDDD-FrancineSantos\Web_ECommerce\Views\Shared\_AlertaPartial.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "e16f4dd6b6f75b4de58bf250f9e1b77b3080d1eeeff32e66a7d342531db42958"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AlertaPartial), @"mvc.1.0.view", @"/Views/Shared/_AlertaPartial.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Fran\Desktop\clone git\Estudos C#\EcommerceDDD-FrancineSantos\Web_ECommerce\Views\_ViewImports.cshtml"
using Web_ECommerce;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Fran\Desktop\clone git\Estudos C#\EcommerceDDD-FrancineSantos\Web_ECommerce\Views\_ViewImports.cshtml"
using Web_ECommerce.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"e16f4dd6b6f75b4de58bf250f9e1b77b3080d1eeeff32e66a7d342531db42958", @"/Views/Shared/_AlertaPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"a5be9ec684ed773fec2011c780a019e2285d0c44a3afd32637f8c103022ac8e8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__AlertaPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Fran\Desktop\clone git\Estudos C#\EcommerceDDD-FrancineSantos\Web_ECommerce\Views\Shared\_AlertaPartial.cshtml"
  
    bool sucesso = false;
    bool alerta = false;
    bool erro = false;
    string messagem = string.Empty;


    sucesso = ViewBag.Sucesso != null ? ViewBag.Sucesso : false;
    alerta = ViewBag.Alerta != null ? ViewBag.Alerta : false;
    erro = ViewBag.Erro != null ? ViewBag.Erro : false;
    messagem = ViewBag.Mensagem != null ? ViewBag.Mensagem : string.Empty;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 14 "C:\Users\Fran\Desktop\clone git\Estudos C#\EcommerceDDD-FrancineSantos\Web_ECommerce\Views\Shared\_AlertaPartial.cshtml"
 if (sucesso)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-sucess\">\r\n        <a href=\"#\" class=\"close\" data-dismiss=\"alert\" aria-label=\"close\">&times;</a>\r\n        <strong>");
#nullable restore
#line 18 "C:\Users\Fran\Desktop\clone git\Estudos C#\EcommerceDDD-FrancineSantos\Web_ECommerce\Views\Shared\_AlertaPartial.cshtml"
           Write(messagem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n    </div>\r\n");
#nullable restore
#line 20 "C:\Users\Fran\Desktop\clone git\Estudos C#\EcommerceDDD-FrancineSantos\Web_ECommerce\Views\Shared\_AlertaPartial.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 22 "C:\Users\Fran\Desktop\clone git\Estudos C#\EcommerceDDD-FrancineSantos\Web_ECommerce\Views\Shared\_AlertaPartial.cshtml"
 if (alerta)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-warning\">\r\n        <a href=\"#\" class=\"close\" data-dismiss=\"alert\" aria-label=\"close\">&times;</a>\r\n        <strong>");
#nullable restore
#line 26 "C:\Users\Fran\Desktop\clone git\Estudos C#\EcommerceDDD-FrancineSantos\Web_ECommerce\Views\Shared\_AlertaPartial.cshtml"
           Write(messagem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n    </div>\r\n");
#nullable restore
#line 28 "C:\Users\Fran\Desktop\clone git\Estudos C#\EcommerceDDD-FrancineSantos\Web_ECommerce\Views\Shared\_AlertaPartial.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 30 "C:\Users\Fran\Desktop\clone git\Estudos C#\EcommerceDDD-FrancineSantos\Web_ECommerce\Views\Shared\_AlertaPartial.cshtml"
 if (erro)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\">\r\n        <a href=\"#\" class=\"close\" data-dismiss=\"alert\" aria-label=\"close\">&times;</a>\r\n        <strong>");
#nullable restore
#line 34 "C:\Users\Fran\Desktop\clone git\Estudos C#\EcommerceDDD-FrancineSantos\Web_ECommerce\Views\Shared\_AlertaPartial.cshtml"
           Write(messagem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n    </div>\r\n");
#nullable restore
#line 36 "C:\Users\Fran\Desktop\clone git\Estudos C#\EcommerceDDD-FrancineSantos\Web_ECommerce\Views\Shared\_AlertaPartial.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"AlertaJS\">\r\n\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
