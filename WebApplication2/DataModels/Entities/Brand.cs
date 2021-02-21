using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Data.Entities
{
    public class Brand
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string URL { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
