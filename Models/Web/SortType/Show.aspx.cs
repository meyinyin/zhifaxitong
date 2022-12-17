﻿using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
namespace Maticsoft.Web.SortType
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					int ID=(Convert.ToInt32(strid));
					ShowInfo(ID);
				}
			}
		}
		
	private void ShowInfo(int ID)
	{
		Maticsoft.BLL.SortType bll=new Maticsoft.BLL.SortType();
		Maticsoft.Model.SortType model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblName.Text=model.Name;
		this.lblUrl.Text=model.Url;
		this.lblIsLock.Text=model.IsLock?"是":"否";
		this.lblSiteID.Text=model.SiteID.ToString();

	}


    }
}
