namespace VirtuPães
{
    partial class FormUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.grbCadastro = new System.Windows.Forms.GroupBox();
            this.TxbSenhaCadastro = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txbEmailCadastro = new System.Windows.Forms.TextBox();
            this.txbNomecadastro = new System.Windows.Forms.TextBox();
            this.lblEmailcadastrar = new System.Windows.Forms.Label();
            this.lblNomeCompletoCadastro = new System.Windows.Forms.Label();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.lblSenhaEditar = new System.Windows.Forms.Label();
            this.txbSenhaEditar = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txbEmailEditar = new System.Windows.Forms.TextBox();
            this.txbNomeEditar = new System.Windows.Forms.TextBox();
            this.LblEmailEditar = new System.Windows.Forms.Label();
            this.lblNomeCommpletoEditar = new System.Windows.Forms.Label();
            this.grbApagar = new System.Windows.Forms.GroupBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.lblApagarUsuario = new System.Windows.Forms.Label();
            this.lblUsuarioApagar = new System.Windows.Forms.Label();
            this.lblGerenciadorDeUsuario = new System.Windows.Forms.Label();
            this.pibGerenciador = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.grbCadastro.SuspendLayout();
            this.grbEditar.SuspendLayout();
            this.grbApagar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibGerenciador)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToResizeColumns = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(17, 94);
            this.dgvUsuarios.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.Size = new System.Drawing.Size(1144, 209);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            // 
            // grbCadastro
            // 
            this.grbCadastro.Controls.Add(this.TxbSenhaCadastro);
            this.grbCadastro.Controls.Add(this.lblSenha);
            this.grbCadastro.Controls.Add(this.btnCadastrar);
            this.grbCadastro.Controls.Add(this.txbEmailCadastro);
            this.grbCadastro.Controls.Add(this.txbNomecadastro);
            this.grbCadastro.Controls.Add(this.lblEmailcadastrar);
            this.grbCadastro.Controls.Add(this.lblNomeCompletoCadastro);
            this.grbCadastro.Location = new System.Drawing.Point(17, 313);
            this.grbCadastro.Name = "grbCadastro";
            this.grbCadastro.Size = new System.Drawing.Size(556, 268);
            this.grbCadastro.TabIndex = 1;
            this.grbCadastro.TabStop = false;
            this.grbCadastro.Text = "Cadastro";
            // 
            // TxbSenhaCadastro
            // 
            this.TxbSenhaCadastro.Location = new System.Drawing.Point(121, 141);
            this.TxbSenhaCadastro.Name = "TxbSenhaCadastro";
            this.TxbSenhaCadastro.Size = new System.Drawing.Size(329, 38);
            this.TxbSenhaCadastro.TabIndex = 6;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(23, 141);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(92, 31);
            this.lblSenha.TabIndex = 5;
            this.lblSenha.Text = "Senha";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(98, 185);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(308, 74);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txbEmailCadastro
            // 
            this.txbEmailCadastro.Location = new System.Drawing.Point(110, 88);
            this.txbEmailCadastro.Name = "txbEmailCadastro";
            this.txbEmailCadastro.Size = new System.Drawing.Size(340, 38);
            this.txbEmailCadastro.TabIndex = 3;
            // 
            // txbNomecadastro
            // 
            this.txbNomecadastro.Location = new System.Drawing.Point(238, 36);
            this.txbNomecadastro.Name = "txbNomecadastro";
            this.txbNomecadastro.Size = new System.Drawing.Size(212, 38);
            this.txbNomecadastro.TabIndex = 2;
            this.txbNomecadastro.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblEmailcadastrar
            // 
            this.lblEmailcadastrar.AutoSize = true;
            this.lblEmailcadastrar.Location = new System.Drawing.Point(23, 88);
            this.lblEmailcadastrar.Name = "lblEmailcadastrar";
            this.lblEmailcadastrar.Size = new System.Drawing.Size(81, 31);
            this.lblEmailcadastrar.TabIndex = 1;
            this.lblEmailcadastrar.Text = "Email";
            // 
            // lblNomeCompletoCadastro
            // 
            this.lblNomeCompletoCadastro.AutoSize = true;
            this.lblNomeCompletoCadastro.Location = new System.Drawing.Point(23, 39);
            this.lblNomeCompletoCadastro.Name = "lblNomeCompletoCadastro";
            this.lblNomeCompletoCadastro.Size = new System.Drawing.Size(209, 31);
            this.lblNomeCompletoCadastro.TabIndex = 0;
            this.lblNomeCompletoCadastro.Text = "Nome Completo";
            // 
            // grbEditar
            // 
            this.grbEditar.Controls.Add(this.lblSenhaEditar);
            this.grbEditar.Controls.Add(this.txbSenhaEditar);
            this.grbEditar.Controls.Add(this.btnEditar);
            this.grbEditar.Controls.Add(this.txbEmailEditar);
            this.grbEditar.Controls.Add(this.txbNomeEditar);
            this.grbEditar.Controls.Add(this.LblEmailEditar);
            this.grbEditar.Controls.Add(this.lblNomeCommpletoEditar);
            this.grbEditar.Enabled = false;
            this.grbEditar.Location = new System.Drawing.Point(579, 339);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(534, 268);
            this.grbEditar.TabIndex = 2;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar";
            this.grbEditar.Enter += new System.EventHandler(this.grbEditar_Enter);
            // 
            // lblSenhaEditar
            // 
            this.lblSenhaEditar.AutoSize = true;
            this.lblSenhaEditar.Location = new System.Drawing.Point(20, 138);
            this.lblSenhaEditar.Name = "lblSenhaEditar";
            this.lblSenhaEditar.Size = new System.Drawing.Size(92, 31);
            this.lblSenhaEditar.TabIndex = 6;
            this.lblSenhaEditar.Text = "Senha";
            // 
            // txbSenhaEditar
            // 
            this.txbSenhaEditar.Location = new System.Drawing.Point(126, 138);
            this.txbSenhaEditar.Name = "txbSenhaEditar";
            this.txbSenhaEditar.Size = new System.Drawing.Size(402, 38);
            this.txbSenhaEditar.TabIndex = 5;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(99, 185);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(308, 74);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txbEmailEditar
            // 
            this.txbEmailEditar.Location = new System.Drawing.Point(126, 91);
            this.txbEmailEditar.Name = "txbEmailEditar";
            this.txbEmailEditar.Size = new System.Drawing.Size(407, 38);
            this.txbEmailEditar.TabIndex = 3;
            // 
            // txbNomeEditar
            // 
            this.txbNomeEditar.Location = new System.Drawing.Point(228, 49);
            this.txbNomeEditar.Name = "txbNomeEditar";
            this.txbNomeEditar.Size = new System.Drawing.Size(300, 38);
            this.txbNomeEditar.TabIndex = 2;
            // 
            // LblEmailEditar
            // 
            this.LblEmailEditar.AutoSize = true;
            this.LblEmailEditar.Location = new System.Drawing.Point(23, 94);
            this.LblEmailEditar.Name = "LblEmailEditar";
            this.LblEmailEditar.Size = new System.Drawing.Size(81, 31);
            this.LblEmailEditar.TabIndex = 1;
            this.LblEmailEditar.Text = "Email";
            this.LblEmailEditar.Click += new System.EventHandler(this.LblEmailEditar_Click);
            // 
            // lblNomeCommpletoEditar
            // 
            this.lblNomeCommpletoEditar.AutoSize = true;
            this.lblNomeCommpletoEditar.Location = new System.Drawing.Point(23, 56);
            this.lblNomeCommpletoEditar.Name = "lblNomeCommpletoEditar";
            this.lblNomeCommpletoEditar.Size = new System.Drawing.Size(209, 31);
            this.lblNomeCommpletoEditar.TabIndex = 0;
            this.lblNomeCommpletoEditar.Text = "Nome Completo";
            // 
            // grbApagar
            // 
            this.grbApagar.Controls.Add(this.btnApagar);
            this.grbApagar.Controls.Add(this.lblApagarUsuario);
            this.grbApagar.Controls.Add(this.lblUsuarioApagar);
            this.grbApagar.Location = new System.Drawing.Point(57, 687);
            this.grbApagar.Name = "grbApagar";
            this.grbApagar.Size = new System.Drawing.Size(1104, 140);
            this.grbApagar.TabIndex = 3;
            this.grbApagar.TabStop = false;
            this.grbApagar.Text = "Apagar Usuario";
            this.grbApagar.Enter += new System.EventHandler(this.grbApagar_Enter);
            // 
            // btnApagar
            // 
            this.btnApagar.ForeColor = System.Drawing.Color.Red;
            this.btnApagar.Location = new System.Drawing.Point(829, 37);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(252, 80);
            this.btnApagar.TabIndex = 2;
            this.btnApagar.Text = "Apagar ";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // lblApagarUsuario
            // 
            this.lblApagarUsuario.AutoSize = true;
            this.lblApagarUsuario.Location = new System.Drawing.Point(33, 62);
            this.lblApagarUsuario.Name = "lblApagarUsuario";
            this.lblApagarUsuario.Size = new System.Drawing.Size(86, 31);
            this.lblApagarUsuario.TabIndex = 1;
            this.lblApagarUsuario.Text = "label1";
            // 
            // lblUsuarioApagar
            // 
            this.lblUsuarioApagar.AutoSize = true;
            this.lblUsuarioApagar.Location = new System.Drawing.Point(7, 75);
            this.lblUsuarioApagar.Name = "lblUsuarioApagar";
            this.lblUsuarioApagar.Size = new System.Drawing.Size(0, 31);
            this.lblUsuarioApagar.TabIndex = 0;
            // 
            // lblGerenciadorDeUsuario
            // 
            this.lblGerenciadorDeUsuario.AutoSize = true;
            this.lblGerenciadorDeUsuario.Location = new System.Drawing.Point(243, 33);
            this.lblGerenciadorDeUsuario.Name = "lblGerenciadorDeUsuario";
            this.lblGerenciadorDeUsuario.Size = new System.Drawing.Size(330, 31);
            this.lblGerenciadorDeUsuario.TabIndex = 4;
            this.lblGerenciadorDeUsuario.Text = "Gerenciador de Usuarioes";
            // 
            // pibGerenciador
            // 
            this.pibGerenciador.Image = global::VirtuPães.Properties.Resources.GerenciadorUsuario;
            this.pibGerenciador.Location = new System.Drawing.Point(596, 12);
            this.pibGerenciador.Name = "pibGerenciador";
            this.pibGerenciador.Size = new System.Drawing.Size(100, 75);
            this.pibGerenciador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibGerenciador.TabIndex = 5;
            this.pibGerenciador.TabStop = false;
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 931);
            this.Controls.Add(this.pibGerenciador);
            this.Controls.Add(this.lblGerenciadorDeUsuario);
            this.Controls.Add(this.grbApagar);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grbCadastro);
            this.Controls.Add(this.dgvUsuarios);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "FormUsuarios";
            this.Text = "FormUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.grbCadastro.ResumeLayout(false);
            this.grbCadastro.PerformLayout();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.grbApagar.ResumeLayout(false);
            this.grbApagar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibGerenciador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.GroupBox grbCadastro;
        private System.Windows.Forms.TextBox txbNomecadastro;
        private System.Windows.Forms.Label lblEmailcadastrar;
        private System.Windows.Forms.Label lblNomeCompletoCadastro;
        private System.Windows.Forms.TextBox txbEmailCadastro;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txbEmailEditar;
        private System.Windows.Forms.TextBox txbNomeEditar;
        private System.Windows.Forms.Label LblEmailEditar;
        private System.Windows.Forms.Label lblNomeCommpletoEditar;
        private System.Windows.Forms.GroupBox grbApagar;
        private System.Windows.Forms.Label lblApagarUsuario;
        private System.Windows.Forms.Label lblUsuarioApagar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lblGerenciadorDeUsuario;
        private System.Windows.Forms.PictureBox pibGerenciador;
        private System.Windows.Forms.TextBox TxbSenhaCadastro;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txbSenhaEditar;
        private System.Windows.Forms.Label lblSenhaEditar;
    }
}