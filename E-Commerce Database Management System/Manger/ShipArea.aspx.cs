﻿using System;
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

public partial class Manger_ShipArea : System.Web.UI.Page
{
    MangerClass mcObj = new MangerClass();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (this.Request.QueryString["Action"] == "Manage")
            {
                lblAction.Text = "Ship Area Manage";
                gvAreaBind();
            }
            else if (this.Request.QueryString["Action"] == "Add")
            {
                lblAction.Text = "Add Ship Area";


            }
            else if (this.Request.QueryString["Action"] == "Modify")
            {
                lblAction.Text = "Modify Ship Area";
                GetAreaInfo();
            }


        }

    }
    public void gvAreaBind()
    { 
        DataSet ds = mcObj.ReturnAreaDs("AreaInfo");
        gvArea.DataSource = ds.Tables["AreaInfo"].DefaultView;
        gvArea.DataBind();
    }
    protected void gvArea_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvArea.PageIndex = e.NewPageIndex;
        gvAreaBind();
    }
    protected void gvArea_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int P_Int_AreaID = Convert.ToInt32(gvArea.DataKeys[e.RowIndex].Value.ToString());
        mcObj.DeleteAreaInfo(P_Int_AreaID);
        gvAreaBind();

    }
    public void GetAreaInfo()
    {
        DataSet ds = mcObj.ReturnAreaDsByID(Convert.ToInt32(this.Request["AreaID"].ToString()), "AreaInfo");
        txtName.Text = ds.Tables["AreaInfo"].Rows[0][1].ToString();
        txtKM.Text = ds.Tables["AreaInfo"].Rows[0][2].ToString();

    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (this.Request.QueryString["Action"] == "Add")
        {
            if (txtName.Text == ""||txtKM.Text =="")
            {
                Response.Write("<script>alert('Please input completely!')</script>");
                return;
            }
            else
            {
                if (IsValidInt(txtKM.Text.Trim()) == false)
                {
                    Response.Write("<script>alert('Please input integer!')</script>");
                    return;
                }
                else
                { 
                 mcObj.InsertArea(txtName.Text.Trim(),Convert.ToInt32(txtKM.Text.Trim()));
                 Response.Write("<script>alert('Add successfully！')</script>");
                 return;
                }

               
            }

        }
        else if (this.Request.QueryString["Action"] == "Modify")
        {

            if (txtName.Text == ""||txtKM.Text=="")
            {
                Response.Write("<script>alert('请输入完整信息')</script>");
                return;
            }
            else
            {
                if (IsValidInt(txtKM.Text.Trim()) == false)
                {
                    Response.Write("<script>alert('请输入整数！')</script>");
                    return;
                }
                else
                {
                    mcObj.UpdateArea(Convert.ToInt32(this.Request["AreaID"].ToString()), txtName.Text.Trim(), Convert.ToInt32(txtKM.Text.Trim()));
                    Response.Write("<script>alert('修改成功！')</script>");
                    return;
                }
            }


        }
    }
    public bool IsValidInt(string num)
    {
        return Regex.IsMatch(num, @"[0-9]*$");

    }
   
}
