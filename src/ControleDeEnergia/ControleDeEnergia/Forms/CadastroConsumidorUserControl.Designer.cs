namespace ControleDeEnergia.Forms
{
    partial class CadastroConsumidorUserControl
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            tipoDocumento = new ComboBox();
            tipoLabel = new Label();
            saveCadastroBtn = new Button();
            documentoTextBox = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(166, 83);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans Unicode", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(166, 16);
            label2.Name = "label2";
            label2.Size = new Size(310, 28);
            label2.TabIndex = 1;
            label2.Text = "Cadastre um Consumidor";
            label2.Click += this.label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(170, 133);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 0;
            label3.Text = "Tipo";
            label3.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(240, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(225, 32);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += this.textBox1_TextChanged;
            // 
            // tipoDocumento
            // 
            tipoDocumento.BackColor = SystemColors.Window;
            tipoDocumento.Cursor = Cursors.Hand;
            tipoDocumento.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tipoDocumento.FormattingEnabled = true;
            tipoDocumento.Items.AddRange(new object[] { "CPF", "CNPJ" });
            tipoDocumento.Location = new Point(240, 131);
            tipoDocumento.Name = "tipoDocumento";
            tipoDocumento.Size = new Size(225, 28);
            tipoDocumento.TabIndex = 3;
            tipoDocumento.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tipoLabel.ForeColor = SystemColors.ControlDarkDark;
            tipoLabel.Location = new Point(172, 187);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new Size(38, 20);
            tipoLabel.TabIndex = 4;
            tipoLabel.Text = "CPF";
            tipoLabel.Click += tipoLabel_Click;
            // 
            // saveCadastroBtn
            // 
            saveCadastroBtn.Cursor = Cursors.Hand;
            saveCadastroBtn.Location = new Point(275, 249);
            saveCadastroBtn.Name = "saveCadastroBtn";
            saveCadastroBtn.Size = new Size(134, 51);
            saveCadastroBtn.TabIndex = 6;
            saveCadastroBtn.Text = "Salvar";
            saveCadastroBtn.UseVisualStyleBackColor = true;
            saveCadastroBtn.Click += this.saveCadastroBtn_Click;
            // 
            // documentoTextBox
            // 
            documentoTextBox.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            documentoTextBox.Location = new Point(240, 182);
            documentoTextBox.Name = "documentoTextBox";
            documentoTextBox.Size = new Size(225, 32);
            documentoTextBox.TabIndex = 7;
            documentoTextBox.MaskInputRejected += documentoTextBox_MaskInputRejected;
            // 
            // CadastroConsumidorUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(documentoTextBox);
            Controls.Add(saveCadastroBtn);
            Controls.Add(tipoLabel);
            Controls.Add(tipoDocumento);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "CadastroConsumidorUserControl";
            Size = new Size(669, 358);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private ComboBox tipoDocumento;
        private Label tipoLabel;
        private Button saveCadastroBtn;
        private MaskedTextBox documentoTextBox;
    }
}
