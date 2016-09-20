/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author User1
 */
public class LatihanStrukturKontrol {
 
    public void tryElseIf()
    {
        char nilai = 'A';
        if (nilai == 'A') 
        {
            System.out.println("Good");
        }
        else if (nilai == 'B') 
        {
            System.out.println("Average");
        }
        else if (nilai =='C') 
        {
            System.out.println("Bad");
        }
    }
    
    public void tryInlineIfElse()
    {
        int a = 21;
        String Result = (a==20)? "A Adalah 20" : "A bukan 20";
        System.out.println(Result);
    }
    
    public void tryIfElse()
    {
        int b = 20;
        if (b==15) 
        {
            System.out.println("B adalah 15");
        }
        else
        {
            System.out.println("B bukan 15");
        }
    }
    public void tryIf()
    {
        int a= 10;
        if(a == 10)
        {
            System.out.println("A adalah 10");
        }
        
    }
}
