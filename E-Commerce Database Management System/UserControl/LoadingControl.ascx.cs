using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

public partial class LoadingControl : System.Web.UI.UserControl
{
    DBClass dbObj = new DBClass();
    UserInfoClass uiObj = new UserInfoClass(); 

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            lbValid.Text = new randomCode().RandomNum(4);
             if (Session["UID"] != null)
            {

                tabLoad.Visible = true;
                 tabLoading.Visible =false ;
            }        
        }
       
    }

    protected void btnLoad_Click(object sender, EventArgs e)
    {
        Session["UID"] = null ;
        Session["Username"] = null ;
        if (txtName.Text.Trim() == "" || txtPassword.Text.Trim () == "")
        {


            Response.Write("<script>alert('The username or password is null!');location='javascript:history.go(-1)';</script>");
        }
        else
        {
            if (txtValid.Text.Trim() == lbValid.Text.Trim())
            {

                int P_Int_IsExists = uiObj.UserExists(txtName.Text.Trim(), txtPassword.Text.Trim());
                if (P_Int_IsExists == 100)
                {
                    DataSet ds = uiObj.ReturnUIDs(txtName.Text.Trim(), txtPassword.Text.Trim(), "UserInfo");
                    
                    Session["UID"] = Convert.ToInt32(ds.Tables["UserInfo"].Rows[0][0].ToString());
                    Session["Username"] = ds.Tables["UserInfo"].Rows[0][1].ToString();
                    Response.Redirect("index.aspx");
                  
                }
                else
                {
                    
                    Response.Write("<script>alert('Login failed. Please check again!');location='javascript:history.go(-1)';</script>");

                }
            }
            else
            {
                Response.Write("<script>alert('Please input correct verification code!');location='javascript:history.go(-1)';</script>");            
            }
           
        
        
        }
    }
    protected void btnRegister_Click(object sender, EventArgs e)
    {
        Response.Redirect("Register.aspx");
    }
    protected void lnkbtnResetInfo_Click(object sender, EventArgs e)
    {
        Response.Write("<script language=javascript>window.open('ResetMemberInfo.aspx','','width=655,height=655')</script>");
    }
 
}
