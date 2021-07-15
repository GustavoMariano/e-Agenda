using eAgenda.Controladores.ContatoModule;
using eAgenda.Controladores.Shared;
using eAgenda.Dominio.ContatoModule;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace eAgenda.Forms.ContatoModule
{
    public partial class TelaSelecionarVisualizacaoContato : Form
    {
        Controlador<Contato> controlador = new ControladorContato();
        ControladorContato controladorContato = new ControladorContato();
        TelaVisualizarEditarContato tela;
        bool editavel = false;
        public TelaSelecionarVisualizacaoContato(bool editar = false)
        {
            InitializeComponent();
            editavel = editar;
            List<Contato> todosContatos = controlador.SelecionarTodos();
            foreach (var item in todosContatos)
            {
                if (!cBoxCargos.Items.Contains(item.Cargo))
                    cBoxCargos.Items.Add(item.Cargo);
            }
            controladorContato.SelecionarContatosAgrupados(c => c.Cargo);
        }

        private void btnVisualizarSelecionado_Click(object sender, EventArgs e)
        {            
            if (String.IsNullOrEmpty(cBoxCargos.Text))
                MessageBox.Show("Não foi selecionado nenhum cargo, tente novamente!!");
            else
            {
                if (editavel)
                    tela = new TelaVisualizarEditarContato(cBoxCargos.Text, editavel);
                else
                    tela = new TelaVisualizarEditarContato(cBoxCargos.Text);
                tela.ShowDialog();
            }
        }

        private void btnVisualizarTodos_Click(object sender, EventArgs e)
        {
            if(editavel)
                tela = new TelaVisualizarEditarContato("",editavel);
            else
                tela = new TelaVisualizarEditarContato();
            tela.ShowDialog();
        }
    }
}
