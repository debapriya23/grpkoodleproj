#pragma checksum "C:\Users\dsp\Desktop\New folder (7)\FinalProjectKoodle\KoodleProject\KoodleProject\Views\Home\about.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c70ee49d96795207cb9a7585ea4855f3005bdb4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_about), @"mvc.1.0.view", @"/Views/Home/about.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/about.cshtml", typeof(AspNetCore.Views_Home_about))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c70ee49d96795207cb9a7585ea4855f3005bdb4", @"/Views/Home/about.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"905d0d685ff31f1eb6c0abbfb793838606aa9c2e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_about : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\dsp\Desktop\New folder (7)\FinalProjectKoodle\KoodleProject\KoodleProject\Views\Home\about.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
            BeginContext(43, 5678, true);
            WriteLiteral(@"

<style>
    body {
        font-family: 'Roboto';
        font-size: 16px;
    }

    .aboutus-section {
        padding: 90px 0;
    }

    .aboutus-title {
        font-size: 30px;
        letter-spacing: 0;
        line-height: 32px;
        margin: 0 0 39px;
        padding: 0 0 11px;
        position: relative;
        text-transform: uppercase;
        color: #000;
    }

        .aboutus-title::after {
            background: #fdb801 none repeat scroll 0 0;
            bottom: 0;
            content: """";
            height: 2px;
            left: 0;
            position: absolute;
            width: 54px;
        }

    .aboutus-text {
        color: #606060;
        font-size: 13px;
        line-height: 22px;
        margin: 0 0 35px;
    }

    a:hover, a:active {
        color: #ffb901;
        text-decoration: none;
        outline: 0;
    }

    .aboutus-more {
        border: 1px solid #fdb801;
        border-radius: 25px;
        color: #fdb801;");
            WriteLiteral(@"
        display: inline-block;
        font-size: 14px;
        font-weight: 700;
        letter-spacing: 0;
        padding: 7px 20px;
        text-transform: uppercase;
    }

    .feature .feature-box .iconset {
        background: #fff none repeat scroll 0 0;
        float: left;
        position: relative;
        width: 18%;
    }

        .feature .feature-box .iconset::after {
            background: #fdb801 none repeat scroll 0 0;
            content: """";
            height: 150%;
            left: 43%;
            position: absolute;
            top: 100%;
            width: 1px;
        }

    .feature .feature-box .feature-content h4 {
        color: #0f0f0f;
        font-size: 18px;
        letter-spacing: 0;
        line-height: 22px;
        margin: 0 0 5px;
    }


    .feature .feature-box .feature-content {
        float: left;
        padding-left: 28px;
        width: 78%;
    }

        .feature .feature-box .feature-content h4 {
            colo");
            WriteLiteral(@"r: #0f0f0f;
            font-size: 18px;
            letter-spacing: 0;
            line-height: 22px;
            margin: 0 0 5px;
        }

        .feature .feature-box .feature-content p {
            color: #606060;
            font-size: 13px;
            line-height: 22px;
        }

    .icon {
        color: #f4b841;
        padding: 0px;
        font-size: 40px;
        border: 1px solid #fdb801;
        border-radius: 100px;
        color: #fdb801;
        font-size: 28px;
        height: 70px;
        line-height: 70px;
        text-align: center;
        width: 70px;
    }
</style>


<link href='https://fonts.googleapis.com/css?family=Roboto' rel='stylesheet'>

<div class=""aboutus-section"" style=""background-color:lavender;"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-3 col-sm-6 col-xs-12"">
                <div class=""aboutus"">
                    <h2 class=""aboutus-title"">About Us</h2>
                    <p class=""ab");
            WriteLiteral(@"outus-text"">
                        Koodle is an online community for showcasing user-created HTML, CSS, Java, and other
                        technical code snippets.
                    </p>
                    <p class=""aboutus-text"">
                        ‘A dumb question that you ask because you are too lazy to find the answer
                        yourself.’
                    </p>

                </div>
            </div>
            <div class=""col-md-3 col-sm-6 col-xs-12"">
                <div class=""aboutus-banner"">
                    <img src=""http://themeinnovation.com/demo2/html/build-up/img/home1/about1.jpg"" alt="""">
                </div>
            </div>
            <div class=""col-md-5 col-sm-6 col-xs-12"">
                <div class=""feature"">
                    <div class=""feature-box"">
                        <div class=""clearfix"">
                            <div class=""iconset"">
                                <span class=""glyphicon glyphicon-cog icon""></s");
            WriteLiteral(@"pan>
                            </div>
                            <div class=""feature-content"">
                                <h4>Work with heart</h4>
                                <p>share your work with th community</p>
                            </div>
                        </div>
                    </div>
                    <div class=""feature-box"">
                        <div class=""clearfix"">
                            <div class=""iconset"">
                                <span class=""glyphicon glyphicon-cog icon""></span>
                            </div>
                            <div class=""feature-content"">
                                <h4>Reliable services</h4>
                                <p>to showcase your creations and to interact with the IT community</p>
                            </div>
                        </div>
                    </div>
                    <div class=""feature-box"">
                        <div class=""clearfix"">
              ");
            WriteLiteral(@"              <div class=""iconset"">
                                <span class=""glyphicon glyphicon-cog icon""></span>
                            </div>
                            <div class=""feature-content"">
                                <h4>Great support</h4>
                                <p>User can follow each other and view each others content and can comment</p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
