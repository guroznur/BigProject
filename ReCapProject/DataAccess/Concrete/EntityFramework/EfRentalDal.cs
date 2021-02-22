using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
   public class EfRentalDal:IEfEntityRepositoryBase<Rental,RentACarContext>,IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from r in filter == null ? context.Rentals : context.Rentals.Where(filter)
                             join c in context.Cars
                             on r.CarId equals c.CarId
                             join cu in context.Customers
                             on r.CustomerId equals cu.Id
                             join us in context.Users
                             on cu.UserId equals us.Id
                             select new RentalDetailDto
                             {
                                 Id = r.Id,
                                 CarId = c.CarId,
                                 CarName = c.CarName,
                                 CustomerName = cu.CompanyName,
                                 RentDay = r.RentDay,
                                 ReturnDate = r.ReturnDate,
                                 UserName = us.FirstName + " " + us.LastName

                             };
                return result.ToList();

            }
        }
    }
}
