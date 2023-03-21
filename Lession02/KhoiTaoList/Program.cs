using System;
using System.Collections;
using System.Collections.Generic;

namespace KhoiTaoList
{
    class Program
    {
        public static void PrintInt (int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i] + " ");
            }
        }

        public static void PrintArray<T>(T[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            int[] a = { 3, 8, 1, 5, 6 };    
            double[] b = { 3, 8, 1, 5, 6 };
            string[] s = { "Vu", "Dai", "An" };
            PrintArray<int>(a);
            PrintArray<double> (b);
            PrintArray<string>(s);

            //Khởi tạo List<>
            List<int> list1 = new List<int>();
            list1.Add(10);
            list1.Add(20);

            //NhanVien nv1 = new NhanVien();
            //nv1.MaNV = "102";
            //nv1.HoTen = "Vu Dai An";

            //NhanVien nv2 = new NhanVien();
            //nv2.MaNV = "103";
            //nv2.HoTen = "Nguyen Van A";

            //List<NhanVien> list2 = new List<NhanVien>();
            //list2.Add(nv1);
            //list2.Add(nv2);

            List<NhanVien> list2 = new List<NhanVien>()
            {
                new NhanVien(){MaNV = "102", HoTen = "Vu Dai An"},
                new NhanVien(){MaNV = "103", HoTen = "Nguyen Van A"}
            };

            List<string> list3 = new List<string>()
            {
                "Am tham ben em",
                "Noi nay co anh"
            };
        }
    }
}
