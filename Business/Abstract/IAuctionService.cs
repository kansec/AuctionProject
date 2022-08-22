using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAuctionService
    {
        IDataResult<List<Auction>> GetAll();
        IDataResult<Auction> GetById(int id);
        IResult Add(Auction auction);   
        IResult Update(Auction auction);
        IResult ChangeStatus(int auctionId);



    }
}
