using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGeneric
{
    class InList
    {
        private int[] numbers;
        public InList(int n)
        {
            numbers = new int[n];
        }
        //Phương thức trả về số lượng phần tử trong danh sách
        public int Size()
        {
            return numbers.Length;
        }
        //Phương thức them phần tử vào danh sách
        public void Add(int index, int value)
        {
            if(index >= 0 && index < numbers.Length)
            {
                numbers[index] = value;
            }
        }
        //Phương thức lấy ra phần tử trong danh sách
        public int Get(int index)
        {
            if(index >= 0 && index < numbers.Length) { return numbers[index]; }
            return 0;
        }
    }
}
