#pragma checksum "C:\Users\hemre\Desktop\Blog\CoreDemo\CoreDemo\Views\Comment\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "415b86287c88f397e5adff970d0cedef53d4ba0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comment_Index), @"mvc.1.0.view", @"/Views/Comment/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\hemre\Desktop\Blog\CoreDemo\CoreDemo\Views\Comment\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"415b86287c88f397e5adff970d0cedef53d4ba0a", @"/Views/Comment/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Comment_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Comment>>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\hemre\Desktop\Blog\CoreDemo\CoreDemo\Views\Comment\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "415b86287c88f397e5adff970d0cedef53d4ba0a3562", async() => {
                WriteLiteral(@"          
            <div class=""wrapper wrapper-content animated fadeInRight"">
                <div class=""row""> 
                    
                    <div class=""col-lg-12"">
                        <div class=""ibox "">
                            <div class=""ibox-title"">
                                <h5>Yorumlar </h5>
                                <div class=""ibox-tools"">
                                    <a class=""collapse-link"">
                                        <i class=""fa fa-chevron-up""></i>
                                    </a>
  
                                </div>
                            </div>
                            <div class=""ibox-content"">

                                <table class=""table table-striped"">
                                    <thead>
                                        <tr>
                                            <th>#</th>
                                            <th>Kullan??c??</th>
                               ");
                WriteLiteral(@"             <th>Ba??l??k</th>
                                            <th>Blog</th>
                                            <th>Puan</th>
                                            <th>Tarih</th>
                                            <th>Sil</th>
                                            <th>D??zenle</th>

                                        </tr>
                                    </thead>
                                    <tbody>
");
#nullable restore
#line 43 "C:\Users\hemre\Desktop\Blog\CoreDemo\CoreDemo\Views\Comment\Index.cshtml"
                                         foreach(var item in Model){

#line default
#line hidden
#nullable disable
                WriteLiteral("                                       <tr>\r\n                                            <th>");
#nullable restore
#line 45 "C:\Users\hemre\Desktop\Blog\CoreDemo\CoreDemo\Views\Comment\Index.cshtml"
                                           Write(item.CommentID);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                            <td>");
#nullable restore
#line 46 "C:\Users\hemre\Desktop\Blog\CoreDemo\CoreDemo\Views\Comment\Index.cshtml"
                                           Write(item.CommentUserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 47 "C:\Users\hemre\Desktop\Blog\CoreDemo\CoreDemo\Views\Comment\Index.cshtml"
                                           Write(item.CommentTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 48 "C:\Users\hemre\Desktop\Blog\CoreDemo\CoreDemo\Views\Comment\Index.cshtml"
                                           Write(item.Blog.BlogTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>         \r\n                                            <td class=\"text-navy\"> <i class=\"fa fa-level-up\"></i> ");
#nullable restore
#line 49 "C:\Users\hemre\Desktop\Blog\CoreDemo\CoreDemo\Views\Comment\Index.cshtml"
                                                                                             Write(item.BlogScore);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                                            <td>");
#nullable restore
#line 50 "C:\Users\hemre\Desktop\Blog\CoreDemo\CoreDemo\Views\Comment\Index.cshtml"
                                            Write(((DateTime)item.CommentDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        <td><a");
                BeginWriteAttribute("href", " href=\"", 2432, "\"", 2477, 2);
                WriteAttributeValue("", 2439, "/Comment/CommentDelete/", 2439, 23, true);
#nullable restore
#line 51 "C:\Users\hemre\Desktop\Blog\CoreDemo\CoreDemo\Views\Comment\Index.cshtml"
WriteAttributeValue("", 2462, item.CommentID, 2462, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n                                            <td><a href=\"#\" class=\"btn btn-success\">G??ncelle</a></td>\r\n                                        </tr>\r\n");
#nullable restore
#line 54 "C:\Users\hemre\Desktop\Blog\CoreDemo\CoreDemo\Views\Comment\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    </tbody>\r\n                                </table>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n\r\n            </div>   \r\n");
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
            WriteLiteral("\r\n\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Comment>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
