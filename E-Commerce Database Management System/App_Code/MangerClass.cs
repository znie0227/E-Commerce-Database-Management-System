using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

/// <summary>

/// </summary>
public class MangerClass
{
    DBClass dbObj = new DBClass();
	public MangerClass()
	{
		//
		
		//
	}
  
    public  void gvBind(GridView gvName, SqlCommand myCmd, string P_Str_srcTable)
    {      
        SqlDataAdapter da = new SqlDataAdapter(myCmd);
        DataSet ds = new DataSet();
        da.Fill(ds, P_Str_srcTable);
        gvName.DataSource = ds.Tables[P_Str_srcTable].DefaultView;
        gvName.DataBind();
    }
    
    /// <returns></returns>
    public int IsExistsNI(string P_Str_ProcName)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand(P_Str_ProcName, myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
       
        SqlParameter returnValue = myCmd.Parameters.Add("returnValue", SqlDbType.Int, 4);
        returnValue.Direction = ParameterDirection.ReturnValue;
       
        myConn.Open();
        try
        {
            myCmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            myCmd.Dispose();
            myConn.Close();

        }
        int P_Int_returnValue = Convert.ToInt32(returnValue.Value.ToString());
        return P_Int_returnValue;      
    }
    
    public SqlCommand GetNewICmd(string P_Str_ProcName)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand(P_Str_ProcName, myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
       
        SqlParameter returnValue = myCmd.Parameters.Add("returnValue", SqlDbType.Int, 4);
        returnValue.Direction = ParameterDirection.ReturnValue;
        
        myConn.Open();
        try
        {
            myCmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            myCmd.Dispose();
            myConn.Close();

        }
      
         return myCmd ;   
    }

    public SqlCommand  GetOrderInfo(int P_Int_Flag,int P_Int_IsMember, int P_Int_MemberID, int P_Int_OrderID, int P_Int_Confirm,int P_Int_Payed,int P_Int_Shipped,int P_Int_Finished,int P_Int_IsConfirm, int P_Int_IsPayment, int P_Int_IsConsignment, int P_Int_IsPigeonhole)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_GetOrderInfo", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
      
        SqlParameter Flag = new SqlParameter("@Flag", SqlDbType.Int, 4);
        Flag.Value = P_Int_Flag;
        myCmd.Parameters.Add(Flag);
        
        SqlParameter IsMember = new SqlParameter("@IsMember", SqlDbType.Int, 4);
        IsMember.Value = P_Int_IsMember;
        myCmd.Parameters.Add(IsMember);
       
        SqlParameter MemberID = new SqlParameter("@MemberID", SqlDbType.Int, 4);
        MemberID.Value = P_Int_MemberID;
        myCmd.Parameters.Add(MemberID);
        
        SqlParameter OrderID = new SqlParameter("@OrderID", SqlDbType.Int, 4);
        OrderID.Value = P_Int_OrderID;
        myCmd.Parameters.Add(OrderID);
      
        SqlParameter Confirm = new SqlParameter("@Confirm", SqlDbType.Int, 4);
        Confirm.Value = P_Int_Confirm;
        myCmd.Parameters.Add(Confirm);
        
        SqlParameter Payed = new SqlParameter("@Payed", SqlDbType.Int, 4);
        Payed.Value = P_Int_Payed;
        myCmd.Parameters.Add(Payed);
       
        SqlParameter Shipped = new SqlParameter("@Shipped", SqlDbType.Int, 4);
        Shipped.Value = P_Int_Shipped;
        myCmd.Parameters.Add(Shipped);
        SqlParameter Finished = new SqlParameter("@Finished", SqlDbType.Int, 4);
        Finished.Value = P_Int_Finished;
        myCmd.Parameters.Add(Finished);
        
        SqlParameter IsConfirm = new SqlParameter("@IsConfirm", SqlDbType.Int, 4);
        IsConfirm.Value = P_Int_IsConfirm;
        myCmd.Parameters.Add(IsConfirm);
      
        SqlParameter IsPayment = new SqlParameter("@IsPayment", SqlDbType.Int, 4);
        IsPayment.Value = P_Int_IsPayment;
        myCmd.Parameters.Add(IsPayment);
       
        SqlParameter IsConsignment = new SqlParameter("@IsConsignment", SqlDbType.Int, 4);
        IsConsignment.Value = P_Int_IsConsignment;
        myCmd.Parameters.Add(IsConsignment);
        
        SqlParameter IsPigeonhole = new SqlParameter("@IsPigeonhole", SqlDbType.Int, 4);
        IsPigeonhole.Value = P_Int_IsPigeonhole;
        myCmd.Parameters.Add(IsPigeonhole);
       
        myConn.Open();
        try
        {
            myCmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            myCmd.Dispose();
            myConn.Close();

        }
        return myCmd;
    }
 
    public void DeleteOrderInfo(int P_Int_OrderID)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_DeleteOrderInfo", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
        
        SqlParameter OrderID = new SqlParameter("@OrderID", SqlDbType.BigInt, 8);
        OrderID.Value = P_Int_OrderID;
        myCmd.Parameters.Add(OrderID);
       
        myConn.Open();
        try
        {
            myCmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            myCmd.Dispose();
            myConn.Close();

        }
    }
   
    public string GetShipWay(int P_Int_ShipType)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_GetShipWay", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
       
        SqlParameter ShipType = new SqlParameter("@ShipType", SqlDbType.Int,4);
        ShipType.Value = P_Int_ShipType;
        myCmd.Parameters.Add(ShipType);
        
        myConn.Open();
        string P_Str_ShipWay =Convert.ToString(myCmd.ExecuteScalar());
        myCmd.Dispose();
        myConn.Close();
        return P_Str_ShipWay;
    }
   
    public string GetPayWay(int P_Int_PayType)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_GetPayWay", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
        
        SqlParameter PayType = new SqlParameter("@PayType", SqlDbType.Int, 4);
        PayType.Value = P_Int_PayType;
        myCmd.Parameters.Add(PayType);
       
        myConn.Open();
        string P_Str_PayWay = Convert.ToString (myCmd.ExecuteScalar());
        myCmd.Dispose();
        myConn.Close();
        return P_Str_PayWay;
    }
   
    public DataSet GetStatusDS(int P_Int_OrderID,string P_Str_srcTable)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_GetStatus", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
       
        SqlParameter OrderID = new SqlParameter("@OrderID", SqlDbType.BigInt, 8);
        OrderID.Value = P_Int_OrderID;
        myCmd.Parameters.Add(OrderID);
        
        myConn.Open();
        myCmd.ExecuteNonQuery();
        SqlDataAdapter da = new SqlDataAdapter(myCmd);
        DataSet ds=new DataSet ();
        da.Fill(ds, P_Str_srcTable);
        myCmd.Dispose();
        myConn.Dispose();
        return ds;
    }
   
    public DataSet GetOdIfDS(int P_Int_OrderID, string P_Str_srcTable)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_GetOdIf", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
       
        SqlParameter OrderID = new SqlParameter("@OrderID", SqlDbType.BigInt, 8);
        OrderID.Value = P_Int_OrderID;
        myCmd.Parameters.Add(OrderID);
        
        myConn.Open();
        myCmd.ExecuteNonQuery();
        SqlDataAdapter da = new SqlDataAdapter(myCmd);
        DataSet ds = new DataSet();
        da.Fill(ds, P_Str_srcTable);
        myCmd.Dispose();
        myConn.Dispose();
        return ds;
    }
    
    public DataSet GetGIByOID(int P_Int_OrderID, string P_Str_srcTable)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_GetGIByOID", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
        
        SqlParameter OrderID = new SqlParameter("@OrderID", SqlDbType.BigInt, 8);
        OrderID.Value = P_Int_OrderID;
        myCmd.Parameters.Add(OrderID);
        
        myConn.Open();
        myCmd.ExecuteNonQuery();
        SqlDataAdapter da = new SqlDataAdapter(myCmd);
        DataSet ds = new DataSet();
        da.Fill(ds, P_Str_srcTable);
        myCmd.Dispose();
        myConn.Dispose();
        return ds;
    }
   
    public void UpdateOI(int P_Int_OrderID,bool P_Bl_IsConfirm,bool P_Bl_IsPayment,bool P_Bl_IsConsignment,bool P_Bl_IsPigeonhole)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_UpdateOI", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
        
        SqlParameter OrderID = new SqlParameter("@OrderID", SqlDbType.BigInt, 8);
        OrderID.Value = P_Int_OrderID;
        myCmd.Parameters.Add(OrderID);
        
        SqlParameter IsConfirm = new SqlParameter("@IsConfirm", SqlDbType.Bit, 1);
        IsConfirm.Value = P_Bl_IsConfirm;
        myCmd.Parameters.Add(IsConfirm);
        
        SqlParameter IsPayment = new SqlParameter("@IsPayment", SqlDbType.Bit, 1);
        IsPayment.Value = P_Bl_IsPayment;
        myCmd.Parameters.Add(IsPayment);
        
        SqlParameter IsConsignment = new SqlParameter("@IsConsignment", SqlDbType.Bit, 1);
        IsConsignment.Value = P_Bl_IsConsignment;
        myCmd.Parameters.Add(IsConsignment);
        
        SqlParameter IsPigeonhole = new SqlParameter("@IsPigeonhole", SqlDbType.Bit, 1);
        IsPigeonhole.Value = P_Bl_IsPigeonhole;
        myCmd.Parameters.Add(IsPigeonhole);
        
        myConn.Open();
        try
        {
            myCmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            myCmd.Dispose();
            myConn.Close();

        }
    }
    
    public int AddCategory(string P_Str_ClassName, string P_Str_categoryUrl)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_AddCategory", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
        
        SqlParameter ClassName = new SqlParameter("@ClassName", SqlDbType.VarChar, 50);
        ClassName.Value = P_Str_ClassName;
        myCmd.Parameters.Add(ClassName);
        
        SqlParameter categoryUrl = new SqlParameter("@categoryUrl", SqlDbType.VarChar, 50);
        categoryUrl.Value = P_Str_categoryUrl;
        myCmd.Parameters.Add(categoryUrl);
        
        SqlParameter returnValue = myCmd.Parameters.Add("returnValue", SqlDbType.Int, 4);
        returnValue.Direction = ParameterDirection.ReturnValue;
        
        myConn.Open();
        try
        {
            myCmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            myCmd.Dispose();
            myConn.Close();

        }
        int P_Int_returnValue = Convert.ToInt32(returnValue.Value.ToString());
        return P_Int_returnValue;
    }
  
    public DataSet GetCategory( string P_Str_srcTable)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_GetCategory", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
        
        myConn.Open();
        myCmd.ExecuteNonQuery();
        SqlDataAdapter da = new SqlDataAdapter(myCmd);
        DataSet ds = new DataSet();
        da.Fill(ds, P_Str_srcTable);
        myCmd.Dispose();
        myConn.Dispose();
        return ds;
    }
  
    public void  DeleteCategory(int P_Int_ClassID)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_DeleteCategory", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
        
        SqlParameter ClassID = new SqlParameter("@ClassID", SqlDbType.BigInt, 8);
        ClassID.Value = P_Int_ClassID;
        myCmd.Parameters.Add(ClassID);
        
        myConn.Open();
        try
        {
            myCmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            myCmd.Dispose();
            myConn.Close();

        }
    }


    
    public void ddlClassBind(DropDownList ddlName)
    { 
        string P_Str_SqlStr = "select * from tb_Class";
        SqlConnection myConn = dbObj.GetConnection();
        SqlDataAdapter da = new SqlDataAdapter(P_Str_SqlStr, myConn);
        DataSet ds = new DataSet();
        da.Fill(ds, "Class");
        ddlName.DataSource = ds.Tables["Class"].DefaultView;
        ddlName.DataTextField = ds.Tables["Class"].Columns[1].ToString();
        ddlName.DataValueField = ds.Tables["Class"].Columns[0].ToString();
        ddlName.DataBind();

    }
    
    public void ddlUrl(DropDownList ddlName)
    {
        string P_Str_SqlStr = "select * from tb_Image";
        SqlConnection myConn = dbObj.GetConnection();
        SqlDataAdapter da = new SqlDataAdapter(P_Str_SqlStr, myConn);
        DataSet ds = new DataSet();
        da.Fill(ds, "Url");
        ddlName.DataSource = ds.Tables["Url"].DefaultView;
        ddlName.DataTextField = ds.Tables["Url"].Columns[1].ToString();
        ddlName.DataValueField = ds.Tables["Url"].Columns[2].ToString();
        ddlName.DataBind();
    }
  
    public int AddGInfo(int P_Int_ClassID, string P_Str_GoodsName, string P_Str_GoodsIntroduce, string P_Str_GoodsBrand, string P_Str_GoodsUnit, float P_Flt_GoodsWeight, string P_Str_GoodsUrl, float P_Flt_MarketPrice, float P_Flt_MemberPrice, bool P_Bl_Isrefinement, bool P_Bl_IsHot, bool P_Bl_IsDiscount)
    {

        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_AddGoodsInfo", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
        
        SqlParameter ClassID = new SqlParameter("@ClassID", SqlDbType.BigInt,8);
        ClassID.Value = P_Int_ClassID;
        myCmd.Parameters.Add(ClassID);
        
        SqlParameter GoodsName = new SqlParameter("@GoodsName", SqlDbType.VarChar, 50);
        GoodsName.Value = P_Str_GoodsName;
        myCmd.Parameters.Add(GoodsName);
        
        SqlParameter GoodsIntroduce = new SqlParameter("@GoodsIntroduce", SqlDbType.NText, 16);
        GoodsIntroduce.Value = P_Str_GoodsIntroduce;
        myCmd.Parameters.Add(GoodsIntroduce);
       
        SqlParameter GoodsBrand = new SqlParameter("@GoodsBrand", SqlDbType.VarChar, 50);
        GoodsBrand.Value = P_Str_GoodsBrand;
        myCmd.Parameters.Add(GoodsBrand);
        
        SqlParameter GoodsUnit = new SqlParameter("@GoodsUnit", SqlDbType.VarChar, 10);
        GoodsUnit.Value = P_Str_GoodsUnit;
        myCmd.Parameters.Add(GoodsUnit);
        
        SqlParameter GoodsWeight = new SqlParameter("@GoodsWeight", SqlDbType.Float , 8);
        GoodsWeight.Value = P_Flt_GoodsWeight;
        myCmd.Parameters.Add(GoodsWeight);
        
        SqlParameter GoodsUrl = new SqlParameter("@GoodsUrl", SqlDbType.VarChar, 50);
        GoodsUrl.Value = P_Str_GoodsUrl;
        myCmd.Parameters.Add(GoodsUrl);
        
        SqlParameter MarketPrice = new SqlParameter("@MarketPrice", SqlDbType.Float , 8);
        MarketPrice.Value = P_Flt_MarketPrice;
        myCmd.Parameters.Add(MarketPrice);
        
        SqlParameter MemberPrice = new SqlParameter("@MemberPrice", SqlDbType.Float, 8);
        MemberPrice.Value = P_Flt_MemberPrice;
        myCmd.Parameters.Add(MemberPrice);
        
        SqlParameter Isrefinement = new SqlParameter("@Isrefinement", SqlDbType.Bit, 1);
        Isrefinement.Value = P_Bl_Isrefinement;
        myCmd.Parameters.Add(Isrefinement);
        
        SqlParameter IsHot = new SqlParameter("@IsHot", SqlDbType.Bit, 1);
        IsHot.Value = P_Bl_IsHot;
        myCmd.Parameters.Add(IsHot);
        
        SqlParameter IsDiscount = new SqlParameter("@IsDiscount", SqlDbType.Bit, 1);
        IsDiscount.Value = P_Bl_IsDiscount;
        myCmd.Parameters.Add(IsDiscount);
        
        SqlParameter returnValue = myCmd.Parameters.Add("returnValue",SqlDbType.Int,4);
        returnValue.Direction = ParameterDirection.ReturnValue;
        
        myConn.Open();
        try
        {
            myCmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw (ex);

        }
        finally
        {
            myCmd.Dispose();
            myConn.Close();
        }
        return Convert.ToInt32(returnValue.Value.ToString());

    }
    
    public DataSet GetGoodsInfoDs(string P_Str_srcTable)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_GetGoodsInfo", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
        
        myConn.Open();
        myCmd.ExecuteNonQuery();
        SqlDataAdapter da = new SqlDataAdapter(myCmd);
        DataSet ds = new DataSet();
        da.Fill(ds, P_Str_srcTable);
        myCmd.Dispose();
        myConn.Dispose();
        return ds;
    }
    
    public DataSet GetGoodsInfoByIDDs(int P_Int_GoodsID,string P_Str_srcTable)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_GetGoodsInfoByID", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
       
        SqlParameter GoodsID = new SqlParameter("@GoodsID", SqlDbType.BigInt, 8);
        GoodsID.Value = P_Int_GoodsID;
        myCmd.Parameters.Add(GoodsID);
      
        myConn.Open();
        myCmd.ExecuteNonQuery();
        SqlDataAdapter da = new SqlDataAdapter(myCmd);
        DataSet ds = new DataSet();
        da.Fill(ds, P_Str_srcTable);
        myCmd.Dispose();
        myConn.Dispose();
        return ds;
    }
    
    public DataSet SearchGoodsInfoDs(string P_Str_srcTable, string P_Str_keywords)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_SearchGoodsInfo", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
        
        SqlParameter keywords = new SqlParameter("@keywords", SqlDbType.VarChar, 50);
        keywords.Value = P_Str_keywords;
        myCmd.Parameters.Add(keywords);

       
        myConn.Open();
        myCmd.ExecuteNonQuery();
        SqlDataAdapter da = new SqlDataAdapter(myCmd);
        DataSet ds = new DataSet();
        da.Fill(ds, P_Str_srcTable);
        myCmd.Dispose();
        myConn.Dispose();
        return ds;
    }
   
    public void DeleteGoodsInfo(int P_Int_GoodsID)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_DeleteGoodsInfo", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
        
        SqlParameter GoodsID = new SqlParameter("@GoodsID", SqlDbType.BigInt, 8);
        GoodsID.Value = P_Int_GoodsID;
        myCmd.Parameters.Add(GoodsID);
        
        myConn.Open();
        try
        {
            myCmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            myCmd.Dispose();
            myConn.Close();

        }
    }
    public void UpdateGInfo(int P_Int_ClassID, string P_Str_GoodsName, string P_Str_GoodsIntroduce, string P_Str_GoodsBrand, string P_Str_GoodsUnit, float P_Flt_GoodsWeight, string P_Str_GoodsUrl, float P_Flt_MarketPrice, float P_Flt_MemberPrice, bool P_Bl_Isrefinement, bool P_Bl_IsHot, bool P_Bl_IsDiscount, int P_Int_GoodsID)
    {

        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_UpdateGoodsInfo", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
       
        SqlParameter ClassID = new SqlParameter("@ClassID", SqlDbType.BigInt, 8);
        ClassID.Value = P_Int_ClassID;
        myCmd.Parameters.Add(ClassID);
        
        SqlParameter GoodsName = new SqlParameter("@GoodsName", SqlDbType.VarChar, 50);
        GoodsName.Value = P_Str_GoodsName;
        myCmd.Parameters.Add(GoodsName);
       
        SqlParameter GoodsIntroduce = new SqlParameter("@GoodsIntroduce", SqlDbType.NText, 16);
        GoodsIntroduce.Value = P_Str_GoodsIntroduce;
        myCmd.Parameters.Add(GoodsIntroduce);
        
        SqlParameter GoodsBrand = new SqlParameter("@GoodsBrand", SqlDbType.VarChar, 50);
        GoodsBrand.Value = P_Str_GoodsBrand;
        myCmd.Parameters.Add(GoodsBrand);
        
        SqlParameter GoodsUnit = new SqlParameter("@GoodsUnit", SqlDbType.VarChar, 10);
        GoodsUnit.Value = P_Str_GoodsUnit;
        myCmd.Parameters.Add(GoodsUnit);
        
        SqlParameter GoodsWeight = new SqlParameter("@GoodsWeight", SqlDbType.Float , 8);
        GoodsWeight.Value = P_Flt_GoodsWeight;
        myCmd.Parameters.Add(GoodsWeight);
        
        SqlParameter GoodsUrl = new SqlParameter("@GoodsUrl", SqlDbType.VarChar, 50);
        GoodsUrl.Value = P_Str_GoodsUrl;
        myCmd.Parameters.Add(GoodsUrl);
        
        SqlParameter MarketPrice = new SqlParameter("@MarketPrice", SqlDbType.Float , 8);
        MarketPrice.Value = P_Flt_MarketPrice;
        myCmd.Parameters.Add(MarketPrice);
        
        SqlParameter MemberPrice = new SqlParameter("@MemberPrice", SqlDbType.Float , 8);
        MemberPrice.Value = P_Flt_MemberPrice;
        myCmd.Parameters.Add(MemberPrice);
        
        SqlParameter Isrefinement = new SqlParameter("@Isrefinement", SqlDbType.Bit, 1);
        Isrefinement.Value = P_Bl_Isrefinement;
        myCmd.Parameters.Add(Isrefinement);
        
        SqlParameter IsHot = new SqlParameter("@IsHot", SqlDbType.Bit, 1);
        IsHot.Value = P_Bl_IsHot;
        myCmd.Parameters.Add(IsHot);
       
        SqlParameter IsDiscount = new SqlParameter("@IsDiscount", SqlDbType.Bit, 1);
        IsDiscount.Value = P_Bl_IsDiscount;
        myCmd.Parameters.Add(IsDiscount);
        
        SqlParameter GoodsID = new SqlParameter("@GoodsID", SqlDbType.BigInt, 8);
        GoodsID.Value = P_Int_GoodsID;
        myCmd.Parameters.Add(GoodsID);
        
        myConn.Open();
        try
        {
            myCmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw (ex);

        }
        finally
        {
            myCmd.Dispose();
            myConn.Close();
        }
    }
    
    public int AddAdmin(string P_Str_Admin,string P_Str_Password)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_AddAdmin", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
        
        SqlParameter Admin = new SqlParameter("@Admin", SqlDbType.VarChar, 50);
        Admin.Value = P_Str_Admin;
        myCmd.Parameters.Add(Admin);
        
        SqlParameter Password = new SqlParameter("@Password", SqlDbType.VarChar, 50);
        Password.Value = P_Str_Password;
        myCmd.Parameters.Add(Password);
        
        SqlParameter returnValue = myCmd.Parameters.Add("returnValue", SqlDbType.Int, 4);
        returnValue.Direction = ParameterDirection.ReturnValue;
        
        myConn.Open();
        try
        {
            myCmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            myCmd.Dispose();
            myConn.Close();

        }
        int P_Int_returnValue = Convert.ToInt32(returnValue.Value.ToString());
        return P_Int_returnValue;
    }
   
    public int AExists(string P_Str_Name, string P_Str_Password)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_AdminExists", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
        
        SqlParameter Name = new SqlParameter("@Name", SqlDbType.VarChar, 50);
        Name.Value = P_Str_Name;
        myCmd.Parameters.Add(Name);
        
        SqlParameter Password = new SqlParameter("@Password", SqlDbType.VarChar, 50);
        Password.Value = P_Str_Password;
        myCmd.Parameters.Add(Password);
        
        SqlParameter returnValue = myCmd.Parameters.Add("returnValue", SqlDbType.Int, 4);
        returnValue.Direction = ParameterDirection.ReturnValue;
        
        myConn.Open();
        try
        {
            myCmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            myCmd.Dispose();
            myConn.Close();

        }
        int P_Int_returnValue = Convert.ToInt32(returnValue.Value.ToString());
        return P_Int_returnValue;
    }
    
    public DataSet ReturnAIDs(string P_Str_Name, string P_Str_Password, string P_Str_srcTable)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_GetAInfo", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
        
        SqlParameter Name = new SqlParameter("@Name", SqlDbType.VarChar, 50);
        Name.Value = P_Str_Name;
        myCmd.Parameters.Add(Name);
        
        SqlParameter Password = new SqlParameter("@Password", SqlDbType.VarChar, 50);
        Password.Value = P_Str_Password;
        myCmd.Parameters.Add(Password);
       
        myConn.Open();
        try
        {
            myCmd.ExecuteNonQuery();

        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            myCmd.Dispose();
            myConn.Close();

        }
        SqlDataAdapter da = new SqlDataAdapter(myCmd);
        DataSet ds = new DataSet();
        da.Fill(ds, P_Str_srcTable);
        return ds;

    }
   
    public DataSet ReturnAdminIDs(string P_Str_srcTable)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_GetAdminInfo", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
        
        myConn.Open();
        try
        {
            myCmd.ExecuteNonQuery();

        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            myCmd.Dispose();
            myConn.Close();

        }
        SqlDataAdapter da = new SqlDataAdapter(myCmd);
        DataSet ds = new DataSet();
        da.Fill(ds, P_Str_srcTable);
        return ds;

    }
    
    public void  DeleteAdminInfo(int P_Int_AdminID)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_DeleteAdminInfo", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
       
        SqlParameter AdminID = new SqlParameter("@AdminID", SqlDbType.BigInt,8);
        AdminID.Value = P_Int_AdminID;
        myCmd.Parameters.Add(AdminID);
        
        myConn.Open();
        try
        {
            myCmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            myCmd.Dispose();
            myConn.Close();

        }
    }
    public void UpdateAdminInfo(int P_Int_AdminID,string P_Str_Admin,string P_Str_Password)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_UpdateAdminInfo", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
       
        SqlParameter AdminID = new SqlParameter("@AdminID", SqlDbType.BigInt, 8);
        AdminID.Value = P_Int_AdminID;
        myCmd.Parameters.Add(AdminID);
        
        SqlParameter Admin = new SqlParameter("@Admin", SqlDbType.VarChar, 50);
        Admin.Value = P_Str_Admin;
        myCmd.Parameters.Add(Admin);
       
        SqlParameter Password = new SqlParameter("@Password", SqlDbType.VarChar, 50);
        Password.Value = P_Str_Password;
        myCmd.Parameters.Add(Password);
        
        myConn.Open();
        try
        {
            myCmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            myCmd.Dispose();
            myConn.Close();

        }
    }
   
    public DataSet ReturnImagerDs(string P_Str_srcTable)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_GetImageInfo", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
       
        myConn.Open();
        try
        {
            myCmd.ExecuteNonQuery();

        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            myCmd.Dispose();
            myConn.Close();

        }
        SqlDataAdapter da = new SqlDataAdapter(myCmd);
        DataSet ds = new DataSet();
        da.Fill(ds, P_Str_srcTable);
        return ds;

    }
    
    public void  InsertImage(string P_Str_ImageName,string P_Str_ImageUrl)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_InsertImageInfo", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
       
        SqlParameter ImageName = new SqlParameter("@ImageName", SqlDbType.VarChar, 50);
        ImageName.Value = P_Str_ImageName;
        myCmd.Parameters.Add(ImageName);
        
        SqlParameter ImageUrl = new SqlParameter("@ImageUrl", SqlDbType.VarChar, 200);
        ImageUrl.Value = P_Str_ImageUrl;
        myCmd.Parameters.Add(ImageUrl);
       
        myConn.Open();
        try
        {
            myCmd.ExecuteNonQuery();

        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            myCmd.Dispose();
            myConn.Close();

        }
    }
    
    public void DeleteImage(int P_Int_ImageID)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_DeleteImageInfo", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
       
        SqlParameter ImageID = new SqlParameter("@ImageID", SqlDbType.BigInt, 8);
        ImageID.Value = P_Int_ImageID;
        myCmd.Parameters.Add(ImageID);
       
        myConn.Open();
        try
        {
            myCmd.ExecuteNonQuery();

        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            myCmd.Dispose();
            myConn.Close();

        }
    }
   //**************************************************************************************************
    public DataSet ReturnMemberDs(string P_Str_srcTable)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_GetAllUserInfo", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
      
        myConn.Open();
        try
        {
            myCmd.ExecuteNonQuery();

        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            myCmd.Dispose();
            myConn.Close();

        }
        SqlDataAdapter da = new SqlDataAdapter(myCmd);
        DataSet ds = new DataSet();
        da.Fill(ds, P_Str_srcTable);
        return ds;
    }
 
    public void DeleteMemberInfo(int P_Int_MemberID)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_DeleteMemberInfo", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
      
        SqlParameter MemberID = new SqlParameter("@MemberID", SqlDbType.BigInt, 8);
        MemberID.Value = P_Int_MemberID;
        myCmd.Parameters.Add(MemberID);
       
        myConn.Open();
        try
        {
            myCmd.ExecuteNonQuery();

        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            myCmd.Dispose();
            myConn.Close();

        }
    }
    //*********************************************************************************************
    
    public DataSet ReturnShipDs(string P_Str_srcTable)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_GetShipInfo", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
       
        myConn.Open();
        try
        {
            myCmd.ExecuteNonQuery();

        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            myCmd.Dispose();
            myConn.Close();

        }
        SqlDataAdapter da = new SqlDataAdapter(myCmd);
        DataSet ds = new DataSet();
        da.Fill(ds, P_Str_srcTable);
        return ds;
    }
   
    public DataSet ReturnShipDsByID(int P_Int_ShipID,string P_Str_srcTable)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_GetShipInfoByID", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
        
        SqlParameter ShipID = new SqlParameter("@ShipID", SqlDbType.BigInt, 8);
        ShipID.Value = P_Int_ShipID;
        myCmd.Parameters.Add(ShipID);
        
        myConn.Open();
        try
        {
            myCmd.ExecuteNonQuery();

        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            myCmd.Dispose();
            myConn.Close();

        }
        SqlDataAdapter da = new SqlDataAdapter(myCmd);
        DataSet ds = new DataSet();
        da.Fill(ds, P_Str_srcTable);
        return ds;
    }
  
    public void DeleteShipInfo(int P_Int_ShipID)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_DeleteShipInfo", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
        
        SqlParameter ShipID = new SqlParameter("@ShipID", SqlDbType.BigInt, 8);
        ShipID.Value = P_Int_ShipID;
        myCmd.Parameters.Add(ShipID);
       
        myConn.Open();
        try
        {
            myCmd.ExecuteNonQuery();

        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            myCmd.Dispose();
            myConn.Close();

        }
    }
    
    public string GetClass(int P_Int_ClassID)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_GetClassName", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
        
        SqlParameter ClassID = new SqlParameter("@ClassID", SqlDbType.Int, 8);
        ClassID.Value = P_Int_ClassID;
        myCmd.Parameters.Add(ClassID);
        
        myConn.Open();
        string P_Str_Class = Convert.ToString(myCmd.ExecuteScalar());
        myCmd.Dispose();
        myConn.Close();
        return P_Str_Class;
    }
    public void InsertShip(string P_Str_ShipWay, float P_Flt_ShipFee, int P_int_ClassID)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_InsertShipInfo", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
        
        SqlParameter ShipWay = new SqlParameter("@ShipWay", SqlDbType.VarChar, 50);
        ShipWay.Value = P_Str_ShipWay;
        myCmd.Parameters.Add(ShipWay);
        
        SqlParameter ShipFee = new SqlParameter("@ShipFee", SqlDbType.Float , 8);
        ShipFee.Value = P_Flt_ShipFee;
        myCmd.Parameters.Add(ShipFee);
       
        
        SqlParameter ClassID = new SqlParameter("@ClassID", SqlDbType.BigInt, 8);
        ClassID.Value = P_int_ClassID;
        myCmd.Parameters.Add(ClassID);
        
        myConn.Open();
        try
        {
            myCmd.ExecuteNonQuery();

        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            myCmd.Dispose();
            myConn.Close();

        }
    }
    public void UpdateShip(int P_Int_ShipID, string P_Str_ShipWay, float P_Flt_ShipFee, int P_int_ClassID)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_UpdateShipInfo", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
        
        SqlParameter ShipID = new SqlParameter("@ShipID", SqlDbType.BigInt, 8);
        ShipID.Value = P_Int_ShipID;
        myCmd.Parameters.Add(ShipID);
        
        SqlParameter ShipWay = new SqlParameter("@ShipWay", SqlDbType.VarChar, 50);
        ShipWay.Value = P_Str_ShipWay;
        myCmd.Parameters.Add(ShipWay);
        
        SqlParameter ShipFee = new SqlParameter("@ShipFee", SqlDbType.Float , 8);
        ShipFee.Value = P_Flt_ShipFee;
        myCmd.Parameters.Add(ShipFee);

        
        SqlParameter ClassID = new SqlParameter("@ClassID", SqlDbType.BigInt, 8);
        ClassID.Value = P_int_ClassID;
        myCmd.Parameters.Add(ClassID);
        
        myConn.Open();
        try
        {
            myCmd.ExecuteNonQuery();

        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            myCmd.Dispose();
            myConn.Close();

        }
    }
    //*********************************************************************************************
   
    public DataSet ReturnPayDs(string P_Str_srcTable)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_GetPayInfo", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
        
        myConn.Open();
        try
        {
            myCmd.ExecuteNonQuery();

        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            myCmd.Dispose();
            myConn.Close();

        }
        SqlDataAdapter da = new SqlDataAdapter(myCmd);
        DataSet ds = new DataSet();
        da.Fill(ds, P_Str_srcTable);
        return ds;
    }
    
    public DataSet ReturnPayDsByID(int P_Int_PayID, string P_Str_srcTable)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_GetPayInfoByID", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
        
        SqlParameter PayID = new SqlParameter("@PayID", SqlDbType.BigInt, 8);
        PayID.Value = P_Int_PayID;
        myCmd.Parameters.Add(PayID);
        
        myConn.Open();
        try
        {
            myCmd.ExecuteNonQuery();

        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            myCmd.Dispose();
            myConn.Close();

        }
        SqlDataAdapter da = new SqlDataAdapter(myCmd);
        DataSet ds = new DataSet();
        da.Fill(ds, P_Str_srcTable);
        return ds;
    }
   
    public void DeletePayInfo(int P_Int_PayID)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_DeletePayInfo", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
       
        SqlParameter PayID = new SqlParameter("@PayID", SqlDbType.BigInt, 8);
        PayID.Value = P_Int_PayID;
        myCmd.Parameters.Add(PayID);
        
        myConn.Open();
        try
        {
            myCmd.ExecuteNonQuery();

        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            myCmd.Dispose();
            myConn.Close();

        }
    }
    public void InsertPay(string P_Str_PayWay)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_InsertPayInfo", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
        
        SqlParameter PayWay = new SqlParameter("@PayWay", SqlDbType.VarChar, 50);
        PayWay.Value = P_Str_PayWay;
        myCmd.Parameters.Add(PayWay);  
        
        myConn.Open();
        try
        {
            myCmd.ExecuteNonQuery();

        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            myCmd.Dispose();
            myConn.Close();

        }
    }
    public void UpdatePay(int P_Int_PayID, string P_Str_PayWay)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_UpdatePayInfo", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
       
        SqlParameter PayID = new SqlParameter("@PayID", SqlDbType.BigInt, 8);
        PayID.Value = P_Int_PayID;
        myCmd.Parameters.Add(PayID);
        
        SqlParameter PayWay = new SqlParameter("@PayWay", SqlDbType.VarChar, 50);
        PayWay.Value = P_Str_PayWay;
        myCmd.Parameters.Add(PayWay);
        
        myConn.Open();
        try
        {
            myCmd.ExecuteNonQuery();

        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            myCmd.Dispose();
            myConn.Close();

        }
    }
   
    public DataSet ReturnAreaDs(string P_Str_srcTable)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_GetAreaInfo", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
        
        myConn.Open();
        try
        {
            myCmd.ExecuteNonQuery();

        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            myCmd.Dispose();
            myConn.Close();

        }
        SqlDataAdapter da = new SqlDataAdapter(myCmd);
        DataSet ds = new DataSet();
        da.Fill(ds, P_Str_srcTable);
        return ds;
    }

    public void DeleteAreaInfo(int P_Int_AreaID)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_DeleteAreaInfo", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
       
        SqlParameter AreaID = new SqlParameter("@AreaID", SqlDbType.BigInt, 8);
        AreaID.Value = P_Int_AreaID;
        myCmd.Parameters.Add(AreaID);
        
        myConn.Open();
        try
        {
            myCmd.ExecuteNonQuery();

        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            myCmd.Dispose();
            myConn.Close();

        }
    }
    
    public DataSet ReturnAreaDsByID(int P_Int_AreaID, string P_Str_srcTable)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_GetAreaInfoByID", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
        
        SqlParameter AreaID = new SqlParameter("@AreaID", SqlDbType.BigInt, 8);
        AreaID.Value = P_Int_AreaID;
        myCmd.Parameters.Add(AreaID);
       
        myConn.Open();
        try
        {
            myCmd.ExecuteNonQuery();

        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            myCmd.Dispose();
            myConn.Close();

        }
        SqlDataAdapter da = new SqlDataAdapter(myCmd);
        DataSet ds = new DataSet();
        da.Fill(ds, P_Str_srcTable);
        return ds;
    }
    public void InsertArea(string P_Str_AreaName,int P_Int_AreaKM)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_InsertAreaInfo", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
        
        SqlParameter AreaName = new SqlParameter("@AreaName", SqlDbType.VarChar, 50);
        AreaName.Value = P_Str_AreaName;
        myCmd.Parameters.Add(AreaName);
       
        SqlParameter AreaKM = new SqlParameter("@AreaKM", SqlDbType.Int, 4);
        AreaKM.Value = P_Int_AreaKM;
        myCmd.Parameters.Add(AreaKM);
       
        myConn.Open();
        try
        {
            myCmd.ExecuteNonQuery();

        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            myCmd.Dispose();
            myConn.Close();

        }
    }
    public void UpdateArea(int P_Int_AreaID,string P_Str_AreaName, int P_Int_AreaKM)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_UpdateAreaInfo", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
      
        SqlParameter AreaID = new SqlParameter("@AreaID", SqlDbType.BigInt, 8);
        AreaID.Value = P_Int_AreaID;
        myCmd.Parameters.Add(AreaID);
      
        SqlParameter AreaName = new SqlParameter("@AreaName", SqlDbType.VarChar, 50);
        AreaName.Value = P_Str_AreaName;
        myCmd.Parameters.Add(AreaName);
        
        SqlParameter AreaKM = new SqlParameter("@AreaKM", SqlDbType.Int, 4);
        AreaKM.Value = P_Int_AreaKM;
        myCmd.Parameters.Add(AreaKM);
       
        myConn.Open();
        try
        {
            myCmd.ExecuteNonQuery();

        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            myCmd.Dispose();
            myConn.Close();

        }
    }
  
    public string SubStr(string sString, int nLeng)
    {
        if (sString.Length <= nLeng)
        {
            return sString;
        }
        int nStrLeng = nLeng - 3;
        string sNewStr = sString.Substring(0, nStrLeng);
        sNewStr = sNewStr + "...";
        return sNewStr;
    }
   
    public string VarStr(string sString, int nLeng)
    {
        int index = sString.IndexOf(".");
        if (index == -1||index+2>=sString.Length)
            return sString;
        else
            return sString.Substring(0, (index + nLeng+1));
    }

}
