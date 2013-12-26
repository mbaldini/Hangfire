﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HangFire.Web.Pages
{
    
    #line 2 "..\..\Pages\EnqueuedJobsPage.cshtml"
    using System;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Pages\EnqueuedJobsPage.cshtml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Pages\EnqueuedJobsPage.cshtml"
    using System.Linq;
    
    #line default
    #line hidden
    using System.Text;
    
    #line 5 "..\..\Pages\EnqueuedJobsPage.cshtml"
    using Common;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Pages\EnqueuedJobsPage.cshtml"
    using Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class EnqueuedJobsPage : RazorPage
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");








            
            #line 8 "..\..\Pages\EnqueuedJobsPage.cshtml"
  
    Layout = new LayoutPage
        {
            Title = Queue.ToUpperInvariant(), 
            Subtitle = "Enqueued jobs",
            Breadcrumbs = new Dictionary<string, string>
                {
                    { "Queues", Request.LinkTo("/queues") }
                }
        };

    int from, perPage;

    int.TryParse(Request.QueryString["from"], out from);
    int.TryParse(Request.QueryString["count"], out perPage);

    var pager = new Pager(from, perPage, JobStorage.EnqueuedCount(Queue))
    {
        BasePageUrl = Request.LinkTo("/queues/" + Queue)
    };

    var enqueuedJobs = JobStorage.EnqueuedJobs(Queue, pager.FromRecord, pager.RecordsPerPage);


            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 32 "..\..\Pages\EnqueuedJobsPage.cshtml"
 if (pager.TotalPageCount == 0)
{

            
            #line default
            #line hidden
WriteLiteral("    <div class=\"alert alert-info\">\r\n        The queue is empty.\r\n    </div>\r\n");


            
            #line 37 "..\..\Pages\EnqueuedJobsPage.cshtml"
}
else
{
    
            
            #line default
            #line hidden
            
            #line 40 "..\..\Pages\EnqueuedJobsPage.cshtml"
Write(RenderPartial(new PerPageSelector(pager)));

            
            #line default
            #line hidden
            
            #line 40 "..\..\Pages\EnqueuedJobsPage.cshtml"
                                              
    

            
            #line default
            #line hidden
WriteLiteral("    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th" +
">Id</th>\r\n                <th>Job type</th>\r\n                <th>Enqueued</th>\r\n" +
"            </tr>\r\n        </thead>\r\n        <tbody>\r\n");


            
            #line 51 "..\..\Pages\EnqueuedJobsPage.cshtml"
             foreach (var job in enqueuedJobs)
            {

            
            #line default
            #line hidden
WriteLiteral("                <tr class=\"");


            
            #line 53 "..\..\Pages\EnqueuedJobsPage.cshtml"
                       Write(!job.Value.InEnqueuedState ? "obsolete-data" : null);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                    <td>\r\n                        <a href=\"");


            
            #line 55 "..\..\Pages\EnqueuedJobsPage.cshtml"
                            Write(Request.LinkTo("/job/" + job.Key));

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 55 "..\..\Pages\EnqueuedJobsPage.cshtml"
                                                                Write(HtmlHelper.JobId(job.Key));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");


            
            #line 56 "..\..\Pages\EnqueuedJobsPage.cshtml"
                         if (!job.Value.InEnqueuedState)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <span title=\"Job\'s state has been changed while fetch" +
"ing data.\" class=\"glyphicon glyphicon-question-sign\"></span>\r\n");


            
            #line 59 "..\..\Pages\EnqueuedJobsPage.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </td> \r\n                    <td>");


            
            #line 61 "..\..\Pages\EnqueuedJobsPage.cshtml"
                   Write(HtmlHelper.JobType(job.Value.Method));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                    <td>\r\n");


            
            #line 63 "..\..\Pages\EnqueuedJobsPage.cshtml"
                         if (job.Value.EnqueuedAt.HasValue)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <span data-moment=\"");


            
            #line 65 "..\..\Pages\EnqueuedJobsPage.cshtml"
                                          Write(JobHelper.ToStringTimestamp(job.Value.EnqueuedAt.Value));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                                ");


            
            #line 66 "..\..\Pages\EnqueuedJobsPage.cshtml"
                           Write(job.Value.EnqueuedAt);

            
            #line default
            #line hidden
WriteLiteral("        \r\n                            </span>\r\n");


            
            #line 68 "..\..\Pages\EnqueuedJobsPage.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </td>\r\n                </tr>\r\n");


            
            #line 71 "..\..\Pages\EnqueuedJobsPage.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </tbody>\r\n    </table>\r\n");


            
            #line 74 "..\..\Pages\EnqueuedJobsPage.cshtml"
    
    
            
            #line default
            #line hidden
            
            #line 75 "..\..\Pages\EnqueuedJobsPage.cshtml"
Write(RenderPartial(new Paginator(pager)));

            
            #line default
            #line hidden
            
            #line 75 "..\..\Pages\EnqueuedJobsPage.cshtml"
                                        
}
            
            #line default
            #line hidden

        }
    }
}
#pragma warning restore 1591
