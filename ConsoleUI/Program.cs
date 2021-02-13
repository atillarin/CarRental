using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EFCarDal());
            BrandManager brandManager = new BrandManager(new EFBrandDal());
            ColorManager colorManager = new ColorManager(new EFColorDal());



            foreach (var car in carManager.GetAll().Data) //tabloları join etmeden listeleme
            {
                Console.WriteLine("Brand " + (brandManager.GetById(car.BrandId).Data).BrandName + " Color " + (colorManager.GetById(car.ColorId).Data).ColorName + " Daily Price " + car.DailyPrice);
            }


            var resultAdd=carManager.Add(new Car { Id=10, BrandId = 3,ColorId=3, DailyPrice = 500,ModelYear=2020,Description="4 X 5" });
            Console.WriteLine(resultAdd.Message);
            var resultUpdate=carManager.Update(new Car { Id = 10, BrandId = 3, ColorId = 3, DailyPrice = 700, ModelYear = 2020, Description = "4 X 4" });
            Console.WriteLine(resultUpdate.Message);
            var resultDelete=carManager.Delete(carManager.GetById(10).Data);
            Console.WriteLine(resultDelete.Message);

            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine("Car ID: "+car.Id + " Color: " + car.ColorId+ " Daily Price: " + car.DailyPrice+ " Description: " + car.Description);
            }

            var result = carManager.GetCarDetails();

            if (result.Success==true)
            {
            
                foreach (var car in result.Data) //tabloları join ederek
                {
                    Console.WriteLine("Brand " + car.BrandName + " Color " + car.ColorName + " Daily Price " + car.DailyPrice);
                    
                }
                Console.WriteLine(result.Message);
            }


        }
    }
}
