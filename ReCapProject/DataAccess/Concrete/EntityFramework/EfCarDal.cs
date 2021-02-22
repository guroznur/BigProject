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
    public class EfCarDal : IEfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from c in context.Cars
                             join p in context.Brands
                             on c.BrandId equals p.BrandId
                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                 Description = c.Description,
                                 BrandName = p.BrandName,
                                 DailyPrice = c.DailyPrice
                             };
                return result.ToList();

            }
        }
    }
}
