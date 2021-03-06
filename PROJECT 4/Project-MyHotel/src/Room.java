/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author KIDDY
 */
public class Room extends javax.swing.JFrame {

    /**
     * Creates new form Room
     */
    public Room() {
        initComponents();
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        btn_addRoom = new javax.swing.JButton();
        btn_updateRoom = new javax.swing.JButton();
        btn_displayRoom = new javax.swing.JButton();
        jLabel7 = new javax.swing.JLabel();
        jLabel6 = new javax.swing.JLabel();
        jLabel3 = new javax.swing.JLabel();
        jLabel5 = new javax.swing.JLabel();
        jLabel1 = new javax.swing.JLabel();
        jButton1 = new javax.swing.JButton();
        jLabel2 = new javax.swing.JLabel();
        jButton2 = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setMinimumSize(new java.awt.Dimension(1366, 768));
        setResizable(false);
        setSize(new java.awt.Dimension(1366, 768));
        getContentPane().setLayout(null);

        btn_addRoom.setFont(new java.awt.Font("Myriad Pro", 0, 14)); // NOI18N
        btn_addRoom.setIcon(new javax.swing.ImageIcon(getClass().getResource("/img/addroom.jpg"))); // NOI18N
        btn_addRoom.setBorder(new javax.swing.border.LineBorder(new java.awt.Color(251, 227, 96), 2, true));
        btn_addRoom.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn_addRoomActionPerformed(evt);
            }
        });
        getContentPane().add(btn_addRoom);
        btn_addRoom.setBounds(281, 302, 200, 200);

        btn_updateRoom.setFont(new java.awt.Font("Myriad Pro", 0, 14)); // NOI18N
        btn_updateRoom.setIcon(new javax.swing.ImageIcon(getClass().getResource("/img/editroom.jpg"))); // NOI18N
        btn_updateRoom.setBorder(new javax.swing.border.LineBorder(new java.awt.Color(251, 227, 96), 2, true));
        btn_updateRoom.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn_updateRoomActionPerformed(evt);
            }
        });
        getContentPane().add(btn_updateRoom);
        btn_updateRoom.setBounds(571, 302, 200, 200);

        btn_displayRoom.setFont(new java.awt.Font("Myriad Pro", 0, 14)); // NOI18N
        btn_displayRoom.setIcon(new javax.swing.ImageIcon(getClass().getResource("/img/displayroom.jpg"))); // NOI18N
        btn_displayRoom.setBorder(new javax.swing.border.LineBorder(new java.awt.Color(251, 227, 96), 2, true));
        btn_displayRoom.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn_displayRoomActionPerformed(evt);
            }
        });
        getContentPane().add(btn_displayRoom);
        btn_displayRoom.setBounds(857, 302, 200, 200);

        jLabel7.setFont(new java.awt.Font("Monotype Corsiva", 0, 48)); // NOI18N
        jLabel7.setForeground(new java.awt.Color(251, 227, 96));
        jLabel7.setText("Display Room");
        getContentPane().add(jLabel7);
        jLabel7.setBounds(830, 520, 250, 60);

        jLabel6.setFont(new java.awt.Font("Monotype Corsiva", 0, 48)); // NOI18N
        jLabel6.setForeground(new java.awt.Color(251, 227, 96));
        jLabel6.setText("Update Room");
        getContentPane().add(jLabel6);
        jLabel6.setBounds(550, 520, 240, 60);

        jLabel3.setFont(new java.awt.Font("Monotype Corsiva", 1, 60)); // NOI18N
        jLabel3.setForeground(new java.awt.Color(251, 227, 96));
        jLabel3.setText("Room Panel");
        getContentPane().add(jLabel3);
        jLabel3.setBounds(517, 87, 320, 60);

        jLabel5.setFont(new java.awt.Font("Monotype Corsiva", 0, 48)); // NOI18N
        jLabel5.setForeground(new java.awt.Color(251, 227, 96));
        jLabel5.setText("Add Room");
        getContentPane().add(jLabel5);
        jLabel5.setBounds(290, 520, 180, 60);

        jLabel1.setFont(new java.awt.Font("Monotype Corsiva", 1, 60)); // NOI18N
        jLabel1.setForeground(new java.awt.Color(51, 51, 51));
        jLabel1.setText("Room Panel");
        getContentPane().add(jLabel1);
        jLabel1.setBounds(520, 90, 320, 60);

        jButton1.setFont(new java.awt.Font("Monotype Corsiva", 1, 36)); // NOI18N
        jButton1.setText("Back to Mainmenu");
        jButton1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton1ActionPerformed(evt);
            }
        });
        getContentPane().add(jButton1);
        jButton1.setBounds(520, 660, 320, 70);

        jLabel2.setIcon(new javax.swing.ImageIcon(getClass().getResource("/img/background.jpg"))); // NOI18N
        getContentPane().add(jLabel2);
        jLabel2.setBounds(0, 0, 1366, 768);

        jButton2.setText("jButton2");
        getContentPane().add(jButton2);
        jButton2.setBounds(630, 650, 73, 23);

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void btn_addRoomActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn_addRoomActionPerformed
        // TODO add your handling code here:
        AddRoom ar = new AddRoom();
        ar.setLocationRelativeTo(null);
        ar.setVisible(true);

    }//GEN-LAST:event_btn_addRoomActionPerformed

    private void btn_updateRoomActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn_updateRoomActionPerformed
        // TODO add your handling code here:
        UpdateRoom ur = new UpdateRoom();
        ur.setLocationRelativeTo(null);
        ur.setVisible(true);

    }//GEN-LAST:event_btn_updateRoomActionPerformed

    private void btn_displayRoomActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn_displayRoomActionPerformed
        // TODO add your handling code here:
        DisplayRoom dr = new DisplayRoom();
        dr.setLocationRelativeTo(null);
        dr.setVisible(true);

    }//GEN-LAST:event_btn_displayRoomActionPerformed

    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
        // TODO add your handling code here:
        this.hide();
        Admin adm = new Admin();
        adm.setLocationRelativeTo(null);
        adm.setVisible(true);
    }//GEN-LAST:event_jButton1ActionPerformed

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
            java.util.logging.Logger.getLogger(Room.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(Room.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(Room.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(Room.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new Room().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btn_addRoom;
    private javax.swing.JButton btn_displayRoom;
    private javax.swing.JButton btn_updateRoom;
    private javax.swing.JButton jButton1;
    private javax.swing.JButton jButton2;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JLabel jLabel6;
    private javax.swing.JLabel jLabel7;
    // End of variables declaration//GEN-END:variables
}
