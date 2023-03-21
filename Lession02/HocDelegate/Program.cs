using System;

namespace HocDelegate
{
    //1. Khai báo delegate
    //public delegate int TinhToan(int x, int y);
    //public delegate void Display(string name);
    class Program
    {
        public static int TinhTong(int a, int b)
        {
            return a + b;
        }
        public static int TinhHieu(int a, int b)
        {
            return a - b;
        }
        public static void GetInfo(string name)
        {
            Console.WriteLine("Hello: " + name);
        }
        static void Main(string[] args)
        {
            //2. Khởi tạo
            //TinhToan tinhToan = new TinhToan(TinhTong); // Cách 1
            //Func<int, int, int> tinhToan = delegate(int a, int b) {
            //    return a + b;
            //}; // Phương thức nặc danh

            //Biểu thức ngắn gọn của phương thức nặc danh
            //Func<int, int, int> tinhToan = (int a, int b) => a + b;
            Func<int, int, int> tinhToan = (a, b) => a + b;

            Action<string> display = GetInfo; // Cách 2

            //Thực thi
            Console.WriteLine(tinhToan.Invoke(3, 4)); // Cách 1
            Console.WriteLine(tinhToan(3, 4)); // Cách 2
            display("Vu Dai An");
        }
    }
}
