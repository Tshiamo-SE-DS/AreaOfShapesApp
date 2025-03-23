using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAreasOfShapesApp
{
    public abstract class Shapes
    {
        //First option using virtual
        public virtual void CalculateArea() { }

        //First option using abstract
        //public abstract void CalculateArea2();
    }
}
