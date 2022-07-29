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
            //Car Tests
            CarManager carManager = new CarManager(new EfCarDal());
            //DisplayCarsTest(carManager);

            //AddCarTest(carManager);

            //GetByBrand(carManager);

            //GetByColor(carManager);

            //CrudTest(carManager);


            //GetCarDetailsTest(carManager);

            //Brand Tests
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            //DisplayBrandsTest(brandManager);

            //CrudTest TEST Brand
            //Brand newBrand = new Brand { BrandId = 11, BrandName = "Corolla New" };
            //brandManager.Delete(newBrand);
            //foreach (var b in brandManager.GetAll().Message)
            //Console.WriteLine(brandManager.GetAll().Message);

            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            //AddCustomerTest(customerManager);
            //UpdateCustomerTest(customerManager);
            UserManager userManager = new UserManager(new EfUserDal());
            //CrudTestUser(userManager);
            //UserDetailsTest(userManager);

            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            //RentalCrudTest(rentalManager);
            RentalDisplay(rentalManager);
        }

        private static void RentalDisplay(RentalManager rentalManager)
        {
            foreach (var rental in rentalManager.GetAll().Data)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", rental.Id, rental.CarId, rental.CustomerId, rental.RentDate, rental.ReturnDate);
            }
        }

        private static void RentalCrudTest(RentalManager rentalManager)
        {
            rentalManager.Add(new Rental() { Id = 4, CarId = 5, CustomerId = 3, RentDate = DateTime.Now, ReturnDate = DateTime.Now.AddDays(2) });
            foreach (var rental in rentalManager.GetAll().Data)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", rental.Id, rental.CarId, rental.CustomerId, rental.RentDate, rental.ReturnDate);
            }
        }

        private static void UserDetailsTest(UserManager userManager)
        {
            foreach (var user in userManager.GetUserDetails().Data)
            {
                Console.WriteLine("{0}{1}{2}{3}", user.CompanyName, user.FirstName, user.LastName, user.Email);
            }
        }

        private static void CrudTestUser(UserManager userManager)
        {
            userManager.Add(new User()
            {
                Id = 5,
                FirstName = "Dimitri",
                LastName = "Reyes",
                Email = "dimitri_reyes@gmail.com",
                Password = "dimitriBG"
            });
            foreach (var user in userManager.GetAll().Data)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", user.Id, user.FirstName, user.LastName, user.Email);
            }
        }

        private static void UpdateCustomerTest(CustomerManager customerManager)
        {
            customerManager.Update(new Customer() { Id = 4, CompanyName = "The Queen Rent a Car" });
            foreach (var customer in customerManager.GetAll().Data)
            {
                Console.WriteLine("{0} {1}", customer.Id, customer.CompanyName);
            }
        }

        private static void AddCustomerTest(CustomerManager customerManager)
        {
            customerManager.Add(new Customer() { Id = 5, CompanyName = "Star Rent a Car" });
            foreach (var customer in customerManager.GetAll().Data)
            {
                Console.WriteLine("{0} {1}", customer.Id, customer.CompanyName);
            }
        }

        private static void DisplayBrandsTest(BrandManager brandManager)
        {
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine("{0} {1}", brand.BrandId, brand.BrandName);
            }
            Console.WriteLine("\n" + brandManager.GetAll().Message);
        }

        private static void DisplayCarsTest(CarManager carManager)
        {
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine("{0}\t {1} \t {2}\t {3}", car.Id, car.ModelYear, car.DailyPrice, car.Description);
            }
            Console.WriteLine();
        }

        private static void GetCarDetailsTest(CarManager carManager)
        {
            Console.WriteLine("{0}\t\t {1} \t\t {2}\t {3}", "BrandName", "ColorName", "DailyPrice", "Description");
            var result = carManager.GetCarDetails();
            foreach (var car in result.Data)
            {
                Console.WriteLine("{0}\t {1} \t {2}\t {3}", car.BrandName, car.ColorName, car.DailyPrice, car.Description);
            }
            Console.WriteLine("\n"+result.Message);
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
                Description = "Selling my old car"
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
            foreach (var car in carManager.GetByColorId(1).Data)
            {
                Console.WriteLine("{0}\t {1} \t {2}", car.Id, car.ModelYear, car.Description);
            }
        }

        private static void GetByBrand(CarManager carManager)
        {
            Console.WriteLine("\nBrand id 3:");
            foreach (var car in carManager.GetByBrandId(3).Data)
            {
                Console.WriteLine("{0}\t {1} \t {2}", car.Id, car.ModelYear, car.Description);
            }
        }
    }
}
