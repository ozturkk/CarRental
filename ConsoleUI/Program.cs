using Business.Concrete;
using DataAccess.Concrete.InMemory;
using DataAccess.Abstract;
using Business.Abstract;
using System;
using DataAccess.Concrete.EntityFramework;
using Entities.Conrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            CarTest2();
            //CarTest3();
            //ColorTest();
            //BrandTest();
            //CarTest4();

            Console.ReadLine();
        }

        private static void CarTest4()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car = new Car { CarId = 6, BrandId = 2, ColorId = 2, ModelYear = 2015, DailyPrice = 350, Description = "520" };
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
            Car car = new Car { CarId = 6, BrandId = 2, ColorId = 2, ModelYear = 2015, DailyPrice = 300, Description = "316i" };
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
                    Console.WriteLine(car.Description);
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
