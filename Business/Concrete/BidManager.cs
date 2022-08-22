using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BidManager : IBidService
    {
        private readonly IBidDal _bidDal;
        public BidManager(IBidDal bidDal)
        {
            _bidDal = bidDal;
        }

        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Bid bid)
        {
            _bidDal.Add(bid);
            return new SuccessResult(Messages.BidAdded);
        }

        public IDataResult<List<Bid>> GetAll()
        {
            var result = _bidDal.GetAll();
            return new SuccessDataResult<List<Bid>>(result);
        }

        public IDataResult<List<Bid>> GetAllByAuctionId(int auctionId)
        {
            var result = _bidDal.GetAllByAuctionId(auctionId);
            return new SuccessDataResult<List<Bid>>(result);
            
        }

        public IDataResult<List<Bid>> GetAllByCarId(int carId)
        {
            var result = _bidDal.GetAll(b => b.CarId == carId);
            return new SuccessDataResult<List<Bid>>(result);
        }

        public IDataResult<List<Bid>> GetAllByUserId(int userId)
        {
            var result = _bidDal.GetAllByUserId(userId);
            return new SuccessDataResult<List<Bid>>(result);

        }

        public IDataResult<Bid> GetById(int id)
        {
            var result = _bidDal.Get(b => b.Id == id);
            return new SuccessDataResult<Bid>(result);
        }

        public IDataResult<Bid> GetHighestPricedBidByCarId(int carId)
        {
            var result = _bidDal.GetAll().OrderByDescending(b => b.Price).First();

            return new SuccessDataResult<Bid>(result);

        }

        public IResult Update(Bid bid)
        {
            _bidDal.Update(bid);
            return new SuccessResult(Messages.BidUpdated);
        }
    }
}
