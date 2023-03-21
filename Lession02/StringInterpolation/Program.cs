using System;

namespace StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            String Name = "Le Ngoc Anh";
            int age = 20;
            Console.WriteLine("Chao ban " + Name + ", ban da " + age + " tuoi");
            Console.WriteLine("Chao ban {0}, ban da {1} tuoi", Name, age);

            Console.WriteLine($"Chao ban {Name}, ban da {age} tuoi");
        }
    }
}
