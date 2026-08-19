using System;
using System.Collections.Generic;
using System.Text;

namespace _2_7
{
    internal class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age)
        {
        }
        public override string Species
        {
            get { return "Cat"; }
        }

        public void SleepSound()
        {
            Console.WriteLine("スースー");
        }

        public override void Speak()
        {
            Console.WriteLine("ニャー");
        }
    }
}
