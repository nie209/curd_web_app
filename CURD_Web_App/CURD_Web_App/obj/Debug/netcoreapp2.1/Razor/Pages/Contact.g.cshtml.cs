#pragma checksum "F:\University\ASP.Net core\CURD_app\curd_web_app\CURD_Web_App\CURD_Web_App\Pages\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2ea0001e28c537ddb102f26f521021dcf57c235"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CURD_Web_App.Pages.Pages_Contact), @"mvc.1.0.razor-page", @"/Pages/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Contact.cshtml", typeof(CURD_Web_App.Pages.Pages_Contact), null)]
namespace CURD_Web_App.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "F:\University\ASP.Net core\CURD_app\curd_web_app\CURD_Web_App\CURD_Web_App\Pages\_ViewImports.cshtml"
using CURD_Web_App;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2ea0001e28c537ddb102f26f521021dcf57c235", @"/Pages/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efa87d1c961ba22f26ea5ec52007bfcca550214e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Contact : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "F:\University\ASP.Net core\CURD_app\curd_web_app\CURD_Web_App\CURD_Web_App\Pages\Contact.cshtml"
  
    ViewData["Title"] = "Contact";

#line default
#line hidden
            BeginContext(66, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(71, 17, false);
#line 6 "F:\University\ASP.Net core\CURD_app\curd_web_app\CURD_Web_App\CURD_Web_App\Pages\Contact.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(88, 10, true);
            WriteLiteral("</h2>\n<h3>");
            EndContext();
            BeginContext(99, 13, false);
#line 7 "F:\University\ASP.Net core\CURD_app\curd_web_app\CURD_Web_App\CURD_Web_App\Pages\Contact.cshtml"
Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(112, 356, true);
            WriteLiteral(@"</h3>

<address>
    One Microsoft Way<br />
    Redmond, WA 98052-6399<br />
    <abbr title=""Phone"">P:</abbr>
    425.555.0100
</address>

<address>
    <strong>Support:</strong> <a href=""mailto:Support@example.com"">Support@example.com</a><br />
    <strong>Marketing:</strong> <a href=""mailto:Marketing@example.com"">Marketing@example.com</a>
</address>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContactModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContactModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContactModel>)PageContext?.ViewData;
        public ContactModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
