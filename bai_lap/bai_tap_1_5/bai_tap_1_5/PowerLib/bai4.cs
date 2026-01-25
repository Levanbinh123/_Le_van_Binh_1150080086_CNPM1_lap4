namespace GeometryLib
{
    public class Diem
    {
        public int X { get; }
        public int Y { get; }

        public Diem(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
     public class HinhChuNhat
    {
        public Diem TrenTrai { get; }
        public Diem DuoiPhai { get; }

        public HinhChuNhat(Diem trenTrai, Diem duoiPhai)
        {
          
            if (trenTrai.X >= duoiPhai.X || trenTrai.Y <= duoiPhai.Y)
                throw new ArgumentException("Invalid Rectangle");

            TrenTrai = trenTrai;
            DuoiPhai = duoiPhai;
        }

   
        public int DienTich()
        {
            int chieuRong = DuoiPhai.X - TrenTrai.X;
            int chieuCao = TrenTrai.Y - DuoiPhai.Y;
            return chieuRong * chieuCao;
        }


        public bool GiaoNhau(HinhChuNhat other)
        {
            if (DuoiPhai.X <= other.TrenTrai.X ||
                TrenTrai.X >= other.DuoiPhai.X ||
                TrenTrai.Y <= other.DuoiPhai.Y ||
                DuoiPhai.Y >= other.TrenTrai.Y)
            {
                return false;
            }
            return true;
        }
    }
}