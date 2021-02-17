using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarContext>, IRentalDal
    {


        public List<RentalDetailDto> GetRentalDetails()
        {
            using (CarContext context = new CarContext())
            {
                var result = from rental in context.Rentals
                             join customer in context.Customers
                             on rental.UserId equals customer.Id
                             join user in context.Users
                             on customer.UserId equals user.Id
                             join car in context.Cars
                             on rental.CarId equals car.Id
                             join brand in context.Brands
                             on car.BrandId equals brand.Id
                             join color in context.Colors
                             on car.ColorId equals color.Id
                             select new RentalDetailDto
                             {
                                 RentalId = rental.Id,
                                 RentDate = rental.RentDate,
                                 ReturnDate = rental.ReturnDate,
                                 BrandName = brand.BrandName,
                                 Description = car.CarDescription,
                                 ColorName = color.ColorName,
                                 CompanyName = customer.CompanyName,
                                 DailyPrice = car.DailyPrice,
                                 FirstName = user.FirstName,
                                 LastName = user.LastName,
                                 ModelYear = car.ModelYear
                             };
                return result.ToList();

            }
        }
    }
}
