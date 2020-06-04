#pragma checksum "/data/CrossPlatformWork/OpenNetLink/src/OpenNetLinkApp/Pages/Charts/Inline.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1abca2757ee641cf099e7116b999a2ac2a42345b"
// <auto-generated/>
#pragma warning disable 1591
namespace OpenNetLinkApp.Pages.Charts
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/data/CrossPlatformWork/OpenNetLink/src/OpenNetLinkApp/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/data/CrossPlatformWork/OpenNetLink/src/OpenNetLinkApp/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/data/CrossPlatformWork/OpenNetLink/src/OpenNetLinkApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/data/CrossPlatformWork/OpenNetLink/src/OpenNetLinkApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/data/CrossPlatformWork/OpenNetLink/src/OpenNetLinkApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/data/CrossPlatformWork/OpenNetLink/src/OpenNetLinkApp/_Imports.razor"
using OpenNetLinkApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/data/CrossPlatformWork/OpenNetLink/src/OpenNetLinkApp/_Imports.razor"
using OpenNetLinkApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/data/CrossPlatformWork/OpenNetLink/src/OpenNetLinkApp/_Imports.razor"
using WebWindows;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/data/CrossPlatformWork/OpenNetLink/src/OpenNetLinkApp/Pages/Charts/Inline.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Charts/inline")]
    public partial class Inline : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<section class=""content-header"">
    <div class=""container-fluid"">
    <div class=""row mb-2"">
        <div class=""col-sm-6"">
        <h1>Inline Charts</h1>
        </div>
        <div class=""col-sm-6"">
        <ol class=""breadcrumb float-sm-right"">
            <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
            <li class=""breadcrumb-item active"">Inline Charts</li>
        </ol>
        </div>
    </div>
    </div>
</section>


");
            __builder.AddMarkupContent(1, "<section class=\"content\">\n    <div class=\"container-fluid\">\n    \n    <div class=\"row\">\n        <div class=\"col-12\">\n        \n        <div class=\"card\">\n            <div class=\"card-header\">\n            <h3 class=\"card-title\">\n                <i class=\"far fa-chart-bar\"></i>\n                jQuery Knob\n            </h3>\n\n            <div class=\"card-tools\">\n                <button type=\"button\" class=\"btn btn-tool\" data-card-widget=\"collapse\"><i class=\"fas fa-minus\"></i>\n                </button>\n                <button type=\"button\" class=\"btn btn-tool\" data-card-widget=\"remove\"><i class=\"fas fa-times\"></i>\n                </button>\n            </div>\n            </div>\n            \n            <div class=\"card-body\">\n            <div class=\"row\">\n                <div class=\"col-6 col-md-3 text-center\">\n                <input type=\"text\" class=\"knob\" value=\"30\" data-width=\"90\" data-height=\"90\" data-fgColor=\"#3c8dbc\">\n\n                <div class=\"knob-label\">New Visitors</div>\n                </div>\n                \n                <div class=\"col-6 col-md-3 text-center\">\n                <input type=\"text\" class=\"knob\" value=\"70\" data-width=\"90\" data-height=\"90\" data-fgColor=\"#f56954\">\n\n                <div class=\"knob-label\">Bounce Rate</div>\n                </div>\n                \n                <div class=\"col-6 col-md-3 text-center\">\n                <input type=\"text\" class=\"knob\" value=\"-80\" data-min=\"-150\" data-max=\"150\" data-width=\"90\" data-height=\"90\" data-fgColor=\"#00a65a\">\n\n                <div class=\"knob-label\">Server Load</div>\n                </div>\n                \n                <div class=\"col-6 col-md-3 text-center\">\n                <input type=\"text\" class=\"knob\" value=\"40\" data-width=\"90\" data-height=\"90\" data-fgColor=\"#00c0ef\">\n\n                <div class=\"knob-label\">Disk Space</div>\n                </div>\n                \n            </div>\n            \n\n            <div class=\"row\">\n                <div class=\"col-6 text-center\">\n                <input type=\"text\" class=\"knob\" value=\"90\" data-width=\"90\" data-height=\"90\" data-fgColor=\"#932ab6\">\n\n                <div class=\"knob-label\">Bandwidth</div>\n                </div>\n                \n                <div class=\"col-6 text-center\">\n                <input type=\"text\" class=\"knob\" value=\"50\" data-width=\"90\" data-height=\"90\" data-fgColor=\"#39CCCC\">\n\n                <div class=\"knob-label\">CPU</div>\n                </div>\n                \n            </div>\n            \n            </div>\n            \n        </div>\n        \n        </div>\n        \n    </div>\n    \n\n    <div class=\"row\">\n        <div class=\"col-12\">\n        <div class=\"card\">\n            <div class=\"card-header\">\n            <h3 class=\"card-title\">\n                <i class=\"far fa-chart-bar\"></i>\n                jQuery Knob Different Sizes\n            </h3>\n\n            <div class=\"card-tools\">\n                <button type=\"button\" class=\"btn btn-tool\" data-card-widget=\"collapse\"><i class=\"fas fa-minus\"></i>\n                </button>\n                <button type=\"button\" class=\"btn btn-tool\" data-card-widget=\"remove\"><i class=\"fas fa-times\"></i>\n                </button>\n            </div>\n            </div>\n            \n            <div class=\"card-body\">\n            <div class=\"row\">\n                <div class=\"col-6 col-md-3 text-center\">\n                <input type=\"text\" class=\"knob\" value=\"30\" data-width=\"90\" data-height=\"90\" data-fgColor=\"#3c8dbc\" data-readonly=\"true\">\n\n                <div class=\"knob-label\">data-width=\"90\"</div>\n                </div>\n                \n                <div class=\"col-6 col-md-3 text-center\">\n                <input type=\"text\" class=\"knob\" value=\"30\" data-width=\"120\" data-height=\"120\" data-fgColor=\"#f56954\">\n\n                <div class=\"knob-label\">data-width=\"120\"</div>\n                </div>\n                \n                <div class=\"col-6 col-md-3 text-center\">\n                <input type=\"text\" class=\"knob\" value=\"30\" data-thickness=\"0.1\" data-width=\"90\" data-height=\"90\" data-fgColor=\"#00a65a\">\n\n                <div class=\"knob-label\">data-thickness=\"0.1\"</div>\n                </div>\n                \n                <div class=\"col-6 col-md-3 text-center\">\n                <input type=\"text\" class=\"knob\" data-thickness=\"0.2\" data-angleArc=\"250\" data-angleOffset=\"-125\" value=\"30\" data-width=\"120\" data-height=\"120\" data-fgColor=\"#00c0ef\">\n\n                <div class=\"knob-label\">data-angleArc=\"250\"</div>\n                </div>\n                \n            </div>\n            \n            </div>\n            \n        </div>\n        \n        </div>\n        \n    </div>\n    \n\n    <div class=\"row\">\n        <div class=\"col-12\">\n        <div class=\"card\">\n            <div class=\"card-header\">\n            <h3 class=\"card-title\">\n                <i class=\"far fa-chart-bar\"></i>\n                jQuery Knob Tron Style\n            </h3>\n\n            <div class=\"card-tools\">\n                <button type=\"button\" class=\"btn btn-tool\" data-card-widget=\"collapse\"><i class=\"fas fa-minus\"></i>\n                </button>\n                <button type=\"button\" class=\"btn btn-tool\" data-card-widget=\"remove\"><i class=\"fas fa-times\"></i>\n                </button>\n            </div>\n            </div>\n            \n            <div class=\"card-body\">\n            <div class=\"row\">\n                <div class=\"col-6 col-md-3 text-center\">\n                <input type=\"text\" class=\"knob\" value=\"80\" data-skin=\"tron\" data-thickness=\"0.2\" data-width=\"90\" data-height=\"90\" data-fgColor=\"#3c8dbc\" data-readonly=\"true\">\n\n                <div class=\"knob-label\">data-width=\"90\"</div>\n                </div>\n                \n                <div class=\"col-6 col-md-3 text-center\">\n                <input type=\"text\" class=\"knob\" value=\"60\" data-skin=\"tron\" data-thickness=\"0.2\" data-width=\"120\" data-height=\"120\" data-fgColor=\"#f56954\">\n\n                <div class=\"knob-label\">data-width=\"120\"</div>\n                </div>\n                \n                <div class=\"col-6 col-md-3 text-center\">\n                <input type=\"text\" class=\"knob\" value=\"10\" data-skin=\"tron\" data-thickness=\"0.1\" data-width=\"90\" data-height=\"90\" data-fgColor=\"#00a65a\">\n\n                <div class=\"knob-label\">data-thickness=\"0.1\"</div>\n                </div>\n                \n                <div class=\"col-6 col-md-3 text-center\">\n                <input type=\"text\" class=\"knob\" value=\"100\" data-skin=\"tron\" data-thickness=\"0.2\" data-angleArc=\"250\" data-angleOffset=\"-125\" data-width=\"120\" data-height=\"120\" data-fgColor=\"#00c0ef\">\n\n                <div class=\"knob-label\">data-angleArc=\"250\"</div>\n                </div>\n                \n            </div>\n            \n            </div>\n            \n        </div>\n        \n        </div>\n        \n    </div>\n    \n\n    </div>\n</section>");
        }
        #pragma warning restore 1998
#nullable restore
#line 228 "/data/CrossPlatformWork/OpenNetLink/src/OpenNetLinkApp/Pages/Charts/Inline.razor"
 
    public async Task LoadJavaScript()
    {
        await JSRuntime.InvokeVoidAsync("loadJavaScript");
        await JSRuntime.InvokeVoidAsync("loadInline");
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if(firstRender)
        {
            await LoadJavaScript();
            await base.OnAfterRenderAsync(firstRender);
            StateHasChanged();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
