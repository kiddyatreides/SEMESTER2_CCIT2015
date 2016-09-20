
public class LatihanVariable {
    String nama;/*variable global berwarna hijau
    */
    public void displayNama()
    {
        nama = "Bambang";
        System.out.println("Hello, "+ nama);
    }
    
    public void LuasLingkaran()
    {
        double r;
        double pi = 3.14;
        
        r= 10.884;
        double luas = pi *r *r;
        
        System.out.println("Luas Lingkaran :" + luas);
    }
}
