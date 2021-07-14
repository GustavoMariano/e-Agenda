using eAgenda.Controladores.Shared;
using eAgenda.Controladores.TarefaModule;
using eAgenda.Dominio.TarefaModule;
using System;
using System.Windows.Forms;

namespace eAgenda.Forms.TarefaModule
{
    public partial class TelaAdicionarTarefa : Form
    {
        Tarefa tarefa;
        Controlador<Tarefa> controlador = new ControladorTarefa();
        public TelaAdicionarTarefa()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tBoxTitulo.Text = "";
            cBoxPrioridade.SelectedItem = null;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            tarefa = new Tarefa(tBoxTitulo.Text, DateTime.Now.Date, (PrioridadeEnum)cBoxPrioridade.SelectedIndex);

            string resultadoValidacao = controlador.InserirNovo(tarefa);
            if (resultadoValidacao == "ESTA_VALIDO")
            {
                MessageBox.Show("Tarefa inserida com sucesso");
                Dispose();
            }
            else
                MessageBox.Show(resultadoValidacao);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tBoxTitulo.Text = "";
            cBoxPrioridade.SelectedItem = null;
            Dispose();
        }
    }
}
