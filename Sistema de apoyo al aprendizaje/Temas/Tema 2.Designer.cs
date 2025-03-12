namespace Sistema_de_apoyo_al_aprendizaje
{
    partial class Tema_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tema_2));
            button1 = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            BtnRegresar = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(548, 706);
            button1.Name = "button1";
            button1.Size = new Size(134, 61);
            button1.TabIndex = 13;
            button1.Text = "Ir al Test";
            button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.Location = new Point(82, 569);
            label6.Name = "label6";
            label6.Size = new Size(636, 160);
            label6.TabIndex = 12;
            label6.Text = resources.GetString("label6.Text");
            // 
            // label5
            // 
            label5.Location = new Point(82, 301);
            label5.Name = "label5";
            label5.Size = new Size(636, 160);
            label5.TabIndex = 11;
            label5.Text = resources.GetString("label5.Text");
            // 
            // label4
            // 
            label4.Location = new Point(82, 111);
            label4.Name = "label4";
            label4.Size = new Size(623, 120);
            label4.TabIndex = 10;
            label4.Text = resources.GetString("label4.Text");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(82, 525);
            label3.Name = "label3";
            label3.Size = new Size(241, 30);
            label3.TabIndex = 9;
            label3.Text = "Estrategia y Simulación\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(95, 264);
            label2.Name = "label2";
            label2.Size = new Size(168, 30);
            label2.TabIndex = 8;
            label2.Text = "RPG y Aventura";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(82, 70);
            label1.Name = "label1";
            label1.Size = new Size(181, 30);
            label1.TabIndex = 7;
            label1.Text = "Shooter y Acción";
            // 
            // BtnRegresar
            // 
            BtnRegresar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRegresar.Location = new Point(95, 706);
            BtnRegresar.Name = "BtnRegresar";
            BtnRegresar.Size = new Size(134, 61);
            BtnRegresar.TabIndex = 14;
            BtnRegresar.Text = "Regresar";
            BtnRegresar.UseVisualStyleBackColor = true;
            BtnRegresar.Click += BtnRegresar_Click;
            // 
            // Tema_2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 836);
            Controls.Add(BtnRegresar);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Tema_2";
            Text = "Tema_2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button BtnRegresar;
    }
}