package javaapplication3;

import java.util.InputMismatchException;
import org.junit.Test;
import static org.junit.Assert.assertEquals;

public class Tester {

    private PhanSo p1 = new PhanSo(1, 2);
    private PhanSo p2 = new PhanSo(2, 3);

    // Test lỗi mẫu số = 0
    @Test(expected = InputMismatchException.class)
    public void testError() {
        PhanSo ps = new PhanSo(1, 0);
    }

    // Test cộng phân số
    @Test
    public void testAddFraction1() {
        PhanSo actual = p1.cong(p2);
        PhanSo expected = new PhanSo(7, 6);

        assertEquals(expected.getTuSo(), actual.getTuSo());
        assertEquals(expected.getMauSo(), actual.getMauSo());
    }
}