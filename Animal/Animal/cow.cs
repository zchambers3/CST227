using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    class cow : Animal
    {
        public void MilkMe()
        {
            Console.WriteLine("Time to fill the bucket full of milk.");
        }
        public void MakeBread()
        {
            Console.WriteLine("create bread by using the milk from the bucket! ");
        }
        public void Sing()
        {
            Console.WriteLine("MOOOOO");
        }
    }
}
