namespace Sistema_de_apoyo_al_aprendizaje.Temas.Tema1
{
    partial class Tema1_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tema1_2));
            label5 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            BtnAnterior = new Button();
            BtnSiguiente = new Button();
            BtnMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.Location = new Point(12, 70);
            label5.Name = "label5";
            label5.Size = new Size(592, 213);
            label5.TabIndex = 6;
            label5.Text = resources.GetString("label5.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 27);
            label2.Name = "label2";
            label2.Size = new Size(264, 30);
            label2.TabIndex = 5;
            label2.Text = "Evolución de las Consolas";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Tema_1_2;
            pictureBox1.Location = new Point(610, 91);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(230, 223);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // BtnAnterior
            // 
            BtnAnterior.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAnterior.Location = new Point(37, 306);
            BtnAnterior.Name = "BtnAnterior";
            BtnAnterior.Size = new Size(134, 61);
            BtnAnterior.TabIndex = 12;
            BtnAnterior.Text = "Anterior";
            BtnAnterior.UseVisualStyleBackColor = true;
            BtnAnterior.Click += BtnAnterior_Click;
            // 
            // BtnSiguiente
            // 
            BtnSiguiente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSiguiente.Location = new Point(444, 306);
            BtnSiguiente.Name = "BtnSiguiente";
            BtnSiguiente.Size = new Size(134, 61);
            BtnSiguiente.TabIndex = 11;
            BtnSiguiente.Text = "Siguiente";
            BtnSiguiente.UseVisualStyleBackColor = true;
            BtnSiguiente.Click += BtnSiguiente_Click;
            // 
            // BtnMenu
            // 
            BtnMenu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnMenu.Location = new Point(240, 306);
            BtnMenu.Name = "BtnMenu";
            BtnMenu.Size = new Size(134, 61);
            BtnMenu.TabIndex = 13;
            BtnMenu.Text = "Menu principal";
            BtnMenu.UseVisualStyleBackColor = true;
            BtnMenu.Click += BtnMenu_Click;
            // 
            // Tema1_2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 420);
            Controls.Add(BtnMenu);
            Controls.Add(BtnAnterior);
            Controls.Add(BtnSiguiente);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label2);
            Name = "Tema1_2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tema 1:Historia de los Videojuegos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label2;
        private PictureBox pictureBox1;
        private Button BtnAnterior;
        private Button BtnSiguiente;
        private Button BtnMenu;
    }
}