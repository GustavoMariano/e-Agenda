using eAgenda.Controladores.CompromissoModule;
using eAgenda.Controladores.Shared;
using eAgenda.Dominio.CompromissoModule;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace eAgenda.Forms.CompromissoModule
{
    public partial class TelaExcluirCompromisso : Form
    {
        List<Compromisso> compromissosBanco;
        Controlador<Compromisso> controlador = new ControladorCompromisso();
        public TelaExcluirCompromisso()
        {
            InitializeComponent();
            MostrarCompromisso();
        }

        #region Ações dos Botões
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string strCompromissoSelecionado = "";
            bool resultadoExclusao = false;
            if (lBoxCompromissos.SelectedItem == null)
            {
                MessageBox.Show("Nenhum compromisso foi selecionado, tente novamente!!");
                return;
            }
            else
            {
                string[] propCompromissoSelecionado;
                SelecionaCompromisso(out strCompromissoSelecionado, out propCompromissoSelecionado);
                resultadoExclusao = controlador.Excluir(Convert.ToInt32(propCompromissoSelecionado[0]));
            }
            if (resultadoExclusao)
                MessageBox.Show("Compromisso excluido com sucesso!!");
            else
                MessageBox.Show("Não foi possível excluir o compromisso selecionado, tente novamente!"); return;
        }        
        #endregion

        #region Méttodos Privados
        private void MostrarCompromisso()
        {
            compromissosBanco = controlador.SelecionarTodos();

            foreach (var item in compromissosBanco)
                lBoxCompromissos.Items.Add(item.ToString());
        }
        private void SelecionaCompromisso(out string strCompromissoSelecionado, out string[] propCompromissoSelecionado)
        {
            strCompromissoSelecionado = lBoxCompromissos.SelectedItem.ToString().Replace("   ", "");
            propCompromissoSelecionado = strCompromissoSelecionado.Split('-');
        }
        #endregion        
    }
}
