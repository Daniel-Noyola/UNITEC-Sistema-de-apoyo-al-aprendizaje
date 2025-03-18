namespace Sistema_de_apoyo_al_aprendizaje
{
    partial class Tema_1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tema_1));
            label1 = new Label();
            label4 = new Label();
            BtnSiguiente = new Button();
            BtnMenu = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 41);
            label1.Name = "label1";
            label1.Size = new Size(267, 30);
            label1.TabIndex = 0;
            label1.Text = "Los Primeros Videojuegos";
            // 
            // label4
            // 
            label4.Location = new Point(26, 82);
            label4.Name = "label4";
            label4.Size = new Size(565, 120);
            label4.TabIndex = 3;
            label4.Text = resources.GetString("label4.Text");
            // 
            // BtnSiguiente
            // 
            BtnSiguiente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSiguiente.Location = new Point(395, 229);
            BtnSiguiente.Name = "BtnSiguiente";
            BtnSiguiente.Size = new Size(134, 61);
            BtnSiguiente.TabIndex = 6;
            BtnSiguiente.Text = "Siguiente";
            BtnSiguiente.UseVisualStyleBackColor = true;
            BtnSiguiente.Click += BtnSiguiente_Click;
            // 
            // BtnMenu
            // 
            BtnMenu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnMenu.Location = new Point(50, 229);
            BtnMenu.Name = "BtnMenu";
            BtnMenu.Size = new Size(134, 61);
            BtnMenu.TabIndex = 8;
            BtnMenu.Text = "Menu principal";
            BtnMenu.UseVisualStyleBackColor = true;
            BtnMenu.Click += MainButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Tema1_1;
            pictureBox1.Location = new Point(597, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(267, 223);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Tema_1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 327);
            Controls.Add(pictureBox1);
            Controls.Add(BtnMenu);
            Controls.Add(BtnSiguiente);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "Tema_1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tema 1:Historia de los Videojuegos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label4;
        private Button BtnSiguiente;
        private Button BtnMenu;
        private PictureBox pictureBox1;
    }
}