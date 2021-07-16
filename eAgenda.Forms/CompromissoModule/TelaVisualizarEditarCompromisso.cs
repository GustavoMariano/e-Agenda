using eAgenda.Controladores.CompromissoModule;
using eAgenda.Controladores.Shared;
using eAgenda.Dominio.CompromissoModule;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace eAgenda.Forms.CompromissoModule
{
    public partial class TelaVisualizarEditarCompromisso : Form
    {
        Controlador<Compromisso> controlador = new ControladorCompromisso();
        ControladorCompromisso controladorCompromisso = new ControladorCompromisso();
        List<Compromisso> compromissosBanco;
        DateTime? dataInicial;
        DateTime? dataFinal;
        public TelaVisualizarEditarCompromisso(bool editar = false, DateTime? dataInicial = null, DateTime? dataFinal = null)
        {
            InitializeComponent();
            this.dataInicial = dataInicial;
            this.dataFinal = dataFinal;
            if (editar == true)
            {
                btnVoltar.Visible = false;
                Text = "eAgenda - Editar Compromisso";
                Height = 859;
            }
            else
            {
                btnVoltar.Location = new Point (541, 419);
                Text = "eAgenda - Visualizar Compromisso";
                Height = 493;
            }

            MostrarContatos(dataInicial, dataFinal);
        }        

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            MostrarContatos(dataInicial, dataFinal);
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tBoxAssunto.Text = "";
            tBoxLinkLocalizacao.Text = "";
            dataInicio.Value = DateTime.Now;
            dateTPHoraInicio.Value = DateTime.Now;
            dateTPHoraConclusao.Value = DateTime.Now;
        }

        #region Métodos Privados
        private void MostrarContatos(DateTime? dataInicial, DateTime? dataFinal)
        {
            if (dataInicial == null && dataFinal == null)
                compromissosBanco = controladorCompromisso.SelecionarTodos();
            else if (dataInicial != null && dataFinal == null)
                compromissosBanco = controladorCompromisso.SelecionarCompromissosPassados(Convert.ToDateTime(dataInicial));
            else
                compromissosBanco = controladorCompromisso.SelecionarCompromissosFuturos(dataInicial, dataFinal);

            foreach (var item in compromissosBanco)
            {
                lBoxCompromissos.Items.Add(item.ToString());
            }
        }
        #endregion        
    }
}
