using System.Runtime.InteropServices.Marshalling;

namespace _20260817
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("xの値を入力してください");
            //int x = int.Parse(Console.ReadLine());

            //Console.WriteLine("yの値を入力してください");
            //int y = int.Parse(Console.ReadLine());

            //int a = Mondai2_2_3(x, y);
            //Console.WriteLine(a);

            //Console.WriteLine("年齢を入力してください");
            //int x = int.Parse(Console.ReadLine());

            //int a = Mondai2_2_4(x);
            //Console.WriteLine(a);

            //Console.WriteLine("xの値を入力してください");
            //int x = int.Parse(Console.ReadLine());

            //Console.WriteLine("yの値を入力してください");
            //int y = int.Parse(Console.ReadLine());

            //Mondai2_3_1(x, y);

            //Console.WriteLine("xの値を入力してください");
            //int x = int.Parse(Console.ReadLine());

            //Console.WriteLine("yの値を入力してください");
            //int y = int.Parse(Console.ReadLine());

            //Mondai2_3_2(x, y);

            //Console.WriteLine("点数を入力してください");
            //int x = int.Parse(Console.ReadLine());
            //Mondai2_3_4(x);

            //Console.WriteLine("xの値を入力してください");
            //int x = int.Parse(Console.ReadLine());

            //Console.WriteLine("yの値を入力してください");
            //int y = int.Parse(Console.ReadLine());

            //Mondai2_3_5(x, y);

            //Console.WriteLine("お好きな寿司を選んでください");
            //Console.WriteLine("1:まぐろ 2:えび 3:こはだ 4:あなご 5:いくら");
            //int su = int.Parse(Console.ReadLine());
            //switch (su)
            //{
            //    case 1:
            //        Console.WriteLine("まぐろ");
            //        break;

            //    case 2:
            //        Console.WriteLine("えび");
            //        break;

            //    case 3:
            //        Console.WriteLine("こはだ");
            //        break;

            //    case 4:
            //        Console.WriteLine("あなご");
            //        break;

            //    case 5:
            //        Console.WriteLine("いくら");
            //        break;
            //}

            //for (int i = 0; i < 10; i++) {
            //    Console.WriteLine("spam");
            //}
            //for (int i = 3; i <= 27; i+=3) {
            //    Console.WriteLine(i);
            //}

            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());
            //int d = int.Parse(Console.ReadLine());
            //int e = int.Parse(Console.ReadLine());
            //int f = int.Parse(Console.ReadLine());
            //int g = int.Parse(Console.ReadLine());
            //int h = int.Parse(Console.ReadLine());
            //int i = int.Parse(Console.ReadLine());
            //int j = int.Parse(Console.ReadLine());
            //Console.WriteLine((a+b+c+d+e+f+g+h+i+j)/10);

            //int b = 0;
            //for (int i = 0; i < 10; i++) {
            //    int a = int.Parse(Console.ReadLine());
            //    b += a;            
            //}
            //Console.WriteLine(b/10);

            //int c = 0;
            //int d = 0;
            //for (int i = 1; i < 10; i++)
            //{
            //    Console.Write(i+"回表、巨人の得点は？");
            //    int a = int.Parse(Console.ReadLine());
            //    Console.Write(i + "回裏、阪神の得点は？");
            //    int b = int.Parse(Console.ReadLine());
            //    c += a;
            //    d += b;
            //}
            //Console.WriteLine("巨人:"+c+"点,阪神:"+ d +"点");
            //if (c < d)
            //{
            //    Console.WriteLine("阪神の勝ち");
            //}
            //else {
            //    Console.WriteLine("巨人の勝ち");
            //}
            //int st = 0;
            //int bo = 0;
            //for (int i = 0; i < 10000; i++)
            //{
            //    Console.WriteLine("ストライク=1 or ボール=2 or ファール=3　？");
            //    int x = int.Parse(Console.ReadLine());
            //    if (x == 1)
            //    {
            //        st++;
            //    }
            //    else if (x == 2)
            //    {
            //        bo++;
            //    }
            //    else if (x == 3 && st < 2)
            //    {
            //        st++;
            //    }
            //    if (st == 3 || bo == 4)
            //    {
            //        Console.WriteLine(bo + "ボール," + st + "ストライク");
            //        break;
            //    }

            //}

            int[] scores = new int[10];
            for (int i = 0; i < scores.Length; i++)
            {
                Console.Write($"{i + 1}人目の点数を入力してください: ");
                scores[i] = int.Parse(Console.ReadLine());
            }




            //public static int Mondai2_2_3(int x, int y)
            //{
            //    return((x+y)/2);
            //}
            //public static int Mondai2_2_4(int x)

            //{
            //    return (x * 365);
            //}

            //public static void Mondai2_3_2(int x, int y)
            //{
            //    if (x > y)
            //    {
            //        Console.WriteLine(x + "は" + y + "より大きい");
            //    }
            //    else if (x < y)
            //    {
            //        Console.WriteLine(x + "は" + y + "より小さい");
            //    }
            //    else
            //    {
            //        Console.WriteLine(x + "と" + y + "は等しい");
            //    }
            //    return;
            //}

            //public static void Mondai2_3_3(int x)
            //{
            //    if (x % 2 == 0)
            //    {
            //        Console.WriteLine(x + "は偶数です");
            //    }
            //    else
            //    {
            //        Console.WriteLine(x+"は奇数です");
            //    }
            //return;
            //}

            //public static void Mondai2_3_4(int x)
            //{
            //    if (x >= 80)
            //    {
            //        Console.WriteLine("合格");
            //        Console.WriteLine("たいへんよくできました");
            //        Console.WriteLine("優");
            //    }
            //    else if (x >=70)
            //    {
            //        Console.WriteLine("合格");
            //        Console.WriteLine("よくできました");
            //        Console.WriteLine("良");
            //    }
            //    else if (x >=60)
            //    {
            //        Console.WriteLine("合格");
            //        Console.WriteLine("よくできました");
            //        Console.WriteLine("可");
            //    }

            //    else
            //    {
            //        Console.WriteLine("不合格");
            //        Console.WriteLine("ざんねんでした");
            //        Console.WriteLine("不可");
            //    }       
            //}

            //public static void Mondai2_3_5(int x, int y)
            //{
            //    if (x < y && x % 2 == 0 && y % 2 == 0) {
            //        Console.WriteLine("xはyより小さく、かつ、xとyは共に偶数である。");
            //    }
            //    if (x==y && x<0 && y<0) {  
            //        Console.WriteLine("xとyは等しく、かつ、負の数である。");
            //    }
            //    if (x < y || x % 2 == 0) {
            //        Console.WriteLine("xはyより小さい、または、xは偶数である。");
            //    }
            //    if (x<=10 || x>=100 && x>=10 && y<=100) {
            //        Console.WriteLine("xは10以下または100以上で、かつ、yは10以上かつ100以下である。");
            //    }
            //    if (!(x < 0 && y < 0)) {
            //        Console.WriteLine("xもyも負の数である、ではない。");
            //    }
            //}
        }
    }
}
