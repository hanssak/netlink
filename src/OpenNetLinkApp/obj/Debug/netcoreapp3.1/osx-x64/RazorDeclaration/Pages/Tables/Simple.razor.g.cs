#pragma checksum "/Volumes/Macintosh HD2/CrossPlatformWork/DesktopApp/BlazorAdminLTE_side/BlazorAdminLTE/Pages/Tables/Simple.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffbb00837762491eef9c2564e384002ff7df1edd"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorDesktopApp.Pages.Tables
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
#line 3 "/Volumes/Macintosh HD2/CrossPlatformWork/DesktopApp/BlazorAdminLTE_side/BlazorAdminLTE/Pages/Tables/Simple.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Tables/simple")]
    public partial class Simple : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 473 "/Volumes/Macintosh HD2/CrossPlatformWork/DesktopApp/BlazorAdminLTE_side/BlazorAdminLTE/Pages/Tables/Simple.razor"
 
    public async Task LoadJavaScript()
    {
        await JSRuntime.InvokeVoidAsync("loadJavaScript");
        //await JSRuntime.InvokeVoidAsync("loadTablesSimple");
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
