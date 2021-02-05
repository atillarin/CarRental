using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        IRentDal _renDal;

        public CarManager(IRentDal renDal)
        {
            _renDal = renDal;
        }
        public List<Car> GetAll()
        {
            return _renDal.GetAll();
        }
        public List<Car> GetById(int Id)
        {
            return _renDal.GetById(Id);
        }

        public void Add(Car car)
        {
            _renDal.Add(car);
        }

        public void Delete(Car car)
        {
            _renDal.Delete(car);
        }

        public void Update(Car car)
        {
            _renDal.Update(car);
        }
    }
}
