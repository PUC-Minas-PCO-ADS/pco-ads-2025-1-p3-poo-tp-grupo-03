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
        public CadastroConsumidorUserControl()
        {
            InitializeComponent();
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
            
        }
    }
}
