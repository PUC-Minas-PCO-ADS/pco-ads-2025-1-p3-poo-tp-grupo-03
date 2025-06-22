namespace ControleDeEnergia.Forms
{
    partial class CadastroContaUserControl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            documentoTextBox = new MaskedTextBox();
            saveCadastroBtn = new Button();
            tipoLabel = new Label();
            tipoDocumento = new ComboBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            numericUpDown1 = new NumericUpDown();
            label6 = new Label();
            numericUpDown2 = new NumericUpDown();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // documentoTextBox
            // 
            documentoTextBox.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            documentoTextBox.Location = new Point(198, 110);
            documentoTextBox.Name = "documentoTextBox";
            documentoTextBox.Size = new Size(132, 32);
            documentoTextBox.TabIndex = 15;
            // 
            // saveCadastroBtn
            // 
            saveCadastroBtn.Cursor = Cursors.Hand;
            saveCadastroBtn.Location = new Point(290, 275);
            saveCadastroBtn.Name = "saveCadastroBtn";
            saveCadastroBtn.Size = new Size(134, 51);
            saveCadastroBtn.TabIndex = 14;
            saveCadastroBtn.Text = "Salvar";
            saveCadastroBtn.UseVisualStyleBackColor = true;
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tipoLabel.ForeColor = SystemColors.ControlDarkDark;
            tipoLabel.Location = new Point(11, 117);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new Size(38, 20);
            tipoLabel.TabIndex = 13;
            tipoLabel.Text = "CPF";
            // 
            // tipoDocumento
            // 
            tipoDocumento.BackColor = SystemColors.Window;
            tipoDocumento.Cursor = Cursors.Hand;
            tipoDocumento.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tipoDocumento.FormattingEnabled = true;
            tipoDocumento.Items.AddRange(new object[] { "CPF", "CNPJ" });
            tipoDocumento.Location = new Point(198, 74);
            tipoDocumento.Name = "tipoDocumento";
            tipoDocumento.Size = new Size(132, 28);
            tipoDocumento.TabIndex = 12;
            tipoDocumento.SelectedIndexChanged += tipoDocumento_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(198, 213);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(132, 32);
            textBox1.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans Unicode", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(150, 24);
            label2.Name = "label2";
            label2.Size = new Size(379, 28);
            label2.TabIndex = 10;
            label2.Text = "Cadastre uma Conta de energia";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(11, 77);
            label3.Name = "label3";
            label3.Size = new Size(170, 20);
            label3.TabIndex = 8;
            label3.Text = "Tipo de Consumidor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(11, 213);
            label1.Name = "label1";
            label1.Size = new Size(181, 20);
            label1.TabIndex = 9;
            label1.Text = "Numero da instalação";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(11, 162);
            label4.Name = "label4";
            label4.Size = new Size(117, 20);
            label4.TabIndex = 16;
            label4.Text = "Tipo de conta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(361, 77);
            label5.Name = "label5";
            label5.Size = new Size(134, 20);
            label5.TabIndex = 18;
            label5.Text = "Leitura anterior";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(511, 77);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(361, 122);
            label6.Name = "label6";
            label6.Size = new Size(109, 20);
            label6.TabIndex = 20;
            label6.Text = "Leitura atual";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(511, 122);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 21;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(389, 215);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(228, 23);
            dateTimePicker1.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(451, 180);
            label7.Name = "label7";
            label7.Size = new Size(117, 20);
            label7.TabIndex = 23;
            label7.Text = "Data da conta";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Residencial", "Comercial" });
            comboBox1.Location = new Point(198, 159);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(132, 28);
            comboBox1.TabIndex = 24;
            // 
            // CadastroContaUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(dateTimePicker1);
            Controls.Add(numericUpDown2);
            Controls.Add(label6);
            Controls.Add(numericUpDown1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(documentoTextBox);
            Controls.Add(saveCadastroBtn);
            Controls.Add(tipoLabel);
            Controls.Add(tipoDocumento);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "CadastroContaUserControl";
            Size = new Size(669, 358);
            Load += CadastroContaUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox documentoTextBox;
        private Button saveCadastroBtn;
        private Label tipoLabel;
        private ComboBox tipoDocumento;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label label1;
        private Label label4;
        private Label label5;
        private NumericUpDown numericUpDown1;
        private Label label6;
        private NumericUpDown numericUpDown2;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private ComboBox comboBox1;
    }
}
