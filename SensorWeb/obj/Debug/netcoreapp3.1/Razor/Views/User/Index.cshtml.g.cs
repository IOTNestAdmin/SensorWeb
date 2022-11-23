#pragma checksum "D:\Dev\repos\SensorWeb\SensorWeb\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04deb659ae90ac81218f48e1ada517214eced43a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04deb659ae90ac81218f48e1ada517214eced43a", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc3edcab5c525076ddb9767b99a274e7be94ac3b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<UserModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
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
#line 22 "D:\Dev\repos\SensorWeb\SensorWeb\Views\User\Index.cshtml"
                                                  Write(localizer.Get("UserTitle"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></td>\r\n                            <td style=\"text-align:right\">\r\n\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 644, "\"", 681, 1);
#nullable restore
#line 25 "D:\Dev\repos\SensorWeb\SensorWeb\Views\User\Index.cshtml"
WriteAttributeValue("", 651, Url.Action("Create", "User" ), 651, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 682, "\"", 715, 1);
#nullable restore
#line 25 "D:\Dev\repos\SensorWeb\SensorWeb\Views\User\Index.cshtml"
WriteAttributeValue("", 690, localizer.Get("Add new"), 690, 25, false);

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
#line 44 "D:\Dev\repos\SensorWeb\SensorWeb\Views\User\Index.cshtml"
                                   Write(Html.DisplayNameFor(modelItem => modelItem.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 47 "D:\Dev\repos\SensorWeb\SensorWeb\Views\User\Index.cshtml"
                                   Write(Html.DisplayNameFor(modelItem => modelItem.Contact.NomeCompleto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 50 "D:\Dev\repos\SensorWeb\SensorWeb\Views\User\Index.cshtml"
                                   Write(Html.DisplayNameFor(modelItem => modelItem.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th class=\"sccentralize\">\r\n                                        ");
#nullable restore
#line 53 "D:\Dev\repos\SensorWeb\SensorWeb\Views\User\Index.cshtml"
                                   Write(Html.DisplayNameFor(modelItem => modelItem.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n\r\n                                    <th style=\"text-align:center\">\r\n                                        ");
#nullable restore
#line 57 "D:\Dev\repos\SensorWeb\SensorWeb\Views\User\Index.cshtml"
                                   Write(localizer.Get("Actions"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th></th>\r\n                                </tr>\r\n                            </thead>\r\n\r\n                            <tbody>\r\n");
#nullable restore
#line 64 "D:\Dev\repos\SensorWeb\SensorWeb\Views\User\Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 68 "D:\Dev\repos\SensorWeb\SensorWeb\Views\User\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 71 "D:\Dev\repos\SensorWeb\SensorWeb\Views\User\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Contact.NomeCompleto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 74 "D:\Dev\repos\SensorWeb\SensorWeb\Views\User\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td class=\"sccentralize\">\r\n                                            ");
#nullable restore
#line 77 "D:\Dev\repos\SensorWeb\SensorWeb\Views\User\Index.cshtml"
                                       Write(Html.CheckBoxFor(modelItem => item.IsActiveBool));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </td>
                                        <td>
                                            <table style=""width:100%"">
                                                <tr>
                                                    <td style=""padding:0 4px""><a");
            BeginWriteAttribute("href", " href=\"", 3529, "\"", 3588, 1);
#nullable restore
#line 82 "D:\Dev\repos\SensorWeb\SensorWeb\Views\User\Index.cshtml"
WriteAttributeValue("", 3536, Url.Action("Details", "User", new { id = item.Id }), 3536, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 3589, "\"", 3619, 1);
#nullable restore
#line 82 "D:\Dev\repos\SensorWeb\SensorWeb\Views\User\Index.cshtml"
WriteAttributeValue("", 3597, localizer.Get("View"), 3597, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-eye\"></i></a></td>\r\n                                                    <td style=\"padding:0 4px\"><a");
            BeginWriteAttribute("href", " href=\"", 3738, "\"", 3794, 1);
#nullable restore
#line 83 "D:\Dev\repos\SensorWeb\SensorWeb\Views\User\Index.cshtml"
WriteAttributeValue("", 3745, Url.Action("Edit", "User", new { id = item.Id }), 3745, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 3795, "\"", 3825, 1);
#nullable restore
#line 83 "D:\Dev\repos\SensorWeb\SensorWeb\Views\User\Index.cshtml"
WriteAttributeValue("", 3803, localizer.Get("Edit"), 3803, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-edit\" style=\"color:#ff6a00\"></i></a></td>\r\n                                                    <td style=\"padding:0 4px\"><a");
            BeginWriteAttribute("href", " href=\"", 3967, "\"", 4025, 1);
#nullable restore
#line 84 "D:\Dev\repos\SensorWeb\SensorWeb\Views\User\Index.cshtml"
WriteAttributeValue("", 3974, Url.Action("Delete", "User", new { id = item.Id }), 3974, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 4026, "\"", 4058, 1);
#nullable restore
#line 84 "D:\Dev\repos\SensorWeb\SensorWeb\Views\User\Index.cshtml"
WriteAttributeValue("", 4034, localizer.Get("Delete"), 4034, 24, false);

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
#line 89 "D:\Dev\repos\SensorWeb\SensorWeb\Views\User\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<UserModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
