/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */


import javax.swing.UIManager;

/**
 *
 * @author KIDDY
 */
public class MyHotel {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        
          
        try{
            UIManager.setLookAndFeel("com.jtattoo.plaf.graphite.GraphiteLookAndFeel");
            Login obj = new Login();
            obj.setLocationRelativeTo(null);
            obj.setVisible(true);
        }
        catch(Exception e){
            System.err.println(e);
        }
    }
    
}
