﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TechScreen.Web
{
    public partial class MenuMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var user = (TechScreen.Entities.User)Session["user"];
            if (user != null)
            {
                lblUserName.Text = user.UserName;
                if (user.RoleName != "Admin")
                {
                    Admin.Visible = false;
                }
            }
            else
            {
                Response.Redirect("Login.aspx");
            }

        }
    }
}