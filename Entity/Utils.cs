using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Utils
    {
        public static int generarRandomId()
        {
            Random rnd = new Random();
            return rnd.Next();
        }
    }
}
