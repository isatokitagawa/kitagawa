using System.Security.Cryptography.X509Certificates;

namespace _2_6_1___
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int x=int.Parse(Console.ReadLine());
            //int a = Mondai2_6_1(x);
            //Console.WriteLine(a);

            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());
            //int a = Mondai2_6_2(x,y);
            //Console.WriteLine(a);

            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());
            //int a = Mondai2_6_3(x, y);
            //Console.WriteLine(a);

            int[] ha = new int[5];
            Console.WriteLine("数値を入力してください。");
            for (int i = 0; i < 5; i++) {
                Console.Write((i+1)+"回目:");
                ha[i] = int.Parse(Console.ReadLine());
            }
            int a = max(ha);
            Console.WriteLine(ha[a]);

        }

        public static int max(int[] a){
            int m = 0;
            for (int i=1; i<a.Length; i++) {
                if (a[m] < a[i])
                {
                    m=i;
                }
            }
            return m;
        }

        //public static int Mondai2_6_1(int x)
        //{
        //    return (x * x);
        //}

        //public static int Mondai2_6_2(int x, int y) {
        //    return ((x+y)/2);
        //}

        //public static int Mondai2_6_3(int x, int y)
        //{
        //    if (x < y)
        //    {
        //        return y;
        //    }
        //    else {
        //        return x;
        //    }
        //}

    }
}
