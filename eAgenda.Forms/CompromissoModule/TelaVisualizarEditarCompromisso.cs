using eAgenda.Controladores.CompromissoModule;
using eAgenda.Controladores.ContatoModule;
using eAgenda.Controladores.Shared;
using eAgenda.Dominio.CompromissoModule;
using eAgenda.Dominio.ContatoModule;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace eAgenda.Forms.CompromissoModule
{
    public partial class TelaVisualizarEditarCompromisso : Form
    {
        Controlador<Compromisso> controlador = new ControladorCompromisso();
        Controlador<Contato> controladorContato = new ControladorContato();
        ControladorCompromisso controladorCompromisso = new ControladorCompromisso();
        List<Compromisso> compromissosBanco;
        List<Contato> contatosBanco;
        Compromisso compromisso;
        Contato contato;
        DateTime? dataInicial;
        DateTime? dataFinal;
        string[] propriedadesCompromissoSelecionado;
        public TelaVisualizarEditarCompromisso(bool editar = false, DateTime? dataInicial = null, DateTime? dataFinal = null)
        {
            InitializeComponent();
            gBoxEditarCompromisso.Enabled = false;
            this.dataInicial = dataInicial;
            this.dataFinal = dataFinal;

            ConfiguraTela(editar);
            MostrarCompromisso(dataInicial, dataFinal);
        }

        #region Ações dos Botões
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            MostrarCompromisso(dataInicial, dataFinal);
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tBoxAssunto.Text = "";
            tBoxLinkLocalizacao.Text = "";
            dateTKDataInicio.Value = DateTime.Now;
            dateTPHoraInicio.Value = DateTime.Now;
            dateTPHoraConclusao.Value = DateTime.Now;
        }
        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (lBoxCompromissos.SelectedItem == null)
                MessageBox.Show("Nenhum compromisso foi selecionado, tente novamente!!");
            else
                ConfiguraGBoxEdicao();
        }        
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string resultadoInserção = "";
            string link = "";
            string localizacao = "";

            if (rBtnPresencial.Checked == true)
                localizacao = tBoxLinkLocalizacao.Text;
            else
                link = tBoxLinkLocalizacao.Text;

            if (rBtnNaoPossuiContato.Checked == true)
            {
                compromisso = new Compromisso(tBoxAssunto.Text, localizacao, link, dateTKDataInicio.Value, dateTPHoraInicio.Value.TimeOfDay, dateTPHoraConclusao.Value.TimeOfDay, null);
                resultadoInserção = controlador.Editar(Convert.ToInt32(lblIdContato.Text), compromisso);
            }
            else
            {
                SelecionaContato();
                compromisso = new Compromisso(tBoxAssunto.Text, localizacao, link, dateTKDataInicio.Value, dateTPHoraInicio.Value.TimeOfDay, dateTPHoraConclusao.Value.TimeOfDay, contato);
                resultadoInserção = controlador.Editar(Convert.ToInt32(lblIdContato.Text), compromisso);
            }

            if (resultadoInserção == "ESTA_VALIDO")
                MessageBox.Show("Compromisso adicionado com sucesso!!");
            else
                MessageBox.Show(resultadoInserção);
        }
        private void rBtnPresencial_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnPresencial.Checked == true)
                lblLinkLocalizacao.Text = "Localização*";
            else
                lblLinkLocalizacao.Text = "Link*";
        }
        private void rBtnPossuiContato_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnPossuiContato.Checked == true)
                lBoxContatos.Enabled = true;
            else
                lBoxContatos.Enabled = false;
        }
        #endregion

        #region Métodos Privados
        private void ConfiguraTela(bool editar)
        {
            if (editar == true)
            {
                btnAtualizar.Enabled = false;
                btnSalvar.Enabled = false;
                btnSelecionar.Visible = true;
                Text = "eAgenda - Editar Compromisso";
                Height = 859;
                MostrarContato();
            }
            else
            {
                btnSelecionar.Visible = false;
                btnVoltar.Location = new Point(541, 419);
                Text = "eAgenda - Visualizar Compromisso";
                Height = 493;
            }
        }
        private void ConfiguraGBoxEdicao()
        {
            gBoxEditarCompromisso.Enabled = true;
            btnSalvar.Enabled = true;
            string compromissoSelecionado = lBoxCompromissos.SelectedItem.ToString().Replace("   ", "");
            propriedadesCompromissoSelecionado = compromissoSelecionado.Split('-');
            lblIdContato.Text = propriedadesCompromissoSelecionado[0];
            tBoxAssunto.Text = propriedadesCompromissoSelecionado[1];
            ConfiguraBotoesPresencialRemoto();
            ConfiguraBotoesComSemContato();
            dateTKDataInicio.Value = Convert.ToDateTime(propriedadesCompromissoSelecionado[5]);
            dateTPHoraInicio.Value = Convert.ToDateTime(propriedadesCompromissoSelecionado[6]);
            dateTPHoraConclusao.Value = Convert.ToDateTime(propriedadesCompromissoSelecionado[7]);
        }
        private void MostrarCompromisso(DateTime? dataInicial, DateTime? dataFinal)
        {
            if (dataInicial == null && dataFinal == null)
                compromissosBanco = controladorCompromisso.SelecionarTodos();
            else if (dataInicial != null && dataFinal == null)
                compromissosBanco = controladorCompromisso.SelecionarCompromissosPassados(Convert.ToDateTime(dataInicial));
            else
                compromissosBanco = controladorCompromisso.SelecionarCompromissosFuturos(dataInicial, dataFinal);

            foreach (var item in compromissosBanco)
                lBoxCompromissos.Items.Add(item.ToString());
        }
        private void MostrarContato()
        {
            contatosBanco = controladorContato.SelecionarTodos();

            foreach (var item in contatosBanco)
                lBoxContatos.Items.Add(item.ToString());
        }
        private void SelecionaContato()
        {
            string strContato = lBoxContatos.SelectedItem.ToString().Replace("   ", "");
            string[] propContato = strContato.Split('-');
            contato = new Contato(propContato[1], propContato[2], propContato[3], propContato[4], propContato[5], Convert.ToInt32(propContato[0]));
        }
        private void ConfiguraBotoesPresencialRemoto()
        {
            if (propriedadesCompromissoSelecionado[3].Length == 0)
            {
                rBtnRemoto.Checked = true;
                tBoxLinkLocalizacao.Text = propriedadesCompromissoSelecionado[4];
            }
            else
            {
                rBtnPresencial.Checked = true;
                tBoxLinkLocalizacao.Text = propriedadesCompromissoSelecionado[3];
            }
        }
        private void ConfiguraBotoesComSemContato()
        {
            if (propriedadesCompromissoSelecionado[2] != "N/A Contato")
            {
                rBtnPossuiContato.Checked = true;
                lBoxContatos.Enabled = true;
            }
            else
            {
                rBtnNaoPossuiContato.Checked = true;
                lBoxContatos.Enabled = false;
            }
        }
        #endregion
    }
}
