using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, AuctionsContext>, ICarDal
    {
        public List<CarDetailDto> GetAllCarDetails()
        {
            using(AuctionsContext context = new AuctionsContext())
            {
                var result = from c in context.Cars
                             join m in context.Models
                             on c.ModelId equals m.Id
                             join t in context.TransmissionTypes
                             on m.TransmissionTypeId equals t.Id
                             join e in context.EngineTypes
                             on m.EngineId equals e.Id
                             join bs in context.BodyStyles
                             on m.BodyStyleId equals bs.Id
                             join b in context.Brands
                             on m.BrandId equals b.Id
                             join col in context.Colours
                             on c.ColourId equals col.Id
                             select new CarDetailDto
                             {
                                 CarId = c.Id,
                                 Mileage = c.Mileage,
                                 Year = c.Year,
                                 ModelName = m.ModelName,
                                 Colour = col.Description,
                                 BodyStyle = bs.Description,
                                 Brand = b.Description,
                                 EngineType = e.Description,
                                 TransmissionType = t.Description
                             };
                             
                return result.ToList();
            }
        }

        public List<CarDetailDto> GetAllCarDetailsByAuctionId(int auctionId)
        {
            using (AuctionsContext context = new AuctionsContext())
            {
                var result = from c in context.Cars
                             join m in context.Models
                             on c.ModelId equals m.Id
                             join t in context.TransmissionTypes
                             on m.TransmissionTypeId equals t.Id
                             join e in context.EngineTypes
                             on m.EngineId equals e.Id
                             join bs in context.BodyStyles
                             on m.BodyStyleId equals bs.Id
                             join b in context.Brands
                             on m.BrandId equals b.Id
                             join col in context.Colours
                             on c.ColourId equals col.Id
                             where c.AuctionId == auctionId
                             select new CarDetailDto
                             {
                                 CarId = c.Id,
                                 Mileage = c.Mileage,
                                 Year = c.Year,
                                 ModelName = m.ModelName,
                                 Colour = col.Description,
                                 BodyStyle = bs.Description,
                                 Brand = b.Description,
                                 EngineType = e.Description,
                                 TransmissionType = t.Description
                             };

                return result.ToList();
            }
        }

        public CarDetailDto GetCarDetailsById(int id)
        {
            using (AuctionsContext context = new AuctionsContext())
            {
                var result = from c in context.Cars
                             join m in context.Models
                             on c.ModelId equals m.Id
                             join t in context.TransmissionTypes
                             on m.TransmissionTypeId equals t.Id
                             join e in context.EngineTypes
                             on m.EngineId equals e.Id
                             join bs in context.BodyStyles
                             on m.BodyStyleId equals bs.Id
                             join b in context.Brands
                             on m.BrandId equals b.Id
                             join col in context.Colours
                             on c.ColourId equals col.Id
                             where c.Id == id
                             select new CarDetailDto
                             {
                                 CarId = c.Id,
                                 Mileage = c.Mileage,
                                 Year = c.Year,
                                 ModelName = m.ModelName,
                                 Colour = col.Description,
                                 BodyStyle = bs.Description,
                                 Brand = b.Description,
                                 EngineType = e.Description,
                                 TransmissionType = t.Description
                             };

                return result.SingleOrDefault();
            }

        }
    }
}
