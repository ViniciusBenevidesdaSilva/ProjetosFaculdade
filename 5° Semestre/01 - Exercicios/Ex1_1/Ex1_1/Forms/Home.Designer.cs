
namespace Ex1_1
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.NumericUpDown();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtMensalidade = new System.Windows.Forms.NumericUpDown();
            this.lblMensalidade = new System.Windows.Forms.Label();
            this.lblDatNascimento = new System.Windows.Forms.Label();
            this.txtDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.txtCidadeId = new System.Windows.Forms.NumericUpDown();
            this.lblCidadeId = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMensalidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCidadeId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(244, 34);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(300, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cadastro de Alunos";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(56, 114);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(39, 29);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "Id:";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(61, 146);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(144, 35);
            this.txtId.TabIndex = 2;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(56, 200);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(85, 29);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(61, 232);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(263, 35);
            this.txtNome.TabIndex = 4;
            // 
            // txtMensalidade
            // 
            this.txtMensalidade.DecimalPlaces = 2;
            this.txtMensalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensalidade.Location = new System.Drawing.Point(61, 318);
            this.txtMensalidade.Name = "txtMensalidade";
            this.txtMensalidade.Size = new System.Drawing.Size(144, 35);
            this.txtMensalidade.TabIndex = 6;
            this.txtMensalidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMensalidade
            // 
            this.lblMensalidade.AutoSize = true;
            this.lblMensalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensalidade.Location = new System.Drawing.Point(56, 286);
            this.lblMensalidade.Name = "lblMensalidade";
            this.lblMensalidade.Size = new System.Drawing.Size(158, 29);
            this.lblMensalidade.TabIndex = 5;
            this.lblMensalidade.Text = "Mensalidade:";
            // 
            // lblDatNascimento
            // 
            this.lblDatNascimento.AutoSize = true;
            this.lblDatNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatNascimento.Location = new System.Drawing.Point(459, 114);
            this.lblDatNascimento.Name = "lblDatNascimento";
            this.lblDatNascimento.Size = new System.Drawing.Size(236, 29);
            this.lblDatNascimento.TabIndex = 7;
            this.lblDatNascimento.Text = "Data de Nascimento:";
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataNascimento.Location = new System.Drawing.Point(464, 146);
            this.txtDataNascimento.Mask = "00/00/0000";
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(184, 35);
            this.txtDataNascimento.TabIndex = 8;
            this.txtDataNascimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // txtCidadeId
            // 
            this.txtCidadeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidadeId.Location = new System.Drawing.Point(464, 232);
            this.txtCidadeId.Name = "txtCidadeId";
            this.txtCidadeId.Size = new System.Drawing.Size(144, 35);
            this.txtCidadeId.TabIndex = 10;
            this.txtCidadeId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCidadeId
            // 
            this.lblCidadeId.AutoSize = true;
            this.lblCidadeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidadeId.Location = new System.Drawing.Point(459, 200);
            this.lblCidadeId.Name = "lblCidadeId";
            this.lblCidadeId.Size = new System.Drawing.Size(123, 29);
            this.lblCidadeId.TabIndex = 9;
            this.lblCidadeId.Text = "Id Cidade:";
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Location = new System.Drawing.Point(113, 384);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(157, 45);
            this.btnInserir.TabIndex = 11;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(317, 384);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(157, 45);
            this.btnAlterar.TabIndex = 12;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(521, 384);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(157, 45);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtCidadeId);
            this.Controls.Add(this.lblCidadeId);
            this.Controls.Add(this.txtDataNascimento);
            this.Controls.Add(this.lblDatNascimento);
            this.Controls.Add(this.txtMensalidade);
            this.Controls.Add(this.lblMensalidade);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro alunos";
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMensalidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCidadeId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.NumericUpDown txtId;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.NumericUpDown txtMensalidade;
        private System.Windows.Forms.Label lblMensalidade;
        private System.Windows.Forms.Label lblDatNascimento;
        private System.Windows.Forms.MaskedTextBox txtDataNascimento;
        private System.Windows.Forms.NumericUpDown txtCidadeId;
        private System.Windows.Forms.Label lblCidadeId;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
    }
}

