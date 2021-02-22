using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VaquesBackend.Db;
using VaquesBackend.Models;
using VaquesBackend.Services;

namespace VaquesBackend.Controllers
{
    [ApiController]
    [Route("vaques")]
    public class CampController : ControllerBase
    {
        

        private readonly ILogger<CampController> _logger;
        private readonly ICampService _campService;

        public CampController(ICampService campService, ILogger<CampController> logger)
        {
            _logger = logger;
            _campService = campService;
        }

        [HttpGet]
        [Route("camp")]
        public IEnumerable<Vaca> GetVaquesCamp()
        {
            return _campService.getCasa();
        }

        [HttpGet("camio")]
        public IEnumerable<Vaca> GetVaquesCamio()
        {
            return _campService.getCamio();
        }

        
        [HttpGet("ciutat")]
        public IEnumerable<Vaca> GetVaquesCiutat()
        {
            return _campService.getCiutat();
        }

        [HttpGet("posacamio/{nom}")]
        public IActionResult PosaVacaCamio(string nom)
        {
            if (_campService.PosaVacaAlCamio(nom)) {
                return Ok("Ok");
            }
            else
            {
                return NotFound("Quina vaca s'ha de posar?");
            }
        }

        [HttpGet("posacamp/{nom}")]
        public IActionResult  PosaVacaCamp(string nom)
        {
            if (_campService.PosaVacaAlCamp(nom)) {
                return Ok("Ok");
            }
            else
            {
                return NotFound("Quina vaca s'ha de posar?");
            }
        }

        [HttpGet("tocity")]
        public IEnumerable<Vaca> PosaVacaACiutat(string nom)
        {
            return _campService.getCiutat();
        }
    }
}
