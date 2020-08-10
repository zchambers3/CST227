using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    class Dog : Animal, IDomesticated
    {
        public Dog(bool isAlive, int weight) : base(isAlive, weight)
        {
        }

        public void Talk()
        {
            Console.WriteLine("Bark bark bark");
        }

        public void Sing()
        {
            Console.WriteLine("OOOWwwwOO");
        }

        public void Fetch(string thing)
        {
            Console.WriteLine("here you go. Here is your " + thing + " That was fun let's do it again");
        }

        public void TouchMe()
        {
            Console.WriteLine("Please scratch behind my ears");
        }

        public void FeedMe()
        {
            Console.WriteLine("Suppertime! The very best time of day!");
        }
    };
}
