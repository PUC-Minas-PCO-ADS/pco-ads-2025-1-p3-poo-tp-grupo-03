using ControleDeEnergia.Factories;
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
    public partial class CadastroConsumidorUserControl : UserControl
    {

        private RepositorioConsumidor repositorioConsumidor;
        public CadastroConsumidorUserControl(RepositorioConsumidor repo)
        {
            InitializeComponent();
            repositorioConsumidor = repo;
            if (tipoDocumento.Items.Count > 0)
                tipoDocumento.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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

        private void tipoLabel_Click(object sender, EventArgs e)
        {

        }

        private void documentoTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveCadastroBtn_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text.Trim();
            string tipo = tipoDocumento.SelectedItem?.ToString();
            string documento = documentoTextBox.Text.Trim();

            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Preencha o nome do consumidor.");
                return;
            }
            if (string.IsNullOrEmpty(tipo))
            {
                MessageBox.Show("Selecione o tipo de documento.");
                return;
            }
            if (string.IsNullOrWhiteSpace(documento) || documento.Contains(" "))
            {
                MessageBox.Show($"Preencha corretamente o {tipo}.");
                return;
            }

            Consumidor novoConsumidor = ConsumidorFactory.CriarConsumidor(tipo, nome, documento);
            repositorioConsumidor.Adicionar(novoConsumidor);

            MessageBox.Show("Consumidor cadastrado com sucesso!");
            repositorioConsumidor.SalvarArquivo();

            textBox1.Clear();
            documentoTextBox.Clear();
        }

        private void CadastroConsumidorUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
