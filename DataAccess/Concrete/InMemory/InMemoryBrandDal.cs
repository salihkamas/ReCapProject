using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryBrandDal : IBrandDal
    {
        List<Brand> _brands;

        public InMemoryBrandDal()
        {
            _brands = new List<Brand>
            {
                new Brand{BrandId=1,BrandName="Citroen"},
                new Brand{BrandId=2,BrandName="Fiat"},
                new Brand{BrandId=2,BrandName="Renault"},
            };
        }

        public void Add(Brand entity)
        {
            _brands.Add(entity);
        }

        public void Delete(Brand entity)
        {
            Brand brandToDelete = _brands.SingleOrDefault(b => b.BrandId == entity.BrandId);
            _brands.Remove(brandToDelete);
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Brand entity)
        {
            Brand brandToUpdate = _brands.SingleOrDefault(b => b.BrandId == entity.BrandId);
            brandToUpdate.BrandName = entity.BrandName;
        }
    }
}
