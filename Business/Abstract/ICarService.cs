﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        Car GetById(int id);
        List<Car> GetAllByColorId(int id);
        List<Car> GetAllByBrandId(int id);

        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);



    }
}
