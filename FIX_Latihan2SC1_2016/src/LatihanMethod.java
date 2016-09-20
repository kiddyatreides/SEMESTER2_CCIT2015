/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author User1
 */
public class LatihanMethod {
        
    public void tryReturn(int a, int b)
    {
        int hasil = tryReturnAgain(a, b);
        System.out.println("Hasil Return : " + hasil);
    }
    
    public int tryReturnAgain(int a, int b)
    {
        a+=b;
        return a;
    }

    //accces specifier | return value(jika void tidak ada return) | nama method | (parameter)
    public void tryMtehod()
    {
        System.out.println("Hello, World");
    }
    
    public void tryParameter(String nama)
    {
        System.out.println("Hello, " + nama + "!");    
    }
    
}
