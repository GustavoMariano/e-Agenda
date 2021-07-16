
namespace eAgenda.Forms.CompromissoModule
{
    partial class TelaSelecionarVisualizacaoCompromisso
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
            this.btnVisualizarFuturos = new System.Windows.Forms.Button();
            this.btnVisualizarTodos = new System.Windows.Forms.Button();
            this.btnVisualizarPassados = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.dateTPFinal = new System.Windows.Forms.DateTimePicker();
            this.dateTPInicio = new System.Windows.Forms.DateTimePicker();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.lblDataFinal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAdicionarTarefa
            // 
            this.lblAdicionarTarefa.AutoSize = true;
            this.lblAdicionarTarefa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicionarTarefa.Location = new System.Drawing.Point(175, 26);
            this.lblAdicionarTarefa.Name = "lblAdicionarTarefa";
            this.lblAdicionarTarefa.Size = new System.Drawing.Size(192, 31);
            this.lblAdicionarTarefa.TabIndex = 6;
            this.lblAdicionarTarefa.Text = "Compromisso";
            this.lblAdicionarTarefa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVisualizarFuturos
            // 
            this.btnVisualizarFuturos.Location = new System.Drawing.Point(336, 116);
            this.btnVisualizarFuturos.Name = "btnVisualizarFuturos";
            this.btnVisualizarFuturos.Size = new System.Drawing.Size(117, 27);
            this.btnVisualizarFuturos.TabIndex = 7;
            this.btnVisualizarFuturos.Text = "Visualizar Futuros";
            this.btnVisualizarFuturos.UseVisualStyleBackColor = true;
            this.btnVisualizarFuturos.Click += new System.EventHandler(this.btnVisualizarFuturos_Click);
            // 
            // btnVisualizarTodos
            // 
            this.btnVisualizarTodos.Location = new System.Drawing.Point(336, 201);
            this.btnVisualizarTodos.Name = "btnVisualizarTodos";
            this.btnVisualizarTodos.Size = new System.Drawing.Size(117, 23);
            this.btnVisualizarTodos.TabIndex = 8;
            this.btnVisualizarTodos.Text = "VisualizarTodos";
            this.btnVisualizarTodos.UseVisualStyleBackColor = true;
            this.btnVisualizarTodos.Click += new System.EventHandler(this.btnVisualizarTodos_Click);
            // 
            // btnVisualizarPassados
            // 
            this.btnVisualizarPassados.Location = new System.Drawing.Point(213, 201);
            this.btnVisualizarPassados.Name = "btnVisualizarPassados";
            this.btnVisualizarPassados.Size = new System.Drawing.Size(117, 23);
            this.btnVisualizarPassados.TabIndex = 9;
            this.btnVisualizarPassados.Text = "Visualizar Passados";
            this.btnVisualizarPassados.UseVisualStyleBackColor = true;
            this.btnVisualizarPassados.Click += new System.EventHandler(this.btnVisualizarPassados_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVoltar.Location = new System.Drawing.Point(90, 201);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(117, 23);
            this.btnVoltar.TabIndex = 10;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // dateTPFinal
            // 
            this.dateTPFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTPFinal.Location = new System.Drawing.Point(229, 140);
            this.dateTPFinal.Name = "dateTPFinal";
            this.dateTPFinal.Size = new System.Drawing.Size(90, 20);
            this.dateTPFinal.TabIndex = 11;
            // 
            // dateTPInicio
            // 
            this.dateTPInicio.CustomFormat = "";
            this.dateTPInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTPInicio.Location = new System.Drawing.Point(229, 99);
            this.dateTPInicio.Name = "dateTPInicio";
            this.dateTPInicio.Size = new System.Drawing.Size(90, 20);
            this.dateTPInicio.TabIndex = 12;
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Location = new System.Drawing.Point(87, 105);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(119, 13);
            this.lblDataInicio.TabIndex = 13;
            this.lblDataInicio.Text = "Selecione a Data Inicial";
            // 
            // lblDataFinal
            // 
            this.lblDataFinal.AutoSize = true;
            this.lblDataFinal.Location = new System.Drawing.Point(87, 146);
            this.lblDataFinal.Name = "lblDataFinal";
            this.lblDataFinal.Size = new System.Drawing.Size(114, 13);
            this.lblDataFinal.TabIndex = 14;
            this.lblDataFinal.Text = "Selecione a Data Final";
            // 
            // TelaSelecionarVisualizacaoCompromisso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 268);
            this.Controls.Add(this.lblDataFinal);
            this.Controls.Add(this.lblDataInicio);
            this.Controls.Add(this.dateTPInicio);
            this.Controls.Add(this.dateTPFinal);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnVisualizarPassados);
            this.Controls.Add(this.btnVisualizarTodos);
            this.Controls.Add(this.btnVisualizarFuturos);
            this.Controls.Add(this.lblAdicionarTarefa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TelaSelecionarVisualizacaoCompromisso";
            this.Text = "eAgenda - Visualizar Compromisso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdicionarTarefa;
        private System.Windows.Forms.Button btnVisualizarFuturos;
        private System.Windows.Forms.Button btnVisualizarTodos;
        private System.Windows.Forms.Button btnVisualizarPassados;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DateTimePicker dateTPFinal;
        private System.Windows.Forms.DateTimePicker dateTPInicio;
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.Label lblDataFinal;
    }
}