/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author KIDDY
 */

import java.sql.*;

public class AutoGenerateID {
    
    public String autoIDClass(){
        try
        {
            Koneksi kon = new Koneksi();
            Connection con = kon.open();
            
            String sql = "select top 1 id_class from tb_class order by id_class desc";
            Statement state = con.createStatement();
            ResultSet rs = state.executeQuery(sql);
            
            String idbarang = null;
            if(rs.next())
            {
                idbarang = rs.getString("id_class");
                int nextnumber = Integer.parseInt(idbarang.substring(1)) + 1;
                if(nextnumber < 10)
                {
                    idbarang = "C00" + nextnumber;
                }
                else if(nextnumber < 100)
                {
                    idbarang = "C0" + nextnumber;
                }
                else if(nextnumber < 1000)
                {
                    idbarang = "C" + nextnumber;
                }
            }
            else
            {
                idbarang = "C001";
            }
            return idbarang;
        }
        catch(Exception e)
        {
            System.err.println(e);
            return null;
        }
    }
    
     public String autoIDCustomer(){
        try
        {
            Koneksi kon = new Koneksi();
            Connection con = kon.open();
            
            String sql = "select top 1 id_customer from tb_cust order by id_customer desc";
            Statement state = con.createStatement();
            ResultSet rs = state.executeQuery(sql);
            
            String idbarang = null;
            if(rs.next())
            {
                idbarang = rs.getString("id_customer");
                int nextnumber = Integer.parseInt(idbarang.substring(1)) + 1;
                if(nextnumber < 10)
                {
                    idbarang = "P00" + nextnumber;
                }
                else if(nextnumber < 100)
                {
                    idbarang = "P0" + nextnumber;
                }
                else if(nextnumber < 1000)
                {
                    idbarang = "P" + nextnumber;
                }
            }
            else
            {
                idbarang = "P001";
            }
            return idbarang;
        }
        catch(Exception e)
        {
            System.err.println(e);
            return null;
        }
    }
    
     public String autoIDRoom(){
        try
        {
            Koneksi kon = new Koneksi();
            Connection con = kon.open();
            
            String sql = "select top 1 id_room from tb_room2 order by id_room desc";
            Statement state = con.createStatement();
            ResultSet rs = state.executeQuery(sql);
            
            String idbarang = null;
            if(rs.next())
            {
                idbarang = rs.getString("id_room");
                int nextnumber = Integer.parseInt(idbarang.substring(1)) + 1;
                if(nextnumber < 10)
                {
                    idbarang = "R00" + nextnumber;
                }
                else if(nextnumber < 100)
                {
                    idbarang = "R0" + nextnumber;
                }
                else if(nextnumber < 1000)
                {
                    idbarang = "R" + nextnumber;
                }
            }
            else
            {
                idbarang = "R001";
            }
            return idbarang;
        }
        catch(Exception e)
        {
            System.err.println(e);
            return null;
        }
    }
    
       public String autoIDTransaction(){
        try
        {
            Koneksi kon = new Koneksi();
            Connection con = kon.open();
            
            String sql = "select top 1 id_transaction from tb_trans order by id_transaction desc";
            Statement state = con.createStatement();
            ResultSet rs = state.executeQuery(sql);
            
            String idbarang = null;
            if(rs.next())
            {
                idbarang = rs.getString("id_transaction");
                int nextnumber = Integer.parseInt(idbarang.substring(1)) + 1;
                if(nextnumber < 10)
                {
                    idbarang = "T00" + nextnumber;
                }
                else if(nextnumber < 100)
                {
                    idbarang = "T0" + nextnumber;
                }
                else if(nextnumber < 1000)
                {
                    idbarang = "T" + nextnumber;
                }
            }
            else
            {
                idbarang = "T001";
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
