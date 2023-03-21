using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HocCollection
{
    class SinhVien
    {
        private string maSV;
        public string MaSv
        {
            get { return maSV; }
            set { maSV = value; }
        }
        private string hoTen;
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        public SinhVien(string maSV, string hoTen)
        {
            this.maSV = maSV;
            this.hoTen = hoTen;
        }
    }
}
