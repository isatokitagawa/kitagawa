namespace _2_7
{
    using System;
    using static System.Runtime.InteropServices.JavaScript.JSType;

    //class Dog
    //{
    //    private string mName = "";
    //    private int age = 0;
    //    private string Type = "";

    //    public string Name
    //    {
    //        get { return mName; }
    //        set { mName = value; }
    //    }

    //    public int Age
    //    {
    //        get { return age; }
    //        set { age = value; }
    //    }

    //    public Dog(string type)
    //    {
    //        this.Type = type;
    //    }

    //    public void ShowProfile()
    //    {
    //        Console.WriteLine("名前："+mName);
    //        Console.WriteLine("年齢：" + age);
    //        Console.WriteLine("犬種：" + Type);
    //    }

    //    static void Main(string[] args)
    //    {
    //        Dog dog = new Dog("コーギー");

    //        dog.Name = "ポチ";

    //        dog.Age = 5;

    //        dog.ShowProfile();

    //        Dog dog1 = new Dog("柴犬");

    //        dog1.Name = "ワン";

    //        dog1.Age = 6;

    //        dog1.ShowProfile();

    //        Dog dog2 = new Dog("ブルドッグ");

    //        dog2.Name = "ドン";

    //        dog2.Age = 10;

    //        dog2.ShowProfile();
    //    }
    //}

    //class CoinCase
    //{
    //    private int coin500;
    //    private int coin100;
    //    private int coin50;
    //    private int coin10;
    //    private int coin5;
    //    private int coin1;

    //    public void AddCoins(int type, int count)
    //    {
    //        switch (type)
    //        {
    //            case 500:
    //                coin500 += count;
    //                break;
    //            case 100:
    //                coin100 += count;
    //                break;
    //            case 50:
    //                coin50 += count;
    //                break;
    //            case 10:
    //                coin10 += count;
    //                break;
    //            case 5:
    //                coin5 += count;
    //                break;
    //            case 1:
    //                coin1 += count;
    //                break;
    //        }
    //    }
    //    public int GetCount(int type)
    //    {
    //        switch (type)
    //        {
    //            case 500:
    //                return coin500;
    //            case 100:
    //                return coin100;
    //            case 50:
    //                return coin50;
    //            case 10:
    //                return coin10;
    //            case 5:
    //                return coin5;
    //            case 1:
    //                return coin1;
    //            default:
    //                throw new ArgumentException("存在しない硬貨です。");
    //        }
    //    }

    //    public int GetAmount()
    //    {
    //        return coin500 * 500
    //             + coin100 * 100
    //             + coin50 * 50
    //             + coin10 * 10
    //             + coin5 * 5
    //             + coin1;
    //    }

    //    static void Main(string[] args)
    //    {
    //        CoinCase coincase = new CoinCase();

    //        for (int i = 0; i < 10; i++)
    //        {
    //            Console.Write("硬貨の種類：");
    //            int type = int.Parse(Console.ReadLine());

    //            Console.Write("枚数：");
    //            int count = int.Parse(Console.ReadLine());

    //            coincase.AddCoins(type, count);
    //        }

    //        Console.WriteLine("500円：" + coincase.GetCount(500) + "枚");
    //        Console.WriteLine("100円：" + coincase.GetCount(100) + "枚");
    //        Console.WriteLine("50円：" + coincase.GetCount(50) + "枚");
    //        Console.WriteLine("10円：" + coincase.GetCount(10) + "枚");
    //        Console.WriteLine("5円：" + coincase.GetCount(5) + "枚");
    //        Console.WriteLine("1円：" + coincase.GetCount(1) + "枚");

    //        Console.WriteLine("総額：" + coincase.GetAmount() + "円");
    //    }

    //}

    class Program
    {
        static void Main()
        {
            //Animal[] animals = new Animal[4];

            //animals[0] = new Cat("タマ", 10);
            //animals[1] = new Dog("ポチ", 9);
            //animals[2] = new Cat("ミケ", 5);
            //animals[3] = new Dog("コロ", 7);

            //for (int i = 0; i < animals.Length; i++)
            //{
            //    animals[i].ShowProfile();
            //    animals[i].Speak();
            //}

            //Animal obj1 = new Dog("ポチ", 9);
            //Animal obj2 = new Cat("タマ", 10);

            //Console.WriteLine(obj1);
            //Console.WriteLine(obj2);

            //Cat cat = new Cat("タマ",10);
            //Console.WriteLine("Cat型で呼び出す場合");
            //cat.ShowKind();

            //Animal animal = cat;
            //Console.WriteLine("Animal型で呼び出す");
            //animal.ShowKind();

            //List<Animal> animals = new List<Animal>();
            //animals.Add(new Cat("タマ", 10));
            //animals.Add(new Dog("ポチ", 9));
            //animals.Add(new Cat("ミケ", 5));
            //animals.Add(new Dog("コロ", 7));
            //animals.Add(new Bird("ピヨ", 1));

            //Animal animal = new Dog("ポチ", 9);

            //animal.Walk();
            //animal.Walk(3);

            //foreach (Animal animal in animals)
            //{
            //    animal.DoDaily();
            //}

            //foreach (Animal animal in animals)
            //{

            //    Console.WriteLine(
            //    $"Species: {animal.Species}, Name: {animal.Name}, Age: {animal.Age}"
            //);

            //Console.WriteLine(animal);
            //animal.Speak();
            //if (animal is Bird b)
            //{
            //    b.fly();
            //}
            //}

            //Animal a = new Cat("タマ", 10);

            //// ① 明示的キャスト
            //Dog dog1 = (Dog)a;
            //dog1.Walk();
            ////(Dog)a = 強制変換

            //// ② as演算子 + nullチェック
            //Dog? dog2 = a as Dog;

            //if (dog2 != null)
            //{
            //    dog2.Walk();
            //}
            ////as = 失敗したらnull

            //// ③ パターンマッチング
            //if (a is Dog d)
            //{
            //    d.Walk();
            //}
            ////is = その型なら実行

            //Dog dog = new Dog("ポチ", 9);
            //Cat cat = new Cat("タマ", 10);
            //Bird bird = new Bird("ピヨ", 1);

            //// IPlayableとして保持
            //List<IPlayable> playables = new List<IPlayable>();

            //playables.Add(dog);
            //playables.Add(cat);
            //playables.Add(bird);

            //Console.WriteLine("=== IPlayableとしてPlay() ===");

            //foreach (IPlayable playable in playables)
            //{
            //    playable.Play();
            //}

            // Animalとして同じ個体を保持
            List<Animal> animals = new List<Animal>();

            Console.Write("頭数を入力してください: ");
            int n = int.Parse(Console.ReadLine());

            // 動物を登録
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                string species = input[0];
                string name = input[1];
                int age = int.Parse(input[2]);

                Animal animal = null;

                if (species == "Dog")
                {
                    animal = new Dog(name, age);
                }
                else if (species == "Cat")
                {
                    animal = new Cat(name, age);
                }
                else if (species == "Bird")
                {
                    animal = new Bird(name, age);
                }

                if (animal != null)
                {
                    animals.Add(animal);
                }
            }

            Console.WriteLine();
            Console.WriteLine("=== 動物一覧 ===");

            // Speak、ShowProfile、Play
            foreach (Animal animal in animals)
            {
                animal.ShowProfile();
                animal.Speak();

                if (animal is IPlayable playable)
                {
                    playable.Play();
                }

                Console.WriteLine();
            }

            // 種類別頭数
            Dictionary<string, int> count = new Dictionary<string, int>();

            foreach (Animal animal in animals)
            {
                if (count.ContainsKey(animal.Species))
                {
                    count[animal.Species]++;
                }
                else
                {
                    count.Add(animal.Species, 1);
                }
            }

            Console.WriteLine("=== 種類別頭数 ===");

            foreach (KeyValuePair<string, int> item in count)
            {
                Console.WriteLine($"{item.Key}: {item.Value}匹");
            }
        }
    }
}

    
