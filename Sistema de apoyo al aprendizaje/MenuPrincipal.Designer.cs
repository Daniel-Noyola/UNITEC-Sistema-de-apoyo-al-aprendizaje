namespace Sistema_de_apoyo_al_aprendizaje
{
    partial class MenuPrincipal
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            BtnCalificacionFinal = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(61, 296);
            button1.Name = "button1";
            button1.Size = new Size(153, 54);
            button1.TabIndex = 0;
            button1.Text = "Tema 1: Historia de los Videojuegos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(326, 296);
            button2.Name = "button2";
            button2.Size = new Size(135, 54);
            button2.TabIndex = 1;
            button2.Text = "Tema 2: Géneros de Videojuegos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(565, 296);
            button3.Name = "button3";
            button3.Size = new Size(141, 54);
            button3.TabIndex = 2;
            button3.Text = "Tema 3: Desarrollo y Diseño de Videojuegos";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(51, 97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(177, 171);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(308, 97);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(177, 171);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(549, 97);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(177, 171);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // BtnCalificacionFinal
            // 
            BtnCalificacionFinal.Location = new Point(326, 381);
            BtnCalificacionFinal.Name = "BtnCalificacionFinal";
            BtnCalificacionFinal.Size = new Size(135, 57);
            BtnCalificacionFinal.TabIndex = 6;
            BtnCalificacionFinal.Text = "Ver calificación final";
            BtnCalificacionFinal.UseVisualStyleBackColor = true;
            BtnCalificacionFinal.Click += BtnCalificacionFinal_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnCalificacionFinal);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tests Videojuegos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        public Button BtnCalificacionFinal;
    }
}
