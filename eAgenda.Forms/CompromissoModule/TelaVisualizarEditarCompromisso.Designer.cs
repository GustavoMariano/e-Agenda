
namespace eAgenda.Forms.CompromissoModule
{
    partial class TelaVisualizarEditarCompromisso
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
            this.lBoxCompromissos = new System.Windows.Forms.ListBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.gBoxEditarCompromisso = new System.Windows.Forms.GroupBox();
            this.lblIdContato = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.gBoxAdicionarContato = new System.Windows.Forms.GroupBox();
            this.lblAdicionarContato = new System.Windows.Forms.Label();
            this.lBoxContatos = new System.Windows.Forms.ListBox();
            this.rBtnNaoPossuiContato = new System.Windows.Forms.RadioButton();
            this.rBtnPossuiContato = new System.Windows.Forms.RadioButton();
            this.rBtnRemoto = new System.Windows.Forms.RadioButton();
            this.rBtnPresencial = new System.Windows.Forms.RadioButton();
            this.dateTPHoraConclusao = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTPHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.dateTKDataInicio = new System.Windows.Forms.DateTimePicker();
            this.lblDataCompromisso = new System.Windows.Forms.Label();
            this.lblCamposObrigatorios = new System.Windows.Forms.Label();
            this.tBoxLinkLocalizacao = new System.Windows.Forms.TextBox();
            this.lblLinkLocalizacao = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tBoxAssunto = new System.Windows.Forms.TextBox();
            this.lblAssunto = new System.Windows.Forms.Label();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.gBoxEditarCompromisso.SuspendLayout();
            this.gBoxAdicionarContato.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAdicionarTarefa
            // 
            this.lblAdicionarTarefa.AutoSize = true;
            this.lblAdicionarTarefa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicionarTarefa.Location = new System.Drawing.Point(251, 26);
            this.lblAdicionarTarefa.Name = "lblAdicionarTarefa";
            this.lblAdicionarTarefa.Size = new System.Drawing.Size(192, 31);
            this.lblAdicionarTarefa.TabIndex = 5;
            this.lblAdicionarTarefa.Text = "Compromisso";
            this.lblAdicionarTarefa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lBoxCompromissos
            // 
            this.lBoxCompromissos.FormattingEnabled = true;
            this.lBoxCompromissos.Location = new System.Drawing.Point(12, 88);
            this.lBoxCompromissos.Name = "lBoxCompromissos";
            this.lBoxCompromissos.Size = new System.Drawing.Size(685, 316);
            this.lBoxCompromissos.TabIndex = 6;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(622, 419);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 7;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVoltar.Location = new System.Drawing.Point(541, 419);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // gBoxEditarCompromisso
            // 
            this.gBoxEditarCompromisso.Controls.Add(this.lblIdContato);
            this.gBoxEditarCompromisso.Controls.Add(this.lblId);
            this.gBoxEditarCompromisso.Controls.Add(this.gBoxAdicionarContato);
            this.gBoxEditarCompromisso.Controls.Add(this.rBtnRemoto);
            this.gBoxEditarCompromisso.Controls.Add(this.rBtnPresencial);
            this.gBoxEditarCompromisso.Controls.Add(this.dateTPHoraConclusao);
            this.gBoxEditarCompromisso.Controls.Add(this.label1);
            this.gBoxEditarCompromisso.Controls.Add(this.dateTPHoraInicio);
            this.gBoxEditarCompromisso.Controls.Add(this.lblHoraInicio);
            this.gBoxEditarCompromisso.Controls.Add(this.dateTKDataInicio);
            this.gBoxEditarCompromisso.Controls.Add(this.lblDataCompromisso);
            this.gBoxEditarCompromisso.Controls.Add(this.lblCamposObrigatorios);
            this.gBoxEditarCompromisso.Controls.Add(this.tBoxLinkLocalizacao);
            this.gBoxEditarCompromisso.Controls.Add(this.lblLinkLocalizacao);
            this.gBoxEditarCompromisso.Controls.Add(this.btnLimpar);
            this.gBoxEditarCompromisso.Controls.Add(this.btnCancelar);
            this.gBoxEditarCompromisso.Controls.Add(this.btnSalvar);
            this.gBoxEditarCompromisso.Controls.Add(this.tBoxAssunto);
            this.gBoxEditarCompromisso.Controls.Add(this.lblAssunto);
            this.gBoxEditarCompromisso.Location = new System.Drawing.Point(12, 448);
            this.gBoxEditarCompromisso.Name = "gBoxEditarCompromisso";
            this.gBoxEditarCompromisso.Size = new System.Drawing.Size(685, 367);
            this.gBoxEditarCompromisso.TabIndex = 9;
            this.gBoxEditarCompromisso.TabStop = false;
            this.gBoxEditarCompromisso.Text = "Editar";
            // 
            // lblIdContato
            // 
            this.lblIdContato.AutoSize = true;
            this.lblIdContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdContato.Location = new System.Drawing.Point(353, 14);
            this.lblIdContato.Name = "lblIdContato";
            this.lblIdContato.Size = new System.Drawing.Size(11, 15);
            this.lblIdContato.TabIndex = 28;
            this.lblIdContato.Text = " ";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(326, 16);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.TabIndex = 27;
            this.lblId.Text = "ID:";
            // 
            // gBoxAdicionarContato
            // 
            this.gBoxAdicionarContato.Controls.Add(this.lblAdicionarContato);
            this.gBoxAdicionarContato.Controls.Add(this.lBoxContatos);
            this.gBoxAdicionarContato.Controls.Add(this.rBtnNaoPossuiContato);
            this.gBoxAdicionarContato.Controls.Add(this.rBtnPossuiContato);
            this.gBoxAdicionarContato.Location = new System.Drawing.Point(6, 173);
            this.gBoxAdicionarContato.Name = "gBoxAdicionarContato";
            this.gBoxAdicionarContato.Size = new System.Drawing.Size(673, 158);
            this.gBoxAdicionarContato.TabIndex = 26;
            this.gBoxAdicionarContato.TabStop = false;
            this.gBoxAdicionarContato.Text = "Adicionar Contato";
            // 
            // lblAdicionarContato
            // 
            this.lblAdicionarContato.AutoSize = true;
            this.lblAdicionarContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicionarContato.Location = new System.Drawing.Point(24, 45);
            this.lblAdicionarContato.Name = "lblAdicionarContato";
            this.lblAdicionarContato.Size = new System.Drawing.Size(162, 26);
            this.lblAdicionarContato.TabIndex = 3;
            this.lblAdicionarContato.Text = "Deseja vincular um contato\r\na esse compromisso?";
            this.lblAdicionarContato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lBoxContatos
            // 
            this.lBoxContatos.Enabled = false;
            this.lBoxContatos.FormattingEnabled = true;
            this.lBoxContatos.Location = new System.Drawing.Point(216, 14);
            this.lBoxContatos.Name = "lBoxContatos";
            this.lBoxContatos.Size = new System.Drawing.Size(450, 134);
            this.lBoxContatos.TabIndex = 2;
            // 
            // rBtnNaoPossuiContato
            // 
            this.rBtnNaoPossuiContato.AutoSize = true;
            this.rBtnNaoPossuiContato.Checked = true;
            this.rBtnNaoPossuiContato.Location = new System.Drawing.Point(50, 91);
            this.rBtnNaoPossuiContato.Name = "rBtnNaoPossuiContato";
            this.rBtnNaoPossuiContato.Size = new System.Drawing.Size(45, 17);
            this.rBtnNaoPossuiContato.TabIndex = 1;
            this.rBtnNaoPossuiContato.TabStop = true;
            this.rBtnNaoPossuiContato.Text = "Não";
            this.rBtnNaoPossuiContato.UseVisualStyleBackColor = true;
            // 
            // rBtnPossuiContato
            // 
            this.rBtnPossuiContato.AutoSize = true;
            this.rBtnPossuiContato.Location = new System.Drawing.Point(118, 91);
            this.rBtnPossuiContato.Name = "rBtnPossuiContato";
            this.rBtnPossuiContato.Size = new System.Drawing.Size(42, 17);
            this.rBtnPossuiContato.TabIndex = 0;
            this.rBtnPossuiContato.Text = "Sim";
            this.rBtnPossuiContato.UseVisualStyleBackColor = true;
            this.rBtnPossuiContato.CheckedChanged += new System.EventHandler(this.rBtnPossuiContato_CheckedChanged);
            // 
            // rBtnRemoto
            // 
            this.rBtnRemoto.AutoSize = true;
            this.rBtnRemoto.Location = new System.Drawing.Point(551, 89);
            this.rBtnRemoto.Name = "rBtnRemoto";
            this.rBtnRemoto.Size = new System.Drawing.Size(62, 17);
            this.rBtnRemoto.TabIndex = 22;
            this.rBtnRemoto.Text = "Remoto";
            this.rBtnRemoto.UseVisualStyleBackColor = true;
            // 
            // rBtnPresencial
            // 
            this.rBtnPresencial.AutoSize = true;
            this.rBtnPresencial.Checked = true;
            this.rBtnPresencial.Location = new System.Drawing.Point(401, 89);
            this.rBtnPresencial.Name = "rBtnPresencial";
            this.rBtnPresencial.Size = new System.Drawing.Size(74, 17);
            this.rBtnPresencial.TabIndex = 21;
            this.rBtnPresencial.TabStop = true;
            this.rBtnPresencial.Text = "Presencial";
            this.rBtnPresencial.UseVisualStyleBackColor = true;
            this.rBtnPresencial.CheckedChanged += new System.EventHandler(this.rBtnPresencial_CheckedChanged);
            // 
            // dateTPHoraConclusao
            // 
            this.dateTPHoraConclusao.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTPHoraConclusao.Location = new System.Drawing.Point(245, 89);
            this.dateTPHoraConclusao.Name = "dateTPHoraConclusao";
            this.dateTPHoraConclusao.Size = new System.Drawing.Size(92, 20);
            this.dateTPHoraConclusao.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Hora de conclusão*";
            // 
            // dateTPHoraInicio
            // 
            this.dateTPHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTPHoraInicio.Location = new System.Drawing.Point(137, 89);
            this.dateTPHoraInicio.Name = "dateTPHoraInicio";
            this.dateTPHoraInicio.Size = new System.Drawing.Size(92, 20);
            this.dateTPHoraInicio.TabIndex = 18;
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Location = new System.Drawing.Point(137, 73);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(76, 13);
            this.lblHoraInicio.TabIndex = 17;
            this.lblHoraInicio.Text = "Hora de inicio*";
            // 
            // dateTKDataInicio
            // 
            this.dateTKDataInicio.CustomFormat = "";
            this.dateTKDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTKDataInicio.Location = new System.Drawing.Point(9, 89);
            this.dateTKDataInicio.Name = "dateTKDataInicio";
            this.dateTKDataInicio.Size = new System.Drawing.Size(92, 20);
            this.dateTKDataInicio.TabIndex = 16;
            // 
            // lblDataCompromisso
            // 
            this.lblDataCompromisso.AutoSize = true;
            this.lblDataCompromisso.Location = new System.Drawing.Point(9, 73);
            this.lblDataCompromisso.Name = "lblDataCompromisso";
            this.lblDataCompromisso.Size = new System.Drawing.Size(113, 13);
            this.lblDataCompromisso.TabIndex = 12;
            this.lblDataCompromisso.Text = "Data do compromisso*";
            // 
            // lblCamposObrigatorios
            // 
            this.lblCamposObrigatorios.AutoSize = true;
            this.lblCamposObrigatorios.Location = new System.Drawing.Point(6, 347);
            this.lblCamposObrigatorios.Name = "lblCamposObrigatorios";
            this.lblCamposObrigatorios.Size = new System.Drawing.Size(129, 13);
            this.lblCamposObrigatorios.TabIndex = 11;
            this.lblCamposObrigatorios.Text = "Campos * são obrigatórios";
            // 
            // tBoxLinkLocalizacao
            // 
            this.tBoxLinkLocalizacao.Location = new System.Drawing.Point(9, 137);
            this.tBoxLinkLocalizacao.Name = "tBoxLinkLocalizacao";
            this.tBoxLinkLocalizacao.Size = new System.Drawing.Size(670, 20);
            this.tBoxLinkLocalizacao.TabIndex = 8;
            // 
            // lblLinkLocalizacao
            // 
            this.lblLinkLocalizacao.AutoSize = true;
            this.lblLinkLocalizacao.Location = new System.Drawing.Point(6, 121);
            this.lblLinkLocalizacao.Name = "lblLinkLocalizacao";
            this.lblLinkLocalizacao.Size = new System.Drawing.Size(68, 13);
            this.lblLinkLocalizacao.TabIndex = 7;
            this.lblLinkLocalizacao.Text = "Localizacao*";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(523, 337);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(442, 337);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalvar.Location = new System.Drawing.Point(604, 337);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // tBoxAssunto
            // 
            this.tBoxAssunto.Location = new System.Drawing.Point(9, 44);
            this.tBoxAssunto.Name = "tBoxAssunto";
            this.tBoxAssunto.Size = new System.Drawing.Size(670, 20);
            this.tBoxAssunto.TabIndex = 1;
            // 
            // lblAssunto
            // 
            this.lblAssunto.AutoSize = true;
            this.lblAssunto.Location = new System.Drawing.Point(9, 28);
            this.lblAssunto.Name = "lblAssunto";
            this.lblAssunto.Size = new System.Drawing.Size(49, 13);
            this.lblAssunto.TabIndex = 0;
            this.lblAssunto.Text = "Assunto*";
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(622, 419);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionar.TabIndex = 10;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // TelaVisualizarEditarCompromisso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 820);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.gBoxEditarCompromisso);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.lBoxCompromissos);
            this.Controls.Add(this.lblAdicionarTarefa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TelaVisualizarEditarCompromisso";
            this.Text = "eAgenda - Visualizar Compromisso";
            this.gBoxEditarCompromisso.ResumeLayout(false);
            this.gBoxEditarCompromisso.PerformLayout();
            this.gBoxAdicionarContato.ResumeLayout(false);
            this.gBoxAdicionarContato.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdicionarTarefa;
        private System.Windows.Forms.ListBox lBoxCompromissos;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.GroupBox gBoxEditarCompromisso;
        private System.Windows.Forms.GroupBox gBoxAdicionarContato;
        private System.Windows.Forms.Label lblAdicionarContato;
        private System.Windows.Forms.ListBox lBoxContatos;
        private System.Windows.Forms.RadioButton rBtnNaoPossuiContato;
        private System.Windows.Forms.RadioButton rBtnPossuiContato;
        private System.Windows.Forms.RadioButton rBtnRemoto;
        private System.Windows.Forms.RadioButton rBtnPresencial;
        private System.Windows.Forms.DateTimePicker dateTPHoraConclusao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTPHoraInicio;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.DateTimePicker dateTKDataInicio;
        private System.Windows.Forms.Label lblDataCompromisso;
        private System.Windows.Forms.Label lblCamposObrigatorios;
        private System.Windows.Forms.TextBox tBoxLinkLocalizacao;
        private System.Windows.Forms.Label lblLinkLocalizacao;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox tBoxAssunto;
        private System.Windows.Forms.Label lblAssunto;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblIdContato;
    }
}