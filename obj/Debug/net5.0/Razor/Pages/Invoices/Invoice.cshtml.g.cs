#pragma checksum "C:\Users\hmarcia\source\repos\DEV\2021\Hema\Hema-SparkAutoShop\Pages\Invoices\Invoice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "387d4b5d2975cc4eae9e8084e7f4c3758fd98571"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SparkAuto.Pages.Invoices.Pages_Invoices_Invoice), @"mvc.1.0.razor-page", @"/Pages/Invoices/Invoice.cshtml")]
namespace SparkAuto.Pages.Invoices
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
#line 1 "C:\Users\hmarcia\source\repos\DEV\2021\Hema\Hema-SparkAutoShop\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hmarcia\source\repos\DEV\2021\Hema\Hema-SparkAutoShop\Pages\_ViewImports.cshtml"
using SparkAuto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hmarcia\source\repos\DEV\2021\Hema\Hema-SparkAutoShop\Pages\_ViewImports.cshtml"
using SparkAuto.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hmarcia\source\repos\DEV\2021\Hema\Hema-SparkAutoShop\Pages\_ViewImports.cshtml"
using SparkAuto.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"387d4b5d2975cc4eae9e8084e7f4c3758fd98571", @"/Pages/Invoices/Invoice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4d69de3f1e1300da7fddf4fe637537dd02ad215", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Invoices_Invoice : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/theme.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/logo.webp"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100%; max-width:300px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\hmarcia\source\repos\DEV\2021\Hema\Hema-SparkAutoShop\Pages\Invoices\Invoice.cshtml"
  
    Layout = null;
    ViewData["Title"] = "Invoice";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "387d4b5d2975cc4eae9e8084e7f4c3758fd985716567", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "387d4b5d2975cc4eae9e8084e7f4c3758fd985717686", async() => {
                WriteLiteral(@"
    <style>
        #invoice{
            max-width: 800px;
            margin: auto;
            padding: 16px;
            border: 1px solid #eee;
            box-shadow: 0 0 10px rgba(0, 0, 0, .15);
            font-size: 16px;
            line-height: 24px;
            font-family: 'Helvetica Neue', 'Helvetica', Helvetica, Arial, sans-serif;
            color: #555;
        }

        .invoice-container{
            border: 1px solid #ccc;
            padding: 32px;
        }
        
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<div class=""d-flex justify-content-center py-4"">
    <button type=""button"" id=""btnprintpdf"" class=""btn btn-dark rounded-pill"">Imprimir Factura</button>
</div>
<div id=""invoice"" class=""bg-white"">
    <div class=""invoice-container"">
        <div class=""row"">
            <div class=""col"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "387d4b5d2975cc4eae9e8084e7f4c3758fd985719504", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col\">\r\n                <p class=\"m-0 text-right\"> ");
#nullable restore
#line 41 "C:\Users\hmarcia\source\repos\DEV\2021\Hema\Hema-SparkAutoShop\Pages\Invoices\Invoice.cshtml"
                                       Write(Model.serviceHeader.DateAdded.ToString("dddd, dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                <p class=\"m-0 text-right\"> Order Id: <b>#");
#nullable restore
#line 42 "C:\Users\hmarcia\source\repos\DEV\2021\Hema\Hema-SparkAutoShop\Pages\Invoices\Invoice.cshtml"
                                                     Write(Model.serviceHeader.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> </p>\r\n                <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 1383, "\"", 1414, 1);
#nullable restore
#line 43 "C:\Users\hmarcia\source\repos\DEV\2021\Hema\Hema-SparkAutoShop\Pages\Invoices\Invoice.cshtml"
WriteAttributeValue("", 1391, Model.serviceHeader.Id, 1391, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" id=""orderid"">
            </div>
        </div>
        
        <table class=""my-4"">
            <tr>
                <td><b>221, Westney Road South Ajax ON L1S 2C9</b></td>
            </tr>
            <tr>
                <td>Telephone: (289) 600-6524</td>
            </tr>
        </table>
        <table class=""table table-bordered table-sm"">
            <tr>
                <th colspan=""2"">Vehicle Information</th>
            </tr>
            <tr>
                <th>Year:</th>
                <td>");
#nullable restore
#line 61 "C:\Users\hmarcia\source\repos\DEV\2021\Hema\Hema-SparkAutoShop\Pages\Invoices\Invoice.cshtml"
               Write(Model.serviceHeader.Car.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Make:</th>\r\n                <td>");
#nullable restore
#line 65 "C:\Users\hmarcia\source\repos\DEV\2021\Hema\Hema-SparkAutoShop\Pages\Invoices\Invoice.cshtml"
               Write(Model.serviceHeader.Car.Make);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Model:</th>\r\n                <td>");
#nullable restore
#line 69 "C:\Users\hmarcia\source\repos\DEV\2021\Hema\Hema-SparkAutoShop\Pages\Invoices\Invoice.cshtml"
               Write(Model.serviceHeader.Car.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Plate:</th>\r\n                <td>");
#nullable restore
#line 73 "C:\Users\hmarcia\source\repos\DEV\2021\Hema\Hema-SparkAutoShop\Pages\Invoices\Invoice.cshtml"
               Write(Model.serviceHeader.Car.VIN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Odometer:</th>\r\n                <td>");
#nullable restore
#line 77 "C:\Users\hmarcia\source\repos\DEV\2021\Hema\Hema-SparkAutoShop\Pages\Invoices\Invoice.cshtml"
               Write(Model.serviceHeader.Car.Miles);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (miles)</td>\r\n            </tr>\r\n        </table>\r\n\r\n        <table class=\"table table-bordered table-sm mt-4\">\r\n            <tr>\r\n                <th colspan=\"2\">Work Information</th>\r\n            </tr>\r\n\r\n");
#nullable restore
#line 86 "C:\Users\hmarcia\source\repos\DEV\2021\Hema\Hema-SparkAutoShop\Pages\Invoices\Invoice.cshtml"
             foreach (var service in Model.serviceDetails)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 89 "C:\Users\hmarcia\source\repos\DEV\2021\Hema\Hema-SparkAutoShop\Pages\Invoices\Invoice.cshtml"
                   Write(service.ServiceName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 90 "C:\Users\hmarcia\source\repos\DEV\2021\Hema\Hema-SparkAutoShop\Pages\Invoices\Invoice.cshtml"
                    Write(String.Format("${0:0.00}",service.ServicePrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 92 "C:\Users\hmarcia\source\repos\DEV\2021\Hema\Hema-SparkAutoShop\Pages\Invoices\Invoice.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            \r\n            <tr>\r\n                <td>Sub-Total:</td>\r\n                <th>");
#nullable restore
#line 97 "C:\Users\hmarcia\source\repos\DEV\2021\Hema\Hema-SparkAutoShop\Pages\Invoices\Invoice.cshtml"
                Write(String.Format("${0:0.00}",Model.serviceHeader.TotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            </tr>\r\n            <tr>\r\n                <td>Taxes:</td>\r\n                <th>");
#nullable restore
#line 101 "C:\Users\hmarcia\source\repos\DEV\2021\Hema\Hema-SparkAutoShop\Pages\Invoices\Invoice.cshtml"
                Write(String.Format("${0:0.00}",Model.serviceHeader.Tax));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            </tr>\r\n            <tr>\r\n                <td>Env Charge:</td>\r\n                <th>");
#nullable restore
#line 105 "C:\Users\hmarcia\source\repos\DEV\2021\Hema\Hema-SparkAutoShop\Pages\Invoices\Invoice.cshtml"
                Write(String.Format("${0:0.00}",2.99));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            </tr>\r\n            <tr class=\"bg-success-soft\">\r\n                <td>Full Price:</td>\r\n                <th>");
#nullable restore
#line 109 "C:\Users\hmarcia\source\repos\DEV\2021\Hema\Hema-SparkAutoShop\Pages\Invoices\Invoice.cshtml"
                Write(String.Format("${0:0.00}",Model.serviceHeader.FullPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            </tr>\r\n\r\n        </table>\r\n\r\n        <p class=\"mt-5\">Tank you for shopping by today. We look forward to seeing you again</p>\r\n        \r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "387d4b5d2975cc4eae9e8084e7f4c3758fd9857117249", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script src=""https://cdnjs.cloudflare.com/ajax/libs/html2pdf.js/0.9.2/html2pdf.bundle.js""></script>
<script type=""text/javascript"">
    $(""#btnprintpdf"").on(""click"",function(){
        const factura = document.getElementById(""invoice"");
        var opt = {
            margin: 0,
            image: { type: 'jpeg', quality: 1 },
            html2canvas:  { scale: 2 },
            jsPDF: { unit: 'in', format: 'letter', orientation: 'portrait' },
            filename: 'invoice-' + $(""#orderid"").val() + "".pdf""
        };
        html2pdf().set(opt).from(factura).save();
    });
</script>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "387d4b5d2975cc4eae9e8084e7f4c3758fd9857119006", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "387d4b5d2975cc4eae9e8084e7f4c3758fd9857120187", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SparkAuto.Pages.Services.InvoiceModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SparkAuto.Pages.Services.InvoiceModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SparkAuto.Pages.Services.InvoiceModel>)PageContext?.ViewData;
        public SparkAuto.Pages.Services.InvoiceModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
