using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    public class Persegi : ItfBangundatar
    {
        public int x;

        public void luas()
        {
            Console.Write("Masukkan nilai sisi       = ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Luas Persegi              = " + (x * x));
        }

        public void keliling()
        {
            Console.WriteLine("keliling persegi          = " + (4 * x));
        }
    }
}
