#pragma checksum "C:\Users\AGYAL\source\repos\FCoreApp\FCoreApp\Areas\AdminPanel\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0bea3656f6f7c24e757f6859ec7ee942b1acb064"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminPanel_Views_Home_Index), @"mvc.1.0.view", @"/Areas/AdminPanel/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\AGYAL\source\repos\FCoreApp\FCoreApp\Areas\AdminPanel\Views\_ViewImports.cshtml"
using FCoreApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AGYAL\source\repos\FCoreApp\FCoreApp\Areas\AdminPanel\Views\_ViewImports.cshtml"
using FCoreApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\AGYAL\source\repos\FCoreApp\FCoreApp\Areas\AdminPanel\Views\Home\Index.cshtml"
using FCoreApp.Areas.AdminPanel.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bea3656f6f7c24e757f6859ec7ee942b1acb064", @"/Areas/AdminPanel/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96c8aceab6a8888f62d143e8ab3a0b7b6253c5cc", @"/Areas/AdminPanel/Views/_ViewImports.cshtml")]
    public class Areas_AdminPanel_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Admin>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12"">
        <div class=""overview-wrap"">
            <h2 class=""title-1"">overview</h2>
            <button class=""au-btn au-btn-icon au-btn--blue"">
                <i class=""zmdi zmdi-plus""></i>add item
            </button>
        </div>
    </div>
</div>

<div class=""row m-t-25"">

    <div class=""col-sm-6 col-lg-3"">
        <div class=""overview-item overview-item--c1"">
            <div class=""overview__inner"">
                <div class=""overview-box clearfix"">
                    <div class=""icon"">
                        <i class=""zmdi zmdi-account-o""></i>
                    </div>
                    <div class=""text"">
                        <h2>");
#nullable restore
#line 25 "C:\Users\AGYAL\source\repos\FCoreApp\FCoreApp\Areas\AdminPanel\Views\Home\Index.cshtml"
                       Write(Model.team);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                        <span>Team Members Number</span>
                    </div>
                </div>
                <div class=""overview-chart"">
                    <div class=""chartjs-size-monitor"" style=""position: absolute; inset: 0px; overflow: hidden; pointer-events: none; visibility: hidden; z-index: -1;""><div class=""chartjs-size-monitor-expand"" style=""position:absolute;left:0;top:0;right:0;bottom:0;overflow:hidden;pointer-events:none;visibility:hidden;z-index:-1;""><div style=""position:absolute;width:1000000px;height:1000000px;left:0;top:0""></div></div><div class=""chartjs-size-monitor-shrink"" style=""position:absolute;left:0;top:0;right:0;bottom:0;overflow:hidden;pointer-events:none;visibility:hidden;z-index:-1;""><div style=""position:absolute;width:200%;height:200%;left:0; top:0""></div></div></div>
                    <canvas id=""widgetChart1"" height=""162"" style=""display: block; height: 130px; width: 200px;"" width=""250"" class=""chartjs-render-monitor""></canvas>
                </div>
 ");
            WriteLiteral(@"           </div>
        </div>
    </div>

    <div class=""col-sm-6 col-lg-3"">
        <div class=""overview-item overview-item--c2"">
            <div class=""overview__inner"">
                <div class=""overview-box clearfix"">
                    <div class=""icon"">
                        <i class=""zmdi zmdi-shopping-cart""></i>
                    </div>
                    <div class=""text"">
                        <h2>");
#nullable restore
#line 45 "C:\Users\AGYAL\source\repos\FCoreApp\FCoreApp\Areas\AdminPanel\Views\Home\Index.cshtml"
                       Write(Model.news);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                        <span>News Number</span>
                    </div>
                </div>
                <div class=""overview-chart"">
                    <div class=""chartjs-size-monitor"" style=""position: absolute; inset: 0px; overflow: hidden; pointer-events: none; visibility: hidden; z-index: -1;""><div class=""chartjs-size-monitor-expand"" style=""position:absolute;left:0;top:0;right:0;bottom:0;overflow:hidden;pointer-events:none;visibility:hidden;z-index:-1;""><div style=""position:absolute;width:1000000px;height:1000000px;left:0;top:0""></div></div><div class=""chartjs-size-monitor-shrink"" style=""position:absolute;left:0;top:0;right:0;bottom:0;overflow:hidden;pointer-events:none;visibility:hidden;z-index:-1;""><div style=""position:absolute;width:200%;height:200%;left:0; top:0""></div></div></div>
                    <canvas id=""widgetChart2"" height=""143"" style=""display: block; height: 115px; width: 200px;"" width=""250"" class=""chartjs-render-monitor""></canvas>
                </div>
         ");
            WriteLiteral(@"   </div>
        </div>
    </div>

    <div class=""col-sm-6 col-lg-3"">
        <div class=""overview-item overview-item--c3"">
            <div class=""overview__inner"">
                <div class=""overview-box clearfix"">
                    <div class=""icon"">
                        <i class=""zmdi zmdi-collection-plus""></i>
                    </div>
                    <div class=""text"">
                        <h2>");
#nullable restore
#line 65 "C:\Users\AGYAL\source\repos\FCoreApp\FCoreApp\Areas\AdminPanel\Views\Home\Index.cshtml"
                       Write(Model.categ);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                        <span>Categories Number</span>
                    </div>
                </div>
                <div class=""overview-chart"">
                    <div class=""chartjs-size-monitor"" style=""position: absolute; inset: 0px; overflow: hidden; pointer-events: none; visibility: hidden; z-index: -1;""><div class=""chartjs-size-monitor-expand"" style=""position:absolute;left:0;top:0;right:0;bottom:0;overflow:hidden;pointer-events:none;visibility:hidden;z-index:-1;""><div style=""position:absolute;width:1000000px;height:1000000px;left:0;top:0""></div></div><div class=""chartjs-size-monitor-shrink"" style=""position:absolute;left:0;top:0;right:0;bottom:0;overflow:hidden;pointer-events:none;visibility:hidden;z-index:-1;""><div style=""position:absolute;width:200%;height:200%;left:0; top:0""></div></div></div>
                    <canvas id=""widgetChart3"" height=""143"" style=""display: block; height: 115px; width: 200px;"" width=""250"" class=""chartjs-render-monitor""></canvas>
                </div>
   ");
            WriteLiteral(@"         </div>
        </div>
    </div>

    <div class=""col-sm-6 col-lg-3"">
        <div class=""overview-item overview-item--c4"">
            <div class=""overview__inner"">
                <div class=""overview-box clearfix"">
                    <div class=""icon"">
                        <i class=""zmdi zmdi-inbox""></i>
                    </div>
                    <div class=""text"">
                        <h2>");
#nullable restore
#line 85 "C:\Users\AGYAL\source\repos\FCoreApp\FCoreApp\Areas\AdminPanel\Views\Home\Index.cshtml"
                       Write(Model.contact);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                        <span>Messages Number</span>
                    </div>
                </div>
                <div class=""overview-chart"">
                    <div class=""chartjs-size-monitor"" style=""position: absolute; inset: 0px; overflow: hidden; pointer-events: none; visibility: hidden; z-index: -1;""><div class=""chartjs-size-monitor-expand"" style=""position:absolute;left:0;top:0;right:0;bottom:0;overflow:hidden;pointer-events:none;visibility:hidden;z-index:-1;""><div style=""position:absolute;width:1000000px;height:1000000px;left:0;top:0""></div></div><div class=""chartjs-size-monitor-shrink"" style=""position:absolute;left:0;top:0;right:0;bottom:0;overflow:hidden;pointer-events:none;visibility:hidden;z-index:-1;""><div style=""position:absolute;width:200%;height:200%;left:0; top:0""></div></div></div>
                    <canvas id=""widgetChart4"" height=""143"" style=""display: block; height: 115px; width: 200px;"" width=""250"" class=""chartjs-render-monitor""></canvas>
                </div>
     ");
            WriteLiteral(@"       </div>
        </div>
    </div>

</div>

<div class=""row"">

    <div class=""col-lg-6"">
        <div class=""au-card recent-report"">
            <div class=""au-card-inner"">
                <h3 class=""title-2"">recent reports</h3>
                <div class=""chart-info"">
                    <div class=""chart-info__left"">
                        <div class=""chart-note"">
                            <span class=""dot dot--blue""></span>
                            <span>products</span>
                        </div>
                        <div class=""chart-note mr-0"">
                            <span class=""dot dot--green""></span>
                            <span>services</span>
                        </div>
                    </div>
                    <div class=""chart-info__right"">
                        <div class=""chart-statis"">
                            <span class=""index incre"">
                                <i class=""zmdi zmdi-long-arrow-up""></i>25%
                ");
            WriteLiteral(@"            </span>
                            <span class=""label"">products</span>
                        </div>
                        <div class=""chart-statis mr-0"">
                            <span class=""index decre"">
                                <i class=""zmdi zmdi-long-arrow-down""></i>10%
                            </span>
                            <span class=""label"">services</span>
                        </div>
                    </div>
                </div>
                <div class=""recent-report__chart"">
                    <div class=""chartjs-size-monitor"" style=""position: absolute; inset: 0px; overflow: hidden; pointer-events: none; visibility: hidden; z-index: -1;""><div class=""chartjs-size-monitor-expand"" style=""position:absolute;left:0;top:0;right:0;bottom:0;overflow:hidden;pointer-events:none;visibility:hidden;z-index:-1;""><div style=""position:absolute;width:1000000px;height:1000000px;left:0;top:0""></div></div><div class=""chartjs-size-monitor-shrink"" style=""position:a");
            WriteLiteral(@"bsolute;left:0;top:0;right:0;bottom:0;overflow:hidden;pointer-events:none;visibility:hidden;z-index:-1;""><div style=""position:absolute;width:200%;height:200%;left:0; top:0""></div></div></div>
                    <canvas id=""recent-rep-chart"" height=""312"" style=""display: block; height: 250px; width: 474px;"" width=""592"" class=""chartjs-render-monitor""></canvas>
                </div>
            </div>
        </div>
    </div>

    <div class=""col-lg-6"">
        <div class=""au-card chart-percent-card"">
            <div class=""au-card-inner"">
                <h3 class=""title-2 tm-b-5"">char by %</h3>
                <div class=""row no-gutters"">
                    <div class=""col-xl-6"">
                        <div class=""chart-note-wrap"">
                            <div class=""chart-note mr-0 d-block"">
                                <span class=""dot dot--blue""></span>
                                <span>products</span>
                            </div>
                            <div clas");
            WriteLiteral(@"s=""chart-note mr-0 d-block"">
                                <span class=""dot dot--red""></span>
                                <span>services</span>
                            </div>
                        </div>
                    </div>
                    <div class=""col-xl-6"">
                        <div class=""percent-chart"">
                            <div class=""chartjs-size-monitor"" style=""position: absolute; inset: 0px; overflow: hidden; pointer-events: none; visibility: hidden; z-index: -1;""><div class=""chartjs-size-monitor-expand"" style=""position:absolute;left:0;top:0;right:0;bottom:0;overflow:hidden;pointer-events:none;visibility:hidden;z-index:-1;""><div style=""position:absolute;width:1000000px;height:1000000px;left:0;top:0""></div></div><div class=""chartjs-size-monitor-shrink"" style=""position:absolute;left:0;top:0;right:0;bottom:0;overflow:hidden;pointer-events:none;visibility:hidden;z-index:-1;""><div style=""position:absolute;width:200%;height:200%;left:0; top:0""></div></div></div>
");
            WriteLiteral(@"                            <canvas id=""percent-chart"" height=""350"" style=""display: block; height: 280px; width: 173px;"" width=""216"" class=""chartjs-render-monitor""></canvas>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Admin> Html { get; private set; }
    }
}
#pragma warning restore 1591
