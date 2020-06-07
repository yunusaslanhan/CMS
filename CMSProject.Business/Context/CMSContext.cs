using CMSProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMSProject.Business.Context
{
	public class CMSContext:DbContext
	{

		public CMSContext(DbContextOptions<CMSContext> options=null) :base(options)
		{
				
		}


		public virtual DbSet<User> Users { get; set; }
		public virtual DbSet<Post> Posts { get; set; }
		public virtual DbSet<Message> Messages { get; set; }
		public virtual DbSet<PostComment> PostComment { get; set; }
		public virtual DbSet<Category> Categories { get; set; }
		public virtual DbSet<SubCategory> SubCategories  { get; set; }
		public virtual DbSet<Role> Roles { get; set; }
		public virtual DbSet<PostImage> PostImages { get; set; }
		public virtual DbSet<Tag> Tags { get; set; }
		public virtual DbSet<PostTag> PostTags { get; set; }
		public virtual DbSet<Layout> Layouts { get; set; }
		public virtual DbSet<PostDetail> PostDetails { get; set; }
		public virtual DbSet<LayoutComponent> LayoutComponents { get; set; }
		public virtual DbSet<MainPage> MainPages { get; set; }

	




		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{

			
			modelBuilder.Entity<PostTag>().HasKey(p => new { p.PostId, p.TagId });


			foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
			{
				relationship.DeleteBehavior = DeleteBehavior.Restrict;
			}

		}



	}
}
