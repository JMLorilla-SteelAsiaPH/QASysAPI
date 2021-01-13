using Microsoft.EntityFrameworkCore;
using QASysAPI.Context;
using QASysAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QASysAPI.Services
{
    public class BarcodeRepository : IBarcodeRepository
    {
        private readonly BarcodeContext _context;

        public BarcodeRepository(BarcodeContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public Barcode GetBarcode(int barcodeId)
        {
            return _context.barcode.Where(c => c.id == barcodeId).FirstOrDefault();
        }

        public IEnumerable<Barcode> GetBarcodes()
        {
            return _context.barcode.OrderBy(c => c.id).ToList();
        }

    }
}
