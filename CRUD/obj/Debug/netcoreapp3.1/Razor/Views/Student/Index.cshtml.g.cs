#pragma checksum "D:\.Net Core\New folder\CRUD\CRUD\Views\Student\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ce333506d84623b8e513c4841e2d1f895e3fe21"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Index), @"mvc.1.0.view", @"/Views/Student/Index.cshtml")]
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
#line 1 "D:\.Net Core\New folder\CRUD\CRUD\Views\_ViewImports.cshtml"
using CRUD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.Net Core\New folder\CRUD\CRUD\Views\_ViewImports.cshtml"
using CRUD.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ce333506d84623b8e513c4841e2d1f895e3fe21", @"/Views/Student/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"813d028d5e7480ef09b6d196de8cd6b00c3ad294", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Student_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CRUD.Models.StudentViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Student", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddUpdateStudent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\.Net Core\New folder\CRUD\CRUD\Views\Student\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Student Add/ Update</h1>\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-6\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ce333506d84623b8e513c4841e2d1f895e3fe214737", async() => {
                WriteLiteral("\r\n                ");
#nullable restore
#line 10 "D:\.Net Core\New folder\CRUD\CRUD\Views\Student\Index.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                <input type=""hidden"" id=""StudentId"" name=""StudentId"" />

                <div class=""row md-3"">
                    <div class=""col-12""><label for=""FullName""> Student Name </label></div>
                    <div class=""col-12""><input type=""text"" class=""form-control"" name=""FullName"" id=""FullName"" placeholder=""Enter Name"" /></div>
                </div>

                <div class=""row md-3"">
                    <div class=""col-12""><label for=""EmailAddress""> Email Address </label></div>
                    <div class=""col-12""><input type=""text"" class=""form-control"" name=""EmailAddress"" id=""EmailAddress"" placeholder=""Enter Email Address"" /></div>
                </div>

                <div class=""row md-3"">
                    <div class=""col-12""><label for=""City""> City </label></div>
                    <div class=""col-12""><input type=""text"" class=""form-control"" name=""City"" id=""City"" placeholder=""Enter City"" /></div>
                </div>
                <br />
              ");
                WriteLiteral("  <div class=\"row md-3\">\r\n                    <div class=\"col-12\">\r\n                        <button type=\"submit\" class=\"btn btn-success\">Submit</button>\r\n                    </div>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-6\">\r\n");
#nullable restore
#line 36 "D:\.Net Core\New folder\CRUD\CRUD\Views\Student\Index.cshtml"
              
                if (TempData["SuccessMsg"] != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h2 class=\"bg-success\">");
#nullable restore
#line 39 "D:\.Net Core\New folder\CRUD\CRUD\Views\Student\Index.cshtml"
                                      Write(TempData["SuccessMsg"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 40 "D:\.Net Core\New folder\CRUD\CRUD\Views\Student\Index.cshtml"
                }
                if (TempData["ErrorMsg"] != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h2 class=\"bg-danger\">");
#nullable restore
#line 43 "D:\.Net Core\New folder\CRUD\CRUD\Views\Student\Index.cshtml"
                                     Write(TempData["ErrorMsg"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 44 "D:\.Net Core\New folder\CRUD\CRUD\Views\Student\Index.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>

    </div>
</div>
<h1>Student List</h1>
<div class=""container"">
    <table class=""table table-bordered"">
        <tr>
            <th>Student Id</th>
            <th>Student Name</th>
            <th>Email Address</th>
            <th>City</th>
            <th>Date</th>
            <th>Action</th>
        </tr>
");
#nullable restore
#line 61 "D:\.Net Core\New folder\CRUD\CRUD\Views\Student\Index.cshtml"
          
            if (Model.StudentsList != null && Model.StudentsList.Count > 0)
            {
                foreach (var item in Model.StudentsList)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 67 "D:\.Net Core\New folder\CRUD\CRUD\Views\Student\Index.cshtml"
                       Write(item.StudentId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 68 "D:\.Net Core\New folder\CRUD\CRUD\Views\Student\Index.cshtml"
                       Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 69 "D:\.Net Core\New folder\CRUD\CRUD\Views\Student\Index.cshtml"
                       Write(item.EmailAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 70 "D:\.Net Core\New folder\CRUD\CRUD\Views\Student\Index.cshtml"
                       Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 71 "D:\.Net Core\New folder\CRUD\CRUD\Views\Student\Index.cshtml"
                       Write(item.CreationDate.ToString("dd-MMM-yyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            <a");
            BeginWriteAttribute("onclick", " onclick=\"", 2867, "\"", 2915, 3);
            WriteAttributeValue("", 2877, "DeleteStudentRecord(\'", 2877, 21, true);
#nullable restore
#line 73 "D:\.Net Core\New folder\CRUD\CRUD\Views\Student\Index.cshtml"
WriteAttributeValue("", 2898, item.StudentId, 2898, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2913, "\')", 2913, 2, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"cursor: pointer;\">Delete</a>&nbsp;&nbsp;&nbsp;\r\n                            <a");
            BeginWriteAttribute("onclick", " onclick=\"", 3002, "\"", 3101, 9);
            WriteAttributeValue("", 3012, "UpdateStudentRecord(\'", 3012, 21, true);
#nullable restore
#line 74 "D:\.Net Core\New folder\CRUD\CRUD\Views\Student\Index.cshtml"
WriteAttributeValue("", 3033, item.StudentId, 3033, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3048, "\',\'", 3048, 3, true);
#nullable restore
#line 74 "D:\.Net Core\New folder\CRUD\CRUD\Views\Student\Index.cshtml"
WriteAttributeValue("", 3051, item.FullName, 3051, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3065, "\',\'", 3065, 3, true);
#nullable restore
#line 74 "D:\.Net Core\New folder\CRUD\CRUD\Views\Student\Index.cshtml"
WriteAttributeValue("", 3068, item.EmailAddress, 3068, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3086, "\',\'", 3086, 3, true);
#nullable restore
#line 74 "D:\.Net Core\New folder\CRUD\CRUD\Views\Student\Index.cshtml"
WriteAttributeValue("", 3089, item.City, 3089, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3099, "\')", 3099, 2, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"cursor: pointer;\">Edit</a>&nbsp;&nbsp;&nbsp;\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 77 "D:\.Net Core\New folder\CRUD\CRUD\Views\Student\Index.cshtml"
                }
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </table>
</div>

<script type=""text/javascript"">
     function DeleteStudentRecord(StudentId)
     {
         let response = confirm(""Do you want to Delete this record"");
         if(response){
             $.ajax({
              type:""POST"",
              url:'");
#nullable restore
#line 90 "D:\.Net Core\New folder\CRUD\CRUD\Views\Student\Index.cshtml"
              Write(Url.Action("DeleteStudent","Student"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
              data:{StudentId:StudentId},
              success:function(response){
                  if(response.message==""Delete Sucessfully""){
                      window.location.reload();
                  }
                  else{
                      alert(response.message)
                  }
              },
              complete:function(){ },
              failure: function(jqXHR, textStatus,errorThrown) {
                alert(""Error Pcured ! Please try again"");
              }
             });
         }
     }

    function UpdateStudentRecord(StudentId,FullName,EmailAddress,City)
    {
        $('#StudentId').val(StudentId);
        $('#FullName').val(FullName);
        $('#EmailAddress').val(EmailAddress);
        $('#City').val(City);
    }


</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CRUD.Models.StudentViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591