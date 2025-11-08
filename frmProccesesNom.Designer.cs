namespace Gestor_de_Nomina
{
    partial class frmProccesesNom
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
            panelCalNom = new Panel();
            btnCalcNom = new Button();
            cmbBoxMonthYear = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            btnOpPerDed = new Button();
            label5 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            label7 = new Label();
            label6 = new Label();
            panelCalNom.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Verdana", 15F);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(20, 10, 0, 0);
            label1.Size = new Size(684, 50);
            label1.TabIndex = 3;
            label1.Text = "Procesos de Nómina";
            // 
            // panelCalNom
            // 
            panelCalNom.BackColor = Color.FromArgb(39, 52, 79);
            panelCalNom.Controls.Add(btnCalcNom);
            panelCalNom.Controls.Add(cmbBoxMonthYear);
            panelCalNom.Controls.Add(label3);
            panelCalNom.Controls.Add(label2);
            panelCalNom.Dock = DockStyle.Top;
            panelCalNom.Location = new Point(0, 50);
            panelCalNom.Name = "panelCalNom";
            panelCalNom.Padding = new Padding(20, 10, 0, 0);
            panelCalNom.Size = new Size(684, 90);
            panelCalNom.TabIndex = 4;
            // 
            // btnCalcNom
            // 
            btnCalcNom.BackColor = Color.FromArgb(14, 165, 233);
            btnCalcNom.FlatAppearance.BorderSize = 0;
            btnCalcNom.FlatStyle = FlatStyle.Flat;
            btnCalcNom.Location = new Point(241, 53);
            btnCalcNom.Name = "btnCalcNom";
            btnCalcNom.Size = new Size(75, 23);
            btnCalcNom.TabIndex = 3;
            btnCalcNom.Text = "Calcular";
            btnCalcNom.UseVisualStyleBackColor = false;
            // 
            // cmbBoxMonthYear
            // 
            cmbBoxMonthYear.BackColor = Color.FromArgb(39, 52, 79);
            cmbBoxMonthYear.FlatStyle = FlatStyle.Flat;
            cmbBoxMonthYear.FormattingEnabled = true;
            cmbBoxMonthYear.Location = new Point(23, 52);
            cmbBoxMonthYear.Name = "cmbBoxMonthYear";
            cmbBoxMonthYear.Size = new Size(121, 24);
            cmbBoxMonthYear.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(148, 163, 184);
            label3.Location = new Point(23, 27);
            label3.Name = "label3";
            label3.Size = new Size(293, 13);
            label3.TabIndex = 1;
            label3.Text = "Selecciona periodo (mes/año) y ejecuta el cálculo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 10);
            label2.Name = "label2";
            label2.Size = new Size(136, 17);
            label2.TabIndex = 0;
            label2.Text = "Cálculo de Nómina";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(39, 52, 79);
            panel1.Controls.Add(btnOpPerDed);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(0, 190);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20, 10, 0, 0);
            panel1.Size = new Size(684, 90);
            panel1.TabIndex = 5;
            // 
            // btnOpPerDed
            // 
            btnOpPerDed.BackColor = Color.FromArgb(14, 165, 233);
            btnOpPerDed.FlatAppearance.BorderSize = 0;
            btnOpPerDed.FlatStyle = FlatStyle.Flat;
            btnOpPerDed.Location = new Point(23, 43);
            btnOpPerDed.Name = "btnOpPerDed";
            btnOpPerDed.Size = new Size(75, 23);
            btnOpPerDed.TabIndex = 4;
            btnOpPerDed.Text = "Abrir Captura";
            btnOpPerDed.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(148, 163, 184);
            label5.Location = new Point(23, 27);
            label5.Name = "label5";
            label5.Size = new Size(278, 13);
            label5.TabIndex = 4;
            label5.Text = "Aplicar importes por empleado o departamento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 10);
            label4.Name = "label4";
            label4.Size = new Size(287, 17);
            label4.TabIndex = 4;
            label4.Text = "Captura de Percepciones y Deducciones";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(39, 52, 79);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(0, 330);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(20, 10, 0, 0);
            panel2.Size = new Size(684, 90);
            panel2.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(14, 165, 233);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(23, 43);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Exportar CSV";
            button1.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 10);
            label7.Name = "label7";
            label7.Size = new Size(105, 17);
            label7.TabIndex = 7;
            label7.Text = "Exportar CSV";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(148, 163, 184);
            label6.Location = new Point(23, 27);
            label6.Name = "label6";
            label6.Size = new Size(432, 13);
            label6.TabIndex = 6;
            label6.Text = "Genera archivo con número, nombre, importe a depositar, banco y cuenta";
            // 
            // frmProccesesNom
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 41, 59);
            ClientSize = new Size(684, 561);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelCalNom);
            Controls.Add(label1);
            Font = new Font("Verdana", 10F);
            ForeColor = Color.FromArgb(241, 245, 249);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProccesesNom";
            Text = "frmProccesesNom";
            panelCalNom.ResumeLayout(false);
            panelCalNom.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panelCalNom;
        private Label label2;
        private ComboBox cmbBoxMonthYear;
        private Label label3;
        private Panel panel1;
        private Button btnCalcNom;
        private Panel panel2;
        private Label label5;
        private Label label4;
        private Button btnOpPerDed;
        private Button button1;
        private Label label7;
        private Label label6;
    }
}