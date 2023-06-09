using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baimoi1
{
    class Program
    { 
        public static void Main ()
        {
            Car myCar;
            System.Console.WriteLine("Createing a Car object and assigning" + "its memory location to myCar");
            myCar = new Car();
            myCar.make = " Toyota";
            myCar.model = "MR2";
            myCar.yearBuilt = 1995;

            System.Console.WriteLine("myCar details : ");
            System.Console.WriteLine("myCar.make =" +myCar.make);
            System.Console.WriteLine("myCar.model=" + myCar.model);
            System.Console.WriteLine("myCar.color=" + myCar.color);
            System.Console.WriteLine("myCar.yearBuilt=" + myCar.yearBuilt);

            myCar.Start();
            myCar.Stop();

            System.Console.WriteLine("Creating another car object and " + "assigning its memory locatin to redPorsche");
            Car redPorsche = new Car();
            redPorsche.make = "Porsche";
            redPorsche.model = "Boxster";
            redPorsche.color = "red";
            redPorsche.yearBuilt = 2000;
            System.Console.WriteLine("redPorsche id a " + redPorsche.model);
            System.Console.WriteLine("Assigning redPorsche to myCar");
            myCar = redPorsche;
            System.Console.WriteLine("myCar details");
            System.Console.WriteLine("myCar.make =" + myCar.make);
            System.Console.WriteLine("myCar.model = " + myCar.model);
            System.Console.WriteLine("myCar.color = " + myCar.color);
            System.Console.WriteLine("myCar.yearBuilt = " + myCar.yearBuilt);

            myCar = null;
            Console.ReadLine();
            



        }
    }
}
