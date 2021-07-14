
namespace eAgenda.Forms.TarefaModule
{
    partial class TelaAdicionarTarefa
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
            this.lblAdicionarTarefa = new System.Windows.Forms.Label();
            this.gBoxAdicionarTarefa = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.cBoxPrioridade = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCamposObrigatorios = new System.Windows.Forms.Label();
            this.gBoxAdicionarTarefa.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAdicionarTarefa
            // 
            this.lblAdicionarTarefa.AutoSize = true;
            this.lblAdicionarTarefa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicionarTarefa.Location = new System.Drawing.Point(290, 26);
            this.lblAdicionarTarefa.Name = "lblAdicionarTarefa";
            this.lblAdicionarTarefa.Size = new System.Drawing.Size(99, 31);
            this.lblAdicionarTarefa.TabIndex = 2;
            this.lblAdicionarTarefa.Text = "Tarefa";
            this.lblAdicionarTarefa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gBoxAdicionarTarefa
            // 
            this.gBoxAdicionarTarefa.Controls.Add(this.lblCamposObrigatorios);
            this.gBoxAdicionarTarefa.Controls.Add(this.btnLimpar);
            this.gBoxAdicionarTarefa.Controls.Add(this.btnCancelar);
            this.gBoxAdicionarTarefa.Controls.Add(this.btnAdicionar);
            this.gBoxAdicionarTarefa.Controls.Add(this.cBoxPrioridade);
            this.gBoxAdicionarTarefa.Controls.Add(this.label1);
            this.gBoxAdicionarTarefa.Controls.Add(this.tBoxTitulo);
            this.gBoxAdicionarTarefa.Controls.Add(this.lblTitulo);
            this.gBoxAdicionarTarefa.Location = new System.Drawing.Point(12, 75);
            this.gBoxAdicionarTarefa.Name = "gBoxAdicionarTarefa";
            this.gBoxAdicionarTarefa.Size = new System.Drawing.Size(685, 196);
            this.gBoxAdicionarTarefa.TabIndex = 3;
            this.gBoxAdicionarTarefa.TabStop = false;
            this.gBoxAdicionarTarefa.Text = "Adicionar";
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
            // cBoxPrioridade
            // 
            this.cBoxPrioridade.FormattingEnabled = true;
            this.cBoxPrioridade.Items.AddRange(new object[] {
            "Baixa",
            "Média",
            "Alta"});
            this.cBoxPrioridade.Location = new System.Drawing.Point(9, 98);
            this.cBoxPrioridade.Name = "cBoxPrioridade";
            this.cBoxPrioridade.Size = new System.Drawing.Size(155, 21);
            this.cBoxPrioridade.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Prioridade*";
            // 
            // tBoxTitulo
            // 
            this.tBoxTitulo.Location = new System.Drawing.Point(9, 41);
            this.tBoxTitulo.Name = "tBoxTitulo";
            this.tBoxTitulo.Size = new System.Drawing.Size(670, 20);
            this.tBoxTitulo.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(9, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(39, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Título*";
            // 
            // lblCamposObrigatorios
            // 
            this.lblCamposObrigatorios.AutoSize = true;
            this.lblCamposObrigatorios.Location = new System.Drawing.Point(6, 177);
            this.lblCamposObrigatorios.Name = "lblCamposObrigatorios";
            this.lblCamposObrigatorios.Size = new System.Drawing.Size(129, 13);
            this.lblCamposObrigatorios.TabIndex = 12;
            this.lblCamposObrigatorios.Text = "Campos * são obrigatórios";
            // 
            // TelaAdicionarTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 283);
            this.Controls.Add(this.gBoxAdicionarTarefa);
            this.Controls.Add(this.lblAdicionarTarefa);
            this.MaximizeBox = false;
            this.Name = "TelaAdicionarTarefa";
            this.Text = "eAgenda - Adicionar Tarefa";
            this.gBoxAdicionarTarefa.ResumeLayout(false);
            this.gBoxAdicionarTarefa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdicionarTarefa;
        private System.Windows.Forms.GroupBox gBoxAdicionarTarefa;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ComboBox cBoxPrioridade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCamposObrigatorios;
    }
}