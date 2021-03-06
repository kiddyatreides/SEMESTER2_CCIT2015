
import javax.swing.JOptionPane;
import javax.swing.UIManager;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author KIDDY
 */
public class Receptionist extends javax.swing.JFrame {

    /**
     * Creates new form Receptionist
     */
    public Receptionist() {
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

        btn_customer = new javax.swing.JButton();
        jLabel5 = new javax.swing.JLabel();
        btn_transaction = new javax.swing.JButton();
        jLabel4 = new javax.swing.JLabel();
        jButton1 = new javax.swing.JButton();
        jLabel2 = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setPreferredSize(new java.awt.Dimension(1366, 768));
        setResizable(false);
        setSize(new java.awt.Dimension(1366, 768));
        getContentPane().setLayout(null);

        btn_customer.setFont(new java.awt.Font("Myriad Pro", 0, 14)); // NOI18N
        btn_customer.setIcon(new javax.swing.ImageIcon(getClass().getResource("/img/cst.jpg"))); // NOI18N
        btn_customer.setBorder(new javax.swing.border.LineBorder(new java.awt.Color(251, 227, 96), 2, true));
        btn_customer.setMaximumSize(new java.awt.Dimension(200, 200));
        btn_customer.setMinimumSize(new java.awt.Dimension(200, 200));
        btn_customer.setPreferredSize(new java.awt.Dimension(200, 200));
        btn_customer.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn_customerActionPerformed(evt);
            }
        });
        getContentPane().add(btn_customer);
        btn_customer.setBounds(420, 400, 200, 200);

        jLabel5.setFont(new java.awt.Font("Monotype Corsiva", 1, 48)); // NOI18N
        jLabel5.setForeground(new java.awt.Color(251, 227, 96));
        jLabel5.setText("Transaction");
        getContentPane().add(jLabel5);
        jLabel5.setBounds(770, 620, 250, 50);

        btn_transaction.setFont(new java.awt.Font("Myriad Pro", 0, 14)); // NOI18N
        btn_transaction.setIcon(new javax.swing.ImageIcon(getClass().getResource("/img/Transaction.jpg"))); // NOI18N
        btn_transaction.setBorder(new javax.swing.border.LineBorder(new java.awt.Color(251, 227, 96), 2, true));
        btn_transaction.setMaximumSize(new java.awt.Dimension(200, 200));
        btn_transaction.setMinimumSize(new java.awt.Dimension(200, 200));
        btn_transaction.setPreferredSize(new java.awt.Dimension(200, 200));
        btn_transaction.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn_transactionActionPerformed(evt);
            }
        });
        getContentPane().add(btn_transaction);
        btn_transaction.setBounds(790, 400, 200, 200);

        jLabel4.setFont(new java.awt.Font("Monotype Corsiva", 1, 48)); // NOI18N
        jLabel4.setForeground(new java.awt.Color(251, 227, 96));
        jLabel4.setText("Customer");
        getContentPane().add(jLabel4);
        jLabel4.setBounds(420, 620, 190, 50);

        jButton1.setText("Logout");
        jButton1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton1ActionPerformed(evt);
            }
        });
        getContentPane().add(jButton1);
        jButton1.setBounds(60, 30, 120, 23);

        jLabel2.setIcon(new javax.swing.ImageIcon(getClass().getResource("/img/receptionistpnl.jpg"))); // NOI18N
        getContentPane().add(jLabel2);
        jLabel2.setBounds(0, 0, 1366, 768);

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void btn_customerActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn_customerActionPerformed
        // TODO add your handling code here:
        Customer cr = new Customer();
        cr.setLocationRelativeTo(null);
        cr.setVisible(true);
        this.hide();
    }//GEN-LAST:event_btn_customerActionPerformed

    private void btn_transactionActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn_transactionActionPerformed
        // TODO add your handling code here:
        Transaction tr = new Transaction();
        tr.setLocationRelativeTo(null);
        tr.setVisible(true);
        this.hide();
    }//GEN-LAST:event_btn_transactionActionPerformed

    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
        // TODO add your handling code here:
        int result = JOptionPane.showConfirmDialog(this, "Are you sure?", "Logout", JOptionPane.YES_NO_OPTION);
        if(result==JOptionPane.YES_OPTION){

            Login rm = new Login();
            rm.setLocationRelativeTo(null);
            rm.setVisible(true);
            this.hide();
        }

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
            java.util.logging.Logger.getLogger(Receptionist.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(Receptionist.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(Receptionist.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(Receptionist.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new Receptionist().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btn_customer;
    private javax.swing.JButton btn_transaction;
    private javax.swing.JButton jButton1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    // End of variables declaration//GEN-END:variables
}
