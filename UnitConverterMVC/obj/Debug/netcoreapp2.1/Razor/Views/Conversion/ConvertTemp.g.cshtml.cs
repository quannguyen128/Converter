#pragma checksum "C:\APB PRO 2\UnitConverter\UnitConverterMVC\Views\Conversion\ConvertTemp.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "698efcd1e0bc637f6a26b3f66f834f6ba686f32d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Conversion_ConvertTemp), @"mvc.1.0.view", @"/Views/Conversion/ConvertTemp.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Conversion/ConvertTemp.cshtml", typeof(AspNetCore.Views_Conversion_ConvertTemp))]
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
#line 1 "C:\APB PRO 2\UnitConverter\UnitConverterMVC\Views\_ViewImports.cshtml"
using UnitConverterMVC;

#line default
#line hidden
#line 2 "C:\APB PRO 2\UnitConverter\UnitConverterMVC\Views\_ViewImports.cshtml"
using UnitConverterMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"698efcd1e0bc637f6a26b3f66f834f6ba686f32d", @"/Views/Conversion/ConvertTemp.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d28a5dbfc59ae995d9c48bee52d66a636f31f1a5", @"/Views/_ViewImports.cshtml")]
    public class Views_Conversion_ConvertTemp : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ConverterViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 29, true);
            WriteLiteral("\r\n<h1>Results</h1>\r\n<p>\r\n    ");
            EndContext();
            BeginContext(58, 20, false);
#line 5 "C:\APB PRO 2\UnitConverter\UnitConverterMVC\Views\Conversion\ConvertTemp.cshtml"
Write(Model.ValuetoConvert);

#line default
#line hidden
            EndContext();
            BeginContext(78, 19, true);
            WriteLiteral(" Converts to \r\n    ");
            EndContext();
            BeginContext(98, 20, false);
#line 6 "C:\APB PRO 2\UnitConverter\UnitConverterMVC\Views\Conversion\ConvertTemp.cshtml"
Write(Model.ConvertedValue);

#line default
#line hidden
            EndContext();
            BeginContext(118, 8, true);
            WriteLiteral("\r\n\r\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConverterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
