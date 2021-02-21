using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data.Entities;

namespace WebApplication2.Data
{
    public class BrandRepository : IBrandRepository
    {
        private readonly BrandContext _ctx;
        private readonly ILogger<BrandRepository> _logger;

        public BrandRepository(BrandContext ctx, ILogger<BrandRepository> logger)
        {
            _ctx = ctx;
            _logger = logger;
        }

        public IEnumerable<Brand> GetAllBrands()
        {
            try
            {
                _logger.LogInformation("##########Backend API GetAllBrands Was Called###########");
                return _ctx.Brands
                           .OrderBy(p => p.ID)
                           .ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError($"##########Backend API GetAllBrands Was Failed ：{ex}###########");
                return null;
            }

        }

    }
}
