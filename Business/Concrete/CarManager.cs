using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private readonly ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;   

        }

        [SecuredOperation("admin")]
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
            
        }

        public IDataResult<List<Car>> GetAll()
        {
            var result = _carDal.GetAll();

            return new SuccessDataResult<List<Car>>(result);
        }

        public IDataResult<List<Car>> GetAllByAuctionId(int auctionId)
        {
            var result = _carDal.GetAll(c => c.AuctionId == auctionId);

            return new SuccessDataResult<List<Car>>(result);
        }

        public IDataResult<List<CarDetailDto>> GetAllCarDetails()
        {
            var result = _carDal.GetAllCarDetails();

            return new SuccessDataResult<List<CarDetailDto>>(result);
        }

        public IDataResult<List<CarDetailDto>> GetAllCarDetailsByAuctionId(int auctionId)
        {
            var result = _carDal.GetAllCarDetailsByAuctionId(auctionId);

            return new SuccessDataResult<List<CarDetailDto>>(result);
        }

        public IDataResult<Car> GetById(int id)
        {
            var result = _carDal.Get(c => c.Id == id);
            return new SuccessDataResult<Car>(result);
        }

        public IDataResult<CarDetailDto> GetCarDetailById(int id)
        {
            throw new NotImplementedException();
        }

        [ValidationAspect(typeof(CarValidator))]
        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }
    }
}
