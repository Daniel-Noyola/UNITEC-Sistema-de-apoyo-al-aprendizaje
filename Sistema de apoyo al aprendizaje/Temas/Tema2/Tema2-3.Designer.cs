namespace Sistema_de_apoyo_al_aprendizaje.Temas.Tema2
{
    partial class Tema2_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tema2_3));
            label6 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            BtnAnterior = new Button();
            BtnTest = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.Location = new Point(21, 89);
            label6.Name = "label6";
            label6.Size = new Size(529, 63);
            label6.TabIndex = 14;
            label6.Text = resources.GetString("label6.Text");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 45);
            label3.Name = "label3";
            label3.Size = new Size(241, 30);
            label3.TabIndex = 13;
            label3.Text = "Estrategia y Simulación\n";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(583, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(230, 223);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(224, 181);
            button1.Name = "button1";
            button1.Size = new Size(134, 61);
            button1.TabIndex = 20;
            button1.Text = "Menu principal";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BtnAnterior
            // 
            BtnAnterior.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAnterior.Location = new Point(31, 181);
            BtnAnterior.Name = "BtnAnterior";
            BtnAnterior.Size = new Size(134, 61);
            BtnAnterior.TabIndex = 19;
            BtnAnterior.Text = "Anterior";
            BtnAnterior.UseVisualStyleBackColor = true;
            BtnAnterior.Click += BtnAnterior_Click;
            // 
            // BtnTest
            // 
            BtnTest.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnTest.Location = new Point(416, 181);
            BtnTest.Name = "BtnTest";
            BtnTest.Size = new Size(134, 61);
            BtnTest.TabIndex = 18;
            BtnTest.Text = "Ir al test";
            BtnTest.UseVisualStyleBackColor = true;
            BtnTest.Click += BtnTest_Click;
            // 
            // Tema2_3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 289);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(BtnAnterior);
            Controls.Add(BtnTest);
            Controls.Add(label6);
            Controls.Add(label3);
            Name = "Tema2_3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Géneros de videojuegos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label3;
        private PictureBox pictureBox1;
        private Button button1;
        private Button BtnAnterior;
        private Button BtnTest;
    }
}