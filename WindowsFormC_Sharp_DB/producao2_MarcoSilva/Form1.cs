using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace producao2_MarcoSilva
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //inicializar a db, declara string com sql e string connection à db
            GetData db = new GetData();
            string ssql = "SELECT * FROM T_categorias";

            //obtem info para a combobox
            cmbBox_categorias.DataSource = db.BuscaDados(StringConnection.SC, ssql);
            cmbBox_categorias.DisplayMember = "nome_categoria";
            cmbBox_categorias.ValueMember = "cod_cat";

            string gridQuery = "select codigo_produto as id, nome_prod as produto, preco_prod as preco," 
                + "quantidade, T_categorias.nome_categoria as categoria from T_produtos, T_categorias where T_produtos.categoria = T_categorias.cod_cat";
            dataGridProdutos.DataSource = db.BuscaDados(StringConnection.SC, gridQuery);
            dataGridProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // ======== COMBO BOX ====== //
        private void CmbBox_categorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetData db = new GetData();
            string filtra_categoria;

            try
            {
                filtra_categoria = cmbBox_categorias.SelectedValue.ToString();
            }
            catch(Exception)
            {
                filtra_categoria = "0";
            }
           
            //filtra a query com a categoria selecionada e da update na grid
            string ssql = "select codigo_produto as id, nome_prod as produto, preco_prod as preco,"
                + "quantidade, T_categorias.nome_categoria as categoria from T_produtos," +
                " T_categorias where T_produtos.categoria = T_categorias.cod_cat and T_categorias.cod_cat ='" + filtra_categoria + "'";
            
            dataGridProdutos.DataSource = db.BuscaDados(StringConnection.SC, ssql);
           
        }
        // =============== BUTTON =============
        private void Btn_contaRegistos_Click(object sender, EventArgs e)
        {
            GetData db = new GetData();
            ContaProdutos produtosDB = new ContaProdutos();
            string filtra_categoria;
            string filtra_id;
            //filtra id da combobox para enviar para a classe conta produtos
            try
            {
                filtra_categoria = cmbBox_categorias.SelectedValue.ToString();
                filtra_id = cmbBox_categorias.Text;
            }

            catch (Exception)
            {
                filtra_categoria = "0";
                filtra_id = "0";
            }

            //chama a classe Conta Produtos, e efectua as várias operações 
            produtosDB.LimpaGrids(gridViewConta);
            produtosDB.Somatorio(filtra_categoria, filtra_id, gridViewConta);
            produtosDB.PrecoMaisAlto(filtra_categoria, filtra_id, gridViewConta);
            produtosDB.PrecoMaisBaixo(filtra_categoria, filtra_id, gridViewConta);
            produtosDB.QuantidadeTotalElementos(filtra_categoria, filtra_id, gridViewConta);
            produtosDB.MaiorQuantidadeElemento(filtra_categoria, filtra_id, gridViewConta);
            produtosDB.MenorQuantidadeElemento(filtra_categoria, filtra_id, gridViewConta);
            produtosDB.TotalRegistos(gridViewConta);
            produtosDB.TotalRegistosCategoria(filtra_categoria, filtra_id, gridViewConta);
        }

        private void SobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feito por Marco Silva nº 9.\nProdução 2\nEFA Programação, turma 2019, 30-07-2019");
        }
    }
}
