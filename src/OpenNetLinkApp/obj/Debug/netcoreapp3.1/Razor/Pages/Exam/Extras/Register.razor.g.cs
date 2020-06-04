#pragma checksum "/data/CrossPlatformWork/OpenNetLink/src/OpenNetLinkApp/Pages/Exam/Extras/Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "297b7c728602d8edb251d9d979bb3fdaf2bee19e"
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
#line 3 "/data/CrossPlatformWork/OpenNetLink/src/OpenNetLinkApp/Pages/Exam/Extras/Register.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Exam/Extras/register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"hold-transition register-page\"> \n<div class=\"register-box\">\n  <div class=\"register-logo\">\n    <a href=\"/index2\"><b>Admin</b>LTE</a>\n  </div>\n\n  <div class=\"card\">\n    <div class=\"card-body register-card-body\">\n      <p class=\"login-box-msg\">Register a new membership</p>\n\n      <form action=\"/index1\" method=\"post\">\n        <div class=\"input-group mb-3\">\n          <input type=\"text\" class=\"form-control\" placeholder=\"Full name\">\n          <div class=\"input-group-append\">\n            <div class=\"input-group-text\">\n              <span class=\"fas fa-user\"></span>\n            </div>\n          </div>\n        </div>\n        <div class=\"input-group mb-3\">\n          <input type=\"email\" class=\"form-control\" placeholder=\"Email\">\n          <div class=\"input-group-append\">\n            <div class=\"input-group-text\">\n              <span class=\"fas fa-envelope\"></span>\n            </div>\n          </div>\n        </div>\n        <div class=\"input-group mb-3\">\n          <input type=\"password\" class=\"form-control\" placeholder=\"Password\">\n          <div class=\"input-group-append\">\n            <div class=\"input-group-text\">\n              <span class=\"fas fa-lock\"></span>\n            </div>\n          </div>\n        </div>\n        <div class=\"input-group mb-3\">\n          <input type=\"password\" class=\"form-control\" placeholder=\"Retype password\">\n          <div class=\"input-group-append\">\n            <div class=\"input-group-text\">\n              <span class=\"fas fa-lock\"></span>\n            </div>\n          </div>\n        </div>\n        <div class=\"row\">\n          <div class=\"col-8\">\n            <div class=\"icheck-primary\">\n              <input type=\"checkbox\" id=\"agreeTerms\" name=\"terms\" value=\"agree\">\n              <label for=\"agreeTerms\">\n               I agree to the <a href=\"#\">terms</a>\n              </label>\n            </div>\n          </div>\n          \n          <div class=\"col-4\">\n            <button type=\"submit\" class=\"btn btn-primary btn-block\">Register</button>\n          </div>\n          \n        </div>\n      </form>\n\n      <div class=\"social-auth-links text-center\">\n        <p>- OR -</p>\n        <a href=\"#\" class=\"btn btn-block btn-primary\">\n          <i class=\"fab fa-facebook mr-2\"></i>\n          Sign up using Facebook\n        </a>\n        <a href=\"#\" class=\"btn btn-block btn-danger\">\n          <i class=\"fab fa-google-plus mr-2\"></i>\n          Sign up using Google+\n        </a>\n      </div>\n\n      <a href=\"login.html\" class=\"text-center\">I already have a membership</a>\n    </div>\n    \n  </div>\n</div>\n\n\n</div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 88 "/data/CrossPlatformWork/OpenNetLink/src/OpenNetLinkApp/Pages/Exam/Extras/Register.razor"
 
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
