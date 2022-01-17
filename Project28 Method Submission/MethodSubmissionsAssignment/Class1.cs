using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionsAssignment
{
    public class Class1
    {
        public int Adding(int x)
        {
            x = x + 20;
            return x;

        }

        public int Adding(decimal x)
        {
            x = x * 30;
            return Convert.ToInt32(x);
        }
        public int Adding(string x)
        {
           
                int y = Convert.ToInt32(x);
                y = y * 5;
                return y;
            
        }

    }
}
