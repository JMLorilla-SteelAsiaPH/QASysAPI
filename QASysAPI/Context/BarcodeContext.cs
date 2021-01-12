using Microsoft.EntityFrameworkCore;
using QASysAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QASysAPI.Context
{
    public class BarcodeContext : DbContext
    {
        public DbSet<Barcode> barcode{ get; set; }

        public BarcodeContext(DbContextOptions<BarcodeContext> options) : base(options)
        {
            //Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            DateTime currDate = DateTime.Now;

            modelBuilder.Entity<Barcode>().ToTable("barcode", "prod");

            modelBuilder.Entity<Barcode>().HasData(
                new Barcode()
                {
                    id = 1,
                    product_line_id = "12AB",
                    material_number = "13CB",
                    product_code = "667ABC",
                    file_number = "FILE01",
                    bundle_number = "BUND01",
                    shift_number = "SHFT01",
                    grade_id = 1,
                    diameter_id = 2,
                    spacing_id = 3,
                    length_id = 4,
                    standard_id = 5,
                    quantity = 2.5F,
                    uom = "TESTUOM",
                    status = 1,
                    last_date_time = currDate,
                    last_user = "jmlorilla"
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}
