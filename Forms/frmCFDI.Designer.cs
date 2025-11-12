namespace Gestor_de_Nomina
{
    partial class frmCFDI
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
            label3 = new Label();
            label2 = new Label();
            btnTimb = new Button();
            dataRecEmit = new DataGridView();
            panelCalNom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataRecEmit).BeginInit();
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
            label1.TabIndex = 4;
            label1.Text = "Timbrado / CFDI";
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
            panelCalNom.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(148, 163, 184);
            label3.Location = new Point(23, 37);
            label3.Name = "label3";
            label3.Size = new Size(400, 13);
            label3.TabIndex = 1;
            label3.Text = "Guarda UUID y metadatos. Integración real requiere certificado SAT.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 20);
            label2.Name = "label2";
            label2.Size = new Size(188, 17);
            label2.TabIndex = 0;
            label2.Text = "Emitir Recibos (Simulado)";
            // 
            // btnTimb
            // 
            btnTimb.BackColor = Color.FromArgb(14, 165, 233);
            btnTimb.FlatAppearance.BorderSize = 0;
            btnTimb.FlatStyle = FlatStyle.Flat;
            btnTimb.Location = new Point(23, 53);
            btnTimb.Name = "btnTimb";
            btnTimb.Size = new Size(130, 23);
            btnTimb.TabIndex = 3;
            btnTimb.Text = "Timbrar Recibos";
            btnTimb.UseVisualStyleBackColor = false;
            btnTimb.Click += btnTimb_Click;
            // 
            // dataRecEmit
            // 
            dataRecEmit.BackgroundColor = Color.FromArgb(47, 59, 85);
            dataRecEmit.BorderStyle = BorderStyle.None;
            dataRecEmit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataRecEmit.Dock = DockStyle.Fill;
            dataRecEmit.GridColor = Color.FromArgb(15, 23, 42);
            dataRecEmit.Location = new Point(0, 140);
            dataRecEmit.Name = "dataRecEmit";
            dataRecEmit.Size = new Size(684, 421);
            dataRecEmit.TabIndex = 6;
            // 
            // frmCFDI
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 41, 59);
            ClientSize = new Size(684, 561);
            Controls.Add(dataRecEmit);
            Controls.Add(panelCalNom);
            Controls.Add(label1);
            Font = new Font("Verdana", 10F);
            ForeColor = Color.FromArgb(241, 245, 249);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCFDI";
            Text = "frmCFDI";
            panelCalNom.ResumeLayout(false);
            panelCalNom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataRecEmit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panelCalNom;
        private Label label3;
        private Label label2;
        private Button btnTimb;
        private DataGridView dataRecEmit;
    }
}