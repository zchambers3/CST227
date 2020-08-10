using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    abstract class Animal
    {
        Boolean isAlive { get; set; }
        int weight { get; set; }
        public Animal()
        {
            Console.WriteLine("Animal Constructor");
        }
        public Animal(Boolean isAlive, int weight)
        {
            this.isAlive = isAlive;
            this.weight = weight;
            Console.WriteLine("Animal Constructor");
        }
        
        public void Greet()
        {
            Console.WriteLine("Animal says 'hello'");
        }

        public void Talk()
        {
            Console.WriteLine("Animal is talking");
        }

        public void Sing()
        {
            Console.WriteLine("Animal is singing");
        }

        public string ToString()
        {
            return "Status: " + isAlive + " Weight: " + weight;
        }
    }
}
