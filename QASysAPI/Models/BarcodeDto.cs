using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QASysAPI.Models
{
    public class BarcodeDto
    {
        public int id { get; set; }

        public string product_line_id { get; set; }

        public string material_number { get; set; }

        public string product_code { get; set; }

        public string file_number { get; set; }

        public string bundle_number { get; set; }

        public string shift_number { get; set; }

        public int grade_id { get; set; }

        public int diameter_id { get; set; }

        public int spacing_id { get; set; }

        public int length_id { get; set; }

        public int standard_id { get; set; }

        public float quantity { get; set; }

        public string uom { get; set; }

        public int status { get; set; }

        public DateTime last_date_time { get; set; }

        public string last_user { get; set; }
    }
}
