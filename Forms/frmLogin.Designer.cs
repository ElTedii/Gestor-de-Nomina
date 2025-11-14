namespace Gestor_de_Nomina.Forms
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnIngresar = new Button();
            txtPass = new TextBox();
            txtUsuario = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(725, 100);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Verdana", 20F);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(50, 25, 0, 0);
            label1.Size = new Size(179, 57);
            label1.TabIndex = 0;
            label1.Text = "Ingresar";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(262, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnIngresar);
            panel2.Controls.Add(txtPass);
            panel2.Controls.Add(txtUsuario);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(725, 420);
            panel2.TabIndex = 2;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(68, 94, 135);
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Location = new Point(262, 297);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(200, 23);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.FromArgb(68, 94, 135);
            txtPass.BorderStyle = BorderStyle.None;
            txtPass.Font = new Font("Verdana", 15F);
            txtPass.ForeColor = Color.FromArgb(241, 245, 249);
            txtPass.Location = new Point(262, 251);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.PlaceholderText = "Ingresa tu contraseña";
            txtPass.Size = new Size(200, 25);
            txtPass.TabIndex = 3;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(68, 94, 135);
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Verdana", 15F);
            txtUsuario.ForeColor = Color.FromArgb(241, 245, 249);
            txtUsuario.Location = new Point(262, 220);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Ingresa tu usuario";
            txtUsuario.Size = new Size(200, 25);
            txtUsuario.TabIndex = 2;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 41, 59);
            ClientSize = new Size(725, 520);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Verdana", 10F);
            ForeColor = Color.FromArgb(241, 245, 249);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private TextBox txtPass;
        private TextBox txtUsuario;
        private Button btnIngresar;
    }
}