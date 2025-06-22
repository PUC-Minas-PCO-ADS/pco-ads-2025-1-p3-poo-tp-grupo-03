using ControleDeEnergia.Forms;

namespace ControleDeEnergia
{
    public partial class Form1 : Form
    {

        // Instâncias dos UserControls como campos da classe
        private InicioUserControl inicioUserControl = new InicioUserControl();
        private CadastroConsumidorUserControl cadastroConsumidorUserControl = new CadastroConsumidorUserControl();
        private CadastroContaUserControl cadastroContaUserControl = new CadastroContaUserControl();
        private ConsultaUserControl consultaUserControl = new ConsultaUserControl();
        public Form1()
        {
            InitializeComponent();
            ExibirUserControl(inicioUserControl);
        }
        private void ExibirUserControl(UserControl uc)
        {
            conteudoPanel.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            conteudoPanel.Controls.Add(uc);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExibirUserControl(inicioUserControl);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void inicioUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void cadastroConsumidorUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void conteudoPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cadastroBtn_Click_1(object sender, EventArgs e)
        {
            ExibirUserControl(cadastroConsumidorUserControl);
        }

        private void conteudoPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void cadastroContaBtn_Click(object sender, EventArgs e)
        {
            ExibirUserControl(cadastroContaUserControl);
        }

        private void consultarBtn_Click(object sender, EventArgs e)
        {
            ExibirUserControl(consultaUserControl);
        }
    }
}
