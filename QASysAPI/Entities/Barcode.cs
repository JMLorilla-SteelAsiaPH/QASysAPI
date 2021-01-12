using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QASysAPI.Entities
{
    public class Barcode
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [MaxLength(50)]
        public string product_line_id { get; set; }

        [MaxLength(50)]
        public string material_number { get; set; }

        [MaxLength(50)]
        public string product_code { get; set; }

        [MaxLength(50)]
        public string file_number { get; set; }

        [MaxLength(50)]
        public string bundle_number { get; set; }

        [MaxLength(10)]
        public string shift_number { get; set; }

        public int grade_id { get; set; }

        public int diameter_id { get; set; }

        public int spacing_id { get; set; }

        public int length_id { get; set; }

        public int standard_id { get; set; }

        public float quantity { get; set; }

        [MaxLength(50)]
        public string uom { get; set; }

        public int status { get; set; }

        public DateTime last_date_time { get; set; }

        [MaxLength(20)]
        public string last_user { get; set; }
    }
}
