using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVsReadonly
{
    class ConstVReadOnly
    {
            public readonly double PI= 3.1;
            public const int inchesToFeet = 12;
        public ConstVReadOnly()
        {
            this.PI = 3.14;
        }
    }
}


