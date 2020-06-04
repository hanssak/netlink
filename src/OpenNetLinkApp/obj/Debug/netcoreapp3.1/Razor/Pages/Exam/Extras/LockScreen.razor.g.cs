#pragma checksum "/data/CrossPlatformWork/OpenNetLink/src/OpenNetLinkApp/Pages/Exam/Extras/LockScreen.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18d05ef2516dd0e6a50ea9819b56cb43c8b4470b"
// <auto-generated/>
#pragma warning disable 1591
namespace OpenNetLinkApp.Pages.Exam.Extras
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
#line 3 "/data/CrossPlatformWork/OpenNetLink/src/OpenNetLinkApp/Pages/Exam/Extras/LockScreen.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Exam/Extras/lockscreen")]
    public partial class LockScreen : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""hold-transition lockscreen""> 

<div class=""lockscreen-wrapper"">
  <div class=""lockscreen-logo"">
    <a href=""/index2""><b>Admin</b>LTE</a>
  </div>
  
  <div class=""lockscreen-name"">John Doe</div>

  
  <div class=""lockscreen-item"">
    
    <div class=""lockscreen-image"">
      <img src=""../../images/adminlte/user1-128x128.jpg"" alt=""User Image"">
    </div>
    

    
    <form class=""lockscreen-credentials"">
      <div class=""input-group"">
        <input type=""password"" class=""form-control"" placeholder=""password"">

        <div class=""input-group-append"">
          <button type=""button"" class=""btn""><i class=""fas fa-arrow-right text-muted""></i></button>
        </div>
      </div>
    </form>
    

  </div>
  
  <div class=""help-block text-center"">
    Enter your password to retrieve your session
  </div>
  <div class=""text-center"">
    <a href=""/Exam/Extras/login"">Or sign in as a different user</a>
  </div>
  <div class=""lockscreen-footer text-center"">
    Copyright &copy; 2014-2019 <b><a href=""http://adminlte.io"" class=""text-black"">AdminLTE.io</a></b><br>
    All rights reserved
  </div>
</div>


</div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "/data/CrossPlatformWork/OpenNetLink/src/OpenNetLinkApp/Pages/Exam/Extras/LockScreen.razor"
 
    public async Task LoadJavaScript()
    {
        await JSRuntime.InvokeVoidAsync("loadJavaScript");
        //await JSRuntime.InvokeVoidAsync("loadMailBoxInBox");
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
