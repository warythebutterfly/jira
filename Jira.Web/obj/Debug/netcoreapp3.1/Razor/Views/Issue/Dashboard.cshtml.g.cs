#pragma checksum "C:\Users\user\source\repos\Jira\Jira.Web\Views\Issue\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbde3c7b331b1f3f1bdbb5ee56d2dd69b4a90a03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Issue_Dashboard), @"mvc.1.0.view", @"/Views/Issue/Dashboard.cshtml")]
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
#line 1 "C:\Users\user\source\repos\Jira\Jira.Web\Views\_ViewImports.cshtml"
using Jira.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\source\repos\Jira\Jira.Web\Views\_ViewImports.cshtml"
using Jira.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbde3c7b331b1f3f1bdbb5ee56d2dd69b4a90a03", @"/Views/Issue/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"669142c728258dbab86a4119a11e7724db581e0f", @"/Views/_ViewImports.cshtml")]
    public class Views_Issue_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/xs/avatar1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Avatar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("avatar sm  rounded-circle me-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/xs/avatar2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("avatar sm rounded-circle me-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/xs/avatar4.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/xs/avatar5.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/xs/avatar6.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/xs/avatar7.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""container-xxl"">
    <div class=""row g-3 mb-3 row-deck"">
        <div class=""col-md-12 col-lg-4 col-xl-4 col-xxl-4"">
            <div class=""card "">
                <div class=""card-body"">
                    <div class=""d-flex align-items-center"">
                        <div class=""avatar lg  rounded-1 no-thumbnail bg-lightyellow color-defult""><i class=""bi bi-journal-check fs-4""></i></div>
                        <div class=""flex-fill ms-4"">
                            <div");
            BeginWriteAttribute("class", " class=\"", 499, "\"", 507, 0);
            EndWriteAttribute();
            WriteLiteral(@">Total Task</div>
                            <h5 class=""mb-0 "">122</h5>
                        </div>
                        <a href=""task.html"" title=""view-members"" class=""btn btn-link text-decoration-none  rounded-1""><i class=""icofont-hand-drawn-right fs-2 ""></i></a>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-md-12 col-lg-4 col-xl-4 col-xxl-4"">
            <div class=""card "">
                <div class=""card-body"">
                    <div class=""d-flex align-items-center"">
                        <div class=""avatar lg  rounded-1 no-thumbnail bg-lightblue color-defult""><i class=""bi bi-list-check fs-4""></i></div>
                        <div class=""flex-fill ms-4"">
                            <div");
            BeginWriteAttribute("class", " class=\"", 1297, "\"", 1305, 0);
            EndWriteAttribute();
            WriteLiteral(@">Completed Task</div>
                            <h5 class=""mb-0 "">376</h5>
                        </div>
                        <a href=""task.html"" title=""space-used"" class=""btn btn-link text-decoration-none  rounded-1""><i class=""icofont-hand-drawn-right fs-2 ""></i></a>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-md-12 col-lg-4 col-xl-4 col-xxl-4"">
            <div class=""card "">
                <div class=""card-body"">
                    <div class=""d-flex align-items-center"">
                        <div class=""avatar lg  rounded-1 no-thumbnail bg-lightgreen color-defult""><i class=""bi bi-clipboard-data fs-4""></i></div>
                        <div class=""flex-fill ms-4"">
                            <div");
            BeginWriteAttribute("class", " class=\"", 2102, "\"", 2110, 0);
            EndWriteAttribute();
            WriteLiteral(@">Progress Task</div>
                            <h5 class=""mb-0 "">74</h5>
                        </div>
                        <a href=""task.html"" title=""renewal-date"" class=""btn btn-link text-decoration-none  rounded-1""><i class=""icofont-hand-drawn-right fs-2 ""></i></a>
                    </div>
                </div>
            </div>
        </div>
    </div><!-- Row End -->
    <div class=""row g-3 mb-3 row-deck"">
        <div class=""col-md-12 col-lg-8 col-xl-7 col-xxl-7"">
            <div class=""card"">
                <div class=""card-body"">
                    <div class=""row align-items-center"">
                        <div class=""col-12 col-md-5 col-lg-6 order-md-2 "">
                            <div class=""text-center p-4"">
                                <img src=""assets/images/task-view.svg"" alt=""..."" class=""img-fluid"">
                            </div>
                        </div>
                        <div class=""col-12 col-md-7 col-lg-6 order-md-1 px-4"">
            ");
            WriteLiteral(@"                <h3 class=""fw-bold "">Dylan Hunter</h3>
                            <p class=""line-height-custom"">Welcome back Dylan Hunter.Integer molestie, arcu non porta sollicitudin, arcu felis aliquam urna, placerat maximus lorem urna commodo sem. Pellentesque venenatis leo quam, sed mattis sapien lobortis ut.placerat maximus lorem urna commodo sem</p>
                            <a class=""btn bg-secondary text-light btn-lg lift"" href=""http://pixelwibes.com/"" target=""_blank"">Free Inquire</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-md-12 col-lg-4 col-xl-5 col-xxl-5"">
            <div class=""alert alert-primary p-3 mb-0 w-100"">
                <h6 class=""fw-bold mb-1"">Create Project Credentials</h6>
                <p class=""small mb-4"">Create a Project credentials now and never miss</p>
                <div class=""my-3 "">
                    <input type=""text"" class=""form-control form-control-lg""");
            WriteLiteral(@" placeholder=""Enter Username"">
                </div>
                <div class=""my-3"">
                    <input type=""password"" class=""form-control form-control-lg"" placeholder=""Enter Password"">
                </div>
                <div class=""my-3"">
                    <input type=""password"" class=""form-control form-control-lg"" placeholder=""Confirm Password"">
                </div>
                <button class=""btn btn-primary mt-2"">Create Credentials</button>
            </div>
        </div>
    </div><!-- Row End -->
    <div class=""row g-3 mb-3 row-deck"">
        <div class=""col-md-12 col-lg-4"">
            <div class=""card"">
                <div class=""card-body"">
                    <h6 class=""mb-3 fw-bold "">Income Analytics</h6>
                    <div class=""d-flex justify-content-end text-center"">
                        <div class=""p-2"">
                            <h6 class=""mb-0 fw-bold"">$5,318</h6>
                            <small class=""text-muted"">Income</small>
");
            WriteLiteral(@"                        </div>
                        <div class=""p-2 ms-4"">
                            <h6 class=""mb-0 fw-bold"">$2,840</h6>
                            <small class=""text-muted"">Expense</small>
                        </div>
                    </div>
                    <div class=""mt-3"" id=""incomeanalytics""></div>
                </div>
            </div>
        </div>
        <div class=""col-md-12 col-lg-8"">
            <div class=""card"">
                <div class=""card-header py-3 d-flex justify-content-between align-items-center"">
                    <div class=""info-header"">
                        <h6 class=""mb-0 fw-bold "">Project Timeline</h6>
                    </div>
                    <button class=""btn btn-sm btn-link  dropdown-toggle"" type=""button"" data-bs-toggle=""dropdown"" aria-expanded=""false""></button>
                    <ul class=""dropdown-menu border-0 shadow dropdown-menu-end"">
                        <li><a class=""dropdown-item py-2 rounded"" href=""");
            WriteLiteral(@"#"">Last 7 days</a></li>
                        <li><a class=""dropdown-item py-2 rounded"" href=""#"">Last 30 days</a></li>
                        <li><a class=""dropdown-item py-2 rounded"" href=""#"">Last 60 days</a></li>
                    </ul>
                </div>
                <div class=""card-body"">
                    <div id=""apex-timeline""></div>
                </div>
            </div>
        </div>
    </div><!-- Row End -->
    <div class=""row g-3 mb-3 row-cols-1 row-cols-sm-2 row-cols-md-2 row-cols-lg-2 row-cols-xl-4 row-cols-xxl-4"">
        <div class=""col"">
            <div class=""card bg-primary"">
                <div class=""card-body text-white d-flex align-items-center"">
                    <i class=""icofont-data fs-3""></i>
                    <div class=""d-flex flex-column ms-3"">
                        <h6 class=""mb-0"">Total Projects</h6>
                        <span class=""text-white"">550</span>
                    </div>
                </div>
            </div>
");
            WriteLiteral(@"        </div>
        <div class=""col"">
            <div class=""card bg-primary"">
                <div class=""card-body text-white d-flex align-items-center"">
                    <i class=""icofont-chart-flow fs-3""></i>
                    <div class=""d-flex flex-column ms-3"">
                        <h6 class=""mb-0"">Coming Projects</h6>
                        <span class=""text-white"">210</span>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col"">
            <div class=""card bg-primary"">
                <div class=""card-body text-white d-flex align-items-center"">
                    <i class=""icofont-chart-flow-2 fs-3""></i>
                    <div class=""d-flex flex-column ms-3"">
                        <h6 class=""mb-0"">Progress Projects</h6>
                        <span class=""text-white"">8456 Files</span>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col"">
          ");
            WriteLiteral(@"  <div class=""card bg-primary"">
                <div class=""card-body text-white d-flex align-items-center"">
                    <i class=""icofont-tasks fs-3""></i>
                    <div class=""d-flex flex-column ms-3"">
                        <h6 class=""mb-0"">Finished Projects</h6>
                        <span class=""text-white"">88 Files</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""row g-3 mb-3 row-deck"">
        <div class=""col-md-12"">
            <div class=""card mb-3"">
                <div class=""card-header py-3 d-flex justify-content-between align-items-center"">
                    <div class=""info-header"">
                        <h6 class=""mb-0 fw-bold "">Project Information</h6>
                    </div>
                </div>
                <div class=""card-body"">
                    <table id=""myProjectTable"" class=""table table-hover align-middle mb-0"" style=""width:100%"">
                        <thead");
            WriteLiteral(@">
                            <tr>
                                <th>Title</th>
                                <th>Date Start</th>
                                <th>Deadline</th>
                                <th>Leader</th>
                                <th>Completion</th>
                                <th>Stage</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td><a href=""projects.html"">Social Geek Made</a></td>
                                <td>10-01-2021</td>
                                <td>4 Month</td>
                                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fbde3c7b331b1f3f1bdbb5ee56d2dd69b4a90a0317247", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"<a href=""#"">Keith</a></td>
                                <td>
                                    <div class=""progress"">
                                        <div class=""progress-bar bg-primary"" role=""progressbar"" aria-valuenow=""92"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 78%;"">78%</div>
                                    </div>
                                </td>
                                <td><span class=""badge bg-warning"">MEDIUM</span></td>
                            </tr>
                            <tr>
                                <td><a href=""projects.html"">Practice to Perfect</a></td>
                                <td>12-02-2021</td>
                                <td>1 Month</td>
                                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fbde3c7b331b1f3f1bdbb5ee56d2dd69b4a90a0319240", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"<a href=""#"">Colin</a></td>
                                <td>
                                    <div class=""progress"">
                                        <div class=""progress-bar  bg-primary"" role=""progressbar"" aria-valuenow=""80"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 80%;"">80%</div>
                                    </div>
                                </td>
                                <td><span class=""badge bg-success"">LOW</span></td>
                            </tr>
                            <tr>
                                <td><a href=""projects.html"">Rhinestone</a></td>
                                <td>18-02-2021</td>
                                <td>2 Month</td>
                                <td><img src=""assets/images/xs/avatar3.jpg"" alt=""Avatar"" class=""avatar sm rounded-circle me-2""><a href=""#"">Adam</a></td>
                                <td>
                                    <div class=""progress"">
                                        <");
            WriteLiteral(@"div class=""progress-bar  bg-primary"" role=""progressbar"" aria-valuenow=""90"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 90%;"">90%</div>
                                    </div>
                                </td>
                                <td><span class=""badge bg-danger"">HIGH</span></td>
                            </tr>
                            <tr>
                                <td><a href=""projects.html"">Box of Crayons</a></td>
                                <td>23-02-2021</td>
                                <td>1 Month</td>
                                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fbde3c7b331b1f3f1bdbb5ee56d2dd69b4a90a0322141", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"<a href=""#"">Peter</a></td>
                                <td>
                                    <div class=""progress"">
                                        <div class=""progress-bar  bg-primary"" role=""progressbar"" aria-valuenow=""85"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 85%;"">85%</div>
                                    </div>
                                </td>
                                <td><span class=""badge bg-warning"">MEDIUM</span></td>
                            </tr>
                            <tr>
                                <td><a href=""projects.html"">Gob Geeklords</a></td>
                                <td>16-03-2021</td>
                                <td>10 Month</td>
                                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fbde3c7b331b1f3f1bdbb5ee56d2dd69b4a90a0324130", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"<a href=""#"">Evan</a></td>
                                <td>
                                    <div class=""progress"">
                                        <div class=""progress-bar  bg-primary"" role=""progressbar"" aria-valuenow=""65"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 65%;"">65%</div>
                                    </div>
                                </td>
                                <td><span class=""badge bg-success"">LOW</span></td>
                            </tr>
                            <tr>
                                <td><a href=""projects.html"">Java Dalia</a></td>
                                <td>17-03-2021</td>
                                <td>8 Month</td>
                                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fbde3c7b331b1f3f1bdbb5ee56d2dd69b4a90a0326111", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"<a href=""#"">Connor</a></td>
                                <td>
                                    <div class=""progress"">
                                        <div class=""progress-bar  bg-primary"" role=""progressbar"" aria-valuenow=""48"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 48%;"">48%</div>
                                    </div>
                                </td>
                                <td><span class=""badge bg-secondary"">MEDIUM</span></td>
                            </tr>
                            <tr>
                                <td><a href=""projects.html"">Fast Cad</a></td>
                                <td>14-04-2021</td>
                                <td>2 Month</td>
                                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fbde3c7b331b1f3f1bdbb5ee56d2dd69b4a90a0328097", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"<a href=""#"">Benjamin</a></td>
                                <td>
                                    <div class=""progress"">
                                        <div class=""progress-bar  bg-primary"" role=""progressbar"" aria-valuenow=""76"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 76%;"">76%</div>
                                    </div>
                                </td>
                                <td><span class=""badge bg-secondary"">MEDIUM</span></td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div><!-- Row End -->
</div>
");
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
