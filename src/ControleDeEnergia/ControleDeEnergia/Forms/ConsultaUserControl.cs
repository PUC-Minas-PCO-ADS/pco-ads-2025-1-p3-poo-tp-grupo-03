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
        public ConsultaUserControl()
        {
            InitializeComponent();
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
    }
}
