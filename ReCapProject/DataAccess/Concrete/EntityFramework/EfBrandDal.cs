using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal :IEfEntityRepositoryBase<Brand, RentACarContext>,IBrandDal
    {
        public List<BrandDetailDto> GetBrandDetails()
        {
            using (RentACarContext context  = new RentACarContext())
            {
                var result = from b in context.Brands
                             join c in context.Cars
                             on b.BrandId equals c.BrandId
                             select new BrandDetailDto
                             {
                                 BrandId = b.BrandId,
                                 BrandName = b.BrandName,
                                 DailyPrice = c.DailyPrice

                             };
                return result.ToList();
            }
        }
        
    }
}
