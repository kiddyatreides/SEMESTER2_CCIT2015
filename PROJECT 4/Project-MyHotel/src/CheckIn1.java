/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author KIDDY
 */

import java.awt.Color;
import java.sql.*;
import java.text.*;
import java.util.Calendar;
import javax.swing.JOptionPane;
import org.joda.time.DateTime;
import org.joda.time.Days;

public class CheckIn1 extends javax.swing.JFrame {

    /**
     * Creates new form CheckIn1
     */
    public CheckIn1() {
        initComponents();
        getContentPane().setBackground(Color.BLACK);
        AutoGenerateID auto = new AutoGenerateID();
        jTextField1.setText(auto.autoIDTransaction());
        
        getDataForComboRoom();
        getDataForComboUser();
        
        jComboBox2.setSelectedIndex(-1);
        jLabel10.setText("0");
        jXDatePicker1.setFormats(new String[] {"yyyy-MM-dd"});
        jXDatePicker1.setDate(null);
        
        jXDatePicker2.setFormats(new String[] {"yyyy-MM-dd"});
        jXDatePicker2.setDate(null);
        
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jLabel1 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();
        jComboBox1 = new javax.swing.JComboBox();
        jComboBox2 = new javax.swing.JComboBox();
        jLabel3 = new javax.swing.JLabel();
        jLabel4 = new javax.swing.JLabel();
        jXDatePicker1 = new org.jdesktop.swingx.JXDatePicker();
        jXDatePicker2 = new org.jdesktop.swingx.JXDatePicker();
        jLabel5 = new javax.swing.JLabel();
        jLabel6 = new javax.swing.JLabel();
        jLabel7 = new javax.swing.JLabel();
        jLabel10 = new javax.swing.JLabel();
        jButton1 = new javax.swing.JButton();
        jLabel8 = new javax.swing.JLabel();
        jLabel11 = new javax.swing.JLabel();
        jLabel9 = new javax.swing.JLabel();
        jLabel12 = new javax.swing.JLabel();
        jTextField1 = new javax.swing.JTextField();
        jLabel13 = new javax.swing.JLabel();
        jButton2 = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setMaximumSize(new java.awt.Dimension(450, 400));
        setMinimumSize(new java.awt.Dimension(450, 400));
        setPreferredSize(new java.awt.Dimension(450, 400));
        setResizable(false);
        setSize(new java.awt.Dimension(450, 400));
        getContentPane().setLayout(null);
        getContentPane().add(jLabel1);
        jLabel1.setBounds(162, 22, 0, 0);

        jLabel2.setFont(new java.awt.Font("Monotype Corsiva", 1, 48)); // NOI18N
        jLabel2.setForeground(new java.awt.Color(255, 255, 255));
        jLabel2.setText("Check In");
        getContentPane().add(jLabel2);
        jLabel2.setBounds(130, 30, 174, 55);

        jComboBox1.addItemListener(new java.awt.event.ItemListener() {
            public void itemStateChanged(java.awt.event.ItemEvent evt) {
                jComboBox1ItemStateChanged(evt);
            }
        });
        jComboBox1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jComboBox1ActionPerformed(evt);
            }
        });
        getContentPane().add(jComboBox1);
        jComboBox1.setBounds(204, 121, 116, 20);

        jComboBox2.addItemListener(new java.awt.event.ItemListener() {
            public void itemStateChanged(java.awt.event.ItemEvent evt) {
                jComboBox2ItemStateChanged(evt);
            }
        });
        jComboBox2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jComboBox2ActionPerformed(evt);
            }
        });
        jComboBox2.addPropertyChangeListener(new java.beans.PropertyChangeListener() {
            public void propertyChange(java.beans.PropertyChangeEvent evt) {
                jComboBox2PropertyChange(evt);
            }
        });
        getContentPane().add(jComboBox2);
        jComboBox2.setBounds(204, 152, 116, 20);

        jLabel3.setFont(new java.awt.Font("Myriad Pro", 0, 14)); // NOI18N
        jLabel3.setForeground(new java.awt.Color(255, 255, 255));
        jLabel3.setText("ID Customer");
        getContentPane().add(jLabel3);
        jLabel3.setBounds(99, 124, 90, 15);

        jLabel4.setFont(new java.awt.Font("Myriad Pro", 0, 14)); // NOI18N
        jLabel4.setForeground(new java.awt.Color(255, 255, 255));
        jLabel4.setText("ID Room");
        getContentPane().add(jLabel4);
        jLabel4.setBounds(99, 155, 70, 15);

        jXDatePicker1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jXDatePicker1ActionPerformed(evt);
            }
        });
        getContentPane().add(jXDatePicker1);
        jXDatePicker1.setBounds(204, 203, 104, 22);

        jXDatePicker2.addFocusListener(new java.awt.event.FocusAdapter() {
            public void focusLost(java.awt.event.FocusEvent evt) {
                jXDatePicker2FocusLost(evt);
            }
        });
        jXDatePicker2.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                jXDatePicker2MouseClicked(evt);
            }
            public void mouseExited(java.awt.event.MouseEvent evt) {
                jXDatePicker2MouseExited(evt);
            }
        });
        jXDatePicker2.addInputMethodListener(new java.awt.event.InputMethodListener() {
            public void caretPositionChanged(java.awt.event.InputMethodEvent evt) {
                jXDatePicker2CaretPositionChanged(evt);
            }
            public void inputMethodTextChanged(java.awt.event.InputMethodEvent evt) {
                jXDatePicker2InputMethodTextChanged(evt);
            }
        });
        jXDatePicker2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jXDatePicker2ActionPerformed(evt);
            }
        });
        getContentPane().add(jXDatePicker2);
        jXDatePicker2.setBounds(204, 232, 104, 22);

        jLabel5.setFont(new java.awt.Font("Myriad Pro", 0, 14)); // NOI18N
        jLabel5.setForeground(new java.awt.Color(255, 255, 255));
        jLabel5.setText("Check In Date");
        getContentPane().add(jLabel5);
        jLabel5.setBounds(99, 207, 100, 15);

        jLabel6.setFont(new java.awt.Font("Myriad Pro", 0, 14)); // NOI18N
        jLabel6.setForeground(new java.awt.Color(255, 255, 255));
        jLabel6.setText("Check Out Date");
        getContentPane().add(jLabel6);
        jLabel6.setBounds(99, 236, 100, 15);

        jLabel7.setFont(new java.awt.Font("Myriad Pro", 0, 14)); // NOI18N
        jLabel7.setForeground(new java.awt.Color(255, 255, 255));
        jLabel7.setText("Room Price");
        getContentPane().add(jLabel7);
        jLabel7.setBounds(99, 183, 80, 15);

        jLabel10.setFont(new java.awt.Font("Myriad Pro", 0, 14)); // NOI18N
        jLabel10.setForeground(new java.awt.Color(255, 255, 255));
        jLabel10.setText("0");
        getContentPane().add(jLabel10);
        jLabel10.setBounds(204, 183, 8, 15);

        jButton1.setFont(new java.awt.Font("Myriad Pro", 0, 14)); // NOI18N
        jButton1.setText("Submit");
        jButton1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton1ActionPerformed(evt);
            }
        });
        getContentPane().add(jButton1);
        jButton1.setBounds(204, 322, 90, 23);

        jLabel8.setFont(new java.awt.Font("Myriad Pro", 0, 14)); // NOI18N
        jLabel8.setForeground(new java.awt.Color(255, 255, 255));
        jLabel8.setText("Total Day");
        getContentPane().add(jLabel8);
        jLabel8.setBounds(99, 265, 70, 15);

        jLabel11.setFont(new java.awt.Font("Myriad Pro", 0, 14)); // NOI18N
        jLabel11.setForeground(new java.awt.Color(255, 255, 255));
        jLabel11.setText("0");
        getContentPane().add(jLabel11);
        jLabel11.setBounds(204, 265, 8, 15);

        jLabel9.setFont(new java.awt.Font("Myriad Pro", 0, 14)); // NOI18N
        jLabel9.setForeground(new java.awt.Color(255, 255, 255));
        jLabel9.setText("Total Price");
        getContentPane().add(jLabel9);
        jLabel9.setBounds(99, 290, 80, 15);

        jLabel12.setFont(new java.awt.Font("Myriad Pro", 0, 14)); // NOI18N
        jLabel12.setForeground(new java.awt.Color(255, 255, 255));
        jLabel12.setText("0");
        getContentPane().add(jLabel12);
        jLabel12.setBounds(204, 290, 8, 15);

        jTextField1.setEditable(false);
        getContentPane().add(jTextField1);
        jTextField1.setBounds(204, 95, 116, 20);

        jLabel13.setFont(new java.awt.Font("Myriad Pro", 0, 14)); // NOI18N
        jLabel13.setForeground(new java.awt.Color(255, 255, 255));
        jLabel13.setText("ID Transaction");
        getContentPane().add(jLabel13);
        jLabel13.setBounds(99, 98, 100, 15);

        jButton2.setText("Close");
        jButton2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton2ActionPerformed(evt);
            }
        });
        getContentPane().add(jButton2);
        jButton2.setBounds(310, 10, 80, 23);

        pack();
    }// </editor-fold>//GEN-END:initComponents

     private int Validation(){
        int flag = 0;
        String error = "";
        
        
        if(jComboBox1.getSelectedIndex()== -1){
            flag = 1;
            error += "Please Choose ID Customer.\n";
        }
        if(jComboBox2.getSelectedIndex()== -1){
            flag = 1;
            error += "Please Choose ID Room.\n";
        }
        if(jLabel10.getText().equals("0")){
            flag = 1;
            error += "Please Choose ID Room.\n";
        }
        if(jLabel11.getText().equals("0")){
            flag = 1;
            error += "Error Date!.\n";
        }
        if(jLabel12.getText().equals("0")){
            flag = 1;
            error += "Error Date!.\n";
        }
         if(jXDatePicker2.getDate()==null)
        {
            flag = 1;   
            error += "Please Choose Checkout Date.\n";
        }
         if(jXDatePicker1.getDate()==null)
        {
            flag = 1;   
            error += "Please Choose Checkin Date.\n";
        }
        
        
        if(flag == 0)
        {
            
        }
        else
        {
            JOptionPane.showMessageDialog(this, error);
        }
        return flag;
    }
    
    
    private void getDataForComboRoom(){
        try{
            
            Koneksi kon = new Koneksi();
            Connection con = kon.open();
            
            String sql = "Select * from tb_room2 where status ='Available'";
            
            Statement state = con.createStatement();
            ResultSet rs = state.executeQuery(sql);
            
            while(rs.next()){
                jComboBox2.addItem(rs.getString("id_room"));
                
            }
            jComboBox2.setSelectedIndex(-1);
            
            con.close();
        }
        catch(Exception e ){
            System.err.println(e);
        }
    }
    
       private void getDataForComboUser(){
        try{
            
            Koneksi kon = new Koneksi();
            Connection con = kon.open();
            
            String sql = "Select * from tb_cust";
            
            Statement state = con.createStatement();
            ResultSet rs = state.executeQuery(sql);
            
            while(rs.next()){
                jComboBox1.addItem(rs.getString("id_customer"));
                
            }
            jComboBox1.setSelectedIndex(-1);
            
            con.close();
        }
        catch(Exception e ){
            System.err.println(e);
        }
    }
    
    
    private void jComboBox1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jComboBox1ActionPerformed
        // TODO add your handling code here:
        
        
        
        
        
        
    }//GEN-LAST:event_jComboBox1ActionPerformed

    private void jComboBox2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jComboBox2ActionPerformed
        // TODO add your handling code here:
        
        
        
        
        
    }//GEN-LAST:event_jComboBox2ActionPerformed

    private void jComboBox2PropertyChange(java.beans.PropertyChangeEvent evt) {//GEN-FIRST:event_jComboBox2PropertyChange
        // TODO add your handling code here:
        
       
        
    }//GEN-LAST:event_jComboBox2PropertyChange

    private void jComboBox1ItemStateChanged(java.awt.event.ItemEvent evt) {//GEN-FIRST:event_jComboBox1ItemStateChanged
        // TODO add your handling code here:
        
        
    }//GEN-LAST:event_jComboBox1ItemStateChanged

    private void jComboBox2ItemStateChanged(java.awt.event.ItemEvent evt) {//GEN-FIRST:event_jComboBox2ItemStateChanged
        // TODO add your handling code here:
          try
        {
            Koneksi kon = new Koneksi();
            Connection con = kon.open();
            
            String sql = "select * from tb_room2 where id_room = ?";
            PreparedStatement ps = con.prepareStatement(sql);
            ps.setString(1, jComboBox2.getSelectedItem().toString());
            ResultSet rs = ps.executeQuery();
            
            if(rs.next())
            {
                
                jLabel10.setText(rs.getString("price"));
                
            }
            else
            {
                JOptionPane.showMessageDialog(this, "Data not found.");
                
            }
        }
            catch(Exception e)
            {
                    System.err.println(e);
            }
        
    }//GEN-LAST:event_jComboBox2ItemStateChanged

    private void jXDatePicker2CaretPositionChanged(java.awt.event.InputMethodEvent evt) {//GEN-FIRST:event_jXDatePicker2CaretPositionChanged
        // TODO add your handling code here:
        
    }//GEN-LAST:event_jXDatePicker2CaretPositionChanged

    private void jXDatePicker2InputMethodTextChanged(java.awt.event.InputMethodEvent evt) {//GEN-FIRST:event_jXDatePicker2InputMethodTextChanged
        // TODO add your handling code here:
        
        
    }//GEN-LAST:event_jXDatePicker2InputMethodTextChanged

    private void jXDatePicker2MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_jXDatePicker2MouseClicked
        // TODO add your handling code here:
        
    }//GEN-LAST:event_jXDatePicker2MouseClicked

    private void jXDatePicker2FocusLost(java.awt.event.FocusEvent evt) {//GEN-FIRST:event_jXDatePicker2FocusLost
        // TODO add your handling code here:
        
        
    }//GEN-LAST:event_jXDatePicker2FocusLost

    private void jXDatePicker2MouseExited(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_jXDatePicker2MouseExited
        // TODO add your handling code here:
        
        
    }//GEN-LAST:event_jXDatePicker2MouseExited

    private void jXDatePicker2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jXDatePicker2ActionPerformed
        // TODO add your handling code here:
        
        //check total days
        
        
        java.util.Date today = new java.util.Date(); //mengambil tanggal hari ini
        java.util.Date checkindate = jXDatePicker1.getDate();
        java.util.Date checkoutdate = jXDatePicker2.getDate();
        
        if(jLabel10.getText() == "0"){
            JOptionPane.showMessageDialog(this, "Please Choose ID Room");
            jXDatePicker2.setDate(null);
        }
        if(jXDatePicker1.getDate() == null){
        JOptionPane.showMessageDialog(this, "Please Choose Checkin Date");
        }
        
        //start
        int days = getDaysDiff(today, checkindate);
            int days2 = getDaysDiff(checkindate, checkoutdate);
            int days3 = getDaysDiff(checkoutdate, checkindate);
            
            // tanggal lahir harus sebelum tanggal hari ini.
            if(today.before(checkindate))
            {
                //check hari harus lebih besar dari kemarin
        //check yesterday
         DateFormat dateFormat = new SimpleDateFormat("yyyy/MM/dd HH:mm:ss");

        // Create a calendar object with today date. Calendar is in java.util pakage.
        Calendar calendar = Calendar.getInstance();

        // Move calendar to yesterday
        calendar.add(Calendar.DATE, -1);

        // Get current date of calendar which point to the yesterday now
        java.util.Date yesterday = calendar.getTime();
        
        //
        
        if(checkindate.before(yesterday)){
            JOptionPane.showMessageDialog(this, "Checkindate must be bigger than today");
            jXDatePicker1.setDate(null);
        }
        //finish
            }
            if(checkindate.equals(today))
            {
                jLabel11.setText(String.valueOf(days2));
                
                Integer roomprice = Integer.parseInt(jLabel10.getText());
                Integer totaldays = Integer.parseInt(jLabel11.getText());
                
                Integer total = roomprice * totaldays;
                
                jLabel12.setText(String.valueOf(total));
            }
            if(checkoutdate.before(checkindate)){
                JOptionPane.showMessageDialog(this, "Checkout date must bigger than checkin date");
                jXDatePicker2.setDate(null);
            }
            if(checkoutdate.equals(checkindate)){
                JOptionPane.showMessageDialog(this, "Checkout date must bigger than checkin date");
                jXDatePicker2.setDate(null);
            }
            else{
                jLabel11.setText(String.valueOf(days2));
                
                Integer roomprice = Integer.parseInt(jLabel10.getText());
                Integer totaldays = Integer.parseInt(jLabel11.getText());
                
                Integer total = roomprice * totaldays;
                
                jLabel12.setText(String.valueOf(total));
            }
            
    }//GEN-LAST:event_jXDatePicker2ActionPerformed

    private void jXDatePicker1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jXDatePicker1ActionPerformed
        // TODO add your handling code here:
        
        if(jLabel10.getText() == "0"){
            JOptionPane.showMessageDialog(this, "Please Choose ID Room");
            jXDatePicker1.setDate(null);
        }
        
        java.util.Date today = new java.util.Date(); //mengambil tanggal hari ini
        java.util.Date checkindate = jXDatePicker1.getDate();
        
        //check hari harus lebih besar dari kemarin
        //check yesterday
         DateFormat dateFormat = new SimpleDateFormat("yyyy/MM/dd HH:mm:ss");

        // Create a calendar object with today date. Calendar is in java.util pakage.
        Calendar calendar = Calendar.getInstance();

        // Move calendar to yesterday
        calendar.add(Calendar.DATE, -1);

        // Get current date of calendar which point to the yesterday now
        java.util.Date yesterday = calendar.getTime();
        
        //
        
        if(checkindate.before(yesterday)){
            JOptionPane.showMessageDialog(this, "Checkindate must be bigger than today");
            jXDatePicker1.setDate(null);
        }
        //finish
        
    }//GEN-LAST:event_jXDatePicker1ActionPerformed

    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
 
         if(Validation() == 0){
            String idtransaction = jTextField1.getText();
            String idcustomer = jComboBox1.getSelectedItem().toString();
            String idroom = jComboBox2.getSelectedItem().toString();
            DateFormat df = new SimpleDateFormat("yyyy-MM-dd");
            String checkindate = df.format(jXDatePicker1.getDate());
            String checkoutdate = df.format(jXDatePicker2.getDate());
            String price = jLabel10.getText();
            String totaldays = jLabel11.getText();
            String totalprice = jLabel12.getText();
            String status = "Check In";
            String status2 = "Not Available";
            
            try
            {
                    Koneksi kon = new Koneksi();
                    Connection con = kon.open();
                    String sql = "insert tb_trans values(?,?,?,?,?,?,?,?)";
                    PreparedStatement ps = con.prepareStatement(sql);
                    ps.setString(1, idtransaction);
                    ps.setString(2, idcustomer);
                    ps.setString(3, idroom);
                    ps.setString(4, checkindate);
                    ps.setString(5, checkoutdate);
                    ps.setString(6, totaldays);
                    ps.setString(7, totalprice);
                    ps.setString(8, status);
                    
                     //update room
                    
                        String sql2 = "update tb_room2 set status = ? where id_room = ?";
                        PreparedStatement ps2 = con.prepareStatement(sql2);
                        ps2.setString(1, status2);
                        ps2.setString(2, idroom);
                        int rows2 = ps2.executeUpdate();
                    //
                    
                    int rows =ps.executeUpdate();
                    
                    
                   
                    if(rows!=0)
                    {
                        JOptionPane.showMessageDialog(this, "Data Successfully Added");

                        ClearForm();
                    }
                    else
                    {
                        JOptionPane.showMessageDialog(this, "Terjadi Kesalahan");
                    }


            }
            catch(Exception e)
            {
                System.err.println(e);
            }
        }
                // TODO add your handling code here:
        
        
        
    }//GEN-LAST:event_jButton1ActionPerformed

    private void jButton2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton2ActionPerformed
        // TODO add your handling code here:

        this.hide();
    }//GEN-LAST:event_jButton2ActionPerformed

    
    public void ClearForm(){
         jTextField1.setText("");
         jComboBox1.setSelectedIndex(-1);
         jComboBox2.setSelectedIndex(-1);
         
         jXDatePicker1.setDate(null);
            jXDatePicker2.setDate(null);
            jLabel10.setText("0");
            jLabel11.setText("0");
            jLabel12.setText("0");
            
            AutoGenerateID auto = new AutoGenerateID();
            jTextField1.setText(auto.autoIDTransaction());
            
    }
    
     private int getDaysDiff(java.util.Date startdate, java.util.Date enddate)
    {
        DateTime start = new DateTime(startdate);
        DateTime end = new DateTime(enddate);

        int days = Days.daysBetween(start, end).getDays();
        return days;
        
    }
    
    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(CheckIn1.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(CheckIn1.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(CheckIn1.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(CheckIn1.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new CheckIn1().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton jButton1;
    private javax.swing.JButton jButton2;
    private javax.swing.JComboBox jComboBox1;
    private javax.swing.JComboBox jComboBox2;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel10;
    private javax.swing.JLabel jLabel11;
    private javax.swing.JLabel jLabel12;
    private javax.swing.JLabel jLabel13;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JLabel jLabel6;
    private javax.swing.JLabel jLabel7;
    private javax.swing.JLabel jLabel8;
    private javax.swing.JLabel jLabel9;
    private javax.swing.JTextField jTextField1;
    private org.jdesktop.swingx.JXDatePicker jXDatePicker1;
    private org.jdesktop.swingx.JXDatePicker jXDatePicker2;
    // End of variables declaration//GEN-END:variables
}
