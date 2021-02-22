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
    public class EfColorDal : IEfEntityRepositoryBase<Color, RentACarContext>,IColorDal
    {
        public List<ColorDetailDto> GetColorDetails()
        {
            using (RentACarContext context = new RentACarContext() )
            {
                var result = from c in context.Colors
                             join p in context.Cars
                             on c.ColorId equals p.ColorId
                             select new ColorDetailDto
                             {
                                 ColorId = c.ColorId,
                                 ColorName = c.ColorName,
                                 DailyPrice = p.DailyPrice
                             };
                return result.ToList();


            }
        }
       
    }
}
