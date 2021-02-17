﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public IResult Add(Rental rental)
        {
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentalAdded);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.RentalListed);
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }

        public IDataResult<List<RentalDetailDto>> GetAllRentalDetails()
        {
           return new SuccessDataResult<List<RentalDetailDto>>(  _rentalDal.GetRentalDetails());
        }

        public IDataResult<bool> IsDelivery(int carId)
        {
            Rental isDeliveryCar = _rentalDal.Get(p => p.Id == carId && p.ReturnDate == null);
            if (isDeliveryCar != null)
            {
                return new ErrorDataResult<bool>(false, Messages.CarNotAvailable);
            }
            else
                return new SuccessDataResult<bool>(true, Messages.CarAvailable);
        }
    }
}
