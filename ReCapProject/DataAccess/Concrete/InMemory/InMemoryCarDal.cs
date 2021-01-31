using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
     
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{CarId=1,BrandId=1,ColorId=2,ModelYear=2001,DailyPrice=500,Description="Binek Otomobil"},
                new Car{CarId=2,BrandId=2,ColorId=1,ModelYear=2020,DailyPrice=500,Description="Hibrit"},
                new Car{CarId=3,BrandId=5,ColorId=4,ModelYear=2018,DailyPrice=500,Description="Aile Arabası"},
                new Car{CarId=4,BrandId=8,ColorId=6,ModelYear=2014,DailyPrice=500,Description="Kısa Kasa"},
                new Car{CarId=5,BrandId=3,ColorId=9,ModelYear=2019,DailyPrice=500,Description="Spor Araba"},


            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

     

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            
        }
    }
}
