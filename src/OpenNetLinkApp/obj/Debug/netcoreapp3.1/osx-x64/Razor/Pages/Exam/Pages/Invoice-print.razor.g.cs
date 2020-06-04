#pragma checksum "/Volumes/Macintosh HD2/CrossPlatformWork/DesktopApp/BlazorAdminLTE_side/BlazorAdminLTE/Pages/Exam/Pages/Invoice-print.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a88dccf6d47ed7e7736f077009bf5389604a8c31"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorDesktopApp.Pages.Exam.Pages
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
#line 3 "/Volumes/Macintosh HD2/CrossPlatformWork/DesktopApp/BlazorAdminLTE_side/BlazorAdminLTE/Pages/Exam/Pages/Invoice-print.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Exam/Pages/invoice-print")]
    public partial class Invoice_print : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<section class=\"invoice\">\n\n<div class=\"row\">\n    <div class=\"col-12\">\n    <h2 class=\"page-header\">\n        <i class=\"fas fa-globe\"></i> AdminLTE, Inc.\n        <small class=\"float-right\">Date: 2/10/2014</small>\n    </h2>\n    </div>\n    \n</div>\n\n<div class=\"row invoice-info\">\n    <div class=\"col-sm-4 invoice-col\">\n    From\n    <address>\n        <strong>Admin, Inc.</strong><br>\n        795 Folsom Ave, Suite 600<br>\n        San Francisco, CA 94107<br>\n        Phone: (804) 123-5432<br>\n        Email: info@almasaeedstudio.com\n    </address>\n    </div>\n    \n    <div class=\"col-sm-4 invoice-col\">\n    To\n    <address>\n        <strong>John Doe</strong><br>\n        795 Folsom Ave, Suite 600<br>\n        San Francisco, CA 94107<br>\n        Phone: (555) 539-1037<br>\n        Email: john.doe@example.com\n    </address>\n    </div>\n    \n    <div class=\"col-sm-4 invoice-col\">\n    <b>Invoice #007612</b><br>\n    <br>\n    <b>Order ID:</b> 4F3S8J<br>\n    <b>Payment Due:</b> 2/22/2014<br>\n    <b>Account:</b> 968-34567\n    </div>\n    \n</div>\n\n\n\n<div class=\"row\">\n    <div class=\"col-12 table-responsive\">\n    <table class=\"table table-striped\">\n        <thead>\n        <tr>\n        <th>Qty</th>\n        <th>Product</th>\n        <th>Serial #</th>\n        <th>Description</th>\n        <th>Subtotal</th>\n        </tr>\n        </thead>\n        <tbody>\n        <tr>\n        <td>1</td>\n        <td>Call of Duty</td>\n        <td>455-981-221</td>\n        <td>El snort testosterone trophy driving gloves handsome</td>\n        <td>$64.50</td>\n        </tr>\n        <tr>\n        <td>1</td>\n        <td>Need for Speed IV</td>\n        <td>247-925-726</td>\n        <td>Wes Anderson umami biodiesel</td>\n        <td>$50.00</td>\n        </tr>\n        <tr>\n        <td>1</td>\n        <td>Monsters DVD</td>\n        <td>735-845-642</td>\n        <td>Terry Richardson helvetica tousled street art master</td>\n        <td>$10.70</td>\n        </tr>\n        <tr>\n        <td>1</td>\n        <td>Grown Ups Blue Ray</td>\n        <td>422-568-642</td>\n        <td>Tousled lomo letterpress</td>\n        <td>$25.99</td>\n        </tr>\n        </tbody>\n    </table>\n    </div>\n    \n</div>\n\n\n<div class=\"row\">\n    \n    <div class=\"col-6\">\n    <p class=\"lead\">Payment Methods:</p>\n    <img src=\"images/adminlte/credit/visa.png\" alt=\"Visa\">\n    <img src=\"images/adminlte/credit/mastercard.png\" alt=\"Mastercard\">\n    <img src=\"images/adminlte/credit/american-express.png\" alt=\"American Express\">\n    <img src=\"images/adminlte/credit/paypal2.png\" alt=\"Paypal\">\n\n    <p class=\"text-muted well well-sm shadow-none\" style=\"margin-top: 10px;\">\n        Etsy doostang zoodles disqus groupon greplin oooj voxy zoodles, weebly ning heekya handango imeem plugg dopplr\n        jibjab, movity jajah plickers sifteo edmodo ifttt zimbra.\n    </p>\n    </div>\n    \n    <div class=\"col-6\">\n    <p class=\"lead\">Amount Due 2/22/2014</p>\n\n    <div class=\"table-responsive\">\n        <table class=\"table\">\n        <tr>\n            <th style=\"width:50%\">Subtotal:</th>\n            <td>$250.30</td>\n        </tr>\n        <tr>\n            <th>Tax (9.3%)</th>\n            <td>$10.34</td>\n        </tr>\n        <tr>\n            <th>Shipping:</th>\n            <td>$5.80</td>\n        </tr>\n        <tr>\n            <th>Total:</th>\n            <td>$265.24</td>\n        </tr>\n        </table>\n    </div>\n    </div>\n    \n</div>\n\n</section>");
        }
        #pragma warning restore 1998
#nullable restore
#line 148 "/Volumes/Macintosh HD2/CrossPlatformWork/DesktopApp/BlazorAdminLTE_side/BlazorAdminLTE/Pages/Exam/Pages/Invoice-print.razor"
 
    public async Task LoadJavaScript()
    {
        //await JSRuntime.InvokeVoidAsync("loadJavaScript");
        //await JSRuntime.InvokeVoidAsync("loadPagePrint");
        await JSRuntime.InvokeAsync<string>("print");
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
