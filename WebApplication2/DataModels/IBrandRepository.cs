using System.Collections.Generic;
using WebApplication2.Data.Entities;

namespace WebApplication2.Data
{
    public interface IBrandRepository
    {
        IEnumerable<Brand> GetAllBrands();
    }
}