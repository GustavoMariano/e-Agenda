using eAgenda.Controladores.Shared;
using eAgenda.Controladores.TarefaModule;
using eAgenda.Dominio.TarefaModule;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace eAgenda.Forms.TarefaModule
{
    public partial class TelaVisualizarEditarTarefa : Form
    {
        Controlador<Tarefa> controlador = new ControladorTarefa();
        List<Tarefa> listaTarefas = new List<Tarefa>();
        public TelaVisualizarEditarTarefa(bool editavel = false)
        {
            InitializeComponent();

            AtualizarRegistros();
            ConfiguraTela(editavel);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarRegistros();
        }

        string[] propTarefaSelecionada;
        int prioridade = 0;
        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            string strTarefaSelecionada = "";
            if (tabTarefas.SelectedIndex == 0)
                strTarefaSelecionada = lBoxTarefasPendentes.SelectedItem.ToString().Replace("   ", "");
            else
                strTarefaSelecionada = lBoxTarefasConcluidas.SelectedItem.ToString().Replace("   ", "");

            if (strTarefaSelecionada.Length > 0)
            {
                propTarefaSelecionada = strTarefaSelecionada.Split('-');
                switch (propTarefaSelecionada[2])
                {
                    case "Prioridade Alta": prioridade = 2; break;
                    case "Prioridade Normal": prioridade = 1; break;
                    case "Prioridade Baixa": prioridade = 0; break;
                }
                CarregaGBoxComTarefa(propTarefaSelecionada, prioridade);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (lblIdTarefa.Text == " ")
                MessageBox.Show("Nenhuma tarefa foi selecionada, tente novamente!!");
            else
            {
                Tarefa tarefa = new Tarefa(tBoxTitulo.Text, DateTime.Now, (PrioridadeEnum)cBoxPrioridade.SelectedIndex, Convert.ToInt32(numUpDownPercentual.Value));
                string resultadoEdicao = controlador.Editar(Convert.ToInt32(lblIdTarefa.Text), tarefa);
                if (resultadoEdicao == "ESTA_VALIDO")
                    MessageBox.Show("Tarefa atualizada com sucesso!!");
                else
                    MessageBox.Show(resultadoEdicao);
            }
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
                    lBoxTarefasPendentes.Items.Add(item.ToString());
                else
                    lBoxTarefasConcluidas.Items.Add(item.ToString());
            }
        }
        private void ConfiguraTela(bool editavel)
        {
            if (editavel == true)
            {
                btnAtualizar.Visible = false;
                btnSelecionar.Visible = true;
                Height = 751;
                btnVoltar.Location = new Point(431, 682);
            }
            else
            {
                btnAtualizar.Visible = true;
                btnSelecionar.Visible = false;
                Height = 520;
                btnVoltar.Location = new Point(431, 455);
            }
        }
        private void CarregaGBoxComTarefa(string[] propTarefaSelecionada, int prioridade)
        {
            gBoxEditar.Enabled = true;
            lblIdTarefa.Text = propTarefaSelecionada[0];
            tBoxTitulo.Text = propTarefaSelecionada[1];
            lblDataCriacao.Text = "Data de criação: " + propTarefaSelecionada[3];
            if (propTarefaSelecionada[5].Length != 0)
                lblDataConclusao.Text = "Data de conclusão: " + propTarefaSelecionada[5];
            cBoxPrioridade.SelectedIndex = prioridade;
            numUpDownPercentual.Value = Convert.ToInt32(propTarefaSelecionada[4]);
        }
        #endregion       
    }
}
