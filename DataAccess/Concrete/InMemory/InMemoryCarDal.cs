using DataAccess.Abstract;
using Entities.Conrete;
using Entities.DTOs;
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
                new Car{Id=1,BrandId=1,ColorId=1,ModelYear=2011,DailyPrice=150,CarDescription="Audi A4"},
                new Car{Id=2,BrandId=1,ColorId=2,ModelYear=2012,DailyPrice=250,CarDescription="Audi A3"},
                new Car{Id=3,BrandId=2,ColorId=1,ModelYear=2013,DailyPrice=350,CarDescription="Bmw 320i"},
                new Car{Id=4,BrandId=2,ColorId=3,ModelYear=2014,DailyPrice=250,CarDescription="Bmw 520d"},
                new Car{Id=5,BrandId=3,ColorId=1,ModelYear=2015,DailyPrice=450,CarDescription="WV Passat"},
                new Car{Id=6,BrandId=3,ColorId=4,ModelYear=2013,DailyPrice=250,CarDescription="WV CC"},
                new Car{Id=7,BrandId=4,ColorId=1,ModelYear=2015,DailyPrice=250,CarDescription="Nissan Juke"},
                new Car{Id=8,BrandId=4,ColorId=2,ModelYear=2010,DailyPrice=150,CarDescription="Nissan Qaskhai"}
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
            throw new NotImplementedException();
        }

        public List<Car> GetAllByBrand(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public List<Car> GetAllByColor(int colorId)
        {
            return _cars.Where(c => c.ColorId == colorId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.CarDescription = car.CarDescription;
            
        }
    }
}
