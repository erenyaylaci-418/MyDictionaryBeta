using System;

namespace MyDictionaryBeta
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, int> myDictionary = new MyDictionary<int, int>();
            myDictionary.Add(1, 5);
            myDictionary.Add(7, 4);
            myDictionary.Add(3, 4);

            //Uzunluk//
            int uzunluk = myDictionary.Lenght;
            Console.WriteLine(uzunluk + "////////////");

            //Listeleme//
            foreach (var item in myDictionary.First)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("****************");
            foreach (var item in myDictionary.Second)
            {
                Console.WriteLine(item);
            }
        }

    }
}
