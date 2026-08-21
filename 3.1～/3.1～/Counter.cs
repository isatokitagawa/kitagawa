using System;
using System.Collections.Generic;
using System.Text;

namespace _3._1_
{
    internal class Counter
    {
        public static int count = 0;

        public Counter() {
            count++;
        }
        public static int GetCount() { 
            return count;
        }
    }
}
