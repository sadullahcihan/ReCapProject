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
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("{0}\t {1} \t {2}", car.Id, car.ModelYear, car.Description);
            }
            Console.WriteLine();
            //Add new car
            /*
            Car newCar = new Car() { 
                Id=9, BrandId = 5, ColorId = 9, 
                ModelYear = new DateTime(1988, 01, 01), 
                DailyPrice = 0, Description = "Selling my car." };
            carManager.AddCar(newCar);
            */
            Console.WriteLine("\nBrand id 3:");
            foreach (var car in carManager.GetByBrandId(3))
            {
                Console.WriteLine("{0}\t {1} \t {2}", car.Id, car.ModelYear, car.Description);
            }
            Console.WriteLine("\nColor id 1:");
            foreach (var car in carManager.GetByColorId(1))
            {
                Console.WriteLine("{0}\t {1} \t {2}", car.Id, car.ModelYear, car.Description);
            }
        }
    }
}
