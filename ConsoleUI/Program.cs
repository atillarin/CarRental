using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Model Numarası:" + car.BrandId + " Model Yılı:" + car.ModelYear + " Fiyat:" + car.DailyPrice + " Açıklama:" + car.Description);
            }

            Console.WriteLine("------------------güncelleme ");
            carManager.Update(new Car { Id = 2,BrandId=1, ModelYear=0,DailyPrice=500,Description="Yanlış güncelleme"});

            foreach (var car in carManager.GetById(2))
            {
                Console.WriteLine("Model Numarası:" + car.BrandId + " Model Yılı:" + car.ModelYear + " Fiyat:" + car.DailyPrice + " Açıklama:" + car.Description);
            }
            
            Console.WriteLine("------------------ekleme ");
            carManager.Add(new Car { Id=6,BrandId=3,ModelYear=2022,DailyPrice=18000,Description="Yeni ürün açıklama bekleniyor"});
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Model Numarası:" + car.BrandId + " Model Yılı:" + car.ModelYear + " Fiyat:" + car.DailyPrice + " Açıklama:" + car.Description);
            }

            Console.WriteLine("------------------yanlış güncellenen ürün silindi ");
            carManager.Delete(new Car { Id=2});
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Model Numarası:" + car.BrandId + " Model Yılı:" + car.ModelYear + " Fiyat:" + car.DailyPrice + " Açıklama:" + car.Description);
            }
        }
    }
}
