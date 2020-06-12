using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Abstraction.AbstractClass;      
using Abstraction.Interface;            

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BANGUN DATAR");
            Console.WriteLine();

            Bangundatar bangundatar;  
            ItfBangunDatar bangundatar;   

            Console.WriteLine("1. Persegi");
            bangundatar = new Persegi();
            bangundatar.luas();
            bangundatar.keliling();

            Console.WriteLine();
            Console.WriteLine("2. Jajar Genjang");
            bangundatar = new PersegiPanjang();
            bangundatar.luas();
            bangundatar.keliling();

            Console.WriteLine();
            Console.WriteLine("3. Segitiga");
            bangundatar = new Segitiga();
            bangundatar.luas();
            bangundatar.keliling();

            Console.ReadKey(true);
        }
    }
}
