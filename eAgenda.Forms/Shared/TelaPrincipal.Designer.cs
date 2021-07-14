
namespace eAgenda.Forms.Shared
{
    partial class TelaPrincipal
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
            this.gBoxTarefa = new System.Windows.Forms.GroupBox();
            this.btnExcluirTarefa = new System.Windows.Forms.Button();
            this.btnEditarTarefa = new System.Windows.Forms.Button();
            this.btnVisualizarTarefa = new System.Windows.Forms.Button();
            this.btnAdicionarTarefa = new System.Windows.Forms.Button();
            this.lblEAgenda = new System.Windows.Forms.Label();
            this.gBoxContato = new System.Windows.Forms.GroupBox();
            this.btnExcluirContato = new System.Windows.Forms.Button();
            this.btnEditarContato = new System.Windows.Forms.Button();
            this.btnVisualizarContato = new System.Windows.Forms.Button();
            this.btnAdicionarContato = new System.Windows.Forms.Button();
            this.gBoxCompromisso = new System.Windows.Forms.GroupBox();
            this.btnExcluirCompromisso = new System.Windows.Forms.Button();
            this.btnEditarCompromisso = new System.Windows.Forms.Button();
            this.btnVisualizarCompromisso = new System.Windows.Forms.Button();
            this.btnAdicionarCompromisso = new System.Windows.Forms.Button();
            this.gBoxTarefa.SuspendLayout();
            this.gBoxContato.SuspendLayout();
            this.gBoxCompromisso.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxTarefa
            // 
            this.gBoxTarefa.Controls.Add(this.btnExcluirTarefa);
            this.gBoxTarefa.Controls.Add(this.btnEditarTarefa);
            this.gBoxTarefa.Controls.Add(this.btnVisualizarTarefa);
            this.gBoxTarefa.Controls.Add(this.btnAdicionarTarefa);
            this.gBoxTarefa.Location = new System.Drawing.Point(12, 75);
            this.gBoxTarefa.Name = "gBoxTarefa";
            this.gBoxTarefa.Size = new System.Drawing.Size(200, 169);
            this.gBoxTarefa.TabIndex = 0;
            this.gBoxTarefa.TabStop = false;
            this.gBoxTarefa.Text = "Tarefas";
            // 
            // btnExcluirTarefa
            // 
            this.btnExcluirTarefa.Location = new System.Drawing.Point(45, 118);
            this.btnExcluirTarefa.Name = "btnExcluirTarefa";
            this.btnExcluirTarefa.Size = new System.Drawing.Size(109, 23);
            this.btnExcluirTarefa.TabIndex = 3;
            this.btnExcluirTarefa.Text = "Excluir";
            this.btnExcluirTarefa.UseVisualStyleBackColor = true;
            this.btnExcluirTarefa.Click += new System.EventHandler(this.btnExcluirTarefa_Click);
            // 
            // btnEditarTarefa
            // 
            this.btnEditarTarefa.Location = new System.Drawing.Point(45, 89);
            this.btnEditarTarefa.Name = "btnEditarTarefa";
            this.btnEditarTarefa.Size = new System.Drawing.Size(109, 23);
            this.btnEditarTarefa.TabIndex = 2;
            this.btnEditarTarefa.Text = "Editar";
            this.btnEditarTarefa.UseVisualStyleBackColor = true;
            this.btnEditarTarefa.Click += new System.EventHandler(this.btnEditarTarefa_Click);
            // 
            // btnVisualizarTarefa
            // 
            this.btnVisualizarTarefa.Location = new System.Drawing.Point(45, 60);
            this.btnVisualizarTarefa.Name = "btnVisualizarTarefa";
            this.btnVisualizarTarefa.Size = new System.Drawing.Size(109, 23);
            this.btnVisualizarTarefa.TabIndex = 1;
            this.btnVisualizarTarefa.Text = "Visualizar";
            this.btnVisualizarTarefa.UseVisualStyleBackColor = true;
            this.btnVisualizarTarefa.Click += new System.EventHandler(this.btnVisualizarTarefa_Click);
            // 
            // btnAdicionarTarefa
            // 
            this.btnAdicionarTarefa.Location = new System.Drawing.Point(45, 31);
            this.btnAdicionarTarefa.Name = "btnAdicionarTarefa";
            this.btnAdicionarTarefa.Size = new System.Drawing.Size(109, 23);
            this.btnAdicionarTarefa.TabIndex = 0;
            this.btnAdicionarTarefa.Text = "Adicionar";
            this.btnAdicionarTarefa.UseVisualStyleBackColor = true;
            this.btnAdicionarTarefa.Click += new System.EventHandler(this.btnAdicionarTarefa_Click);
            // 
            // lblEAgenda
            // 
            this.lblEAgenda.AutoSize = true;
            this.lblEAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEAgenda.Location = new System.Drawing.Point(290, 26);
            this.lblEAgenda.Name = "lblEAgenda";
            this.lblEAgenda.Size = new System.Drawing.Size(129, 31);
            this.lblEAgenda.TabIndex = 1;
            this.lblEAgenda.Text = "eAgenda";
            // 
            // gBoxContato
            // 
            this.gBoxContato.Controls.Add(this.btnExcluirContato);
            this.gBoxContato.Controls.Add(this.btnEditarContato);
            this.gBoxContato.Controls.Add(this.btnVisualizarContato);
            this.gBoxContato.Controls.Add(this.btnAdicionarContato);
            this.gBoxContato.Location = new System.Drawing.Point(254, 75);
            this.gBoxContato.Name = "gBoxContato";
            this.gBoxContato.Size = new System.Drawing.Size(200, 169);
            this.gBoxContato.TabIndex = 2;
            this.gBoxContato.TabStop = false;
            this.gBoxContato.Text = "Contato";
            // 
            // btnExcluirContato
            // 
            this.btnExcluirContato.Location = new System.Drawing.Point(45, 118);
            this.btnExcluirContato.Name = "btnExcluirContato";
            this.btnExcluirContato.Size = new System.Drawing.Size(109, 23);
            this.btnExcluirContato.TabIndex = 3;
            this.btnExcluirContato.Text = "Excluir";
            this.btnExcluirContato.UseVisualStyleBackColor = true;
            this.btnExcluirContato.Click += new System.EventHandler(this.btnExcluirContato_Click);
            // 
            // btnEditarContato
            // 
            this.btnEditarContato.Location = new System.Drawing.Point(45, 89);
            this.btnEditarContato.Name = "btnEditarContato";
            this.btnEditarContato.Size = new System.Drawing.Size(109, 23);
            this.btnEditarContato.TabIndex = 2;
            this.btnEditarContato.Text = "Editar";
            this.btnEditarContato.UseVisualStyleBackColor = true;
            this.btnEditarContato.Click += new System.EventHandler(this.btnEditarContato_Click);
            // 
            // btnVisualizarContato
            // 
            this.btnVisualizarContato.Location = new System.Drawing.Point(45, 60);
            this.btnVisualizarContato.Name = "btnVisualizarContato";
            this.btnVisualizarContato.Size = new System.Drawing.Size(109, 23);
            this.btnVisualizarContato.TabIndex = 1;
            this.btnVisualizarContato.Text = "Visualizar";
            this.btnVisualizarContato.UseVisualStyleBackColor = true;
            this.btnVisualizarContato.Click += new System.EventHandler(this.btnVisualizarContato_Click);
            // 
            // btnAdicionarContato
            // 
            this.btnAdicionarContato.Location = new System.Drawing.Point(45, 31);
            this.btnAdicionarContato.Name = "btnAdicionarContato";
            this.btnAdicionarContato.Size = new System.Drawing.Size(109, 23);
            this.btnAdicionarContato.TabIndex = 0;
            this.btnAdicionarContato.Text = "Adicionar";
            this.btnAdicionarContato.UseVisualStyleBackColor = true;
            this.btnAdicionarContato.Click += new System.EventHandler(this.btnAdicionarContato_Click);
            // 
            // gBoxCompromisso
            // 
            this.gBoxCompromisso.Controls.Add(this.btnExcluirCompromisso);
            this.gBoxCompromisso.Controls.Add(this.btnEditarCompromisso);
            this.gBoxCompromisso.Controls.Add(this.btnVisualizarCompromisso);
            this.gBoxCompromisso.Controls.Add(this.btnAdicionarCompromisso);
            this.gBoxCompromisso.Location = new System.Drawing.Point(497, 75);
            this.gBoxCompromisso.Name = "gBoxCompromisso";
            this.gBoxCompromisso.Size = new System.Drawing.Size(200, 169);
            this.gBoxCompromisso.TabIndex = 3;
            this.gBoxCompromisso.TabStop = false;
            this.gBoxCompromisso.Text = "Compromisso";
            // 
            // btnExcluirCompromisso
            // 
            this.btnExcluirCompromisso.Location = new System.Drawing.Point(45, 118);
            this.btnExcluirCompromisso.Name = "btnExcluirCompromisso";
            this.btnExcluirCompromisso.Size = new System.Drawing.Size(109, 23);
            this.btnExcluirCompromisso.TabIndex = 3;
            this.btnExcluirCompromisso.Text = "Excluir";
            this.btnExcluirCompromisso.UseVisualStyleBackColor = true;
            this.btnExcluirCompromisso.Click += new System.EventHandler(this.btnExcluirCompromisso_Click);
            // 
            // btnEditarCompromisso
            // 
            this.btnEditarCompromisso.Location = new System.Drawing.Point(45, 89);
            this.btnEditarCompromisso.Name = "btnEditarCompromisso";
            this.btnEditarCompromisso.Size = new System.Drawing.Size(109, 23);
            this.btnEditarCompromisso.TabIndex = 2;
            this.btnEditarCompromisso.Text = "Editar";
            this.btnEditarCompromisso.UseVisualStyleBackColor = true;
            this.btnEditarCompromisso.Click += new System.EventHandler(this.btnEditarCompromisso_Click);
            // 
            // btnVisualizarCompromisso
            // 
            this.btnVisualizarCompromisso.Location = new System.Drawing.Point(45, 60);
            this.btnVisualizarCompromisso.Name = "btnVisualizarCompromisso";
            this.btnVisualizarCompromisso.Size = new System.Drawing.Size(109, 23);
            this.btnVisualizarCompromisso.TabIndex = 1;
            this.btnVisualizarCompromisso.Text = "Visualizar";
            this.btnVisualizarCompromisso.UseVisualStyleBackColor = true;
            this.btnVisualizarCompromisso.Click += new System.EventHandler(this.btnVisualizarCompromisso_Click);
            // 
            // btnAdicionarCompromisso
            // 
            this.btnAdicionarCompromisso.Location = new System.Drawing.Point(45, 31);
            this.btnAdicionarCompromisso.Name = "btnAdicionarCompromisso";
            this.btnAdicionarCompromisso.Size = new System.Drawing.Size(109, 23);
            this.btnAdicionarCompromisso.TabIndex = 0;
            this.btnAdicionarCompromisso.Text = "Adicionar";
            this.btnAdicionarCompromisso.UseVisualStyleBackColor = true;
            this.btnAdicionarCompromisso.Click += new System.EventHandler(this.btnAdicionarCompromisso_Click);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 276);
            this.Controls.Add(this.gBoxCompromisso);
            this.Controls.Add(this.gBoxContato);
            this.Controls.Add(this.lblEAgenda);
            this.Controls.Add(this.gBoxTarefa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TelaPrincipal";
            this.Text = "eAgenda - Academia do Programador 2021";
            this.gBoxTarefa.ResumeLayout(false);
            this.gBoxContato.ResumeLayout(false);
            this.gBoxCompromisso.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxTarefa;
        private System.Windows.Forms.Label lblEAgenda;
        private System.Windows.Forms.Button btnExcluirTarefa;
        private System.Windows.Forms.Button btnEditarTarefa;
        private System.Windows.Forms.Button btnVisualizarTarefa;
        private System.Windows.Forms.Button btnAdicionarTarefa;
        private System.Windows.Forms.GroupBox gBoxContato;
        private System.Windows.Forms.Button btnExcluirContato;
        private System.Windows.Forms.Button btnEditarContato;
        private System.Windows.Forms.Button btnVisualizarContato;
        private System.Windows.Forms.Button btnAdicionarContato;
        private System.Windows.Forms.GroupBox gBoxCompromisso;
        private System.Windows.Forms.Button btnExcluirCompromisso;
        private System.Windows.Forms.Button btnEditarCompromisso;
        private System.Windows.Forms.Button btnVisualizarCompromisso;
        private System.Windows.Forms.Button btnAdicionarCompromisso;
    }
}