#pragma checksum "C:\Users\hemre\Desktop\Blog\CoreDemo\CoreDemo\Views\Admin\AdminNavbarPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "109e084cafbd8c9814364dbdc40fff220f69dc97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AdminNavbarPartial), @"mvc.1.0.view", @"/Views/Admin/AdminNavbarPartial.cshtml")]
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
#line 1 "C:\Users\hemre\Desktop\Blog\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hemre\Desktop\Blog\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"109e084cafbd8c9814364dbdc40fff220f69dc97", @"/Views/Admin/AdminNavbarPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_AdminNavbarPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/inspinia-gh-pages/img/profile_small.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@" <nav class=""navbar-default navbar-static-side"" role=""navigation"">
        <div class=""sidebar-collapse"">
            <ul class=""nav metismenu"" id=""side-menu"">
                <li class=""nav-header"">
                    <div class=""dropdown profile-element"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "109e084cafbd8c9814364dbdc40fff220f69dc974546", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <a data-toggle=""dropdown"" class=""dropdown-toggle"" href=""#"">
                            <span class=""block m-t-xs font-bold"">Hakan</span>
                            <span class=""text-muted text-xs block"">Yazılımcı <b class=""caret""></b></span>
                        </a>
                        <ul class=""dropdown-menu animated fadeInRight m-t-xs"">
                            <li><a class=""dropdown-item"" href=""profile.html"">Profile</a></li>
                            <li><a class=""dropdown-item"" href=""contacts.html"">Contacts</a></li>
                            <li><a class=""dropdown-item"" href=""mailbox.html"">Mailbox</a></li>
                            <li class=""dropdown-divider""></li>
                            <li><a class=""dropdown-item"" href=""login.html"">Logout</a></li>
                        </ul>
                    </div>
                    <div class=""logo-element"">
                        IN+
                    </div>
                
                ");
            WriteLiteral("</li>\r\n");
#nullable restore
#line 24 "C:\Users\hemre\Desktop\Blog\CoreDemo\CoreDemo\Views\Admin\AdminNavbarPartial.cshtml"
                 if(User.IsInRole(role:"Admin")){

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>\r\n                    <a href=\"/Admin/AdminRole/Index/\"><i class=\"fa fa-lock\"></i> <span class=\"nav-label\">Roller</span>  </a>\r\n                </li>\r\n");
#nullable restore
#line 28 "C:\Users\hemre\Desktop\Blog\CoreDemo\CoreDemo\Views\Admin\AdminNavbarPartial.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <li>
                <a href=""/Admin/Widget/Index/""><i class=""fa fa-th-large""></i> <span class=""nav-label"">Dashboard</span>  </a>
            </li>
            <li>
                <a href=""/Admin/Chart/Index/""><i class=""fa fa-th-large""></i> <span class=""nav-label"">Grafikler</span>  </a>
            </li>
                <li>
                    <a href=""metrics.html""><i class=""fa fa-pie-chart""></i> <span class=""nav-label"">Metrikler</span>  </a>
                </li>
            <li>
                <a href=""/Admin/Category/Index/""><i class=""fa fa-group""></i> <span class=""nav-label"">Kategoriler</span>  </a>
            </li>
            <li>
                <a href=""/Admin/AdminBlog/Index/""><i class=""fa fa-list""></i> <span class=""nav-label"">Bloglar</span>  </a>
            </li>
            <li>
                <a href=""/Admin/AdminComment/Index/""><i class=""fa fa-comment""></i> <span class=""nav-label"">Yorumlar</span>  </a>
            </li>
            <li>
                <a hre");
            WriteLiteral(@"f=""/Admin/Writer/Index/""><i class=""fa fa-user""></i> <span class=""nav-label"">Yazarlar</span>  </a>
            </li>
            <li>
                <a href=""metrics.html""><i class=""fa fa-diamond""></i> <span class=""nav-label"">Bildirimler</span>  </a>
            </li>

            <li>
                <a href=""/Login/LogOut/""><i class=""fa fa-book""></i> <span class=""fa fa-close"">Çıkış Yap</span>  </a>
            </li>
            </ul>

        </div>
 </nav>

");
        }
        #pragma warning restore 1998
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
