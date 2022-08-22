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
    public class AuctionManager : IAuctionService
    {
        private readonly IAuctionDal _auctionDal;

        public AuctionManager(IAuctionDal _auctionDal)
        {
            _auctionDal = _auctionDal;  

        }

        [ValidationAspect(typeof(AuctionValidator))]
        public IResult Add(Auction auction)
        {
            _auctionDal.Add(auction);

            return new SuccessResult(Messages.AuctionAdded);
        }

        public IResult ChangeStatus(int auctionId)
        {
            _auctionDal.ChangeStatus(auctionId);
            return new SuccessResult(Messages.AuctionUpdated);
        }

        public IDataResult<List<Auction>> GetAll()
        {
            var result = _auctionDal.GetAll();

            return new SuccessDataResult<List<Auction>>(result);
        }

        public IDataResult<Auction> GetById(int id)
        {
            var result = _auctionDal.Get(a => a.Id == id);
            return new SuccessDataResult<Auction>(result);
        }

        [ValidationAspect(typeof(AuctionValidator))]
        public IResult Update(Auction auction)
        {
            _auctionDal.Update(auction);

            return new SuccessResult(Messages.AuctionUpdated);
        }
    }
}
