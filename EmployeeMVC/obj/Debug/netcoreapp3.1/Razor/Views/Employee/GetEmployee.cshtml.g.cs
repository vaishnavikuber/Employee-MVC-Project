#pragma checksum "C:\Users\vaish\source\repos\EmployeeMVC\EmployeeMVC\Views\Employee\GetEmployee.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "73c5e89b67b4bde58879600a5246e4194c422434e284c53929b625ba1eecf8f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Views_Employee_GetEmployee), @"mvc.1.0.view", @"/Views/Employee/GetEmployee.cshtml")]
namespace AspNetCoreGeneratedDocument
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\vaish\source\repos\EmployeeMVC\EmployeeMVC\Views\_ViewImports.cshtml"
using EmployeeMVC

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\vaish\source\repos\EmployeeMVC\EmployeeMVC\Views\_ViewImports.cshtml"
using EmployeeMVC.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"73c5e89b67b4bde58879600a5246e4194c422434e284c53929b625ba1eecf8f4", @"/Views/Employee/GetEmployee.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"f5f22c87f5b1f650cada8ba1b584659ea882b8b59b60b640e2eb8df230e23927", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Views_Employee_GetEmployee : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 1 "C:\Users\vaish\source\repos\EmployeeMVC\EmployeeMVC\Views\Employee\GetEmployee.cshtml"
       IEnumerable<CommonLayer.Models.EmployeeModel>

#line default
#line hidden
#nullable disable
    >
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\vaish\source\repos\EmployeeMVC\EmployeeMVC\Views\Employee\GetEmployee.cshtml"
  
    ViewData["Title"] = "GetEmployee";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<h1>GetEmployee</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73c5e89b67b4bde58879600a5246e4194c422434e284c53929b625ba1eecf8f44118", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            Write(
#nullable restore
#line 16 "C:\Users\vaish\source\repos\EmployeeMVC\EmployeeMVC\Views\Employee\GetEmployee.cshtml"
                 Html.DisplayNameFor(model => model.EmployeeId)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            Write(
#nullable restore
#line 19 "C:\Users\vaish\source\repos\EmployeeMVC\EmployeeMVC\Views\Employee\GetEmployee.cshtml"
                 Html.DisplayNameFor(model => model.EmployeeName)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            Write(
#nullable restore
#line 22 "C:\Users\vaish\source\repos\EmployeeMVC\EmployeeMVC\Views\Employee\GetEmployee.cshtml"
                 Html.DisplayNameFor(model => model.Email)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            Write(
#nullable restore
#line 25 "C:\Users\vaish\source\repos\EmployeeMVC\EmployeeMVC\Views\Employee\GetEmployee.cshtml"
                 Html.DisplayNameFor(model => model.Age)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            Write(
#nullable restore
#line 28 "C:\Users\vaish\source\repos\EmployeeMVC\EmployeeMVC\Views\Employee\GetEmployee.cshtml"
                 Html.DisplayNameFor(model => model.Salary)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            Write(
#nullable restore
#line 31 "C:\Users\vaish\source\repos\EmployeeMVC\EmployeeMVC\Views\Employee\GetEmployee.cshtml"
                 Html.DisplayNameFor(model => model.City)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            Write(
#nullable restore
#line 34 "C:\Users\vaish\source\repos\EmployeeMVC\EmployeeMVC\Views\Employee\GetEmployee.cshtml"
                 Html.DisplayNameFor(model => model.Department)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            Write(
#nullable restore
#line 37 "C:\Users\vaish\source\repos\EmployeeMVC\EmployeeMVC\Views\Employee\GetEmployee.cshtml"
                 Html.DisplayNameFor(model => model.Gender)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 43 "C:\Users\vaish\source\repos\EmployeeMVC\EmployeeMVC\Views\Employee\GetEmployee.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable

            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            Write(
#nullable restore
#line 46 "C:\Users\vaish\source\repos\EmployeeMVC\EmployeeMVC\Views\Employee\GetEmployee.cshtml"
                 Html.DisplayFor(modelItem => item.EmployeeId)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            Write(
#nullable restore
#line 49 "C:\Users\vaish\source\repos\EmployeeMVC\EmployeeMVC\Views\Employee\GetEmployee.cshtml"
                 Html.DisplayFor(modelItem => item.EmployeeName)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            Write(
#nullable restore
#line 52 "C:\Users\vaish\source\repos\EmployeeMVC\EmployeeMVC\Views\Employee\GetEmployee.cshtml"
                 Html.DisplayFor(modelItem => item.Email)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            Write(
#nullable restore
#line 55 "C:\Users\vaish\source\repos\EmployeeMVC\EmployeeMVC\Views\Employee\GetEmployee.cshtml"
                 Html.DisplayFor(modelItem => item.Age)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            Write(
#nullable restore
#line 58 "C:\Users\vaish\source\repos\EmployeeMVC\EmployeeMVC\Views\Employee\GetEmployee.cshtml"
                 Html.DisplayFor(modelItem => item.Salary)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            Write(
#nullable restore
#line 61 "C:\Users\vaish\source\repos\EmployeeMVC\EmployeeMVC\Views\Employee\GetEmployee.cshtml"
                 Html.DisplayFor(modelItem => item.City)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            Write(
#nullable restore
#line 64 "C:\Users\vaish\source\repos\EmployeeMVC\EmployeeMVC\Views\Employee\GetEmployee.cshtml"
                 Html.DisplayFor(modelItem => item.Department)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            Write(
#nullable restore
#line 67 "C:\Users\vaish\source\repos\EmployeeMVC\EmployeeMVC\Views\Employee\GetEmployee.cshtml"
                 Html.DisplayFor(modelItem => item.Gender)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            Write(
#nullable restore
#line 70 "C:\Users\vaish\source\repos\EmployeeMVC\EmployeeMVC\Views\Employee\GetEmployee.cshtml"
                 Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" |\r\n                ");
            Write(
#nullable restore
#line 71 "C:\Users\vaish\source\repos\EmployeeMVC\EmployeeMVC\Views\Employee\GetEmployee.cshtml"
                 Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" |\r\n                ");
            Write(
#nullable restore
#line 72 "C:\Users\vaish\source\repos\EmployeeMVC\EmployeeMVC\Views\Employee\GetEmployee.cshtml"
                 Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 75 "C:\Users\vaish\source\repos\EmployeeMVC\EmployeeMVC\Views\Employee\GetEmployee.cshtml"
}

#line default
#line hidden
#nullable disable

            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CommonLayer.Models.EmployeeModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
