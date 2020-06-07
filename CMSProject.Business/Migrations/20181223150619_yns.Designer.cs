﻿// <auto-generated />
using System;
using CMSProject.Business.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CMSProject.Business.Migrations
{
    [DbContext(typeof(CMSContext))]
    [Migration("20181223150619_yns")]
    partial class yns
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CMSProject.Domain.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .IsRequired();

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("CMSProject.Domain.Entities.Layout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Layouts");
                });

            modelBuilder.Entity("CMSProject.Domain.Entities.LayoutComponent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ComponentClass")
                        .IsRequired();

                    b.Property<DateTime>("CreateTime");

                    b.Property<int>("LayoutId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Size")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("LayoutId");

                    b.ToTable("LayoutComponents");
                });

            modelBuilder.Entity("CMSProject.Domain.Entities.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FromId");

                    b.Property<string>("MessageText")
                        .IsRequired();

                    b.Property<int>("ToId");

                    b.HasKey("MessageId");

                    b.HasIndex("FromId");

                    b.HasIndex("ToId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("CMSProject.Domain.Entities.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate");

                    b.Property<int>("LayoutId");

                    b.Property<string>("PostText");

                    b.Property<int>("SubCategoryId");

                    b.Property<int>("UserId");

                    b.HasKey("PostId");

                    b.HasIndex("LayoutId");

                    b.HasIndex("SubCategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("CMSProject.Domain.Entities.PostComment", b =>
                {
                    b.Property<int>("PostCommentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CommentText")
                        .IsRequired();

                    b.Property<DateTime>("CreateDate");

                    b.Property<int>("PostId");

                    b.Property<int>("UserId");

                    b.HasKey("PostCommentId");

                    b.HasIndex("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("PostComments");
                });

            modelBuilder.Entity("CMSProject.Domain.Entities.PostDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("PostHtml")
                        .IsRequired();

                    b.Property<int>("PostId");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.ToTable("PostDetails");
                });

            modelBuilder.Entity("CMSProject.Domain.Entities.PostImage", b =>
                {
                    b.Property<int>("PostImageId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image");

                    b.Property<int>("PostId");

                    b.HasKey("PostImageId");

                    b.HasIndex("PostId");

                    b.ToTable("PostImages");
                });

            modelBuilder.Entity("CMSProject.Domain.Entities.PostTag", b =>
                {
                    b.Property<int>("PostId");

                    b.Property<int>("TagId");

                    b.HasKey("PostId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("PostTags");
                });

            modelBuilder.Entity("CMSProject.Domain.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoleName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("CMSProject.Domain.Entities.SubCategory", b =>
                {
                    b.Property<int>("SubCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<string>("SubCategoryName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("SubCategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("SubCategories");
                });

            modelBuilder.Entity("CMSProject.Domain.Entities.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TagName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("TagId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("CMSProject.Domain.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Photo")
                        .HasMaxLength(100);

                    b.Property<int>("RoleId");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("UserId");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CMSProject.Domain.Entities.LayoutComponent", b =>
                {
                    b.HasOne("CMSProject.Domain.Entities.Layout", "Layout")
                        .WithMany("LayoutComponents")
                        .HasForeignKey("LayoutId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CMSProject.Domain.Entities.Message", b =>
                {
                    b.HasOne("CMSProject.Domain.Entities.User", "FromUser")
                        .WithMany("FromMessage")
                        .HasForeignKey("FromId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CMSProject.Domain.Entities.User", "ToUser")
                        .WithMany("ToMessage")
                        .HasForeignKey("ToId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CMSProject.Domain.Entities.Post", b =>
                {
                    b.HasOne("CMSProject.Domain.Entities.Layout", "Layout")
                        .WithMany("Posts")
                        .HasForeignKey("LayoutId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CMSProject.Domain.Entities.SubCategory", "SubCategory")
                        .WithMany("Posts")
                        .HasForeignKey("SubCategoryId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CMSProject.Domain.Entities.User", "User")
                        .WithMany("Posts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CMSProject.Domain.Entities.PostComment", b =>
                {
                    b.HasOne("CMSProject.Domain.Entities.Post", "Post")
                        .WithMany("PostComments")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CMSProject.Domain.Entities.User", "User")
                        .WithMany("PostComments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CMSProject.Domain.Entities.PostDetail", b =>
                {
                    b.HasOne("CMSProject.Domain.Entities.Post", "Post")
                        .WithMany()
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CMSProject.Domain.Entities.PostImage", b =>
                {
                    b.HasOne("CMSProject.Domain.Entities.Post", "Post")
                        .WithMany("PostImages")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CMSProject.Domain.Entities.PostTag", b =>
                {
                    b.HasOne("CMSProject.Domain.Entities.Post", "Post")
                        .WithMany()
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CMSProject.Domain.Entities.Tag", "Tag")
                        .WithMany()
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CMSProject.Domain.Entities.SubCategory", b =>
                {
                    b.HasOne("CMSProject.Domain.Entities.Category", "Category")
                        .WithMany("SubCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CMSProject.Domain.Entities.User", b =>
                {
                    b.HasOne("CMSProject.Domain.Entities.Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
