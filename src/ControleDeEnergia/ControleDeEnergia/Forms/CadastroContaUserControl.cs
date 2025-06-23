using ControleDeEnergia.Models;
using ControleDeEnergia.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeEnergia.Forms
{
    public partial class CadastroContaUserControl : UserControl
    {
        private RepositorioConsumidor repositorioConsumidor;
        private RepositorioConta repositorioConta;
        public CadastroContaUserControl(RepositorioConsumidor repoConsumidor, RepositorioConta repoConta)
        {
            InitializeComponent();
            repositorioConsumidor = repoConsumidor;
            repositorioConta = repoConta;
        }

        private void tipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tipoDocumento.SelectedItem?.ToString() == "CPF")
            {
                tipoLabel.Text = "CPF";
                documentoTextBox.Mask = "000.000.000-00";
                documentoTextBox.Clear();
            }
            else if (tipoDocumento.SelectedItem?.ToString() == "CNPJ")
            {
                tipoLabel.Text = "CNPJ";
                documentoTextBox.Mask = "00.000.000/0000-00";
                documentoTextBox.Clear();
            }

        }

        private void CadastroContaUserControl_Load(object sender, EventArgs e)
        {

        }

        private void saveCadastroContaBtn_Click(object sender, EventArgs e)
        {

            string tipoDoc = tipoDocumento.SelectedItem?.ToString();
            string documento = documentoTextBox.Text.Trim();
            string tipoConta = tipoContaComboBox.SelectedItem?.ToString();
            string instalacao = instalacaoTxtBox.Text.Trim();
            DateTime data = dataConta.Value;

            // Validação dis campos
            if (string.IsNullOrEmpty(tipoDoc) || string.IsNullOrEmpty(documento) ||
                string.IsNullOrEmpty(tipoConta) || string.IsNullOrEmpty(instalacao))
            {
                MessageBox.Show("Preencha todos os campos corretamente.");
                return;
            }

            double leituraAnteriorValor = (double)leituraAnterior.Value;
            double leituraAtualValor = (double)leituraAtual.Value;

            // Buscar consumidor
            Consumidor consumidor = repositorioConsumidor.ListarTodos()
                .FirstOrDefault(c =>
                    (tipoDoc == "CPF" && c is PessoaFisica pf && pf.CPF == documento) ||
                    (tipoDoc == "CNPJ" && c is PessoaJuridica pj && pj.CNPJ == documento)
                );

            if (consumidor == null)
            {
                MessageBox.Show("Consumidor não encontrado.");
                return;
            }

            // Criar conta
            ContaDeEnergia conta;
            if (tipoConta == "Residencial")
                conta = new ContaResidencial();
            else
                conta = new ContaComercial();

            conta.LeituraAnterior = leituraAnteriorValor;
            conta.LeituraAtual = leituraAtualValor;
            conta.DataConta = data;
            conta.Instalacao = instalacao;

            // Associar conta ao consumidor
            consumidor.AdicionarConta(conta);
            repositorioConsumidor.SalvarArquivo();

            // Salvar no repositório de contas
            repositorioConta.Adicionar(conta);

            // Salvar arquivos
            repositorioConta.SalvarArquivo();
            repositorioConsumidor.SalvarArquivo();

            MessageBox.Show("Conta cadastrada com sucesso!");

            // Limpar campos
            instalacaoTxtBox.Clear();
            documentoTextBox.Clear();
            leituraAnterior.Value = 0;
            leituraAtual.Value = 0;
        }
    }
    
}
