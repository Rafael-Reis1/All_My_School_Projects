using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Sistema_de_vendas
{
    internal class DAL
    {
        private MySqlConnection conn;

        private String server = "localhost";
        private String user = "root";
        private String database = "SISTEMA_DE_VENDAS";
        private String port = "3306";
        private String password = "168395";

        public async Task ConectarAsync()
        {
            string connStr = String.Format("server={0}; User Id={1}; database={2}; port={3}; password={4}; pooling=false", server, user, database, port, password);
            try
            {
                if (conn != null)
                {
                    await conn.CloseAsync();
                }
                conn = new MySqlConnection(connStr);
                await conn.OpenAsync();
            }
            catch
            {
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    await conn.CloseAsync();
                }
            }
        }

        public async Task ExecutarComandoSQLAsync(string comandoSql)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    await conn.OpenAsync();
                }

                if (conn.State == ConnectionState.Open)
                {
                    MySqlCommand comando = new MySqlCommand(comandoSql, conn);
                    await comando.ExecuteNonQueryAsync();
                }
            }
            catch
            {
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    await conn.CloseAsync();
                }
            }
        }

        public async Task<MySqlDataReader> RetDataReaderAsync(string sql)
        {
            if (conn.State != ConnectionState.Open)
            {
                await conn.OpenAsync();
            }

            MySqlCommand comando = new MySqlCommand(sql, conn);
            MySqlDataReader dr = (MySqlDataReader)await comando.ExecuteReaderAsync();
            return dr;
        }

        public async Task FecharAsync()
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                await conn.CloseAsync();
            }
        }
    }
}
