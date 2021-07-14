using eAgenda.Controladores.Shared;
using eAgenda.Controladores.TarefaModule;
using eAgenda.Dominio.TarefaModule;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace eAgenda.Forms.TarefaModule
{
    public partial class TelaVisualizarTarefa : Form
    {
        Controlador<Tarefa> controlador = new ControladorTarefa();
        List<Tarefa> listaTarefas = new List<Tarefa>();
        public string  tarefaSelecionada { get { return Convert.ToString(lBoxTarefasPendentes.SelectedItem); } set { } }
        public TelaVisualizarTarefa(bool editavel = false)
        {
            InitializeComponent();

            AtualizarRegistros();
            if (editavel == true)
            {
                this.Height = 800;
                btnSelecionarTarefa.Visible = true;
                btnAtualizar.Visible = false;
            }
            else
            {
                this.Height = 520;
                btnAtualizar.Visible = true;
                btnSelecionarTarefa.Visible = false;
            }
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarRegistros();
        }
        #region Métodos Privados
        private void AtualizarRegistros()
        {
            lBoxTarefasPendentes.Items.Clear();
            lBoxTarefasConcluidas.Items.Clear();
            listaTarefas = controlador.SelecionarTodos();
            foreach (var item in listaTarefas)
            {
                if (item.DataConclusao == DateTime.MinValue || item.DataConclusao == null)
                    lBoxTarefasPendentes.Items.Add(item.Id + "   ||   " + item.Titulo + "   -   " + item.Prioridade + "   -   " + item.Percentual + "   -   " + item.DataCriacao);
                else
                    lBoxTarefasConcluidas.Items.Add(item.Id + "   ||   " + item.Titulo + "   -   " + item.Prioridade + "   -   " + item.Percentual + "   -   " + item.DataCriacao + "   -   " + item.DataConclusao);
            }
        }
        #endregion
    }
}
