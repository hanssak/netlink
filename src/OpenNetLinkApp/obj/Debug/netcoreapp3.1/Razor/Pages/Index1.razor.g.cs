#pragma checksum "/data/CrossPlatformWork/OpenNetLink/src/OpenNetLinkApp/Pages/Index1.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "911ef1762bc089a0dfed04e70148de563dc6483c"
// <auto-generated/>
#pragma warning disable 1591
namespace OpenNetLinkApp.Pages
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
#line 3 "/data/CrossPlatformWork/OpenNetLink/src/OpenNetLinkApp/Pages/Index1.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/index1")]
    public partial class Index1 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""content-header"">
    <div class=""container-fluid"">
    <div class=""row mb-2"">
        <div class=""col-sm-6"">
        <h1 class=""m-0 text-dark"">Dashboard</h1>
        </div>
        <div class=""col-sm-6"">
        <ol class=""breadcrumb float-sm-right"">
            <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
            <li class=""breadcrumb-item active"">Dashboard v1</li>
        </ol>
        </div>
    </div>
    </div>
</div>



");
            __builder.AddMarkupContent(1, "<section class=\"content\">\n    <div class=\"container-fluid\">\n    \n    <div class=\"row\">\n        <div class=\"col-lg-3 col-6\">\n        \n        <div class=\"small-box bg-info\">\n            <div class=\"inner\">\n            <h3>150</h3>\n\n            <p>New Orders</p>\n            </div>\n            <div class=\"icon\">\n            <i class=\"ion ion-bag\"></i>\n            </div>\n            <a href=\"#\" class=\"small-box-footer\">More info <i class=\"fas fa-arrow-circle-right\"></i></a>\n        </div>\n        </div>\n        \n        <div class=\"col-lg-3 col-6\">\n        \n        <div class=\"small-box bg-success\">\n            <div class=\"inner\">\n            <h3>53<sup style=\"font-size: 20px\">%</sup></h3>\n\n            <p>Bounce Rate</p>\n            </div>\n            <div class=\"icon\">\n            <i class=\"ion ion-stats-bars\"></i>\n            </div>\n            <a href=\"#\" class=\"small-box-footer\">More info <i class=\"fas fa-arrow-circle-right\"></i></a>\n        </div>\n        </div>\n        \n        <div class=\"col-lg-3 col-6\">\n        \n        <div class=\"small-box bg-warning\">\n            <div class=\"inner\">\n            <h3>44</h3>\n\n            <p>User Registrations</p>\n            </div>\n            <div class=\"icon\">\n            <i class=\"ion ion-person-add\"></i>\n            </div>\n            <a href=\"#\" class=\"small-box-footer\">More info <i class=\"fas fa-arrow-circle-right\"></i></a>\n        </div>\n        </div>\n        \n        <div class=\"col-lg-3 col-6\">\n        \n        <div class=\"small-box bg-danger\">\n            <div class=\"inner\">\n            <h3>65</h3>\n\n            <p>Unique Visitors</p>\n            </div>\n            <div class=\"icon\">\n            <i class=\"ion ion-pie-graph\"></i>\n            </div>\n            <a href=\"#\" class=\"small-box-footer\">More info <i class=\"fas fa-arrow-circle-right\"></i></a>\n        </div>\n        </div>\n        \n    </div>\n    \n    \n    <div class=\"row\">\n        \n        <section class=\"col-lg-7 connectedSortable\">\n        \n        <div class=\"card\">\n            <div class=\"card-header\">\n            <h3 class=\"card-title\">\n                <i class=\"fas fa-chart-pie mr-1\"></i>\n                Sales\n            </h3>\n            <div class=\"card-tools\">\n                <ul class=\"nav nav-pills ml-auto\">\n                <li class=\"nav-item\">\n                    <a class=\"nav-link active\" href=\"#revenue-chart\" data-toggle=\"tab\">Area</a>\n                </li>\n                <li class=\"nav-item\">\n                    <a class=\"nav-link\" href=\"#sales-chart\" data-toggle=\"tab\">Donut</a>\n                </li>\n                </ul>\n            </div>\n            </div>\n            <div class=\"card-body\">\n            <div class=\"tab-content p-0\">\n                \n                <div class=\"chart tab-pane active\" id=\"revenue-chart\" style=\"position: relative; height: 300px;\">\n                    <canvas id=\"revenue-chart-canvas\" height=\"300\" style=\"height: 300px;\"></canvas>                         \n                </div>\n                <div class=\"chart tab-pane\" id=\"sales-chart\" style=\"position: relative; height: 300px;\">\n                <canvas id=\"sales-chart-canvas\" height=\"300\" style=\"height: 300px;\"></canvas>                         \n                </div>  \n            </div>\n            </div>\n        </div>\n        \n\n        \n        <div class=\"card direct-chat direct-chat-primary\">\n            <div class=\"card-header\">\n            <h3 class=\"card-title\">Direct Chat</h3>\n\n            <div class=\"card-tools\">\n                <span data-toggle=\"tooltip\" title=\"3 New Messages\" class=\"badge badge-primary\">3</span>\n                <button type=\"button\" class=\"btn btn-tool\" data-card-widget=\"collapse\">\n                <i class=\"fas fa-minus\"></i>\n                </button>\n                <button type=\"button\" class=\"btn btn-tool\" data-toggle=\"tooltip\" title=\"Contacts\" data-widget=\"chat-pane-toggle\">\n                <i class=\"fas fa-comments\"></i>\n                </button>\n                <button type=\"button\" class=\"btn btn-tool\" data-card-widget=\"remove\"><i class=\"fas fa-times\"></i>\n                </button>\n            </div>\n            </div>\n            \n            <div class=\"card-body\">\n            \n            <div class=\"direct-chat-messages\">\n                \n                <div class=\"direct-chat-msg\">\n                <div class=\"direct-chat-infos clearfix\">\n                    <span class=\"direct-chat-name float-left\">Alexander Pierce</span>\n                    <span class=\"direct-chat-timestamp float-right\">23 Jan 2:00 pm</span>\n                </div>\n                \n                <img class=\"direct-chat-img\" src=\"images/adminlte/user1-128x128.jpg\" alt=\"message user image\">\n                \n                <div class=\"direct-chat-text\">\n                    Is this template really for free? That\'s unbelievable!\n                </div>\n                \n                </div>\n                \n\n                \n                <div class=\"direct-chat-msg right\">\n                <div class=\"direct-chat-infos clearfix\">\n                    <span class=\"direct-chat-name float-right\">Sarah Bullock</span>\n                    <span class=\"direct-chat-timestamp float-left\">23 Jan 2:05 pm</span>\n                </div>\n                \n                <img class=\"direct-chat-img\" src=\"images/adminlte/user3-128x128.jpg\" alt=\"message user image\">\n                \n                <div class=\"direct-chat-text\">\n                    You better believe it!\n                </div>\n                \n                </div>\n                \n\n                \n                <div class=\"direct-chat-msg\">\n                <div class=\"direct-chat-infos clearfix\">\n                    <span class=\"direct-chat-name float-left\">Alexander Pierce</span>\n                    <span class=\"direct-chat-timestamp float-right\">23 Jan 5:37 pm</span>\n                </div>\n                \n                <img class=\"direct-chat-img\" src=\"images/adminlte/user1-128x128.jpg\" alt=\"message user image\">\n                \n                <div class=\"direct-chat-text\">\n                    Working with AdminLTE on a great new app! Wanna join?\n                </div>\n                \n                </div>\n                \n\n                \n                <div class=\"direct-chat-msg right\">\n                <div class=\"direct-chat-infos clearfix\">\n                    <span class=\"direct-chat-name float-right\">Sarah Bullock</span>\n                    <span class=\"direct-chat-timestamp float-left\">23 Jan 6:10 pm</span>\n                </div>\n                \n                <img class=\"direct-chat-img\" src=\"images/adminlte/user3-128x128.jpg\" alt=\"message user image\">\n                \n                <div class=\"direct-chat-text\">\n                    I would love to.\n                </div>\n                \n                </div>\n                \n\n            </div>\n            \n\n            \n            <div class=\"direct-chat-contacts\">\n                <ul class=\"contacts-list\">\n                <li>\n                    <a href=\"#\">\n                    <img class=\"contacts-list-img\" src=\"images/adminlte/user1-128x128.jpg\">\n\n                    <div class=\"contacts-list-info\">\n                        <span class=\"contacts-list-name\">\n                        Count Dracula\n                        <small class=\"contacts-list-date float-right\">2/28/2015</small>\n                        </span>\n                        <span class=\"contacts-list-msg\">How have you been? I was...</span>\n                    </div>\n                    \n                    </a>\n                </li>\n                \n                <li>\n                    <a href=\"#\">\n                    <img class=\"contacts-list-img\" src=\"images/adminlte/user7-128x128.jpg\">\n\n                    <div class=\"contacts-list-info\">\n                        <span class=\"contacts-list-name\">\n                        Sarah Doe\n                        <small class=\"contacts-list-date float-right\">2/23/2015</small>\n                        </span>\n                        <span class=\"contacts-list-msg\">I will be waiting for...</span>\n                    </div>\n                    \n                    </a>\n                </li>\n                \n                <li>\n                    <a href=\"#\">\n                    <img class=\"contacts-list-img\" src=\"images/adminlte/user3-128x128.jpg\">\n\n                    <div class=\"contacts-list-info\">\n                        <span class=\"contacts-list-name\">\n                        Nadia Jolie\n                        <small class=\"contacts-list-date float-right\">2/20/2015</small>\n                        </span>\n                        <span class=\"contacts-list-msg\">I\'ll call you back at...</span>\n                    </div>\n                    \n                    </a>\n                </li>\n                \n                <li>\n                    <a href=\"#\">\n                    <img class=\"contacts-list-img\" src=\"images/adminlte/user5-128x128.jpg\">\n\n                    <div class=\"contacts-list-info\">\n                        <span class=\"contacts-list-name\">\n                        Nora S. Vans\n                        <small class=\"contacts-list-date float-right\">2/10/2015</small>\n                        </span>\n                        <span class=\"contacts-list-msg\">Where is your new...</span>\n                    </div>\n                    \n                    </a>\n                </li>\n                \n                <li>\n                    <a href=\"#\">\n                    <img class=\"contacts-list-img\" src=\"images/adminlte/user6-128x128.jpg\">\n\n                    <div class=\"contacts-list-info\">\n                        <span class=\"contacts-list-name\">\n                        John K.\n                        <small class=\"contacts-list-date float-right\">1/27/2015</small>\n                        </span>\n                        <span class=\"contacts-list-msg\">Can I take a look at...</span>\n                    </div>\n                    \n                    </a>\n                </li>\n                \n                <li>\n                    <a href=\"#\">\n                    <img class=\"contacts-list-img\" src=\"images/adminlte/user8-128x128.jpg\">\n\n                    <div class=\"contacts-list-info\">\n                        <span class=\"contacts-list-name\">\n                        Kenneth M.\n                        <small class=\"contacts-list-date float-right\">1/4/2015</small>\n                        </span>\n                        <span class=\"contacts-list-msg\">Never mind I found...</span>\n                    </div>\n                    \n                    </a>\n                </li>\n                \n                </ul>\n                \n            </div>\n            \n            </div>\n            \n            <div class=\"card-footer\">\n            <form action=\"#\" method=\"post\">\n                <div class=\"input-group\">\n                <input type=\"text\" name=\"message\" placeholder=\"Type Message ...\" class=\"form-control\">\n                <span class=\"input-group-append\">\n                    <button type=\"button\" class=\"btn btn-primary\">Send</button>\n                </span>\n                </div>\n            </form>\n            </div>\n            \n        </div>\n        \n\n        \n        <div class=\"card\">\n            <div class=\"card-header\">\n            <h3 class=\"card-title\">\n                <i class=\"ion ion-clipboard mr-1\"></i>\n                To Do List\n            </h3>\n\n            <div class=\"card-tools\">\n                <ul class=\"pagination pagination-sm\">\n                <li class=\"page-item\"><a href=\"#\" class=\"page-link\">&laquo;</a></li>\n                <li class=\"page-item\"><a href=\"#\" class=\"page-link\">1</a></li>\n                <li class=\"page-item\"><a href=\"#\" class=\"page-link\">2</a></li>\n                <li class=\"page-item\"><a href=\"#\" class=\"page-link\">3</a></li>\n                <li class=\"page-item\"><a href=\"#\" class=\"page-link\">&raquo;</a></li>\n                </ul>\n            </div>\n            </div>\n            \n            <div class=\"card-body\">\n            <ul class=\"todo-list\" data-widget=\"todo-list\">\n                <li>\n                \n                <span class=\"handle\">\n                    <i class=\"fas fa-ellipsis-v\"></i>\n                    <i class=\"fas fa-ellipsis-v\"></i>\n                </span>\n                \n                <div class=\"icheck-primary d-inline ml-2\">\n                    <input type=\"checkbox\" value name=\"todo1\" id=\"todoCheck1\">\n                    <label for=\"todoCheck1\"></label>\n                </div>\n                \n                <span class=\"text\">Design a nice theme</span>\n                \n                <small class=\"badge badge-danger\"><i class=\"far fa-clock\"></i> 2 mins</small>\n                \n                <div class=\"tools\">\n                    <i class=\"fas fa-edit\"></i>\n                    <i class=\"fas fa-trash-o\"></i>\n                </div>\n                </li>\n                <li>\n                <span class=\"handle\">\n                    <i class=\"fas fa-ellipsis-v\"></i>\n                    <i class=\"fas fa-ellipsis-v\"></i>\n                </span>\n                <div class=\"icheck-primary d-inline ml-2\">\n                    <input type=\"checkbox\" value name=\"todo2\" id=\"todoCheck2\" checked>\n                    <label for=\"todoCheck2\"></label>\n                </div>\n                <span class=\"text\">Make the theme responsive</span>\n                <small class=\"badge badge-info\"><i class=\"far fa-clock\"></i> 4 hours</small>\n                <div class=\"tools\">\n                    <i class=\"fas fa-edit\"></i>\n                    <i class=\"fas fa-trash-o\"></i>\n                </div>\n                </li>\n                <li>\n                <span class=\"handle\">\n                    <i class=\"fas fa-ellipsis-v\"></i>\n                    <i class=\"fas fa-ellipsis-v\"></i>\n                </span>\n                <div class=\"icheck-primary d-inline ml-2\">\n                    <input type=\"checkbox\" value name=\"todo3\" id=\"todoCheck3\">\n                    <label for=\"todoCheck3\"></label>\n                </div>\n                <span class=\"text\">Let theme shine like a star</span>\n                <small class=\"badge badge-warning\"><i class=\"far fa-clock\"></i> 1 day</small>\n                <div class=\"tools\">\n                    <i class=\"fas fa-edit\"></i>\n                    <i class=\"fas fa-trash-o\"></i>\n                </div>\n                </li>\n                <li>\n                <span class=\"handle\">\n                    <i class=\"fas fa-ellipsis-v\"></i>\n                    <i class=\"fas fa-ellipsis-v\"></i>\n                </span>\n                <div class=\"icheck-primary d-inline ml-2\">\n                    <input type=\"checkbox\" value name=\"todo4\" id=\"todoCheck4\">\n                    <label for=\"todoCheck4\"></label>\n                </div>\n                <span class=\"text\">Let theme shine like a star</span>\n                <small class=\"badge badge-success\"><i class=\"far fa-clock\"></i> 3 days</small>\n                <div class=\"tools\">\n                    <i class=\"fas fa-edit\"></i>\n                    <i class=\"fas fa-trash-o\"></i>\n                </div>\n                </li>\n                <li>\n                <span class=\"handle\">\n                    <i class=\"fas fa-ellipsis-v\"></i>\n                    <i class=\"fas fa-ellipsis-v\"></i>\n                </span>\n                <div class=\"icheck-primary d-inline ml-2\">\n                    <input type=\"checkbox\" value name=\"todo5\" id=\"todoCheck5\">\n                    <label for=\"todoCheck5\"></label>\n                </div>\n                <span class=\"text\">Check your messages and notifications</span>\n                <small class=\"badge badge-primary\"><i class=\"far fa-clock\"></i> 1 week</small>\n                <div class=\"tools\">\n                    <i class=\"fas fa-edit\"></i>\n                    <i class=\"fas fa-trash-o\"></i>\n                </div>\n                </li>\n                <li>\n                <span class=\"handle\">\n                    <i class=\"fas fa-ellipsis-v\"></i>\n                    <i class=\"fas fa-ellipsis-v\"></i>\n                </span>\n                <div class=\"icheck-primary d-inline ml-2\">\n                    <input type=\"checkbox\" value name=\"todo6\" id=\"todoCheck6\">\n                    <label for=\"todoCheck6\"></label>\n                </div>\n                <span class=\"text\">Let theme shine like a star</span>\n                <small class=\"badge badge-secondary\"><i class=\"far fa-clock\"></i> 1 month</small>\n                <div class=\"tools\">\n                    <i class=\"fas fa-edit\"></i>\n                    <i class=\"fas fa-trash-o\"></i>\n                </div>\n                </li>\n            </ul>\n            </div>\n            \n            <div class=\"card-footer clearfix\">\n            <button type=\"button\" class=\"btn btn-info float-right\"><i class=\"fas fa-plus\"></i> Add item</button>\n            </div>\n        </div>\n        \n        </section>\n        \n        \n        <section class=\"col-lg-5 connectedSortable\">\n\n        \n        <div class=\"card bg-gradient-primary\">\n            <div class=\"card-header border-0\">\n            <h3 class=\"card-title\">\n                <i class=\"fas fa-map-marker-alt mr-1\"></i>\n                Visitors\n            </h3>\n            \n            <div class=\"card-tools\">\n                <button type=\"button\" class=\"btn btn-primary btn-sm daterange\" data-toggle=\"tooltip\" title=\"Date range\">\n                <i class=\"far fa-calendar-alt\"></i>\n                </button>\n                <button type=\"button\" class=\"btn btn-primary btn-sm\" data-card-widget=\"collapse\" data-toggle=\"tooltip\" title=\"Collapse\">\n                <i class=\"fas fa-minus\"></i>\n                </button>\n            </div>\n            \n            </div>\n            <div class=\"card-body\">\n            <div id=\"world-map\" style=\"height: 250px; width: 100%;\"></div>\n            </div>\n            \n            <div class=\"card-footer bg-transparent\">\n            <div class=\"row\">\n                <div class=\"col-4 text-center\">\n                <div id=\"sparkline-1\"></div>\n                <div class=\"text-white\">Visitors</div>\n                </div>\n                \n                <div class=\"col-4 text-center\">\n                <div id=\"sparkline-2\"></div>\n                <div class=\"text-white\">Online</div>\n                </div>\n                \n                <div class=\"col-4 text-center\">\n                <div id=\"sparkline-3\"></div>\n                <div class=\"text-white\">Sales</div>\n                </div>\n                \n            </div>\n            \n            </div>\n        </div>\n        \n\n        \n        <div class=\"card bg-gradient-info\">\n            <div class=\"card-header border-0\">\n            <h3 class=\"card-title\">\n                <i class=\"fas fa-th mr-1\"></i>\n                Sales Graph\n            </h3>\n\n            <div class=\"card-tools\">\n                <button type=\"button\" class=\"btn bg-info btn-sm\" data-card-widget=\"collapse\">\n                <i class=\"fas fa-minus\"></i>\n                </button>\n                <button type=\"button\" class=\"btn bg-info btn-sm\" data-card-widget=\"remove\">\n                <i class=\"fas fa-times\"></i>\n                </button>\n            </div>\n            </div>\n            <div class=\"card-body\">\n            <canvas class=\"chart\" id=\"line-chart\" style=\"min-height: 250px; height: 250px; max-height: 250px; max-width: 100%;\"></canvas>\n            </div>\n            \n            <div class=\"card-footer bg-transparent\">\n            <div class=\"row\">\n                <div class=\"col-4 text-center\">\n                <input type=\"text\" class=\"knob\" data-readonly=\"true\" value=\"20\" data-width=\"60\" data-height=\"60\" data-fgColor=\"#39CCCC\">\n\n                <div class=\"text-white\">Mail-Orders</div>\n                </div>\n                \n                <div class=\"col-4 text-center\">\n                <input type=\"text\" class=\"knob\" data-readonly=\"true\" value=\"50\" data-width=\"60\" data-height=\"60\" data-fgColor=\"#39CCCC\">\n\n                <div class=\"text-white\">Online</div>\n                </div>\n                \n                <div class=\"col-4 text-center\">\n                <input type=\"text\" class=\"knob\" data-readonly=\"true\" value=\"30\" data-width=\"60\" data-height=\"60\" data-fgColor=\"#39CCCC\">\n\n                <div class=\"text-white\">In-Store</div>\n                </div>\n                \n            </div>\n            \n            </div>\n            \n        </div>\n        \n\n        \n        <div class=\"card bg-gradient-success\">\n            <div class=\"card-header border-0\">\n\n            <h3 class=\"card-title\">\n                <i class=\"far fa-calendar-alt\"></i>\n                Calendar\n            </h3>\n            \n            <div class=\"card-tools\">\n                \n                <div class=\"btn-group\">\n                <button type=\"button\" class=\"btn btn-success btn-sm dropdown-toggle\" data-toggle=\"dropdown\" data-offset=\"-52\">\n                    <i class=\"fas fa-bars\"></i></button>\n                <div class=\"dropdown-menu\" role=\"menu\">\n                    <a href=\"#\" class=\"dropdown-item\">Add new event</a>\n                    <a href=\"#\" class=\"dropdown-item\">Clear events</a>\n                    <div class=\"dropdown-divider\"></div>\n                    <a href=\"#\" class=\"dropdown-item\">View calendar</a>\n                </div>\n                </div>\n                <button type=\"button\" class=\"btn btn-success btn-sm\" data-card-widget=\"collapse\">\n                <i class=\"fas fa-minus\"></i>\n                </button>\n                <button type=\"button\" class=\"btn btn-success btn-sm\" data-card-widget=\"remove\">\n                <i class=\"fas fa-times\"></i>\n                </button>\n            </div>\n            \n            </div>\n            \n            <div class=\"card-body pt-0\">\n            \n            <div id=\"calendar\" style=\"width: 100%\"></div>\n            </div>\n            \n        </div>\n        \n        </section>\n        \n    </div>\n    \n    </div>\n</section>");
        }
        #pragma warning restore 1998
#nullable restore
#line 619 "/data/CrossPlatformWork/OpenNetLink/src/OpenNetLinkApp/Pages/Index1.razor"
 
    public async Task LoadJavaScript()
    {
        await JSRuntime.InvokeVoidAsync("loadJavaScript");
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
