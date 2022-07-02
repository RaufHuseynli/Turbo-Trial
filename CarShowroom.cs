using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbo.az
{
    class CarShowroom 
    { 
      public int Id { get; set; }
        public int AnnouncementId { get; set; }
        Announcement Announcement { get; set; }
    }
}
