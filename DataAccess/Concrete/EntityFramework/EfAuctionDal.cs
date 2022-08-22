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
    public class EfAuctionDal : EfEntityRepositoryBase<Auction, AuctionsContext>, IAuctionDal
    {
        public void ChangeStatus(int auctionId)
        {
            using (AuctionsContext context = new AuctionsContext())
            {
                var auctionToModify = context.Set<Auction>().SingleOrDefault(a => a.Id == auctionId);
                auctionToModify.IsActive = !(auctionToModify.IsActive);
                context.SaveChanges();
            }
            
        }
    }
}
