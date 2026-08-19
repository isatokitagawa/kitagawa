using System;
using System.Collections.Generic;
using System.Text;

namespace _2_7
{
    internal class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age)
        {
        }
        public override string Species
        {
            get { return "Dog"; }
        }

        public void WalkSound()
        {
            Console.WriteLine("トコトコ");
        }

        public override void Walk()
        {
            Console.WriteLine("尻尾を振りながら歩く");
        }

        public override void Speak()
        {
            Console.WriteLine("ワンワン");
        }
    }
}
