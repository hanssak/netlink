#pragma checksum "/Volumes/Macintosh HD2/CrossPlatformWork/DesktopApp/BlazorAdminLTE_side/BlazorAdminLTE/Shared/NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4be84f14d3549a4ebfa8865db14655097773de7"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorDesktopApp.Shared
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
#line 6 "/Volumes/Macintosh HD2/CrossPlatformWork/DesktopApp/BlazorAdminLTE_side/BlazorAdminLTE/_Imports.razor"
using Microsoft.JSInterop;

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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<ul class=""navbar-nav"">
    <li class=""nav-item"">
    <a class=""nav-link"" data-widget=""pushmenu"" href=""#"" role=""button""><i class=""fas fa-bars""></i></a>
    </li>
    <li class=""nav-item d-none d-sm-inline-block"">
    <a href=""index3.html"" class=""nav-link"">Home</a>
    </li>
    <li class=""nav-item d-none d-sm-inline-block"">
    <a href=""#"" class=""nav-link"">Contact</a>
    </li>
</ul>


");
            __builder.AddMarkupContent(1, @"<form class=""form-inline ml-3"">
    <div class=""input-group input-group-sm"">
    <input class=""form-control form-control-navbar"" type=""search"" placeholder=""Search"" aria-label=""Search"">
    <div class=""input-group-append"">
        <button class=""btn btn-navbar"" type=""submit"">
        <i class=""fas fa-search""></i>
        </button>
    </div>
    </div>
</form>


");
            __builder.AddMarkupContent(2, "<ul class=\"navbar-nav ml-auto\">\n    \n    <li class=\"nav-item dropdown\">\n    <a class=\"nav-link\" data-toggle=\"dropdown\" href=\"#\">\n        <i class=\"far fa-comments\"></i>\n        <span class=\"badge badge-danger navbar-badge\">3</span>\n    </a>\n    <div class=\"dropdown-menu dropdown-menu-lg dropdown-menu-right\">\n        <a href=\"#\" class=\"dropdown-item\">\n        \n        <div class=\"media\">\n            <img src=\"images/adminlte/user1-128x128.jpg\" alt=\"User Avatar\" class=\"img-size-50 mr-3 img-circle\">\n            <div class=\"media-body\">\n            <h3 class=\"dropdown-item-title\">\n                Brad Diesel\n                <span class=\"float-right text-sm text-danger\"><i class=\"fas fa-star\"></i></span>\n            </h3>\n            <p class=\"text-sm\">Call me whenever you can...</p>\n            <p class=\"text-sm text-muted\"><i class=\"far fa-clock mr-1\"></i> 4 Hours Ago</p>\n            </div>\n        </div>\n        \n        </a>\n        <div class=\"dropdown-divider\"></div>\n        <a href=\"#\" class=\"dropdown-item\">\n        \n        <div class=\"media\">\n            <img src=\"images/adminlte/user8-128x128.jpg\" alt=\"User Avatar\" class=\"img-size-50 img-circle mr-3\">\n            <div class=\"media-body\">\n            <h3 class=\"dropdown-item-title\">\n                John Pierce\n                <span class=\"float-right text-sm text-muted\"><i class=\"fas fa-star\"></i></span>\n            </h3>\n            <p class=\"text-sm\">I got your message bro</p>\n            <p class=\"text-sm text-muted\"><i class=\"far fa-clock mr-1\"></i> 4 Hours Ago</p>\n            </div>\n        </div>\n        \n        </a>\n        <div class=\"dropdown-divider\"></div>\n        <a href=\"#\" class=\"dropdown-item\">\n        \n        <div class=\"media\">\n            <img src=\"images/adminlte/user3-128x128.jpg\" alt=\"User Avatar\" class=\"img-size-50 img-circle mr-3\">\n            <div class=\"media-body\">\n            <h3 class=\"dropdown-item-title\">\n                Nora Silvester\n                <span class=\"float-right text-sm text-warning\"><i class=\"fas fa-star\"></i></span>\n            </h3>\n            <p class=\"text-sm\">The subject goes here</p>\n            <p class=\"text-sm text-muted\"><i class=\"far fa-clock mr-1\"></i> 4 Hours Ago</p>\n            </div>\n        </div>\n        \n        </a>\n        <div class=\"dropdown-divider\"></div>\n        <a href=\"#\" class=\"dropdown-item dropdown-footer\">See All Messages</a>\n    </div>\n    </li>\n    \n    <li class=\"nav-item dropdown\">\n    <a class=\"nav-link\" data-toggle=\"dropdown\" href=\"#\">\n        <i class=\"far fa-bell\"></i>\n        <span class=\"badge badge-warning navbar-badge\">15</span>\n    </a>\n    <div class=\"dropdown-menu dropdown-menu-lg dropdown-menu-right\">\n        <span class=\"dropdown-item dropdown-header\">15 Notifications</span>\n        <div class=\"dropdown-divider\"></div>\n        <a href=\"#\" class=\"dropdown-item\">\n        <i class=\"fas fa-envelope mr-2\"></i> 4 new messages\n        <span class=\"float-right text-muted text-sm\">3 mins</span>\n        </a>\n        <div class=\"dropdown-divider\"></div>\n        <a href=\"#\" class=\"dropdown-item\">\n        <i class=\"fas fa-users mr-2\"></i> 8 friend requests\n        <span class=\"float-right text-muted text-sm\">12 hours</span>\n        </a>\n        <div class=\"dropdown-divider\"></div>\n        <a href=\"#\" class=\"dropdown-item\">\n        <i class=\"fas fa-file mr-2\"></i> 3 new reports\n        <span class=\"float-right text-muted text-sm\">2 days</span>\n        </a>\n        <div class=\"dropdown-divider\"></div>\n        <a href=\"#\" class=\"dropdown-item dropdown-footer\">See All Notifications</a>\n    </div>\n    </li>\n    <li class=\"nav-item\">\n    <a class=\"nav-link\" data-widget=\"control-sidebar\" data-slide=\"true\" href=\"#\" role=\"button\"><i class=\"fas fa-th-large\"></i></a>\n    </li>\n</ul>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
