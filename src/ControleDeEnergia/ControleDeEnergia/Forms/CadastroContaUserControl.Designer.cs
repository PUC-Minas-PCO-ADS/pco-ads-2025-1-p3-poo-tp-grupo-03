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
            saveCadastroContaBtn = new Button();
            tipoLabel = new Label();
            tipoDocumento = new ComboBox();
            instalacaoTxtBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            leituraAnterior = new NumericUpDown();
            label6 = new Label();
            leituraAtual = new NumericUpDown();
            dataConta = new DateTimePicker();
            label7 = new Label();
            tipoContaComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)leituraAnterior).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leituraAtual).BeginInit();
            SuspendLayout();
            // 
            // documentoTextBox
            // 
            documentoTextBox.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            documentoTextBox.Location = new Point(316, 108);
            documentoTextBox.Name = "documentoTextBox";
            documentoTextBox.Size = new Size(132, 32);
            documentoTextBox.TabIndex = 15;
            // 
            // saveCadastroContaBtn
            // 
            saveCadastroContaBtn.Cursor = Cursors.Hand;
            saveCadastroContaBtn.Location = new Point(427, 274);
            saveCadastroContaBtn.Name = "saveCadastroContaBtn";
            saveCadastroContaBtn.Size = new Size(134, 51);
            saveCadastroContaBtn.TabIndex = 14;
            saveCadastroContaBtn.Text = "Salvar";
            saveCadastroContaBtn.UseVisualStyleBackColor = true;
            saveCadastroContaBtn.Click += saveCadastroContaBtn_Click;
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tipoLabel.ForeColor = SystemColors.ControlDarkDark;
            tipoLabel.Location = new Point(129, 115);
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
            tipoDocumento.Location = new Point(316, 72);
            tipoDocumento.Name = "tipoDocumento";
            tipoDocumento.Size = new Size(132, 28);
            tipoDocumento.TabIndex = 12;
            tipoDocumento.SelectedIndexChanged += tipoDocumento_SelectedIndexChanged;
            // 
            // instalacaoTxtBox
            // 
            instalacaoTxtBox.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            instalacaoTxtBox.Location = new Point(316, 211);
            instalacaoTxtBox.Name = "instalacaoTxtBox";
            instalacaoTxtBox.Size = new Size(132, 32);
            instalacaoTxtBox.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans Unicode", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(292, 0);
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
            label3.Location = new Point(129, 75);
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
            label1.Location = new Point(129, 211);
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
            label4.Location = new Point(129, 160);
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
            label5.Location = new Point(579, 75);
            label5.Name = "label5";
            label5.Size = new Size(134, 20);
            label5.TabIndex = 18;
            label5.Text = "Leitura anterior";
            // 
            // leituraAnterior
            // 
            leituraAnterior.Location = new Point(729, 75);
            leituraAnterior.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            leituraAnterior.Name = "leituraAnterior";
            leituraAnterior.Size = new Size(120, 23);
            leituraAnterior.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(579, 120);
            label6.Name = "label6";
            label6.Size = new Size(109, 20);
            label6.TabIndex = 20;
            label6.Text = "Leitura atual";
            // 
            // leituraAtual
            // 
            leituraAtual.Location = new Point(729, 120);
            leituraAtual.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            leituraAtual.Name = "leituraAtual";
            leituraAtual.Size = new Size(120, 23);
            leituraAtual.TabIndex = 21;
            // 
            // dataConta
            // 
            dataConta.Location = new Point(607, 213);
            dataConta.Name = "dataConta";
            dataConta.Size = new Size(228, 23);
            dataConta.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(669, 178);
            label7.Name = "label7";
            label7.Size = new Size(117, 20);
            label7.TabIndex = 23;
            label7.Text = "Data da conta";
            // 
            // tipoContaComboBox
            // 
            tipoContaComboBox.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tipoContaComboBox.FormattingEnabled = true;
            tipoContaComboBox.Items.AddRange(new object[] { "Residencial", "Comercial" });
            tipoContaComboBox.Location = new Point(316, 157);
            tipoContaComboBox.Name = "tipoContaComboBox";
            tipoContaComboBox.Size = new Size(132, 28);
            tipoContaComboBox.TabIndex = 24;
            // 
            // CadastroContaUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tipoContaComboBox);
            Controls.Add(label7);
            Controls.Add(dataConta);
            Controls.Add(leituraAtual);
            Controls.Add(label6);
            Controls.Add(leituraAnterior);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(documentoTextBox);
            Controls.Add(saveCadastroContaBtn);
            Controls.Add(tipoLabel);
            Controls.Add(tipoDocumento);
            Controls.Add(instalacaoTxtBox);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "CadastroContaUserControl";
            Size = new Size(947, 358);
            Load += CadastroContaUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)leituraAnterior).EndInit();
            ((System.ComponentModel.ISupportInitialize)leituraAtual).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox documentoTextBox;
        private Button saveCadastroContaBtn;
        private Label tipoLabel;
        private ComboBox tipoDocumento;
        private TextBox instalacaoTxtBox;
        private Label label2;
        private Label label3;
        private Label label1;
        private Label label4;
        private Label label5;
        private NumericUpDown leituraAnterior;
        private Label label6;
        private NumericUpDown leituraAtual;
        private DateTimePicker dataConta;
        private Label label7;
        private ComboBox tipoContaComboBox;
    }
}
