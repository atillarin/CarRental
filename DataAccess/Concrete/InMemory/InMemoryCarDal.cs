using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ModelYear=2020,DailyPrice=150000,Description="Ortalama yakıt tüketimi 4.5-4.9 Lt/100 km"},
                new Car{Id=2,BrandId=1,ModelYear=2019,DailyPrice=120000,Description="Ortalama yakıt tüketimi 4.2-4.4 Lt/100 km"},
                new Car{Id=3,BrandId=2,ModelYear=2021,DailyPrice=135000,Description="Ortalama yakıt tüketimi 5.5-5.9 Lt/100 km"},
                new Car{Id=4,BrandId=2,ModelYear=2015,DailyPrice=110000,Description="Ortalama yakıt tüketimi 4.2-4.4 Lt/100 km"},
                new Car{Id=5,BrandId=2,ModelYear=2020,DailyPrice=120000,Description="Ortalama yakıt tüketimi 3.5-3.9 Lt/100 km"}
            };

        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);

        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            
            return _cars.Where(c=>c.Id==Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c=>car.Id==c.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }
    }
     
}

