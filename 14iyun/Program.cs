using System;

namespace _14iyun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Human[] human = new Human[]
            //{
            //    new Human (34, "Heyder", "Velieyev"),
            //    new Human (45,"Ali", "Aliyev"),
            //    new Human (25, "Cahangir", "Shirinov")
            //};
            //Console.WriteLine("Axtaris deyeri daxil edin: ");
            //string input  = Console.ReadLine();
            //for (int i = 0; i < human.Length; i++)
            //{
            //    if (human[i].Name.Contains(input))
            //    {
            //        Console.WriteLine(human[i].Name);
            //    }
            //}

            int count;
            do
            {
                Console.WriteLine("Sudlerin sayini yazin");
            } while (!int.TryParse(Console.ReadLine(), out count));

            Milk[] milks = new Milk[count];
            for (int i = 0; i < milks.Length; i++)
            {
                Console.WriteLine($"{i + 1}. Sudun adini yazin");
                string name = Console.ReadLine();
                double price;
                do
                {
                    Console.WriteLine($"{i + 1}. Sudun qiymetini yazin");
                } while (!double.TryParse(Console.ReadLine(), out price));

                double fatPercent;
                do
                {
                    Console.WriteLine($"{i + 1}. Sudun yaglilig faizini yazin");
                } while (!double.TryParse(Console.ReadLine(), out fatPercent));
                milks[i] = new Milk();
                milks[i].Name = name;
                milks[i].Price = price;
                milks[i].FatPercent = fatPercent;
            }



        }
    }
}
