#pragma checksum "C:\Users\hemre\Desktop\Blog\CoreDemo\CoreDemo\Views\Shared\Partial3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f0b98e4a09878023cd22dd9ac46ded9055f4727"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Partial3), @"mvc.1.0.view", @"/Views/Shared/Partial3.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f0b98e4a09878023cd22dd9ac46ded9055f4727", @"/Views/Shared/Partial3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Partial3 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<footer>
	<div class=""container"">
		<div class=""row"">
			<div class=""col-lg-4 footer-grid-agileits-w3ls text-left"">
				<h3>Hakkımızda</h3>
				<p>Blog (Türkçe: ağ günlüğü, günce) veya Weblog (Türkçe: Ağ kütüğü) teknik bilgi gerektirmeden, 
					kendi istedikleri şeyleri, kendi istedikleri şekilde yazan insanların oluşturabildikleri, 
					günlüğe benzeyen web siteleridir. Genellikle güncelden eskiye doğru sıralanmış yazı ve yorumların yayınlandığı, web tabanlı bir yayını belirtir...</p>
				<div class=""read"">
					<a href=""/About/Index/"" class=""btn btn-primary read-m"">Devamını Oku</a>
				</div>
			</div>
			<div class=""col-lg-4 footer-grid-agileits-w3ls text-left"">
				
				");
#nullable restore
#line 15 "C:\Users\hemre\Desktop\Blog\CoreDemo\CoreDemo\Views\Shared\Partial3.cshtml"
           Write(await Component.InvokeAsync("BlogLast3Post"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\r\n\t\t\t</div>\r\n\t\t\t<!-- subscribe -->\r\n\t\t\t<div class=\"col-lg-4 subscribe-main footer-grid-agileits-w3ls text-left\">\r\n\t\t\t\t<h2>Mail Bültenine Abone Ol</h2>\r\n\t\t\t\t");
#nullable restore
#line 21 "C:\Users\hemre\Desktop\Blog\CoreDemo\CoreDemo\Views\Shared\Partial3.cshtml"
           Write(await Html.PartialAsync("~/Views/NewsLetter/SubscribeMail.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
				<!-- //subscribe -->
			</div>
		</div>
		<!-- footer -->
		<div class=""footer-cpy text-center"">
			<div class=""footer-social"">
				<div class=""copyrighttop"">
					<ul>
						<li class=""mx-3"">
							<a class=""facebook"" href=""#"">
								<i class=""fab fa-facebook-f""></i>
								<span>Facebook</span>
							</a>
						</li>
						<li>
							<a class=""facebook"" href=""#"">
								<i class=""fab fa-twitter""></i>
								<span>Twitter</span>
							</a>
						</li>
						<li class=""mx-3"">
							<a class=""facebook"" href=""#"">
								<i class=""fab fa-google-plus-g""></i>
								<span>Google+</span>
							</a>
						</li>
						<li>
							<a class=""facebook"" href=""#"">
								<i class=""fab fa-pinterest-p""></i>
								<span>Pinterest</span>
							</a>
						</li>
					</ul>

				</div>
			</div>
			<div class=""w3layouts-agile-copyrightbottom"">
				<p>
					© ");
#nullable restore
#line 60 "C:\Users\hemre\Desktop\Blog\CoreDemo\CoreDemo\Views\Shared\Partial3.cshtml"
                 Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n\t\t\t\t</p>\r\n\r\n\t\t\t</div>\r\n\t\t</div>\r\n\r\n\t\t<!-- //footer -->\r\n\r\n\r\n\t</div>\r\n</footer>");
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