#pragma checksum "/data/CrossPlatformWork/OpenNetLink/src/OpenNetLinkApp/Pages/Exam/Gallery.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0632bf55b8d725a4101b30ab5f0d6af61bce5e9a"
// <auto-generated/>
#pragma warning disable 1591
namespace OpenNetLinkApp.Pages.Exam
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
#line 3 "/data/CrossPlatformWork/OpenNetLink/src/OpenNetLinkApp/Pages/Exam/Gallery.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Exam/gallery")]
    public partial class Gallery : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<section class=""content-header"">
    <div class=""container-fluid"">
    <div class=""row mb-2"">
        <div class=""col-sm-6"">
        <h1>Gallery</h1>
        </div>
        <div class=""col-sm-6"">
        <ol class=""breadcrumb float-sm-right"">
            <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
            <li class=""breadcrumb-item active"">Gallery</li>
        </ol>
        </div>
    </div>
    </div>
</section>


");
            __builder.OpenElement(1, "section");
            __builder.AddAttribute(2, "class", "content");
            __builder.AddMarkupContent(3, "\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container-fluid");
            __builder.AddMarkupContent(6, "\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "row");
            __builder.AddMarkupContent(9, "\n        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-12");
            __builder.AddMarkupContent(12, "\n        ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "card card-primary");
            __builder.AddMarkupContent(15, "\n            ");
            __builder.AddMarkupContent(16, "<div class=\"card-header\">\n            <div class=\"card-title\">\n                FilterizR Gallery with Ekko Lightbox\n            </div>\n            </div>\n            ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "card-body");
            __builder.AddMarkupContent(19, "\n            ");
            __builder.OpenElement(20, "div");
            __builder.AddMarkupContent(21, "\n                ");
            __builder.AddMarkupContent(22, @"<div class=""btn-group w-100 mb-2"">
                <a class=""btn btn-info active"" href=""javascript:void(0)"" data-filter=""all""> All items </a>
                <a class=""btn btn-info"" href=""javascript:void(0)"" data-filter=""1""> Category 1 (WHITE) </a>
                <a class=""btn btn-info"" href=""javascript:void(0)"" data-filter=""2""> Category 2 (BLACK) </a>
                <a class=""btn btn-info"" href=""javascript:void(0)"" data-filter=""3""> Category 3 (COLORED) </a>
                <a class=""btn btn-info"" href=""javascript:void(0)"" data-filter=""4""> Category 4 (COLORED, BLACK) </a>
                </div>
                ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "mb-2");
            __builder.AddMarkupContent(25, "\n                ");
            __builder.AddMarkupContent(26, "<a class=\"btn btn-secondary\" href=\"javascript:void(0)\" data-shuffle> Shuffle items </a>\n                ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "float-right");
            __builder.AddMarkupContent(29, "\n                    ");
            __builder.OpenElement(30, "select");
            __builder.AddAttribute(31, "class", "custom-select");
            __builder.AddAttribute(32, "style", "width: auto;");
            __builder.AddAttribute(33, "data-sortOrder", true);
            __builder.AddMarkupContent(34, "\n                    ");
            __builder.OpenElement(35, "option");
            __builder.AddAttribute(36, "value", "index");
            __builder.AddContent(37, " Sort by Position ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\n                    ");
            __builder.OpenElement(39, "option");
            __builder.AddAttribute(40, "value", "sortData");
            __builder.AddContent(41, " Sort by Custom Data ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n                    ");
            __builder.AddMarkupContent(44, @"<div class=""btn-group"">
                    <a class=""btn btn-default"" href=""javascript:void(0)"" data-sortAsc> Ascending </a>
                    <a class=""btn btn-default"" href=""javascript:void(0)"" data-sortDesc> Descending </a>
                    </div>
                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\n            ");
            __builder.AddMarkupContent(48, "<div>\n                <div class=\"filter-container p-0 row\">\n                <div class=\"filtr-item col-sm-2\" data-category=\"1\" data-sort=\"white sample\">\n                    <a href=\"https://via.placeholder.com/1200/FFFFFF.png?text=1\" data-toggle=\"lightbox\" data-title=\"sample 1 - white\">\n                    <img src=\"https://via.placeholder.com/300/FFFFFF?text=1\" class=\"img-fluid mb-2\" alt=\"white sample\">\n                    </a>\n                </div>\n                <div class=\"filtr-item col-sm-2\" data-category=\"2, 4\" data-sort=\"black sample\">\n                    <a href=\"https://via.placeholder.com/1200/000000.png?text=2\" data-toggle=\"lightbox\" data-title=\"sample 2 - black\">\n                    <img src=\"https://via.placeholder.com/300/000000?text=2\" class=\"img-fluid mb-2\" alt=\"black sample\">\n                    </a>\n                </div>\n                <div class=\"filtr-item col-sm-2\" data-category=\"3, 4\" data-sort=\"red sample\">\n                    <a href=\"https://via.placeholder.com/1200/FF0000/FFFFFF.png?text=3\" data-toggle=\"lightbox\" data-title=\"sample 3 - red\">\n                    <img src=\"https://via.placeholder.com/300/FF0000/FFFFFF?text=3\" class=\"img-fluid mb-2\" alt=\"red sample\">\n                    </a>\n                </div>\n                <div class=\"filtr-item col-sm-2\" data-category=\"3, 4\" data-sort=\"red sample\">\n                    <a href=\"https://via.placeholder.com/1200/FF0000/FFFFFF.png?text=4\" data-toggle=\"lightbox\" data-title=\"sample 4 - red\">\n                    <img src=\"https://via.placeholder.com/300/FF0000/FFFFFF?text=4\" class=\"img-fluid mb-2\" alt=\"red sample\">\n                    </a>\n                </div>\n                <div class=\"filtr-item col-sm-2\" data-category=\"2, 4\" data-sort=\"black sample\">\n                    <a href=\"https://via.placeholder.com/1200/000000.png?text=5\" data-toggle=\"lightbox\" data-title=\"sample 5 - black\">\n                    <img src=\"https://via.placeholder.com/300/000000?text=5\" class=\"img-fluid mb-2\" alt=\"black sample\">\n                    </a>\n                </div>\n                <div class=\"filtr-item col-sm-2\" data-category=\"1\" data-sort=\"white sample\">\n                    <a href=\"https://via.placeholder.com/1200/FFFFFF.png?text=6\" data-toggle=\"lightbox\" data-title=\"sample 6 - white\">\n                    <img src=\"https://via.placeholder.com/300/FFFFFF?text=6\" class=\"img-fluid mb-2\" alt=\"white sample\">\n                    </a>\n                </div>\n                <div class=\"filtr-item col-sm-2\" data-category=\"1\" data-sort=\"white sample\">\n                    <a href=\"https://via.placeholder.com/1200/FFFFFF.png?text=7\" data-toggle=\"lightbox\" data-title=\"sample 7 - white\">\n                    <img src=\"https://via.placeholder.com/300/FFFFFF?text=7\" class=\"img-fluid mb-2\" alt=\"white sample\">\n                    </a>\n                </div>\n                <div class=\"filtr-item col-sm-2\" data-category=\"2, 4\" data-sort=\"black sample\">\n                    <a href=\"https://via.placeholder.com/1200/000000.png?text=8\" data-toggle=\"lightbox\" data-title=\"sample 8 - black\">\n                    <img src=\"https://via.placeholder.com/300/000000?text=8\" class=\"img-fluid mb-2\" alt=\"black sample\">\n                    </a>\n                </div>\n                <div class=\"filtr-item col-sm-2\" data-category=\"3, 4\" data-sort=\"red sample\">\n                    <a href=\"https://via.placeholder.com/1200/FF0000/FFFFFF.png?text=9\" data-toggle=\"lightbox\" data-title=\"sample 9 - red\">\n                    <img src=\"https://via.placeholder.com/300/FF0000/FFFFFF?text=9\" class=\"img-fluid mb-2\" alt=\"red sample\">\n                    </a>\n                </div>\n                <div class=\"filtr-item col-sm-2\" data-category=\"1\" data-sort=\"white sample\">\n                    <a href=\"https://via.placeholder.com/1200/FFFFFF.png?text=10\" data-toggle=\"lightbox\" data-title=\"sample 10 - white\">\n                    <img src=\"https://via.placeholder.com/300/FFFFFF?text=10\" class=\"img-fluid mb-2\" alt=\"white sample\">\n                    </a>\n                </div>\n                <div class=\"filtr-item col-sm-2\" data-category=\"1\" data-sort=\"white sample\">\n                    <a href=\"https://via.placeholder.com/1200/FFFFFF.png?text=11\" data-toggle=\"lightbox\" data-title=\"sample 11 - white\">\n                    <img src=\"https://via.placeholder.com/300/FFFFFF?text=11\" class=\"img-fluid mb-2\" alt=\"white sample\">\n                    </a>\n                </div>\n                <div class=\"filtr-item col-sm-2\" data-category=\"2, 4\" data-sort=\"black sample\">\n                    <a href=\"https://via.placeholder.com/1200/000000.png?text=12\" data-toggle=\"lightbox\" data-title=\"sample 12 - black\">\n                    <img src=\"https://via.placeholder.com/300/000000?text=12\" class=\"img-fluid mb-2\" alt=\"black sample\">\n                    </a>\n                </div>\n                </div>\n            </div>\n\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\n        ");
            __builder.AddMarkupContent(52, "<div class=\"col-12\">\n        <div class=\"card card-primary\">\n            <div class=\"card-header\">\n            <div class=\"card-title\">\n                Ekko Lightbox\n            </div>\n            </div>\n            <div class=\"card-body\">\n            <div class=\"row\">\n                <div class=\"col-sm-2\">\n                <a href=\"https://via.placeholder.com/1200/FFFFFF.png?text=1\" data-toggle=\"lightbox\" data-title=\"sample 1 - white\" data-gallery=\"gallery\">\n                    <img src=\"https://via.placeholder.com/300/FFFFFF?text=1\" class=\"img-fluid mb-2\" alt=\"white sample\">\n                </a>\n                </div>\n                <div class=\"col-sm-2\">\n                <a href=\"https://via.placeholder.com/1200/000000.png?text=2\" data-toggle=\"lightbox\" data-title=\"sample 2 - black\" data-gallery=\"gallery\">\n                    <img src=\"https://via.placeholder.com/300/000000?text=2\" class=\"img-fluid mb-2\" alt=\"black sample\">\n                </a>\n                </div>\n                <div class=\"col-sm-2\">\n                <a href=\"https://via.placeholder.com/1200/FF0000/FFFFFF.png?text=3\" data-toggle=\"lightbox\" data-title=\"sample 3 - red\" data-gallery=\"gallery\">\n                    <img src=\"https://via.placeholder.com/300/FF0000/FFFFFF?text=3\" class=\"img-fluid mb-2\" alt=\"red sample\">\n                </a>\n                </div>\n                <div class=\"col-sm-2\">\n                <a href=\"https://via.placeholder.com/1200/FF0000/FFFFFF.png?text=4\" data-toggle=\"lightbox\" data-title=\"sample 4 - red\" data-gallery=\"gallery\">\n                    <img src=\"https://via.placeholder.com/300/FF0000/FFFFFF?text=4\" class=\"img-fluid mb-2\" alt=\"red sample\">\n                </a>\n                </div>\n                <div class=\"col-sm-2\">\n                <a href=\"https://via.placeholder.com/1200/000000.png?text=5\" data-toggle=\"lightbox\" data-title=\"sample 5 - black\" data-gallery=\"gallery\">\n                    <img src=\"https://via.placeholder.com/300/000000?text=5\" class=\"img-fluid mb-2\" alt=\"black sample\">\n                </a>\n                </div>\n                <div class=\"col-sm-2\">\n                <a href=\"https://via.placeholder.com/1200/FFFFFF.png?text=6\" data-toggle=\"lightbox\" data-title=\"sample 6 - white\" data-gallery=\"gallery\">\n                    <img src=\"https://via.placeholder.com/300/FFFFFF?text=6\" class=\"img-fluid mb-2\" alt=\"white sample\">\n                </a>\n                </div>\n                <div class=\"col-sm-2\">\n                <a href=\"https://via.placeholder.com/1200/FFFFFF.png?text=7\" data-toggle=\"lightbox\" data-title=\"sample 7 - white\" data-gallery=\"gallery\">\n                    <img src=\"https://via.placeholder.com/300/FFFFFF?text=7\" class=\"img-fluid mb-2\" alt=\"white sample\">\n                </a>\n                </div>\n                <div class=\"col-sm-2\">\n                <a href=\"https://via.placeholder.com/1200/000000.png?text=8\" data-toggle=\"lightbox\" data-title=\"sample 8 - black\" data-gallery=\"gallery\">\n                    <img src=\"https://via.placeholder.com/300/000000?text=8\" class=\"img-fluid mb-2\" alt=\"black sample\">\n                </a>\n                </div>\n                <div class=\"col-sm-2\">\n                <a href=\"https://via.placeholder.com/1200/FF0000/FFFFFF.png?text=9\" data-toggle=\"lightbox\" data-title=\"sample 9 - red\" data-gallery=\"gallery\">\n                    <img src=\"https://via.placeholder.com/300/FF0000/FFFFFF?text=9\" class=\"img-fluid mb-2\" alt=\"red sample\">\n                </a>\n                </div>\n                <div class=\"col-sm-2\">\n                <a href=\"https://via.placeholder.com/1200/FFFFFF.png?text=10\" data-toggle=\"lightbox\" data-title=\"sample 10 - white\" data-gallery=\"gallery\">\n                    <img src=\"https://via.placeholder.com/300/FFFFFF?text=10\" class=\"img-fluid mb-2\" alt=\"white sample\">\n                </a>\n                </div>\n                <div class=\"col-sm-2\">\n                <a href=\"https://via.placeholder.com/1200/FFFFFF.png?text=11\" data-toggle=\"lightbox\" data-title=\"sample 11 - white\" data-gallery=\"gallery\">\n                    <img src=\"https://via.placeholder.com/300/FFFFFF?text=11\" class=\"img-fluid mb-2\" alt=\"white sample\">\n                </a>\n                </div>\n                <div class=\"col-sm-2\">\n                <a href=\"https://via.placeholder.com/1200/000000.png?text=12\" data-toggle=\"lightbox\" data-title=\"sample 12 - black\" data-gallery=\"gallery\">\n                    <img src=\"https://via.placeholder.com/300/000000?text=12\" class=\"img-fluid mb-2\" alt=\"black sample\">\n                </a>\n                </div>\n            </div>\n            </div>\n        </div>\n        </div>\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 208 "/data/CrossPlatformWork/OpenNetLink/src/OpenNetLinkApp/Pages/Exam/Gallery.razor"
 
    public async Task LoadJavaScript()
    {
        await JSRuntime.InvokeVoidAsync("loadJavaScript");
        await JSRuntime.InvokeVoidAsync("loadExamGallery");
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
