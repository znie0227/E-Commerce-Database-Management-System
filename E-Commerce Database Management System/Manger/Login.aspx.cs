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

public partial class AdminManage_Login : System.Web.UI.Page
{
    MangerClass mcObj=new MangerClass ();
    UserInfoClass uiObj = new UserInfoClass();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            labCode.Text = new randomCode().RandomNum(4);//
        }
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if (txtAdminName.Text.Trim() == "" || txtAdminPwd.Text.Trim() == "")
        {
            Response.Write("<script>alert('Login username or password is null！');location='javascript:history.go(-1)';</script>");
          
        }
        else
        {
            if (txtAdminCode.Text.Trim() == labCode.Text.Trim())
            {
                int P_Int_IsExists = mcObj.AExists(txtAdminName.Text.Trim(), txtAdminPwd.Text.Trim());
                if (P_Int_IsExists == 100)
                {
                    DataSet ds = mcObj.ReturnAIDs(txtAdminName.Text.Trim(), txtAdminPwd.Text.Trim(), "AInfo");

                    Session["AID"] = Convert.ToInt32(ds.Tables["AInfo"].Rows[0][0].ToString());
                    Session["Aname"] = ds.Tables["AInfo"].Rows[0][1].ToString();
                    Response.Redirect("AdminIndex.aspx");
                }
                else
                {

                    Response.Write("<script>alert('Your username or password is wrong. Please input again！');location='javascript:history.go(-1)';</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Your verification code is wrong. Please input again!');location='javascript:history.go(-1)';</script>");
            }
        }
    }
       
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Write("<script>window.close();location='javascript:history.go(-1)';</script>");
    }
}
