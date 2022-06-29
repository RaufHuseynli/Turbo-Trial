using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbo.az
{
    class Marka
    {
        public string Id { get; set; }
        public int ModelId { get; set; }
        public Model Model { get; set; }
        public string  Description { get; set; }
    }
}
