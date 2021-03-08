using Business.Concrete;
using DataAccess.Concrete.InMemory;
using DataAccess.Abstract;
using Business.Abstract;
using System;
using DataAccess.Concrete.EntityFramework;
using Entities.Conrete;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            //CarTest2();
            //CarTest3();
            //ColorTest();
            //BrandTest();
            //CarTest4();
            //UserTest();




            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            //Rental rental3 = new Rental
            //{
            //    Id = 3,
            //    CarId = 3,
            //    UserId = 3,
            //    RentDate = new DateTime(2021, 2, 18)
            //};
            //rentalManager.Add(rental3);
            foreach (var rental in rentalManager.GetAllRentalDetails().Data)
            {
                Console.WriteLine(rental.FirstName+ rental.LastName+ rental.CompanyName+rental.Description+rental.BrandName+rental.ColorName+rental.RentDate+rental.ReturnDate);
            }

            //rentalManager.Add(rental1);
            //Console.WriteLine("Kiracı eklendi");
            //
            Console.ReadLine();
        }

        //private static void UserTest()
        //{
        //    UserManager userManager = new UserManager(new EfUserDal());
        //    foreach (var user in userManager.GetAll().Data)
        //    {
        //        Console.WriteLine(user.FirstName + user.LastName);
        //    }
        //}

        private static void CarTest4()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car = new Car { Id = 6, BrandId = 1, ColorId = 2, ModelYear = 2015, DailyPrice = 350, CarDescription = "520" };
            carManager.Update(car);
        }

        //private static void ColorTest()
        //{
        //    ColorManager colorManager = new ColorManager(new EfColorDal());
        //    Color color = new Color { ColorId = 3, ColorName = "Lacivert" };
        //    colorManager.Add(color);
        //    foreach (var brand in colorManager.GetAll())
        //    {
        //        Console.WriteLine(brand.ColorName);
        //    }
        //}

        //private static void BrandTest()
        //{
        //    BrandManager brandManager = new BrandManager(new EfBrandDal());
        //    Brand brand = new Brand { BrandId = 6, BrandName = "Citroen" };
        //    brandManager.Add(brand);
        //    foreach (var b in brandManager.GetAll())
        //    {
        //        Console.WriteLine(b.BrandName);
        //    }
        //}

        private static void CarTest3()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car = new Car { Id = 6, BrandId = 2, ColorId = 2, ModelYear = 2015, DailyPrice = 300, CarDescription = "316i" };
            carManager.Add(car);
        }

        private static void CarTest2()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetAll();
            Console.WriteLine("Güncel Araç Listesi");
            if (result.Success==true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarDescription);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
        }

        //private static void CarTest()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    Console.WriteLine("Güncel Araç Listesi");
        //    foreach (var car in carManager.GetAll())
        //    {
        //        Console.WriteLine(car.CarId + "  " + car.Description);
        //    }
        //}
    }
}
