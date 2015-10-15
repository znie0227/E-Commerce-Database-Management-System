using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
///
/// </summary>
public class CommonProperty
{
    public int OrderNo;  
    public DateTime OrderTime;
    public float  ProductPrice;
    public float ShipPrice;
    public float TotalPrice;
    public string BuyerName;
    public string BuyerPhone;
    public string BuyerEmail;
    public string BuyerAddress;
    public string BuyerPostalcode;
    public string ReceiverName;
    public string ReceiverPhone;
    public string ReceiverEmail;
    public string ReceiverAddress;
    public string ReceiverPostalcode;
    public int ShipType;
    public int PayType;
   

	public CommonProperty()
	{
		//
		// 
		//
	}
    
}
