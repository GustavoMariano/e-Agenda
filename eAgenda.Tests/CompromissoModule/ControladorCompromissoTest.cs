using eAgenda.Controladores.CompromissoModule;
using eAgenda.Controladores.ContatoModule;
using eAgenda.Controladores.Shared;
using eAgenda.Dominio.CompromissoModule;
using eAgenda.Dominio.ContatoModule;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace eAgenda.Tests.CompromissoModule
{
    [TestClass]
    public class ControladorCompromissoTest
    {
        ControladorCompromisso controladorCompromisso = null;
        ControladorContato controladorContato = null;

        public ControladorCompromissoTest()
        {
            controladorCompromisso = new ControladorCompromisso();
            controladorContato = new ControladorContato();
            Db.Update("DELETE FROM [TBCOMPROMISSO]");
            Db.Update("DELETE FROM [TBCONTATO]");
        }

        [TestMethod]
        public void DeveInserir_CompromissoComContato()
        {
            //arrange
            DateTime dataCompromisso;
            TimeSpan dataInicio, dataTermino;
            Contato novoContato;
            Input(out dataCompromisso, out dataInicio, out dataTermino, out novoContato);
            var compromisso = new Compromisso("Assunto", "Local", "Link", dataCompromisso, dataInicio, dataTermino, novoContato);

            //action
            controladorCompromisso.InserirNovo(compromisso);

            //assert
            var compromissoEncontrado = controladorCompromisso.SelecionarPorId(compromisso.Id);
            compromissoEncontrado.Should().Be(compromisso);
        }
        [TestMethod]
        public void DeveInserir_CompromissoSemContato()
        {
            //arrange
            DateTime dataCompromisso = new DateTime(2021, 12, 12);
            TimeSpan dataInicio = new TimeSpan(12, 12, 12);
            TimeSpan dataTermino = new TimeSpan(12, 12, 13);

            var compromisso = new Compromisso("Assunto", "Local", "Link", dataCompromisso, dataInicio, dataTermino, null);

            //action
            controladorCompromisso.InserirNovo(compromisso);

            //assert
            var compromissoEncontrado = controladorCompromisso.SelecionarPorId(compromisso.Id);
            compromissoEncontrado.Should().Be(compromisso);
        }
        [TestMethod]
        public void DeveAtualizar_Compromisso()
        {
            //arrange
            DateTime dataCompromisso;
            TimeSpan dataInicio, dataTermino;
            Contato novoContato;
            Input(out dataCompromisso, out dataInicio, out dataTermino, out novoContato);

            var compromisso = new Compromisso("Assunto", "Local", "Link", dataCompromisso.AddDays(1), dataInicio, dataTermino, novoContato);
            controladorCompromisso.InserirNovo(compromisso);

            var novoCompromisso = new Compromisso("Assunto", "LocalEditado", "Link", dataCompromisso, dataInicio, dataTermino, novoContato);

            //action
            controladorCompromisso.Editar(compromisso.Id, novoCompromisso);

            //assert
            Compromisso compromissoAtualizado = controladorCompromisso.SelecionarPorId(compromisso.Id);
            compromissoAtualizado.Should().Be(novoCompromisso);
        }
        [TestMethod]
        public void NaoDeveAtualizar_CompromissoDataJaUsada()
        {
            //arrange
            DateTime dataCompromisso;
            TimeSpan dataInicio, dataTermino;
            Contato novoContato;
            Input(out dataCompromisso, out dataInicio, out dataTermino, out novoContato);

            var compromissoParaEditar = new Compromisso("Compromisso a ser editado", "Midi", "Presencial", DateTime.Now, dataInicio, dataTermino, novoContato);
            controladorCompromisso.InserirNovo(compromissoParaEditar);

            var compromissoUtilizandoData = new Compromisso("Compromisso usando data e hora", "Remoto", "meet.com/", dataCompromisso, dataInicio, dataTermino, novoContato);
            controladorCompromisso.InserirNovo(compromissoUtilizandoData);

            var compromissoEditadoDataJaUsada = new Compromisso("Compromisso repetindo data", "NDD", "Presencial", dataCompromisso, dataInicio, dataTermino, novoContato);

            //action
            controladorCompromisso.Editar(compromissoParaEditar.Id, compromissoEditadoDataJaUsada);

            //assert
            Compromisso compromissoAtualizado = controladorCompromisso.SelecionarPorId(compromissoParaEditar.Id);
            compromissoAtualizado.Should().Be(compromissoParaEditar);
        }
        [TestMethod]
        public void DeveExcluir_Compromisso()
        {
            //arrange            
            DateTime dataCompromisso;
            TimeSpan dataInicio, dataTermino;
            Contato novoContato;
            Input(out dataCompromisso, out dataInicio, out dataTermino, out novoContato);

            var compromisso = new Compromisso("Assunto", "Local", "Link", dataCompromisso, dataInicio, dataTermino, null);
            controladorCompromisso.InserirNovo(compromisso);

            //action

            controladorCompromisso.Excluir(compromisso.Id);

            //assert
            Compromisso contatoEncontrado = controladorCompromisso.SelecionarPorId(compromisso.Id);
            contatoEncontrado.Should().BeNull();
        }
        [TestMethod]
        public void DeveSelecionar_CompromissoPorId()
        {
            //arrange
            DateTime dataCompromisso;
            TimeSpan dataInicio, dataTermino;
            Contato novoContato;
            Input(out dataCompromisso, out dataInicio, out dataTermino, out novoContato);

            var compromisso = new Compromisso("Assunto", "Local", "Link", dataCompromisso, dataInicio, dataTermino, null);
            controladorCompromisso.InserirNovo(compromisso);

            //action
            Compromisso compromissoEncontrado = controladorCompromisso.SelecionarPorId(compromisso.Id);

            //assert
            compromissoEncontrado.Should().NotBeNull();
        }
        [TestMethod]
        public void DeveSelecionar_CompromissoDataFutura()
        {
            //arrange
            DateTime dataCompromisso;
            TimeSpan dataInicio, dataTermino;
            Contato novoContato;
            Input(out dataCompromisso, out dataInicio, out dataTermino, out novoContato);

            var compromissoPassado = new Compromisso("Assunto Passado", "Midi", "Presencial", DateTime.Now.AddDays(-1), dataInicio, dataTermino, null);
            controladorCompromisso.InserirNovo(compromissoPassado);

            var compromissoFuturo = new Compromisso("Assunto Futuro", "Ndd", "Presencial", DateTime.Now.AddDays(1), dataInicio, dataTermino, null);
            controladorCompromisso.InserirNovo(compromissoFuturo);

            //action
            List<Compromisso> compromissosFuturos = controladorCompromisso.SelecionarCompromissosFuturos(DateTime.Now, DateTime.Now.AddDays(5));

            //assert
            compromissosFuturos.Should().HaveCount(1);
        }
        [TestMethod]
        public void DeveSelecionar_CompromissoDataPassada()
        {
            //arrange
            DateTime dataCompromisso;
            TimeSpan dataInicio, dataTermino;
            Contato novoContato;
            Input(out dataCompromisso, out dataInicio, out dataTermino, out novoContato);

            var compromissoPassado = new Compromisso("Assunto Passado", "Midi", "Presencial", DateTime.Now.AddDays(-1), dataInicio, dataTermino, null);
            controladorCompromisso.InserirNovo(compromissoPassado);

            var compromissoFuturo = new Compromisso("Assunto Futuro", "Ndd", "Presencial", DateTime.Now.AddDays(1), dataInicio, dataTermino, null);
            controladorCompromisso.InserirNovo(compromissoFuturo);

            //action
            List<Compromisso> compromissosPassados = controladorCompromisso.SelecionarCompromissosPassados(DateTime.Now);

            //assert
            compromissosPassados.Should().HaveCount(1);
        }
        [TestMethod]
        public void DeveSelecionar_TodosCompromissos()
        {
            //arrange
            DateTime dataCompromisso;
            TimeSpan dataInicio, dataTermino;
            Contato novoContato;
            Input(out dataCompromisso, out dataInicio, out dataTermino, out novoContato);

            var compromisso = new Compromisso("Compromisso 1", "Local", "Presencial", dataCompromisso, dataInicio, dataTermino, null);
            controladorCompromisso.InserirNovo(compromisso);

            var compromisso1 = new Compromisso("Compromisso 2", "Remoto", "Link", dataCompromisso.AddDays(1), dataInicio, dataTermino, null);
            controladorCompromisso.InserirNovo(compromisso1);

            var compromisso2 = new Compromisso("Compromisso 3", "Local", "Presencial", dataCompromisso.AddDays(2), dataInicio, dataTermino, null);
            controladorCompromisso.InserirNovo(compromisso2);
            //action
            var compromissos = controladorCompromisso.SelecionarTodos();

            //assert
            compromissos.Should().HaveCount(3);
            compromissos[0].Assunto.Should().Be("Compromisso 1");
            compromissos[1].Assunto.Should().Be("Compromisso 2");
            compromissos[2].Assunto.Should().Be("Compromisso 3");
        }
        [TestMethod]
        public void NaoDeveInserir_CompromissoComDataRepetida()
        {
            //arrange
            Compromisso compromisso1 = new Compromisso("Assunto1", "Midi", "", new DateTime(2021, 11, 04), new TimeSpan(14, 00, 00), new TimeSpan(15, 00, 00), null);
            controladorCompromisso.InserirNovo(compromisso1);

            //action
            Compromisso compromissoMesmaData = new Compromisso("Assunto2", "", "meet.com/", new DateTime(2021, 11, 04), new TimeSpan(14, 00, 00), new TimeSpan(15, 00, 00), null);           
            string resultado = controladorCompromisso.InserirNovo(compromissoMesmaData);

            //assert
            resultado.Should().Be("Já há compromisso marcado nessa data e horário");
            controladorCompromisso.SelecionarTodos().Should().HaveCount(1);
        }
        private void Input(out DateTime dataCompromisso, out TimeSpan dataInicio, out TimeSpan dataTermino, out Contato novoContato)
        {
            dataCompromisso = new DateTime(2021, 12, 12);
            dataInicio = new TimeSpan(12, 12, 12);
            dataTermino = new TimeSpan(12, 12, 13);
            novoContato = new Contato("José Pedro", "jp@gmail.com", "3251-8000", "JP Ltda.", "Dev");
            controladorContato.InserirNovo(novoContato);
        }
    }
}

