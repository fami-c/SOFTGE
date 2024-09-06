using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace SOFTGE.Models
{
    public class Produto
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }  // ID é gerado automaticamente
        public string? Nome { get; set; }  // Nome do produto
        public string? Categoria { get; set; }  // Categoria do produto
        public DateTime Validade { get; set; }  // Data de validade do produto
        public string? Fornecedor { get; set; }  // Fornecedor do produto
        public string? Locacao { get; set; }  // Local onde o produto está armazenado
        public int Quantidade { get; set; }  // Quantidade em estoque
        public decimal Valor { get; set; }  // Valor do produto
    }
}
