using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testapplikation
{
    internal class testklass
    {
        int x;
       public int kvadrat(string x)
        {
            string y = x;
            int kvadrat;
            int.TryParse(y, out kvadrat);
            kvadrat = kvadrat * kvadrat;
            return kvadrat;
        }

        public int delatmed (int x)
        {
            int delat = x / 5;
            return delat;
        }
    }
}
