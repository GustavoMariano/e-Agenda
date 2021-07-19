using System;
using System.Windows.Forms;

namespace eAgenda.Forms.CompromissoModule
{
    public partial class TelaSelecionarVisualizacaoCompromisso : Form
    {
        bool editar = true;
        TelaVisualizarEditarCompromisso tela;
        public TelaSelecionarVisualizacaoCompromisso(bool editar = false)
        {
            InitializeComponent();
            dateTPFinal.Value = DateTime.Now.AddDays(7);
            if (editar == true)
                Text = "eAgenda - Editar Compromisso";
            this.editar = editar;

            dateTPInicio.CustomFormat = "yyyy/MM/dd";
            dateTPInicio.Format = DateTimePickerFormat.Custom;
            dateTPFinal.CustomFormat = "yyyy/MM/dd";
            dateTPFinal.Format = DateTimePickerFormat.Custom;
        }

        private void btnVisualizarFuturos_Click(object sender, EventArgs e)
        {
            DateTime dataIncialPesquisa = new DateTime(dateTPInicio.Value.Year, dateTPInicio.Value.Month, dateTPInicio.Value.Day);
            DateTime dataFinalPesquisa = new DateTime(dateTPFinal.Value.Year, dateTPFinal.Value.Month, dateTPFinal.Value.Day);
            if (editar)
                tela = new TelaVisualizarEditarCompromisso(true, dataIncialPesquisa, dataFinalPesquisa);
            else
                tela = new TelaVisualizarEditarCompromisso(false, dataIncialPesquisa, dataFinalPesquisa);
            tela.ShowDialog();
        }

        private void btnVisualizarTodos_Click(object sender, EventArgs e)
        {
            if (editar)
                tela = new TelaVisualizarEditarCompromisso(true);
            else
                tela = new TelaVisualizarEditarCompromisso();
            tela.ShowDialog();
        }

        private void btnVisualizarPassados_Click(object sender, EventArgs e)
        {
            if (editar)
                tela = new TelaVisualizarEditarCompromisso(true, DateTime.Now);
            else
                tela = new TelaVisualizarEditarCompromisso(false, DateTime.Now);
            tela.ShowDialog();
        }
    }
}
