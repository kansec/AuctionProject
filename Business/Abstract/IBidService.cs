using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBidService
    {
        IDataResult<List<Bid>> GetAll();
        IDataResult<List<Bid>> GetAllByCarId(int carId);
        IDataResult<List<Bid>> GetAllByUserId(int userId);
        IDataResult<List<Bid>> GetAllByAuctionId(int auctionId);
        IDataResult<Bid> GetById(int id);
        IDataResult<Bid> GetHighestPricedBidByCarId(int carId);
        IResult Add(Bid bid);
        IResult Update(Bid bid);
    }
}
