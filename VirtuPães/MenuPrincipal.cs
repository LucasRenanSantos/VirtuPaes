using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtuPães
{
    public partial class MenuPrincipal : Form
    {
        // Variaveis globais:
        Model.Usuario usuario = new Model.Usuario();

        public MenuPrincipal(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            lblSaudacao.Text = $"Olá {usuario.NomeCompleto},\nEscolha uma opção abaixo:";

        }

        private void btnComandas_Click(object sender, EventArgs e)
        {

        }

        private void btnComanda_Click(object sender, EventArgs e)
        {
            FormComandas formComanda = new FormComandas(usuario);
            formComanda.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FormComandas formUsuario = new FormComandas(usuario);
            formUsuario.ShowDialog();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            FormProdutos formProdutos = new FormProdutos(usuario);
            formProdutos.ShowDialog();
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            FormCaixa formCaixa = new FormCaixa(usuario);
            formCaixa.ShowDialog();
        }
    }
}
