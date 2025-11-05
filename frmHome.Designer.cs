namespace Gestor_de_Nomina
{
    partial class frmHome
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(241, 245, 249);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(20, 0, 0, 0);
            label1.Size = new Size(684, 50);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido al Sistema de Nómina";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.Font = new Font("Verdana", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(203, 213, 225);
            label2.Location = new Point(0, 50);
            label2.Name = "label2";
            label2.Padding = new Padding(20, 0, 0, 0);
            label2.Size = new Size(684, 30);
            label2.TabIndex = 1;
            label2.Text = "Panel de Control Rápido";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.BackColor = Color.FromArgb(37, 43, 54);
            label3.Font = new Font("Verdana", 12F);
            label3.ForeColor = Color.FromArgb(203, 213, 225);
            label3.Location = new Point(12, 80);
            label3.Name = "label3";
            label3.Padding = new Padding(10, 10, 0, 0);
            label3.Size = new Size(179, 104);
            label3.TabIndex = 2;
            label3.Text = "Empleados Activos:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.BackColor = Color.FromArgb(37, 43, 54);
            label4.Font = new Font("Verdana", 12F);
            label4.ForeColor = Color.FromArgb(203, 213, 225);
            label4.Location = new Point(242, 80);
            label4.Name = "label4";
            label4.Padding = new Padding(10, 10, 0, 0);
            label4.Size = new Size(185, 104);
            label4.TabIndex = 3;
            label4.Text = "Costo Nómina (Mes)";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.BackColor = Color.FromArgb(37, 43, 54);
            label5.Font = new Font("Verdana", 12F);
            label5.ForeColor = Color.FromArgb(203, 213, 225);
            label5.Location = new Point(472, 80);
            label5.Name = "label5";
            label5.Padding = new Padding(10, 10, 0, 0);
            label5.Size = new Size(189, 104);
            label5.TabIndex = 4;
            label5.Text = "Percepciones Totales";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(37, 43, 54);
            label6.Font = new Font("Verdana", 15F);
            label6.Location = new Point(12, 141);
            label6.Name = "label6";
            label6.Padding = new Padding(20, 0, 0, 0);
            label6.Size = new Size(71, 25);
            label6.TabIndex = 5;
            label6.Text = "128";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(37, 43, 54);
            label7.Font = new Font("Verdana", 15F);
            label7.Location = new Point(242, 141);
            label7.Name = "label7";
            label7.Padding = new Padding(20, 0, 0, 0);
            label7.Size = new Size(163, 25);
            label7.TabIndex = 6;
            label7.Text = "$432,000.00";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(37, 43, 54);
            label8.Font = new Font("Verdana", 15F);
            label8.Location = new Point(472, 141);
            label8.Name = "label8";
            label8.Padding = new Padding(20, 0, 0, 0);
            label8.Size = new Size(150, 25);
            label8.TabIndex = 7;
            label8.Text = "$78,400.00";
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(30, 41, 59);
            ClientSize = new Size(684, 561);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(241, 245, 249);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmHome";
            Text = "frmHome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}