using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopDemo.Abstractions;
using WebShopDemo.Domain;

namespace WebShopDemo.Services
{
    public class BrandService : IBrandService
    {
        public Brand GetBrandById(int brandId)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetBrands()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsByBrand(int brandId)
        {
            throw new NotImplementedException();
        }
    }
}
