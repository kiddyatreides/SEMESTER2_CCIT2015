import java.awt.*;
import java.awt.event.ActionListener;
import javax.swing.*;
import java.awt.event.*;
        

public class FormTambahBarang extends JFrame implements ActionListener {
    JLabel lblJudul = new JLabel("Form Tambah Barang");
    JLabel lblID = new JLabel("ID Barang");
    JLabel lblNama = new JLabel("Nama Barang");
    JLabel lblJenis = new JLabel("Jenis Barang");
    JLabel lblStok = new JLabel("Stok Barang");
    JLabel lblHarga = new JLabel("Harga Barang");
    
    JTextField txtID = new JTextField();
    JTextField txtNama = new JTextField();
    JTextField txtJenis = new JTextField();
    JComboBox cbJenis = new JComboBox();
    JTextField txtStok = new JTextField();
    JTextField txtHarga = new JTextField();
    
    JButton btnSave = new JButton("Save");
    JButton btnReset = new JButton("Reset");
    public FormTambahBarang()
    {
        this.getContentPane().setLayout(null);
        this.setTitle("Applikasi DistroPNJ");
        
        lblJudul.setFont(new Font("Times New Roman", Font.BOLD,25));
        lblJudul.setBounds(70,20,300,30);
        
        
        int x = 75;
        int y = 75;
        lblID.setFont(new Font("Times New Roman",0,15));
        lblID.setBounds(x,y,100,20);
        txtID.setFont(new Font("Times New Roman",0,15));
        txtID.setBounds(x+130,y,100,20);

        y+=40;
        lblNama.setFont(new Font("Times New Roman",0,15));
        lblNama.setBounds(x,y,100,20);
        txtNama.setFont(new Font("Times New Roman",0,15));
        txtNama.setBounds(x+130,y,100,20);
        
        
        y+=40;
        lblJenis.setFont(new Font("Times New Roman",0,15));
        lblJenis.setBounds(x,y,100,20);
        cbJenis.setFont(new Font("Times New Roman",0,15));
        cbJenis.setBounds(x+130,y,100,20);
        cbJenis.addItem("-- Pilih --");
        cbJenis.addItem("Celana");
        cbJenis.addItem("Jaket");

        y+=40;
        lblStok.setFont(new Font("Times New Roman",0,15));
        lblStok.setBounds(x,y,100,20);
        txtStok.setFont(new Font("Times New Roman",0,15));
        txtStok.setBounds(x+130,y,100,20);

        y+=40;
        lblHarga.setFont(new Font("Times New Roman",0,15));
        lblHarga.setBounds(x,y,100,20);
        txtHarga.setFont(new Font("Times New Roman",0,15));
        txtHarga.setBounds(x+130,y,100,20);
        
        y+=40;
        btnSave.setFont(new Font("Times New Roman",0,15));
        btnSave.setBounds(x,y,100,35);
        btnReset.setFont(new Font("Times New Roman",0,15));
        btnReset.setBounds(x+130,y,100,35);
        
        this.getContentPane().add(lblID);
        this.getContentPane().add(lblNama);
        this.getContentPane().add(lblJenis);
        this.getContentPane().add(lblStok);
        this.getContentPane().add(lblHarga);
        
        this.getContentPane().add(txtID);
        this.getContentPane().add(txtNama);
        this.getContentPane().add(cbJenis);
        this.getContentPane().add(txtStok);
        this.getContentPane().add(txtHarga);
        this.getContentPane().add(btnReset);
        this.getContentPane().add(btnSave);
         
        this.getContentPane().add(lblJudul);
        btnSave.addActionListener(this);
        btnReset.addActionListener(this);
    }
    
    @Override
    public void actionPerformed (ActionEvent ae)
    {
        if(ae.getSource().equals(btnSave))
        {
            String result = "Id Barang : " + txtID.getText()+
                            "\n Nama Barang : " + txtNama.getText()+
                            "\n Jenis Barang : " + cbJenis.getSelectedItem().toString()+
                            "\n Stok Barang : " + txtStok.getText() +
                            "\n Harga Barang : " + txtHarga.getText();
                    
            
            JOptionPane.showMessageDialog(this,result);
        }
        else if(ae.getSource().equals(btnReset)) 
        {
//                String result = txtID.getText() = "" +
//                                "\n Nama Barang : " + txtNama.getText()+
//                                "\n Jenis Barang : " + cbJenis.getSelectedItem().toString()+
//                                "\n Stok Barang : " + txtStok.getText() +
//                                "\n Harga Barang : " + txtHarga.getText();
            JOptionPane.showMessageDialog(this, "Button Reset Clicked");
        }
    }
}
