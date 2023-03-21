using System;

namespace KieuLacDanh
{
    class Program
    {
        static void Main(string[] args)
        {
            //ó thể tạo đối tượng không cần tạo lớp --> kiểu lạc danh
            var employee = new
            {
                Name = "Le Van Manh",
                Age = "25",
                Phone = "0997235856"
            };

            Console.WriteLine(employee.Name);
            Console.WriteLine(employee.Age);
            Console.WriteLine(employee.Phone);
        }
    }
}
