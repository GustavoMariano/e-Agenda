using eAgenda.Controladores.ContatoModule;
using eAgenda.Controladores.Shared;
using eAgenda.Dominio.CompromissoModule;
using eAgenda.Dominio.ContatoModule;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace eAgenda.Forms.CompromissoModule
{
    public partial class TelaAdicionarCompromisso : Form
    {
        //Controlador<Compromisso> controlador = new ControladorCompromisso();
        Controlador<Contato> controladorContato = new ControladorContato();
        Compromisso compromisso;
        Contato contato;
        public TelaAdicionarCompromisso()
        {
            InitializeComponent();

            List<Contato> todosContatos = controladorContato.SelecionarTodos();
            foreach (var item in todosContatos)
            {
                lBoxContatos.Items.Add(item.ToString());
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string link = "";
            string localizacao = "";
            if (rBtnPresencial.Checked == true)
                localizacao = tBoxLinkLocalizacao.Text;
            else
                link = tBoxLinkLocalizacao.Text;

            compromisso = new Compromisso(tBoxAssunto.Text, localizacao, link, dataInicio.Value, dateTPHoraInicio.Value.TimeOfDay, dateTPHoraConclusao.Value.TimeOfDay, contato);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tBoxAssunto.Text = "";
            tBoxLinkLocalizacao.Text = "";
            dataInicio.Value = DateTime.Now;
            dateTPHoraInicio.Value = DateTime.Now;
            dateTPHoraConclusao.Value = DateTime.Now;
            Dispose();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tBoxAssunto.Text = "";
            tBoxLinkLocalizacao.Text = "";
            dataInicio.Value = DateTime.Now;
            dateTPHoraInicio.Value = DateTime.Now;
            dateTPHoraConclusao.Value = DateTime.Now;
        }

        private void rBtnPresencial_CheckedChanged(object sender, EventArgs e)
        {
            if(rBtnPresencial.Checked == true)
                lblLinkLocalizacao.Text = "Localização*";
            else
                lblLinkLocalizacao.Text = "Link*";
        }

        private void rBtnPossuiContato_CheckedChanged(object sender, EventArgs e)
        {
            lBoxContatos.Enabled = true;
        }

        private void rBtnNaoPossuiContato_CheckedChanged(object sender, EventArgs e)
        {
            lBoxContatos.Enabled = false;
        }
    }
}
