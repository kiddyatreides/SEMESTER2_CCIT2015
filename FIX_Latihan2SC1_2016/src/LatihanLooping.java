/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author User1
 */
public class LatihanLooping {
    
    public void tryFor()
    {
        for (int i = 0; i < 10; i++) 
        {
           System.out.println("Hello CCIT"); 
        }
    }
    
    public void tryDoWhile()
    {
        int x = 0;
        do
        {
            System.out.println("Hello Earth");
            x++;
        } while(x < 10);
    }
    
    public void tryWhile()
    {
        int x = 0;
        while(x < 10)
        {
            System.out.println("Hello World");
            ++x;
        }
    }
}
