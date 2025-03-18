namespace Sistema_de_apoyo_al_aprendizaje.Temas.Tema3
{
    partial class Tema3_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tema3_2));
            BtnMenu = new Button();
            BtnAnterior = new Button();
            BtnSiguiente = new Button();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BtnMenu
            // 
            BtnMenu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnMenu.Location = new Point(224, 241);
            BtnMenu.Name = "BtnMenu";
            BtnMenu.Size = new Size(134, 61);
            BtnMenu.TabIndex = 23;
            BtnMenu.Text = "Menu principal";
            BtnMenu.UseVisualStyleBackColor = true;
            BtnMenu.Click += BtnMenu_Click;
            // 
            // BtnAnterior
            // 
            BtnAnterior.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAnterior.Location = new Point(21, 241);
            BtnAnterior.Name = "BtnAnterior";
            BtnAnterior.Size = new Size(134, 61);
            BtnAnterior.TabIndex = 22;
            BtnAnterior.Text = "Anterior";
            BtnAnterior.UseVisualStyleBackColor = true;
            BtnAnterior.Click += BtnAnterior_Click;
            // 
            // BtnSiguiente
            // 
            BtnSiguiente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSiguiente.Location = new Point(428, 241);
            BtnSiguiente.Name = "BtnSiguiente";
            BtnSiguiente.Size = new Size(134, 61);
            BtnSiguiente.TabIndex = 21;
            BtnSiguiente.Text = "Siguiente";
            BtnSiguiente.UseVisualStyleBackColor = true;
            BtnSiguiente.Click += BtnSiguiente_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(597, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(230, 223);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.Location = new Point(29, 124);
            label5.Name = "label5";
            label5.Size = new Size(545, 95);
            label5.TabIndex = 19;
            label5.Text = resources.GetString("label5.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 79);
            label2.Name = "label2";
            label2.Size = new Size(313, 30);
            label2.TabIndex = 18;
            label2.Text = "Diseño de Personajes y Niveles";
            // 
            // Tema3_2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 381);
            Controls.Add(BtnMenu);
            Controls.Add(BtnAnterior);
            Controls.Add(BtnSiguiente);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label2);
            Name = "Tema3_2";
            Text = "Tema3_2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnMenu;
        private Button BtnAnterior;
        private Button BtnSiguiente;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label2;
    }
}