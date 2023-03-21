using System;
using System.Collections;
using System.Collections.Generic;

namespace HocCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(4);
            arrayList.Add("C");
            arrayList.Add(6.5);

            arrayList.Remove(1);

            SinhVien sv1 = new SinhVien("101", "Vu Dai An");
            SinhVien sv2 = new SinhVien("102", "Nguyen Van A");
            arrayList.Add(sv1);
            arrayList.Add(sv2);

            foreach (var item in arrayList)
            {
                if(item is SinhVien)
                {
                    SinhVien sv = (SinhVien)item;
                    Console.WriteLine(sv.MaSv + ", " + sv.HoTen);
                }
                else
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
