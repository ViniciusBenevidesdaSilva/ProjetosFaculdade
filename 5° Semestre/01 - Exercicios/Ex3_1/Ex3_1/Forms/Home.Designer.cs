
namespace Ex3_1
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
            this.components = new System.ComponentModel.Container();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.txtCategoriaId = new System.Windows.Forms.NumericUpDown();
            this.lblCategoriaId = new System.Windows.Forms.Label();
            this.txtDataAquisicao = new System.Windows.Forms.MaskedTextBox();
            this.lblDataAquisicao = new System.Windows.Forms.Label();
            this.txtValorLocacao = new System.Windows.Forms.NumericUpDown();
            this.lblValorLocacao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.NumericUpDown();
            this.lblId = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtCategoriaId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorLocacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(546, 378);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(157, 45);
            this.btnExcluir.TabIndex = 27;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(342, 378);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(157, 45);
            this.btnAlterar.TabIndex = 26;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Location = new System.Drawing.Point(138, 378);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(157, 45);
            this.btnInserir.TabIndex = 25;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // txtCategoriaId
            // 
            this.txtCategoriaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoriaId.Location = new System.Drawing.Point(489, 226);
            this.txtCategoriaId.Name = "txtCategoriaId";
            this.txtCategoriaId.Size = new System.Drawing.Size(144, 35);
            this.txtCategoriaId.TabIndex = 24;
            this.txtCategoriaId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCategoriaId
            // 
            this.lblCategoriaId.AutoSize = true;
            this.lblCategoriaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaId.Location = new System.Drawing.Point(484, 194);
            this.lblCategoriaId.Name = "lblCategoriaId";
            this.lblCategoriaId.Size = new System.Drawing.Size(150, 29);
            this.lblCategoriaId.TabIndex = 23;
            this.lblCategoriaId.Text = "Id Categoria:";
            // 
            // txtDataAquisicao
            // 
            this.txtDataAquisicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataAquisicao.Location = new System.Drawing.Point(489, 140);
            this.txtDataAquisicao.Mask = "00/00/0000";
            this.txtDataAquisicao.Name = "txtDataAquisicao";
            this.txtDataAquisicao.Size = new System.Drawing.Size(184, 35);
            this.txtDataAquisicao.TabIndex = 22;
            this.txtDataAquisicao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataAquisicao.ValidatingType = typeof(System.DateTime);
            // 
            // lblDataAquisicao
            // 
            this.lblDataAquisicao.AutoSize = true;
            this.lblDataAquisicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataAquisicao.Location = new System.Drawing.Point(484, 108);
            this.lblDataAquisicao.Name = "lblDataAquisicao";
            this.lblDataAquisicao.Size = new System.Drawing.Size(213, 29);
            this.lblDataAquisicao.TabIndex = 21;
            this.lblDataAquisicao.Text = "Data de Aquisição:";
            // 
            // txtValorLocacao
            // 
            this.txtValorLocacao.DecimalPlaces = 2;
            this.txtValorLocacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorLocacao.Location = new System.Drawing.Point(86, 312);
            this.txtValorLocacao.Name = "txtValorLocacao";
            this.txtValorLocacao.Size = new System.Drawing.Size(144, 35);
            this.txtValorLocacao.TabIndex = 20;
            this.txtValorLocacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblValorLocacao
            // 
            this.lblValorLocacao.AutoSize = true;
            this.lblValorLocacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorLocacao.Location = new System.Drawing.Point(81, 280);
            this.lblValorLocacao.Name = "lblValorLocacao";
            this.lblValorLocacao.Size = new System.Drawing.Size(172, 29);
            this.lblValorLocacao.TabIndex = 19;
            this.lblValorLocacao.Text = "Valor Locação:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(86, 226);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(263, 35);
            this.txtDescricao.TabIndex = 18;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(81, 194);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(127, 29);
            this.lblDescricao.TabIndex = 17;
            this.lblDescricao.Text = "Descrição:";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(86, 140);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(144, 35);
            this.txtId.TabIndex = 16;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(81, 108);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(39, 29);
            this.lblId.TabIndex = 15;
            this.lblId.Text = "Id:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(269, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(287, 37);
            this.lblTitulo.TabIndex = 14;
            this.lblTitulo.Text = "Cadastro de Jogos";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtCategoriaId);
            this.Controls.Add(this.lblCategoriaId);
            this.Controls.Add(this.txtDataAquisicao);
            this.Controls.Add(this.lblDataAquisicao);
            this.Controls.Add(this.txtValorLocacao);
            this.Controls.Add(this.lblValorLocacao);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Jogos";
            ((System.ComponentModel.ISupportInitialize)(this.txtCategoriaId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorLocacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.NumericUpDown txtCategoriaId;
        private System.Windows.Forms.Label lblCategoriaId;
        private System.Windows.Forms.MaskedTextBox txtDataAquisicao;
        private System.Windows.Forms.Label lblDataAquisicao;
        private System.Windows.Forms.NumericUpDown txtValorLocacao;
        private System.Windows.Forms.Label lblValorLocacao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.NumericUpDown txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

