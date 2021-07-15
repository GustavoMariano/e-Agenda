
namespace eAgenda.Forms.ContatoModule
{
    partial class TelaSelecionarVisualizacaoContato
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
            this.btnVisualizarTodos = new System.Windows.Forms.Button();
            this.lblCargo = new System.Windows.Forms.Label();
            this.cBoxCargos = new System.Windows.Forms.ComboBox();
            this.lblAdicionarContato = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnVisualizarSelecionado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVisualizarTodos
            // 
            this.btnVisualizarTodos.Location = new System.Drawing.Point(160, 175);
            this.btnVisualizarTodos.Name = "btnVisualizarTodos";
            this.btnVisualizarTodos.Size = new System.Drawing.Size(95, 23);
            this.btnVisualizarTodos.TabIndex = 0;
            this.btnVisualizarTodos.Text = "Visualizar Todos";
            this.btnVisualizarTodos.UseVisualStyleBackColor = true;
            this.btnVisualizarTodos.Click += new System.EventHandler(this.btnVisualizarTodos_Click);
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(48, 71);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(194, 13);
            this.lblCargo.TabIndex = 2;
            this.lblCargo.Text = "Selecione o cargo que deseja visualizar";
            // 
            // cBoxCargos
            // 
            this.cBoxCargos.FormattingEnabled = true;
            this.cBoxCargos.Location = new System.Drawing.Point(67, 90);
            this.cBoxCargos.Name = "cBoxCargos";
            this.cBoxCargos.Size = new System.Drawing.Size(157, 21);
            this.cBoxCargos.TabIndex = 3;
            // 
            // lblAdicionarContato
            // 
            this.lblAdicionarContato.AutoSize = true;
            this.lblAdicionarContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicionarContato.Location = new System.Drawing.Point(87, 26);
            this.lblAdicionarContato.Name = "lblAdicionarContato";
            this.lblAdicionarContato.Size = new System.Drawing.Size(117, 31);
            this.lblAdicionarContato.TabIndex = 4;
            this.lblAdicionarContato.Text = "Contato";
            this.lblAdicionarContato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVoltar
            // 
            this.btnVoltar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVoltar.Location = new System.Drawing.Point(41, 175);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnVisualizarSelecionado
            // 
            this.btnVisualizarSelecionado.Location = new System.Drawing.Point(79, 126);
            this.btnVisualizarSelecionado.Name = "btnVisualizarSelecionado";
            this.btnVisualizarSelecionado.Size = new System.Drawing.Size(133, 23);
            this.btnVisualizarSelecionado.TabIndex = 1;
            this.btnVisualizarSelecionado.Text = "Visualizar Selecionado";
            this.btnVisualizarSelecionado.UseVisualStyleBackColor = true;
            this.btnVisualizarSelecionado.Click += new System.EventHandler(this.btnVisualizarSelecionado_Click);
            // 
            // TelaSelecionarVisulizacaoContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 218);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblAdicionarContato);
            this.Controls.Add(this.cBoxCargos);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.btnVisualizarSelecionado);
            this.Controls.Add(this.btnVisualizarTodos);
            this.Name = "TelaSelecionarVisulizacaoContato";
            this.Text = "eAgenda - Visualizar Contato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVisualizarTodos;
        private System.Windows.Forms.Button btnVisualizarSelecionado;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.ComboBox cBoxCargos;
        private System.Windows.Forms.Label lblAdicionarContato;
        private System.Windows.Forms.Button btnVoltar;
    }
}