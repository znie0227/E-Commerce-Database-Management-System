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
using System.Text.RegularExpressions;

public partial class User_UpdateMember : System.Web.UI.Page
{
    UserInfoClass uiObj = new UserInfoClass();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        { 
         GetMIByID();
        }
           
    }
    protected void GetMIByID()
    {
        if (Convert.ToString(Session["UID"]) == "")
        {
            Response.Redirect("index.aspx");
        }
        else
         { 
                DataSet ds = new DataSet();
                ds = uiObj.ReturnUIDsByID(Convert.ToInt32(Session["UID"].ToString()), "UserInfo");
                txtName.Text=ds.Tables["UserInfo"].Rows[0][1].ToString();
                txtPassword.Text=ds.Tables["UserInfo"].Rows[0][3].ToString ();
               
                if(Convert.ToBoolean(ds.Tables["UserInfo"].Rows[0][2])==true )
                {
                    ddlSex.SelectedIndex =0;
                }
                else 
                {
                    ddlSex.SelectedIndex = 1;
                }
                txtTrueName.Text =ds.Tables["UserInfo"].Rows[0][4].ToString ();
                ddlCity.SelectedItem.Text =ds.Tables["UserInfo"].Rows [0][9].ToString ();
                txtAddress.Text=ds.Tables["UserInfo"].Rows[0][10].ToString ();
                txtPostCode.Text =ds.Tables["UserInfo"].Rows[0][11].ToString();
                txtPhone.Text=ds.Tables["UserInfo"].Rows[0][7].ToString ();
                txtEmail.Text = ds.Tables["UserInfo"].Rows[0][8].ToString();
               
        }
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        if (txtName.Text.Trim() == "" && txtPassword.Text.Trim() == "" && txtAddress.Text.Trim() == "" && txtPostCode.Text.Trim() == "" && txtPassword.Text.Trim() == "")
        {
            Response.Write("<script>alert('Please input Completely!');location='javascript:history.go(-1)';</script>");
        }
        else
        {
            if (IsValidPostCode(txtPostCode.Text.Trim()) == false)
            {
                Response.Write("<script>alert('Your Zip Code is Wrong!')</script>");
                return;
            }
            else if (IsValidPhone(txtPhone.Text.Trim()) == false)
            {
                Response.Write("<script>alert('Your Cell Phone is Wrong!')</script>");
                return;
            }
            else if (IsValidEmail(txtEmail.Text.Trim()) == false)
            {
                Response.Write("<script>alert('Your Email Address is Wrong!')</script>");
                return;
            }
            else
            {
                bool P_Bl_Sex;
                if (Convert.ToInt32(ddlSex.SelectedItem.Value.Trim()) == 1)
                {
                    P_Bl_Sex = true;

                }
                else
                {
                    P_Bl_Sex = false;

                }
                uiObj.UpdateUInfo(txtName.Text.Trim(), P_Bl_Sex, txtPassword.Text.Trim(), txtTrueName.Text.Trim(), "", "", txtPhone.Text.Trim(), txtEmail.Text.Trim(), ddlCity.SelectedItem.Text.Trim(), txtAddress.Text.Trim(), txtPostCode.Text.Trim(), Convert.ToInt32(Session["UID"].ToString()));

                Session["Username"] = "";
                Session["Username"] = txtName.Text.Trim();
                Response.Write("<script>alert('Congratulations! Update Successfully!');location='index.aspx';</script>");
            }
        }
    }

    public bool IsValidPostCode( string num)
    {

        return Regex.IsMatch(num, @"\d{5}-?(\d{4})?$");

    }
     public bool IsValidPhone( string num)
    {

        return Regex.IsMatch(num, @"((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}");

    }
     public bool IsValidEmail( string num)
    {
       
            return Regex.IsMatch(num, @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
    }
       


}
