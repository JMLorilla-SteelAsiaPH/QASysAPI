﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QASysAPI.Context;

namespace QASysAPI.Migrations
{
    [DbContext(typeof(BarcodeContext))]
    partial class BarcodeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("QASysAPI.Entities.Barcode", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("bundle_number")
                        .HasMaxLength(50);

                    b.Property<int>("diameter_id");

                    b.Property<string>("file_number")
                        .HasMaxLength(50);

                    b.Property<int>("grade_id");

                    b.Property<DateTime>("last_date_time");

                    b.Property<string>("last_user")
                        .HasMaxLength(20);

                    b.Property<int>("length_id");

                    b.Property<string>("material_number")
                        .HasMaxLength(50);

                    b.Property<string>("product_code")
                        .HasMaxLength(50);

                    b.Property<string>("product_line_id")
                        .HasMaxLength(50);

                    b.Property<float>("quantity");

                    b.Property<string>("shift_number")
                        .HasMaxLength(10);

                    b.Property<int>("spacing_id");

                    b.Property<int>("standard_id");

                    b.Property<int>("status");

                    b.Property<string>("uom")
                        .HasMaxLength(50);

                    b.HasKey("id");

                    b.ToTable("barcode","prod");

                    b.HasData(
                        new { id = 1, bundle_number = "BUND01", diameter_id = 2, file_number = "FILE01", grade_id = 1, last_date_time = new DateTime(2021, 1, 12, 15, 49, 43, 587, DateTimeKind.Local), last_user = "jmlorilla", length_id = 4, material_number = "13CB", product_code = "667ABC", product_line_id = "12AB", quantity = 2.5f, shift_number = "SHFT01", spacing_id = 3, standard_id = 5, status = 1, uom = "TESTUOM" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
