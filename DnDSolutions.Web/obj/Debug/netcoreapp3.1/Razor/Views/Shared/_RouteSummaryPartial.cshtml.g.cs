#pragma checksum "D:\DnDSolutions\DnDSolutions.Web\Views\Shared\_RouteSummaryPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "171e2a83f1aee731a9ed983279f10f55e2b3e1e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__RouteSummaryPartial), @"mvc.1.0.view", @"/Views/Shared/_RouteSummaryPartial.cshtml")]
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
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"171e2a83f1aee731a9ed983279f10f55e2b3e1e4", @"/Views/Shared/_RouteSummaryPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1ceddae098880946682a3b718765ae61a6892d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__RouteSummaryPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RouteSummaryViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""card"">
	<div class=""card-header"">
		Route Summary
	</div>
	<ul class=""list-group list-group-flush"">
		<li class=""list-group-item"">
			<div class=""row"">
				<div class=""col"">
					<b>Pickup Location</b>
				</div>
				<div class=""col"">
					<b>Delivery Location</b>
				</div>
			</div>
		</li>
		<li class=""list-group-item"">
			<div class=""row"">
				<div class=""col"">
					");
#nullable restore
#line 21 "D:\DnDSolutions\DnDSolutions.Web\Views\Shared\_RouteSummaryPartial.cshtml"
               Write(Model.PickupLocation);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"col\">\r\n\t\t\t\t\t");
#nullable restore
#line 24 "D:\DnDSolutions\DnDSolutions.Web\Views\Shared\_RouteSummaryPartial.cshtml"
               Write(Model.DeliveryLocation);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
				</div>
			</div>
		</li>
		<li class=""list-group-item"">
			<div class=""row"">
				<div class=""col"">
					<b>Collection Date Earliest</b>
				</div>
				<div class=""col"">
					<b>Delivery Date Latest</b>
				</div>
			</div>
		</li>
		<li class=""list-group-item"">
			<div class=""row"">
				<div class=""col"">
					");
#nullable restore
#line 41 "D:\DnDSolutions\DnDSolutions.Web\Views\Shared\_RouteSummaryPartial.cshtml"
               Write(Model.CollectionDateEarliest.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"col\">\r\n\t\t\t\t\t");
#nullable restore
#line 44 "D:\DnDSolutions\DnDSolutions.Web\Views\Shared\_RouteSummaryPartial.cshtml"
               Write(Model.DeliveryDateLatest.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</li>\r\n\t</ul>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RouteSummaryViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
