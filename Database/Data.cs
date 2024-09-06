using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SOFTGE.Models;

namespace SOFTGE.Data
{
    public class ProdutoDatabase
    {

        static SQLiteAsyncConnection Database;



        public ProdutoDatabase(string dbPath)
        {
            Database = new SQLiteAsyncConnection(dbPath);
            Database.CreateTableAsync<Produto>().Wait();
        }

        // Adicionar produto
        public static async Task<int> SaveProdutoAsync(Produto produto)
        {
            return await Database.InsertAsync(produto);
        }

        // Método para obter todos os produtos da database
        public static async Task<List<Produto>> GetProdutosAsync()
        {
            return await Database.Table<Produto>().ToListAsync();
        }

        // Atualizar produto
        public static async Task<int> UpdateProdutoAsync(Produto produto)
        {
            return await Database.UpdateAsync(produto);
        }

        // Deletar produto
        public static async Task<int> DeleteProdutoAsync(Produto produto)
        {
            return await Database.DeleteAsync(produto);
        }
    }
}
