#pragma checksum "C:\Users\User\Desktop\ECommerce-App\ECommerce\Views\Home\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60b614a67ec82c7cd66b7c1c386e9acc139b55eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_index), @"mvc.1.0.view", @"/Views/Home/index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/index.cshtml", typeof(AspNetCore.Views_Home_index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60b614a67ec82c7cd66b7c1c386e9acc139b55eb", @"/Views/Home/index.cshtml")]
    public class Views_Home_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ECommerce.ViewModels.HomeVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 9, true);
            WriteLiteral("\r\n\r\n<h2> ");
            EndContext();
            BeginContext(46, 11, false);
#line 4 "C:\Users\User\Desktop\ECommerce-App\ECommerce\Views\Home\index.cshtml"
Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(57, 9, true);
            WriteLiteral("</h2>\r\n\r\n");
            EndContext();
#line 6 "C:\Users\User\Desktop\ECommerce-App\ECommerce\Views\Home\index.cshtml"
     foreach (var product in Model.Products)
    {

#line default
#line hidden
            BeginContext(119, 38, true);
            WriteLiteral("        <div>\r\n            <h2>Name : ");
            EndContext();
            BeginContext(158, 12, false);
#line 9 "C:\Users\User\Desktop\ECommerce-App\ECommerce\Views\Home\index.cshtml"
                  Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(170, 34, true);
            WriteLiteral("</h2>\r\n            <h2>Category : ");
            EndContext();
            BeginContext(205, 16, false);
#line 10 "C:\Users\User\Desktop\ECommerce-App\ECommerce\Views\Home\index.cshtml"
                      Write(product.Category);

#line default
#line hidden
            EndContext();
            BeginContext(221, 34, true);
            WriteLiteral("</h2>\r\n            <h3>Condtion : ");
            EndContext();
            BeginContext(256, 17, false);
#line 11 "C:\Users\User\Desktop\ECommerce-App\ECommerce\Views\Home\index.cshtml"
                      Write(product.Condition);

#line default
#line hidden
            EndContext();
            BeginContext(273, 45, true);
            WriteLiteral("</h3>\r\n            <h3></h3>\r\n            <p>");
            EndContext();
            BeginContext(319, 19, false);
#line 13 "C:\Users\User\Desktop\ECommerce-App\ECommerce\Views\Home\index.cshtml"
          Write(product.Description);

#line default
#line hidden
            EndContext();
            BeginContext(338, 22, true);
            WriteLiteral("</p>\r\n        </div>\r\n");
            EndContext();
#line 15 "C:\Users\User\Desktop\ECommerce-App\ECommerce\Views\Home\index.cshtml"
    }

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ECommerce.ViewModels.HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
