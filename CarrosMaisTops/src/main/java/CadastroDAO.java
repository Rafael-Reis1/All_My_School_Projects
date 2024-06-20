import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

public class CadastroDAO {
    
    public void insertMySQL(String fabricante, String modelo, int ano, double potencia, int nota) {
        MySQLConnection mysql = new MySQLConnection();
        Connection connection = mysql.getConexao();
        if (connection != null) {
            try {
                String campos = "FABRICANTE, MODELO, ANO, POTENCIA, NOTA";
                String valores = "?, ?, ?, ?, ?";
                String sql = "INSERT INTO CARROS ("+ campos +") VALUES (" + valores + ")";
                
                PreparedStatement statement = connection.prepareStatement(sql);
                statement.setString(1, fabricante);
                statement.setString(2, modelo);
                statement.setInt(3, ano);
                statement.setDouble(4, potencia);
                statement.setInt(5, nota);
                
                int qtdeCad = statement.executeUpdate();
                if (qtdeCad > 0) {
                    System.out.println("Carro cadastrado com sucesso!");
                }
            } catch (SQLException e) {
                e.printStackTrace();
            } finally {
                mysql.desconectar();
            }
        }
    }
    
     public void selecionarCarros() {
        MySQLConnection mysql = new MySQLConnection();
        Connection connection = mysql.getConexao();
        if (connection != null) {
            try {
                String query = "SELECT * FROM CARROS";
                PreparedStatement statement = connection.prepareStatement(query);
                ResultSet resultSet = statement.executeQuery();
                CarrosForm.jTextAreaCadastrados.setText("");
                String carros = "";
                while (resultSet.next()) {
                     carros += "Fabricante: " + resultSet.getString("FABRICANTE") + "   -   Modelo: " + resultSet.getString("MODELO")
                            + "   -   Ano: " + resultSet.getString("ANO") + "   -   Potencia: " + resultSet.getString("POTENCIA") + "   -   Nota: " + resultSet.getString("NOTA") + "\n";
                    
                }
                CarrosForm.jTextAreaCadastrados.setText(carros);
            } catch (SQLException e) {
                e.printStackTrace();
            } finally {
                mysql.desconectar();
            }
        }
    }
}
