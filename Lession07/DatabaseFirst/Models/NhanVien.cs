using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseFirst.Models
{
    public partial class NhanVien
    {
        public string MaNv { get; set; }
        public string HoTen { get; set; }
        public string DienThoai { get; set; }
        public string DiaChi { get; set; }
        public string MaPhong { get; set; }

        public virtual PhongBan MaPhongNavigation { get; set; }
    }
}
