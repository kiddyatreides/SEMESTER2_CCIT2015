/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author User1
 */
public class LatihanEksepsi {
    
    public void tryEksepsi3()
    {
        try
        {
            int a = 10 / 0;
        }
        catch(Exception e)
        {
            System.err.println(e);
        }
        finally
        {
            System.err.println("Pasti kepanggil..");
        }
    }
    
    public void tryEksepsi2()
    {
        try
        {
        int[] angka = new int[3];
        angka[0] = 10;
        angka[1] = 20;
        angka[2] = 30;
        angka[3] = 40; 
        }
        catch(IndexOutOfBoundsException e)
        {
            System.err.println(e.getMessage());
            // atau bisa ini System.err.println(e());
            
        }
    }
    
    public void tryEksepsi()
    {
        int a = 10;
        int b = 0;
        try
        {
            int c = a/b;
            System.out.println(c);
        }
        catch(ArithmeticException e)
        {
            System.err.println("gabole dibagi nol");
        }
    }
}
