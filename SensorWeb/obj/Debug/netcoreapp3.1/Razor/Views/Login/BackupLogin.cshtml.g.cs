#pragma checksum "D:\Dev\repos\SensorWeb\SensorWeb\Views\Login\BackupLogin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc77f7677d833078970b91f27b60ba0c415ba407"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_BackupLogin), @"mvc.1.0.view", @"/Views/Login/BackupLogin.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc77f7677d833078970b91f27b60ba0c415ba407", @"/Views/Login/BackupLogin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc3edcab5c525076ddb9767b99a274e7be94ac3b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Login_BackupLogin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("login100-form validate-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Login"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Login\BackupLogin.cshtml"
  
    ViewData["Title"] = "Login";
    Layout = "~/Views/Shared/_LayoutLoginPage.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"pt-br\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc77f7677d833078970b91f27b60ba0c415ba4074830", async() => {
                WriteLiteral(@"

    <title>VibrationSensor</title>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <!--===============================================================================================-->
    <link rel=""stylesheet"" type=""text/css""");
                BeginWriteAttribute("href", " href=\"", 502, "\"", 565, 1);
#nullable restore
#line 16 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Login\BackupLogin.cshtml"
WriteAttributeValue("", 509, Url.Content("~/vendor/bootstrap/css/bootstrap.min.css"), 509, 56, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <!--===============================================================================================-->\r\n    <link rel=\"stylesheet\" type=\"text/css\"");
                BeginWriteAttribute("href", " href=\"", 719, "\"", 793, 1);
#nullable restore
#line 18 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Login\BackupLogin.cshtml"
WriteAttributeValue("", 726, Url.Content("~/fonts/font-awesome-4.7.0/css/font-awesome.min.css"), 726, 67, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <!--===============================================================================================-->\r\n    <link rel=\"stylesheet\" type=\"text/css\"");
                BeginWriteAttribute("href", " href=\"", 947, "\"", 1019, 1);
#nullable restore
#line 20 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Login\BackupLogin.cshtml"
WriteAttributeValue("", 954, Url.Content("~/fonts/Linearicons-Free-v1.0.0/icon-font.min.css"), 954, 65, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <!--===============================================================================================-->\r\n    <link rel=\"stylesheet\" type=\"text/css\"");
                BeginWriteAttribute("href", " href=\"", 1173, "\"", 1224, 1);
#nullable restore
#line 22 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Login\BackupLogin.cshtml"
WriteAttributeValue("", 1180, Url.Content("~/vendor/animate/animate.css"), 1180, 44, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <!--===============================================================================================-->\r\n    <link rel=\"stylesheet\" type=\"text/css\"");
                BeginWriteAttribute("href", " href=\"", 1378, "\"", 1443, 1);
#nullable restore
#line 24 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Login\BackupLogin.cshtml"
WriteAttributeValue("", 1385, Url.Content("~/vendor/css-hamburgers/hamburgers.min.css"), 1385, 58, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <!--===============================================================================================-->\r\n    <link rel=\"stylesheet\" type=\"text/css\"");
                BeginWriteAttribute("href", " href=\"", 1597, "\"", 1662, 1);
#nullable restore
#line 26 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Login\BackupLogin.cshtml"
WriteAttributeValue("", 1604, Url.Content("~/vendor/animsition/css/animsition.min.css"), 1604, 58, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <!--===============================================================================================-->\r\n    <link rel=\"stylesheet\" type=\"text/css\"");
                BeginWriteAttribute("href", " href=\"", 1816, "\"", 1871, 1);
#nullable restore
#line 28 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Login\BackupLogin.cshtml"
WriteAttributeValue("", 1823, Url.Content("~/vendor/select2/select2.min.css"), 1823, 48, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <!--===============================================================================================-->\r\n\r\n    <link rel=\"stylesheet\" type=\"text/css\"");
                BeginWriteAttribute("href", " href=\"", 2027, "\"", 2094, 1);
#nullable restore
#line 31 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Login\BackupLogin.cshtml"
WriteAttributeValue("", 2034, Url.Content("~/vendor/daterangepicker/daterangepicker.css"), 2034, 60, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <!--===============================================================================================-->\r\n    <link rel=\"stylesheet\" type=\"text/css\"");
                BeginWriteAttribute("href", " href=\"", 2248, "\"", 2285, 1);
#nullable restore
#line 33 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Login\BackupLogin.cshtml"
WriteAttributeValue("", 2255, Url.Content("~/css/util.css"), 2255, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <link rel=\"stylesheet\" type=\"text/css\"");
                BeginWriteAttribute("href", " href=\"", 2331, "\"", 2368, 1);
#nullable restore
#line 34 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Login\BackupLogin.cshtml"
WriteAttributeValue("", 2338, Url.Content("~/css/main.css"), 2338, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <!--===============================================================================================-->\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc77f7677d833078970b91f27b60ba0c415ba40711532", async() => {
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 40 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Login\BackupLogin.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <div class=\"limiter\"");
                BeginWriteAttribute("style", " style=\"", 2557, "\"", 2655, 5);
                WriteAttributeValue(" ", 2565, "background:repeat;", 2566, 19, true);
                WriteAttributeValue(" ", 2584, "background-image:", 2585, 18, true);
                WriteAttributeValue(" ", 2602, "url(\'", 2603, 6, true);
#nullable restore
#line 42 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Login\BackupLogin.cshtml"
WriteAttributeValue("", 2608, Url.Content("~/Resources/fundo_login.png"), 2608, 43, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 2651, "\');", 2652, 4, true);
                EndWriteAttribute();
                WriteLiteral(@">
        <div class=""container-login100"">
            <div class=""wrap-login100"">
                <div class=""login100-form-title"" style=""background-image: url('images/bg-01.jpg');"">

                    <span class=""login100-form-title-1"">
                        ");
#nullable restore
#line 48 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Login\BackupLogin.cshtml"
                   Write(localizer.Get("RestrictedAccess"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </span>\r\n                </div>\r\n\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc77f7677d833078970b91f27b60ba0c415ba40713363", async() => {
                    WriteLiteral("\r\n                    <div class=\"wrap-input100 validate-input m-b-26\" data-validate=\"Usu??rio obrigat??rio\">\r\n                        <span class=\"label-input100\">");
#nullable restore
#line 54 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Login\BackupLogin.cshtml"
                                                Write(localizer.Get("User"));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</span>\r\n                        <input class=\"input100\" type=\"text\" name=\"username\" ");
                    WriteLiteral(">\r\n                        <span class=\"focus-input100\"></span>\r\n                    </div>\r\n\r\n                    <div class=\"wrap-input100 validate-input m-b-18\" data-validate=\"Senha Obrigat??ria\">\r\n                        <span class=\"label-input100\">");
#nullable restore
#line 60 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Login\BackupLogin.cshtml"
                                                Write(localizer.Get("Pass"));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</span>\r\n                        <input class=\"input100\" type=\"password\" name=\"pass\" ");
                    WriteLiteral(">\r\n                        <span class=\"focus-input100\"></span>\r\n                    </div>\r\n\r\n");
                    WriteLiteral("\r\n                    <div class=\"container-login100-form-btn\">\r\n                        <button class=\"login100-form-btn\" type=\"submit\">\r\n                            Login\r\n                        </button>\r\n                    </div>\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <!--===============================================================================================-->\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 5013, "\"", 5070, 1);
#nullable restore
#line 91 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Login\BackupLogin.cshtml"
WriteAttributeValue("", 5019, Url.Content("~/vendor/jquery/jquery-3.2.1.min.js"), 5019, 51, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <!--===============================================================================================-->\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 5202, "\"", 5264, 1);
#nullable restore
#line 93 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Login\BackupLogin.cshtml"
WriteAttributeValue("", 5208, Url.Content("~/vendor/animsition/js/animsition.min.js"), 5208, 56, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <!--===============================================================================================-->\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 5396, "\"", 5449, 1);
#nullable restore
#line 95 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Login\BackupLogin.cshtml"
WriteAttributeValue("", 5402, Url.Content("~/vendor/bootstrap/js/popper.js"), 5402, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 5473, "\"", 5533, 1);
#nullable restore
#line 96 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Login\BackupLogin.cshtml"
WriteAttributeValue("", 5479, Url.Content("~/vendor/bootstrap/js/bootstrap.min.js"), 5479, 54, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <!--===============================================================================================-->\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 5665, "\"", 5718, 1);
#nullable restore
#line 98 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Login\BackupLogin.cshtml"
WriteAttributeValue("", 5671, Url.Content("~/vendor/select2/select2.min.js"), 5671, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <!--===============================================================================================-->\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 5850, "\"", 5910, 1);
#nullable restore
#line 100 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Login\BackupLogin.cshtml"
WriteAttributeValue("", 5856, Url.Content("~/vendor/daterangepicker/moment.min.js"), 5856, 54, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 5934, "\"", 5999, 1);
#nullable restore
#line 101 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Login\BackupLogin.cshtml"
WriteAttributeValue("", 5940, Url.Content("~/vendor/daterangepicker/daterangepicker.js"), 5940, 59, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <!--===============================================================================================-->\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 6131, "\"", 6192, 1);
#nullable restore
#line 103 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Login\BackupLogin.cshtml"
WriteAttributeValue("", 6137, Url.Content("~/vendor/countdowntime/countdowntime.js"), 6137, 55, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <!--===============================================================================================-->\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 6324, "\"", 6358, 1);
#nullable restore
#line 105 "D:\Dev\repos\SensorWeb\SensorWeb\Views\Login\BackupLogin.cshtml"
WriteAttributeValue("", 6330, Url.Content("~/js/main.js"), 6330, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
