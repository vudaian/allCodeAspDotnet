using System;

namespace KhoiTaoDoiTuong
{
    class Program
    {
        static void Main(string[] args)
        {
            //KhachHang kh = new KhachHang("Nguyen The Anh", "0927586622");

            //Cung cấp giá trih thuộc tính lúc khởi tạo
            KhachHang kh = new KhachHang() { HoTen = "Nguyen The Anh", DienThoai = "0927586622" };
        }
    }
}
