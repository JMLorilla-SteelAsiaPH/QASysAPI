using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QASysAPI.Profiles
{
    public class BarcodeProfile : Profile
    {
        public BarcodeProfile()
        {
            CreateMap<Entities.Barcode, Models.BarcodeDto>();
        }
    }
}
