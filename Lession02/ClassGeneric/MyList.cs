using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGeneric
{
    class MyList<T>
    {
        private T[] numbers;
        public MyList(int n)
        {
            numbers = new T[n];
        }
        //Phương thức trả về số lượng phần tử trong danh sách
        public int Size()
        {
            return numbers.Length;
        }
        //Phương thức them phần tử vào danh sách
        public void Add(int index, T value)
        {
            if (index >= 0 && index < numbers.Length)
            {
                numbers[index] = value;
            }
        }
        //Phương thức lấy ra phần tử trong danh sách
        public T Get(int index)
        {
            if (index >= 0 && index < numbers.Length) { return numbers[index]; }
            return default(T);
        }
    }
}
