#pragma checksum "D:\UploadAndDown\UploadAndDown\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb7d34ce79046fc205eceea29ae5dee53b9ed6b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "D:\UploadAndDown\UploadAndDown\Views\_ViewImports.cshtml"
using WalkingTec.Mvvm.TagHelpers.LayUI;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb7d34ce79046fc205eceea29ae5dee53b9ed6b9", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb6fecd289e437acbee50f7e1040b7eeb0a429e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UploadAndDown.ViewModels.HomeVMs.IndexVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\UploadAndDown\UploadAndDown\Views\Home\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(77, 86, true);
            WriteLiteral("\n<div class=\"layui-layout layui-layout-admin\">\n    <div class=\"layui-header\">\n        ");
            EndContext();
            BeginContext(164, 40, false);
#line 8 "D:\UploadAndDown\UploadAndDown\Views\Home\Index.cshtml"
   Write(await Html.PartialAsync("Header", Model));

#line default
#line hidden
            EndContext();
            BeginContext(204, 65, true);
            WriteLiteral("\n    </div>\n\n    <div class=\"layui-side layui-bg-black\">\n        ");
            EndContext();
            BeginContext(270, 38, false);
#line 12 "D:\UploadAndDown\UploadAndDown\Views\Home\Index.cshtml"
   Write(await Html.PartialAsync("Menu", Model));

#line default
#line hidden
            EndContext();
            BeginContext(308, 181, true);
            WriteLiteral("\n    </div>\n\n    <div class=\"layui-body\" id=\"DONOTUSE_MAINPANEL\">\n        <!-- 内容主体区域 -->\n    </div>\n\n    <div class=\"layui-footer\">\n        Powered by WalkingTec\n    </div>\n</div>\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UploadAndDown.ViewModels.HomeVMs.IndexVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
