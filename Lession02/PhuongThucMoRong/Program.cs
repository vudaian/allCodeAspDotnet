using System;

namespace PhuongThucMoRong
{
    static class MyClass
    {
        /*
        * Phương thức mở rộng là một phương thức được viết thêm vào 1 static class
        * đã có
        */
        public static int DemTu(this string str)
        {
            return str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Truong Dai hoc Dai Nam";
            Console.WriteLine(str.DemTu());
        }
    }
}
