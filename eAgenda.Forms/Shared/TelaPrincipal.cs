using eAgenda.Forms.CompromissoModule;
using eAgenda.Forms.ContatoModule;
using eAgenda.Forms.TarefaModule;
using System;
using System.Windows.Forms;

namespace eAgenda.Forms.Shared
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        #region Tarefa
        private void btnAdicionarTarefa_Click(object sender, EventArgs e)
        {
            TelaAdicionarTarefa tela = new TelaAdicionarTarefa();
            tela.Visible = true;
        }
        private void btnVisualizarTarefa_Click(object sender, EventArgs e)
        {
            TelaVisualizarEditarTarefa tela = new TelaVisualizarEditarTarefa();
            tela.ShowDialog();
        }
        private void btnEditarTarefa_Click(object sender, EventArgs e)
        {
            TelaVisualizarEditarTarefa tela = new TelaVisualizarEditarTarefa(true);
            tela.ShowDialog();
        }
        private void btnExcluirTarefa_Click(object sender, EventArgs e)
        {
            TelaExcluirTarefa tela = new TelaExcluirTarefa();
            tela.ShowDialog();
        }
        #endregion

        #region Contato
        private void btnAdicionarContato_Click(object sender, EventArgs e)
        {
            TelaAdicionarContato tela = new TelaAdicionarContato();
            tela.Visible = true;
        }
        private void btnVisualizarContato_Click(object sender, EventArgs e)
        {
            TelaSelecionarVisualizacaoContato tela = new TelaSelecionarVisualizacaoContato();
            tela.ShowDialog();
        }
        private void btnEditarContato_Click(object sender, EventArgs e)
        {
            TelaSelecionarVisualizacaoContato tela = new TelaSelecionarVisualizacaoContato(true);
            tela.ShowDialog();
        }
        private void btnExcluirContato_Click(object sender, EventArgs e)
        {
            TelaExcluirContato tela = new TelaExcluirContato();
            tela.ShowDialog();
        }
        #endregion

        #region Compromisso
        private void btnAdicionarCompromisso_Click(object sender, EventArgs e)
        {
            TelaAdicionarCompromisso tela = new TelaAdicionarCompromisso();
            tela.ShowDialog();
        }
        private void btnVisualizarCompromisso_Click(object sender, EventArgs e)
        {
            TelaSelecionarVisualizacaoCompromisso tela = new TelaSelecionarVisualizacaoCompromisso();
            tela.ShowDialog();
        }
        private void btnEditarCompromisso_Click(object sender, EventArgs e)
        {
            TelaSelecionarVisualizacaoCompromisso tela = new TelaSelecionarVisualizacaoCompromisso(true);
            tela.ShowDialog();
        }
        private void btnExcluirCompromisso_Click(object sender, EventArgs e)
        {
            TelaExcluirCompromisso tela = new TelaExcluirCompromisso();
            tela.ShowDialog();
        }
        #endregion
    }
}
