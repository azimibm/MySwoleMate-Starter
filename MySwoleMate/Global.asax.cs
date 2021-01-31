using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.UI;

namespace MySwoleMate
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery", new ScriptResourceDefinition
            {
                Path = "~/Script/jquery-1.11.3.min.js",
                DebugPath = "~/Script/jquery-1.11.3.js",
                CdnPath = "https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js",
                CdnDebugPath = "https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"
            });
        }
    }
}