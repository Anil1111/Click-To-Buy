#pragma checksum "F:\C# Project\Web Application - CORE\Click-To-Buy\ClickToBuy\ClickToBuy\Views\Purchase\GetPurchaseItemByPurchaseId.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de31cfdaad22d5dd8f055c4c0db6aeb4141ab3c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Purchase_GetPurchaseItemByPurchaseId), @"mvc.1.0.view", @"/Views/Purchase/GetPurchaseItemByPurchaseId.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "F:\C# Project\Web Application - CORE\Click-To-Buy\ClickToBuy\ClickToBuy\Views\_ViewImports.cshtml"
using ClickToBuy;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\C# Project\Web Application - CORE\Click-To-Buy\ClickToBuy\ClickToBuy\Views\_ViewImports.cshtml"
using ClickToBuy.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "F:\C# Project\Web Application - CORE\Click-To-Buy\ClickToBuy\ClickToBuy\Views\Purchase\GetPurchaseItemByPurchaseId.cshtml"
using ClickToBuy.Model;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de31cfdaad22d5dd8f055c4c0db6aeb4141ab3c6", @"/Views/Purchase/GetPurchaseItemByPurchaseId.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58182b6284b770ec652d8b2f171e7aefd040d64f", @"/Views/_ViewImports.cshtml")]
    public class Views_Purchase_GetPurchaseItemByPurchaseId : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PurchaseItem>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "F:\C# Project\Web Application - CORE\Click-To-Buy\ClickToBuy\ClickToBuy\Views\Purchase\GetPurchaseItemByPurchaseId.cshtml"
  
    ViewData["Title"] = "GetPurchaseItemByPurchaseId";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2 id=""hadertitle"">Purchase Item Details</h2>
<hr />

<div class=""row"" id=""datatables"">
    <div class=""col-md-8"">
        <table id=""myTable"" class=""display table table-bordered table-striped"">
            <thead>
                <tr>
                    <th>Product Name</th>
                    <th>Quantity</th>
                    <th>Price</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 23 "F:\C# Project\Web Application - CORE\Click-To-Buy\ClickToBuy\ClickToBuy\Views\Purchase\GetPurchaseItemByPurchaseId.cshtml"
                 foreach (PurchaseItem item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 26 "F:\C# Project\Web Application - CORE\Click-To-Buy\ClickToBuy\ClickToBuy\Views\Purchase\GetPurchaseItemByPurchaseId.cshtml"
                       Write(item.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 27 "F:\C# Project\Web Application - CORE\Click-To-Buy\ClickToBuy\ClickToBuy\Views\Purchase\GetPurchaseItemByPurchaseId.cshtml"
                       Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 28 "F:\C# Project\Web Application - CORE\Click-To-Buy\ClickToBuy\ClickToBuy\Views\Purchase\GetPurchaseItemByPurchaseId.cshtml"
                       Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 30 "F:\C# Project\Web Application - CORE\Click-To-Buy\ClickToBuy\ClickToBuy\Views\Purchase\GetPurchaseItemByPurchaseId.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PurchaseItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
