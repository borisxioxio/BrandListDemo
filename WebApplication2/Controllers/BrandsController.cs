using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data;
using WebApplication2.Data.Entities;
using WebApplication2.ViewModels;

namespace WebApplication2.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    [Produces("application/json")]
    public class BrandsController : ControllerBase
    {
        private readonly IBrandRepository _brandRepository;
        private readonly ILogger<BrandsController> _logger;
        private readonly IMapper _mapper;

        public BrandsController(IBrandRepository brandRepository, ILogger<BrandsController> logger, IMapper mapper )
        {
            _brandRepository = brandRepository;
            _logger = logger;
            _mapper = mapper;
        }


        [HttpGet]
        public ActionResult<IEnumerable<Brand>> Get() 
        {
            try
            {
                var results = _brandRepository.GetAllBrands();
                return Ok(_mapper.Map<IEnumerable<Brand>, IEnumerable<BrandViewModel>>(results));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get Brands: {ex}");
                return BadRequest("Failed to get Brands");
            }
            
        }
    }
}
