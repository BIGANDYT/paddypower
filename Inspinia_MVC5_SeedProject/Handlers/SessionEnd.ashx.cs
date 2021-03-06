﻿namespace Inspinia_MVC5_SeedProject.Handlers
{
    using System.Web;
    using System.Web.SessionState;

    public class SessionEnd : IHttpHandler, IRequiresSessionState
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Session.Abandon();
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}