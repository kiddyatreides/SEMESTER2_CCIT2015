/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author User1
 */
import java.sql.*;
public class AutoGenerateID {
    
    public String autoIDBarang()
    {
        try 
        {
            Koneksi kon = new Koneksi();
            Connection con = kon.Open();
            
            String sql = "select top 1 idbarang from tb_barang order by idbarang desc";
            Statement state = con.createStatement();
            ResultSet rs = state.executeQuery(sql);
             
            String idbarang = null;
            if (rs.next()) 
            {
                idbarang = rs.getString("idbarang");
                int nextNumber = Integer.parseInt(idbarang.substring(1)) + 1;
                if (nextNumber < 10) 
                {
                    idbarang = "B00" + nextNumber;
                }
                else if (nextNumber < 100) 
                {
                    idbarang = "B0" + nextNumber;
                }
                else if (nextNumber < 1000) 
                {
                    idbarang = "B" + nextNumber;
                }
            }
            return idbarang;
        }
        catch(Exception e)
        {
            System.err.println(e);
            return null;
        }
    }
}
