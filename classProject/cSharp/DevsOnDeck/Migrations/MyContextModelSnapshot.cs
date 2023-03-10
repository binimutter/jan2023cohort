﻿// <auto-generated />
using System;
using DevsOnDeck.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DevsOnDeck.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DevsOnDeck.Models.Dev", b =>
                {
                    b.Property<int>("DevId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("DevId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Devs");
                });

            modelBuilder.Entity("DevsOnDeck.Models.DevSkill", b =>
                {
                    b.Property<int>("DevSkillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("DevId")
                        .HasColumnType("int");

                    b.Property<int?>("FrameOrder")
                        .HasColumnType("int");

                    b.Property<int?>("LangOrder")
                        .HasColumnType("int");

                    b.Property<int>("SkillId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("DevSkillId");

                    b.HasIndex("DevId");

                    b.HasIndex("SkillId");

                    b.ToTable("DevSkills");
                });

            modelBuilder.Entity("DevsOnDeck.Models.Job", b =>
                {
                    b.Property<int>("JobId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Info")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("OrgId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("YearlyPay")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("JobId");

                    b.HasIndex("OrgId");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("DevsOnDeck.Models.JobSkill", b =>
                {
                    b.Property<int>("UserSkillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("FrameOrder")
                        .HasColumnType("int");

                    b.Property<int>("JobId")
                        .HasColumnType("int");

                    b.Property<int?>("LangOrder")
                        .HasColumnType("int");

                    b.Property<int>("SkillId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("UserSkillId");

                    b.HasIndex("JobId");

                    b.HasIndex("SkillId");

                    b.ToTable("JobSkills");
                });

            modelBuilder.Entity("DevsOnDeck.Models.Org", b =>
                {
                    b.Property<int>("OrgId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ContactEmail")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ContactName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("OrgId");

                    b.HasIndex("UserId");

                    b.ToTable("Orgs");
                });

            modelBuilder.Entity("DevsOnDeck.Models.OrgList", b =>
                {
                    b.Property<int>("OrgListId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("OrgId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("OrgListId");

                    b.HasIndex("OrgId");

                    b.HasIndex("UserId");

                    b.ToTable("OrgLists");
                });

            modelBuilder.Entity("DevsOnDeck.Models.OrgProfile", b =>
                {
                    b.Property<int>("OrgProfileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("longtext");

                    b.Property<string>("Bio")
                        .HasColumnType("longtext");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Github")
                        .HasColumnType("longtext");

                    b.Property<string>("LinkedIn")
                        .HasColumnType("longtext");

                    b.Property<int>("OrgId")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Zip")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("OrgProfileId");

                    b.HasIndex("OrgId")
                        .IsUnique();

                    b.ToTable("OrgProfiles");
                });

            modelBuilder.Entity("DevsOnDeck.Models.Skill", b =>
                {
                    b.Property<int>("SkillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("SkillImg")
                        .HasColumnType("longtext");

                    b.Property<string>("SkillName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("SkillType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("SkillId");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("DevsOnDeck.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AccessLevel")
                        .HasColumnType("int");

                    b.Property<string>("AccessType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DevsOnDeck.Models.UserProfile", b =>
                {
                    b.Property<int>("UserProfileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("longtext");

                    b.Property<string>("Bio")
                        .HasColumnType("longtext");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Github")
                        .HasColumnType("longtext");

                    b.Property<string>("LinkedIn")
                        .HasColumnType("longtext");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Zip")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("UserProfileId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserProfiles");
                });

            modelBuilder.Entity("DevsOnDeck.Models.Dev", b =>
                {
                    b.HasOne("DevsOnDeck.Models.User", "myUser")
                        .WithOne("myDev")
                        .HasForeignKey("DevsOnDeck.Models.Dev", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("myUser");
                });

            modelBuilder.Entity("DevsOnDeck.Models.DevSkill", b =>
                {
                    b.HasOne("DevsOnDeck.Models.Dev", "theDev")
                        .WithMany("MySkills")
                        .HasForeignKey("DevId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DevsOnDeck.Models.Skill", "theSkill")
                        .WithMany("skilledDevs")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("theDev");

                    b.Navigation("theSkill");
                });

            modelBuilder.Entity("DevsOnDeck.Models.Job", b =>
                {
                    b.HasOne("DevsOnDeck.Models.Org", "theOrg")
                        .WithMany("JobList")
                        .HasForeignKey("OrgId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("theOrg");
                });

            modelBuilder.Entity("DevsOnDeck.Models.JobSkill", b =>
                {
                    b.HasOne("DevsOnDeck.Models.Job", "theJob")
                        .WithMany("theJobSkills")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DevsOnDeck.Models.Skill", "theSkill")
                        .WithMany("skilledJobs")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("theJob");

                    b.Navigation("theSkill");
                });

            modelBuilder.Entity("DevsOnDeck.Models.Org", b =>
                {
                    b.HasOne("DevsOnDeck.Models.User", "theOrgCreator")
                        .WithMany("createdOrgs")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("theOrgCreator");
                });

            modelBuilder.Entity("DevsOnDeck.Models.OrgList", b =>
                {
                    b.HasOne("DevsOnDeck.Models.Org", "theOrg")
                        .WithMany("OrgMembers")
                        .HasForeignKey("OrgId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DevsOnDeck.Models.User", "theUser")
                        .WithMany("memberOf")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("theOrg");

                    b.Navigation("theUser");
                });

            modelBuilder.Entity("DevsOnDeck.Models.OrgProfile", b =>
                {
                    b.HasOne("DevsOnDeck.Models.Org", "org")
                        .WithOne("orgProf")
                        .HasForeignKey("DevsOnDeck.Models.OrgProfile", "OrgId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("org");
                });

            modelBuilder.Entity("DevsOnDeck.Models.UserProfile", b =>
                {
                    b.HasOne("DevsOnDeck.Models.User", "owner")
                        .WithOne("theProfile")
                        .HasForeignKey("DevsOnDeck.Models.UserProfile", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("owner");
                });

            modelBuilder.Entity("DevsOnDeck.Models.Dev", b =>
                {
                    b.Navigation("MySkills");
                });

            modelBuilder.Entity("DevsOnDeck.Models.Job", b =>
                {
                    b.Navigation("theJobSkills");
                });

            modelBuilder.Entity("DevsOnDeck.Models.Org", b =>
                {
                    b.Navigation("JobList");

                    b.Navigation("OrgMembers");

                    b.Navigation("orgProf");
                });

            modelBuilder.Entity("DevsOnDeck.Models.Skill", b =>
                {
                    b.Navigation("skilledDevs");

                    b.Navigation("skilledJobs");
                });

            modelBuilder.Entity("DevsOnDeck.Models.User", b =>
                {
                    b.Navigation("createdOrgs");

                    b.Navigation("memberOf");

                    b.Navigation("myDev");

                    b.Navigation("theProfile");
                });
#pragma warning restore 612, 618
        }
    }
}
