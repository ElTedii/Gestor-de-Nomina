namespace Gestor_de_Nomina
{
    partial class frmIMSS
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
            panelCalNom = new Panel();
            btnTimb = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panelCalNom.SuspendLayout();
            SuspendLayout();
            // 
            // panelCalNom
            // 
            panelCalNom.BackColor = Color.FromArgb(39, 52, 79);
            panelCalNom.Controls.Add(btnTimb);
            panelCalNom.Controls.Add(label3);
            panelCalNom.Controls.Add(label2);
            panelCalNom.Dock = DockStyle.Top;
            panelCalNom.Location = new Point(0, 50);
            panelCalNom.Name = "panelCalNom";
            panelCalNom.Padding = new Padding(20, 10, 0, 0);
            panelCalNom.Size = new Size(684, 90);
            panelCalNom.TabIndex = 7;
            // 
            // btnTimb
            // 
            btnTimb.BackColor = Color.FromArgb(14, 165, 233);
            btnTimb.FlatAppearance.BorderSize = 0;
            btnTimb.FlatStyle = FlatStyle.Flat;
            btnTimb.Location = new Point(23, 53);
            btnTimb.Name = "btnTimb";
            btnTimb.Size = new Size(170, 23);
            btnTimb.TabIndex = 3;
            btnTimb.Text = "Generar Archivo IMSS";
            btnTimb.UseVisualStyleBackColor = false;
            btnTimb.Click += btnTimb_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(148, 163, 184);
            label3.Location = new Point(23, 27);
            label3.Name = "label3";
            label3.Size = new Size(292, 13);
            label3.TabIndex = 1;
            label3.Text = "Altas, bajas y cambios de salario para empleados";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 10);
            label2.Name = "label2";
            label2.Size = new Size(156, 17);
            label2.TabIndex = 0;
            label2.Text = "Generar Avisos IMSS";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Verdana", 15F);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(20, 10, 0, 0);
            label1.Size = new Size(684, 50);
            label1.TabIndex = 6;
            label1.Text = "IMSS - Avisos y Movimientos";
            // 
            // frmIMSS
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 41, 59);
            ClientSize = new Size(684, 561);
            Controls.Add(panelCalNom);
            Controls.Add(label1);
            Font = new Font("Verdana", 10F);
            ForeColor = Color.FromArgb(241, 245, 249);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmIMSS";
            Text = "frmIMSS";
            panelCalNom.ResumeLayout(false);
            panelCalNom.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCalNom;
        private Button btnTimb;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}