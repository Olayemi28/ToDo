#pragma checksum "C:\Users\user\Documents\Projects\UniqueTodoApplication\Views\Admin\IndexAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31ec8a5dfe6d3517566de51545417a823f3867c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_IndexAdmin), @"mvc.1.0.view", @"/Views/Admin/IndexAdmin.cshtml")]
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
#line 1 "C:\Users\user\Documents\Projects\UniqueTodoApplication\Views\_ViewImports.cshtml"
using UniqueTodoApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Documents\Projects\UniqueTodoApplication\Views\_ViewImports.cshtml"
using UniqueTodoApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31ec8a5dfe6d3517566de51545417a823f3867c0", @"/Views/Admin/IndexAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbc906072d35e660dc94564fd89f8acaaf88f3bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_IndexAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\user\Documents\Projects\UniqueTodoApplication\Views\Admin\IndexAdmin.cshtml"
  
    Layout = "_AdminDashboardLayout";

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\user\Documents\Projects\UniqueTodoApplication\Views\Admin\IndexAdmin.cshtml"
 if(!string.IsNullOrEmpty(@TempData["success"].ToString())){

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>alert(\"");
#nullable restore
#line 5 "C:\Users\user\Documents\Projects\UniqueTodoApplication\Views\Admin\IndexAdmin.cshtml"
          Write(TempData["success"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\");</script>\r\n");
#nullable restore
#line 6 "C:\Users\user\Documents\Projects\UniqueTodoApplication\Views\Admin\IndexAdmin.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(")");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
