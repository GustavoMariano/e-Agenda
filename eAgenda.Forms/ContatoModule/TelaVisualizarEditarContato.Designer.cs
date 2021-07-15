
namespace eAgenda.Forms.ContatoModule
{
    partial class TelaVisualizarEditarContato
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
            this.lblVisualizarContato = new System.Windows.Forms.Label();
            this.lBoxContatos = new System.Windows.Forms.ListBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.gBoxEditar = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblIdContato = new System.Windows.Forms.Label();
            this.tBoxNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tBoxEmail = new System.Windows.Forms.TextBox();
            this.mskTBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.tBoxEmpresa = new System.Windows.Forms.TextBox();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.tBoxCargo = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.gBoxEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVisualizarContato
            // 
            this.lblVisualizarContato.AutoSize = true;
            this.lblVisualizarContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisualizarContato.Location = new System.Drawing.Point(240, 26);
            this.lblVisualizarContato.Name = "lblVisualizarContato";
            this.lblVisualizarContato.Size = new System.Drawing.Size(117, 31);
            this.lblVisualizarContato.TabIndex = 4;
            this.lblVisualizarContato.Text = "Contato";
            this.lblVisualizarContato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lBoxContatos
            // 
            this.lBoxContatos.FormattingEnabled = true;
            this.lBoxContatos.Location = new System.Drawing.Point(12, 82);
            this.lBoxContatos.Name = "lBoxContatos";
            this.lBoxContatos.Size = new System.Drawing.Size(588, 355);
            this.lBoxContatos.TabIndex = 0;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(522, 443);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 5;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVoltar.Location = new System.Drawing.Point(441, 443);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(522, 443);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionar.TabIndex = 8;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // gBoxEditar
            // 
            this.gBoxEditar.Controls.Add(this.tBoxCargo);
            this.gBoxEditar.Controls.Add(this.lblCargo);
            this.gBoxEditar.Controls.Add(this.tBoxEmpresa);
            this.gBoxEditar.Controls.Add(this.lblEmpresa);
            this.gBoxEditar.Controls.Add(this.mskTBoxTelefone);
            this.gBoxEditar.Controls.Add(this.tBoxEmail);
            this.gBoxEditar.Controls.Add(this.lblId);
            this.gBoxEditar.Controls.Add(this.lblTelefone);
            this.gBoxEditar.Controls.Add(this.lblEmail);
            this.gBoxEditar.Controls.Add(this.lblIdContato);
            this.gBoxEditar.Controls.Add(this.tBoxNome);
            this.gBoxEditar.Controls.Add(this.lblNome);
            this.gBoxEditar.Enabled = false;
            this.gBoxEditar.Location = new System.Drawing.Point(9, 482);
            this.gBoxEditar.Name = "gBoxEditar";
            this.gBoxEditar.Size = new System.Drawing.Size(591, 189);
            this.gBoxEditar.TabIndex = 9;
            this.gBoxEditar.TabStop = false;
            this.gBoxEditar.Text = "Editar";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(244, 18);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 11;
            this.lblId.Text = "ID";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(428, 85);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 9;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 85);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "E-mail";
            // 
            // lblIdContato
            // 
            this.lblIdContato.AutoSize = true;
            this.lblIdContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdContato.Location = new System.Drawing.Point(275, 16);
            this.lblIdContato.Name = "lblIdContato";
            this.lblIdContato.Size = new System.Drawing.Size(11, 15);
            this.lblIdContato.TabIndex = 3;
            this.lblIdContato.Text = " ";
            // 
            // tBoxNome
            // 
            this.tBoxNome.Location = new System.Drawing.Point(9, 49);
            this.tBoxNome.Name = "tBoxNome";
            this.tBoxNome.Size = new System.Drawing.Size(576, 20);
            this.tBoxNome.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(9, 33);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(519, 682);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // tBoxEmail
            // 
            this.tBoxEmail.Location = new System.Drawing.Point(12, 102);
            this.tBoxEmail.Name = "tBoxEmail";
            this.tBoxEmail.Size = new System.Drawing.Size(396, 20);
            this.tBoxEmail.TabIndex = 12;
            // 
            // mskTBoxTelefone
            // 
            this.mskTBoxTelefone.Location = new System.Drawing.Point(431, 102);
            this.mskTBoxTelefone.Mask = "(99) 99999-9999";
            this.mskTBoxTelefone.Name = "mskTBoxTelefone";
            this.mskTBoxTelefone.Size = new System.Drawing.Size(100, 20);
            this.mskTBoxTelefone.TabIndex = 13;
            // 
            // tBoxEmpresa
            // 
            this.tBoxEmpresa.Location = new System.Drawing.Point(12, 148);
            this.tBoxEmpresa.Name = "tBoxEmpresa";
            this.tBoxEmpresa.Size = new System.Drawing.Size(274, 20);
            this.tBoxEmpresa.TabIndex = 15;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(12, 131);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(48, 13);
            this.lblEmpresa.TabIndex = 14;
            this.lblEmpresa.Text = "Empresa";
            // 
            // tBoxCargo
            // 
            this.tBoxCargo.Location = new System.Drawing.Point(312, 148);
            this.tBoxCargo.Name = "tBoxCargo";
            this.tBoxCargo.Size = new System.Drawing.Size(273, 20);
            this.tBoxCargo.TabIndex = 17;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(312, 131);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(35, 13);
            this.lblCargo.TabIndex = 16;
            this.lblCargo.Text = "Cargo";
            // 
            // TelaVisualizarEditarContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 712);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gBoxEditar);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.lBoxContatos);
            this.Controls.Add(this.lblVisualizarContato);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TelaVisualizarEditarContato";
            this.Text = "eAgenda - Visualizar Contato";
            this.gBoxEditar.ResumeLayout(false);
            this.gBoxEditar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVisualizarContato;
        private System.Windows.Forms.ListBox lBoxContatos;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.GroupBox gBoxEditar;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblIdContato;
        private System.Windows.Forms.TextBox tBoxNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox tBoxEmail;
        private System.Windows.Forms.TextBox tBoxCargo;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox tBoxEmpresa;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.MaskedTextBox mskTBoxTelefone;
    }
}