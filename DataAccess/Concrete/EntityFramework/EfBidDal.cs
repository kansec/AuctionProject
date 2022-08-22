using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBidDal : EfEntityRepositoryBase<Bid, AuctionsContext>, IBidDal
    {
        public List<Bid> GetAllByAuctionId(int auctionId)
        {
            using(AuctionsContext context = new AuctionsContext())
            {
               
                var result = from bids in context.Bids
                             join cars in context.Cars
                             on bids.CarId equals cars.Id
                             join auctions in context.Auctions
                             on cars.AuctionId equals auctions.Id
                             where auctions.Id == auctionId
                             select bids;

                return result.ToList();

            }
        }

        public List<Bid> GetAllByUserId(int userId)
        {
            using (AuctionsContext context = new AuctionsContext())
            {
                var result = from bids in context.Bids
                             join users in context.Users
                             on bids.UserId equals users.Id
                             where users.Id == userId
                             select bids;

                return result.ToList();

            }
        }
    }
}
