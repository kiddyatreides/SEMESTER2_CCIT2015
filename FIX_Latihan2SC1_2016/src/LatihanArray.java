/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author User1
 */
public class LatihanArray {
    
    public void tryArray3()
    {
        int angka [][] = {
                                {10,20,30,40,50},
                                {11,22,33,44,55},
                                {12,23,34,45,90},
        
        };
        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 5; j++) {
                System.out.println(angka[i][j]);
            }
        }
    }
    public void tryArray2()
    {
        String [] nama = {"Bambang", "Budi","Dana"};
        
        for (int i = 0; i <= nama.length -1; i++) {
            System.out.println(nama[i]);
        }
    }
    public void tryArray()
    {
        int [] angka = new int[5];
        angka[0] = 10;
        angka[1] = 20;
        angka[2] = 30;
        angka[3] = 40;
        angka[4] = 50;
        
        for (int i = 0; i <= angka.length -1 ; i++) {
            System.out.println(angka[i]);
        }
    }
    
}
