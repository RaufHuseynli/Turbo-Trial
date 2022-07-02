using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbo.az
{
   public class Announcement
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
        public int CreatedByUserId { get; set; }
        public ContactofSeller CreatedByUser { get; set; }

    }
}
