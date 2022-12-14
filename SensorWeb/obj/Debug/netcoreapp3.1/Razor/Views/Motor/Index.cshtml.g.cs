#pragma checksum "D:\Dev\repos\SensorWeb\SensorWeb\Views\Motor\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e327170671a050131852f2918a67e619e55f6f2c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Motor_Index), @"mvc.1.0.view", @"/Views/Motor/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e327170671a050131852f2918a67e619e55f6f2c", @"/Views/Motor/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc3edcab5c525076ddb9767b99a274e7be94ac3b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Motor_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MotorModel>>
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
#line 23 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Motor\Index.cshtml"
                                                  Write(localizer.Get("MotorTitle"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></td>\r\n                            <td style=\"text-align:right\">\r\n\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 648, "\"", 686, 1);
#nullable restore
#line 26 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Motor\Index.cshtml"
WriteAttributeValue("", 655, Url.Action("Create", "Motor" ), 655, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 687, "\"", 720, 1);
#nullable restore
#line 26 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Motor\Index.cshtml"
WriteAttributeValue("", 695, localizer.Get("Add new"), 695, 25, false);

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
#line 43 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Motor\Index.cshtml"
                                   Write(Html.DisplayNameFor(modelItem => modelItem.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 46 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Motor\Index.cshtml"
                                   Write(Html.DisplayNameFor(modelItem => modelItem.Tag));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 49 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Motor\Index.cshtml"
                                   Write(Html.DisplayNameFor(modelItem => modelItem.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 52 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Motor\Index.cshtml"
                                   Write(Html.DisplayNameFor(modelItem => modelItem.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n");
            WriteLiteral(@"                                    <th style=""text-align:center"">
                                        A????es
                                    </th>
                                    <th></th>
                                </tr>
                            </thead>

                            <tbody>
");
#nullable restore
#line 65 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Motor\Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 69 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Motor\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 72 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Motor\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Tag));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 75 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Motor\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 78 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Motor\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </td>
                                    <td>
                                        <table style=""width:100%"">
                                            <tr>
                                                <td style=""padding:0 4px""><a");
            BeginWriteAttribute("href", " href=\"", 3561, "\"", 3621, 1);
#nullable restore
#line 83 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Motor\Index.cshtml"
WriteAttributeValue("", 3568, Url.Action("Details", "Motor", new { id = item.Id }), 3568, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 3622, "\"", 3652, 1);
#nullable restore
#line 83 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Motor\Index.cshtml"
WriteAttributeValue("", 3630, localizer.Get("View"), 3630, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-eye\"></i></a></td>\r\n                                                <td style=\"padding:0 4px\"><a");
            BeginWriteAttribute("href", " href=\"", 3767, "\"", 3824, 1);
#nullable restore
#line 84 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Motor\Index.cshtml"
WriteAttributeValue("", 3774, Url.Action("Edit", "Motor", new { id = item.Id }), 3774, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 3825, "\"", 3855, 1);
#nullable restore
#line 84 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Motor\Index.cshtml"
WriteAttributeValue("", 3833, localizer.Get("Edit"), 3833, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-edit\" style=\"color:#ff6a00\"></i></a></td>\r\n                                                <td style=\"padding:0 4px\"><a");
            BeginWriteAttribute("href", " href=\"", 3993, "\"", 4052, 1);
#nullable restore
#line 85 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Motor\Index.cshtml"
WriteAttributeValue("", 4000, Url.Action("Delete", "Motor", new { id = item.Id }), 4000, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 4053, "\"", 4085, 1);
#nullable restore
#line 85 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Motor\Index.cshtml"
WriteAttributeValue("", 4061, localizer.Get("Delete"), 4061, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:#ff0000\"><i class=\"fas fa-window-close\"></i></a></td>\r\n                                            </tr>\r\n                                        </table>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 90 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Motor\Index.cshtml"
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
    <p>Iot Nest/Vibra????o &copy; <span class=""current-year""></span>. Conte??do de uso exclusivo.</p>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MotorModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
