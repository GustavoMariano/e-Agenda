
namespace eAgenda.Forms.TarefaModule
{
    partial class TelaExcluirTarefa
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
            this.tabTarefas = new System.Windows.Forms.TabControl();
            this.tabTarefasPendentes = new System.Windows.Forms.TabPage();
            this.lBoxTarefasPendentes = new System.Windows.Forms.ListBox();
            this.tabTarefasConcluidas = new System.Windows.Forms.TabPage();
            this.lBoxTarefasConcluidas = new System.Windows.Forms.ListBox();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.tabTarefas.SuspendLayout();
            this.tabTarefasPendentes.SuspendLayout();
            this.tabTarefasConcluidas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAdicionarTarefa
            // 
            this.lblAdicionarTarefa.AutoSize = true;
            this.lblAdicionarTarefa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicionarTarefa.Location = new System.Drawing.Point(245, 26);
            this.lblAdicionarTarefa.Name = "lblAdicionarTarefa";
            this.lblAdicionarTarefa.Size = new System.Drawing.Size(99, 31);
            this.lblAdicionarTarefa.TabIndex = 4;
            this.lblAdicionarTarefa.Text = "Tarefa";
            this.lblAdicionarTarefa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabTarefas
            // 
            this.tabTarefas.Controls.Add(this.tabTarefasPendentes);
            this.tabTarefas.Controls.Add(this.tabTarefasConcluidas);
            this.tabTarefas.Location = new System.Drawing.Point(0, 68);
            this.tabTarefas.Name = "tabTarefas";
            this.tabTarefas.SelectedIndex = 0;
            this.tabTarefas.Size = new System.Drawing.Size(605, 388);
            this.tabTarefas.TabIndex = 5;
            // 
            // tabTarefasPendentes
            // 
            this.tabTarefasPendentes.Controls.Add(this.lBoxTarefasPendentes);
            this.tabTarefasPendentes.Location = new System.Drawing.Point(4, 22);
            this.tabTarefasPendentes.Name = "tabTarefasPendentes";
            this.tabTarefasPendentes.Padding = new System.Windows.Forms.Padding(3);
            this.tabTarefasPendentes.Size = new System.Drawing.Size(597, 362);
            this.tabTarefasPendentes.TabIndex = 0;
            this.tabTarefasPendentes.Text = "Tarefas Pendentes";
            this.tabTarefasPendentes.UseVisualStyleBackColor = true;
            // 
            // lBoxTarefasPendentes
            // 
            this.lBoxTarefasPendentes.FormattingEnabled = true;
            this.lBoxTarefasPendentes.Location = new System.Drawing.Point(6, 6);
            this.lBoxTarefasPendentes.Name = "lBoxTarefasPendentes";
            this.lBoxTarefasPendentes.Size = new System.Drawing.Size(588, 355);
            this.lBoxTarefasPendentes.TabIndex = 0;
            // 
            // tabTarefasConcluidas
            // 
            this.tabTarefasConcluidas.Controls.Add(this.lBoxTarefasConcluidas);
            this.tabTarefasConcluidas.Location = new System.Drawing.Point(4, 22);
            this.tabTarefasConcluidas.Name = "tabTarefasConcluidas";
            this.tabTarefasConcluidas.Padding = new System.Windows.Forms.Padding(3);
            this.tabTarefasConcluidas.Size = new System.Drawing.Size(597, 362);
            this.tabTarefasConcluidas.TabIndex = 1;
            this.tabTarefasConcluidas.Text = "Tarefas Concluidas";
            this.tabTarefasConcluidas.UseVisualStyleBackColor = true;
            // 
            // lBoxTarefasConcluidas
            // 
            this.lBoxTarefasConcluidas.FormattingEnabled = true;
            this.lBoxTarefasConcluidas.Location = new System.Drawing.Point(6, 4);
            this.lBoxTarefasConcluidas.Name = "lBoxTarefasConcluidas";
            this.lBoxTarefasConcluidas.Size = new System.Drawing.Size(588, 355);
            this.lBoxTarefasConcluidas.TabIndex = 1;
            // 
            // btnDeletar
            // 
            this.btnDeletar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDeletar.Location = new System.Drawing.Point(522, 458);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 6;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVoltar.Location = new System.Drawing.Point(360, 458);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 7;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(441, 458);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 8;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // TelaExcluirTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 489);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.tabTarefas);
            this.Controls.Add(this.lblAdicionarTarefa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TelaExcluirTarefa";
            this.Text = "eAgenda - Deletar Tarefa";
            this.tabTarefas.ResumeLayout(false);
            this.tabTarefasPendentes.ResumeLayout(false);
            this.tabTarefasConcluidas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdicionarTarefa;
        private System.Windows.Forms.TabControl tabTarefas;
        private System.Windows.Forms.TabPage tabTarefasPendentes;
        private System.Windows.Forms.ListBox lBoxTarefasPendentes;
        private System.Windows.Forms.TabPage tabTarefasConcluidas;
        private System.Windows.Forms.ListBox lBoxTarefasConcluidas;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAtualizar;
    }
}