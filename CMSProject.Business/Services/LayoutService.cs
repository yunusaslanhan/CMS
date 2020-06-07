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
	public class LayoutService:ILayoutService
	{
		private CMSContext _dbContext;

		public LayoutService(CMSContext dbContext)
		{
			_dbContext = dbContext;
		}


		public void SaveLayout(LayoutDto layoutDto) {

			var model =_dbContext.Layouts.Add(new Layout
			{
				Name = layoutDto.Name,
				CreateDate = DateTime.Now

			});

			foreach (var item in layoutDto.layoutComponentDtos)
			{
				_dbContext.LayoutComponents.Add(new LayoutComponent
				{
					LayoutId = model.Entity.Id,
					Size = item.Size,
					Name = item.Name,
					CreateTime = DateTime.Now,
					ComponentClass=item.ComponentClass
					
				});

			}



			_dbContext.SaveChanges();

		}


		public List<LayoutDto> GetLayoutList() {

			var model = _dbContext.Layouts.Select(l => new LayoutDto
			{
				Id=l.Id,
				Name=l.Name,
				CreateDate=l.CreateDate



			}).ToList();

			return model;
			

		}
		public List<LayoutComponentDto> GetLayoutComponentList(int LayoutId)
		{

			var model = _dbContext.LayoutComponents.Where(l=>l.LayoutId==LayoutId).Select(l => new LayoutComponentDto
			{
				Id = l.Id,
				LayoutId=l.LayoutId,
				Name =l.Name,
				CreateTime=l.CreateTime,
				Size=l.Size,
				ComponentClass=l.ComponentClass
				

			}).ToList();

			return model;


		}




	}


	}

