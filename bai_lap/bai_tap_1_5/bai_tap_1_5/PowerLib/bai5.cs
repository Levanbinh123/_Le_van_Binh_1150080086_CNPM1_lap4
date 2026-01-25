using System;
using System.Linq;

namespace StudentLib
{
    public class HocVien
    {
        public string MaSo { get; }
        public string HoTen { get; }
        public string QueQuan { get; }
        public double[] Diem { get; }

        public HocVien(string maSo, string hoTen, string queQuan, double[] diem)
        {
            if (diem.Length != 3)
                throw new ArgumentException("Phai co 3 mon hoc");

            MaSo = maSo;
            HoTen = hoTen;
            QueQuan = queQuan;
            Diem = diem;
        }

        public double DiemTrungBinh()
        {
            return Diem.Average();
        }

        public bool DuocHocBong()
        {
            return DiemTrungBinh() >= 8.0 && Diem.All(d => d >= 5.0);
        }
    }
      public class HocVienService
    {
        public List<HocVien> DanhSachHocBong(List<HocVien> ds)
        {
            return ds.Where(hv => hv.DuocHocBong()).ToList();
        }
    }
}
