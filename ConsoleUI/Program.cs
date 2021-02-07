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

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Brand "+brandManager.GetById(car.BrandId).BrandName +  " Color "+colorManager.GetById(car.ColorId).ColorName +" Daily Price "+ car.DailyPrice);
            }

            carManager.Add(new Car { Id = 7, BrandId = 3,ColorId=3, DailyPrice = 0,ModelYear=2020 });
            carManager.Add(new Car { Id = 5, BrandId = 4, ColorId = 2, DailyPrice = 5000, ModelYear = 2010 });




        }
    }
}
