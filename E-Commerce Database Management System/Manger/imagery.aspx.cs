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

public partial class Manger_imagegallery : System.Web.UI.Page
{
    MangerClass mcObj = new MangerClass();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            lbIamge.Visible = false;
            gvImageBind();
        }
    }
    public void gvImageBind()
    {
        DataSet ds = mcObj.ReturnImagerDs("ImageInfo");
        dlImage.DataSource = ds.Tables["ImageInfo"].DefaultView;
        dlImage.DataBind();
    }
    protected void UploadImage_OnClick(object sender, EventArgs e)
    {    
        try
        {
            lbIamge.Visible = true;
            if (imageUpload.PostedFile.FileName == "")
            {
                lbIamge.Text = "You cannot upload null document!";
                return;
            }
            else
            {
                string filePath = imageUpload.PostedFile.FileName;
                string filename = filePath.Substring(filePath.LastIndexOf("\\") + 1);
                string serverpath = Server.MapPath(@"~\Images\ftp\") + filename;
                string relativepath = @"~\Images\ftp\"+filename;
                imageUpload.PostedFile.SaveAs(serverpath);
                lbIamge.Text = "Upload successfully!";
                mcObj.InsertImage(filename, relativepath);
                gvImageBind();
            }
        
        }
        catch (Exception error)
        {
            lbIamge.Text = "Error: " + error.ToString();
        }

    }
    protected void dlImage_DeleteCommand(object source, DataListCommandEventArgs e)
    {
        mcObj.DeleteImage(Convert.ToInt32(dlImage.DataKeys[e.Item.ItemIndex].ToString()));
        gvImageBind();
    }
}
