using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    internal class Program
    {

        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //DisplayCarsTest(carManager);
            
            //AddCarTest(carManager);

            //GetByBrand(carManager);

            //GetByColor(carManager);

            //CrudTest(carManager);

            GetCarDetailsTest(carManager);

        }

        private static void DisplayCarsTest(CarManager carManager)
        {
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("{0}\t {1} \t {2}\t {3}", car.Id, car.ModelYear, car.DailyPrice, car.Description);
            }
        }

        private static void GetCarDetailsTest(CarManager carManager)
        {
            Console.WriteLine("{0}\t\t {1} \t\t {2}\t {3}", "BrandName", "ColorName", "DailyPrice", "Description");
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("{0}\t {1} \t {2}\t {3}", car.BrandName, car.ColorName, car.DailyPrice, car.Description);
            }
            Console.WriteLine();
        }

        private static void AddCarTest(CarManager carManager)
        {
            //Add new car
            Car newCar = new Car()
            {
                Id = 9,
                BrandId = 5,
                ColorId = 9,
                ModelYear = new DateTime(1988, 01, 01),
                DailyPrice = 0,
                Description = "Selling my car."
            };
            carManager.Add(newCar);
        }

        private static void CrudTest(CarManager carManager)
        {
            //CRUD TEST
            Car newCar = new Car()
            {
                Id = 10,
                BrandId = 2,
                ColorId = 2,
                ModelYear = new DateTime(2005, 01, 01),
                DailyPrice = 255000,
                Description = "Car from Nurse"
            };
            carManager.Add(newCar);
            //carManager.Update(newCar);
            //carManager.Delete(newCar);
            GetCarDetailsTest(carManager);
        }

        private static void GetByColor(CarManager carManager)
        {
            Console.WriteLine("\nColor id 1:");
            foreach (var car in carManager.GetByColorId(1))
            {
                Console.WriteLine("{0}\t {1} \t {2}", car.Id, car.ModelYear, car.Description);
            }
        }

        private static void GetByBrand(CarManager carManager)
        {
            Console.WriteLine("\nBrand id 3:");
            foreach (var car in carManager.GetByBrandId(3))
            {
                Console.WriteLine("{0}\t {1} \t {2}", car.Id, car.ModelYear, car.Description);
            }
        }
    }
}
