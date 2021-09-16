using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX21StreamWriter
{
    class Program
    {

        //static void Main(string[] args)
        //{
        //    /* OPG 1.1
        //    using (StreamWriter writer = new StreamWriter(@"C:\Users\will5606\Desktop\MyFile.txt"))
        //    {

        //        writer.Write("Dette bliver skrevet på en linje");
        //        writer.Write("..og det her fortsætter på samme linje");

        //        writer.WriteLine("..det her står på næste linje, men afsluttes med nyt linjeskift");
        //        writer.WriteLine("Forskellen på Write og WriteLine er altså om den bliver afsluttet med nyt linjeskift eller ej");
        //        writer.WriteLine("1");
        //        writer.WriteLine("2");
        //    }
        //    */

        //    using (StreamWriter writer = new StreamWriter(@"C:\Users\will5606\Desktop\RndNum.txt"))
        //    {
        //        Random rnd = new Random();

        //        for (int i = 0; i < 101; i++)
        //        {
        //            writer.WriteLine(rnd.Next(1, 7));
        //        }
        //    }

        //    Console.ReadKey();
        //}



        //OPG 1.2 Ekstra 

        //public static void SaveRandomNumbers(int num, string path)
        //{
        //    using (StreamWriter writer = new StreamWriter(path + "\\SaveRandomNumbers.txt"))
        //    {
        //        Random rnd = new Random();

        //        for (int i = 0; i < num + 1; i++)
        //        {
        //            writer.WriteLine(rnd.Next());
        //        }
        //    }

        //}

        //static void Main(string[] args)
        //{
        //    string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        //    SaveRandomNumbers(10, path);

        //    Console.ReadKey();
        //}


        //OPG 1.3 Plus ekstra
        static void Main(string[] args)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            using (StreamReader reader = new StreamReader(path + "\\RndNum.txt"))
            {
                string fullPath = path + "\\RndNum.txt";

                List<int> values = new List<int>();
                List<int> count = new List<int>();

                while (!reader.EndOfStream)
                {
                    string line;
                    line = reader.ReadLine();

                    values.Add(int.Parse(line));
                }

                values.Sort();

                int counter = 0;
                int num = 1;

                foreach (var item in values)
                {
                    if (item == num)
                    {
                        counter++;

                    }
                    else
                    {
                        Console.WriteLine(num + "- Taller: " + counter);
                        num = item;
                        counter = 1;
                    }
                }
                Console.WriteLine(num + "- Taller: " + counter);

                Console.WriteLine("Afslut");

                //int[] tempArray = new int[values.Count];

                //values.CopyTo(tempArray);
                

            //    int i = 0;
            //    int awr;
            //    int a = 1;

            //    count.Add(0);

            //    foreach (var item in values)
            //    {
            //        awr = item - 1;
            //        bool isFinished = false;

            //        while (!isFinished)
            //        {
            //            foreach (var element in tempArray)
            //            {
            //                count.Insert(awr, i++);
            //                if (element == a)
            //                {
            //                    isFinished = true;
            //                }
            //            }
            //        }

            //        count.Add(item);

            //        if (item == a)
            //        {
            //            i = 0;
            //            a++;
            //        }

            //    }

            //    foreach (int item in count)
            //    {
            //        Console.WriteLine(count.ToString());
            //    }
                

                
            }

            Console.ReadKey();
        }

    }
}
