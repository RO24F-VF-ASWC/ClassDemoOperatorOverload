using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoOperatorOverload
{
    public static class PositionExt
    {

        public static bool IsValid(this Position pos)
        {
            return pos.X >= 0 && pos.Y >= 0;
        }



        
    }
}
