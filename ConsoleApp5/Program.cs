using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.ReadLine();
        }
        static int Sahe(int side1, int side2, int side3,string fiqur)
        {
            int result;
            if (fiqur == "cevre")
            {
                result = side1 * side2 * 3;
            }
            else if (fiqur == "duzbucaqli")
            {
                result = side1 * side2;
            }
            else if(fiqur=="duzbucaqli paralelpiped")
            {
                result = 2 * (side1 * side2 + side1 * side3 + side2 * side3);
            }
            else if (fiqur == "D.D.C.C.S")
            {
                result = side1 * (side1 + side2 + side3) / 2;
            }
            else
            {
                result = -1;
            }
            return result;

            
        }
    }
}
