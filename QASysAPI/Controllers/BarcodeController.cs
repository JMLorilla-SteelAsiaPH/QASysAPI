using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QASysAPI.Entities;
using AutoMapper;
using QASysAPI.Services;
using QASysAPI.Models;

namespace QASysAPI.Controllers
{
    [ApiController]
    [Route("api/Barcode")]
    public class BarcodeController : ControllerBase
    {
        //private readonly ILogger<BarcodeController> _logger;
        private readonly IQASysRepository _qaSysRepository;
        private readonly IMapper _mapper;

        public BarcodeController(IMapper mapper, IQASysRepository QASysRepository)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _qaSysRepository = QASysRepository ?? throw new ArgumentNullException(nameof(QASysRepository));
        }

        [HttpGet]
        public IActionResult GetBarcodes()
        {
            //_logger.LogInformation("It works!");
            return Ok();
        }
        
        [HttpGet("{id}")]
        public IActionResult GetBarcode(int id)
        {
            var barcode = _qaSysRepository.GetBarcode(id);

            if(barcode == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<BarcodeDto>(barcode));
        }
    }
}
