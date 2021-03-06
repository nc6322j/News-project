// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using News.Data;

namespace News.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Roles");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityRole");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "6867eb2e-97d5-4e59-861f-084da5e14b78",
                            RoleId = "480ea624-c060-4a0a-90b0-52ed63ea0b0b"
                        },
                        new
                        {
                            UserId = "dda7d159-2259-4a5f-93a2-fbec16fb5025",
                            RoleId = "0a532d3b-e73b-48f9-b680-d0da02a2c004"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("News.Entities.Categories", b =>
                {
                    b.Property<string>("category_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("category_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("category_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("category_Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            category_Id = "7cc1c8a5-5211-4322-a4f2-16a5db0cf5d1",
                            IsDelete = false,
                            category_Description = "Des 1",
                            category_Name = "Category1"
                        },
                        new
                        {
                            category_Id = "c5b05389-ada6-49a9-9e1c-f31896e9222c",
                            IsDelete = false,
                            category_Description = "Des 2",
                            category_Name = "Category2"
                        },
                        new
                        {
                            category_Id = "01105ae7-ca01-4c01-a2a9-ad6a41fedbfc",
                            IsDelete = false,
                            category_Description = "Des 3",
                            category_Name = "Category3"
                        });
                });

            modelBuilder.Entity("News.Entities.Comments", b =>
                {
                    b.Property<string>("cmt_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("cmt_Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cmt_IdeaId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("cmt_UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("cmt_UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("cmt_Id");

                    b.HasIndex("cmt_IdeaId");

                    b.HasIndex("cmt_UserId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            cmt_Id = "4092f78b-b23b-41cd-be3c-2f712179d3df",
                            IsDelete = false,
                            cmt_Content = "Comment1",
                            cmt_IdeaId = "ef73d406-43ce-4535-8f1d-ff809e273b8a",
                            cmt_UpdateDate = new DateTime(2022, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            cmt_UserId = "dda7d159-2259-4a5f-93a2-fbec16fb5025"
                        },
                        new
                        {
                            cmt_Id = "f2fe5e80-5a12-42f9-a21b-4fa427a8cd3b",
                            IsDelete = false,
                            cmt_Content = "Comment2",
                            cmt_IdeaId = "ef73d406-43ce-4535-8f1d-ff809e273b8a",
                            cmt_UpdateDate = new DateTime(2022, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            cmt_UserId = "6867eb2e-97d5-4e59-861f-084da5e14b78"
                        },
                        new
                        {
                            cmt_Id = "c2123b52-5f7d-4a8f-b79b-d33ad17f63c9",
                            IsDelete = false,
                            cmt_Content = "Comment3",
                            cmt_IdeaId = "ef73d406-43ce-4535-8f1d-ff809e273b8a",
                            cmt_UpdateDate = new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            cmt_UserId = "dda7d159-2259-4a5f-93a2-fbec16fb5025"
                        });
                });

            modelBuilder.Entity("News.Entities.ContactEmail", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ContactEmail");

                    b.HasData(
                        new
                        {
                            Id = "d621be59-43b8-458e-a773-7ab64d14e650",
                            Email = "Email Test",
                            Message = "Message Test",
                            Name = "Name Test",
                            Subject = "Subject Test"
                        });
                });

            modelBuilder.Entity("News.Entities.Department", b =>
                {
                    b.Property<string>("department_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("department_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("department_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("department_Id");

                    b.ToTable("Department");

                    b.HasData(
                        new
                        {
                            department_Id = "8473b4f0-c67b-4700-be8c-e009df09ffcb",
                            IsDelete = false,
                            department_Description = "Department 1",
                            department_Name = "Department 1"
                        },
                        new
                        {
                            department_Id = "c089d62f-0225-4a27-a190-3bfe58a1b122",
                            IsDelete = false,
                            department_Description = "Department 2",
                            department_Name = "Department 2 "
                        },
                        new
                        {
                            department_Id = "161a20ef-d107-4f00-8418-fedd02dbb85c",
                            IsDelete = false,
                            department_Description = "Department 3",
                            department_Name = "Department 3"
                        });
                });

            modelBuilder.Entity("News.Entities.Idea", b =>
                {
                    b.Property<string>("idea_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<bool>("idea_Agree")
                        .HasColumnType("bit");

                    b.Property<string>("idea_CategoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("idea_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("idea_ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("idea_ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("idea_SubmissionId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("idea_Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("idea_UpdateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("idea_UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("idea_View")
                        .HasColumnType("int");

                    b.HasKey("idea_Id");

                    b.HasIndex("idea_CategoryId");

                    b.HasIndex("idea_SubmissionId");

                    b.HasIndex("idea_UserId");

                    b.ToTable("Idea");

                    b.HasData(
                        new
                        {
                            idea_Id = "ef73d406-43ce-4535-8f1d-ff809e273b8a",
                            IsDelete = false,
                            idea_Agree = false,
                            idea_CategoryId = "7cc1c8a5-5211-4322-a4f2-16a5db0cf5d1",
                            idea_Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Beatae ipsum non voluptatum eum repellendus quod aliquid. Vitae, dolorum voluptate quis repudiandae eos molestiae dolores enim. ",
                            idea_ImageName = "blog-1.png",
                            idea_SubmissionId = "e1f215c5-53a8-49a3-9c26-2f18a6bf979e",
                            idea_Title = "Title1",
                            idea_UpdateTime = new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            idea_UserId = "6867eb2e-97d5-4e59-861f-084da5e14b78",
                            idea_View = 0
                        },
                        new
                        {
                            idea_Id = "f8a89a18-56f6-4c84-90ab-f3df95cf02b9",
                            IsDelete = false,
                            idea_Agree = false,
                            idea_CategoryId = "c5b05389-ada6-49a9-9e1c-f31896e9222c",
                            idea_Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Beatae ipsum non voluptatum eum repellendus quod aliquid. Vitae, dolorum voluptate quis repudiandae eos molestiae dolores enim. ",
                            idea_ImageName = "blog-2.png",
                            idea_SubmissionId = "e1f215c5-53a8-49a3-9c26-2f18a6bf979e",
                            idea_Title = "Title2",
                            idea_UpdateTime = new DateTime(2022, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            idea_UserId = "6867eb2e-97d5-4e59-861f-084da5e14b78",
                            idea_View = 0
                        },
                        new
                        {
                            idea_Id = "5b4e9f64-d78b-4c2a-b11c-962665caf499",
                            IsDelete = false,
                            idea_Agree = false,
                            idea_CategoryId = "c5b05389-ada6-49a9-9e1c-f31896e9222c",
                            idea_Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Beatae ipsum non voluptatum eum repellendus quod aliquid. Vitae, dolorum voluptate quis repudiandae eos molestiae dolores enim. ",
                            idea_ImageName = "blog-3.png",
                            idea_SubmissionId = "e1f215c5-53a8-49a3-9c26-2f18a6bf979e",
                            idea_Title = "Title3",
                            idea_UpdateTime = new DateTime(2022, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            idea_UserId = "dda7d159-2259-4a5f-93a2-fbec16fb5025",
                            idea_View = 0
                        });
                });

            modelBuilder.Entity("News.Entities.LikeInIdea", b =>
                {
                    b.Property<string>("likeInIdea_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("likeInIdea_CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("likeInIdea_DisLike")
                        .HasColumnType("bit");

                    b.Property<string>("likeInIdea_IdeaId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("likeInIdea_Like")
                        .HasColumnType("bit");

                    b.Property<string>("likeInIdea_UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("likeInIdea_Id");

                    b.HasIndex("likeInIdea_IdeaId");

                    b.HasIndex("likeInIdea_UserId");

                    b.ToTable("LikeInIdea");
                });

            modelBuilder.Entity("News.Entities.Submission", b =>
                {
                    b.Property<string>("submission_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("submission_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("submission_DueTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("submission_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("submission_StartTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("submission_UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("submission_Id");

                    b.HasIndex("submission_UserId");

                    b.ToTable("Submission");

                    b.HasData(
                        new
                        {
                            submission_Id = "e1f215c5-53a8-49a3-9c26-2f18a6bf979e",
                            IsDelete = false,
                            submission_Description = "Submission1",
                            submission_DueTime = new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            submission_Name = "Submission1",
                            submission_StartTime = new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("News.Entities.UserInDepartment", b =>
                {
                    b.Property<string>("uid_UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("uid_DepartmentId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("uid_UserId", "uid_DepartmentId");

                    b.HasIndex("uid_DepartmentId");

                    b.ToTable("UserInDepartment");

                    b.HasData(
                        new
                        {
                            uid_UserId = "dda7d159-2259-4a5f-93a2-fbec16fb5025",
                            uid_DepartmentId = "8473b4f0-c67b-4700-be8c-e009df09ffcb"
                        },
                        new
                        {
                            uid_UserId = "6867eb2e-97d5-4e59-861f-084da5e14b78",
                            uid_DepartmentId = "c089d62f-0225-4a27-a190-3bfe58a1b122"
                        });
                });

            modelBuilder.Entity("News.Models.DetailIdeaModels", b =>
                {
                    b.Property<string>("idea_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("idea_CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("idea_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("idea_ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("idea_SubmissionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("idea_Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("idea_UpdateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("idea_UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idea_Id");

                    b.ToTable("DetailIdeaModels");
                });

            modelBuilder.Entity("News.Entities.AppRole", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityRole");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.HasDiscriminator().HasValue("AppRole");

                    b.HasData(
                        new
                        {
                            Id = "480ea624-c060-4a0a-90b0-52ed63ea0b0b",
                            ConcurrencyStamp = "fe6793ae-a1c4-44f3-832e-83287db71b88",
                            Name = "staff",
                            Description = "Staff",
                            IsDelete = false
                        },
                        new
                        {
                            Id = "0a532d3b-e73b-48f9-b680-d0da02a2c004",
                            ConcurrencyStamp = "f7939964-eadd-44db-8478-bdf8794dbdb0",
                            Name = "admin",
                            Description = "Admin",
                            IsDelete = false
                        });
                });

            modelBuilder.Entity("News.Entities.AppUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<DateTime>("DoB")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("AppUser");

                    b.HasData(
                        new
                        {
                            Id = "dda7d159-2259-4a5f-93a2-fbec16fb5025",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0f3e59a9-28a7-4f45-ab4a-f53d62fe9e33",
                            Email = "admin@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEA7g+vaSU0XcRlJF74853gkwnK1b64wR+jqR9hMpL3zMC/RC81pkcJgQnbPzoZDgYA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "27cf68fe-3903-4bd3-8774-2dbe55368007",
                            TwoFactorEnabled = false,
                            UserName = "Admin",
                            DoB = new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDelete = false,
                            LastName = "Admin"
                        },
                        new
                        {
                            Id = "6867eb2e-97d5-4e59-861f-084da5e14b78",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d578bbee-f9b1-4ab0-9e0d-553796e6617e",
                            Email = "staff@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "STAFF@GMAIL.COM",
                            NormalizedUserName = "STAFF@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEJlpbBe+S87C5ge09r5UGvvoCIgHjuDRECFSTILeiTlzjzM6r48fUItOvxwVsveYFA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "5c854b3a-8a5e-4bd1-a9db-d07a7d53358b",
                            TwoFactorEnabled = false,
                            UserName = "Staff",
                            DoB = new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDelete = false,
                            LastName = "Staff"
                        },
                        new
                        {
                            Id = "3bfd0a16-fe23-4ec5-820f-032d72e1ce0e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2bdeddb3-42b4-48cb-a6ea-f34e2bb8a004",
                            Email = "staff2@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "STAFF2@GMAIL.COM",
                            NormalizedUserName = "STAFF2@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEJ819avuZ5dO/OzS2vvwGJcoblq2JiCnHwgmqNDAQkTh7QnCTJTYu8b1PQGlUGTtug==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "6bf85846-b259-4ec8-b7ba-0ca6ecf2058a",
                            TwoFactorEnabled = false,
                            UserName = "Staff2",
                            DoB = new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDelete = false,
                            LastName = "Staff2"
                        },
                        new
                        {
                            Id = "22bfd1d0-2d45-4f3a-8e6c-67b60fce775e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "32b97571-2b85-4397-b4f9-58ede59680d1",
                            Email = "anonymous@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ANOYMOUS@GMAIL.COM",
                            NormalizedUserName = "ANOYMOUS@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEGqLpHb3pRK1bsQm/4SV0Hv2xDJUlPJTbhKhpXKYiMgNSBZ9G74bEuX4ujd8amPTNQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ae558c7f-d39e-4b2c-9fd4-3104d6b7bb30",
                            TwoFactorEnabled = false,
                            UserName = "Anonymous",
                            DoB = new DateTime(2022, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDelete = false,
                            LastName = "Anonymous"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("News.Entities.Comments", b =>
                {
                    b.HasOne("News.Entities.Idea", "IdeaFk")
                        .WithMany("Comments")
                        .HasForeignKey("cmt_IdeaId");

                    b.HasOne("News.Entities.AppUser", "AppUserFk")
                        .WithMany("Comments")
                        .HasForeignKey("cmt_UserId");

                    b.Navigation("AppUserFk");

                    b.Navigation("IdeaFk");
                });

            modelBuilder.Entity("News.Entities.Idea", b =>
                {
                    b.HasOne("News.Entities.Categories", "categoriesFK")
                        .WithMany("IdeaList")
                        .HasForeignKey("idea_CategoryId");

                    b.HasOne("News.Entities.Submission", "submissionFK")
                        .WithMany("IdeaList")
                        .HasForeignKey("idea_SubmissionId");

                    b.HasOne("News.Entities.AppUser", "appUserFK")
                        .WithMany("ideasList")
                        .HasForeignKey("idea_UserId");

                    b.Navigation("appUserFK");

                    b.Navigation("categoriesFK");

                    b.Navigation("submissionFK");
                });

            modelBuilder.Entity("News.Entities.LikeInIdea", b =>
                {
                    b.HasOne("News.Entities.Idea", "Idea")
                        .WithMany("likeInIdea")
                        .HasForeignKey("likeInIdea_IdeaId");

                    b.HasOne("News.Entities.AppUser", "AppUser")
                        .WithMany("likeInIdea")
                        .HasForeignKey("likeInIdea_UserId");

                    b.Navigation("AppUser");

                    b.Navigation("Idea");
                });

            modelBuilder.Entity("News.Entities.Submission", b =>
                {
                    b.HasOne("News.Entities.AppUser", "userFK")
                        .WithMany("Submission")
                        .HasForeignKey("submission_UserId");

                    b.Navigation("userFK");
                });

            modelBuilder.Entity("News.Entities.UserInDepartment", b =>
                {
                    b.HasOne("News.Entities.Department", "DepartmentFK")
                        .WithMany("userInDepartmentsList")
                        .HasForeignKey("uid_DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("News.Entities.AppUser", "AppUserFK")
                        .WithMany("userInDepartmentsList")
                        .HasForeignKey("uid_UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUserFK");

                    b.Navigation("DepartmentFK");
                });

            modelBuilder.Entity("News.Entities.Categories", b =>
                {
                    b.Navigation("IdeaList");
                });

            modelBuilder.Entity("News.Entities.Department", b =>
                {
                    b.Navigation("userInDepartmentsList");
                });

            modelBuilder.Entity("News.Entities.Idea", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("likeInIdea");
                });

            modelBuilder.Entity("News.Entities.Submission", b =>
                {
                    b.Navigation("IdeaList");
                });

            modelBuilder.Entity("News.Entities.AppUser", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("ideasList");

                    b.Navigation("likeInIdea");

                    b.Navigation("Submission");

                    b.Navigation("userInDepartmentsList");
                });
#pragma warning restore 612, 618
        }
    }
}
