#pragma checksum "D:\DnDSolutions\DnDSolutions.Web\Views\Manage\GenerateRecoveryCodes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68e62e9e699135bf95b99d91d74320996cd42b30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage_GenerateRecoveryCodes), @"mvc.1.0.view", @"/Views/Manage/GenerateRecoveryCodes.cshtml")]
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
#line 1 "D:\DnDSolutions\DnDSolutions.Web\Views\_ViewImports.cshtml"
using DnDSolutions.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DnDSolutions\DnDSolutions.Web\Views\_ViewImports.cshtml"
using DnDSolutions.Services.Models.Animals;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DnDSolutions\DnDSolutions.Web\Views\_ViewImports.cshtml"
using DnDSolutions.Services.Models.Boats;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\DnDSolutions\DnDSolutions.Web\Views\_ViewImports.cshtml"
using DnDSolutions.Services.Models.Freights;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\DnDSolutions\DnDSolutions.Web\Views\_ViewImports.cshtml"
using DnDSolutions.Services.Models.Vehicles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\DnDSolutions\DnDSolutions.Web\Views\_ViewImports.cshtml"
using DnDSolutions.Services.Models.HouseholdItemsAndMoves;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\DnDSolutions\DnDSolutions.Web\Views\_ViewImports.cshtml"
using DnDSolutions.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\DnDSolutions\DnDSolutions.Web\Views\_ViewImports.cshtml"
using DnDSolutions.Data.Models.Animals;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\DnDSolutions\DnDSolutions.Web\Views\_ViewImports.cshtml"
using DnDSolutions.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\DnDSolutions\DnDSolutions.Web\Views\_ViewImports.cshtml"
using DnDSolutions.Web.Models.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\DnDSolutions\DnDSolutions.Web\Views\_ViewImports.cshtml"
using DnDSolutions.Web.Models.Customers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\DnDSolutions\DnDSolutions.Web\Views\_ViewImports.cshtml"
using DnDSolutions.Web.Models.Transporters;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\DnDSolutions\DnDSolutions.Web\Views\_ViewImports.cshtml"
using DnDSolutions.Services.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\DnDSolutions\DnDSolutions.Web\Views\_ViewImports.cshtml"
using DnDSolutions.Web.Models.Vehicles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\DnDSolutions\DnDSolutions.Web\Views\_ViewImports.cshtml"
using DnDSolutions.Web.Models.Boats;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\DnDSolutions\DnDSolutions.Web\Views\_ViewImports.cshtml"
using DnDSolutions.Web.Models.Animals;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\DnDSolutions\DnDSolutions.Web\Views\_ViewImports.cshtml"
using DnDSolutions.Web.Models.HouseholdItemsAndMoves;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\DnDSolutions\DnDSolutions.Web\Views\_ViewImports.cshtml"
using DnDSolutions.Data.Models.HouseholdItemsAndMoves;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\DnDSolutions\DnDSolutions.Web\Views\_ViewImports.cshtml"
using DnDSolutions.Web.Models.Freights;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\DnDSolutions\DnDSolutions.Web\Views\_ViewImports.cshtml"
using DnDSolutions.Data.Models.Freights;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\DnDSolutions\DnDSolutions.Web\Views\_ViewImports.cshtml"
using DnDSolutions.Web.Models.Bids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\DnDSolutions\DnDSolutions.Web\Views\_ViewImports.cshtml"
using DnDSolutions.Web.Models.Deliveries;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\DnDSolutions\DnDSolutions.Web\Views\_ViewImports.cshtml"
using DnDSolutions.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\DnDSolutions\DnDSolutions.Web\Views\_ViewImports.cshtml"
using DnDSolutions.Web.Models.Messages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\DnDSolutions\DnDSolutions.Web\Views\Manage\_ViewImports.cshtml"
using DnDSolutions.Web.Views.Manage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DnDSolutions\DnDSolutions.Web\Views\Manage\_ViewImports.cshtml"
using DnDSolutions.Web.Models.Manage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DnDSolutions\DnDSolutions.Web\Views\Manage\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68e62e9e699135bf95b99d91d74320996cd42b30", @"/Views/Manage/GenerateRecoveryCodes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6237ba8e6e6d034ff6b1b77ab83394b44b8b0b4e", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1781a8638ebf87b44c15388b30ad8566bd4d3241", @"/Views/Manage/_ViewImports.cshtml")]
    public class Views_Manage_GenerateRecoveryCodes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GenerateRecoveryCodesViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\DnDSolutions\DnDSolutions.Web\Views\Manage\GenerateRecoveryCodes.cshtml"
  
    ViewData["Title"] = "Recovery codes";
    ViewData.AddActivePage(ManageNavPages.TwoFactorAuthentication);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4>");
#nullable restore
#line 7 "D:\DnDSolutions\DnDSolutions.Web\Views\Manage\GenerateRecoveryCodes.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
<div class=""alert alert-warning"" role=""alert"">
    <p>
        <span class=""glyphicon glyphicon-warning-sign""></span>
        <strong>Put these codes in a safe place.</strong>
    </p>
    <p>
        If you lose your device and don""t have the recovery codes you will lose access to your account.
    </p>
</div>
<div class=""row"">
    <div class=""col-md-12"">
");
#nullable restore
#line 19 "D:\DnDSolutions\DnDSolutions.Web\Views\Manage\GenerateRecoveryCodes.cshtml"
         for (var row = 0; row < Model.RecoveryCodes.Count(); row += 2)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <code>");
#nullable restore
#line 21 "D:\DnDSolutions\DnDSolutions.Web\Views\Manage\GenerateRecoveryCodes.cshtml"
             Write(Model.RecoveryCodes[row]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</code>");
            WriteLiteral("&nbsp;");
            WriteLiteral("<code>");
#nullable restore
#line 21 "D:\DnDSolutions\DnDSolutions.Web\Views\Manage\GenerateRecoveryCodes.cshtml"
                                                                      Write(Model.RecoveryCodes[row + 1]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</code><br />\r\n");
#nullable restore
#line 22 "D:\DnDSolutions\DnDSolutions.Web\Views\Manage\GenerateRecoveryCodes.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GenerateRecoveryCodesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
