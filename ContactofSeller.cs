using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbo.az
{
    public class ContactofSeller
    {
        public int Id { get; set; }
        public int AnnouncementId { get; set; }
        public Announcement Announcement { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ContactNumber { get; set; }


    }
}
