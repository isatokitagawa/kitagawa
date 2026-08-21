using System.Security.Cryptography.X509Certificates;

namespace _4._1_
{
    internal class Program
    {
        static void CheckAge(int age)
        {
            if (age < 0 || age > 120)
            {
                throw new ArgumentOutOfRangeException();
            }
            Console.WriteLine($"年齢は{age}歳です");
        }
        static void Main(string[] args)
        {
            //try
            //{
            //    int.Parse(Console.ReadLine());
            //}
            //catch (FormatException) {
            //    Console.WriteLine("整数を入力してください");
            //}


            //try
            //{
            //    string text = File.ReadAllText("test.txt");
            //    Console.WriteLine(text);
            //}
            //catch (FileNotFoundException)
            //{
            //    Console.WriteLine("ファイルが存在しません");
            //}
            //finally 
            //{
            //    Console.WriteLine("処理を終了します");
            //}


            //try{
            //    int x = 1;
            //    int y = 0;
            //    Console.WriteLine(x/y);
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("0で割るな！");
            //}

            //try {
            //    int[] numbers = { 10, 20, 30 };
            //    Console.WriteLine(numbers[3]);
            //}
            //catch(IndexOutOfRangeException)
            //{
            //    Console.WriteLine("存在しません");
            //}



            //Console.Write("年齢を入力してください: ");
            //int age = int.Parse(Console.ReadLine());

            //try
            //{
            //    CheckAge(age);
            //}
            //catch (ArgumentOutOfRangeException)
            //{
            //    Console.WriteLine("入力が不正です");
            //}


            //try
            //{
            //    int x = int.Parse(Console.ReadLine());
            //    int y = int.Parse(Console.ReadLine());
            //    int z = x / y;
            //    Console.WriteLine(z);
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("0では割れません");
            //}
            //catch (FormatException x)
            //{
            //    Console.WriteLine("数値を入力してください");
            //}


            //int total = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    total += i;
            //}
            //Console.WriteLine("合計は " + total);


            try
            {
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());
                Console.WriteLine("+ or - or * or /");
                string z = Console.ReadLine();
                if (z == "+")
                {
                    int a = x + y;
                    Console.WriteLine(a);
                }
                else if (z == "-")
                {
                    int a = x - y;
                    Console.WriteLine(a);
                }
                else if (z == "*")
                {
                    int a = x * y;
                    Console.WriteLine(a);
                }
                else if (z == "/")
                {
                    int a = x / y;
                    Console.WriteLine(a);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("数値を入力してください");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("0では割れません");
            }

        }
    }
}

