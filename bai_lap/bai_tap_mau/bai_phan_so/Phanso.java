/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package javaapplication3;

import java.util.InputMismatchException;

 class PhanSo {
private int tuSo;
private int mauSo;
public PhanSo(int tu, int mau) {
if (mau == 0)
throw new InputMismatchException("Error!!!");
this.tuSo = tu;
this.mauSo = mau;
}
public PhanSo cong(PhanSo p) {
int t = this.tuSo * p.mauSo + this.mauSo * p.tuSo;
int m = this.mauSo * p.mauSo;
return new PhanSo(t, m);
}

    public int getTuSo() {
        return tuSo;
    }

    public void setTuSo(int tuSo) {
        this.tuSo = tuSo;
    }

    public int getMauSo() {
        return mauSo;
    }

    public void setMauSo(int mauSo) {
        this.mauSo = mauSo;
    }

}