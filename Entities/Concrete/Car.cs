using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Car : IEntity
    {
        public int Id { get; set; }
        public int ModelId { get; set; }
        public int ColourId { get; set; }
        public int AuctionId { get; set; }
        public int Mileage { get; set; }
        public int Year { get; set; }

    }
}
