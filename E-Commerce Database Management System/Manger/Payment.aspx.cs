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

public partial class Manger_Payment : System.Web.UI.Page
{
    MangerClass mcObj = new MangerClass();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (this.Request.QueryString["Action"] == "Manage")
            {
                lblAction.Text = "Payment Method Manage";
                gvPayBind();
            }
            else if (this.Request.QueryString["Action"] == "Add")
            {
                lblAction.Text = "Add Payment Method";
               

            }
            else if (this.Request.QueryString["Action"] == "Modify")
            {
                lblAction.Text = "Modify Payment Method";
                GetPayInfo();
            }

           
        }

    }
    public void gvPayBind()
    {
        DataSet ds = mcObj.ReturnPayDs("PayInfo");
        gvPay.DataSource = ds.Tables["PayInfo"].DefaultView;
        gvPay.DataBind();
    
    }
    protected void gvPay_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvPay.PageIndex = e.NewPageIndex;
        gvPayBind();
    }
    protected void gvPay_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int P_Int_PayID = Convert.ToInt32(gvPay.DataKeys[e.RowIndex].Value.ToString());
        mcObj.DeletePayInfo(P_Int_PayID);
        gvPayBind();

    }
    public void GetPayInfo()
    {
        DataSet ds = mcObj.ReturnPayDsByID(Convert.ToInt32(this.Request["PayID"].ToString()), "PayInfo");
        txtName.Text = ds.Tables["PayInfo"].Rows[0][1].ToString();
    
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (this.Request.QueryString["Action"] == "Add")
        {
            if (txtName.Text == "")
            {
                Response.Write("<script>alert('Please input completely!')</script>");
                return;
            }
            else
            {

                mcObj.InsertPay(txtName.Text.Trim());
                Response.Write("<script>alert('Add Completely!')</script>");
                return;
            

            }

        }
        else if (this.Request.QueryString["Action"] == "Modify")
        {

            if (txtName.Text == "")
            {
                Response.Write("<script>alert('Please input completely')</script>");
                return;
            }
            else
            {
                mcObj.UpdatePay(Convert.ToInt32(this.Request["PayID"].ToString()), txtName.Text.Trim());
                Response.Write("<script>alert('Update Successfully！')</script>");
                return;

            }


        }
    }
}
