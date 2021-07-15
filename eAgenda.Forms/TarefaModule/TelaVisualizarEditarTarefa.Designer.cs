
namespace eAgenda.Forms.TarefaModule
{
    partial class TelaVisualizarEditarTarefa
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
            this.lBoxTarefasPendentes = new System.Windows.Forms.ListBox();
            this.tabTarefas = new System.Windows.Forms.TabControl();
            this.tabTarefasPendentes = new System.Windows.Forms.TabPage();
            this.tabTarefasConcluidas = new System.Windows.Forms.TabPage();
            this.lBoxTarefasConcluidas = new System.Windows.Forms.ListBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.lblAdicionarTarefa = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.gBoxEditar = new System.Windows.Forms.GroupBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tBoxTitulo = new System.Windows.Forms.TextBox();
            this.lblIdTarefa = new System.Windows.Forms.Label();
            this.lblDataCriacao = new System.Windows.Forms.Label();
            this.lblDataConclusao = new System.Windows.Forms.Label();
            this.cBoxPrioridade = new System.Windows.Forms.ComboBox();
            this.lblPrioridade = new System.Windows.Forms.Label();
            this.lblPercentual = new System.Windows.Forms.Label();
            this.numUpDownPercentual = new System.Windows.Forms.NumericUpDown();
            this.lblId = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tabTarefas.SuspendLayout();
            this.tabTarefasPendentes.SuspendLayout();
            this.tabTarefasConcluidas.SuspendLayout();
            this.gBoxEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPercentual)).BeginInit();
            this.SuspendLayout();
            // 
            // lBoxTarefasPendentes
            // 
            this.lBoxTarefasPendentes.FormattingEnabled = true;
            this.lBoxTarefasPendentes.Location = new System.Drawing.Point(6, 6);
            this.lBoxTarefasPendentes.Name = "lBoxTarefasPendentes";
            this.lBoxTarefasPendentes.Size = new System.Drawing.Size(588, 355);
            this.lBoxTarefasPendentes.TabIndex = 0;
            // 
            // tabTarefas
            // 
            this.tabTarefas.Controls.Add(this.tabTarefasPendentes);
            this.tabTarefas.Controls.Add(this.tabTarefasConcluidas);
            this.tabTarefas.Location = new System.Drawing.Point(0, 68);
            this.tabTarefas.Name = "tabTarefas";
            this.tabTarefas.SelectedIndex = 0;
            this.tabTarefas.Size = new System.Drawing.Size(605, 388);
            this.tabTarefas.TabIndex = 1;
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
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(523, 455);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 2;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // lblAdicionarTarefa
            // 
            this.lblAdicionarTarefa.AutoSize = true;
            this.lblAdicionarTarefa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicionarTarefa.Location = new System.Drawing.Point(245, 26);
            this.lblAdicionarTarefa.Name = "lblAdicionarTarefa";
            this.lblAdicionarTarefa.Size = new System.Drawing.Size(99, 31);
            this.lblAdicionarTarefa.TabIndex = 3;
            this.lblAdicionarTarefa.Text = "Tarefa";
            this.lblAdicionarTarefa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVoltar
            // 
            this.btnVoltar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVoltar.Location = new System.Drawing.Point(431, 682);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(523, 455);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionar.TabIndex = 5;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // gBoxEditar
            // 
            this.gBoxEditar.Controls.Add(this.lblId);
            this.gBoxEditar.Controls.Add(this.numUpDownPercentual);
            this.gBoxEditar.Controls.Add(this.lblPercentual);
            this.gBoxEditar.Controls.Add(this.lblPrioridade);
            this.gBoxEditar.Controls.Add(this.cBoxPrioridade);
            this.gBoxEditar.Controls.Add(this.lblDataConclusao);
            this.gBoxEditar.Controls.Add(this.lblDataCriacao);
            this.gBoxEditar.Controls.Add(this.lblIdTarefa);
            this.gBoxEditar.Controls.Add(this.tBoxTitulo);
            this.gBoxEditar.Controls.Add(this.lblTitulo);
            this.gBoxEditar.Enabled = false;
            this.gBoxEditar.Location = new System.Drawing.Point(7, 484);
            this.gBoxEditar.Name = "gBoxEditar";
            this.gBoxEditar.Size = new System.Drawing.Size(591, 174);
            this.gBoxEditar.TabIndex = 6;
            this.gBoxEditar.TabStop = false;
            this.gBoxEditar.Text = "Editar";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(9, 33);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(33, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo";
            // 
            // tBoxTitulo
            // 
            this.tBoxTitulo.Location = new System.Drawing.Point(9, 49);
            this.tBoxTitulo.Name = "tBoxTitulo";
            this.tBoxTitulo.Size = new System.Drawing.Size(576, 20);
            this.tBoxTitulo.TabIndex = 2;
            // 
            // lblIdTarefa
            // 
            this.lblIdTarefa.AutoSize = true;
            this.lblIdTarefa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdTarefa.Location = new System.Drawing.Point(275, 16);
            this.lblIdTarefa.Name = "lblIdTarefa";
            this.lblIdTarefa.Size = new System.Drawing.Size(11, 15);
            this.lblIdTarefa.TabIndex = 3;
            this.lblIdTarefa.Text = " ";
            // 
            // lblDataCriacao
            // 
            this.lblDataCriacao.AutoSize = true;
            this.lblDataCriacao.Location = new System.Drawing.Point(9, 88);
            this.lblDataCriacao.Name = "lblDataCriacao";
            this.lblDataCriacao.Size = new System.Drawing.Size(10, 13);
            this.lblDataCriacao.TabIndex = 4;
            this.lblDataCriacao.Text = " ";
            // 
            // lblDataConclusao
            // 
            this.lblDataConclusao.AutoSize = true;
            this.lblDataConclusao.Location = new System.Drawing.Point(327, 88);
            this.lblDataConclusao.Name = "lblDataConclusao";
            this.lblDataConclusao.Size = new System.Drawing.Size(10, 13);
            this.lblDataConclusao.TabIndex = 5;
            this.lblDataConclusao.Text = " ";
            // 
            // cBoxPrioridade
            // 
            this.cBoxPrioridade.FormattingEnabled = true;
            this.cBoxPrioridade.Items.AddRange(new object[] {
            "Baixa",
            "Normal",
            "Alta"});
            this.cBoxPrioridade.Location = new System.Drawing.Point(9, 121);
            this.cBoxPrioridade.Name = "cBoxPrioridade";
            this.cBoxPrioridade.Size = new System.Drawing.Size(121, 21);
            this.cBoxPrioridade.TabIndex = 6;
            // 
            // lblPrioridade
            // 
            this.lblPrioridade.AutoSize = true;
            this.lblPrioridade.Location = new System.Drawing.Point(9, 105);
            this.lblPrioridade.Name = "lblPrioridade";
            this.lblPrioridade.Size = new System.Drawing.Size(54, 13);
            this.lblPrioridade.TabIndex = 7;
            this.lblPrioridade.Text = "Prioridade";
            // 
            // lblPercentual
            // 
            this.lblPercentual.AutoSize = true;
            this.lblPercentual.Location = new System.Drawing.Point(401, 105);
            this.lblPercentual.Name = "lblPercentual";
            this.lblPercentual.Size = new System.Drawing.Size(58, 13);
            this.lblPercentual.TabIndex = 9;
            this.lblPercentual.Text = "Percentual";
            // 
            // numUpDownPercentual
            // 
            this.numUpDownPercentual.Location = new System.Drawing.Point(404, 121);
            this.numUpDownPercentual.Name = "numUpDownPercentual";
            this.numUpDownPercentual.Size = new System.Drawing.Size(76, 20);
            this.numUpDownPercentual.TabIndex = 10;
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
            // btnSalvar
            // 
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalvar.Location = new System.Drawing.Point(523, 682);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // TelaVisualizarEditarTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 712);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gBoxEditar);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblAdicionarTarefa);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.tabTarefas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TelaVisualizarEditarTarefa";
            this.Text = "eAgenda - Visualizar Tarefa";
            this.tabTarefas.ResumeLayout(false);
            this.tabTarefasPendentes.ResumeLayout(false);
            this.tabTarefasConcluidas.ResumeLayout(false);
            this.gBoxEditar.ResumeLayout(false);
            this.gBoxEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPercentual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lBoxTarefasPendentes;
        private System.Windows.Forms.TabControl tabTarefas;
        private System.Windows.Forms.TabPage tabTarefasPendentes;
        private System.Windows.Forms.TabPage tabTarefasConcluidas;
        private System.Windows.Forms.ListBox lBoxTarefasConcluidas;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label lblAdicionarTarefa;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.GroupBox gBoxEditar;
        private System.Windows.Forms.Label lblIdTarefa;
        private System.Windows.Forms.TextBox tBoxTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDataCriacao;
        private System.Windows.Forms.Label lblDataConclusao;
        private System.Windows.Forms.Label lblPrioridade;
        private System.Windows.Forms.ComboBox cBoxPrioridade;
        private System.Windows.Forms.NumericUpDown numUpDownPercentual;
        private System.Windows.Forms.Label lblPercentual;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnSalvar;
    }
}