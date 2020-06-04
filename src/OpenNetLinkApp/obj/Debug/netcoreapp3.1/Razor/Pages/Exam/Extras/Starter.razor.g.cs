#pragma checksum "/data/CrossPlatformWork/OpenNetLink/src/OpenNetLinkApp/Pages/Exam/Extras/Starter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a15069bd7d31abfac9e36a3cd0f85978b9249b9"
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
#line 3 "/data/CrossPlatformWork/OpenNetLink/src/OpenNetLinkApp/Pages/Exam/Extras/Starter.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Exam/Extras/starter")]
    public partial class Starter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""content-header"">
    <div class=""container-fluid"">
      <div class=""row mb-2"">
        <div class=""col-sm-6"">
          <h1 class=""m-0 text-dark"">Starter Page</h1>
        </div>
        <div class=""col-sm-6"">
          <ol class=""breadcrumb float-sm-right"">
            <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
            <li class=""breadcrumb-item active"">Starter Page</li>
          </ol>
        </div>
      </div>
    </div>
  </div>
  

  
  ");
            __builder.AddMarkupContent(1, "<div class=\"content\">\n    <div class=\"container-fluid\">\n      <div class=\"row\">\n        <div class=\"col-lg-6\">\n          <div class=\"card\">\n            <div class=\"card-body\">\n              <h5 class=\"card-title\">Card title</h5>\n\n              <p class=\"card-text\">\n                Some quick example text to build on the card title and make up the bulk of the card\'s\n                content.\n              </p>\n\n              <a href=\"#\" class=\"card-link\">Card link</a>\n              <a href=\"#\" class=\"card-link\">Another link</a>\n            </div>\n          </div>\n\n          <div class=\"card card-primary card-outline\">\n            <div class=\"card-body\">\n              <h5 class=\"card-title\">Card title</h5>\n\n              <p class=\"card-text\">\n                Some quick example text to build on the card title and make up the bulk of the card\'s\n                content.\n              </p>\n              <a href=\"#\" class=\"card-link\">Card link</a>\n              <a href=\"#\" class=\"card-link\">Another link</a>\n            </div>\n          </div>\n        </div>\n        \n        <div class=\"col-lg-6\">\n          <div class=\"card\">\n            <div class=\"card-header\">\n              <h5 class=\"m-0\">Featured</h5>\n            </div>\n            <div class=\"card-body\">\n              <h6 class=\"card-title\">Special title treatment</h6>\n\n              <p class=\"card-text\">With supporting text below as a natural lead-in to additional content.</p>\n              <a href=\"#\" class=\"btn btn-primary\">Go somewhere</a>\n            </div>\n          </div>\n\n          <div class=\"card card-primary card-outline\">\n            <div class=\"card-header\">\n              <h5 class=\"m-0\">Featured</h5>\n            </div>\n            <div class=\"card-body\">\n              <h6 class=\"card-title\">Special title treatment</h6>\n\n              <p class=\"card-text\">With supporting text below as a natural lead-in to additional content.</p>\n              <a href=\"#\" class=\"btn btn-primary\">Go somewhere</a>\n            </div>\n          </div>\n        </div>\n        \n      </div>\n      \n    </div>\n  </div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 94 "/data/CrossPlatformWork/OpenNetLink/src/OpenNetLinkApp/Pages/Exam/Extras/Starter.razor"
 
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
