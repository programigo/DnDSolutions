#pragma checksum "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "189fe18c77705110d0c088bb29db83ae0d6bfbbd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vehicles_RecreationalVehicleDetails), @"mvc.1.0.view", @"/Views/Vehicles/RecreationalVehicleDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"189fe18c77705110d0c088bb29db83ae0d6bfbbd", @"/Views/Vehicles/RecreationalVehicleDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6237ba8e6e6d034ff6b1b77ab83394b44b8b0b4e", @"/Views/_ViewImports.cshtml")]
    public class Views_Vehicles_RecreationalVehicleDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RecreationalVehicleDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
  
	ViewData["Title"] = "Recreational Vehicle Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n\t<h4><b>");
#nullable restore
#line 8 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
      Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h4>\r\n\t");
#nullable restore
#line 9 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
Write(await Html.PartialAsync("_RouteSummaryPartial", Model.RouteSummary));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
	<div class=""card"">
		<div class=""card-header"">
			Recreational Vehicle Details
		</div>
		<ul class=""list-group list-group-flush"">
			<li class=""list-group-item"">
				<div class=""row"">
					<div class=""col"">
						<b>Type</b>
					</div>
					<div class=""col"">
						<b>Year</b>
					</div>
					<div class=""col"">
						<b>Make</b>
					</div>
					<div class=""col"">
						<b>Model</b>
					</div>
				</div>
			</li>
			<li class=""list-group-item"">
				<div class=""row"">
					<div class=""col"">
						");
#nullable restore
#line 34 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
                   Write(Model.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"col\">\r\n\t\t\t\t\t\t");
#nullable restore
#line 37 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
                   Write(Model.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"col\">\r\n\t\t\t\t\t\t");
#nullable restore
#line 40 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
                   Write(Model.Make);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"col\">\r\n\t\t\t\t\t\t");
#nullable restore
#line 43 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
                   Write(Model.Model);

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
						<b>Length</b>
					</div>
					<div class=""col"">
						<b>Width</b>
					</div>
					<div class=""col"">
						<b>Height</b>
					</div>
					<div class=""col"">
						<b>Weight</b>
					</div>
				</div>
			</li>
			<li class=""list-group-item"">
				<div class=""row"">
					<div class=""col"">
");
#nullable restore
#line 66 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
                         if (Model.LengthFirstPart > 0)
						{
							

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
                             if (Model.MeasurementUnit == MeasurementUnit.Metric)
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<span>\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 71 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
                               Write(Model.LengthFirstPart);

#line default
#line hidden
#nullable disable
            WriteLiteral(" m\r\n\t\t\t\t\t\t\t\t</span>\r\n");
#nullable restore
#line 73 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
							}
							else
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<span>\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 77 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
                               Write(Model.LengthFirstPart);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ft\r\n\t\t\t\t\t\t\t\t</span>\r\n");
#nullable restore
#line 79 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
							}

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
                             
						}

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
                         if (Model.LengthSecondPart != null && Model.LengthSecondPart > 0)
						{
							

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
                             if (Model.MeasurementUnit == MeasurementUnit.Metric)
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<span>\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 86 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
                               Write(Model.LengthSecondPart);

#line default
#line hidden
#nullable disable
            WriteLiteral(" cm\r\n\t\t\t\t\t\t\t\t</span>\r\n");
#nullable restore
#line 88 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
							}
							else
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<span>\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 92 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
                               Write(Model.LengthSecondPart);

#line default
#line hidden
#nullable disable
            WriteLiteral(" in\r\n\t\t\t\t\t\t\t\t</span>\r\n");
#nullable restore
#line 94 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
							}

#line default
#line hidden
#nullable disable
#nullable restore
#line 94 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
                             
						}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"col\">\r\n");
#nullable restore
#line 98 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
                         if (Model.WidthFirstPart > 0)
						{
							

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
                             if (Model.MeasurementUnit == MeasurementUnit.Metric)
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<span>\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 103 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
                               Write(Model.WidthFirstPart);

#line default
#line hidden
#nullable disable
            WriteLiteral(" m\r\n\t\t\t\t\t\t\t\t</span>\r\n");
#nullable restore
#line 105 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
							}
							else
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<span>\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 109 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
                               Write(Model.WidthFirstPart);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ft\r\n\t\t\t\t\t\t\t\t</span>\r\n");
#nullable restore
#line 111 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
							}

#line default
#line hidden
#nullable disable
#nullable restore
#line 111 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
                             
						}

#line default
#line hidden
#nullable disable
#nullable restore
#line 113 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
                         if (Model.WidthSecondPart != null && Model.WidthSecondPart > 0)
						{
							

#line default
#line hidden
#nullable disable
#nullable restore
#line 115 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
                             if (Model.MeasurementUnit == MeasurementUnit.Metric)
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<span>\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 118 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
                               Write(Model.WidthSecondPart);

#line default
#line hidden
#nullable disable
            WriteLiteral(" cm\r\n\t\t\t\t\t\t\t\t</span>\r\n");
#nullable restore
#line 120 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
							}
							else
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<span>\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 124 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
                               Write(Model.WidthSecondPart);

#line default
#line hidden
#nullable disable
            WriteLiteral(" in\r\n\t\t\t\t\t\t\t\t</span>\r\n");
#nullable restore
#line 126 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
							}

#line default
#line hidden
#nullable disable
#nullable restore
#line 126 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
                             
						}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"col\">\r\n");
#nullable restore
#line 130 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
                         if (Model.HeightFirstPart > 0)
						{
							

#line default
#line hidden
#nullable disable
#nullable restore
#line 132 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
                             if (Model.MeasurementUnit == MeasurementUnit.Metric)
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<span>\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 135 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
                               Write(Model.HeightFirstPart);

#line default
#line hidden
#nullable disable
            WriteLiteral(" m\r\n\t\t\t\t\t\t\t\t</span>\r\n");
#nullable restore
#line 137 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
							}
							else
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<span>\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 141 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
                               Write(Model.HeightFirstPart);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ft\r\n\t\t\t\t\t\t\t\t</span>\r\n");
#nullable restore
#line 143 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
							}

#line default
#line hidden
#nullable disable
#nullable restore
#line 143 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
                             
						}

#line default
#line hidden
#nullable disable
#nullable restore
#line 145 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
                         if (Model.HeightSecondPart != null && Model.HeightSecondPart > 0)
						{
							

#line default
#line hidden
#nullable disable
#nullable restore
#line 147 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
                             if (Model.MeasurementUnit == MeasurementUnit.Metric)
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<span>\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 150 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
                               Write(Model.HeightSecondPart);

#line default
#line hidden
#nullable disable
            WriteLiteral(" cm\r\n\t\t\t\t\t\t\t\t</span>\r\n");
#nullable restore
#line 152 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
							}
							else
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<span>\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 156 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
                               Write(Model.HeightSecondPart);

#line default
#line hidden
#nullable disable
            WriteLiteral(" in\r\n\t\t\t\t\t\t\t\t</span>\r\n");
#nullable restore
#line 158 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
							}

#line default
#line hidden
#nullable disable
#nullable restore
#line 158 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
                             
						}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"col\">\r\n\t\t\t\t\t\t");
#nullable restore
#line 162 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
                    Write(Model.MeasurementUnit == MeasurementUnit.Metric ? $"{Model.Weight} kg" : $"{Model.Weight} lbs");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</li>\r\n\t\t\t<li class=\"list-group-item\">\r\n\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t<div class=\"col\">\r\n\t\t\t\t\t\t<b>Weight</b>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"col\">\r\n");
#nullable restore
#line 172 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
                         if (Model.CanBeDriven != null)
						{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t<b>Can Be Driven</b>\r\n");
#nullable restore
#line 175 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
						}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</li>\r\n\t\t\t<li class=\"list-group-item\">\r\n\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t<div class=\"col\">\r\n\t\t\t\t\t\t");
#nullable restore
#line 182 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
                   Write(Model.Weight);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"col\">\r\n");
#nullable restore
#line 185 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
                         if (Model.CanBeDriven != null)
						{
							if (Model.CanBeDriven == true)
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<span>Yes</span>\r\n");
#nullable restore
#line 190 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
							}
							else
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<span>No</span>\r\n");
#nullable restore
#line 194 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
							}
						}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</li>\r\n");
#nullable restore
#line 199 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
             if (Model.Photos.Any())
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<li class=\"list-group-item\">\r\n\t\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t\t<div class=\"col\">\r\n\t\t\t\t\t\t\t<b>Photos</b>\r\n\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 206 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
                         foreach (var photo in Model.Photos)
						{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t<div class=\"col\">\r\n\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "189fe18c77705110d0c088bb29db83ae0d6bfbbd24940", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4451, "~/images/", 4451, 9, true);
#nullable restore
#line 209 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
AddHtmlAttributeValue("", 4460, photo.Path, 4460, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 211 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
						}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t</div>\r\n\t\t\t\t</li>\r\n");
#nullable restore
#line 214 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t</ul>\r\n\t</div>\r\n");
#nullable restore
#line 217 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
     if (Model.AdditionalDetails != null)
	{
		

#line default
#line hidden
#nullable disable
#nullable restore
#line 219 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
   Write(await Html.PartialAsync("_AdditionalDetailsPartial", Model.AdditionalDetails));

#line default
#line hidden
#nullable disable
#nullable restore
#line 219 "D:\DnDSolutions\DnDSolutions.Web\Views\Vehicles\RecreationalVehicleDetails.cshtml"
                                                                                      
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RecreationalVehicleDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
