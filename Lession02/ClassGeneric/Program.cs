using System;

namespace ClassGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            //InList inList = new InList(4);
            //inList.Add(0, 100);
            //inList.Add(1, 7);
            //inList.Add(2, 21);
            //inList.Add(3, 9);
            //for(int i = 0; i < inList.Size(); i++)
            //{
            //    Console.WriteLine(inList.Get(i) + " ");
            //}

            MyList<int> list1 = new MyList<int>(4);
            list1.Add(0, 100);
            list1.Add(1, 8);
            list1.Add(2, 5);
            list1.Add(3, 2);
            for (int i = 0; i < list1.Size(); i++)
            {
                Console.WriteLine(list1.Get(i) + " ");
            }
        }
    }
}
