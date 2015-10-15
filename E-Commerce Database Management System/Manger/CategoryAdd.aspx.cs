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

public partial class Manger_CategoryAdd : System.Web.UI.Page
{
    MangerClass mcObj = new MangerClass();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            mcObj.ddlUrl(ddlUrl);
        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        txtName.Text = "";
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (txtName.Text == "")
        {
            Response.Write("<script>alert('Please Input Goods Category');location='javascript:history.go(-1)';</script>");
        }
        else
        {
            int P_Int_ReturnValue = mcObj.AddCategory(txtName.Text.Trim(),ddlUrl.SelectedItem.Value.ToString());
            if (P_Int_ReturnValue == -100)
            {
                Response.Write("<script>alert('This Category is Existing!');location='javascript:history.go(-1)';</script>");
            }
            else
            {
                Response.Write("<script>alert('Add Successfully!');location='javascript:history.go(-1)';</script>");
            
            }

        
        }

    }
    protected void ddlUrl_SelectedIndexChanged(object sender, EventArgs e)
    {
        ImageMapPhoto.ImageUrl = ddlUrl.SelectedItem.Value;
    }
}
