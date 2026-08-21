using System;
using System.Collections.Generic;
using System.Text;

namespace _2_7
{
    internal class Cat : Animal, IPlayable
    {
        public Cat(string name, int age) : base(name, age)
        {
        }

        public new void ShowKind() 
        {
            Console.WriteLine("猫です");
        }

        public void Play()
        {
            Console.WriteLine("じゃれる");
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

        public override void MoveCore()
        {
            Console.WriteLine("歩く");
        }
    }
}
