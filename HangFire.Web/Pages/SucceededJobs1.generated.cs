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
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    #line 2 "..\..\Pages\SucceededJobs.cshtml"
    using Common;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Pages\SucceededJobs.cshtml"
    using Common.States;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Pages\SucceededJobs.cshtml"
    using HangFire.Storage;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Pages\SucceededJobs.cshtml"
    using Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class SucceededJobs : RazorPage
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");







            
            #line 7 "..\..\Pages\SucceededJobs.cshtml"
  
    Layout = new LayoutPage { Title = "Succeeded Jobs" };

    int from, perPage;

    int.TryParse(Request.QueryString["from"], out from);
    int.TryParse(Request.QueryString["count"], out perPage);

    var pager = new Pager(from, perPage, JobStorage.Current.Monitoring.SucceededListCount())
    {
        BasePageUrl = Request.LinkTo("/succeeded")
    };

    var succeededJobs = JobStorage.Current.Monitoring
        .SucceededJobs(pager.FromRecord, pager.RecordsPerPage);


            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 24 "..\..\Pages\SucceededJobs.cshtml"
 if (pager.TotalPageCount == 0)
{

            
            #line default
            #line hidden
WriteLiteral("    <div class=\"alert alert-info\">\r\n        No succeeded jobs found.\r\n    </div>\r" +
"\n");


            
            #line 29 "..\..\Pages\SucceededJobs.cshtml"
}
else
{
    
            
            #line default
            #line hidden
            
            #line 32 "..\..\Pages\SucceededJobs.cshtml"
Write(RenderPartial(new PerPageSelector(pager)));

            
            #line default
            #line hidden
            
            #line 32 "..\..\Pages\SucceededJobs.cshtml"
                                              
    

            
            #line default
            #line hidden
WriteLiteral("    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th" +
">Id</th>\r\n                <th>Job type</th>\r\n                <th>Succeeded</th>\r" +
"\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");


            
            #line 43 "..\..\Pages\SucceededJobs.cshtml"
             foreach (var job in succeededJobs)
            {

            
            #line default
            #line hidden
WriteLiteral("                <tr class=\"");


            
            #line 45 "..\..\Pages\SucceededJobs.cshtml"
                       Write(job.Value != null && !job.Value.InSucceededState ? "obsolete-data" : null);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                    <td>\r\n                        <a href=\"");


            
            #line 47 "..\..\Pages\SucceededJobs.cshtml"
                            Write(Request.LinkTo("/job/" + job.Key));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                            ");


            
            #line 48 "..\..\Pages\SucceededJobs.cshtml"
                       Write(HtmlHelper.JobId(job.Key));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </a>\r\n");


            
            #line 50 "..\..\Pages\SucceededJobs.cshtml"
                         if (job.Value != null && !job.Value.InSucceededState)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <span title=\"Job\'s state has been changed while fetch" +
"ing data.\" class=\"glyphicon glyphicon-question-sign\"></span>\r\n");


            
            #line 53 "..\..\Pages\SucceededJobs.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </td>\r\n\r\n");


            
            #line 56 "..\..\Pages\SucceededJobs.cshtml"
                     if (job.Value == null)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <td colspan=\"3\"><em>Job was expired.</em>\r\n              " +
"          </td>\r\n");


            
            #line 60 "..\..\Pages\SucceededJobs.cshtml"
                    }
                    else
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <td>\r\n                            ");


            
            #line 64 "..\..\Pages\SucceededJobs.cshtml"
                       Write(HtmlHelper.QueueLabel(job.Value.Method.GetQueue()));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            <span title=\"");


            
            #line 65 "..\..\Pages\SucceededJobs.cshtml"
                                    Write(HtmlHelper.DisplayMethodHint(job.Value.Method));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                                ");


            
            #line 66 "..\..\Pages\SucceededJobs.cshtml"
                           Write(HtmlHelper.DisplayMethod(job.Value.Method));

            
            #line default
            #line hidden
WriteLiteral("    \r\n                            </span>\r\n                        </td>\r\n");



WriteLiteral("                        <td>\r\n");


            
            #line 70 "..\..\Pages\SucceededJobs.cshtml"
                             if (job.Value.SucceededAt.HasValue)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <span  data-moment=\"");


            
            #line 72 "..\..\Pages\SucceededJobs.cshtml"
                                               Write(JobHelper.ToStringTimestamp(job.Value.SucceededAt.Value));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                                    ");


            
            #line 73 "..\..\Pages\SucceededJobs.cshtml"
                               Write(job.Value.SucceededAt);

            
            #line default
            #line hidden
WriteLiteral("\r\n                                </span>\r\n");


            
            #line 75 "..\..\Pages\SucceededJobs.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </td>\r\n");


            
            #line 77 "..\..\Pages\SucceededJobs.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </tr>\r\n");


            
            #line 79 "..\..\Pages\SucceededJobs.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </tbody>\r\n    </table>\r\n");


            
            #line 82 "..\..\Pages\SucceededJobs.cshtml"
    
    
            
            #line default
            #line hidden
            
            #line 83 "..\..\Pages\SucceededJobs.cshtml"
Write(RenderPartial(new Paginator(pager)));

            
            #line default
            #line hidden
            
            #line 83 "..\..\Pages\SucceededJobs.cshtml"
                                        
}
            
            #line default
            #line hidden

        }
    }
}
#pragma warning restore 1591
