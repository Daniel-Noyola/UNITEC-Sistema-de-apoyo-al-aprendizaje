namespace Sistema_de_apoyo_al_aprendizaje.Temas
{
    partial class Tema_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tema_3));
            pictureBox1 = new PictureBox();
            BtnMenu = new Button();
            BtnSiguiente = new Button();
            label4 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(578, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(230, 223);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // BtnMenu
            // 
            BtnMenu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnMenu.Location = new Point(52, 238);
            BtnMenu.Name = "BtnMenu";
            BtnMenu.Size = new Size(134, 61);
            BtnMenu.TabIndex = 17;
            BtnMenu.Text = "Menu principal";
            BtnMenu.UseVisualStyleBackColor = true;
            BtnMenu.Click += BtnMenu_Click;
            // 
            // BtnSiguiente
            // 
            BtnSiguiente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSiguiente.Location = new Point(395, 238);
            BtnSiguiente.Name = "BtnSiguiente";
            BtnSiguiente.Size = new Size(134, 61);
            BtnSiguiente.TabIndex = 16;
            BtnSiguiente.Text = "Siguiente";
            BtnSiguiente.UseVisualStyleBackColor = true;
            BtnSiguiente.Click += BtnSiguiente_Click;
            // 
            // label4
            // 
            label4.Location = new Point(33, 117);
            label4.Name = "label4";
            label4.Size = new Size(527, 98);
            label4.TabIndex = 15;
            label4.Text = resources.GetString("label4.Text");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 76);
            label1.Name = "label1";
            label1.Size = new Size(427, 30);
            label1.TabIndex = 14;
            label1.Text = "Inteligencia Artificial y Futuro del Gaming";
            // 
            // Tema_3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 374);
            Controls.Add(pictureBox1);
            Controls.Add(BtnMenu);
            Controls.Add(BtnSiguiente);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "Tema_3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tema_3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button BtnMenu;
        private Button BtnSiguiente;
        private Label label4;
        private Label label1;
    }
}