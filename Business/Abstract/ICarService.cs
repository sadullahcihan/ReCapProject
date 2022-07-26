using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetByBrandId(int id);
        List<Car> GetByColorId(int id);
        public Car GetById(int id);
        public void Add(Car car);
        public void Update(Car car);
        public void Delete(Car car);

        List<CarDetailDto> GetCarDetails();
    }
}
