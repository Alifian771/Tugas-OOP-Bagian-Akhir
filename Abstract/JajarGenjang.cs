using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractClass
{
    public class JajarGenjang : Bangundatar
    {
        public int a,t,s;

        public override void luas()
        {
            Console.Write("Masukkan  alas    = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan  tinggi     = ");
            t = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan  sisi       = ");
            s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("luas jajar genjang     = " + (a * t));
        }

        public override void keliling()
        {
            Console.WriteLine("keliling jajar genjang  = " + (s + s + s + s));
        }
    }
}
