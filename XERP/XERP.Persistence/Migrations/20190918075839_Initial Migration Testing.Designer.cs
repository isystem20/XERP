﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using XERP.Persistence;

namespace XERP.Persistence.Migrations
{
    [DbContext(typeof(XERPDbContext))]
    [Migration("20190918075839_Initial Migration Testing")]
    partial class InitialMigrationTesting
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("XERP.Domain.Entities.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ActivationCode");

                    b.Property<string>("ClientId");

                    b.Property<string>("CompanyId");

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedById");

                    b.Property<string>("Email");

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("EmployeeId");

                    b.Property<DateTime>("LastModifiedAt");

                    b.Property<string>("LastModifiedById");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTime>("LockoutEnd");

                    b.Property<string>("NormalizedEmail");

                    b.Property<string>("NormalizedUserName");

                    b.Property<string>("PasswordHash");

                    b.Property<bool>("PasswordNeverExpires");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("Remarks");

                    b.Property<string>("SecurityHash");

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("Status");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<bool>("UserCantChangePassword");

                    b.Property<bool>("UserChangePasswordNextLogon");

                    b.Property<string>("UserCode");

                    b.Property<string>("UserName");

                    b.Property<int>("VersionNo");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("ApplicationUsers");
                });

            modelBuilder.Entity("XERP.Domain.Entities.Common.Company", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("CompanyAddress");

                    b.Property<string>("CompanyName");

                    b.Property<string>("ContactPersons");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedById");

                    b.Property<string>("Description");

                    b.Property<string>("Designation");

                    b.Property<int?>("IndustriesId");

                    b.Property<string>("IndustryId");

                    b.Property<DateTime>("LastModifiedAt");

                    b.Property<string>("LastModifiedById");

                    b.Property<string>("Status");

                    b.Property<int>("VersionNo");

                    b.HasKey("Id");

                    b.HasIndex("IndustriesId");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("XERP.Domain.Entities.Common.CompanyRepresentative", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("CompanyId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedById");

                    b.Property<string>("Description");

                    b.Property<string>("Designation");

                    b.Property<DateTime>("LastModifiedAt");

                    b.Property<string>("LastModifiedById");

                    b.Property<string>("Status");

                    b.Property<int>("VersionNo");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("CompanyRepresentative");
                });

            modelBuilder.Entity("XERP.Domain.Entities.Common.CostCenter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code");

                    b.Property<string>("CompanyId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedById");

                    b.Property<string>("Description");

                    b.Property<DateTime>("LastModifiedAt");

                    b.Property<string>("LastModifiedById");

                    b.Property<string>("Name");

                    b.Property<int>("VersionNo");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("CostCenter");
                });

            modelBuilder.Entity("XERP.Domain.Entities.Common.Industry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedById");

                    b.Property<string>("Description");

                    b.Property<DateTime>("LastModifiedAt");

                    b.Property<string>("LastModifiedById");

                    b.Property<string>("Name");

                    b.Property<int>("VersionNo");

                    b.HasKey("Id");

                    b.ToTable("Industry");
                });

            modelBuilder.Entity("XERP.Domain.Entities.Common.Site", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("CompanyId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedById");

                    b.Property<string>("Description");

                    b.Property<DateTime>("LastModifiedAt");

                    b.Property<string>("LastModifiedById");

                    b.Property<string>("Name");

                    b.Property<string>("Status");

                    b.Property<int>("VersionNo");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Site");
                });

            modelBuilder.Entity("XERP.Domain.Entities.HumanResource.Certificate", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("CompanyId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedById");

                    b.Property<string>("Description");

                    b.Property<DateTime>("LastModifiedAt");

                    b.Property<string>("LastModifiedById");

                    b.Property<string>("Name");

                    b.Property<int>("VersionNo");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Certificate");
                });

            modelBuilder.Entity("XERP.Domain.Entities.HumanResource.Department", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("CompanyId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedById");

                    b.Property<string>("Description");

                    b.Property<DateTime>("LastModifiedAt");

                    b.Property<string>("LastModifiedById");

                    b.Property<string>("Name");

                    b.Property<int>("VersionNo");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("XERP.Domain.Entities.HumanResource.Employee", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnName("Id");

                    b.Property<DateTime?>("BirthDate")
                        .IsRequired()
                        .HasColumnType("datetime");

                    b.Property<string>("BirthPlace")
                        .HasMaxLength(200);

                    b.Property<string>("CivilStatus")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<DateTime?>("CreatedAt")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("CreatedById")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<DateTime?>("LastModifiedAt")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("LastModifiedById")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("MiddleName")
                        .HasMaxLength(20);

                    b.Property<string>("NationalityId");

                    b.Property<string>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue("ACTIVE");

                    b.Property<string>("Suffix")
                        .HasMaxLength(20);

                    b.Property<int>("VersionNo")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(1);

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("XERP.Domain.Entities.HumanResource.EmployeeCertificate", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CertificateCustomName");

                    b.Property<string>("CertificateId");

                    b.Property<string>("CompanyId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedById");

                    b.Property<string>("EmployeeId");

                    b.Property<string>("IssuedDate");

                    b.Property<string>("IssuedInstitution");

                    b.Property<DateTime>("LastModifiedAt");

                    b.Property<string>("LastModifiedById");

                    b.Property<string>("Remarks");

                    b.Property<string>("ValidityExpiration");

                    b.Property<int>("VersionNo");

                    b.HasKey("Id");

                    b.HasIndex("CertificateId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeeCertificate");
                });

            modelBuilder.Entity("XERP.Domain.Entities.HumanResource.EmployeeDependent", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Birthdate");

                    b.Property<string>("CompanyId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedById");

                    b.Property<string>("EmployeeId");

                    b.Property<string>("FirstName");

                    b.Property<DateTime>("LastModifiedAt");

                    b.Property<string>("LastModifiedById");

                    b.Property<string>("LastName");

                    b.Property<int>("Relation");

                    b.Property<int>("VersionNo");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeeDependent");
                });

            modelBuilder.Entity("XERP.Domain.Entities.HumanResource.EmployeeRank", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("CompanyId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedById");

                    b.Property<string>("Description");

                    b.Property<DateTime>("LastModifiedAt");

                    b.Property<string>("LastModifiedById");

                    b.Property<string>("Name");

                    b.Property<int>("VersionNo");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("EmployeeRank");
                });

            modelBuilder.Entity("XERP.Domain.Entities.HumanResource.EmployeeState", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ChangeType");

                    b.Property<string>("CompanyId");

                    b.Property<int>("CostCenterId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedById");

                    b.Property<int>("DepartmentId");

                    b.Property<string>("DepartmentsId");

                    b.Property<string>("EmployeeId");

                    b.Property<int>("EmployeeRankId");

                    b.Property<string>("EmployeeRanksId");

                    b.Property<int>("EmploymentTypeId");

                    b.Property<string>("EmploymentTypesId");

                    b.Property<int>("PositionId");

                    b.Property<string>("PositionsId");

                    b.Property<string>("SiteId");

                    b.Property<string>("Status");

                    b.Property<int>("TeamId");

                    b.Property<string>("TeamsId");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("CostCenterId");

                    b.HasIndex("DepartmentsId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("EmployeeRanksId");

                    b.HasIndex("EmploymentTypesId");

                    b.HasIndex("PositionsId");

                    b.HasIndex("SiteId");

                    b.HasIndex("TeamsId");

                    b.ToTable("EmployeeState");
                });

            modelBuilder.Entity("XERP.Domain.Entities.HumanResource.EmploymentType", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("CompanyId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedById");

                    b.Property<string>("Description");

                    b.Property<DateTime>("LastModifiedAt");

                    b.Property<string>("LastModifiedById");

                    b.Property<string>("Name");

                    b.Property<int>("VersionNo");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("EmploymentType");
                });

            modelBuilder.Entity("XERP.Domain.Entities.HumanResource.Nationality", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedById");

                    b.Property<string>("Description");

                    b.Property<DateTime>("LastModifiedAt");

                    b.Property<string>("LastModifiedById");

                    b.Property<string>("Name");

                    b.Property<string>("Status");

                    b.Property<int>("VersionNo");

                    b.HasKey("Id");

                    b.ToTable("Nationality");
                });

            modelBuilder.Entity("XERP.Domain.Entities.HumanResource.Position", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("CompanyId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedById");

                    b.Property<string>("Description");

                    b.Property<DateTime>("LastModifiedAt");

                    b.Property<string>("LastModifiedById");

                    b.Property<string>("Name");

                    b.Property<int>("VersionNo");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Position");
                });

            modelBuilder.Entity("XERP.Domain.Entities.HumanResource.Team", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("CompanyId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedById");

                    b.Property<string>("Description");

                    b.Property<DateTime>("LastModifiedAt");

                    b.Property<string>("LastModifiedById");

                    b.Property<string>("Name");

                    b.Property<int>("VersionNo");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Team");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("XERP.Domain.Entities.ApplicationUser", b =>
                {
                    b.HasOne("XERP.Domain.Entities.HumanResource.Employee")
                        .WithMany("UserAccounts")
                        .HasForeignKey("EmployeeId");

                    b.OwnsOne("XERP.Domain.ValueObjects.AdAccount", "AdAccount", b1 =>
                        {
                            b1.Property<string>("ApplicationUserId");

                            b1.Property<string>("Domain");

                            b1.Property<string>("Name");

                            b1.HasKey("ApplicationUserId");

                            b1.ToTable("ApplicationUsers");

                            b1.HasOne("XERP.Domain.Entities.ApplicationUser")
                                .WithOne("AdAccount")
                                .HasForeignKey("XERP.Domain.ValueObjects.AdAccount", "ApplicationUserId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });

            modelBuilder.Entity("XERP.Domain.Entities.Common.Company", b =>
                {
                    b.HasOne("XERP.Domain.Entities.Common.Industry", "Industries")
                        .WithMany("Companies")
                        .HasForeignKey("IndustriesId");
                });

            modelBuilder.Entity("XERP.Domain.Entities.Common.CompanyRepresentative", b =>
                {
                    b.HasOne("XERP.Domain.Entities.Common.Company", "Company")
                        .WithMany("CompanyRepresentative")
                        .HasForeignKey("CompanyId");
                });

            modelBuilder.Entity("XERP.Domain.Entities.Common.CostCenter", b =>
                {
                    b.HasOne("XERP.Domain.Entities.Common.Company", "Companies")
                        .WithMany("CostCenters")
                        .HasForeignKey("CompanyId");
                });

            modelBuilder.Entity("XERP.Domain.Entities.Common.Site", b =>
                {
                    b.HasOne("XERP.Domain.Entities.Common.Company")
                        .WithMany("Sites")
                        .HasForeignKey("CompanyId");
                });

            modelBuilder.Entity("XERP.Domain.Entities.HumanResource.Certificate", b =>
                {
                    b.HasOne("XERP.Domain.Entities.Common.Company", "Companies")
                        .WithMany()
                        .HasForeignKey("CompanyId");
                });

            modelBuilder.Entity("XERP.Domain.Entities.HumanResource.Department", b =>
                {
                    b.HasOne("XERP.Domain.Entities.Common.Company", "Companies")
                        .WithMany("Departments")
                        .HasForeignKey("CompanyId");
                });

            modelBuilder.Entity("XERP.Domain.Entities.HumanResource.Employee", b =>
                {
                    b.HasOne("XERP.Domain.Entities.HumanResource.Nationality", "Nationality")
                        .WithMany("Employees")
                        .HasForeignKey("Id")
                        .HasConstraintName("FK_Employee_Nationality")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("XERP.Domain.Entities.HumanResource.EmployeeCertificate", b =>
                {
                    b.HasOne("XERP.Domain.Entities.HumanResource.Certificate", "Certificates")
                        .WithMany("EmployeeCertificates")
                        .HasForeignKey("CertificateId");

                    b.HasOne("XERP.Domain.Entities.Common.Company", "Companies")
                        .WithMany("EmployeeCertificates")
                        .HasForeignKey("CompanyId");

                    b.HasOne("XERP.Domain.Entities.HumanResource.Employee", "Employees")
                        .WithMany("EmployeeCertificates")
                        .HasForeignKey("EmployeeId");
                });

            modelBuilder.Entity("XERP.Domain.Entities.HumanResource.EmployeeDependent", b =>
                {
                    b.HasOne("XERP.Domain.Entities.Common.Company")
                        .WithMany("EmployeeDependents")
                        .HasForeignKey("CompanyId");

                    b.HasOne("XERP.Domain.Entities.HumanResource.Employee", "Employees")
                        .WithMany()
                        .HasForeignKey("EmployeeId");
                });

            modelBuilder.Entity("XERP.Domain.Entities.HumanResource.EmployeeRank", b =>
                {
                    b.HasOne("XERP.Domain.Entities.Common.Company", "Companies")
                        .WithMany()
                        .HasForeignKey("CompanyId");
                });

            modelBuilder.Entity("XERP.Domain.Entities.HumanResource.EmployeeState", b =>
                {
                    b.HasOne("XERP.Domain.Entities.Common.Company", "Companies")
                        .WithMany("EmployeeState")
                        .HasForeignKey("CompanyId");

                    b.HasOne("XERP.Domain.Entities.Common.CostCenter", "CostCenters")
                        .WithMany("EmployeeStates")
                        .HasForeignKey("CostCenterId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("XERP.Domain.Entities.HumanResource.Department", "Departments")
                        .WithMany("EmployeeStates")
                        .HasForeignKey("DepartmentsId");

                    b.HasOne("XERP.Domain.Entities.HumanResource.Employee", "Employee")
                        .WithMany("EmployeeStates")
                        .HasForeignKey("EmployeeId");

                    b.HasOne("XERP.Domain.Entities.HumanResource.EmployeeRank", "EmployeeRanks")
                        .WithMany("EmployeeStates")
                        .HasForeignKey("EmployeeRanksId");

                    b.HasOne("XERP.Domain.Entities.HumanResource.EmploymentType", "EmploymentTypes")
                        .WithMany("EmployeeStates")
                        .HasForeignKey("EmploymentTypesId");

                    b.HasOne("XERP.Domain.Entities.HumanResource.Position", "Positions")
                        .WithMany("EmployeeStates")
                        .HasForeignKey("PositionsId");

                    b.HasOne("XERP.Domain.Entities.Common.Site", "Site")
                        .WithMany("EmployeeStates")
                        .HasForeignKey("SiteId");

                    b.HasOne("XERP.Domain.Entities.HumanResource.Team", "Teams")
                        .WithMany("EmployeeStates")
                        .HasForeignKey("TeamsId");
                });

            modelBuilder.Entity("XERP.Domain.Entities.HumanResource.EmploymentType", b =>
                {
                    b.HasOne("XERP.Domain.Entities.Common.Company", "Companies")
                        .WithMany()
                        .HasForeignKey("CompanyId");
                });

            modelBuilder.Entity("XERP.Domain.Entities.HumanResource.Position", b =>
                {
                    b.HasOne("XERP.Domain.Entities.Common.Company", "Companies")
                        .WithMany("Positions")
                        .HasForeignKey("CompanyId");
                });

            modelBuilder.Entity("XERP.Domain.Entities.HumanResource.Team", b =>
                {
                    b.HasOne("XERP.Domain.Entities.Common.Company", "Companies")
                        .WithMany()
                        .HasForeignKey("CompanyId");
                });
#pragma warning restore 612, 618
        }
    }
}
