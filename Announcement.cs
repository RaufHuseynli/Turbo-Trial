using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbo.az
{
    class Announcement
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public int CarId { get; set; }
            //Create relation between NewAnnouncement with VehicleId and CarId
    }
}
