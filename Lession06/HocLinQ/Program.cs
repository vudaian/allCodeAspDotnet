using System;
using System.Collections.Generic;
using System.Linq;

namespace HocLinQ
{
    class Program
    {
        static List<Brand> brands = new List<Brand>()
        {
            new Brand(){BrandId = "B001", BrandName = "FPT"},
            new Brand(){BrandId = "B002", BrandName = "Tri Tue"},
            new Brand(){BrandId = "B003", BrandName = "Chien Thang"},
            new Brand(){BrandId = "B004", BrandName = "Xuan Hoa"},
        };
        static List<Product> product = new List<Product>()
        {
            new Product(){ProductId = "P01", ProductName = "Ban Hoc Sinh", Price = 1000,
                Color = new string[]{"Trang", "Hong"}, BrandId = "B004" },
            new Product(){ProductId = "P02", ProductName = "Laptop", Price = 15000,
                Color = new string[]{"Den", "Do"}, BrandId = "B002" },
            new Product(){ProductId = "P03", ProductName = "Den", Price = 8000,
                Color = new string[]{"Vang", "Trang"}, BrandId = "B001" },
            new Product(){ProductId = "P04", ProductName = "Ao dong phuc", Price = 2000,
                Color = new string[]{"Xanh", "Den"}, BrandId = "B003" },
            new Product(){ProductId = "P05", ProductName = "Quan jean", Price = 1000,
                Color = new string[]{"Xanh", "Den"}, BrandId = "B004" }
        };
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //1: Phép chiếu (Projection)
            //Lấy danh sách các thương hiệu
            // - Query syntax
            //var result1 = from b in brands
            //              select b;

            //Trả về đối tượng vô danh
            //var result1 = from b in brands
            //              select new
            //              {
            //                  math = b.BrandId,
            //                  tenth = b.BrandName
            //              };
            // - Method syntax
            //var result1 = brands.Select(b => b);
            //var result1 = brands.Select(b => new
            //                            {
            //                                math = b.BrandId,
            //                                tenth = b.BrandName
            //                            });
            //Console.WriteLine("-Danh sách các thương hiệu-");
            //foreach (var item in result1)
            //{
            //    Console.WriteLine($"{item.math}, {item.tenth}");
            //}

            //2: phép lọc (filter)
            //- Lấy ra các sản phẩm có màu xanh
            //  + Query syntax
            //var result2 = from p in product
            //              where p.Color.Contains("Xanh")
            //              select p;

            //  + Method syntax
            //var result2 = product.Where(p => p.Color.Contains("Xanh"));

            //Console.WriteLine("-Danh sách các thương hiệu-");
            //foreach (var item in result2)
            //{
            //    Console.WriteLine($"{item.ProductId} , {item.ProductName}");
            //}

            //3: Phép nối
            // lấy ra danh sách tất cả các sản phẩm bao gồm các thông tin: mã sản phẩm, tên sản phẩm, giá, tên thương hiệu
            // - Query syntax
            //var result3 = from p in product
            //              join b in brands
            //              on p.BrandId equals b.BrandId
            //              select new
            //              {
            //                  masp = p.ProductId,
            //                  tensp = p.ProductName,
            //                  gia = p.Price,
            //                  tenth = b.BrandName
            //              };

            //Method syntax
            //var result3 = product.Join(brands, p => p.BrandId, b => b.BrandId, (p, b) => new
            //{
            //    masp = p.ProductId,
            //    tensp = p.ProductName,
            //    gia = p.Price,
            //    tenth = b.BrandName
            //});
            //Console.WriteLine("-Danh sách các thương hiệu-");
            //foreach (var item in result3)
            //{
            //    Console.WriteLine($"{item.masp} - {item.tensp} - {item.gia} - {item.tenth}");
            //}

            //4: Sắp xếp
            // - Query syntax
            //var result4 = from p in product
            //              orderby p.Price descending
            //              select p;
            //Method syntax
            //var result4 = product.Select(p => p).OrderByDescending(p => p.Price).ThenByDescending(p => p.ProductId);
            //Console.WriteLine("-Danh sách các sản phẩm-");
            //foreach (var item in result4)
            //{
            //    Console.WriteLine($"{item.ProductId} - {item.ProductName} - {item.Price}");
            //}

            //5: Gom nhóm

            //Console.WriteLine("-Danh sách các sản phẩm-");
            //foreach (var item in result4)
            //{
            //    Console.WriteLine($"{item.ProductId} - {item.ProductName}");
            //}

            //6: Toán tử chuyển kiểu
            //Brand[] arrBrand = brands.ToArray();

            //7: Toán tử nối
            //List<string> list1 = new List<string>() { "1", "2", "3" };
            //List<string> list2 = new List<string>() { "4", "5", "6" };
            //List<string> list3 = (List<string>)list1.Concat(list2);
            //foreach (var item in list3)
            //{
            //    Console.Write(item + " ");
            //}

            //8: Toán tử tổng hợp
            //var soSp = product.Count();
            //Console.WriteLine(soSp);
            //var giaCaoNhat = product.Max(x => x.Price);
            //Console.WriteLine(giaCaoNhat);

            //9: Toán tử định lượng
            //bool check = product.Any(p => p.Price > 1000);
            //if (check)
            //{
            //    Console.WriteLine("Có sản phẩm có giá lớn hơn 1000");
            //}
            //else Console.WriteLine("Khong co");

            //10: Toán tử phân vùng: Skip, SkipWhile, Take, TakeWhile
            List<string> list4 = new List<string>()
            {
                "1", "2", "3", "4"
            };
            //var result6 = list4.Take(4);
            var result6 = list4.Skip(4);
            foreach (var item in result6)
            {
                Console.Write(item + " ");
            }

            //11: Toán tử sinh dữ liệu
            //var list5 = Enumerable.Empty<string>();
            //Console.WriteLine(list5.Count());
            //var list6 = Enumerable.Range(10, 6);
            //foreach (var item in list6)
            //{
            //    Console.WriteLine(item + " ");
            //}

            //12: Toán tử phần tử
            List<int> list7 = new List<int>() { 2, 5, 7, 9, 4, 1 };
            Console.WriteLine(list7.First());
            //Console.WriteLine(list7.First(x => x < 1));
            Console.WriteLine(list7.FirstOrDefault(x => x < 1));
            Console.WriteLine(list7.Last());

            //var result7 = product.Single(p => p.Price > 1000);
            var result7 = product.SingleOrDefault(p => p.Price > 1000);
            Console.WriteLine(result7.ProductId + ", " + result7.ProductName);
        }
    }
}
