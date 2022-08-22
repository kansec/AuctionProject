using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetAllByAuctionId(int auctionId);
        IDataResult<List<CarDetailDto>> GetAllCarDetails();
        IDataResult<List<CarDetailDto>> GetAllCarDetailsByAuctionId(int auctionId);
        IDataResult<Car> GetById(int id);
        IDataResult<CarDetailDto> GetCarDetailById(int id);
        IResult Add(Car car);
        IResult Update(Car car);

    }
}
