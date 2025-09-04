using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtuPães
{
    public partial class FormProdutos : Form
    {
        Model.Usuario usuario;
        public FormProdutos(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            ListarCategorisaCmb();
            

        }

        private void FormProdutos_Load(object sender, EventArgs e)
        {

        }

        private void pibDescricaoProdutos_Click(object sender, EventArgs e)
        {

        }
        public void ListarCategorisaCmb()
        {
            Model.Categoria categoria = new Model.Categoria();
            // tabela p/ receber o resultado do SELECT
           DataTable tabela = categoria.Listar();

            foreach (DataRow dr in tabela.Rows)
            {
                cmbCategoriaCadasrtro.Items.Add($"{dr["id"]} - {dr["nome"]}");
                cmbCategoriaEditar.Items.Add($"{dr["id"]} - {dr["nome"]}");
            }
                

        }
    }
}
