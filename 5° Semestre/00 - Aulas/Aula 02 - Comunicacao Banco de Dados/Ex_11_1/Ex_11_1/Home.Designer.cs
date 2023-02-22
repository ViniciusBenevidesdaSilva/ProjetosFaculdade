
namespace Ex_11_1
{
    partial class Home
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.NumericUpDown();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblValorLocacao = new System.Windows.Forms.Label();
            this.txtValorLocacao = new System.Windows.Forms.NumericUpDown();
            this.lblDataAquisicao = new System.Windows.Forms.Label();
            this.txtDataAquisicao = new System.Windows.Forms.MaskedTextBox();
            this.txtIdCategoria = new System.Windows.Forms.NumericUpDown();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorLocacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(290, 35);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(182, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cadastro Jogos";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(57, 83);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(39, 29);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "Id:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(72, 115);
            this.txtId.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(120, 35);
            this.txtId.TabIndex = 2;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(57, 170);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(127, 29);
            this.lblDescricao.TabIndex = 3;
            this.lblDescricao.Text = "Descricao:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(72, 202);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(263, 35);
            this.txtDescricao.TabIndex = 4;
            // 
            // lblValorLocacao
            // 
            this.lblValorLocacao.AutoSize = true;
            this.lblValorLocacao.Location = new System.Drawing.Point(57, 257);
            this.lblValorLocacao.Name = "lblValorLocacao";
            this.lblValorLocacao.Size = new System.Drawing.Size(172, 29);
            this.lblValorLocacao.TabIndex = 5;
            this.lblValorLocacao.Text = "Valor Locação:";
            // 
            // txtValorLocacao
            // 
            this.txtValorLocacao.DecimalPlaces = 2;
            this.txtValorLocacao.Location = new System.Drawing.Point(72, 289);
            this.txtValorLocacao.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtValorLocacao.Name = "txtValorLocacao";
            this.txtValorLocacao.Size = new System.Drawing.Size(166, 35);
            this.txtValorLocacao.TabIndex = 6;
            this.txtValorLocacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDataAquisicao
            // 
            this.lblDataAquisicao.AutoSize = true;
            this.lblDataAquisicao.Location = new System.Drawing.Point(440, 83);
            this.lblDataAquisicao.Name = "lblDataAquisicao";
            this.lblDataAquisicao.Size = new System.Drawing.Size(179, 29);
            this.lblDataAquisicao.TabIndex = 7;
            this.lblDataAquisicao.Text = "Data Aquisição:";
            // 
            // txtDataAquisicao
            // 
            this.txtDataAquisicao.Location = new System.Drawing.Point(455, 115);
            this.txtDataAquisicao.Mask = "00/00/0000";
            this.txtDataAquisicao.Name = "txtDataAquisicao";
            this.txtDataAquisicao.Size = new System.Drawing.Size(159, 35);
            this.txtDataAquisicao.TabIndex = 8;
            this.txtDataAquisicao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataAquisicao.ValidatingType = typeof(System.DateTime);
            // 
            // txtIdCategoria
            // 
            this.txtIdCategoria.Location = new System.Drawing.Point(455, 202);
            this.txtIdCategoria.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtIdCategoria.Name = "txtIdCategoria";
            this.txtIdCategoria.Size = new System.Drawing.Size(120, 35);
            this.txtIdCategoria.TabIndex = 10;
            this.txtIdCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(440, 170);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(124, 29);
            this.lblCategoria.TabIndex = 9;
            this.lblCategoria.Text = "Categoria:";
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(62, 387);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(161, 42);
            this.btnInserir.TabIndex = 11;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(319, 387);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(161, 42);
            this.btnAlterar.TabIndex = 12;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(576, 387);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(161, 42);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtIdCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.txtDataAquisicao);
            this.Controls.Add(this.lblDataAquisicao);
            this.Controls.Add(this.txtValorLocacao);
            this.Controls.Add(this.lblValorLocacao);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogos";
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorLocacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.NumericUpDown txtId;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblValorLocacao;
        private System.Windows.Forms.NumericUpDown txtValorLocacao;
        private System.Windows.Forms.Label lblDataAquisicao;
        private System.Windows.Forms.MaskedTextBox txtDataAquisicao;
        private System.Windows.Forms.NumericUpDown txtIdCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
    }
}

