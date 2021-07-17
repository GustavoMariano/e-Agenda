using eAgenda.Controladores.ContatoModule;
using eAgenda.Controladores.Shared;
using eAgenda.Dominio.ContatoModule;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace eAgenda.Forms.ContatoModule
{
    public partial class TelaExcluirContato : Form
    {
        Controlador<Contato> controlador = new ControladorContato();
        List<Contato> todosContatos;
        public TelaExcluirContato()
        {
            InitializeComponent();
            AtualizarContatos();
        }

        #region Ações dos Botões
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string strTarefaSelecionada = "";
            bool resultadoExclusao = false;
            if (lBoxContatos.SelectedItem == null)
            {
                MessageBox.Show("Nenhum contato foi selecionado, tente novamente!!");
                return;
            }
            else
            {
                string[] propContatoSelecionado;
                SelecionaContato(out strTarefaSelecionada, out propContatoSelecionado);

                resultadoExclusao = controlador.Excluir(Convert.ToInt32(propContatoSelecionado[0]));
            }

            if (resultadoExclusao)
                MessageBox.Show("Contato excluido com sucesso!!");
            else
                MessageBox.Show("Não foi possível excluir o contato selecionado, tente novamente!"); return;
        }
        #endregion

        #region Métodos Privados
        private void AtualizarContatos()
        {
            todosContatos = controlador.SelecionarTodos();

            foreach (var item in todosContatos)
                lBoxContatos.Items.Add(item.ToString());
        }
        private void SelecionaContato(out string strTarefaSelecionada, out string[] propContatoSelecionado)
        {
            strTarefaSelecionada = lBoxContatos.SelectedItem.ToString().Replace("   ", "");
            propContatoSelecionado = strTarefaSelecionada.Split('-');
        }
        #endregion                
    }
}
