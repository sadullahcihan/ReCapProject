using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars; //example DB
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                /*
                new Car {Id=1, BrandId=1, ColorId=1, ModelYear ="2009-01-01", DailyPrice=550000,Description="Honda Civic"},
                new Car {Id=2, BrandId=1, ColorId=3, ModelYear ="2010-01-01", DailyPrice=750000,Description="Honda Civic"},
                new Car {Id=3, BrandId=2, ColorId=2, ModelYear ="1985-01-01", DailyPrice=70000,Description="Tofas"},
                new Car {Id=4, BrandId=2, ColorId=1, ModelYear ="1986-01-01", DailyPrice=71000,Description="Tofas"},
                new Car {Id=5, BrandId=3, ColorId=1, ModelYear ="2020-01-01", DailyPrice=550000,Description="Mercedes"},
                */
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id==car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c=>c.Id==id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c=>c.Id==car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;   
        }
    }
}
