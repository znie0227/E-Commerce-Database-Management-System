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

public partial class User_ClassGoods : System.Web.UI.Page
{
    MangerClass mcObj = new MangerClass();
    UserInfoClass ucObj = new UserInfoClass();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            dlClassBind();
            lbClassName.Text = GetClass(Convert.ToInt32(this.Request.QueryString["ClassID"].ToString()));
        }
    }
    public string GetClass(int P_Int_ClassID)
    {
        string P_Str_ClassName = mcObj.GetClass(P_Int_ClassID);
        return P_Str_ClassName;
    }
    
    public string GetVarMKP(string P_Str_MarketPrice)
    {
        return ucObj.VarStr(P_Str_MarketPrice, 2);
    }
    
    public string GetVarMBP(string P_Str_MemberPrice)
    {
        return ucObj.VarStr(P_Str_MemberPrice, 2);
    }

    /// <summary>
    
    /// </summary>
    public void dlClassBind()
    {
       
        ucObj.DCGIBind(Convert.ToInt32(this.Request.QueryString["ClassID"].ToString()), "Class", DLClass);
    }
    
    public SaveSubGoodsClass GetSubGoodsInformation(DataListCommandEventArgs e, DataList DLName)
    {
        
        SaveSubGoodsClass Goods = new SaveSubGoodsClass();
        Goods.GoodsID = int.Parse(DLName.DataKeys[e.Item.ItemIndex].ToString());
        string GoodsStyle = e.CommandArgument.ToString();
        int index = GoodsStyle.IndexOf("|");
        if (index < -1 || index + 1 >= GoodsStyle.Length)
            return Goods;
        Goods.GoodsWeight = float.Parse(GoodsStyle.Substring(0, index));
        Goods.MemberPrice = float.Parse(GoodsStyle.Substring(index + 1));
        return (Goods);

    }
    public void AddShopCart(DataListCommandEventArgs e, DataList DLName)
    {
        if (Session["UID"] != null)
        {
            SaveSubGoodsClass Goods = null;
            Goods = GetSubGoodsInformation(e, DLName);
            if (Goods == null)
            {
                
                Response.Write("<script>alert('No Useful Data!');</script>");
                return;
            }
            else
            {
                ucObj.AddShopCart(Goods.GoodsID, Goods.MemberPrice, Convert.ToInt32(Session["UID"].ToString()), Goods.GoodsWeight);
                Response.Write("<script>alert('Congratulations! Add successfully!')</script>");

            }
        }
        else
        {
            Response.Write("<script>alert('Please Login First!');</script>");

        }

    }
    protected void DLClass_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "detailSee")
        {
            Session["address"] = "";
            Session["address"] = "ClassGoods.aspx?ClassID=" + Convert.ToInt32(this.Request.QueryString["ClassID"].ToString());
            Response.Redirect("~/User/GoodsDetail.aspx?GoodsID=" + Convert.ToInt32(DLClass.DataKeys[e.Item.ItemIndex].ToString()));
        }
        else if (e.CommandName == "buyGoods")
        {
            AddShopCart(e, DLClass);
        }
    }
}
