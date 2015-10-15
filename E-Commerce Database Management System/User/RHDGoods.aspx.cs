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



public partial class User_RHDGoods : System.Web.UI.Page
{
    UserInfoClass ucObj = new UserInfoClass();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            tabRefine.Visible = false;
            tabHot.Visible = false;
            tabDiscount.Visible = false;
            if (this.Request.QueryString["Display"] == "1")
            {
                tabRefine.Visible = true;
                RefineBind();
            }
            else if (this.Request.QueryString["Display"] == "2")
            {
                tabHot.Visible = true;
                HotBind();
            }
            else if (this.Request.QueryString["Display"] == "3")
            {
                tabDiscount.Visible = true;
                DiscountBind();
            }
        }
    }
    //Bind Market Price
    public string GetMKPStr(string P_Str_MarketPrice)
    {
        return ucObj.VarStr(P_Str_MarketPrice, 2);
    }
    //Bind Member Price
    public string GetMBPStr(string P_Str_MemberPrice)
    {
        return ucObj.VarStr(P_Str_MemberPrice, 2);
    }
    public void RefineBind()
    {
        ucObj.DGIBind(1, "Refine", DLrefinement);
    }
    public void HotBind()
    {
        ucObj.DGIBind(2, "Hot", DLHot);
    }
    public void DiscountBind()
    {
        ucObj.DGIBind(3, "Discount", DLDiscount);
    }
    //Get Goods Information
    public SaveSubGoodsClass GetSubGoodsInformation(DataListCommandEventArgs e, DataList DLName)
    {
        //Get information in cart
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
                //Show wrong information
                Response.Write("<script>alert('No useful data');</script>");
                return;
            }
            else
            {
                ucObj.AddShopCart(Goods.GoodsID, Goods.MemberPrice, Convert.ToInt32(Session["UID"].ToString()), Goods.GoodsWeight);
                Response.Write("<script>alert('Congratulations! Add Item Successfully!')</script>");

            }
        }
        else
        {
            Response.Write("<script>alert('Please Log in First!');</script>");

        }

    }
    protected void DLrefinement_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "detailSee")
        {
            Session["address"] = "";
            Session["address"] = "RHDGoods.aspx?Display=1";
            //Response.Redirect("~/User/GoodsDetail.aspx?GoodsID='" + Convert.ToInt32(DLrefinement.DataKeys[e.Item.ItemIndex].ToString()) + "'  addr=" + Session["address"].ToString());
            Response.Redirect("~/User/GoodsDetail.aspx?GoodsID=" + Convert.ToInt32(DLrefinement.DataKeys[e.Item.ItemIndex].ToString()));
        }
        else if (e.CommandName == "buyGoods")
        {
            AddShopCart(e, DLrefinement);
        }
    }
    protected void DLHot_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "detailSee")
        {
            Session["address"] = "";
            Session["address"] = "RHDGoods.aspx?Display=2";
            Response.Redirect("~/User/GoodsDetail.aspx?GoodsID=" + Convert.ToInt32(DLHot.DataKeys[e.Item.ItemIndex].ToString()));
        }
        else if (e.CommandName == "buyGoods")
        {
            AddShopCart(e, DLHot);
        }
    }
    protected void DLDiscount_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "detailSee")
        {
            Session["address"] = "";
            Session["address"] = "RHDGoods.aspx?Display=3";
            Response.Redirect("~/User/GoodsDetail.aspx?GoodsID=" + Convert.ToInt32(DLDiscount.DataKeys[e.Item.ItemIndex].ToString()));
        }
        else if (e.CommandName == "buyGoods")
        {
            AddShopCart(e, DLDiscount);
        }
    }
 
}
