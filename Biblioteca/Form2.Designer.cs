namespace biblioteca
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            databaseGeneratedAttributeBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            dataRowViewBindingSource = new BindingSource(components);
            button1 = new Button();
            DeleteBut = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            AdditionBut = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ISBNText = new TextBox();
            AutorText = new TextBox();
            GeneroText = new TextBox();
            CopiasText = new TextBox();
            AnoText = new TextBox();
            EditorialText = new TextBox();
            label7 = new Label();
            lable = new Label();
            TituloText = new TextBox();
            label8 = new Label();
            filtroText = new TextBox();
            disponibleBox = new CheckBox();
            returnBut = new Button();
            reservarBut = new Button();
            reservaText = new TextBox();
            label9 = new Label();
            devolucionBut = new Button();
            ((System.ComponentModel.ISupportInitialize)databaseGeneratedAttributeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataRowViewBindingSource).BeginInit();
            SuspendLayout();
            // 
            // databaseGeneratedAttributeBindingSource
            // 
            databaseGeneratedAttributeBindingSource.DataSource = typeof(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedAttribute);
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 158);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1074, 169);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataRowViewBindingSource
            // 
            dataRowViewBindingSource.DataSource = typeof(System.Data.DataRowView);
            // 
            // button1
            // 
            button1.Location = new Point(10, 132);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 2;
            button1.Text = "Refrescar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DeleteBut
            // 
            DeleteBut.Location = new Point(1001, 132);
            DeleteBut.Margin = new Padding(3, 2, 3, 2);
            DeleteBut.Name = "DeleteBut";
            DeleteBut.Size = new Size(82, 22);
            DeleteBut.TabIndex = 3;
            DeleteBut.Text = "Quitar libro";
            DeleteBut.UseVisualStyleBackColor = true;
            DeleteBut.Click += DeleteBut_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(885, 130);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(885, 112);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 5;
            label1.Text = "ISBN:";
            // 
            // AdditionBut
            // 
            AdditionBut.Location = new Point(843, 60);
            AdditionBut.Margin = new Padding(3, 2, 3, 2);
            AdditionBut.Name = "AdditionBut";
            AdditionBut.Size = new Size(115, 23);
            AdditionBut.TabIndex = 7;
            AdditionBut.Text = "Agregar libro";
            AdditionBut.UseVisualStyleBackColor = true;
            AdditionBut.Click += AdditionBut_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 43);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 8;
            label2.Text = "ISBN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(242, 43);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 9;
            label3.Text = "Autor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(358, 43);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 10;
            label4.Text = "Editorial";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(474, 43);
            label5.Name = "label5";
            label5.Size = new Size(110, 15);
            label5.TabIndex = 11;
            label5.Text = "Año de publicacion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(611, 43);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 12;
            label6.Text = "Genero";
            // 
            // ISBNText
            // 
            ISBNText.Location = new Point(10, 60);
            ISBNText.Margin = new Padding(3, 2, 3, 2);
            ISBNText.Name = "ISBNText";
            ISBNText.Size = new Size(110, 23);
            ISBNText.TabIndex = 13;
            // 
            // AutorText
            // 
            AutorText.Location = new Point(242, 60);
            AutorText.Margin = new Padding(3, 2, 3, 2);
            AutorText.Name = "AutorText";
            AutorText.Size = new Size(110, 23);
            AutorText.TabIndex = 14;
            // 
            // GeneroText
            // 
            GeneroText.Location = new Point(611, 60);
            GeneroText.Margin = new Padding(3, 2, 3, 2);
            GeneroText.Name = "GeneroText";
            GeneroText.Size = new Size(110, 23);
            GeneroText.TabIndex = 15;
            // 
            // CopiasText
            // 
            CopiasText.Location = new Point(727, 60);
            CopiasText.Margin = new Padding(3, 2, 3, 2);
            CopiasText.Name = "CopiasText";
            CopiasText.Size = new Size(110, 23);
            CopiasText.TabIndex = 16;
            // 
            // AnoText
            // 
            AnoText.Location = new Point(474, 60);
            AnoText.Margin = new Padding(3, 2, 3, 2);
            AnoText.Name = "AnoText";
            AnoText.Size = new Size(131, 23);
            AnoText.TabIndex = 17;
            // 
            // EditorialText
            // 
            EditorialText.Location = new Point(358, 60);
            EditorialText.Margin = new Padding(3, 2, 3, 2);
            EditorialText.Name = "EditorialText";
            EditorialText.Size = new Size(110, 23);
            EditorialText.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(727, 43);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 19;
            label7.Text = "Copias";
            // 
            // lable
            // 
            lable.AutoSize = true;
            lable.Location = new Point(126, 43);
            lable.Name = "lable";
            lable.Size = new Size(38, 15);
            lable.TabIndex = 20;
            lable.Text = "Titulo";
            // 
            // TituloText
            // 
            TituloText.Location = new Point(126, 60);
            TituloText.Margin = new Padding(3, 2, 3, 2);
            TituloText.Name = "TituloText";
            TituloText.Size = new Size(110, 23);
            TituloText.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(287, 135);
            label8.Name = "label8";
            label8.Size = new Size(104, 15);
            label8.TabIndex = 22;
            label8.Text = "Filtrar por genero: ";
            // 
            // filtroText
            // 
            filtroText.Location = new Point(397, 129);
            filtroText.Margin = new Padding(3, 2, 3, 2);
            filtroText.Name = "filtroText";
            filtroText.Size = new Size(110, 23);
            filtroText.TabIndex = 24;
            // 
            // disponibleBox
            // 
            disponibleBox.AutoSize = true;
            disponibleBox.Location = new Point(557, 135);
            disponibleBox.Margin = new Padding(3, 2, 3, 2);
            disponibleBox.Name = "disponibleBox";
            disponibleBox.Size = new Size(144, 19);
            disponibleBox.TabIndex = 25;
            disponibleBox.Text = "Solo libros disponibles";
            disponibleBox.UseVisualStyleBackColor = true;
            // 
            // returnBut
            // 
            returnBut.Location = new Point(12, 11);
            returnBut.Margin = new Padding(3, 2, 3, 2);
            returnBut.Name = "returnBut";
            returnBut.Size = new Size(82, 22);
            returnBut.TabIndex = 26;
            returnBut.Text = "Volver";
            returnBut.UseVisualStyleBackColor = true;
            returnBut.Click += returnBut_Click;
            // 
            // reservarBut
            // 
            reservarBut.Location = new Point(132, 102);
            reservarBut.Margin = new Padding(3, 2, 3, 2);
            reservarBut.Name = "reservarBut";
            reservarBut.Size = new Size(86, 23);
            reservarBut.TabIndex = 27;
            reservarBut.Text = "Reservar";
            reservarBut.UseVisualStyleBackColor = true;
            reservarBut.Click += reservarBut_Click;
            // 
            // reservaText
            // 
            reservaText.Location = new Point(10, 102);
            reservaText.Margin = new Padding(3, 2, 3, 2);
            reservaText.Name = "reservaText";
            reservaText.Size = new Size(110, 23);
            reservaText.TabIndex = 28;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 85);
            label9.Name = "label9";
            label9.Size = new Size(35, 15);
            label9.TabIndex = 29;
            label9.Text = "ISBN:";
            // 
            // devolucionBut
            // 
            devolucionBut.Location = new Point(981, 22);
            devolucionBut.Margin = new Padding(3, 2, 3, 2);
            devolucionBut.Name = "devolucionBut";
            devolucionBut.Size = new Size(82, 56);
            devolucionBut.TabIndex = 30;
            devolucionBut.Text = "Devolver Libro";
            devolucionBut.UseVisualStyleBackColor = true;
            devolucionBut.Click += devolucionBut_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1095, 338);
            Controls.Add(devolucionBut);
            Controls.Add(label9);
            Controls.Add(reservaText);
            Controls.Add(reservarBut);
            Controls.Add(returnBut);
            Controls.Add(disponibleBox);
            Controls.Add(filtroText);
            Controls.Add(label8);
            Controls.Add(TituloText);
            Controls.Add(lable);
            Controls.Add(label7);
            Controls.Add(EditorialText);
            Controls.Add(AnoText);
            Controls.Add(CopiasText);
            Controls.Add(GeneroText);
            Controls.Add(AutorText);
            Controls.Add(ISBNText);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(AdditionBut);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(DeleteBut);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Catalogo";
            ((System.ComponentModel.ISupportInitialize)databaseGeneratedAttributeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataRowViewBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource databaseGeneratedAttributeBindingSource;
        private Button tableGenerator;
        private DataGridView dataGridView1;
        private BindingSource dataRowViewBindingSource;
        private Button button1;
        private Button DeleteBut;
        private TextBox textBox1;
        private Label label1;
        private Button AdditionBut;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox ISBNText;
        private TextBox AutorText;
        private TextBox GeneroText;
        private TextBox CopiasText;
        private TextBox AnoText;
        private TextBox EditorialText;
        private Label label7;
        private Label lable;
        private TextBox TituloText;
        private Label label8;
        private TextBox filtroText;
        private CheckBox disponibleBox;
        private Button returnBut;
        private Button reservarBut;
        private TextBox reservaText;
        private Label label9;
        private Button devolucionBut;
    }
}