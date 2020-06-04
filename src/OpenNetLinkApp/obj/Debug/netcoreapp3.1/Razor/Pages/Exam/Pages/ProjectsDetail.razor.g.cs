#pragma checksum "/data/CrossPlatformWork/OpenNetLink/src/OpenNetLinkApp/Pages/Exam/Pages/ProjectsDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52c57fb55490cb9d356eb480367e7d79cadb3cb8"
// <auto-generated/>
#pragma warning disable 1591
namespace OpenNetLinkApp.Pages.Exam.Pages
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
#line 3 "/data/CrossPlatformWork/OpenNetLink/src/OpenNetLinkApp/Pages/Exam/Pages/ProjectsDetail.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Exam/Pages/projects-detail")]
    public partial class ProjectsDetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<section class=""content-header"">
    <div class=""container-fluid"">
    <div class=""row mb-2"">
        <div class=""col-sm-6"">
        <h1>Project Detail</h1>
        </div>
        <div class=""col-sm-6"">
        <ol class=""breadcrumb float-sm-right"">
            <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
            <li class=""breadcrumb-item active"">Project Detail</li>
        </ol>
        </div>
    </div>
    </div>
</section>


");
            __builder.AddMarkupContent(1, "<section class=\"content\">\n\n    \n    <div class=\"card\">\n    <div class=\"card-header\">\n        <h3 class=\"card-title\">Projects Detail</h3>\n\n        <div class=\"card-tools\">\n        <button type=\"button\" class=\"btn btn-tool\" data-card-widget=\"collapse\" data-toggle=\"tooltip\" title=\"Collapse\">\n            <i class=\"fas fa-minus\"></i></button>\n        <button type=\"button\" class=\"btn btn-tool\" data-card-widget=\"remove\" data-toggle=\"tooltip\" title=\"Remove\">\n            <i class=\"fas fa-times\"></i></button>\n        </div>\n    </div>\n    <div class=\"card-body\">\n        <div class=\"row\">\n        <div class=\"col-12 col-md-12 col-lg-8 order-2 order-md-1\">\n            <div class=\"row\">\n            <div class=\"col-12 col-sm-4\">\n                <div class=\"info-box bg-light\">\n                <div class=\"info-box-content\">\n                    <span class=\"info-box-text text-center text-muted\">Estimated budget</span>\n                    <span class=\"info-box-number text-center text-muted mb-0\">2300</span>\n                </div>\n                </div>\n            </div>\n            <div class=\"col-12 col-sm-4\">\n                <div class=\"info-box bg-light\">\n                <div class=\"info-box-content\">\n                    <span class=\"info-box-text text-center text-muted\">Total amount spent</span>\n                    <span class=\"info-box-number text-center text-muted mb-0\">2000</span>\n                </div>\n                </div>\n            </div>\n            <div class=\"col-12 col-sm-4\">\n                <div class=\"info-box bg-light\">\n                <div class=\"info-box-content\">\n                    <span class=\"info-box-text text-center text-muted\">Estimated project duration</span>\n                    <span class=\"info-box-number text-center text-muted mb-0\">20 </span>\n                </div>\n                </div>\n            </div>\n            </div>\n            <div class=\"row\">\n            <div class=\"col-12\">\n                <h4>Recent Activity</h4>\n                <div class=\"post\">\n                    <div class=\"user-block\">\n                    <img class=\"img-circle img-bordered-sm\" src=\"../../images/adminlte/user1-128x128.jpg\" alt=\"user image\">\n                    <span class=\"username\">\n                        <a href=\"#\">Jonathan Burke Jr.</a>\n                    </span>\n                    <span class=\"description\">Shared publicly - 7:45 PM today</span>\n                    </div>\n                    \n                    <p>\n                    Lorem ipsum represents a long-held tradition for designers,\n                    typographers and the like. Some people hate it and argue for\n                    its demise, but others ignore.\n                    </p>\n\n                    <p>\n                    <a href=\"#\" class=\"link-black text-sm\"><i class=\"fas fa-link mr-1\"></i> Demo File 1 v2</a>\n                    </p>\n                </div>\n\n                <div class=\"post clearfix\">\n                    <div class=\"user-block\">\n                    <img class=\"img-circle img-bordered-sm\" src=\"../../images/adminlte/user7-128x128.jpg\" alt=\"User Image\">\n                    <span class=\"username\">\n                        <a href=\"#\">Sarah Ross</a>\n                    </span>\n                    <span class=\"description\">Sent you a message - 3 days ago</span>\n                    </div>\n                    \n                    <p>\n                    Lorem ipsum represents a long-held tradition for designers,\n                    typographers and the like. Some people hate it and argue for\n                    its demise, but others ignore.\n                    </p>\n                    <p>\n                    <a href=\"#\" class=\"link-black text-sm\"><i class=\"fas fa-link mr-1\"></i> Demo File 2</a>\n                    </p>\n                </div>\n\n                <div class=\"post\">\n                    <div class=\"user-block\">\n                    <img class=\"img-circle img-bordered-sm\" src=\"../../images/adminlte/user1-128x128.jpg\" alt=\"user image\">\n                    <span class=\"username\">\n                        <a href=\"#\">Jonathan Burke Jr.</a>\n                    </span>\n                    <span class=\"description\">Shared publicly - 5 days ago</span>\n                    </div>\n                    \n                    <p>\n                    Lorem ipsum represents a long-held tradition for designers,\n                    typographers and the like. Some people hate it and argue for\n                    its demise, but others ignore.\n                    </p>\n\n                    <p>\n                    <a href=\"#\" class=\"link-black text-sm\"><i class=\"fas fa-link mr-1\"></i> Demo File 1 v1</a>\n                    </p>\n                </div>\n            </div>\n            </div>\n        </div>\n        <div class=\"col-12 col-md-12 col-lg-4 order-1 order-md-2\">\n            <h3 class=\"text-primary\"><i class=\"fas fa-paint-brush\"></i> AdminLTE v3</h3>\n            <p class=\"text-muted\">Raw denim you probably haven\'t heard of them jean shorts Austin. Nesciunt tofu stumptown aliqua butcher retro keffiyeh dreamcatcher synth. Cosby sweater eu banh mi, qui irure terr.</p>\n            <br>\n            <div class=\"text-muted\">\n            <p class=\"text-sm\">Client Company\n                <b class=\"d-block\">Deveint Inc</b>\n            </p>\n            <p class=\"text-sm\">Project Leader\n                <b class=\"d-block\">Tony Chicken</b>\n            </p>\n            </div>\n\n            <h5 class=\"mt-5 text-muted\">Project files</h5>\n            <ul class=\"list-unstyled\">\n            <li>\n                <a href class=\"btn-link text-secondary\"><i class=\"far fa-fw fa-file-word\"></i> Functional-requirements.docx</a>\n            </li>\n            <li>\n                <a href class=\"btn-link text-secondary\"><i class=\"far fa-fw fa-file-pdf\"></i> UAT.pdf</a>\n            </li>\n            <li>\n                <a href class=\"btn-link text-secondary\"><i class=\"far fa-fw fa-envelope\"></i> Email-from-flatbal.mln</a>\n            </li>\n            <li>\n                <a href class=\"btn-link text-secondary\"><i class=\"far fa-fw fa-image \"></i> Logo.png</a>\n            </li>\n            <li>\n                <a href class=\"btn-link text-secondary\"><i class=\"far fa-fw fa-file-word\"></i> Contract-10_12_2014.docx</a>\n            </li>\n            </ul>\n            <div class=\"text-center mt-5 mb-3\">\n            <a href=\"#\" class=\"btn btn-sm btn-primary\">Add files</a>\n            <a href=\"#\" class=\"btn btn-sm btn-warning\">Report contact</a>\n            </div>\n        </div>\n        </div>\n    </div>\n    \n    </div>\n    \n\n</section>");
        }
        #pragma warning restore 1998
#nullable restore
#line 181 "/data/CrossPlatformWork/OpenNetLink/src/OpenNetLinkApp/Pages/Exam/Pages/ProjectsDetail.razor"
 
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
