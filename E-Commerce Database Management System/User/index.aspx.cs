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

public partial class index : System.Web.UI.Page
{
    UserInfoClass ucObj = new UserInfoClass();
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (!IsPostBack)
        {
            RefineBind();
            HotBind();
            DiscountBind();


        }
    }
    //Bind Markert Price
    public string GetMKPStr(string P_Str_MarketPrice)
    {
        return ucObj.VarStr(P_Str_MarketPrice, 2);
    }
    //Bind Member Price
    public string GetMBPStr(string P_Str_MemberPrice)
    {
       return  ucObj.VarStr(P_Str_MemberPrice, 2); 
    }
  
    //When we buy something, show the information of items
    public SaveSubGoodsClass GetSubGoodsInformation(DataListCommandEventArgs e, DataList DLName)
    {
        //show the information in shopping cart
        SaveSubGoodsClass Goods = new SaveSubGoodsClass();
        Goods.GoodsID = int.Parse(DLName.DataKeys[e.Item.ItemIndex].ToString());
        string GoodsStyle = e.CommandArgument.ToString();
        int index = GoodsStyle.IndexOf("|");
        if (index < -1 || index + 1 >= GoodsStyle.Length)
            return Goods;
        Goods.GoodsWeight = float.Parse(GoodsStyle.Substring(0, index));
        Goods.MemberPrice =float.Parse( GoodsStyle.Substring(index + 1));
        return (Goods);

    }
    public void AddShopCart(DataListCommandEventArgs e, DataList DLName)
    {
        if (Session["UID"] != null)
        {
            SaveSubGoodsClass Goods = null;
            Goods = GetSubGoodsInformation(e,DLName);
            if (Goods == null)
            {
                //show the wrong information
                Response.Write("<script>alert('No useful data!');</script>");
                return;
            }
            else
            {
                ucObj.AddShopCart(Goods.GoodsID, Goods.MemberPrice, Convert.ToInt32(Session["UID"].ToString()),Goods.GoodsWeight);
                Response.Write("<script>alert('Congratulations! Add to cart successfully!')</script>");

            }
        }
        else
        {
            Response.Write("<script>alert('Please log in first!!');</script>");

        }

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
    protected void DLrefinement_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "detailSee")
        {
            Session["address"] = "";
            Session["address"] = "index.aspx";
            Response.Redirect("~/User/GoodsDetail.aspx?GoodsID=" + Convert.ToInt32(DLrefinement.DataKeys[e.Item.ItemIndex].ToString()));
        }
        else if (e.CommandName == "buyGoods")
        {
            AddShopCart(e,DLrefinement);
        }
    }
    protected void DLHot_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "detailSee")
        {
            Session["address"] = "";
            Session["address"] = "index.aspx";
            Response.Redirect("~/User/GoodsDetail.aspx?GoodsID=" + Convert.ToInt32(DLHot.DataKeys[e.Item.ItemIndex].ToString()));
        }
        else if (e.CommandName == "buyGoods")
        {

            AddShopCart(e,DLHot);
        }
    }
    protected void DLDiscount_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "detailSee")
        {
            Session["address"] = "";
            Session["address"] = "index.aspx";
            Response.Redirect("~/User/GoodsDetail.aspx?GoodsID=" + Convert.ToInt32(DLDiscount.DataKeys[e.Item.ItemIndex].ToString()));
        }
        else if (e.CommandName == "buyGoods")
        {
            AddShopCart(e,DLDiscount);
        }
    }
}
