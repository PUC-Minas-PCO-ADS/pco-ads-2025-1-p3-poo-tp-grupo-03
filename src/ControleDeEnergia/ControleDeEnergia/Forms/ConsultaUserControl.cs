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
    public partial class ConsultaUserControl : UserControl
    {
        private RepositorioConsumidor repositorioConsumidor;
        private RepositorioConta repositorioConta;
        public ConsultaUserControl(RepositorioConsumidor repoConsumidor, RepositorioConta repoConta)
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

        private void consultarBtn_Click(object sender, EventArgs e)
        {
            string tipoDoc = tipoDocumento.SelectedItem?.ToString();
            string documento = documentoTextBox.Text.Trim();

            if (string.IsNullOrEmpty(tipoDoc) || string.IsNullOrEmpty(documento))
            {
                MessageBox.Show("Preencha o tipo e o documento.");
                return;
            }

            // Buscar consumidor
            Consumidor consumidor = repositorioConsumidor.ListarTodos()
                .FirstOrDefault(c =>
                    (tipoDoc == "CPF" && c is PessoaFisica pf && pf.CPF == documento) ||
                    (tipoDoc == "CNPJ" && c is PessoaJuridica pj && pj.CNPJ == documento)
                );

            if (consumidor == null)
            {
                MessageBox.Show("Consumidor não encontrado.");
                dataGridView1.DataSource = null;
                consumoAnterior.Text = valorTotal.Text = semImposto.Text = "-";
                return;
            }

            // Listar contas
            var contas = consumidor.ListarContas();
            dataGridView1.DataSource = contas.Select(c => new
            {
                c.Instalacao,
                c.DataConta,
                c.LeituraAnterior,
                c.LeituraAtual,
                Consumo = c.CalcularConsumo(),
                Tipo = c is ContaResidencial ? "Residencial" : "Comercial",
                ValorTotal = c.CalcularValorTotal(),
                ValorSemImpostos = c.CalcularValorSemImpostos()
            }).ToList();

            // Calcular totais acumulados
            double totalConsumo = contas.Sum(c => c.CalcularConsumo());
            double totalValor = contas.Sum(c => c.CalcularValorTotal());
            double totalSemImposto = contas.Sum(c => c.CalcularValorSemImpostos());

            if (contas.Count > 0)
            {
                consumoAnterior.Text = $"{totalConsumo:N2} kW/h";
                valorTotal.Text = totalValor.ToString("C2");
                semImposto.Text = totalSemImposto.ToString("C2");
            }
            else
            {
                consumoAnterior.Text = valorTotal.Text = semImposto.Text = "-";
            }
        }

        private void ConsultaUserControl_Load(object sender, EventArgs e)
        {

        }

        private void consumoAnterior_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
