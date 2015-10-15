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
///
/// </summary>
public class UserInfoClass
{
    DBClass dbObj = new DBClass();
	public UserInfoClass()
	{
		//
		//
		//
	}
    
    public int UserExists(string P_Str_Name,string P_Str_Password)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_UserExists", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
        //
        SqlParameter Name = new SqlParameter("@Name", SqlDbType.VarChar, 50);
        Name.Value = P_Str_Name;
        myCmd.Parameters.Add(Name);
        //
        SqlParameter Password = new SqlParameter("@Password", SqlDbType.VarChar, 50);
        Password.Value = P_Str_Password;
        myCmd.Parameters.Add(Password);
        //
        SqlParameter returnValue = myCmd.Parameters.Add("returnValue", SqlDbType.Int, 4);
        returnValue.Direction = ParameterDirection.ReturnValue;
        //
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
  
    public DataSet ReturnUIDs(string P_Str_Name, string P_Str_Password,string P_Str_srcTable)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_GetUserInfo", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
        //
        SqlParameter Name = new SqlParameter("@Name", SqlDbType.VarChar, 50);
        Name.Value = P_Str_Name;
        myCmd.Parameters.Add(Name);
        //
        SqlParameter Password = new SqlParameter("@Password", SqlDbType.VarChar, 50);
        Password.Value = P_Str_Password;
        myCmd.Parameters.Add(Password);
        //
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
        DataSet ds= new DataSet();
        da.Fill(ds, P_Str_srcTable);
        return ds;

    }

    public int AddUInfo(string P_Str_Name, bool P_Bl_Sex, string P_Str_Password, string P_Str_TrueName, string P_Str_Questions, string P_Str_Answers, string P_Str_Phonecode, string P_Str_Emails, string P_Str_City, string P_Str_Address, string P_Str_PostCode)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_InsertUInfo", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
        //
        SqlParameter Name = new SqlParameter("@Name", SqlDbType.VarChar, 50);
        Name.Value = P_Str_Name;
        myCmd.Parameters.Add(Name);
        //
        SqlParameter sex = new SqlParameter("@sex", SqlDbType.Bit,1);
        sex.Value = P_Bl_Sex;
        myCmd.Parameters.Add(sex);
        //
        SqlParameter Password = new SqlParameter("@Password", SqlDbType.VarChar, 50);
        Password.Value = P_Str_Password;
        myCmd.Parameters.Add(Password);
        //
        SqlParameter TrueName = new SqlParameter("@TrueName", SqlDbType.VarChar, 50);
        TrueName.Value = P_Str_TrueName;
        myCmd.Parameters.Add(TrueName);
        //
        SqlParameter Questions = new SqlParameter("@Questions", SqlDbType.VarChar, 50);
        Questions.Value = P_Str_Questions;
        myCmd.Parameters.Add(Questions);
        //
        SqlParameter Answers = new SqlParameter("@Answers", SqlDbType.VarChar, 50);
        Answers.Value = P_Str_Answers;
        myCmd.Parameters.Add(Answers);
        //
        SqlParameter Phonecode = new SqlParameter("@Phonecode", SqlDbType.VarChar, 20);
        Phonecode.Value = P_Str_Phonecode;
        myCmd.Parameters.Add(Phonecode);
        //
        SqlParameter Emails = new SqlParameter("@Emails", SqlDbType.VarChar, 50);
        Emails.Value = P_Str_Emails;
        myCmd.Parameters.Add(Emails);
        //
        SqlParameter City = new SqlParameter("@City", SqlDbType.VarChar, 50);
        City.Value = P_Str_City;
        myCmd.Parameters.Add(City);
        //
        SqlParameter Address = new SqlParameter("@Address", SqlDbType.VarChar, 200);
        Address.Value = P_Str_Address;
        myCmd.Parameters.Add(Address);
        //
        SqlParameter PostCode = new SqlParameter("@PostCode", SqlDbType.Char, 10);
        PostCode.Value = P_Str_PostCode;
        myCmd.Parameters.Add(PostCode);
        //
        SqlParameter MemberId = myCmd.Parameters.Add("@MemberId",SqlDbType.BigInt,8);
        MemberId.Direction = ParameterDirection.Output;
        //
        myConn.Open();
        try
        {
            myCmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw(ex);
           
        }
        finally
        {
             myCmd.Dispose();
             myConn.Close();
        }
        return Convert.ToInt32(MemberId.Value.ToString());
      
    }
   
    public void UpdateAP(int P_Int_MemberID, float P_Flt_AdvancePayment)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_UpdateAP", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
        //
        SqlParameter MemberID = new SqlParameter("@MemberID", SqlDbType.BigInt, 8);
        MemberID.Value = P_Int_MemberID;
        myCmd.Parameters.Add(MemberID);
        
        SqlParameter AdvancePayment = new SqlParameter("@AdvancePayment", SqlDbType.Float, 8);
        AdvancePayment.Value = P_Flt_AdvancePayment;
        myCmd.Parameters.Add(AdvancePayment);
        
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
    
    public DataSet ReturnUIDsByID(int P_Int_MemberID, string P_Str_srcTable)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_GetUIByID", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
        //
        SqlParameter MemberID = new SqlParameter("@MemberID", SqlDbType.BigInt, 8);
        MemberID.Value = P_Int_MemberID;
        myCmd.Parameters.Add(MemberID);
        //
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
   
    public void  UpdateUInfo(string P_Str_Name, bool P_Bl_Sex, string P_Str_Password, string P_Str_TrueName, string P_Str_Questions, string P_Str_Answers, string P_Str_Phonecode, string P_Str_Emails, string P_Str_City, string P_Str_Address, string P_Str_PostCode,int P_Int_MemberID)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_UpdateUIbyID", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
        //
        SqlParameter Name = new SqlParameter("@Name", SqlDbType.VarChar, 50);
        Name.Value = P_Str_Name;
        myCmd.Parameters.Add(Name);
        //
        SqlParameter sex = new SqlParameter("@sex", SqlDbType.Bit, 1);
        sex.Value = P_Bl_Sex;
        myCmd.Parameters.Add(sex);
        //
        SqlParameter Password = new SqlParameter("@Password", SqlDbType.VarChar, 50);
        Password.Value = P_Str_Password;
        myCmd.Parameters.Add(Password);
        //
        SqlParameter TrueName = new SqlParameter("@TrueName", SqlDbType.VarChar, 50);
        TrueName.Value = P_Str_TrueName;
        myCmd.Parameters.Add(TrueName);
        //
        SqlParameter Questions = new SqlParameter("@Questions", SqlDbType.VarChar, 50);
        Questions.Value = P_Str_Questions;
        myCmd.Parameters.Add(Questions);
        //
        SqlParameter Answers = new SqlParameter("@Answers", SqlDbType.VarChar, 50);
        Answers.Value = P_Str_Answers;
        myCmd.Parameters.Add(Answers);
        //
        SqlParameter Phonecode = new SqlParameter("@Phonecode", SqlDbType.VarChar, 20);
        Phonecode.Value = P_Str_Phonecode;
        myCmd.Parameters.Add(Phonecode);
        //
        SqlParameter Emails = new SqlParameter("@Emails", SqlDbType.VarChar, 50);
        Emails.Value = P_Str_Emails;
        myCmd.Parameters.Add(Emails);
        //
        SqlParameter City = new SqlParameter("@City", SqlDbType.VarChar, 50);
        City.Value = P_Str_City;
        myCmd.Parameters.Add(City);
        //
        SqlParameter Address = new SqlParameter("@Address", SqlDbType.VarChar, 200);
        Address.Value = P_Str_Address;
        myCmd.Parameters.Add(Address);
        //
        SqlParameter PostCode = new SqlParameter("@PostCode", SqlDbType.Char, 10);
        PostCode.Value = P_Str_PostCode;
        myCmd.Parameters.Add(PostCode);
        //
        SqlParameter MemberId = new SqlParameter("@MemberId", SqlDbType.BigInt, 8);
        MemberId.Value = P_Int_MemberID;
        myCmd.Parameters.Add(MemberId);
        //
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
    
    public void DLClassBind(DataList  dlName)
    {
        string P_Str_SqlStr = "select * from tb_Class";
        SqlConnection myConn = dbObj.GetConnection();
        SqlDataAdapter da = new SqlDataAdapter(P_Str_SqlStr, myConn);
        DataSet ds = new DataSet();
        da.Fill(ds, "Class");
        dlName.DataSource = ds.Tables["Class"].DefaultView;
        dlName.DataBind();
    }

  
    public void DGIBind(int P_Int_Deplay, string P_Str_srcTable,DataList DLName)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_DeplayGInfo", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
        //
        SqlParameter Deplay = new SqlParameter("@Deplay", SqlDbType.Int, 4);
        Deplay.Value = P_Int_Deplay;
        myCmd.Parameters.Add(Deplay);
        //
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
        DLName.DataSource = ds.Tables[P_Str_srcTable].DefaultView;
        DLName.DataBind();
    
    }
  
    public void DCGIBind(int P_Int_ClassID, string P_Str_srcTable, DataList DLName)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_DeplayGIByC", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
        //
        SqlParameter ClassID = new SqlParameter("@ClassID", SqlDbType.BigInt, 8);
        ClassID.Value = P_Int_ClassID;
        myCmd.Parameters.Add(ClassID);
        //
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
        DLName.DataSource = ds.Tables[P_Str_srcTable].DefaultView;
        DLName.DataBind();

    }

    public void AddShopCart(int P_Int_GoodsID, float P_Flt_MemberPrice, int P_Int_MemberID, float P_Flt_GoodsWeight)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_InsertShopCart", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
        //
        SqlParameter GoodsID = new SqlParameter("@GoodsID", SqlDbType.BigInt, 8);
        GoodsID.Value = P_Int_GoodsID;
        myCmd.Parameters.Add(GoodsID);
        //
        SqlParameter MemberPrice = new SqlParameter("@MemberPrice", SqlDbType.Float, 8);
        MemberPrice.Value = P_Flt_MemberPrice;
        myCmd.Parameters.Add(MemberPrice);
        //
        SqlParameter MemberID = new SqlParameter("@MemberID", SqlDbType.BigInt, 8);
        MemberID.Value = P_Int_MemberID;
        myCmd.Parameters.Add(MemberID);
        //
        SqlParameter GoodsWeight = new SqlParameter("@GoodsWeight", SqlDbType.Float , 8);
        GoodsWeight.Value = P_Flt_GoodsWeight;
        myCmd.Parameters.Add(GoodsWeight);
        //
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
    
    public void SCIBind(string P_Str_srcTable, GridView  gvName, int P_Int_MemberID)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_GetShopCart", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
        //
        SqlParameter MemberID = new SqlParameter("@MemberID", SqlDbType.BigInt, 8);
        MemberID.Value = P_Int_MemberID;
        myCmd.Parameters.Add(MemberID);
        //
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
        gvName.DataSource = ds.Tables[P_Str_srcTable].DefaultView;
        gvName.DataBind();

    }
    
    public DataSet ReturnTotalDs(int P_Int_MemberID,string P_Str_srcTable)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_TotalInfo", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
        //
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
        SqlDataAdapter da = new SqlDataAdapter(myCmd);
        DataSet ds = new DataSet();
        da.Fill(ds, P_Str_srcTable);
        return ds;
         
    }
   
    public void DeleteShopCart(int P_Int_MemberID)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_DeleteShopCart", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
        //
        SqlParameter MemberID = new SqlParameter("@MemberID", SqlDbType.BigInt, 8);
        MemberID.Value = P_Int_MemberID;
        myCmd.Parameters.Add(MemberID);
        //
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
    
    public void DeleteShopCartByID(int P_Int_MemberID,int P_Int_CartID)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_DeleteSCByID", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
        //
        SqlParameter MemberID = new SqlParameter("@MemberID", SqlDbType.BigInt, 8);
        MemberID.Value = P_Int_MemberID;
        myCmd.Parameters.Add(MemberID);
        //
        SqlParameter CartID = new SqlParameter("@CartID", SqlDbType.BigInt, 8);
        CartID.Value = P_Int_CartID;
        myCmd.Parameters.Add(CartID);
        //
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
    
    public void UpdateSCI(int P_Int_MemberID, int P_Int_CartID, int P_Int_Num)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_UpdateSC", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
        //
        SqlParameter MemberID = new SqlParameter("@MemberID", SqlDbType.BigInt, 8);
        MemberID.Value = P_Int_MemberID;
        myCmd.Parameters.Add(MemberID);
        //
        SqlParameter CartID = new SqlParameter("@CartID", SqlDbType.BigInt, 8);
        CartID.Value = P_Int_CartID;
        myCmd.Parameters.Add(CartID);
        //
        SqlParameter Num = new SqlParameter("@Num", SqlDbType.BigInt, 8);
        Num.Value = P_Int_Num;
        myCmd.Parameters.Add(Num);
        //
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
    //*****************************************************************************************
    public void ddlCityBind(DropDownList ddlName)
    {
     SqlConnection myConn=dbObj.GetConnection();
     string P_Str_Sqlstr="select * from tb_Area";
     SqlDataAdapter da = new SqlDataAdapter(P_Str_Sqlstr, myConn);
     DataSet ds = new DataSet();
     da.Fill(ds,"Area");
     ddlName.DataSource = ds.Tables["Area"].DefaultView;
     ddlName.DataTextField = ds.Tables["Area"].Columns[1].ToString();
     ddlName.DataValueField = ds.Tables["Area"].Columns[2].ToString();
     ddlName.DataBind();
    
    }
    public void ddlShipBind(DropDownList ddlName)
    {
        SqlConnection myConn = dbObj.GetConnection();
        string P_Str_Sqlstr = "select * from tb_ShipType";
        SqlDataAdapter da = new SqlDataAdapter(P_Str_Sqlstr, myConn);
        DataSet ds = new DataSet();
        da.Fill(ds, "Ship");
        ddlName.DataSource = ds.Tables["Ship"].DefaultView;
        ddlName.DataTextField = ds.Tables["Ship"].Columns[1].ToString();
        ddlName.DataValueField = ds.Tables["Ship"].Columns[0].ToString();
        ddlName.DataBind();  
    }
    public void ddlPayBind(DropDownList ddlName)
    {
        SqlConnection myConn = dbObj.GetConnection();
        string P_Str_Sqlstr = "select * from tb_PayType";
        SqlDataAdapter da = new SqlDataAdapter(P_Str_Sqlstr, myConn);
        DataSet ds = new DataSet();
        da.Fill(ds, "Pay");
        ddlName.DataSource = ds.Tables["Pay"].DefaultView;
        ddlName.DataTextField = ds.Tables["Pay"].Columns[1].ToString();
        ddlName.DataValueField = ds.Tables["Pay"].Columns[0].ToString();
        ddlName.DataBind();   
    }
    public int AddOrderInfo(float P_Flt_GoodsFee, float P_Flt_ShipFee, int P_Int_ShipType, int P_Int_PayType, int P_Int_MemberID, string P_Str_RName, string P_Str_RPhone, string P_Str_RPostCode, string P_Str_RAddress, string P_Str_REmails)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_InsertOrderInfo", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;

        //
        SqlParameter GoodsFee = new SqlParameter("@GoodsFee", SqlDbType.Float, 8);
        GoodsFee.Value = P_Flt_GoodsFee;
        myCmd.Parameters.Add(GoodsFee);
        //
        SqlParameter ShipFee = new SqlParameter("@ShipFee", SqlDbType.Float , 8);
        ShipFee.Value = P_Flt_ShipFee;
        myCmd.Parameters.Add(ShipFee);
        //
        SqlParameter ShipType = new SqlParameter("@ShipType", SqlDbType.Int,4);
        ShipType.Value = P_Int_ShipType;
        myCmd.Parameters.Add(ShipType);
        //
        SqlParameter PayType = new SqlParameter("@PayType", SqlDbType.Int, 4);
        PayType.Value = P_Int_PayType;
        myCmd.Parameters.Add(PayType);
        //
        SqlParameter MemberID = new SqlParameter("@MemberID ", SqlDbType.BigInt,8);
        MemberID.Value = P_Int_MemberID;
        myCmd.Parameters.Add(MemberID);
        //
        SqlParameter RName = new SqlParameter("@RName", SqlDbType.VarChar, 50);
        RName.Value = P_Str_RName;
        myCmd.Parameters.Add(RName);
        //
        SqlParameter RPhone = new SqlParameter("@RPhone", SqlDbType.VarChar, 50);
        RPhone.Value = P_Str_RPhone;
        myCmd.Parameters.Add(RPhone);
        //
        SqlParameter RPostCode = new SqlParameter("@RPostCode", SqlDbType.Char, 10);
        RPostCode.Value = P_Str_RPostCode;
        myCmd.Parameters.Add(RPostCode);
        //
        SqlParameter RAddress = new SqlParameter("@RAddress", SqlDbType.VarChar, 200);
        RAddress.Value = P_Str_RAddress;
        myCmd.Parameters.Add(RAddress);
        
        //
        SqlParameter REmails = new SqlParameter("@REmails", SqlDbType.VarChar, 50);
        REmails.Value = P_Str_REmails;
        myCmd.Parameters.Add(REmails);
        //
        SqlParameter OrderID = myCmd.Parameters.Add("@OrderID", SqlDbType.BigInt,8);
        OrderID.Direction = ParameterDirection.Output;
       
        //
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
        return Convert.ToInt32(OrderID.Value);
      

    }
    public void  AddBuyInfo(int P_Int_GoodsID, int P_Int_Num, int P_Int_OrderID, float  P_Flt_SumPrice, int P_Int_MemberID)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_InsertBuy", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
        //
        SqlParameter GoodsID = new SqlParameter("@GoodsID", SqlDbType.BigInt, 4);
        GoodsID.Value = P_Int_GoodsID;
        myCmd.Parameters.Add(GoodsID);
        //
        SqlParameter Num = new SqlParameter("@Num", SqlDbType.Int, 4);
        Num.Value = P_Int_Num;
        myCmd.Parameters.Add(Num);
        //
        SqlParameter OrderID = new SqlParameter("@OrderID", SqlDbType.BigInt, 8);
        OrderID.Value = P_Int_OrderID;
        myCmd.Parameters.Add(OrderID);
        //
        SqlParameter SumPrice = new SqlParameter("@SumPrice", SqlDbType.Float , 8);
        SumPrice.Value = P_Flt_SumPrice;
        myCmd.Parameters.Add(SumPrice);
        //
        SqlParameter MemberID = new SqlParameter("@MemberID ", SqlDbType.BigInt, 8);
        MemberID.Value = P_Int_MemberID;
        myCmd.Parameters.Add(MemberID);
        //
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
   
    public DataSet ReturnSCDs(int P_Int_MemberID, string P_Str_srcTable)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_GetSCI", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
        //
        SqlParameter MemberID = new SqlParameter("@MemberID", SqlDbType.BigInt, 8);
        MemberID.Value = P_Int_MemberID;
        myCmd.Parameters.Add(MemberID);
        //
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
    
    public void DeleteSCInfo(int P_Int_MemberID)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_DeleteSC", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
        //
        SqlParameter MemberID = new SqlParameter("@MemberID", SqlDbType.BigInt, 8);
        MemberID.Value = P_Int_MemberID;
        myCmd.Parameters.Add(MemberID);
        //
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
   
    public float  GetSFValue(int P_Int_GoodsID,string P_Str_ShipWay)
    {


        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_GSF", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
        //
        SqlParameter GoodsID = new SqlParameter("@GoodsID", SqlDbType.BigInt, 8);
        GoodsID.Value = P_Int_GoodsID;
        myCmd.Parameters.Add(GoodsID);
        //
        SqlParameter ShipWay = new SqlParameter("@ShipWay", SqlDbType.VarChar,50);
        ShipWay.Value = P_Str_ShipWay;
        myCmd.Parameters.Add(ShipWay);
        //
        SqlParameter returnValue = myCmd.Parameters.Add("returnvalue", SqlDbType.Float, 8);
        returnValue.Direction = ParameterDirection.ReturnValue;
        //
        myConn.Open();
        myCmd.ExecuteScalar();
        try
        { 
            if (Convert.ToInt32(returnValue.Value) == 100)
                return 100;
            else
            { 
                float  P_Flt_SF=float.Parse(myCmd.ExecuteScalar().ToString());
                return P_Flt_SF;
            }
        
        }
        catch(Exception ex)
        {
            throw (ex);
        
        }
        finally
        {
         myCmd.Dispose();
        myConn.Close();
        
        }
        
    }
    
    public int  IsUserCart(int P_Int_MemberID, float P_Flt_GoodsFee, float P_Flt_ShipFee)
    {
        SqlConnection myConn = dbObj.GetConnection();
        SqlCommand myCmd = new SqlCommand("Proc_IsUserCart", myConn);
        myCmd.CommandType = CommandType.StoredProcedure;
        //
        SqlParameter MemberID = new SqlParameter("@MemberID", SqlDbType.BigInt, 8);
        MemberID.Value = P_Int_MemberID;
        myCmd.Parameters.Add(MemberID);
        //
        SqlParameter GoodsFee = new SqlParameter("@GoodsFee", SqlDbType.Float, 8);
        GoodsFee.Value = P_Flt_GoodsFee;
        myCmd.Parameters.Add(GoodsFee);
        //
        SqlParameter ShipFee = new SqlParameter("@ShipFee", SqlDbType.Float , 8);
        ShipFee.Value = P_Flt_ShipFee;
        myCmd.Parameters.Add(ShipFee);
        //
        SqlParameter returnValue = myCmd.Parameters.Add("returnvalue", SqlDbType.Float , 8);
        returnValue.Direction=ParameterDirection.ReturnValue;
        //
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
        return int.Parse(returnValue.Value.ToString());
       
    }
    
    public string VarStr(string sString, int nLeng)
    {
        int index = sString.IndexOf(".");
        if (index == -1 || index + 2 >= sString.Length)
            return sString;
        else
            return sString.Substring(0, (index + nLeng + 1));
    }


}
