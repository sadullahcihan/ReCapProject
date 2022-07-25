using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal; //Business class library is connected to data access by ICarDal Interface

        //Then constructor has been created automatically by clicking the yellow lamp
        public CarManager(ICarDal carDal) 
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.DailyPrice > 0 && car.Description.Length>2)
            {
                _carDal.Add(car);
            }
            else
            {
                Console.WriteLine("\nCar could not added! Daily price must be over zero or length of description must be bigger than 2.\n");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetByBrandId(int id)
        {
            return _carDal.GetAll(p => p.BrandId == id);
        }

        public List<Car> GetByColorId(int id)
        {
            return _carDal.GetAll(p => p.ColorId == id);
        }

        public Car GetById(int id)
        {
            return _carDal.Get(p => p.Id == id);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
