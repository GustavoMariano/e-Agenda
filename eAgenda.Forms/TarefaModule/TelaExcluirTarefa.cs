using eAgenda.Controladores.Shared;
using eAgenda.Controladores.TarefaModule;
using eAgenda.Dominio.TarefaModule;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace eAgenda.Forms.TarefaModule
{
    public partial class TelaExcluirTarefa : Form
    {
        Controlador<Tarefa> controlador = new ControladorTarefa();
        List<Tarefa> listaTarefas = new List<Tarefa>();
        public TelaExcluirTarefa()
        {
            InitializeComponent();
            AtualizarRegistros();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            string strTarefaSelecionada = "";
            if (tabTarefas.SelectedIndex == 0)
            {
                if (lBoxTarefasPendentes.SelectedItem == null)
                {
                    MessageBox.Show("Nenhuma tarefa foi selecionada, tente novamente!!");
                    return;
                }
                else 
                    strTarefaSelecionada = lBoxTarefasPendentes.SelectedItem.ToString().Replace("   ", "");
            }
            else
            {
                if (lBoxTarefasConcluidas.SelectedItem == null)
                {
                    MessageBox.Show("Nenhuma tarefa foi selecionada, tente novamente!!");
                    return;
                }
                strTarefaSelecionada = lBoxTarefasConcluidas.SelectedItem.ToString().Replace("   ", "");
            }
            string[] propTarefaSelecionada = strTarefaSelecionada.Split('-');

            bool resultadoExclusao = controlador.Excluir(Convert.ToInt32(propTarefaSelecionada[0]));

            if (resultadoExclusao)
                MessageBox.Show("Tarefa excluida com sucesso!!");
            else
                MessageBox.Show("Não foi possível excluir a tarefa selecionada, tente novamente!"); return;
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarRegistros();
        }

        #region Métodos privados
        private void AtualizarRegistros()
        {
            lBoxTarefasPendentes.Items.Clear();
            lBoxTarefasConcluidas.Items.Clear();
            listaTarefas = controlador.SelecionarTodos();
            foreach (var item in listaTarefas)
            {
                if (item.DataConclusao == DateTime.MinValue || item.DataConclusao == null)
                    lBoxTarefasPendentes.Items.Add(item.ToString());
                else
                    lBoxTarefasConcluidas.Items.Add(item.ToString());
            }
        }
        #endregion
    }
}
