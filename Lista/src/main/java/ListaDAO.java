
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

public class ListaDAO {

    public void insertMySQL(String nome, double quant, double price) {
        MySQLConnection mysql = new MySQLConnection();
        Connection connection = mysql.getConexao();
        if (connection != null) {
            try {
                String campos = "NOME_PRODUTO, QUANT, PRICE";
                String valores = "?, ?, ?";
                String sql = "INSERT INTO PRODUTOS (" + campos + ") VALUES (" + valores + ")";

                PreparedStatement statement = connection.prepareStatement(sql);
                statement.setString(1, nome);
                statement.setFloat(2, (float) quant);
                statement.setFloat(3, (float) price);

                int qtdeCad = statement.executeUpdate();
                if (qtdeCad > 0) {
                    System.out.println("Cadastrado com sucesso!");
                }
            } catch (SQLException e) {
                e.printStackTrace();
            } finally {
                mysql.desconectar();
            }
        }
    }
    
    public void atualizaMySQL(String nome, double quant, double price, int id) {
    MySQLConnection mysql = new MySQLConnection();
    Connection connection = mysql.getConexao();

    if (connection != null) {
        try {
            String sql = "UPDATE PRODUTOS SET NOME_PRODUTO = ?, QUANT = ?, PRICE = ? WHERE ID_PRODUTOS = ?";

            PreparedStatement statement = connection.prepareStatement(sql);
            statement.setString(1, nome);
            statement.setFloat(2, (float) quant);
            statement.setFloat(3, (float) price);
            statement.setInt(4, id);

            int linhasAfetadas = statement.executeUpdate();

            if (linhasAfetadas > 0) {
                System.out.println("Atualizado com sucesso!");
            } else {
                System.out.println("Nenhum produto encontrado com ID: " + id);
            }

        } catch (SQLException e) {
            e.printStackTrace();
        } finally {
            mysql.desconectar();
        }
    }
}


    public void selectProdutoCadastro(String id) {
        MySQLConnection mysql = new MySQLConnection();
        Connection connection = mysql.getConexao();

        if (connection != null) {
            try {
                String query = "SELECT * FROM PRODUTOS WHERE ID_PRODUTOS = \"" + id + "\"";
                PreparedStatement statement = connection.prepareStatement(query);
                ResultSet resultSet = statement.executeQuery();
                resultSet.next();

                CadastroProdutoForm cadastro = new CadastroProdutoForm();
                cadastro.jTextFieldNome.setText(resultSet.getString("NOME_PRODUTO"));
                cadastro.jTextFieldQuant.setText(resultSet.getString("QUANT"));
                cadastro.jTextFieldPreco.setText(resultSet.getString("PRICE"));
                cadastro.jButtonConfirmar.setText("Atualizar");
                cadastro.jButtonDeletar.show();
                cadastro.show();

            } catch (SQLException e) {
                e.printStackTrace();
            } finally {
                mysql.desconectar();
            }
        }
    }

    public boolean cadastrarUsuario(String usuario, String senha) {
        MySQLConnection mysql = new MySQLConnection();
        Connection connection = mysql.getConexao();
        if (connection != null) {
            if (usuarioNaoExisteMySQL(usuario)) {
                try {

                    String campos = "USUARIO, SENHA";
                    String valores = "?, ?";
                    String sql = "INSERT INTO USUARIOS (" + campos + ") VALUES (" + valores + ")";

                    PreparedStatement statement = connection.prepareStatement(sql);
                    statement.setString(1, usuario);
                    statement.setString(2, senha);

                    int qtdeCad = statement.executeUpdate();
                    if (qtdeCad > 0) {
                        System.out.println("Cadastrado com sucesso!");
                    }
                    return true;
                } catch (SQLException e) {
                    e.printStackTrace();
                    return false;
                } finally {
                    mysql.desconectar();
                }
            }
        }
        return false;
    }

    public boolean loginMySQL(String usuario, String senha) {
        MySQLConnection mysql = new MySQLConnection();
        Connection connection = mysql.getConexao();

        if (connection != null) {
            try {
                String query = "SELECT * FROM USUARIOS WHERE USUARIO = \"" + usuario + "\" AND SENHA = \"" + senha + "\"";
                PreparedStatement statement = connection.prepareStatement(query);
                ResultSet resultSet = statement.executeQuery();
                int i = 0;
                while (resultSet.next()) {
                    i++;
                }

                return i > 0;
            } catch (SQLException e) {
                e.printStackTrace();
            } finally {
                mysql.desconectar();
            }
        }

        return false;
    }

    public boolean usuarioNaoExisteMySQL(String usuario) {
        MySQLConnection mysql = new MySQLConnection();
        Connection connection = mysql.getConexao();

        if (connection != null) {
            try {
                String query = "SELECT * FROM USUARIOS WHERE USUARIO = \"" + usuario + "\"";
                PreparedStatement statement = connection.prepareStatement(query);
                ResultSet resultSet = statement.executeQuery();
                int i = 0;
                while (resultSet.next()) {
                    i++;
                }

                return i == 0;
            } catch (SQLException e) {
                e.printStackTrace();
            } finally {
                mysql.desconectar();
            }
        }

        return false;
    }

    public List<Lista> selectProductsMySQL() {
        MySQLConnection mysql = new MySQLConnection();
        Connection connection = mysql.getConexao();

        List<Lista> produtos = new ArrayList<>();

        if (connection != null) {
            try {
                String query = "SELECT * FROM PRODUTOS";
                PreparedStatement statement = connection.prepareStatement(query);
                ResultSet resultSet = statement.executeQuery();
                while (resultSet.next()) {
                    Lista lista = new Lista();
                    lista.setId(resultSet.getInt("ID_PRODUTOS"));
                    lista.setNome(resultSet.getString("NOME_PRODUTO"));
                    lista.setQtde(Double.parseDouble(resultSet.getString("QUANT")));
                    lista.setPrice(Double.parseDouble(resultSet.getString("PRICE")));
                    produtos.add(lista);
                }
            } catch (SQLException e) {
                e.printStackTrace();
            } finally {
                mysql.desconectar();
            }
        }

        return produtos;
    }

    public int excluirSQL(String id) {
        int result = 0;
        MySQLConnection mysql = new MySQLConnection();
        Connection connection = mysql.getConexao();

        if (connection != null) {
            try {

                String query = "DELETE FROM PRODUTOS WHERE ID_PRODUTOS = " + id;
                PreparedStatement statement = connection.prepareStatement(query);
                result = statement.executeUpdate();

            } catch (SQLException e) {
                e.printStackTrace();
            } finally {
                mysql.desconectar();
            }
        }
        return result;
    }
}
