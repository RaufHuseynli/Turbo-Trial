using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbo.az
{
   interface Caravan: Car
    {
         public string Furniture { get; set; }
         public string Bed { get; set; }
         public string Kitchen { get; set; }
        // Car class'i gorunmeli oldugundan interface edilmedi, edilmediyine gore error verdi. Need Solution...

    }
}
