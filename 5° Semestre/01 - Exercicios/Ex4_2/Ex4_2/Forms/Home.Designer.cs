
namespace Ex4_2
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
            this.btnConsulta = new System.Windows.Forms.Button();
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
            this.btnConsultarTodos = new System.Windows.Forms.Button();
            this.dgvJogos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.txtCategoriaId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorLocacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJogos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsulta
            // 
            this.btnConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.Location = new System.Drawing.Point(583, 457);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(157, 45);
            this.btnConsulta.TabIndex = 57;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(332, 481);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(157, 45);
            this.btnExcluir.TabIndex = 56;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(81, 508);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(157, 45);
            this.btnAlterar.TabIndex = 55;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Location = new System.Drawing.Point(81, 457);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(157, 45);
            this.btnInserir.TabIndex = 54;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // txtCategoriaId
            // 
            this.txtCategoriaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoriaId.Location = new System.Drawing.Point(54, 396);
            this.txtCategoriaId.Name = "txtCategoriaId";
            this.txtCategoriaId.Size = new System.Drawing.Size(144, 29);
            this.txtCategoriaId.TabIndex = 53;
            this.txtCategoriaId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCategoriaId
            // 
            this.lblCategoriaId.AutoSize = true;
            this.lblCategoriaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaId.Location = new System.Drawing.Point(51, 369);
            this.lblCategoriaId.Name = "lblCategoriaId";
            this.lblCategoriaId.Size = new System.Drawing.Size(115, 24);
            this.lblCategoriaId.TabIndex = 52;
            this.lblCategoriaId.Text = "Id Categoria:";
            // 
            // txtDataAquisicao
            // 
            this.txtDataAquisicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataAquisicao.Location = new System.Drawing.Point(55, 323);
            this.txtDataAquisicao.Mask = "00/00/0000";
            this.txtDataAquisicao.Name = "txtDataAquisicao";
            this.txtDataAquisicao.Size = new System.Drawing.Size(184, 29);
            this.txtDataAquisicao.TabIndex = 51;
            this.txtDataAquisicao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataAquisicao.ValidatingType = typeof(System.DateTime);
            // 
            // lblDataAquisicao
            // 
            this.lblDataAquisicao.AutoSize = true;
            this.lblDataAquisicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataAquisicao.Location = new System.Drawing.Point(51, 296);
            this.lblDataAquisicao.Name = "lblDataAquisicao";
            this.lblDataAquisicao.Size = new System.Drawing.Size(167, 24);
            this.lblDataAquisicao.TabIndex = 50;
            this.lblDataAquisicao.Text = "Data de Aquisição:";
            // 
            // txtValorLocacao
            // 
            this.txtValorLocacao.DecimalPlaces = 2;
            this.txtValorLocacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorLocacao.Location = new System.Drawing.Point(54, 250);
            this.txtValorLocacao.Name = "txtValorLocacao";
            this.txtValorLocacao.Size = new System.Drawing.Size(144, 29);
            this.txtValorLocacao.TabIndex = 49;
            this.txtValorLocacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblValorLocacao
            // 
            this.lblValorLocacao.AutoSize = true;
            this.lblValorLocacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorLocacao.Location = new System.Drawing.Point(50, 223);
            this.lblValorLocacao.Name = "lblValorLocacao";
            this.lblValorLocacao.Size = new System.Drawing.Size(136, 24);
            this.lblValorLocacao.TabIndex = 48;
            this.lblValorLocacao.Text = "Valor Locação:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(54, 177);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(263, 29);
            this.txtDescricao.TabIndex = 47;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(50, 150);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(99, 24);
            this.lblDescricao.TabIndex = 46;
            this.lblDescricao.Text = "Descrição:";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(54, 104);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(144, 29);
            this.txtId.TabIndex = 45;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(50, 77);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(30, 24);
            this.lblId.TabIndex = 44;
            this.lblId.Text = "Id:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(278, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(287, 37);
            this.lblTitulo.TabIndex = 43;
            this.lblTitulo.Text = "Cadastro de Jogos";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // btnConsultarTodos
            // 
            this.btnConsultarTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarTodos.Location = new System.Drawing.Point(583, 508);
            this.btnConsultarTodos.Name = "btnConsultarTodos";
            this.btnConsultarTodos.Size = new System.Drawing.Size(157, 45);
            this.btnConsultarTodos.TabIndex = 58;
            this.btnConsultarTodos.Text = "Consultar Todos";
            this.btnConsultarTodos.UseVisualStyleBackColor = true;
            this.btnConsultarTodos.Click += new System.EventHandler(this.btnConsultarTodos_Click);
            // 
            // dgvJogos
            // 
            this.dgvJogos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJogos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJogos.Location = new System.Drawing.Point(332, 77);
            this.dgvJogos.Name = "dgvJogos";
            this.dgvJogos.Size = new System.Drawing.Size(438, 348);
            this.dgvJogos.TabIndex = 59;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 565);
            this.Controls.Add(this.dgvJogos);
            this.Controls.Add(this.btnConsultarTodos);
            this.Controls.Add(this.btnConsulta);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Jogos";
            ((System.ComponentModel.ISupportInitialize)(this.txtCategoriaId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorLocacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJogos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsulta;
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
        private System.Windows.Forms.DataGridView dgvJogos;
        private System.Windows.Forms.Button btnConsultarTodos;
    }
}

