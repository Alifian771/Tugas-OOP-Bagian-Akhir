using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractClass
{
    public class Persegi : Bangundatar
    {
       	 public int s;

       	 public override void luas()
        {
            Console.Write("Masukkan  sisi       = ")	;
            	s = Convert.ToInt32(Console.ReadLine())	;
            Console.WriteLine("Luas Persegi             = " + (s * s));
        }

        public override void keliling()
        {
           Console.WriteLine("Keliling Persegi         = " + (4 * s));
        }
    }
}
