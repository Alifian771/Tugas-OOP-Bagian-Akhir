using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractClass
{
    public class Segitiga : Bangundatar
    {
        	public int s = 0;
       	 public float a,t;

        public override void luas()
        {
            Console.Write("Masukkan nilai alas       = ");
            	a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan  tinggi     = ");
            	t = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan  sisi       = ");
            	s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Luas Segitiga             = " + ((a * t) / 2));
        }

        public override void keliling()
        {
            	Console.WriteLine("keliling Segitiga         = " + (s + s + s));
        }
    }
}
