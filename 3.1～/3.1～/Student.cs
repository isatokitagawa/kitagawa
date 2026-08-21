using System;
using System.Collections.Generic;
using System.Text;

namespace _3._1_
{
    internal class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void ShowProfile()
        {
        Console.WriteLine($"名前: {Name}");
        Console.WriteLine($"年齢: {Age}歳");
        }
    }
}
