using System;
using System.Collections.Generic;
using System.Text;

namespace _2_7
{
    internal class Bird : Animal, IPlayable
    {
        public Bird(string name, int age) : base(name, age)
        {
        }

        public override string Species
        {
            get { return "Bird"; }
        }

        public void Play() 
        {
            Console.WriteLine("羽ばたいて遊ぶ");
        }

        public override void Speak()
        {
            Console.WriteLine("ピヨピヨ");
        }
        public void fly() 
        {
            Console.WriteLine("飛んでいます");
        }

        public override void MoveCore()
        {
            Console.WriteLine("飛ぶ");
        }
    }
}
