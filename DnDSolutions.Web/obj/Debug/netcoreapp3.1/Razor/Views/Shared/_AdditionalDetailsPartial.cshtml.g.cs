#pragma checksum "D:\DnDSolutions\DnDSolutions.Web\Views\Shared\_AdditionalDetailsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b254ad7785460005b37ed968aed0d14c4efcf98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AdditionalDetailsPartial), @"mvc.1.0.view", @"/Views/Shared/_AdditionalDetailsPartial.cshtml")]
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
#line 25 "D:\DnDSolutions\DnDSolutions.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b254ad7785460005b37ed968aed0d14c4efcf98", @"/Views/Shared/_AdditionalDetailsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6237ba8e6e6d034ff6b1b77ab83394b44b8b0b4e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__AdditionalDetailsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"card\">\r\n\t<div class=\"card-header\">\r\n\t\tAdditional Details\r\n\t</div>\r\n\t<div class=\"card-body\">\r\n\t\t");
#nullable restore
#line 8 "D:\DnDSolutions\DnDSolutions.Web\Views\Shared\_AdditionalDetailsPartial.cshtml"
   Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591
