using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGit
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    static class Function
    {
        //HamTinhGiaThua
        public static int GiaiThua(int input)
        {
            if (input==1)
            {
                return 1;
            }
            return input*GiaiThua(input-1);
        }  
        
        public static int Fibonanci(int position)
        {
            if (position==1)
            {
                return 1;
            }
            if (position == 0)
            {
                return 0;
            }
            return Fibonanci(position - 2) + Fibonanci(position);
        }      
    } 
}
