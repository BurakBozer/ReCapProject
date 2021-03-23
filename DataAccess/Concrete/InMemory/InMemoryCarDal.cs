using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{BrandId = 1, ColorId = 1, DailyPrice = 20000, Description = "Supra", Id = 1, ModelYear = "1990" },
                new Car{BrandId = 2, ColorId = 2, DailyPrice = 30000, Description = "McLaren", Id = 2, ModelYear = "1980" },
                new Car{BrandId = 3, ColorId = 3, DailyPrice = 40000, Description = "Ferrari", Id = 3, ModelYear = "1970" },
                new Car{BrandId = 4, ColorId = 4, DailyPrice = 50000, Description = "Masserati", Id = 4, ModelYear = "1995" },
                new Car{BrandId = 5, ColorId = 5, DailyPrice = 60000, Description = "BMW", Id = 5, ModelYear = "2000" },

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(car); 
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.Id == carId).ToList();
        }

        public void Update(Car car)
        {
            //Gonderdigim araba id sine sahip olan listedeki arabayi bul 
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.Id = car.Id;
            carToUpdate.ModelYear = car.ModelYear;

        }
    }
}
