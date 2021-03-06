﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Communication.DAL;

namespace ObjectDesign.Migrations
{
    [DbContext(typeof(CommunicationDbContext))]
    [Migration("20190311180957_DbContext_v1")]
    partial class DbContext_v1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ObjectDesign.Communication.DAL.Entities.CommentEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("ContributionId");

                    b.Property<string>("Message");

                    b.Property<DateTime>("Time");

                    b.Property<Guid?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ContributionId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("ObjectDesign.Communication.DAL.Entities.ContributionEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("GroupId");

                    b.Property<string>("Message");

                    b.Property<DateTime>("Time");

                    b.Property<string>("Title");

                    b.Property<Guid?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("UserId");

                    b.ToTable("Contributions");
                });

            modelBuilder.Entity("ObjectDesign.Communication.DAL.Entities.GroupEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<byte[]>("Photo");

                    b.HasKey("Id");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("ObjectDesign.Communication.DAL.Entities.GroupMemberEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("GroupId");

                    b.Property<int>("Permission");

                    b.Property<Guid?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("UserId");

                    b.ToTable("GroupMembers");
                });

            modelBuilder.Entity("ObjectDesign.Communication.DAL.Entities.ReactionEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("ContributionId");

                    b.Property<int>("ReactionType");

                    b.Property<Guid?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ContributionId");

                    b.HasIndex("UserId");

                    b.ToTable("Reactions");
                });

            modelBuilder.Entity("ObjectDesign.Communication.DAL.Entities.UserEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<byte[]>("Photo");

                    b.Property<string>("Surname");

                    b.Property<string>("TelephoneNumber");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ObjectDesign.Communication.DAL.Entities.CommentEntity", b =>
                {
                    b.HasOne("ObjectDesign.Communication.DAL.Entities.ContributionEntity", "Contribution")
                        .WithMany("Comments")
                        .HasForeignKey("ContributionId");

                    b.HasOne("ObjectDesign.Communication.DAL.Entities.UserEntity", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("ObjectDesign.Communication.DAL.Entities.ContributionEntity", b =>
                {
                    b.HasOne("ObjectDesign.Communication.DAL.Entities.GroupEntity", "Group")
                        .WithMany("Contributions")
                        .HasForeignKey("GroupId");

                    b.HasOne("ObjectDesign.Communication.DAL.Entities.UserEntity", "User")
                        .WithMany("Contirbutions")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("ObjectDesign.Communication.DAL.Entities.GroupMemberEntity", b =>
                {
                    b.HasOne("ObjectDesign.Communication.DAL.Entities.GroupEntity", "Group")
                        .WithMany("GroupMembers")
                        .HasForeignKey("GroupId");

                    b.HasOne("ObjectDesign.Communication.DAL.Entities.UserEntity", "User")
                        .WithMany("GroupMembers")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("ObjectDesign.Communication.DAL.Entities.ReactionEntity", b =>
                {
                    b.HasOne("ObjectDesign.Communication.DAL.Entities.ContributionEntity", "Contribution")
                        .WithMany("Reactions")
                        .HasForeignKey("ContributionId");

                    b.HasOne("ObjectDesign.Communication.DAL.Entities.UserEntity", "User")
                        .WithMany("Reactions")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
