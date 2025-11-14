namespace Gestor_de_Nomina
{
    partial class frmCompanies
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            panelComp = new Panel();
            button1 = new Button();
            btnMod = new Button();
            btnSearch = new Button();
            btnNew = new Button();
            btnDelete = new Button();
            textBox1 = new TextBox();
            dGEmpresas = new DataGridView();
            panelComp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGEmpresas).BeginInit();
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
            label1.TabIndex = 7;
            label1.Text = "Empresas Registradas";
            // 
            // panelComp
            // 
            panelComp.BackColor = Color.FromArgb(39, 52, 79);
            panelComp.Controls.Add(button1);
            panelComp.Controls.Add(btnMod);
            panelComp.Controls.Add(btnSearch);
            panelComp.Controls.Add(btnNew);
            panelComp.Controls.Add(btnDelete);
            panelComp.Controls.Add(textBox1);
            panelComp.Dock = DockStyle.Top;
            panelComp.Location = new Point(0, 50);
            panelComp.Name = "panelComp";
            panelComp.Padding = new Padding(20, 0, 20, 0);
            panelComp.Size = new Size(684, 50);
            panelComp.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(30, 41, 59);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(262, 14);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "Refrescar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnMod
            // 
            btnMod.BackColor = Color.FromArgb(30, 41, 59);
            btnMod.FlatAppearance.BorderSize = 0;
            btnMod.FlatStyle = FlatStyle.Flat;
            btnMod.Location = new Point(505, 14);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(75, 23);
            btnMod.TabIndex = 12;
            btnMod.Text = "Modificar";
            btnMod.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(30, 41, 59);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Location = new Point(343, 14);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.FromArgb(30, 41, 59);
            btnNew.FlatAppearance.BorderSize = 0;
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.Location = new Point(424, 14);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 23);
            btnNew.TabIndex = 2;
            btnNew.Text = "Nuevo";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(30, 41, 59);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(586, 14);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(30, 41, 59);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(241, 245, 249);
            textBox1.Location = new Point(23, 17);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(233, 20);
            textBox1.TabIndex = 1;
            // 
            // dGEmpresas
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(47, 59, 85);
            dataGridViewCellStyle1.ForeColor = Color.Silver;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(40, 50, 80);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dGEmpresas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dGEmpresas.BackgroundColor = Color.FromArgb(47, 59, 85);
            dGEmpresas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGEmpresas.Dock = DockStyle.Fill;
            dGEmpresas.GridColor = Color.Gray;
            dGEmpresas.Location = new Point(0, 100);
            dGEmpresas.Name = "dGEmpresas";
            dGEmpresas.Size = new Size(684, 461);
            dGEmpresas.TabIndex = 10;
            // 
            // frmCompanies
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 41, 59);
            ClientSize = new Size(684, 561);
            Controls.Add(dGEmpresas);
            Controls.Add(panelComp);
            Controls.Add(label1);
            Font = new Font("Verdana", 10F);
            ForeColor = Color.FromArgb(241, 245, 249);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCompanies";
            Text = "frmCompanies";
            Load += frmCompanies_Load;
            panelComp.ResumeLayout(false);
            panelComp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dGEmpresas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panelComp;
        private TextBox textBox1;
        private Button btnSearch;
        private Button btnNew;
        private DataGridView dGEmpresas;
        private Button btnMod;
        private Button btnDelete;
        private Button button1;
    }
}