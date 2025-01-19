namespace biblioteca
{
    partial class MainMenu
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
            label1 = new Label();
            catalogoBut = new Button();
            estadisticasBut = new Button();
            userBut = new Button();
            logOutBut = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 60F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(69, 34);
            label1.Name = "label1";
            label1.Size = new Size(572, 90);
            label1.TabIndex = 0;
            label1.Text = "Menu Principal";
            // 
            // catalogoBut
            // 
            catalogoBut.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            catalogoBut.Location = new Point(290, 157);
            catalogoBut.Margin = new Padding(3, 2, 3, 2);
            catalogoBut.Name = "catalogoBut";
            catalogoBut.Size = new Size(135, 72);
            catalogoBut.TabIndex = 1;
            catalogoBut.Text = "Catalogo";
            catalogoBut.UseVisualStyleBackColor = true;
            catalogoBut.Click += catalogoBut_Click;
            // 
            // estadisticasBut
            // 
            estadisticasBut.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            estadisticasBut.Location = new Point(56, 157);
            estadisticasBut.Margin = new Padding(3, 2, 3, 2);
            estadisticasBut.Name = "estadisticasBut";
            estadisticasBut.Size = new Size(191, 72);
            estadisticasBut.TabIndex = 2;
            estadisticasBut.Text = "Estadisticas";
            estadisticasBut.UseVisualStyleBackColor = true;
            estadisticasBut.Click += reservacionesBut_Click;
            // 
            // userBut
            // 
            userBut.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userBut.Location = new Point(462, 157);
            userBut.Margin = new Padding(3, 2, 3, 2);
            userBut.Name = "userBut";
            userBut.Size = new Size(188, 72);
            userBut.TabIndex = 3;
            userBut.Text = "Configuracion de Usuario";
            userBut.UseVisualStyleBackColor = true;
            userBut.Click += userBut_Click;
            // 
            // logOutBut
            // 
            logOutBut.Location = new Point(302, 275);
            logOutBut.Margin = new Padding(3, 2, 3, 2);
            logOutBut.Name = "logOutBut";
            logOutBut.Size = new Size(106, 34);
            logOutBut.TabIndex = 4;
            logOutBut.Text = "Log Out";
            logOutBut.UseVisualStyleBackColor = true;
            logOutBut.Click += logOutBut_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(700, 338);
            Controls.Add(logOutBut);
            Controls.Add(userBut);
            Controls.Add(estadisticasBut);
            Controls.Add(catalogoBut);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button catalogoBut;
        private Button estadisticasBut;
        private Button userBut;
        private Button logOutBut;
    }
}