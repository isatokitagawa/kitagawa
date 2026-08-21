namespace _5._1_
{
    using System;
    using System.IO;
    using System.Reflection.PortableExecutable;

    class Program
    {
        static void Main()
        {
            //using (StreamWriter writer = new StreamWriter("output.txt"))
            //{
            //    writer.WriteLine("こんにちは！");
            //    writer.WriteLine("私はC#を勉強しています。");
            //    writer.WriteLine("よろしくお願いします。");
            //}

            //Console.WriteLine("書き込みが完了しました");


            //string path = "output.txt";
            //try
            //{
            //    using (StreamReader sr = new StreamReader(path))
            //    {
            //        int lineNumber = 1;
            //        string line;

            //        while ((line = sr.ReadLine()) != null)
            //        {
            //            Console.WriteLine(lineNumber + ": " + line);
            //            lineNumber++;
            //        }
            //    }
            //}
            //catch(FileNotFoundException)
            //{
            //    Console.WriteLine("ファイルが見つかりませんでした");
            //}


            //using (StreamWriter writer = new StreamWriter("append.txt"))
            //{
            //    writer.WriteLine("初期化しました");
            //}
            //    Console.WriteLine("書き込みが完了しました");

            //try
            //{
            //    string n = Console.ReadLine();
            //    using (StreamReader sr = new StreamReader(n))
            //    {
            //        int lineNumber = 1;
            //        string line;

            //        while ((line = sr.ReadLine()) != null)
            //        {
            //            Console.WriteLine(lineNumber + ": " + line);
            //            lineNumber++;
            //        }
            //    }
            //}
            //catch (FileNotFoundException)
            //{
            //    Console.WriteLine("存在しません");
            //}


            //string dirpath = "data/logs";
            //Directory.CreateDirectory(dirpath);
            //string filePath = Path.Combine(dirpath, "today.txt");
            //using (StreamWriter writer = new StreamWriter(filePath))
            //{
            //    writer.WriteLine("今日もC#を勉強しました");
            //}
            //Console.WriteLine("書き込みが完了しました");


            //string path = "data";
            //string[]files = Directory.GetFiles(path, "*.txt");
            //foreach(string file in files)
            //{
            //    FileInfo info = new FileInfo(file);
            //    Console.WriteLine("ファイル名：" + info.Name);
            //    Console.WriteLine("サイズ：" + info.Length + "バイト");
            //    Console.WriteLine("最終更新日時：" + info.LastWriteTime);
            //    Console.WriteLine();
            //}


            //string path = "quick.txt";
            //string[] lines =
            //{
            //    "C#を勉強しています。",
            //    "File.WriteAllLinesを使っています。",
            //    "ファイル操作の練習中です。"
            //};

            //// 一括書き込み
            //File.WriteAllLines(path, lines);

            //// 読み込み
            //string[] readLines = File.ReadAllLines(path);

            //// 全行を表示
            //foreach (string line in readLines)
            //{
            //    Console.WriteLine(line);
            //}














        }
    }
}
