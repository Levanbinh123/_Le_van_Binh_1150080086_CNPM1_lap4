using Xunit;
using GeometryLib;
using System;

namespace GeometryLib.Tests
{
    public class HinhChuNhatTests
    {
        //  Test tính diện tích
        [Fact]
        public void DienTich_ReturnsCorrectValue()
        {
            var hcn = new HinhChuNhat(
                new Diem(1, 5),
                new Diem(5, 1)
            );

            int area = hcn.DienTich();

            Assert.Equal(16, area);
        }

        //  Hai hình giao nhau
        [Fact]
        public void GiaoNhau_ReturnsTrue_WhenOverlapping()
        {
            var r1 = new HinhChuNhat(
                new Diem(0, 4),
                new Diem(4, 0)
            );

            var r2 = new HinhChuNhat(
                new Diem(2, 6),
                new Diem(6, 2)
            );

            Assert.True(r1.GiaoNhau(r2));
        }

        //  Hai hình không giao nhau
        [Fact]
        public void GiaoNhau_ReturnsFalse_WhenNotOverlapping()
        {
            var r1 = new HinhChuNhat(
                new Diem(0, 4),
                new Diem(4, 0)
            );

            var r2 = new HinhChuNhat(
                new Diem(5, 4),
                new Diem(8, 1)
            );

            Assert.False(r1.GiaoNhau(r2));
        }

        //  Hình chữ nhật không hợp lệ
        [Fact]
        public void Constructor_InvalidRectangle_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() =>
                new HinhChuNhat(
                    new Diem(5, 1),
                    new Diem(1, 5)
                )
            );
        }
    }
}
