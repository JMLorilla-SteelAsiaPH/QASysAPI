using QASysAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QASysAPI.Services
{
    public interface IQASysRepository
    {
        Barcode GetBarcode(int id);

        IEnumerable<Barcode> GetBarcodes();
    }
}
