namespace VirtuPães
{
    partial class FormProdutos
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
            this.dvgProdutos = new System.Windows.Forms.DataGridView();
            this.lblNomeCadastro = new System.Windows.Forms.Label();
            this.lblPrecoCadastrar = new System.Windows.Forms.Label();
            this.lblCategoriaCadastro = new System.Windows.Forms.Label();
            this.txbNomeCadastro = new System.Windows.Forms.TextBox();
            this.txbPrecoCadastrar = new System.Windows.Forms.TextBox();
            this.cmbCategoriaCadasrtro = new System.Windows.Forms.ComboBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.grbCadastrar = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblNomeEditar = new System.Windows.Forms.Label();
            this.cmbCategoriaEditar = new System.Windows.Forms.ComboBox();
            this.lblPrecoEditar = new System.Windows.Forms.Label();
            this.txbPrecoEditar = new System.Windows.Forms.TextBox();
            this.lblCategoriaEditar = new System.Windows.Forms.Label();
            this.txbNomeEditar = new System.Windows.Forms.TextBox();
            this.grbApagarProduto = new System.Windows.Forms.GroupBox();
            this.btnApagarProdutos = new System.Windows.Forms.Button();
            this.lblDescricaoProduto = new System.Windows.Forms.Label();
            this.pibDescricaoProdutos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProdutos)).BeginInit();
            this.grbCadastrar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grbApagarProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibDescricaoProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgProdutos
            // 
            this.dvgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgProdutos.Location = new System.Drawing.Point(9, 58);
            this.dvgProdutos.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dvgProdutos.Name = "dvgProdutos";
            this.dvgProdutos.Size = new System.Drawing.Size(864, 275);
            this.dvgProdutos.TabIndex = 0;
            // 
            // lblNomeCadastro
            // 
            this.lblNomeCadastro.AutoSize = true;
            this.lblNomeCadastro.Location = new System.Drawing.Point(0, 35);
            this.lblNomeCadastro.Name = "lblNomeCadastro";
            this.lblNomeCadastro.Size = new System.Drawing.Size(86, 31);
            this.lblNomeCadastro.TabIndex = 1;
            this.lblNomeCadastro.Text = "Nome";
            // 
            // lblPrecoCadastrar
            // 
            this.lblPrecoCadastrar.AutoSize = true;
            this.lblPrecoCadastrar.Location = new System.Drawing.Point(0, 89);
            this.lblPrecoCadastrar.Name = "lblPrecoCadastrar";
            this.lblPrecoCadastrar.Size = new System.Drawing.Size(76, 31);
            this.lblPrecoCadastrar.TabIndex = 2;
            this.lblPrecoCadastrar.Text = "Peço";
            // 
            // lblCategoriaCadastro
            // 
            this.lblCategoriaCadastro.AutoSize = true;
            this.lblCategoriaCadastro.Location = new System.Drawing.Point(0, 150);
            this.lblCategoriaCadastro.Name = "lblCategoriaCadastro";
            this.lblCategoriaCadastro.Size = new System.Drawing.Size(132, 31);
            this.lblCategoriaCadastro.TabIndex = 3;
            this.lblCategoriaCadastro.Text = "Categoria";
            // 
            // txbNomeCadastro
            // 
            this.txbNomeCadastro.Location = new System.Drawing.Point(92, 32);
            this.txbNomeCadastro.Name = "txbNomeCadastro";
            this.txbNomeCadastro.Size = new System.Drawing.Size(303, 38);
            this.txbNomeCadastro.TabIndex = 4;
            // 
            // txbPrecoCadastrar
            // 
            this.txbPrecoCadastrar.Location = new System.Drawing.Point(82, 89);
            this.txbPrecoCadastrar.Name = "txbPrecoCadastrar";
            this.txbPrecoCadastrar.Size = new System.Drawing.Size(313, 38);
            this.txbPrecoCadastrar.TabIndex = 5;
            // 
            // cmbCategoriaCadasrtro
            // 
            this.cmbCategoriaCadasrtro.FormattingEnabled = true;
            this.cmbCategoriaCadasrtro.Location = new System.Drawing.Point(136, 147);
            this.cmbCategoriaCadasrtro.Name = "cmbCategoriaCadasrtro";
            this.cmbCategoriaCadasrtro.Size = new System.Drawing.Size(259, 39);
            this.cmbCategoriaCadasrtro.TabIndex = 7;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(6, 218);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(333, 57);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // grbCadastrar
            // 
            this.grbCadastrar.Controls.Add(this.btnCadastrar);
            this.grbCadastrar.Controls.Add(this.lblNomeCadastro);
            this.grbCadastrar.Controls.Add(this.cmbCategoriaCadasrtro);
            this.grbCadastrar.Controls.Add(this.lblPrecoCadastrar);
            this.grbCadastrar.Controls.Add(this.txbPrecoCadastrar);
            this.grbCadastrar.Controls.Add(this.lblCategoriaCadastro);
            this.grbCadastrar.Controls.Add(this.txbNomeCadastro);
            this.grbCadastrar.Location = new System.Drawing.Point(12, 343);
            this.grbCadastrar.Name = "grbCadastrar";
            this.grbCadastrar.Size = new System.Drawing.Size(402, 287);
            this.grbCadastrar.TabIndex = 9;
            this.grbCadastrar.TabStop = false;
            this.grbCadastrar.Text = "cadastro";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.lblNomeEditar);
            this.groupBox1.Controls.Add(this.cmbCategoriaEditar);
            this.groupBox1.Controls.Add(this.lblPrecoEditar);
            this.groupBox1.Controls.Add(this.txbPrecoEditar);
            this.groupBox1.Controls.Add(this.lblCategoriaEditar);
            this.groupBox1.Controls.Add(this.txbNomeEditar);
            this.groupBox1.Location = new System.Drawing.Point(431, 343);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 287);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "cadastro";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(28, 218);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(333, 57);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // lblNomeEditar
            // 
            this.lblNomeEditar.AutoSize = true;
            this.lblNomeEditar.Location = new System.Drawing.Point(0, 35);
            this.lblNomeEditar.Name = "lblNomeEditar";
            this.lblNomeEditar.Size = new System.Drawing.Size(86, 31);
            this.lblNomeEditar.TabIndex = 1;
            this.lblNomeEditar.Text = "Nome";
            // 
            // cmbCategoriaEditar
            // 
            this.cmbCategoriaEditar.FormattingEnabled = true;
            this.cmbCategoriaEditar.Location = new System.Drawing.Point(136, 147);
            this.cmbCategoriaEditar.Name = "cmbCategoriaEditar";
            this.cmbCategoriaEditar.Size = new System.Drawing.Size(259, 39);
            this.cmbCategoriaEditar.TabIndex = 7;
            // 
            // lblPrecoEditar
            // 
            this.lblPrecoEditar.AutoSize = true;
            this.lblPrecoEditar.Location = new System.Drawing.Point(0, 89);
            this.lblPrecoEditar.Name = "lblPrecoEditar";
            this.lblPrecoEditar.Size = new System.Drawing.Size(76, 31);
            this.lblPrecoEditar.TabIndex = 2;
            this.lblPrecoEditar.Text = "Peço";
            // 
            // txbPrecoEditar
            // 
            this.txbPrecoEditar.Location = new System.Drawing.Point(82, 89);
            this.txbPrecoEditar.Name = "txbPrecoEditar";
            this.txbPrecoEditar.Size = new System.Drawing.Size(313, 38);
            this.txbPrecoEditar.TabIndex = 5;
            // 
            // lblCategoriaEditar
            // 
            this.lblCategoriaEditar.AutoSize = true;
            this.lblCategoriaEditar.Location = new System.Drawing.Point(0, 150);
            this.lblCategoriaEditar.Name = "lblCategoriaEditar";
            this.lblCategoriaEditar.Size = new System.Drawing.Size(132, 31);
            this.lblCategoriaEditar.TabIndex = 3;
            this.lblCategoriaEditar.Text = "Categoria";
            // 
            // txbNomeEditar
            // 
            this.txbNomeEditar.Location = new System.Drawing.Point(92, 32);
            this.txbNomeEditar.Name = "txbNomeEditar";
            this.txbNomeEditar.Size = new System.Drawing.Size(303, 38);
            this.txbNomeEditar.TabIndex = 4;
            // 
            // grbApagarProduto
            // 
            this.grbApagarProduto.Controls.Add(this.btnApagarProdutos);
            this.grbApagarProduto.Location = new System.Drawing.Point(18, 650);
            this.grbApagarProduto.Name = "grbApagarProduto";
            this.grbApagarProduto.Size = new System.Drawing.Size(808, 148);
            this.grbApagarProduto.TabIndex = 11;
            this.grbApagarProduto.TabStop = false;
            this.grbApagarProduto.Text = "Apagar Produto";
            // 
            // btnApagarProdutos
            // 
            this.btnApagarProdutos.ForeColor = System.Drawing.Color.Red;
            this.btnApagarProdutos.Location = new System.Drawing.Point(596, 59);
            this.btnApagarProdutos.Name = "btnApagarProdutos";
            this.btnApagarProdutos.Size = new System.Drawing.Size(206, 63);
            this.btnApagarProdutos.TabIndex = 0;
            this.btnApagarProdutos.Text = "Apagar";
            this.btnApagarProdutos.UseVisualStyleBackColor = true;
            // 
            // lblDescricaoProduto
            // 
            this.lblDescricaoProduto.AutoSize = true;
            this.lblDescricaoProduto.Location = new System.Drawing.Point(425, 20);
            this.lblDescricaoProduto.Name = "lblDescricaoProduto";
            this.lblDescricaoProduto.Size = new System.Drawing.Size(349, 31);
            this.lblDescricaoProduto.TabIndex = 12;
            this.lblDescricaoProduto.Text = "Gerenciamento de produtos";
            // 
            // pibDescricaoProdutos
            // 
            this.pibDescricaoProdutos.Image = global::VirtuPães.Properties.Resources.bread;
            this.pibDescricaoProdutos.Location = new System.Drawing.Point(769, 2);
            this.pibDescricaoProdutos.Name = "pibDescricaoProdutos";
            this.pibDescricaoProdutos.Size = new System.Drawing.Size(100, 49);
            this.pibDescricaoProdutos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibDescricaoProdutos.TabIndex = 13;
            this.pibDescricaoProdutos.TabStop = false;
            this.pibDescricaoProdutos.Click += new System.EventHandler(this.pibDescricaoProdutos_Click);
            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 810);
            this.Controls.Add(this.pibDescricaoProdutos);
            this.Controls.Add(this.lblDescricaoProduto);
            this.Controls.Add(this.grbApagarProduto);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbCadastrar);
            this.Controls.Add(this.dvgProdutos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "FormProdutos";
            this.Text = "FormProdutos";
            this.Load += new System.EventHandler(this.FormProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgProdutos)).EndInit();
            this.grbCadastrar.ResumeLayout(false);
            this.grbCadastrar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbApagarProduto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pibDescricaoProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgProdutos;
        private System.Windows.Forms.Label lblNomeCadastro;
        private System.Windows.Forms.Label lblPrecoCadastrar;
        private System.Windows.Forms.Label lblCategoriaCadastro;
        private System.Windows.Forms.TextBox txbNomeCadastro;
        private System.Windows.Forms.TextBox txbPrecoCadastrar;
        private System.Windows.Forms.ComboBox cmbCategoriaCadasrtro;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox grbCadastrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblNomeEditar;
        private System.Windows.Forms.ComboBox cmbCategoriaEditar;
        private System.Windows.Forms.Label lblPrecoEditar;
        private System.Windows.Forms.TextBox txbPrecoEditar;
        private System.Windows.Forms.Label lblCategoriaEditar;
        private System.Windows.Forms.TextBox txbNomeEditar;
        private System.Windows.Forms.GroupBox grbApagarProduto;
        private System.Windows.Forms.Button btnApagarProdutos;
        private System.Windows.Forms.Label lblDescricaoProduto;
        private System.Windows.Forms.PictureBox pibDescricaoProdutos;
    }
}