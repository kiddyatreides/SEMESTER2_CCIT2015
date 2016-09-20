
import java.util.concurrent.ExecutionException;
import javax.swing.JFrame;
import javax.swing.UIManager;
import sun.swing.UIAction;

public class Utama {

   
    public static void main(String[] args) {
        
        
        try
        {
            UIManager.setLookAndFeel("com.jtattoo.plaf.acryl.AcrylLookAndFeel");
            InsertFormBarang obj = new InsertFormBarang();
            obj.setLocationRelativeTo(null);
            obj.setVisible(true);
        }
        catch (Exception e)
        {
            System.err.println(e);
        }
        
    }
    
}
