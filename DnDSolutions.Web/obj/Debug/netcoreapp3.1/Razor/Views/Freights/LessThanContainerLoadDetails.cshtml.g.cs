#pragma checksum "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfb00929522988d55998e92e7c9f1ebd63f3f19a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Freights_LessThanContainerLoadDetails), @"mvc.1.0.view", @"/Views/Freights/LessThanContainerLoadDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfb00929522988d55998e92e7c9f1ebd63f3f19a", @"/Views/Freights/LessThanContainerLoadDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6237ba8e6e6d034ff6b1b77ab83394b44b8b0b4e", @"/Views/_ViewImports.cshtml")]
    public class Views_Freights_LessThanContainerLoadDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LessThanContainerLoadDetailsViewModel>
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
#line 3 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
  
	ViewData["Title"] = "Less Than Container Load Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n\t");
#nullable restore
#line 8 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
Write(await Html.PartialAsync("_RouteSummaryPartial", Model.RouteSummary));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
	<div class=""card"">
		<div class=""card-header"">
			Less Than Container Load Details
		</div>
		<ul class=""list-group list-group-flush"">
			<li class=""list-group-item"">
				<div class=""row"">
					<div class=""col"">
						<b>Quantity</b>
					</div>
					<div class=""col"">
						<b>Type</b>
					</div>
					<div class=""col"">
						<b>Handling Unit</b>
					</div>
					<div class=""col"">
						<b>Is Stackable</b>
					</div>
					<div class=""col"">
						<b>Is Hazardous</b>
					</div>
				</div>
			</li>
			<li class=""list-group-item"">
				<div class=""row"">
					<div class=""col"">
						");
#nullable restore
#line 36 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
                   Write(Model.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"col\">\r\n\t\t\t\t\t\t");
#nullable restore
#line 39 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
                   Write(Model.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"col\">\r\n\t\t\t\t\t\t");
#nullable restore
#line 42 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
                   Write(Model.HandlingUnit);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"col\">\r\n\t\t\t\t\t\t");
#nullable restore
#line 45 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
                    Write(Model.IsStackable ? "Yes" : "No");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"col\">\r\n\t\t\t\t\t\t");
#nullable restore
#line 48 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
                    Write(Model.IsHazardous ? "Yes" : "No");

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
#line 71 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
                         if (Model.LengthFirstPart > 0)
						{
							

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
                             if (Model.MeasurementUnit == MeasurementUnit.Metric)
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<span>\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 76 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
                               Write(Model.LengthFirstPart);

#line default
#line hidden
#nullable disable
            WriteLiteral(" m\r\n\t\t\t\t\t\t\t\t</span>\r\n");
#nullable restore
#line 78 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
							}
							else
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<span>\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 82 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
                               Write(Model.LengthFirstPart);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ft\r\n\t\t\t\t\t\t\t\t</span>\r\n");
#nullable restore
#line 84 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
							}

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
                             
						}

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
                         if (Model.LengthSecondPart != null && Model.LengthSecondPart > 0)
						{
							

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
                             if (Model.MeasurementUnit == MeasurementUnit.Metric)
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<span>\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 91 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
                               Write(Model.LengthSecondPart);

#line default
#line hidden
#nullable disable
            WriteLiteral(" cm\r\n\t\t\t\t\t\t\t\t</span>\r\n");
#nullable restore
#line 93 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
							}
							else
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<span>\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 97 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
                               Write(Model.LengthSecondPart);

#line default
#line hidden
#nullable disable
            WriteLiteral(" in\r\n\t\t\t\t\t\t\t\t</span>\r\n");
#nullable restore
#line 99 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
							}

#line default
#line hidden
#nullable disable
#nullable restore
#line 99 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
                             
						}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"col\">\r\n");
#nullable restore
#line 103 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
                         if (Model.WidthFirstPart > 0)
						{
							

#line default
#line hidden
#nullable disable
#nullable restore
#line 105 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
                             if (Model.MeasurementUnit == MeasurementUnit.Metric)
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<span>\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 108 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
                               Write(Model.WidthFirstPart);

#line default
#line hidden
#nullable disable
            WriteLiteral(" m\r\n\t\t\t\t\t\t\t\t</span>\r\n");
#nullable restore
#line 110 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
							}
							else
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<span>\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 114 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
                               Write(Model.WidthFirstPart);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ft\r\n\t\t\t\t\t\t\t\t</span>\r\n");
#nullable restore
#line 116 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
							}

#line default
#line hidden
#nullable disable
#nullable restore
#line 116 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
                             
						}

#line default
#line hidden
#nullable disable
#nullable restore
#line 118 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
                         if (Model.WidthSecondPart != null && Model.WidthSecondPart > 0)
						{
							

#line default
#line hidden
#nullable disable
#nullable restore
#line 120 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
                             if (Model.MeasurementUnit == MeasurementUnit.Metric)
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<span>\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 123 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
                               Write(Model.WidthSecondPart);

#line default
#line hidden
#nullable disable
            WriteLiteral(" cm\r\n\t\t\t\t\t\t\t\t</span>\r\n");
#nullable restore
#line 125 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
							}
							else
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<span>\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 129 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
                               Write(Model.WidthSecondPart);

#line default
#line hidden
#nullable disable
            WriteLiteral(" in\r\n\t\t\t\t\t\t\t\t</span>\r\n");
#nullable restore
#line 131 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
							}

#line default
#line hidden
#nullable disable
#nullable restore
#line 131 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
                             
						}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"col\">\r\n");
#nullable restore
#line 135 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
                         if (Model.HeightFirstPart > 0)
						{
							

#line default
#line hidden
#nullable disable
#nullable restore
#line 137 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
                             if (Model.MeasurementUnit == MeasurementUnit.Metric)
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<span>\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 140 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
                               Write(Model.HeightFirstPart);

#line default
#line hidden
#nullable disable
            WriteLiteral(" m\r\n\t\t\t\t\t\t\t\t</span>\r\n");
#nullable restore
#line 142 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
							}
							else
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<span>\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 146 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
                               Write(Model.HeightFirstPart);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ft\r\n\t\t\t\t\t\t\t\t</span>\r\n");
#nullable restore
#line 148 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
							}

#line default
#line hidden
#nullable disable
#nullable restore
#line 148 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
                             
						}

#line default
#line hidden
#nullable disable
#nullable restore
#line 150 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
                         if (Model.HeightSecondPart != null && Model.HeightSecondPart > 0)
						{
							

#line default
#line hidden
#nullable disable
#nullable restore
#line 152 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
                             if (Model.MeasurementUnit == MeasurementUnit.Metric)
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<span>\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 155 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
                               Write(Model.HeightSecondPart);

#line default
#line hidden
#nullable disable
            WriteLiteral(" cm\r\n\t\t\t\t\t\t\t\t</span>\r\n");
#nullable restore
#line 157 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
							}
							else
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<span>\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 161 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
                               Write(Model.HeightSecondPart);

#line default
#line hidden
#nullable disable
            WriteLiteral(" in\r\n\t\t\t\t\t\t\t\t</span>\r\n");
#nullable restore
#line 163 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
							}

#line default
#line hidden
#nullable disable
#nullable restore
#line 163 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
                             
						}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"col\">\r\n\t\t\t\t\t\t");
#nullable restore
#line 167 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
                    Write(Model.MeasurementUnit == MeasurementUnit.Metric ? $"{Model.Weight} kg" : $"{Model.Weight} lbs");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</li>\r\n");
#nullable restore
#line 171 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
             if (Model.Photos.Any())
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<li class=\"list-group-item\">\r\n\t\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t\t<div class=\"col\">\r\n\t\t\t\t\t\t\t<b>Photos</b>\r\n\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 178 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
                         foreach (var photo in Model.Photos)
						{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t<div class=\"col\">\r\n\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dfb00929522988d55998e92e7c9f1ebd63f3f19a23235", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3991, "~/images/", 3991, 9, true);
#nullable restore
#line 181 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
AddHtmlAttributeValue("", 4000, photo.Path, 4000, 11, false);

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
#line 183 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
						}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t</div>\r\n\t\t\t\t</li>\r\n");
#nullable restore
#line 186 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t</ul>\r\n\t</div>\r\n");
#nullable restore
#line 189 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
     if (Model.AdditionalDetails != null)
	{
		

#line default
#line hidden
#nullable disable
#nullable restore
#line 191 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
   Write(await Html.PartialAsync("_AdditionalDetailsPartial", Model.AdditionalDetails));

#line default
#line hidden
#nullable disable
#nullable restore
#line 191 "D:\DnDSolutions\DnDSolutions.Web\Views\Freights\LessThanContainerLoadDetails.cshtml"
                                                                                      
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LessThanContainerLoadDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
