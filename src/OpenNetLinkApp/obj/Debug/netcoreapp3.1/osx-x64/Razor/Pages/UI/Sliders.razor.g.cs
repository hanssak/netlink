#pragma checksum "/Volumes/Macintosh HD2/CrossPlatformWork/DesktopApp/BlazorAdminLTE_side/BlazorAdminLTE/Pages/UI/Sliders.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f736340f022e87879785f05e6925111f9d9a56a"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorDesktopApp.Pages.UI
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Volumes/Macintosh HD2/CrossPlatformWork/DesktopApp/BlazorAdminLTE_side/BlazorAdminLTE/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Volumes/Macintosh HD2/CrossPlatformWork/DesktopApp/BlazorAdminLTE_side/BlazorAdminLTE/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Volumes/Macintosh HD2/CrossPlatformWork/DesktopApp/BlazorAdminLTE_side/BlazorAdminLTE/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Volumes/Macintosh HD2/CrossPlatformWork/DesktopApp/BlazorAdminLTE_side/BlazorAdminLTE/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Volumes/Macintosh HD2/CrossPlatformWork/DesktopApp/BlazorAdminLTE_side/BlazorAdminLTE/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Volumes/Macintosh HD2/CrossPlatformWork/DesktopApp/BlazorAdminLTE_side/BlazorAdminLTE/_Imports.razor"
using BlazorDesktopApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Volumes/Macintosh HD2/CrossPlatformWork/DesktopApp/BlazorAdminLTE_side/BlazorAdminLTE/_Imports.razor"
using BlazorDesktopApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Volumes/Macintosh HD2/CrossPlatformWork/DesktopApp/BlazorAdminLTE_side/BlazorAdminLTE/_Imports.razor"
using WebWindows;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Volumes/Macintosh HD2/CrossPlatformWork/DesktopApp/BlazorAdminLTE_side/BlazorAdminLTE/Pages/UI/Sliders.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/UI/sliders")]
    public partial class Sliders : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<section class=""content-header"">
    <div class=""container-fluid"">
    <div class=""row mb-2"">
        <div class=""col-sm-6"">
        <h1>Sliders</h1>
        </div>
        <div class=""col-sm-6"">
        <ol class=""breadcrumb float-sm-right"">
            <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
            <li class=""breadcrumb-item active"">Sliders</li>
        </ol>
        </div>
    </div>
    </div>
</section>


");
            __builder.AddMarkupContent(1, "<section class=\"content\">\n    <div class=\"container-fluid\">\n    <div class=\"row\">\n        <div class=\"col-12\">\n        <div class=\"card card-primary\">\n            <div class=\"card-header\">\n            <h3 class=\"card-title\">Ion Slider</h3>\n            </div>\n            \n            <div class=\"card-body\">\n            <div class=\"row margin\">\n                <div class=\"col-sm-6\">\n                <input id=\"range_1\" type=\"text\" name=\"range_1\" value>\n                </div>\n\n                <div class=\"col-sm-6\">\n                <input id=\"range_2\" type=\"text\" name=\"range_2\" value=\"1000;100000\" data-type=\"double\" data-step=\"500\" data-postfix=\" &euro;\" data-from=\"30000\" data-to=\"90000\" data-hasgrid=\"true\">\n                </div>\n            </div>\n            <div class=\"row margin\">\n                <div class=\"col-sm-6\">\n                <input id=\"range_5\" type=\"text\" name=\"range_5\" value>\n                </div>\n                <div class=\"col-sm-6\">\n                <input id=\"range_6\" type=\"text\" name=\"range_6\" value>\n                </div>\n            </div>\n            <div class=\"row margin\">\n                <div class=\"col-sm-12\">\n                <input id=\"range_4\" type=\"text\" name=\"range_4\" value=\"10000;100000\">\n                </div>\n            </div>\n            </div>\n            \n        </div>\n        \n        </div>\n        \n    </div>\n    \n\n    <div class=\"row\">\n        <div class=\"col-12\">\n        <div class=\"card card-primary\">\n            <div class=\"card-header\">\n            <h3 class=\"card-title\">Bootstrap Slider</h3>\n            </div>\n            \n            <div class=\"card-body\">\n            <div class=\"row margin\">\n                <div class=\"col-sm-6\">\n                <div class=\"slider-red\">\n                    <input type=\"text\" value class=\"slider form-control\" data-slider-min=\"-200\" data-slider-max=\"200\" data-slider-step=\"5\" data-slider-value=\"[-100,100]\" data-slider-orientation=\"horizontal\" data-slider-selection=\"before\" data-slider-tooltip=\"show\">\n                </div>\n\n                <p>.slider-red input.slider</p>\n                <div class=\"slider-blue\">\n                    <input type=\"text\" value class=\"slider form-control\" data-slider-min=\"-200\" data-slider-max=\"200\" data-slider-step=\"5\" data-slider-value=\"[-100,100]\" data-slider-orientation=\"horizontal\" data-slider-selection=\"before\" data-slider-tooltip=\"show\">\n                </div>\n\n                <p>.slider-blue input.slider</p>\n                <div class=\"slider-green\">\n                    <input type=\"text\" value class=\"slider form-control\" data-slider-min=\"-200\" data-slider-max=\"200\" data-slider-step=\"5\" data-slider-value=\"[-100,100]\" data-slider-orientation=\"horizontal\" data-slider-selection=\"before\" data-slider-tooltip=\"show\">\n                </div>\n\n                <p>.slider-green input.slider</p>\n                <div class=\"slider-yellow\">\n                    <input type=\"text\" value class=\"slider form-control\" data-slider-min=\"-200\" data-slider-max=\"200\" data-slider-step=\"5\" data-slider-value=\"[-100,100]\" data-slider-orientation=\"horizontal\" data-slider-selection=\"before\" data-slider-tooltip=\"show\">\n                </div>\n\n                <p>.slider-yellow input.slider</p>\n                <div class=\"slider-teal\">\n                    <input type=\"text\" value class=\"slider form-control\" data-slider-min=\"-200\" data-slider-max=\"200\" data-slider-step=\"5\" data-slider-value=\"[-100,100]\" data-slider-orientation=\"horizontal\" data-slider-selection=\"before\" data-slider-tooltip=\"show\">\n                </div>\n\n                <p>.slider-teal input.slider</p>\n                <div class=\"slider-purple\">\n                    <input type=\"text\" value class=\"slider form-control\" data-slider-min=\"-200\" data-slider-max=\"200\" data-slider-step=\"5\" data-slider-value=\"[-100,100]\" data-slider-orientation=\"horizontal\" data-slider-selection=\"before\" data-slider-tooltip=\"show\">\n                </div>\n\n                <p>.slider-purple input.slider</p>\n                </div>\n                <div class=\"col-sm-6 d-flex justify-content-center\">\n                <div class=\"slider-red mx-3\">\n                    <input type=\"text\" value class=\"slider form-control\" data-slider-min=\"-200\" data-slider-max=\"200\" data-slider-step=\"5\" data-slider-value=\"[-100,100]\" data-slider-orientation=\"vertical\" data-slider-selection=\"before\" data-slider-tooltip=\"show\">\n                </div>\n                <div class=\"slider-blue mx-3\">\n                    <input type=\"text\" value class=\"slider form-control\" data-slider-min=\"-200\" data-slider-max=\"200\" data-slider-step=\"5\" data-slider-value=\"[-100,100]\" data-slider-orientation=\"vertical\" data-slider-selection=\"before\" data-slider-tooltip=\"show\">\n                </div>\n                <div class=\"slider-green mx-3\">\n                    <input type=\"text\" value class=\"slider form-control\" data-slider-min=\"-200\" data-slider-max=\"200\" data-slider-step=\"5\" data-slider-value=\"[-100,100]\" data-slider-orientation=\"vertical\" data-slider-selection=\"before\" data-slider-tooltip=\"show\">\n                </div>\n                <div class=\"slider-yellow mx-3\">\n                    <input type=\"text\" value class=\"slider form-control\" data-slider-min=\"-200\" data-slider-max=\"200\" data-slider-step=\"5\" data-slider-value=\"[-100,100]\" data-slider-orientation=\"vertical\" data-slider-selection=\"before\" data-slider-tooltip=\"show\">\n                </div>\n                <div class=\"slider-teal mx-3\">\n                    <input type=\"text\" value class=\"slider form-control\" data-slider-min=\"-200\" data-slider-max=\"200\" data-slider-step=\"5\" data-slider-value=\"[-100,100]\" data-slider-orientation=\"vertical\" data-slider-selection=\"before\" data-slider-tooltip=\"show\">\n                </div>\n                <div class=\"slider-purple mx-3\">\n                    <input type=\"text\" value class=\"slider form-control\" data-slider-min=\"-200\" data-slider-max=\"200\" data-slider-step=\"5\" data-slider-value=\"[-100,100]\" data-slider-orientation=\"vertical\" data-slider-selection=\"before\" data-slider-tooltip=\"show\">\n                </div>\n                </div>\n            </div>\n            </div>\n            \n        </div>\n        \n        </div>\n        \n    </div>\n    \n    </div>\n</section>");
        }
        #pragma warning restore 1998
#nullable restore
#line 169 "/Volumes/Macintosh HD2/CrossPlatformWork/DesktopApp/BlazorAdminLTE_side/BlazorAdminLTE/Pages/UI/Sliders.razor"
 
    public async Task LoadJavaScript()
    {
        await JSRuntime.InvokeVoidAsync("loadJavaScript");
        await JSRuntime.InvokeVoidAsync("loadSliders");
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
