
namespace eAgenda.Forms.ContatoModule
{
    partial class TelaExcluirContato
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
            this.lBoxContatos = new System.Windows.Forms.ListBox();
            this.lblVisualizarContato = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lBoxContatos
            // 
            this.lBoxContatos.FormattingEnabled = true;
            this.lBoxContatos.Location = new System.Drawing.Point(12, 82);
            this.lBoxContatos.Name = "lBoxContatos";
            this.lBoxContatos.Size = new System.Drawing.Size(588, 355);
            this.lBoxContatos.TabIndex = 1;
            // 
            // lblVisualizarContato
            // 
            this.lblVisualizarContato.AutoSize = true;
            this.lblVisualizarContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisualizarContato.Location = new System.Drawing.Point(240, 26);
            this.lblVisualizarContato.Name = "lblVisualizarContato";
            this.lblVisualizarContato.Size = new System.Drawing.Size(117, 31);
            this.lblVisualizarContato.TabIndex = 5;
            this.lblVisualizarContato.Text = "Contato";
            this.lblVisualizarContato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExcluir
            // 
            this.btnExcluir.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnExcluir.Location = new System.Drawing.Point(522, 443);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVoltar.Location = new System.Drawing.Point(441, 443);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 10;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(522, 443);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 9;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // TelaExcluirContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 489);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.lblVisualizarContato);
            this.Controls.Add(this.lBoxContatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TelaExcluirContato";
            this.Text = "eAgenda - Deletar Contato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lBoxContatos;
        private System.Windows.Forms.Label lblVisualizarContato;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAtualizar;
    }
}