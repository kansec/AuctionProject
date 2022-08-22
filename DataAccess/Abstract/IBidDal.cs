using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IBidDal : IEntityRepository<Bid>
    {
        List<Bid> GetAllByUserId(int userId);
        List<Bid> GetAllByAuctionId(int auctionId);
    }
}
