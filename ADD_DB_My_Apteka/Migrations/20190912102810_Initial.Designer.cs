﻿// <auto-generated />
using ADD_DB_My_Apteka;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ADD_DB_My_Apteka.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20190912102810_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("ADD_DB_My_Apteka.Apt", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Email");

                    b.Property<string>("INN");

                    b.Property<string>("Kass1_FN");

                    b.Property<string>("Kass1_RN");

                    b.Property<string>("Kass1_ZN");

                    b.Property<string>("Kass2_FN");

                    b.Property<string>("Kass2_RN");

                    b.Property<string>("Kass2_ZN");

                    b.Property<string>("Kass3_FN");

                    b.Property<string>("Kass3_RN");

                    b.Property<string>("Kass3_ZN");

                    b.Property<string>("Kass4_FN");

                    b.Property<string>("Kass4_RN");

                    b.Property<string>("Kass4_ZN");

                    b.Property<string>("Kass_1");

                    b.Property<string>("Kass_2");

                    b.Property<string>("Kass_3");

                    b.Property<string>("Kass_4");

                    b.Property<int>("Node");

                    b.Property<string>("Operator");

                    b.Property<string>("Pass_Email");

                    b.Property<string>("Tel_Operator");

                    b.Property<string>("Telephone");

                    b.Property<string>("UR");

                    b.Property<string>("VPN");

                    b.Property<string>("VPN_CODE");

                    b.Property<string>("Work_time");

                    b.Property<int>("flag");

                    b.HasKey("ID");

                    b.ToTable("My_Apteka_DB");
                });
#pragma warning restore 612, 618
        }
    }
}
