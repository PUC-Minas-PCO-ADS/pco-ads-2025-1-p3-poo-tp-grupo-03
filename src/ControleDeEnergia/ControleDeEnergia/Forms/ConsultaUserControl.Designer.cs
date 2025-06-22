namespace ControleDeEnergia.Forms
{
    partial class ConsultaUserControl
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
            label2 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            consumoAnterior = new Label();
            valorTotal = new Label();
            semImposto = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // documentoTextBox
            // 
            documentoTextBox.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            documentoTextBox.Location = new Point(273, 59);
            documentoTextBox.Name = "documentoTextBox";
            documentoTextBox.Size = new Size(164, 32);
            documentoTextBox.TabIndex = 15;
            // 
            // saveCadastroBtn
            // 
            saveCadastroBtn.Cursor = Cursors.Hand;
            saveCadastroBtn.Location = new Point(468, 61);
            saveCadastroBtn.Name = "saveCadastroBtn";
            saveCadastroBtn.Size = new Size(97, 28);
            saveCadastroBtn.TabIndex = 14;
            saveCadastroBtn.Text = "Consultar";
            saveCadastroBtn.UseVisualStyleBackColor = true;
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tipoLabel.ForeColor = SystemColors.ControlDarkDark;
            tipoLabel.Location = new Point(218, 63);
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
            tipoDocumento.Location = new Point(134, 60);
            tipoDocumento.Name = "tipoDocumento";
            tipoDocumento.Size = new Size(62, 28);
            tipoDocumento.TabIndex = 12;
            tipoDocumento.SelectedIndexChanged += tipoDocumento_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans Unicode", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(185, 14);
            label2.Name = "label2";
            label2.Size = new Size(276, 28);
            label2.TabIndex = 10;
            label2.Text = "Consultar Consumidor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(84, 60);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 8;
            label3.Text = "Tipo";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 107);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(610, 83);
            dataGridView1.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(37, 210);
            label1.Name = "label1";
            label1.Size = new Size(174, 40);
            label1.TabIndex = 17;
            label1.Text = "Consumo de energia\r\nno ultimo mês";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(284, 210);
            label4.Name = "label4";
            label4.Size = new Size(120, 40);
            label4.TabIndex = 18;
            label4.Text = "Valor total da \r\nultima conta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(478, 210);
            label5.Name = "label5";
            label5.Size = new Size(145, 60);
            label5.TabIndex = 19;
            label5.Text = "Valor total da \r\nultima conta sem\r\nimpostos";
            // 
            // consumoAnterior
            // 
            consumoAnterior.AutoSize = true;
            consumoAnterior.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            consumoAnterior.ForeColor = SystemColors.ControlDarkDark;
            consumoAnterior.Location = new Point(98, 287);
            consumoAnterior.Name = "consumoAnterior";
            consumoAnterior.Size = new Size(19, 20);
            consumoAnterior.TabIndex = 20;
            consumoAnterior.Text = "0";
            // 
            // valorTotal
            // 
            valorTotal.AutoSize = true;
            valorTotal.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            valorTotal.ForeColor = SystemColors.ControlDarkDark;
            valorTotal.Location = new Point(326, 287);
            valorTotal.Name = "valorTotal";
            valorTotal.Size = new Size(19, 20);
            valorTotal.TabIndex = 21;
            valorTotal.Text = "0";
            // 
            // semImposto
            // 
            semImposto.AutoSize = true;
            semImposto.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            semImposto.ForeColor = SystemColors.ControlDarkDark;
            semImposto.Location = new Point(537, 287);
            semImposto.Name = "semImposto";
            semImposto.Size = new Size(19, 20);
            semImposto.TabIndex = 22;
            semImposto.Text = "0";
            // 
            // ConsultaUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(semImposto);
            Controls.Add(valorTotal);
            Controls.Add(consumoAnterior);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(documentoTextBox);
            Controls.Add(saveCadastroBtn);
            Controls.Add(tipoLabel);
            Controls.Add(tipoDocumento);
            Controls.Add(label2);
            Controls.Add(label3);
            Name = "ConsultaUserControl";
            Size = new Size(669, 358);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox documentoTextBox;
        private Button saveCadastroBtn;
        private Label tipoLabel;
        private ComboBox tipoDocumento;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label consumoAnterior;
        private Label valorTotal;
        private Label semImposto;
    }
}
