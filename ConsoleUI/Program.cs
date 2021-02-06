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
            

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id +  " colorID "+car.ColorId);
            }

            carManager.Add(new Car { Id = 8, BrandId = 3, DailyPrice = 5000,ModelYear=2020 });




        }
    }
}
