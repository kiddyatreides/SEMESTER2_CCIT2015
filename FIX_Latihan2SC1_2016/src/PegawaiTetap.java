/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author User1
 */
public class PegawaiTetap extends Pegawai{
    int GajiBulanan;
    int THR;
    
    public void setData()
    {
        ID = "P001";
        Nama ="Bambang";
        Alamat = "Jakarta";
        JenisKelamin = "Pria";
        NoTelp = "08171916622";
        GajiBulanan = 1200000;
        THR = 100000;
           
    }
    
    public void displayData()
    {
        System.out.println("ID : " + ID);
        System.out.println("Nama : " + Nama);
        System.out.println("Alamat : " + Alamat);
        System.out.println("Jenis Kelamin : " + JenisKelamin);
        System.out.println("No telp : " + NoTelp);
        System.out.println("Gaji Bulanan : " + GajiBulanan);
        System.out.println("THR : " + THR);
    }
}
