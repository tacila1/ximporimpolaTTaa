using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prova.Models
{
    public class ProdutoModel
    {
        public int? id { get; set; }
        public string nome { get; set; }
        public decimal? preco { get; set; }

        public List<SELECT_PRODUTOResult> listaProduto;

        public ProdutoModel produtoASerAlterado;

        public ProdutoModel() { }

        public ProdutoModel(int? id1, string nome1 , decimal? preco1)
        {
            id = id1;
            nome = nome1;
            preco = preco1;
        }

    }
}