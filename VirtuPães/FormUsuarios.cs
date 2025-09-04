using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VirtuPães.Model;

namespace VirtuPães
{
    public partial class FormUsuarios : Form
    {
        private Usuario usuario;
        
        int idSelecionado = 0; // Armazenar o id do usuario selecionado para apagar o usuario


        public FormUsuarios()
        {
            InitializeComponent();
        }
        public void AtualizarDgv()
        {
            // Mostrar as informações do bd no datagridview 
            dgvUsuarios.DataSource = Usuario.listar();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void grbApagar_Enter(object sender, EventArgs e)
        {

        }

        private void LblEmailEditar_Click(object sender, EventArgs e)
        {

        }

        private void grbEditar_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

    public FormUsuarios(Model.Usuario usuario)
        {

            InitializeComponent();
            this.usuario = usuario;

            // Mostrar as informações do bd no datagridview:
            dgvUsuarios.DataSource = usuario.Listar();
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txbNomecadastro.Text.Length < 5)
            {
                MessageBox.Show(" O nomedeve ter no minimo 5 caracteres",
                    "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbEmailCadastro.Text.Length < 7)
            {
                MessageBox.Show("o email deve ter no minimo 7 caracteres",
                                    "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TxbSenhaCadastro.Text.Length < 6)
            {
                MessageBox.Show("A senha deve ter no minimo 6 caracteres",
                                    "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Fazer cadastro 
                Model.Usuario usuariocadastro = new Model.Usuario();

                // salvar os valores dos campos 
                usuariocadastro.NomeCompleto = txbNomecadastro.Text;
                usuariocadastro.Email = txbEmailCadastro.Text;
                usuariocadastro.Senha = TxbSenhaCadastro.Text;
               
                if (usuariocadastro.Cadastrar())
                {
                    MessageBox.Show("usuario cadastrado com sucesso!", "Show!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    // atualizar o dgv:
                    AtualizarDgv();

                    //apagar os campos de cadastro:
                    txbEmailCadastro.Clear();
                    txbNomecadastro.Clear();
                    TxbSenhaCadastro.Clear();
                }
                else
                {
                MessageBox.Show("falha ao cadastrar o usuario",
                    "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //pegar a linha selecionada:
            int ls = dgvUsuarios.SelectedCells[0].RowIndex;

            // colocar os valores da celulas nos txbs de edição
            txbNomeEditar.Text = dgvUsuarios.Rows[ls].Cells[1].Value.ToString();
            txbEmailEditar.Text = dgvUsuarios.Rows[ls].Cells[2].Value.ToString();

            //Aemazenar o id do usuario: 
            idSelecionado = (int)dgvUsuarios.Rows[ls].Cells[0].Value;

            // Ativar o grbEditar

            grbEditar.Enabled = true;

            // ajustes nom grbApagar
            lblApagarUsuario.Text = $"Apagar: {dgvUsuarios.Rows[ls].Cells[1].Value.ToString()}";

            // Ativar o grbApagar:
            grbEditar.Enabled = true;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            // Perguntar se o adimin realmente apagar o usuario

            DialogResult r = MessageBox.Show(" Tem certeza que deseja remover este usuario",
                "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
               // Prosseguir com a exclusão
               Model.Usuario usuarioApagar = new Model.Usuario();
                usuarioApagar.Id = idSelecionado;
                if (usuarioApagar.Apagar())
                {
                    MessageBox.Show("usuario apagado com sucesso!", "Show!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //chamar o resetar campo 
                    ResetarCampo();
                }
                else
                {
                    MessageBox.Show("Falha ao apagar o usuario",
                                    "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        public void ResetarCampo()
        {
            // Atualizar o dgv
            AtualizarDgv();

            //apagar os campos de cadastro:
            txbEmailEditar.Clear();
            txbNomeEditar.Clear();
            txbSenhaEditar.Clear();

            // retomar o idselecionado para 0 
            idSelecionado = 0;

            // Retornar o texto padrão do "apagar"
            lblApagarUsuario.Text = "selecione o usuario que deseja apaga:";

            // Desabilitar os grbs:
            grbApagar.Enabled = false;
            grbEditar.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txbNomeEditar.Text.Length < 5)
            {
                MessageBox.Show(" O nomedeve ter no minimo 5 caracteres",
                    "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbEmailEditar.Text.Length < 7)
            {
                MessageBox.Show("o email deve ter no minimo 7 caracteres",
                                    "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbSenhaEditar.Text.Length < 6)
            {
                MessageBox.Show("A senha deve ter no minimo 6 caracteres",
                                    "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Prosseguir com a edição
                Model.Usuario usuarioEditar = new Model.Usuario();
                usuarioEditar.Id = idSelecionado;
                usuarioEditar.NomeCompleto = txbNomeEditar.Text;
                usuarioEditar.Email = txbNomeEditar.Text;
                usuarioEditar.Senha = txbSenhaEditar.Text;

                if (usuarioEditar.Modificar())
                {
                    MessageBox.Show("Informações do usuario modificadas com sucesso!", "Show!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetarCampo();
                }
                else
                {
                MessageBox.Show("Falha ao modificar ass informações do usuario!",
                                    "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

