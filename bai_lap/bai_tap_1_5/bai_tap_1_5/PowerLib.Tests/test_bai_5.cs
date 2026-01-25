using Xunit;
using StudentLib;
using System.Collections.Generic;

namespace StudentLib.Tests
{
    public class HocVienTests
    {
        //  Test học viên đủ điều kiện học bổng
        [Fact]
        public void HocVien_DuDieuKienHocBong_ReturnsTrue()
        {
            var hv = new HocVien(
                "HV01",
                "Nguyen Van A",
                "Ha Noi",
                new double[] { 8.5, 8.0, 9.0 }
            );

            Assert.True(hv.DuocHocBong());
        }

        //  Trung bình < 8
        [Fact]
        public void HocVien_TrungBinhThap_ReturnsFalse()
        {
            var hv = new HocVien(
                "HV02",
                "Tran Van B",
                "Da Nang",
                new double[] { 7.5, 8.0, 8.0 }
            );

            Assert.False(hv.DuocHocBong());
        }

        //  Có môn < 5
        [Fact]
        public void HocVien_CoMonDuoi5_ReturnsFalse()
        {
            var hv = new HocVien(
                "HV03",
                "Le Van C",
                "Hue",
                new double[] { 9.0, 4.5, 9.0 }
            );

            Assert.False(hv.DuocHocBong());
        }

        //  Test danh sách học bổng
        [Fact]
        public void HocVienService_ReturnsCorrectScholarshipList()
        {
            var ds = new List<HocVien>
            {
                new HocVien("HV01", "A", "HN", new double[]{8,8,8}),
                new HocVien("HV02", "B", "DN", new double[]{9,4,9}),
                new HocVien("HV03", "C", "HCM", new double[]{9,9,9})
            };

            var service = new HocVienService();
            var ketQua = service.DanhSachHocBong(ds);

            Assert.Equal(2, ketQua.Count);
        }
    }
}
