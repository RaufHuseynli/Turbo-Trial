using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbo.az.Car_and_extends
{
    interface Truck:Car
    {
        void SuspensionDumping();
        void TyreStifness();
        void BodyMass();
    }
}
