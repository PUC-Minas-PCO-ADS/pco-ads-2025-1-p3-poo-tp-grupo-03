namespace ControleDeEnergia
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            cadastroContaBtn = new Button();
            cadastroBtn = new Button();
            inicioBtn = new Button();
            imageList1 = new ImageList(components);
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label6 = new Label();
            conteudoPanel = new Panel();
            consultarBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(consultarBtn);
            panel1.Controls.Add(cadastroContaBtn);
            panel1.Controls.Add(cadastroBtn);
            panel1.Controls.Add(inicioBtn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 489);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // cadastroContaBtn
            // 
            cadastroContaBtn.Cursor = Cursors.Hand;
            cadastroContaBtn.FlatAppearance.BorderSize = 0;
            cadastroContaBtn.FlatStyle = FlatStyle.Flat;
            cadastroContaBtn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cadastroContaBtn.ForeColor = SystemColors.ButtonFace;
            cadastroContaBtn.Location = new Point(-2, 226);
            cadastroContaBtn.Name = "cadastroContaBtn";
            cadastroContaBtn.Size = new Size(196, 53);
            cadastroContaBtn.TabIndex = 12;
            cadastroContaBtn.Text = "Cadastrar Conta";
            cadastroContaBtn.UseVisualStyleBackColor = true;
            cadastroContaBtn.Click += cadastroContaBtn_Click;
            // 
            // cadastroBtn
            // 
            cadastroBtn.Cursor = Cursors.Hand;
            cadastroBtn.FlatAppearance.BorderSize = 0;
            cadastroBtn.FlatStyle = FlatStyle.Flat;
            cadastroBtn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cadastroBtn.ForeColor = SystemColors.ButtonFace;
            cadastroBtn.Location = new Point(-2, 158);
            cadastroBtn.Name = "cadastroBtn";
            cadastroBtn.Size = new Size(196, 53);
            cadastroBtn.TabIndex = 11;
            cadastroBtn.Text = "Cadastrar";
            cadastroBtn.UseVisualStyleBackColor = true;
            cadastroBtn.Click += cadastroBtn_Click_1;
            // 
            // inicioBtn
            // 
            inicioBtn.Cursor = Cursors.Hand;
            inicioBtn.FlatAppearance.BorderSize = 0;
            inicioBtn.FlatStyle = FlatStyle.Flat;
            inicioBtn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inicioBtn.ForeColor = SystemColors.ButtonFace;
            inicioBtn.Location = new Point(-2, 88);
            inicioBtn.Name = "inicioBtn";
            inicioBtn.Size = new Size(196, 53);
            inicioBtn.TabIndex = 10;
            inicioBtn.Text = "Inicio";
            inicioBtn.UseVisualStyleBackColor = true;
            inicioBtn.Click += button1_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(234, 28);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(116, 97);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans Unicode", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(388, 64);
            label1.Name = "label1";
            label1.Size = new Size(347, 28);
            label1.TabIndex = 3;
            label1.Text = "Calculo Consumo de Energia";
            label1.Click += label1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(805, 9);
            label6.Name = "label6";
            label6.Size = new Size(31, 33);
            label6.TabIndex = 10;
            label6.Text = "X";
            label6.Click += label6_Click;
            // 
            // conteudoPanel
            // 
            conteudoPanel.Dock = DockStyle.Bottom;
            conteudoPanel.Location = new Point(200, 131);
            conteudoPanel.Name = "conteudoPanel";
            conteudoPanel.Size = new Size(669, 358);
            conteudoPanel.TabIndex = 11;
            conteudoPanel.Paint += conteudoPanel_Paint_1;
            // 
            // consultarBtn
            // 
            consultarBtn.Cursor = Cursors.Hand;
            consultarBtn.FlatAppearance.BorderSize = 0;
            consultarBtn.FlatStyle = FlatStyle.Flat;
            consultarBtn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            consultarBtn.ForeColor = SystemColors.ButtonFace;
            consultarBtn.Location = new Point(-2, 298);
            consultarBtn.Name = "consultarBtn";
            consultarBtn.Size = new Size(196, 53);
            consultarBtn.TabIndex = 13;
            consultarBtn.Text = "Consultar";
            consultarBtn.UseVisualStyleBackColor = true;
            consultarBtn.Click += consultarBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(869, 489);
            Controls.Add(conteudoPanel);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ImageList imageList1;
        private PictureBox pictureBox2;
        private Label label1;
        private Button inicioBtn;
        private Label label6;
        private Panel conteudoPanel;
        private Button cadastroBtn;
        private Button cadastroContaBtn;
        private Button consultarBtn;
    }
}
