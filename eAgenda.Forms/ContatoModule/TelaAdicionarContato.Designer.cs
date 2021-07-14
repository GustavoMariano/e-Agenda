
namespace eAgenda.Forms.ContatoModule
{
    partial class TelaAdicionarContato
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
            this.lblAdicionarContato = new System.Windows.Forms.Label();
            this.gBoxAdicionarContato = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.tBoxNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.tBoxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.mskTBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblCamposObrigatorios = new System.Windows.Forms.Label();
            this.tBoxEmpresa = new System.Windows.Forms.TextBox();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.tBoxCargo = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.gBoxAdicionarContato.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAdicionarContato
            // 
            this.lblAdicionarContato.AutoSize = true;
            this.lblAdicionarContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicionarContato.Location = new System.Drawing.Point(285, 26);
            this.lblAdicionarContato.Name = "lblAdicionarContato";
            this.lblAdicionarContato.Size = new System.Drawing.Size(117, 31);
            this.lblAdicionarContato.TabIndex = 3;
            this.lblAdicionarContato.Text = "Contato";
            this.lblAdicionarContato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gBoxAdicionarContato
            // 
            this.gBoxAdicionarContato.Controls.Add(this.tBoxCargo);
            this.gBoxAdicionarContato.Controls.Add(this.lblCargo);
            this.gBoxAdicionarContato.Controls.Add(this.tBoxEmpresa);
            this.gBoxAdicionarContato.Controls.Add(this.lblEmpresa);
            this.gBoxAdicionarContato.Controls.Add(this.lblCamposObrigatorios);
            this.gBoxAdicionarContato.Controls.Add(this.mskTBoxTelefone);
            this.gBoxAdicionarContato.Controls.Add(this.lblTelefone);
            this.gBoxAdicionarContato.Controls.Add(this.tBoxEmail);
            this.gBoxAdicionarContato.Controls.Add(this.lblEmail);
            this.gBoxAdicionarContato.Controls.Add(this.btnLimpar);
            this.gBoxAdicionarContato.Controls.Add(this.btnCancelar);
            this.gBoxAdicionarContato.Controls.Add(this.btnAdicionar);
            this.gBoxAdicionarContato.Controls.Add(this.tBoxNome);
            this.gBoxAdicionarContato.Controls.Add(this.lblNome);
            this.gBoxAdicionarContato.Location = new System.Drawing.Point(12, 75);
            this.gBoxAdicionarContato.Name = "gBoxAdicionarContato";
            this.gBoxAdicionarContato.Size = new System.Drawing.Size(685, 196);
            this.gBoxAdicionarContato.TabIndex = 4;
            this.gBoxAdicionarContato.TabStop = false;
            this.gBoxAdicionarContato.Text = "Adicionar";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(523, 167);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(442, 167);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(604, 167);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // tBoxNome
            // 
            this.tBoxNome.Location = new System.Drawing.Point(9, 41);
            this.tBoxNome.Name = "tBoxNome";
            this.tBoxNome.Size = new System.Drawing.Size(670, 20);
            this.tBoxNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(9, 25);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // tBoxEmail
            // 
            this.tBoxEmail.Location = new System.Drawing.Point(9, 86);
            this.tBoxEmail.Name = "tBoxEmail";
            this.tBoxEmail.Size = new System.Drawing.Size(532, 20);
            this.tBoxEmail.TabIndex = 8;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(9, 70);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 13);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "E-mail*";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(564, 70);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(53, 13);
            this.lblTelefone.TabIndex = 9;
            this.lblTelefone.Text = "Telefone*";
            // 
            // mskTBoxTelefone
            // 
            this.mskTBoxTelefone.Location = new System.Drawing.Point(564, 86);
            this.mskTBoxTelefone.Mask = "(99) 99999-9999";
            this.mskTBoxTelefone.Name = "mskTBoxTelefone";
            this.mskTBoxTelefone.Size = new System.Drawing.Size(115, 20);
            this.mskTBoxTelefone.TabIndex = 10;
            // 
            // lblCamposObrigatorios
            // 
            this.lblCamposObrigatorios.AutoSize = true;
            this.lblCamposObrigatorios.Location = new System.Drawing.Point(6, 177);
            this.lblCamposObrigatorios.Name = "lblCamposObrigatorios";
            this.lblCamposObrigatorios.Size = new System.Drawing.Size(129, 13);
            this.lblCamposObrigatorios.TabIndex = 11;
            this.lblCamposObrigatorios.Text = "Campos * são obrigatórios";
            // 
            // tBoxEmpresa
            // 
            this.tBoxEmpresa.Location = new System.Drawing.Point(9, 129);
            this.tBoxEmpresa.Name = "tBoxEmpresa";
            this.tBoxEmpresa.Size = new System.Drawing.Size(322, 20);
            this.tBoxEmpresa.TabIndex = 13;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(9, 113);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(48, 13);
            this.lblEmpresa.TabIndex = 12;
            this.lblEmpresa.Text = "Empresa";
            // 
            // tBoxCargo
            // 
            this.tBoxCargo.Location = new System.Drawing.Point(357, 129);
            this.tBoxCargo.Name = "tBoxCargo";
            this.tBoxCargo.Size = new System.Drawing.Size(322, 20);
            this.tBoxCargo.TabIndex = 15;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(357, 113);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(35, 13);
            this.lblCargo.TabIndex = 14;
            this.lblCargo.Text = "Cargo";
            // 
            // TelaAdicionarContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 283);
            this.Controls.Add(this.gBoxAdicionarContato);
            this.Controls.Add(this.lblAdicionarContato);
            this.MaximizeBox = false;
            this.Name = "TelaAdicionarContato";
            this.Text = "eAgenda - Adicionar Contato";
            this.gBoxAdicionarContato.ResumeLayout(false);
            this.gBoxAdicionarContato.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdicionarContato;
        private System.Windows.Forms.GroupBox gBoxAdicionarContato;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox tBoxNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox tBoxEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.MaskedTextBox mskTBoxTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox tBoxCargo;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox tBoxEmpresa;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblCamposObrigatorios;
    }
}