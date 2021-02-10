using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.DailyPrice>0 )
            {
                _carDal.Add(car);
                Console.WriteLine("Car added."+ car.Id);
            }else
            {
                Console.WriteLine("Daily price must be more than 2 letters  ");
            }
              
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine("Car deleted." + car.Id);

        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }


        public Car GetById(int id)
        {
            return _carDal.Get(c=>c.Id==id);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public void Update(Car car)
        {
            if (car.DailyPrice > 0)
            {
                _carDal.Update(car);
                Console.WriteLine("Car updated." + car.Id);
            }
            else
            {
                Console.WriteLine("Daily price must be greater than 0 ");
            }
        }
    }
}
