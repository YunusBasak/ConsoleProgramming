using System;

namespace ConsoleProgramlama
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("İsminizi Giriniz:");
            string name = Console.ReadLine();
            Console.WriteLine("soyadınızı Giriniz:");
            string surname = Console.ReadLine();

            Console.WriteLine("Merhaba! " + name + " " + surname);
        }
    }
}
