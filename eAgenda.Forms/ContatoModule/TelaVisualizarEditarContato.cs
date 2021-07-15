using eAgenda.Controladores.ContatoModule;
using eAgenda.Controladores.Shared;
using eAgenda.Dominio.ContatoModule;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace eAgenda.Forms.ContatoModule
{
    public partial class TelaVisualizarEditarContato : Form
    {
        Controlador<Contato> controlador = new ControladorContato();
        List<Contato> todosContatos;
        public TelaVisualizarEditarContato(string cargo = "", bool editavel = false)
        {
            InitializeComponent();
            AtualizarContatos(cargo);
            ConfiguraTela(editavel);
        }
        string[] propContatoSelecionado;
        private void btnSelecionar_Click(object sender, System.EventArgs e)
        {
            string strContatoSelecionado = "";

            strContatoSelecionado = lBoxContatos.SelectedItem.ToString().Replace("   ", "");

            if (strContatoSelecionado.Length > 0)
            {
                propContatoSelecionado = strContatoSelecionado.Split('-');
                CarregaGBoxComTarefa(propContatoSelecionado);
            }            
        }

        private void btnSalvar_Click(object sender, System.EventArgs e)
        {
            if (lblIdContato.Text == " ")
                MessageBox.Show("Nenhuma tarefa foi selecionada, tente novamente!!");
            else
            {
                Contato contato = new Contato(tBoxNome.Text, tBoxEmail.Text, mskTBoxTelefone.Text, tBoxEmpresa.Text, tBoxCargo.Text);
                string resultadoEdicao = controlador.Editar(Convert.ToInt32(lblIdContato.Text), contato);
                if (resultadoEdicao == "ESTA_VALIDO")
                    MessageBox.Show("Tarefa atualizada com sucesso!!");
                else
                    MessageBox.Show(resultadoEdicao);
            }
        }

        #region Métodos Privados
        private void ConfiguraTela(bool editavel)
        {
            if (editavel == true)
            {
                Text = "eAgenda - Editar Contato";
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
                btnVoltar.Location = new Point(441, 443);
            }
        }
        private void AtualizarContatos(string cargo)
        {
            todosContatos = controlador.SelecionarTodos();
            if (cargo.Length > 0)
            {
                foreach (var item in todosContatos)
                {
                    if (item.Cargo == cargo)
                        lBoxContatos.Items.Add(item.ToString());
                }
            }
            else
            {
                foreach (var item in todosContatos)
                {
                    lBoxContatos.Items.Add(item.ToString());
                }
            }
        }
        private void CarregaGBoxComTarefa(string[] propTarefaSelecionada)
        {
            gBoxEditar.Enabled = true;
            lblIdContato.Text = propTarefaSelecionada[0];
            tBoxNome.Text = propTarefaSelecionada[1];
            tBoxEmail.Text = propTarefaSelecionada[2];
            mskTBoxTelefone.Text = propTarefaSelecionada[3] + propTarefaSelecionada[4];
            tBoxCargo.Text = propTarefaSelecionada[5];
            tBoxEmpresa.Text = propContatoSelecionado[6];
        }
        #endregion        
    }
}
