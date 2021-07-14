using eAgenda.Controladores.ContatoModule;
using eAgenda.Controladores.Shared;
using eAgenda.Dominio.ContatoModule;
using System;
using System.Windows.Forms;

namespace eAgenda.Forms.ContatoModule
{
    public partial class TelaAdicionarContato : Form
    {
        Contato contato;
        Controlador<Contato> controlador = new ControladorContato();
        public TelaAdicionarContato()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tBoxNome.Text = "";
            tBoxEmail.Text = "";
            mskTBoxTelefone.Text = "";
            tBoxEmpresa.Text = "";
            tBoxCargo.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tBoxNome.Text = "";
            tBoxEmail.Text = "";
            mskTBoxTelefone.Text = "";
            tBoxEmpresa.Text = "";
            tBoxCargo.Text = "";
            Dispose();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            contato = new Contato(tBoxNome.Text, tBoxEmail.Text, mskTBoxTelefone.Text, tBoxEmpresa.Text, tBoxCargo.Text);

            string resultadoValidacao = controlador.InserirNovo(contato);
            if (resultadoValidacao == "ESTA_VALIDO")
            {
                MessageBox.Show("Contato inserido com sucesso");
                Dispose();
            }
            else
                MessageBox.Show(resultadoValidacao);
        }
    }
}
