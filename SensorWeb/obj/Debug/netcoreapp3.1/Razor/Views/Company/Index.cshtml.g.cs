#pragma checksum "D:\Dev\repos\SensorWeb\SensorWeb\Views\Company\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "815e0b0ba5e1d353159b09d2bbc3418cd8567f94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Company_Index), @"mvc.1.0.view", @"/Views/Company/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"815e0b0ba5e1d353159b09d2bbc3418cd8567f94", @"/Views/Company/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc3edcab5c525076ddb9767b99a274e7be94ac3b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Company_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CompanyModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"




<div class=""page-title"">
    <h3 class=""breadcrumb-header"">Cadastros</h3>
</div>


<div id=""main-wrapper"">
    <div class=""row"">

        <div class=""col-md-12"">

            <div class=""card card-white"">

                <div class=""card-heading clearfix"">

                    <table style=""width: 100%;"">
                        <tr>
                            <td><h4 class=""card-title"">");
#nullable restore
#line 25 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Company\Index.cshtml"
                                                  Write(localizer.Get("CompanyTitle"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></td>\r\n                            <td style=\"text-align:right\">\r\n\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 656, "\"", 696, 1);
#nullable restore
#line 28 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Company\Index.cshtml"
WriteAttributeValue("", 663, Url.Action("Create", "Company" ), 663, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 697, "\"", 730, 1);
#nullable restore
#line 28 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Company\Index.cshtml"
WriteAttributeValue("", 705, localizer.Get("Add new"), 705, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                    <button type=""button"" class=""btn btn-success btn-sm""><i class=""fas fa-plus""></i> </button>
                                </a>


                            </td>
                        </tr>

                    </table>

                </div>

                <div class=""card-body"">

                    <div class=""table-responsive"">
                        <table id=""example"" class=""display table"" style=""width:100%;text-align:center"">
                            <thead>
                                <tr>
                                    <th>
                                        ");
#nullable restore
#line 47 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Company\Index.cshtml"
                                   Write(Html.DisplayNameFor(modelItem => modelItem.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 50 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Company\Index.cshtml"
                                   Write(Html.DisplayNameFor(modelItem => modelItem.LegalName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 53 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Company\Index.cshtml"
                                   Write(Html.DisplayNameFor(modelItem => modelItem.Cnpj));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th class=\"sccentralize\">\r\n                                        ");
#nullable restore
#line 56 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Company\Index.cshtml"
                                   Write(Html.DisplayNameFor(modelItem => modelItem.UpdatedAt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n\r\n                                    <th style=\"text-align:center\">\r\n                                        ");
#nullable restore
#line 60 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Company\Index.cshtml"
                                   Write(localizer.Get("Actions"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th></th>\r\n                                </tr>\r\n                            </thead>\r\n\r\n                            <tbody>\r\n");
#nullable restore
#line 67 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Company\Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 71 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Company\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 74 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Company\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.LegalName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 77 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Company\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Cnpj));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td class=\"sccentralize\">\r\n                                            ");
#nullable restore
#line 80 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Company\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.UpdatedAtSt));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </td>
                                        <td>
                                            <table style=""width:100%"">
                                                <tr>
                                                    <td style=""padding:0 4px""><a");
            BeginWriteAttribute("href", " href=\"", 3519, "\"", 3581, 1);
#nullable restore
#line 85 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Company\Index.cshtml"
WriteAttributeValue("", 3526, Url.Action("Details", "Company", new { id = item.Id }), 3526, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 3582, "\"", 3612, 1);
#nullable restore
#line 85 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Company\Index.cshtml"
WriteAttributeValue("", 3590, localizer.Get("View"), 3590, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-eye\"></i></a></td>\r\n                                                    <td style=\"padding:0 4px\"><a");
            BeginWriteAttribute("href", " href=\"", 3731, "\"", 3790, 1);
#nullable restore
#line 86 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Company\Index.cshtml"
WriteAttributeValue("", 3738, Url.Action("Edit", "Company", new { id = item.Id }), 3738, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 3791, "\"", 3821, 1);
#nullable restore
#line 86 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Company\Index.cshtml"
WriteAttributeValue("", 3799, localizer.Get("Edit"), 3799, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-edit\" style=\"color:#ff6a00\"></i></a></td>\r\n                                                    <td style=\"padding:0 4px\"><a");
            BeginWriteAttribute("href", " href=\"", 3963, "\"", 4024, 1);
#nullable restore
#line 87 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Company\Index.cshtml"
WriteAttributeValue("", 3970, Url.Action("Delete", "Company", new { id = item.Id }), 3970, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 4025, "\"", 4057, 1);
#nullable restore
#line 87 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Company\Index.cshtml"
WriteAttributeValue("", 4033, localizer.Get("Delete"), 4033, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""color:#ff0000""><i class=""fas fa-window-close""></i></a></td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
");
#nullable restore
#line 92 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Company\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"





                            </tbody>

                        </table>
                    </div>
                </div>






            </div>
        </div>
    </div>

</div>

<!-- end page main wrapper -->
<div class=""page-footer"">
    <p>Iot Nest/Vibração &copy; <span class=""current-year""></span>. Conteúdo de uso exclusivo.</p>
</div>
");
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
