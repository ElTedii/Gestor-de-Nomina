namespace Gestor_de_Nomina
{
    partial class frmEmployeesCat
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
            dataEmployes = new DataGridView();
            txtSearchEmploy = new TextBox();
            label1 = new Label();
            btnNew = new Button();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dataEmployes).BeginInit();
            SuspendLayout();
            // 
            // dataEmployes
            // 
            dataEmployes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataEmployes.BackgroundColor = Color.FromArgb(47, 59, 85);
            dataEmployes.BorderStyle = BorderStyle.None;
            dataEmployes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataEmployes.GridColor = Color.FromArgb(15, 23, 42);
            dataEmployes.Location = new Point(12, 78);
            dataEmployes.Name = "dataEmployes";
            dataEmployes.Size = new Size(660, 471);
            dataEmployes.TabIndex = 0;
            // 
            // txtSearchEmploy
            // 
            txtSearchEmploy.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearchEmploy.BackColor = Color.FromArgb(47, 59, 85);
            txtSearchEmploy.BorderStyle = BorderStyle.None;
            txtSearchEmploy.Font = new Font("Verdana", 13F);
            txtSearchEmploy.ForeColor = Color.FromArgb(226, 232, 240);
            txtSearchEmploy.Location = new Point(12, 49);
            txtSearchEmploy.Name = "txtSearchEmploy";
            txtSearchEmploy.PlaceholderText = "Buscar por nombre, RFS o NSS";
            txtSearchEmploy.Size = new Size(498, 22);
            txtSearchEmploy.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.Font = new Font("Verdana", 15F);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(20, 10, 0, 0);
            label1.Size = new Size(684, 50);
            label1.TabIndex = 2;
            label1.Text = "Datos Personales y Laborales";
            // 
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNew.BackColor = Color.FromArgb(139, 92, 246);
            btnNew.FlatAppearance.BorderSize = 0;
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.Location = new Point(516, 48);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 23);
            btnNew.TabIndex = 3;
            btnNew.Text = "Nuevo";
            btnNew.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.BackColor = Color.FromArgb(139, 92, 246);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Location = new Point(597, 48);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // frmEmployeesCat
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 41, 59);
            ClientSize = new Size(684, 561);
            Controls.Add(btnSearch);
            Controls.Add(btnNew);
            Controls.Add(label1);
            Controls.Add(txtSearchEmploy);
            Controls.Add(dataEmployes);
            Font = new Font("Verdana", 10F);
            ForeColor = Color.FromArgb(241, 245, 249);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmEmployeesCat";
            Text = "frmEmployeesCat";
            ((System.ComponentModel.ISupportInitialize)dataEmployes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataEmployes;
        private TextBox txtSearchEmploy;
        private Label label1;
        private Button btnNew;
        private Button btnSearch;
    }
}