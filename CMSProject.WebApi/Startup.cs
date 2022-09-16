﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMSProject.Business.Context;
using CMSProject.Business.Services;
using CMSProject.Business.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace CMSProject.WebApi
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddHttpContextAccessor();

			services.AddDbContext<CMSContext>(options =>
			{
				options.UseSqlServer("Server=.;Database=CMSProjectDB;Trusted_Connection=True;");

			});

			services.AddTransient<ILayoutService, LayoutService>();
			services.AddTransient<IPostServices, PostServices>();
			services.AddTransient<IMainPageServices, MainPageServices>();

			services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseHsts();
			}
			app.UseCors(x => x.AllowAnyHeader().AllowAnyOrigin().AllowCredentials());
			app.UseHttpsRedirection();
			app.UseMvc();
		}
	}
}