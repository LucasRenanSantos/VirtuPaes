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
        }

        private void FormProdutos_Load(object sender, EventArgs e)
        {

        }

        private void pibDescricaoProdutos_Click(object sender, EventArgs e)
        {

        }
    }
}
