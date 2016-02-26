using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D8T1
{
    class Noppa
    {
        private static readonly Random staticRand = new Random();

        public static int Nopanheitto()
        {
            return staticRand.Next(6) + 1;
        }
    }
}
