namespace Sistema_de_apoyo_al_aprendizaje.Temas.Tema1
{
    partial class Tema1_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tema1_3));
            label6 = new Label();
            label3 = new Label();
            button1 = new Button();
            BtnAnterior = new Button();
            BtnTest = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.Location = new Point(12, 85);
            label6.Name = "label6";
            label6.Size = new Size(636, 98);
            label6.TabIndex = 7;
            label6.Text = resources.GetString("label6.Text");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 41);
            label3.Name = "label3";
            label3.Size = new Size(419, 30);
            label3.TabIndex = 6;
            label3.Text = "La Revolución del Gaming Online y Móvil";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(252, 203);
            button1.Name = "button1";
            button1.Size = new Size(134, 61);
            button1.TabIndex = 16;
            button1.Text = "Menu principal";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BtnAnterior
            // 
            BtnAnterior.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAnterior.Location = new Point(49, 203);
            BtnAnterior.Name = "BtnAnterior";
            BtnAnterior.Size = new Size(134, 61);
            BtnAnterior.TabIndex = 15;
            BtnAnterior.Text = "Anterior";
            BtnAnterior.UseVisualStyleBackColor = true;
            BtnAnterior.Click += BtnAnterior_Click;
            // 
            // BtnTest
            // 
            BtnTest.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnTest.Location = new Point(456, 203);
            BtnTest.Name = "BtnTest";
            BtnTest.Size = new Size(134, 61);
            BtnTest.TabIndex = 14;
            BtnTest.Text = "Ir al test";
            BtnTest.UseVisualStyleBackColor = true;
            BtnTest.Click += BtnTest_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(678, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(230, 223);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // Tema1_3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 302);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(BtnAnterior);
            Controls.Add(BtnTest);
            Controls.Add(label6);
            Controls.Add(label3);
            Name = "Tema1_3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tema 1:Historia de los Videojuegos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label3;
        private Button button1;
        private Button BtnAnterior;
        private Button BtnTest;
        private PictureBox pictureBox1;
    }
}