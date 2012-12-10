﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Facebook;
using TriphulcasLib.UI;
using TriphulcasMvc;

using System.Web.Mvc;
using System.Web.Routing;

public partial class usercontrols_Snippet : TriphulcasUserControl
{
    

    //HTTPMODULE!!
    protected void Page_Load(object sender, EventArgs e)
    {
        if (HttpContext.Current.User.Identity.IsAuthenticated)
        {
            if (User.IsInRole("Triphulcas"))
                WelcomeMessage = Resources.Resource1.SnippetTriphulcasWelcomeMessage;

            if (!String.IsNullOrEmpty(User.AccesToken))
                {
                    try
                    {                        
                        var client = new FacebookClient(User.AccesToken);
                        dynamic result = client.Get("me", new { fields = "id" });
                        pImage.Src = String.Format(Resources.Resource1.FacebookPictureUrl, result.id);
                        pWelcome.InnerText = WelcomeMessage;
                        pLogout.Attributes.Remove("hidden");
                    }
                    catch (FacebookOAuthException)
                    {
                    }
                }            
        }
        
        else
        {
            //ugly, I know.
            pWelcome.InnerHtml = String.Format("{0} <a class=\"popup\" href=\"/authentication.aspx\">{1}</a>.", 
                Resources.Resource1.SnippetShowFaceBeforeLink, 
                Resources.Resource1.SnippetShowFaceLink);
        }
    }

    public bool RightSide { get; set; }

    private int width = 494;
    public int Width { get { return width; } set { width = value; } }

    public string ClassName
    {
        get
        {
            var className = new StringBuilder("sticker");

            if (RightSide)
                className.Append(" floatRight");

            return className.ToString();
        }
    }

    public string CurrentUserName
    {
        get
        {
            string currentUserName = "desconocido";

            if (HttpContext.Current.User.Identity.IsAuthenticated)
                return User.FirstName;

            return currentUserName;
        }
    }

    private string welcomeMessage = Resources.Resource1.SnippetWelcomeMessage;
    public string WelcomeMessage { get { return welcomeMessage; } set { welcomeMessage = value; } }

}