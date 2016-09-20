/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author User1
 */
public class LatihanOperator {
    
    public void tryUnary()
    {
        int a = 10;
        a++; // boleh ++a
        System.out.println("Operator + :" + a);
        a--; //boleh --a
        System.out.println("Operator + :" + a);
    }
    
    public void tryArithmetic()
    {
        int x = 10;
        int z = 20;
        int hasil = 0;
        
        hasil = x + z;
        System.out.println("Operator + :" +  hasil);
        hasil = x - z;
        System.out.println("Operator - :" +  hasil);
        hasil = x * z;
        System.out.println("Operator * :" +  hasil);
        hasil = x / z;
        System.out.println("Operator / :" +  hasil);
    }
    
    public void tryCompatrison()
    {
        int a = 10;
        int b = 20;
        boolean hasil = false;
        
        hasil = (a < b);
        System.out.println("Operator < :" + hasil);
        hasil = (a > b);
        System.out.println("Operator > :" + hasil);
        hasil = (a <= b);
        System.out.println("Operator <= :" + hasil);
        hasil = (a >= b);
        System.out.println("Operator >= :" + hasil);
        hasil = (a == b);
        System.out.println("Operator == :" + hasil);
        hasil = (a != b);
        System.out.println("Operator != :" + hasil);
    }
    
    public void tryLogical()
    {
        boolean a = true;
        boolean b = true;
        boolean hasil = false;
        
        hasil = (a==b && b==a);
        System.out.println("Operator && :" + hasil);
        hasil = (10<9 || a==b);
        System.out.println("Operator || :" + hasil);
        hasil = !(10<9 || a==b);
        System.out.println("Operator ! :" + hasil);
    }
    
    public void tryAssignment()
    {
        int a = 10;
        int b = 20;
        
        System.out.println("Operator += : " + (a+=b));
        System.out.println("Operator -= : " + (a-=b));
        System.out.println("Operator *= : " + (a*=b));
    }
}
