using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace producao2_MarcoSilva
{
    class ContaProdutos
    {
        GetData data = new GetData();

        public void LimpaGrids(DataGridView grid)
        {
            grid.Rows.Clear();
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void Somatorio(string categoriaID, string nomeCategoria, DataGridView grid)
        {
            grid.ColumnCount = 2;
            string ssql = $"select count(categoria) from T_produtos where categoria = {categoriaID}"; 
            DataTable dt = data.BuscaDados(StringConnection.SC, ssql);
            grid.Rows.Add($"Nº de produtos da categoria: {nomeCategoria}", dt.Rows[0][0]);
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void TotalRegistos(DataGridView grid)
        {
            string ssql = "select count(*) from T_produtos";
            DataTable dt = data.BuscaDados(StringConnection.SC, ssql);
            grid.Rows.Add($"Total de registos:", dt.Rows[0][0]);
        }

        public void TotalRegistosCategoria(string categoriaID, string nomeCategoria, DataGridView grid)
        {
            string ssql = $"select count(*) from T_categorias";
            DataTable dt = data.BuscaDados(StringConnection.SC, ssql);
            grid.Rows.Add($"Total de categorias: ", dt.Rows[0][0]);
        }

        public void PrecoMaisAlto(string categoriaID, string nomeCategoria, DataGridView grid)
        {
            string ssql = $"select concat(nome_prod, ' - ', preco_prod, ' Esc.') from T_produtos where categoria = {categoriaID} " +
                "ORDER BY preco_prod DESC OFFSET 0 ROWS FETCH NEXT 1 ROW ONLY";
            DataTable dt = data.BuscaDados(StringConnection.SC, ssql);
            grid.Rows.Add($"Produto mais caro da categoria: {nomeCategoria} ", dt.Rows[0][0]);
        }

        public void PrecoMaisBaixo(string categoriaID, string nomeCategoria, DataGridView grid)
        {
            string ssql = $"select concat(nome_prod, ' - ', preco_prod, ' Esc.') from T_produtos where categoria = {categoriaID} " +
                "ORDER BY preco_prod ASC OFFSET 0 ROWS FETCH NEXT 1 ROW ONLY";
            DataTable dt = data.BuscaDados(StringConnection.SC, ssql);
            grid.Rows.Add($"Produto mais barato da categoria: {nomeCategoria}", dt.Rows[0][0]);
        }

        public void QuantidadeTotalElementos(string categoriaID, string nomeCategoria, DataGridView grid)
        {
            string ssql = $"select SUM(quantidade) from T_produtos where categoria = {categoriaID}";
            DataTable dt = data.BuscaDados(StringConnection.SC, ssql);
            grid.Rows.Add($"Quantidade total de: {nomeCategoria}", dt.Rows[0][0]);
        }

        public void MaiorQuantidadeElemento(string categoriaID, string nomeCategoria, DataGridView grid)
        {
            string ssql = $"select concat(nome_prod, ' - ', quantidade, ' Unidades') from T_produtos where categoria = {categoriaID} " +
               "ORDER BY quantidade DESC OFFSET 0 ROWS FETCH NEXT 1 ROW ONLY";
            DataTable dt = data.BuscaDados(StringConnection.SC, ssql);
            grid.Rows.Add($"Produto com maior quantidade: {nomeCategoria}", dt.Rows[0][0]);
        }

        public void MenorQuantidadeElemento(string categoriaID, string nomeCategoria, DataGridView grid)
        {
            string ssql = $"select concat(nome_prod, ' - ', quantidade, ' Unidades') from T_produtos where categoria = {categoriaID} " +
               "ORDER BY quantidade ASC OFFSET 0 ROWS FETCH NEXT 1 ROW ONLY";
            DataTable dt = data.BuscaDados(StringConnection.SC, ssql);
            grid.Rows.Add($"Produto com menor quantidade: {nomeCategoria}", dt.Rows[0][0]);
        }
    }
}
