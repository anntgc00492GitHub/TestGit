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
    } 
}
