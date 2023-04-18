﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PBL3.Models.Entities;

#nullable disable

namespace PBL3.Migrations
{
    [DbContext(typeof(LibraryManagementContext))]
    [Migration("20230414132912_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HashtagTitle", b =>
                {
                    b.Property<int>("IdHashtag")
                        .HasColumnType("int");

                    b.Property<string>("IdTitle")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("IdHashtag", "IdTitle")
                        .HasName("PK_ID");

                    b.HasIndex("IdTitle");

                    b.ToTable("Hashtag_title", (string)null);
                });

            modelBuilder.Entity("PBL3.Models.Entities.Account", b =>
                {
                    b.Property<string>("AccName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Cccd")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("CCCD");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("FullName")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.HasKey("AccName")
                        .HasName("PK__Account__092245520483F489");

                    b.ToTable("Account", (string)null);
                });

            modelBuilder.Entity("PBL3.Models.Entities.AccountLogin", b =>
                {
                    b.Property<string>("AccName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("PassHashCode")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<bool?>("Permission")
                        .HasColumnType("bit");

                    b.HasKey("AccName")
                        .HasName("PK__AccountL__09224552BE35A89A");

                    b.ToTable("AccountLogin", (string)null);
                });

            modelBuilder.Entity("PBL3.Models.Entities.ActionLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Acc")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Time")
                        .HasColumnType("datetime");

                    b.HasKey("Id")
                        .HasName("PK__ActionLo__3214EC0770136D3A");

                    b.HasIndex("Acc");

                    b.ToTable("ActionLog", (string)null);
                });

            modelBuilder.Entity("PBL3.Models.Entities.Book", b =>
                {
                    b.Property<string>("IdBook")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("IdTitle")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<bool?>("StateRent")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.HasKey("IdBook")
                        .HasName("PK__Book__2756CBDBD68BBF8F");

                    b.HasIndex("IdTitle");

                    b.ToTable("Book", (string)null);
                });

            modelBuilder.Entity("PBL3.Models.Entities.BookRentDetail", b =>
                {
                    b.Property<int>("IdBookRental")
                        .HasColumnType("int");

                    b.Property<string>("IdBook")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("ReturnDate")
                        .HasColumnType("datetime");

                    b.Property<bool?>("StateApprove")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("StateReturn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<bool?>("StateTake")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.HasKey("IdBookRental", "IdBook")
                        .HasName("PK_IdBookRent_IdBook");

                    b.HasIndex("IdBook");

                    b.ToTable("BookRentDetail", (string)null);
                });

            modelBuilder.Entity("PBL3.Models.Entities.BookRental", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AccApprove")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("AccSending")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("TimeCreate")
                        .HasColumnType("date");

                    b.HasKey("Id")
                        .HasName("PK__BookRent__3214EC0743132A74");

                    b.HasIndex("AccApprove");

                    b.HasIndex("AccSending");

                    b.ToTable("BookRental", (string)null);
                });

            modelBuilder.Entity("PBL3.Models.Entities.Hashtag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("NameHashTag")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id")
                        .HasName("PK__Hashtag__3214EC07C7662509");

                    b.ToTable("Hashtag", (string)null);
                });

            modelBuilder.Entity("PBL3.Models.Entities.Notificate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AccReceive")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("StateRead")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("TimeSending")
                        .HasColumnType("date");

                    b.HasKey("Id")
                        .HasName("PK__Notifica__3214EC077B06361B");

                    b.HasIndex("AccReceive");

                    b.ToTable("Notificate", (string)null);
                });

            modelBuilder.Entity("PBL3.Models.Entities.Republish", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("NameRepublisher")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NumOfRep")
                        .HasColumnType("int");

                    b.Property<DateTime?>("TimeOfRep")
                        .HasColumnType("datetime");

                    b.HasKey("Id")
                        .HasName("PK__Republis__3214EC076ADD85DF");

                    b.ToTable("Republish", (string)null);
                });

            modelBuilder.Entity("PBL3.Models.Entities.Title", b =>
                {
                    b.Property<string>("IdTitle")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("IdRepublish")
                        .HasColumnType("int");

                    b.Property<string>("NameBook")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameBookshelf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameWriter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ReleaseDate")
                        .HasColumnType("date");

                    b.HasKey("IdTitle")
                        .HasName("PK__Title__2123011DEE7FEB85");

                    b.HasIndex("IdRepublish");

                    b.ToTable("Title", (string)null);
                });

            modelBuilder.Entity("HashtagTitle", b =>
                {
                    b.HasOne("PBL3.Models.Entities.Hashtag", null)
                        .WithMany()
                        .HasForeignKey("IdHashtag")
                        .IsRequired()
                        .HasConstraintName("FK__Hashtag_t__IdHas__4BAC3F29");

                    b.HasOne("PBL3.Models.Entities.Title", null)
                        .WithMany()
                        .HasForeignKey("IdTitle")
                        .IsRequired()
                        .HasConstraintName("FK__Hashtag_t__IdTit__4CA06362");
                });

            modelBuilder.Entity("PBL3.Models.Entities.AccountLogin", b =>
                {
                    b.HasOne("PBL3.Models.Entities.Account", "AccNameNavigation")
                        .WithOne("AccountLogin")
                        .HasForeignKey("PBL3.Models.Entities.AccountLogin", "AccName")
                        .IsRequired()
                        .HasConstraintName("FK__AccountLo__Permi__38996AB5");

                    b.Navigation("AccNameNavigation");
                });

            modelBuilder.Entity("PBL3.Models.Entities.ActionLog", b =>
                {
                    b.HasOne("PBL3.Models.Entities.Account", "AccNavigation")
                        .WithMany("ActionLogs")
                        .HasForeignKey("Acc")
                        .HasConstraintName("FK__ActionLog__Acc__3E52440B");

                    b.Navigation("AccNavigation");
                });

            modelBuilder.Entity("PBL3.Models.Entities.Book", b =>
                {
                    b.HasOne("PBL3.Models.Entities.Title", "IdTitleNavigation")
                        .WithMany("Books")
                        .HasForeignKey("IdTitle")
                        .HasConstraintName("FK__Book__IdTitle__5070F446");

                    b.Navigation("IdTitleNavigation");
                });

            modelBuilder.Entity("PBL3.Models.Entities.BookRentDetail", b =>
                {
                    b.HasOne("PBL3.Models.Entities.Book", "IdBookNavigation")
                        .WithMany("BookRentDetails")
                        .HasForeignKey("IdBook")
                        .IsRequired()
                        .HasConstraintName("FK__BookRentD__IdBoo__571DF1D5");

                    b.HasOne("PBL3.Models.Entities.BookRental", "IdBookRentalNavigation")
                        .WithMany("BookRentDetails")
                        .HasForeignKey("IdBookRental")
                        .IsRequired()
                        .HasConstraintName("FK__BookRentD__IdBoo__5629CD9C");

                    b.Navigation("IdBookNavigation");

                    b.Navigation("IdBookRentalNavigation");
                });

            modelBuilder.Entity("PBL3.Models.Entities.BookRental", b =>
                {
                    b.HasOne("PBL3.Models.Entities.Account", "AccApproveNavigation")
                        .WithMany("BookRentalAccApproveNavigations")
                        .HasForeignKey("AccApprove")
                        .HasConstraintName("FK__BookRenta__AccAp__412EB0B6");

                    b.HasOne("PBL3.Models.Entities.Account", "AccSendingNavigation")
                        .WithMany("BookRentalAccSendingNavigations")
                        .HasForeignKey("AccSending")
                        .HasConstraintName("FK__BookRenta__AccSe__4222D4EF");

                    b.Navigation("AccApproveNavigation");

                    b.Navigation("AccSendingNavigation");
                });

            modelBuilder.Entity("PBL3.Models.Entities.Notificate", b =>
                {
                    b.HasOne("PBL3.Models.Entities.Account", "AccReceiveNavigation")
                        .WithMany("Notificates")
                        .HasForeignKey("AccReceive")
                        .HasConstraintName("FK__Notificat__AccRe__3B75D760");

                    b.Navigation("AccReceiveNavigation");
                });

            modelBuilder.Entity("PBL3.Models.Entities.Title", b =>
                {
                    b.HasOne("PBL3.Models.Entities.Republish", "IdRepublishNavigation")
                        .WithMany("Titles")
                        .HasForeignKey("IdRepublish")
                        .HasConstraintName("FK__Title__IdRepubli__48CFD27E");

                    b.Navigation("IdRepublishNavigation");
                });

            modelBuilder.Entity("PBL3.Models.Entities.Account", b =>
                {
                    b.Navigation("AccountLogin");

                    b.Navigation("ActionLogs");

                    b.Navigation("BookRentalAccApproveNavigations");

                    b.Navigation("BookRentalAccSendingNavigations");

                    b.Navigation("Notificates");
                });

            modelBuilder.Entity("PBL3.Models.Entities.Book", b =>
                {
                    b.Navigation("BookRentDetails");
                });

            modelBuilder.Entity("PBL3.Models.Entities.BookRental", b =>
                {
                    b.Navigation("BookRentDetails");
                });

            modelBuilder.Entity("PBL3.Models.Entities.Republish", b =>
                {
                    b.Navigation("Titles");
                });

            modelBuilder.Entity("PBL3.Models.Entities.Title", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}