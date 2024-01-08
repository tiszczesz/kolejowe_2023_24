import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.sql.*;
import java.util.ArrayList;
import java.util.List;


public class MainWindow extends JFrame {
    private JPanel jPanel1;
    private JButton zamknijButton;
    private JButton btnConnect;
    private JTable table1;


    public MainWindow()  {
        this.setSize(400,400);
       this.setContentPane(jPanel1);
        setLocationRelativeTo(null);
        setDefaultCloseOperation(EXIT_ON_CLOSE);
       this.setVisible(true);
        zamknijButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {

               System.exit(0);
            }
        });
        btnConnect.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                Connection connection = null;
                try{
                    connection = DriverManager.getConnection(
                            "jdbc:mysql://localhost:3306/pszczesz_4ti_cw1",
                            "root",
                            "");

                    Statement statement = connection.createStatement();
                    String sqlQuery = "SELECT * FROM products";
                    List<Product> products = new ArrayList<>();
                    ResultSet resultSet = statement.executeQuery(sqlQuery);
                    while (resultSet.next()){
                        Product p = new Product();
                        p.Id = resultSet.getInt("id");
                        p.Name = resultSet.getString("name");
                        p.Price = resultSet.getDouble("price");
                        p.Description = resultSet.getString("description");
                        products.add(p);
                    }
                    JOptionPane.showMessageDialog(null,"Połączono z bazą danych i pobrano "+products.size()+" rekordów");
                }catch (SQLException sqlException){
                    JOptionPane.showMessageDialog(null,sqlException.getMessage());
                }
            }
        });
    }
}
