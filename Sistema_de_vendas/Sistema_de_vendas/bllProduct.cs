using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_vendas
{
    internal class bllProduct
    {
        DAL db;

        public async Task InserirAsync(dtoProduct dto)
        {
            db = new DAL();
            await db.ConectarAsync();
            string comando = $"call INSERIR_PRODUCT('{dto.ProductName}','{dto.QTDE}','{dto.Price}')";
            await db.ExecutarComandoSQLAsync(comando);
            await db.FecharAsync();
        }

        public async Task AlterarAsync(dtoProduct dto)
        {
            db = new DAL();
            await db.ConectarAsync();
            string comando = $"call ALTERAR_PRODUCT('{dto.ID}','{dto.ProductName}','{dto.QTDE}','{dto.Price}')";
            await db.ExecutarComandoSQLAsync(comando);
            await db.FecharAsync();
        }

        public async Task DeletarAsync(dtoProduct dto)
        {
            db = new DAL();
            await db.ConectarAsync();
            string comando = $"call DELETAR_PRODUCT('{dto.ID}')";
            await db.ExecutarComandoSQLAsync(comando);
            await db.FecharAsync();
        }

        public async Task SelecionarAsync()
        {
            db = new DAL();
            await db.ConectarAsync();

            string comando = "call SELECIONAR_TODOS_PRODUCT()";

            MySqlDataReader reader = await db.RetDataReaderAsync(comando);

            Stock.dtoProduct.Clear();
            CadProducts.quantProds = 0;

            while (await reader.ReadAsync())
            {
                Stock.dtoProduct.Add(new dtoProduct());
                int i = Stock.dtoProduct.Count - 1;
                Stock.dtoProduct[i].ID = reader.GetInt32(reader.GetOrdinal("ID_PRODUCTS"));
                Stock.dtoProduct[i].ProductName = reader.GetString(reader.GetOrdinal("NOME_PRODUCT"));
                Stock.dtoProduct[i].QTDE = reader.GetFloat(reader.GetOrdinal("QTDE_PRODUCT"));
                Stock.dtoProduct[i].Price = reader.GetFloat(reader.GetOrdinal("PRICE_PRODUCT"));

                CadProducts.quantProds = reader.GetInt32(reader.GetOrdinal("ID_PRODUCTS"));
            }

            CadProducts.quantProds++;

            await reader.CloseAsync();
            await db.FecharAsync();
        }


        public async Task SearchStrictAsync(String name)
        {
            db = new DAL();
            await db.ConectarAsync();

            string comando = $"call PESQUISAR_PRODUCT(\"{name}%\")";

            MySqlDataReader reader = await db.RetDataReaderAsync(comando);

            Stock.dtoProduct.Clear();
            CadProducts.quantProds = 0;

            while (await reader.ReadAsync())
            {
                Stock.dtoProduct.Add(new dtoProduct());
                int i = Stock.dtoProduct.Count - 1;
                Stock.dtoProduct[i].ID = reader.GetInt32(reader.GetOrdinal("ID_PRODUCTS"));
                Stock.dtoProduct[i].ProductName = reader.GetString(reader.GetOrdinal("NOME_PRODUCT"));
                Stock.dtoProduct[i].QTDE = reader.GetFloat(reader.GetOrdinal("QTDE_PRODUCT"));
                Stock.dtoProduct[i].Price = reader.GetFloat(reader.GetOrdinal("PRICE_PRODUCT"));

                CadProducts.quantProds = reader.GetInt32(reader.GetOrdinal("ID_PRODUCTS"));
            }

            CadProducts.quantProds++;

            await reader.CloseAsync();
            await db.FecharAsync();
        }

        public async Task SearchFlexibleAsync(String name)
        {
            db = new DAL();
            await db.ConectarAsync();

            string comando = $"call PESQUISAR_PRODUCT(\"%{name}%\")";

            MySqlDataReader reader = await db.RetDataReaderAsync(comando);

            Stock.dtoProduct.Clear();
            CadProducts.quantProds = 0;

            while (await reader.ReadAsync())
            {
                Stock.dtoProduct.Add(new dtoProduct());
                int i = Stock.dtoProduct.Count - 1;
                Stock.dtoProduct[i].ID = reader.GetInt32(reader.GetOrdinal("ID_PRODUCTS"));
                Stock.dtoProduct[i].ProductName = reader.GetString(reader.GetOrdinal("NOME_PRODUCT"));
                Stock.dtoProduct[i].QTDE = reader.GetFloat(reader.GetOrdinal("QTDE_PRODUCT"));
                Stock.dtoProduct[i].Price = reader.GetFloat(reader.GetOrdinal("PRICE_PRODUCT"));

                CadProducts.quantProds = reader.GetInt32(reader.GetOrdinal("ID_PRODUCTS"));
            }

            CadProducts.quantProds++;

            await reader.CloseAsync();
            await db.FecharAsync();
        }
    }
}
