namespace biblioteca
{
    partial class Estadisticas
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
            label2 = new Label();
            dataLibros = new DataGridView();
            dataUsuarios = new DataGridView();
            volverBut = new Button();
            ((System.ComponentModel.ISupportInitialize)dataLibros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataUsuarios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(69, 53);
            label1.Name = "label1";
            label1.Size = new Size(237, 30);
            label1.TabIndex = 0;
            label1.Text = "Usuarios mas logeados";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(400, 53);
            label2.Name = "label2";
            label2.Size = new Size(227, 30);
            label2.TabIndex = 1;
            label2.Text = "Libros mas reservados";
            // 
            // dataLibros
            // 
            dataLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataLibros.Location = new Point(385, 85);
            dataLibros.Margin = new Padding(3, 2, 3, 2);
            dataLibros.Name = "dataLibros";
            dataLibros.RowHeadersWidth = 51;
            dataLibros.Size = new Size(253, 224);
            dataLibros.TabIndex = 2;
            // 
            // dataUsuarios
            // 
            dataUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataUsuarios.Location = new Point(62, 85);
            dataUsuarios.Margin = new Padding(3, 2, 3, 2);
            dataUsuarios.Name = "dataUsuarios";
            dataUsuarios.RowHeadersWidth = 51;
            dataUsuarios.Size = new Size(244, 224);
            dataUsuarios.TabIndex = 3;
            // 
            // volverBut
            // 
            volverBut.Location = new Point(12, 11);
            volverBut.Margin = new Padding(3, 2, 3, 2);
            volverBut.Name = "volverBut";
            volverBut.Size = new Size(79, 26);
            volverBut.TabIndex = 4;
            volverBut.Text = "Volver";
            volverBut.UseVisualStyleBackColor = true;
            volverBut.Click += volverBut_Click;
            // 
            // Estadisticas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(700, 338);
            Controls.Add(volverBut);
            Controls.Add(dataUsuarios);
            Controls.Add(dataLibros);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Estadisticas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estadisticas";
            Load += Estadisticas_Load;
            ((System.ComponentModel.ISupportInitialize)dataLibros).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dataLibros;
        private DataGridView dataUsuarios;
        private Button volverBut;
    }
}