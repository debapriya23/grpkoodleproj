#pragma checksum "C:\Users\dsp\Desktop\New folder (7)\FinalProjectKoodle\KoodleProject\KoodleProject\Views\Shared\Templates\_Follow.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c4178e72bf930a1bbf53e90e6941172461156bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Templates__Follow), @"mvc.1.0.view", @"/Views/Shared/Templates/_Follow.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Templates/_Follow.cshtml", typeof(AspNetCore.Views_Shared_Templates__Follow))]
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
#line 1 "C:\Users\dsp\Desktop\New folder (7)\FinalProjectKoodle\KoodleProject\KoodleProject\Views\_ViewImports.cshtml"
using Core.Domain.Posts;

#line default
#line hidden
#line 2 "C:\Users\dsp\Desktop\New folder (7)\FinalProjectKoodle\KoodleProject\KoodleProject\Views\_ViewImports.cshtml"
using Core.Domain.Notifications;

#line default
#line hidden
#line 3 "C:\Users\dsp\Desktop\New folder (7)\FinalProjectKoodle\KoodleProject\KoodleProject\Views\_ViewImports.cshtml"
using Services.Users;

#line default
#line hidden
#line 4 "C:\Users\dsp\Desktop\New folder (7)\FinalProjectKoodle\KoodleProject\KoodleProject\Views\_ViewImports.cshtml"
using Services.Follows;

#line default
#line hidden
#line 5 "C:\Users\dsp\Desktop\New folder (7)\FinalProjectKoodle\KoodleProject\KoodleProject\Views\_ViewImports.cshtml"
using Services.Posts;

#line default
#line hidden
#line 6 "C:\Users\dsp\Desktop\New folder (7)\FinalProjectKoodle\KoodleProject\KoodleProject\Views\_ViewImports.cshtml"
using Core.Domain.Follows;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c4178e72bf930a1bbf53e90e6941172461156bf", @"/Views/Shared/Templates/_Follow.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"905d0d685ff31f1eb6c0abbfb793838606aa9c2e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Templates__Follow : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Core.Domain.Users.User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(107, 139, true);
            WriteLiteral("<div class=\"col-lg-3 col-md-6 col-sm-6\">\r\n    <div class=\"box\">\r\n        <div class=\"box__header-bg\">\r\n            <img class=\"box__bg-img\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 246, "\"", 283, 1);
#line 7 "C:\Users\dsp\Desktop\New folder (7)\FinalProjectKoodle\KoodleProject\KoodleProject\Views\Shared\Templates\_Follow.cshtml"
WriteAttributeValue("", 252, Model.GetProfileCoverPicture(), 252, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(284, 64, true);
            WriteLiteral("/>\r\n            <div class=\"box__profile-min\">\r\n                ");
            EndContext();
            BeginContext(348, 196, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96dcfdb2bf1143db86fc74bdab9288b2", async() => {
                BeginContext(434, 26, true);
                WriteLiteral("\r\n                    <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 460, "\"", 492, 1);
#line 10 "C:\Users\dsp\Desktop\New folder (7)\FinalProjectKoodle\KoodleProject\KoodleProject\Views\Shared\Templates\_Follow.cshtml"
WriteAttributeValue("", 466, Model.GetProfilePicture(), 466, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(493, 47, true);
                WriteLiteral(" class=\"box__profile-img\"/>\r\n\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-username", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 9 "C:\Users\dsp\Desktop\New folder (7)\FinalProjectKoodle\KoodleProject\KoodleProject\Views\Shared\Templates\_Follow.cshtml"
                                                                         WriteLiteral(Model.UserName);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["username"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-username", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["username"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(544, 224, true);
            WriteLiteral("\r\n                \r\n                </div>\r\n        </div>\r\n        <div class=\"box__content\">\r\n          \r\n            <div class=\"box__profile-content\">\r\n                <h2 class=\"box__profile-name\">\r\n                    ");
            EndContext();
            BeginContext(768, 131, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35dc0f4ab4fd41c6a5b2e9c65d38aba2", async() => {
                BeginContext(854, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(881, 14, false);
#line 21 "C:\Users\dsp\Desktop\New folder (7)\FinalProjectKoodle\KoodleProject\KoodleProject\Views\Shared\Templates\_Follow.cshtml"
                   Write(Model.FullName);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-username", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 20 "C:\Users\dsp\Desktop\New folder (7)\FinalProjectKoodle\KoodleProject\KoodleProject\Views\Shared\Templates\_Follow.cshtml"
                                                                             WriteLiteral(Model.UserName);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["username"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-username", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["username"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(899, 85, true);
            WriteLiteral("\r\n                </h2>\r\n                <span class=\"text-muted box__profile-other\">");
            EndContext();
            BeginContext(985, 1, true);
            WriteLiteral("@");
            EndContext();
            BeginContext(987, 14, false);
#line 23 "C:\Users\dsp\Desktop\New folder (7)\FinalProjectKoodle\KoodleProject\KoodleProject\Views\Shared\Templates\_Follow.cshtml"
                                                         Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(1001, 280, true);
            WriteLiteral(@"</span>
            </div>
        </div>
        <div class=""box__footer"">
            <div class=""d-flex text-center justify-content-around"">
                <div class=""p-4 box__stat"">
                    <span class=""text-uppercase"">Posts</span>
                    <p>");
            EndContext();
            BeginContext(1282, 50, false);
#line 30 "C:\Users\dsp\Desktop\New folder (7)\FinalProjectKoodle\KoodleProject\KoodleProject\Views\Shared\Templates\_Follow.cshtml"
                  Write(await PostService.GetUserTotalPostsAsync(Model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1332, 165, true);
            WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"p-4 box__stat\">\r\n                    <span class=\"text-uppercase\">Followers</span>\r\n                    <p>");
            EndContext();
            BeginContext(1498, 56, false);
#line 34 "C:\Users\dsp\Desktop\New folder (7)\FinalProjectKoodle\KoodleProject\KoodleProject\Views\Shared\Templates\_Follow.cshtml"
                  Write(await FollowService.GetUserTotalFollowersAsync(Model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1554, 165, true);
            WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"p-4 box__stat\">\r\n                    <span class=\"text-uppercase\">Following</span>\r\n                    <p>");
            EndContext();
            BeginContext(1720, 56, false);
#line 38 "C:\Users\dsp\Desktop\New folder (7)\FinalProjectKoodle\KoodleProject\KoodleProject\Views\Shared\Templates\_Follow.cshtml"
                  Write(await FollowService.GetUserTotalFolloweesAsync(Model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1776, 108, true);
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IFollowService FollowService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IPostService PostService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Core.Domain.Users.User> Html { get; private set; }
    }
}
#pragma warning restore 1591