using System;
using System.Collections.Generic;
using System.Text;

namespace _2_7
{
    abstract class Animal
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        private readonly string species;

        public override string ToString()
        {
            return $"[動物] 名前: {Name}, 年齢: {Age}";
        }
        public virtual string Species
        {
            get { return "Animal"; }
        }

        public virtual void Walk() 
        {
             Console.WriteLine("とことこ歩く");
        }
        public void Walk(int steps) {
            Console.WriteLine("3歩歩いた");
        }

        public abstract void Speak();        
    }
}
