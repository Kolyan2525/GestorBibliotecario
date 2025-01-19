namespace biblioteca
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            UserText = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            asdfToolStripMenuItem = new ToolStripMenuItem();
            UsernameLable = new Label();
            Password = new Label();
            PasswordText = new TextBox();
            signUpBut = new Button();
            label2 = new Label();
            label1 = new Label();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(350, 340);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(139, 29);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UserText
            // 
            UserText.Location = new Point(350, 228);
            UserText.Margin = new Padding(3, 2, 3, 2);
            UserText.Name = "UserText";
            UserText.Size = new Size(139, 23);
            UserText.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { asdfToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(97, 26);
            // 
            // asdfToolStripMenuItem
            // 
            asdfToolStripMenuItem.Name = "asdfToolStripMenuItem";
            asdfToolStripMenuItem.Size = new Size(96, 22);
            asdfToolStripMenuItem.Text = "asdf";
            // 
            // UsernameLable
            // 
            UsernameLable.AutoSize = true;
            UsernameLable.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UsernameLable.Location = new Point(350, 198);
            UsernameLable.Name = "UsernameLable";
            UsernameLable.Size = new Size(117, 28);
            UsernameLable.TabIndex = 2;
            UsernameLable.Text = "ID o Correo";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Password.Location = new Point(353, 269);
            Password.Name = "Password";
            Password.Size = new Size(114, 28);
            Password.TabIndex = 3;
            Password.Text = "Contraseña";
            // 
            // PasswordText
            // 
            PasswordText.Location = new Point(350, 299);
            PasswordText.Margin = new Padding(3, 2, 3, 2);
            PasswordText.Name = "PasswordText";
            PasswordText.Size = new Size(139, 23);
            PasswordText.TabIndex = 4;
            // 
            // signUpBut
            // 
            signUpBut.Location = new Point(371, 448);
            signUpBut.Margin = new Padding(3, 2, 3, 2);
            signUpBut.Name = "signUpBut";
            signUpBut.Size = new Size(100, 27);
            signUpBut.TabIndex = 5;
            signUpBut.Text = "Sign up";
            signUpBut.UseVisualStyleBackColor = true;
            signUpBut.Click += signUpBut_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(318, 425);
            label2.Name = "label2";
            label2.Size = new Size(196, 21);
            label2.TabIndex = 7;
            label2.Text = "Don't have an account yet?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 69.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(135, 57);
            label1.Name = "label1";
            label1.Size = new Size(572, 104);
            label1.TabIndex = 8;
            label1.Text = "Biblioteca AL";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(866, 505);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(signUpBut);
            Controls.Add(PasswordText);
            Controls.Add(Password);
            Controls.Add(UsernameLable);
            Controls.Add(UserText);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Biblioteca AL";
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox UserText;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem asdfToolStripMenuItem;
        private Label UsernameLable;
        private Label Password;
        private TextBox PasswordText;
        private Button signUpBut;
        private Label label2;
        private Label label1;
    }
}
