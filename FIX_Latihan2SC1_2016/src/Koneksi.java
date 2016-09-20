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

public class Koneksi {
    public Connection Open()
    {
        Connection con;
        try
        {
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            String url = "jdbc:sqlserver://localhost\\AREUS;databaseName=DistroPNJ";
            con = DriverManager.getConnection(url,"sa","123456");
            return con;
        }
        catch (Exception e)
        {
            System.err.println(e);
            return null;
        }
    }
}
