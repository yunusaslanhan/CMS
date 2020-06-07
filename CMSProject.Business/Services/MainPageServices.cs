using CMSProject.Business.Context;
using CMSProject.Business.Services.Interfaces;
using CMSProject.Common.Dtos;
using CMSProject.Domain.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMSProject.Business.Services
{
	public class MainPageServices: IMainPageServices
	{
		private CMSContext _dbContext;
		public const string OPEN_MAIN_LIST_TAG = "<li class=\"classic-menu-dropdown\">";
		public const string CLOSE_MAIN_LIST_TAG = "</li>";
		public const string OPEN_MAIN_LIST_LINK_TAG = "<a href=\"/User/MainPagePost/";
		public const string CLOSE_MAIN_LIST_LINK = "/\">";
		public const string CLOSE_MAIN_LIST_LINK_TAG = "</a>";
		public const string OPEN_MAIN_LIST_ICON_TAG = "<i class=\"fa fa-angle-down\"></i>";
		public const string OPEN_SUBPAGE_LIST_TAG = "<ul class=\"dropdown-menu pull-left\">";
		public const string CLOSE_SUBPAGE_LIST_TAG = "</ul>";
		public const string OPEN_SUBPAGE_MORE_LIST_TAG = "<li class=\"dropdown-submenu\">";
		public const string CLOSE_SUBPAGE_MORE_LIST_TAG = "</li>";
		public const string OPEN_LIST_ITEM_TAG = "<li>";
		public const string CLOSE_LIST_ITEM_TAG = "</li>";
		public const string OPEN_SUBPAGE_UL_TAG = "<ul class=\"dropdown-menu\">";



		public MainPageServices(CMSContext dbContext)
		{
			_dbContext = dbContext;
		}


		public List<MainPageDto> GetMainPageList() {

			var model = _dbContext.MainPages.Select(m => new MainPageDto
			{
				Id=m.Id,
				Name=m.Name,
				ParentId=m.ParentId,
				CreateDate=m.CreateDate
				

			}).ToList();

			return model;
			

		}


		public void AddPage(int ParentId, string Name) {


			_dbContext.MainPages.Add(new MainPage {

				Name=Name,
				ParentId=ParentId,
				CreateDate=DateTime.Now

			}
			);

			_dbContext.SaveChanges();
		}



		public string GenerateMenuUi()
		{
			List<MainPageDto> dto = GetMainPageList();
			var strBuilder = new StringBuilder();
			List<MainPageDto> parentItems = (from a in dto where a.ParentId == 0 select a).ToList();

			foreach (var parentcat in parentItems)
			{

				List<MainPageDto> childItems = (from a in dto where a.ParentId == parentcat.Id select a).ToList();
				if (childItems.Count > 0)
				{

					strBuilder.Append(OPEN_MAIN_LIST_TAG);
					strBuilder.Append(OPEN_MAIN_LIST_LINK_TAG);
					strBuilder.Append(parentcat.Id);
					strBuilder.Append(CLOSE_MAIN_LIST_LINK);
					strBuilder.Append(parentcat.Name);
					strBuilder.Append(OPEN_MAIN_LIST_ICON_TAG);
					strBuilder.Append(CLOSE_MAIN_LIST_LINK_TAG);
					strBuilder.Append(OPEN_SUBPAGE_LIST_TAG);
					AddChildItem(parentcat, strBuilder);
					strBuilder.Append(CLOSE_SUBPAGE_LIST_TAG);

				}
				else
				{
					strBuilder.Append(OPEN_MAIN_LIST_TAG);
					strBuilder.Append(OPEN_MAIN_LIST_LINK_TAG);
					strBuilder.Append(parentcat.Id);
					strBuilder.Append(CLOSE_MAIN_LIST_LINK);
					strBuilder.Append(parentcat.Name);

				}
				strBuilder.Append(CLOSE_MAIN_LIST_LINK_TAG);
				strBuilder.Append(CLOSE_MAIN_LIST_TAG);
			}
			return strBuilder.ToString();
		}

		public void AddChildItem(MainPageDto childItem, StringBuilder strBuilder)
		{
			List<MainPageDto> dto = GetMainPageList();

			List<MainPageDto> childItems = (from a in dto where a.ParentId == childItem.Id select a).ToList();
			foreach (MainPageDto cItem in childItems)
			{

				List<MainPageDto> subChilds = (from a in dto where a.ParentId == cItem.Id select a).ToList();
				if (subChilds.Count > 0)
				{
					strBuilder.Append(OPEN_SUBPAGE_MORE_LIST_TAG);
					strBuilder.Append(OPEN_MAIN_LIST_LINK_TAG);
					strBuilder.Append(cItem.Id);
					strBuilder.Append(CLOSE_MAIN_LIST_LINK);
					strBuilder.Append(cItem.Name);
					strBuilder.Append(CLOSE_MAIN_LIST_LINK_TAG);
					strBuilder.Append(OPEN_SUBPAGE_UL_TAG);
					AddChildItem(cItem, strBuilder);
					strBuilder.Append(CLOSE_SUBPAGE_LIST_TAG);
					strBuilder.Append(CLOSE_SUBPAGE_MORE_LIST_TAG);
				}
				else
				{
					strBuilder.Append(OPEN_LIST_ITEM_TAG);
					strBuilder.Append(OPEN_MAIN_LIST_LINK_TAG);
					strBuilder.Append(cItem.Id);
					strBuilder.Append(CLOSE_MAIN_LIST_LINK);
					strBuilder.Append(cItem.Name);
					strBuilder.Append(CLOSE_MAIN_LIST_LINK_TAG);
					strBuilder.Append(CLOSE_LIST_ITEM_TAG);
				}
			}
		}

	}


}

