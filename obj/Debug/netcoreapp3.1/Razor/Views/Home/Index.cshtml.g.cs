#pragma checksum "C:\Users\Fidan Mammadova\Desktop\PeternaBack\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de1f7583f55a3f764997f0675078bc27c42e5376"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Fidan Mammadova\Desktop\PeternaBack\Views\_ViewImports.cshtml"
using PeternaBack;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Fidan Mammadova\Desktop\PeternaBack\Views\_ViewImports.cshtml"
using PeternaBack.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de1f7583f55a3f764997f0675078bc27c42e5376", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab979de081fe07e36d17f63cd78ed0ad8408ebd3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Service>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("service_photo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Fidan Mammadova\Desktop\PeternaBack\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"    <section id=""get_page_done"">
        <div class=""container"">
            <h1>GET PAGE DONE</h1>
            <h4>It take efforts</h4>
            <p>Lorem ipsum dolor sit ametLorem ipsum dolor sit amet</p>
            <button type=""button"" class=""btn btn-danger"">DOWNLOAD THESE THEME NOW !</button>
        </div>
    </section>
    <section id=""our_services"">
        <div class=""container"">
            <h1>OUR SERVICES :</h1>
            <div class=""row"">
                <div class=""col-xl-6"">
                    <h4>Lorem ipsum dolor sit amet</h4>
                    <p>
                        Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur nec nisl odio. Mauris vehicula at nunc
                        id posuere. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur nec nisl odio. Mauris
                        vehicula at nunc id posuere.
                    </p>
                </div>
                <div class=""col-xl-6"">
                    <h4>Lor");
            WriteLiteral(@"em ipsum dolor sit amet</h4>
                    <p>
                        Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur nec nisl odio. Mauris vehicula at nunc
                        id posuere. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur nec nisl odio. Mauris
                        vehicula at nunc id posuere.
                    </p>
                </div>
            </div>
            <div class=""our_services_items"">
                <div class=""row"">
");
#nullable restore
#line 37 "C:\Users\Fidan Mammadova\Desktop\PeternaBack\Views\Home\Index.cshtml"
                     foreach (var service in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-xl-4\">\r\n                            <div class=\"our_services_item\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "de1f7583f55a3f764997f0675078bc27c42e53765932", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1844, "~/img/", 1844, 6, true);
#nullable restore
#line 41 "C:\Users\Fidan Mammadova\Desktop\PeternaBack\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1850, service.Image, 1850, 14, false);

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
            WriteLiteral("\r\n                                <h5>");
#nullable restore
#line 42 "C:\Users\Fidan Mammadova\Desktop\PeternaBack\Views\Home\Index.cshtml"
                               Write(service.ServiceName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <p>\r\n                                    ");
#nullable restore
#line 44 "C:\Users\Fidan Mammadova\Desktop\PeternaBack\Views\Home\Index.cshtml"
                               Write(service.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                                <span>");
#nullable restore
#line 46 "C:\Users\Fidan Mammadova\Desktop\PeternaBack\Views\Home\Index.cshtml"
                                 Write(service.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 49 "C:\Users\Fidan Mammadova\Desktop\PeternaBack\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
            <div class=""our_services_summary"">
                <div class=""row"">
                    <div class=""col-xl-12"">
                        <h4>Lorem ipsum dolor sit amet</h4>
                        <p>
                            Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur nec nisl odio. Mauris vehicula at
                            nunc id posuere. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur nec nisl odio.
                            Mauris vehicula at nunc id posuere. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur
                            nec nisl odio. Mauris vehicula at nunc id posuere. Lorem ipsum dolor sit amet, consectetur adipiscing
                            elit. Curabitur nec nisl odio. Mauris vehicula at nunc id posuere. Lorem ipsum dolor sit amet,
                            consectetur adipiscing elit. Curabitur nec nisl odio. Mauris vehicula at nunc id posuere.");
            WriteLiteral(@" Lorem ipsum
                            dolor sit amet, consectetur adipiscing elit. Curabitur nec nisl odio. Mauris vehicula at nunc id
                            posuere.
                        </p>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <section id=""wall_street"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xl-9"">
                    <h1>Featured In Wall Street</h1>
                    <p>and many other magzines..</p>
                </div>
                <div class=""col-xl-3"">
                    <h1>300+</h1>
                    <p>Reports</p>
                </div>
            </div>
        </div>

    </section>
    <section id=""our_plans"">
        <div class=""container"">
            <h1>OUR PLANS:</h1>
            <div class=""row"">
                <div class=""col-xl-6"">
                    <h4>Lorem ipsum dolor sit amet</h4>
                    <p>
      ");
            WriteLiteral(@"                  Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur nec nisl odio. Mauris vehicula at nunc
                        id posuere. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur nec nisl odio. Mauris
                        vehicula at nunc id posuere.
                    </p>
                </div>
                <div class=""col-xl-6"">
                    <h4>Lorem ipsum dolor sit amet</h4>
                    <p>
                        Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur nec nisl odio. Mauris vehicula at nunc
                        id posuere. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur nec nisl odio. Mauris
                        vehicula at nunc id posuere.
                    </p>
                </div>
                <div class=""our_plans_items"">
                    <div class=""row"">
                        <div class=""col-xl-4"">
                            <div class=""our_plans_it");
            WriteLiteral(@"em"">
                                <h3>BASIC PLAN</h3>
                                <ul>
                                    <li><b>12</b> Accounts</li>
                                    <li><b>52</b> Emails</li>
                                    <li><b>50 GB </b> Space</li>
                                    <li><b>Free</b> Support</li>
                                </ul>
                                <h1>$99 only</h1>
                                <button type=""button"" class=""btn btn-danger"">Read More</button>
                            </div>
                        </div>
                        <div class=""col-xl-4"">
                            <div class=""our_plans_item"">
                                <h3>POPULAR PLAN</h3>
                                <ul>
                                    <li><b>12</b> Accounts</li>
                                    <li><b>52</b> Emails</li>
                                    <li><b>50 GB </b> Space</li>
                   ");
            WriteLiteral(@"                 <li><b>Free</b> Support</li>
                                </ul>
                                <h1>$199 only</h1>
                                <button type=""button"" class=""btn btn-primary"">Read More</button>
                            </div>
                        </div>
                        <div class=""col-xl-4"">
                            <div class=""our_plans_item"">
                                <h3>VALUE PLAN</h3>
                                <ul>
                                    <li><b>12</b> Accounts</li>
                                    <li><b>52</b> Emails</li>
                                    <li><b>50 GB </b> Space</li>
                                    <li><b>Free</b> Support</li>
                                </ul>
                                <h1>$299 only</h1>
                                <button type=""button"" class=""btn btn-success"">Read More</button>
                            </div>
                        </div>
      ");
            WriteLiteral(@"              </div>
                </div>
            </div>
        </div>
    </section>
    <section id=""features"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xl-3"">
                    <h1>5000+</h1>
                    <p>Projects</p>
                </div>
                <div class=""col-xl-3"">
                    <h1>205+</h1>
                    <p>Countries</p>
                </div>
                <div class=""col-xl-3"">
                    <h1>1300+</h1>
                    <p>Offices</p>
                </div>
                <div class=""col-xl-3"">
                    <h1>2400+</h1>
                    <p>Clients</p>
                </div>
            </div>
        </div>
    </section>
    <section id=""contact_us"">
        <div class=""container"">
            <h1>CONTACT US:</h1>
            <div class=""row"">
                <div class=""col-xl-6"">
                    <h4>Lorem ipsum dolor sit amet</h4>
         ");
            WriteLiteral(@"           <p>
                        Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur nec nisl odio. Mauris vehicula at nunc
                        id posuere. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur nec nisl odio. Mauris
                        vehicula at nunc id posuere.
                    </p>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de1f7583f55a3f764997f0675078bc27c42e537615480", async() => {
                WriteLiteral(@"
                        <div class=""form-row"">
                            <div class=""form"">
                                <div class=""form-group col-xl-6"">
                                    <label for=""Name""></label>
                                    <input type=""text"" class=""form-control"" id=""Name"" placeholder=""Name"">
                                </div>
                                <div class=""form-group col-xl-6"">
                                    <label for=""inputEmail4""></label>
                                    <input type=""email"" class=""form-control"" id=""inputEmail4"" placeholder=""Email"">
                                </div>
                            </div>
                        </div>
                        <div class=""form-group col-xl-12"">
                            <label for=""exampleFormControlTextarea1""></label>
                            <textarea class=""form-control"" id=""exampleFormControlTextarea1"" rows=""3""></textarea>
                        </div>
 ");
                WriteLiteral("                       <button type=\"submit\" class=\"btn btn-primary\">Submit Request</button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <div class=""col-xl-6"">
                    <h4>Lorem ipsum dolor sit amet</h4>
                    <p>
                        Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur nec nisl odio. Mauris vehicula at nunc
                        id posuere. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur nec nisl odio. Mauris
                        vehicula at nunc id posuere.
                    </p>
                    <div class=""contact_info"">
                        <p><b>Address:</b> 123,Your locality , Counrty Name, Pin-20100090.</p>
                        <p><b>Email:</b> info@yourdomain.com</p>
                        <p><b>Web:</b> www.yourdomain.com</p>
                        <p><b>Mobile:</b> +00-909-808-707-00</p>
                    </div>
                </div>
            </div>
        </div>
    </section>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Service>> Html { get; private set; }
    }
}
#pragma warning restore 1591
