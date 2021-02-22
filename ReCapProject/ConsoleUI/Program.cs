using Business.Concrete;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {



            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());


            //foreach (var rental in rentalManager.GetRentalDetails().Data)
            //{

            //    Console.WriteLine(rental.CarName + " " + rental.CarId);
            //}
            //    CarManager carManager = new CarManager(new EfCarDal());
            //    var result = carManager.Add(new Car { BrandId = 1, CarName = "yeni araba" });
            //    if (result.Success==true)
            //    {
            //        Console.WriteLine(Messages.CarAdded);
            //    }
            //    else
            //    {
            //        Console.WriteLine(result.Message);
            //    }

            //}




            //private static void BrandTest()
            //{
            //    BrandManager brandManager = new BrandManager(new EfBrandDal());
            //    foreach (var brand in brandManager.GetBrandDetails())
            //    {
            //        Console.WriteLine(brand.BrandName + "-------" + brand.DailyPrice);
            //    }

            //}

            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.CarId + "--------" + car.Description);
            }



        }
    }
}