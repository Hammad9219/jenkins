#pragma checksum "D:\WebApplication1\Views\Event\MyEvents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08ade2f2c849d664dbed2bf224975790e1e983eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_MyEvents), @"mvc.1.0.view", @"/Views/Event/MyEvents.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08ade2f2c849d664dbed2bf224975790e1e983eb", @"/Views/Event/MyEvents.cshtml")]
    public class Views_Event_MyEvents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication1.Models.EventModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\WebApplication1\Views\Event\MyEvents.cshtml"
  
    ViewData["Title"] = "MyEvents";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""container-fluid"">
    <table class=""table table-bordered table-responsive table-hover"">
        <thead>
            <tr class=""warning"">
                <th>Event Title</th>
                <th>Event Date</th>
                <th>Event Start Time</th>
                <th>Event Duration</th>
                <th>Description</th>
                <th>Details</th>
                <th>Edit</th>
            </tr>
        </thead>

");
#nullable restore
#line 22 "D:\WebApplication1\Views\Event\MyEvents.cshtml"
         foreach (var i in Model)
        {
            if (i.Email == null)
            {
                continue;
            }
            else
            {
                foreach (var invite in Model)
                {
                    if (invite.Email == User.Identity.Name)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr class=\"info\">\r\n\r\n                            <td>");
#nullable restore
#line 36 "D:\WebApplication1\Views\Event\MyEvents.cshtml"
                           Write(Html.ActionLink(i.Title, "GetEventByTitle", new { title = i.Title }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            <td>");
#nullable restore
#line 37 "D:\WebApplication1\Views\Event\MyEvents.cshtml"
                           Write(i.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 38 "D:\WebApplication1\Views\Event\MyEvents.cshtml"
                           Write(i.Starttime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 39 "D:\WebApplication1\Views\Event\MyEvents.cshtml"
                           Write(i.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 40 "D:\WebApplication1\Views\Event\MyEvents.cshtml"
                           Write(i.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 41 "D:\WebApplication1\Views\Event\MyEvents.cshtml"
                           Write(i.Details);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 42 "D:\WebApplication1\Views\Event\MyEvents.cshtml"
                           Write(Html.ActionLink("Edit", "Edit", new { title = i.Title }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 44 "D:\WebApplication1\Views\Event\MyEvents.cshtml"
                    }
                }
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>\r\n\r\n</div>\r\n<style>\r\n    .table, th, tr {\r\n        margin-top: 20px;\r\n        width: 15in;\r\n        border: 2px solid pink;\r\n    }\r\n</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication1.Models.EventModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591