#pragma checksum "D:\Dev\repos\SensorWeb\SensorWeb\Views\Company\Index_original.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc51f8e191263bb274282841d5f2ae8ce85f0226"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Company_Index_original), @"mvc.1.0.view", @"/Views/Company/Index_original.cshtml")]
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
#line 1 "D:\Dev\repos\SensorWeb\SensorWeb\Views\_ViewImports.cshtml"
using SensorWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Dev\repos\SensorWeb\SensorWeb\Views\_ViewImports.cshtml"
using SensorWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc51f8e191263bb274282841d5f2ae8ce85f0226", @"/Views/Company/Index_original.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc3edcab5c525076ddb9767b99a274e7be94ac3b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Company_Index_original : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CompanyModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<h4 style=\"color:white; text-align:center\">");
#nullable restore
#line 6 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Company\Index_original.cshtml"
                                      Write(localizer.Get("CompanyTitle"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h4>\r\n<hr />\r\n<p>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 205, "\"", 245, 1);
#nullable restore
#line 9 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Company\Index_original.cshtml"
WriteAttributeValue("", 212, Url.Action("Create", "Company" ), 212, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 246, "\"", 279, 1);
#nullable restore
#line 9 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Company\Index_original.cshtml"
WriteAttributeValue("", 254, localizer.Get("Add new"), 254, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 295, "\"", 346, 1);
#nullable restore
#line 10 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Company\Index_original.cshtml"
WriteAttributeValue("", 301, Url.Content("~/Resources/new_rec_32x32.png"), 301, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </a>\r\n</p>\r\n<table class=\"table sclistTable\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Company\Index_original.cshtml"
           Write(Html.DisplayNameFor(modelItem => modelItem.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Company\Index_original.cshtml"
           Write(Html.DisplayNameFor(modelItem => modelItem.LegalName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Company\Index_original.cshtml"
           Write(Html.DisplayNameFor(modelItem => modelItem.Cnpj));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th class=\"sccentralize\">\r\n                ");
#nullable restore
#line 26 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Company\Index_original.cshtml"
           Write(Html.DisplayNameFor(modelItem => modelItem.UpdatedAt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th style=\"text-align:center\">\r\n                ");
#nullable restore
#line 30 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Company\Index_original.cshtml"
           Write(localizer.Get("Actions"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody class=\"sctbodyresult\">\r\n");
#nullable restore
#line 36 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Company\Index_original.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 40 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Company\Index_original.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 43 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Company\Index_original.cshtml"
               Write(Html.DisplayFor(modelItem => item.LegalName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 46 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Company\Index_original.cshtml"
               Write(Html.DisplayFor(modelItem => item.Cnpj));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"sccentralize\">\r\n                    ");
#nullable restore
#line 49 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Company\Index_original.cshtml"
               Write(Html.DisplayFor(modelItem => item.UpdatedAtSt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td style=\"text-align:center\">\r\n\r\n");
            WriteLiteral("\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1735, "\"", 1797, 1);
#nullable restore
#line 55 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Company\Index_original.cshtml"
WriteAttributeValue("", 1742, Url.Action("Details", "Company", new { id = item.Id }), 1742, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 1798, "\"", 1828, 1);
#nullable restore
#line 55 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Company\Index_original.cshtml"
WriteAttributeValue("", 1806, localizer.Get("View"), 1806, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"links\">\r\n                        <img alt=\"List View\" style=\"height:16px;width:23px;margin-right:15px\"");
            BeginWriteAttribute("src", " src=\"", 1939, "\"", 1983, 1);
#nullable restore
#line 56 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Company\Index_original.cshtml"
WriteAttributeValue("", 1945, Url.Content("~/Resources/visual.png"), 1945, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 2035, "\"", 2094, 1);
#nullable restore
#line 58 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Company\Index_original.cshtml"
WriteAttributeValue("", 2042, Url.Action("Edit", "Company", new { id = item.Id }), 2042, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 2095, "\"", 2125, 1);
#nullable restore
#line 58 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Company\Index_original.cshtml"
WriteAttributeValue("", 2103, localizer.Get("Edit"), 2103, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"links\">\r\n                        <img alt=\"List View\" style=\"margin-right: 15px\"");
            BeginWriteAttribute("src", " src=\"", 2214, "\"", 2263, 1);
#nullable restore
#line 59 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Company\Index_original.cshtml"
WriteAttributeValue("", 2220, Url.Content("~/Resources/lapis_16x16.png"), 2220, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </a>\r\n\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 2317, "\"", 2378, 1);
#nullable restore
#line 62 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Company\Index_original.cshtml"
WriteAttributeValue("", 2324, Url.Action("Delete", "Company", new { id = item.Id }), 2324, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 2379, "\"", 2411, 1);
#nullable restore
#line 62 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Company\Index_original.cshtml"
WriteAttributeValue("", 2387, localizer.Get("Delete"), 2387, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"links\">\r\n                        <img alt=\"List View\"");
            BeginWriteAttribute("src", " src=\"", 2473, "\"", 2520, 1);
#nullable restore
#line 63 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Company\Index_original.cshtml"
WriteAttributeValue("", 2479, Url.Content("~/Resources/exc_16x16.png"), 2479, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </a>\r\n                </td>\r\n                <td></td>\r\n            </tr>\r\n");
#nullable restore
#line 68 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Company\Index_original.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SensorWeb.Resources.CommonLocalizationService localizer { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CompanyModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
