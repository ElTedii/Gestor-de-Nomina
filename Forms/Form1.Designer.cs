namespace Gestor_de_Nomina
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            panelLogo = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            btnHome = new Button();
            btnCatalogs = new Button();
            panelCatsSubMenu = new Panel();
            btnAccoPassCats = new Button();
            btnPerDedCats = new Button();
            btnFunsClasCats = new Button();
            btnDepartsCats = new Button();
            btnEmployCats = new Button();
            btnCompaniesCats = new Button();
            panelSideMenu = new Panel();
            btnHelp = new Button();
            btnSecurity = new Button();
            btnSettings = new Button();
            panelRepsSubMenu = new Panel();
            btnPerDedReps = new Button();
            btnHeadCounterReps = new Button();
            btnNomReps = new Button();
            btnReps = new Button();
            btnINFONAVIT = new Button();
            btnIMSS = new Button();
            btnCFDI = new Button();
            btnNomProcesses = new Button();
            panelPrincipal = new Panel();
            pictureBox1 = new PictureBox();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelCatsSubMenu.SuspendLayout();
            panelSideMenu.SuspendLayout();
            panelRepsSubMenu.SuspendLayout();
            panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(label1);
            panelLogo.Controls.Add(pictureBox2);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(233, 100);
            panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Verdana", 20F);
            label1.ForeColor = Color.FromArgb(203, 213, 225);
            label1.Location = new Point(85, 0);
            label1.Name = "label1";
            label1.Size = new Size(148, 100);
            label1.TabIndex = 1;
            label1.Text = "FinKuma";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(85, 100);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // btnHome
            // 
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.ForeColor = Color.FromArgb(241, 245, 249);
            btnHome.Location = new Point(0, 100);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(10, 0, 0, 0);
            btnHome.Size = new Size(233, 45);
            btnHome.TabIndex = 0;
            btnHome.Text = "Inicio";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // btnCatalogs
            // 
            btnCatalogs.Dock = DockStyle.Top;
            btnCatalogs.FlatAppearance.BorderSize = 0;
            btnCatalogs.FlatStyle = FlatStyle.Flat;
            btnCatalogs.ForeColor = Color.FromArgb(241, 245, 249);
            btnCatalogs.Location = new Point(0, 145);
            btnCatalogs.Name = "btnCatalogs";
            btnCatalogs.Padding = new Padding(10, 0, 0, 0);
            btnCatalogs.Size = new Size(233, 45);
            btnCatalogs.TabIndex = 1;
            btnCatalogs.Text = "Catálogos";
            btnCatalogs.TextAlign = ContentAlignment.MiddleLeft;
            btnCatalogs.UseVisualStyleBackColor = true;
            btnCatalogs.Click += btnCatalogs_Click;
            // 
            // panelCatsSubMenu
            // 
            panelCatsSubMenu.BackColor = Color.FromArgb(39, 52, 79);
            panelCatsSubMenu.Controls.Add(btnAccoPassCats);
            panelCatsSubMenu.Controls.Add(btnPerDedCats);
            panelCatsSubMenu.Controls.Add(btnFunsClasCats);
            panelCatsSubMenu.Controls.Add(btnDepartsCats);
            panelCatsSubMenu.Controls.Add(btnEmployCats);
            panelCatsSubMenu.Controls.Add(btnCompaniesCats);
            panelCatsSubMenu.Dock = DockStyle.Top;
            panelCatsSubMenu.Location = new Point(0, 190);
            panelCatsSubMenu.Name = "panelCatsSubMenu";
            panelCatsSubMenu.Size = new Size(233, 242);
            panelCatsSubMenu.TabIndex = 1;
            // 
            // btnAccoPassCats
            // 
            btnAccoPassCats.Dock = DockStyle.Top;
            btnAccoPassCats.FlatAppearance.BorderSize = 0;
            btnAccoPassCats.FlatStyle = FlatStyle.Flat;
            btnAccoPassCats.ForeColor = Color.FromArgb(226, 232, 240);
            btnAccoPassCats.Location = new Point(0, 200);
            btnAccoPassCats.Name = "btnAccoPassCats";
            btnAccoPassCats.Padding = new Padding(35, 0, 0, 0);
            btnAccoPassCats.Size = new Size(233, 40);
            btnAccoPassCats.TabIndex = 7;
            btnAccoPassCats.Text = "Cuentas y Claves";
            btnAccoPassCats.TextAlign = ContentAlignment.MiddleLeft;
            btnAccoPassCats.UseVisualStyleBackColor = true;
            btnAccoPassCats.Click += btnAccoPassCats_Click;
            // 
            // btnPerDedCats
            // 
            btnPerDedCats.Dock = DockStyle.Top;
            btnPerDedCats.FlatAppearance.BorderSize = 0;
            btnPerDedCats.FlatStyle = FlatStyle.Flat;
            btnPerDedCats.ForeColor = Color.FromArgb(226, 232, 240);
            btnPerDedCats.Location = new Point(0, 160);
            btnPerDedCats.Name = "btnPerDedCats";
            btnPerDedCats.Padding = new Padding(35, 0, 0, 0);
            btnPerDedCats.Size = new Size(233, 40);
            btnPerDedCats.TabIndex = 6;
            btnPerDedCats.Text = "Percepciones/Deducciones";
            btnPerDedCats.TextAlign = ContentAlignment.MiddleLeft;
            btnPerDedCats.UseVisualStyleBackColor = true;
            btnPerDedCats.Click += btnPerDedCats_Click;
            // 
            // btnFunsClasCats
            // 
            btnFunsClasCats.Dock = DockStyle.Top;
            btnFunsClasCats.FlatAppearance.BorderSize = 0;
            btnFunsClasCats.FlatStyle = FlatStyle.Flat;
            btnFunsClasCats.ForeColor = Color.FromArgb(226, 232, 240);
            btnFunsClasCats.Location = new Point(0, 120);
            btnFunsClasCats.Name = "btnFunsClasCats";
            btnFunsClasCats.Padding = new Padding(35, 0, 0, 0);
            btnFunsClasCats.Size = new Size(233, 40);
            btnFunsClasCats.TabIndex = 5;
            btnFunsClasCats.Text = "Funciones y Clasificación";
            btnFunsClasCats.TextAlign = ContentAlignment.MiddleLeft;
            btnFunsClasCats.UseVisualStyleBackColor = true;
            btnFunsClasCats.Click += btnFunsClasCats_Click;
            // 
            // btnDepartsCats
            // 
            btnDepartsCats.Dock = DockStyle.Top;
            btnDepartsCats.FlatAppearance.BorderSize = 0;
            btnDepartsCats.FlatStyle = FlatStyle.Flat;
            btnDepartsCats.ForeColor = Color.FromArgb(226, 232, 240);
            btnDepartsCats.Location = new Point(0, 80);
            btnDepartsCats.Name = "btnDepartsCats";
            btnDepartsCats.Padding = new Padding(35, 0, 0, 0);
            btnDepartsCats.Size = new Size(233, 40);
            btnDepartsCats.TabIndex = 4;
            btnDepartsCats.Text = "Departamentos";
            btnDepartsCats.TextAlign = ContentAlignment.MiddleLeft;
            btnDepartsCats.UseVisualStyleBackColor = true;
            btnDepartsCats.Click += btnDepartsCats_Click;
            // 
            // btnEmployCats
            // 
            btnEmployCats.Dock = DockStyle.Top;
            btnEmployCats.FlatAppearance.BorderSize = 0;
            btnEmployCats.FlatStyle = FlatStyle.Flat;
            btnEmployCats.ForeColor = Color.FromArgb(226, 232, 240);
            btnEmployCats.Location = new Point(0, 40);
            btnEmployCats.Name = "btnEmployCats";
            btnEmployCats.Padding = new Padding(35, 0, 0, 0);
            btnEmployCats.Size = new Size(233, 40);
            btnEmployCats.TabIndex = 3;
            btnEmployCats.Text = "Empleados";
            btnEmployCats.TextAlign = ContentAlignment.MiddleLeft;
            btnEmployCats.UseVisualStyleBackColor = true;
            btnEmployCats.Click += btnEmployCats_Click;
            // 
            // btnCompaniesCats
            // 
            btnCompaniesCats.Dock = DockStyle.Top;
            btnCompaniesCats.FlatAppearance.BorderSize = 0;
            btnCompaniesCats.FlatStyle = FlatStyle.Flat;
            btnCompaniesCats.ForeColor = Color.FromArgb(226, 232, 240);
            btnCompaniesCats.Location = new Point(0, 0);
            btnCompaniesCats.Name = "btnCompaniesCats";
            btnCompaniesCats.Padding = new Padding(35, 0, 0, 0);
            btnCompaniesCats.Size = new Size(233, 40);
            btnCompaniesCats.TabIndex = 2;
            btnCompaniesCats.Text = "Empresas";
            btnCompaniesCats.TextAlign = ContentAlignment.MiddleLeft;
            btnCompaniesCats.UseVisualStyleBackColor = true;
            btnCompaniesCats.Click += btnCompaniesCats_Click;
            // 
            // panelSideMenu
            // 
            panelSideMenu.AutoScroll = true;
            panelSideMenu.BackColor = Color.FromArgb(15, 23, 42);
            panelSideMenu.Controls.Add(btnHelp);
            panelSideMenu.Controls.Add(btnSecurity);
            panelSideMenu.Controls.Add(btnSettings);
            panelSideMenu.Controls.Add(panelRepsSubMenu);
            panelSideMenu.Controls.Add(btnReps);
            panelSideMenu.Controls.Add(btnINFONAVIT);
            panelSideMenu.Controls.Add(btnIMSS);
            panelSideMenu.Controls.Add(btnCFDI);
            panelSideMenu.Controls.Add(btnNomProcesses);
            panelSideMenu.Controls.Add(panelCatsSubMenu);
            panelSideMenu.Controls.Add(btnCatalogs);
            panelSideMenu.Controls.Add(btnHome);
            panelSideMenu.Controls.Add(panelLogo);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(250, 561);
            panelSideMenu.TabIndex = 0;
            // 
            // btnHelp
            // 
            btnHelp.Dock = DockStyle.Top;
            btnHelp.FlatAppearance.BorderSize = 0;
            btnHelp.FlatStyle = FlatStyle.Flat;
            btnHelp.ForeColor = Color.FromArgb(241, 245, 249);
            btnHelp.Location = new Point(0, 868);
            btnHelp.Name = "btnHelp";
            btnHelp.Padding = new Padding(10, 0, 0, 0);
            btnHelp.Size = new Size(233, 45);
            btnHelp.TabIndex = 10;
            btnHelp.Text = "Ayuda";
            btnHelp.TextAlign = ContentAlignment.MiddleLeft;
            btnHelp.UseVisualStyleBackColor = true;
            btnHelp.Click += btnHelp_Click;
            // 
            // btnSecurity
            // 
            btnSecurity.Dock = DockStyle.Top;
            btnSecurity.FlatAppearance.BorderSize = 0;
            btnSecurity.FlatStyle = FlatStyle.Flat;
            btnSecurity.ForeColor = Color.FromArgb(241, 245, 249);
            btnSecurity.Location = new Point(0, 823);
            btnSecurity.Name = "btnSecurity";
            btnSecurity.Padding = new Padding(10, 0, 0, 0);
            btnSecurity.Size = new Size(233, 45);
            btnSecurity.TabIndex = 9;
            btnSecurity.Text = "Seguridad";
            btnSecurity.TextAlign = ContentAlignment.MiddleLeft;
            btnSecurity.UseVisualStyleBackColor = true;
            btnSecurity.Click += btnSecurity_Click;
            // 
            // btnSettings
            // 
            btnSettings.Dock = DockStyle.Top;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.ForeColor = Color.FromArgb(241, 245, 249);
            btnSettings.Location = new Point(0, 778);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(10, 0, 0, 0);
            btnSettings.Size = new Size(233, 45);
            btnSettings.TabIndex = 8;
            btnSettings.Text = "Configuración";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // panelRepsSubMenu
            // 
            panelRepsSubMenu.BackColor = Color.FromArgb(39, 52, 79);
            panelRepsSubMenu.Controls.Add(btnPerDedReps);
            panelRepsSubMenu.Controls.Add(btnHeadCounterReps);
            panelRepsSubMenu.Controls.Add(btnNomReps);
            panelRepsSubMenu.Dock = DockStyle.Top;
            panelRepsSubMenu.Location = new Point(0, 657);
            panelRepsSubMenu.Name = "panelRepsSubMenu";
            panelRepsSubMenu.Size = new Size(233, 121);
            panelRepsSubMenu.TabIndex = 7;
            // 
            // btnPerDedReps
            // 
            btnPerDedReps.Dock = DockStyle.Top;
            btnPerDedReps.FlatAppearance.BorderSize = 0;
            btnPerDedReps.FlatStyle = FlatStyle.Flat;
            btnPerDedReps.ForeColor = Color.FromArgb(226, 232, 240);
            btnPerDedReps.Location = new Point(0, 80);
            btnPerDedReps.Name = "btnPerDedReps";
            btnPerDedReps.Padding = new Padding(35, 0, 0, 0);
            btnPerDedReps.Size = new Size(233, 40);
            btnPerDedReps.TabIndex = 4;
            btnPerDedReps.Text = "Percepciones/Deducciones";
            btnPerDedReps.TextAlign = ContentAlignment.MiddleLeft;
            btnPerDedReps.UseVisualStyleBackColor = true;
            btnPerDedReps.Click += btnPerDedReps_Click;
            // 
            // btnHeadCounterReps
            // 
            btnHeadCounterReps.Dock = DockStyle.Top;
            btnHeadCounterReps.FlatAppearance.BorderSize = 0;
            btnHeadCounterReps.FlatStyle = FlatStyle.Flat;
            btnHeadCounterReps.ForeColor = Color.FromArgb(226, 232, 240);
            btnHeadCounterReps.Location = new Point(0, 40);
            btnHeadCounterReps.Name = "btnHeadCounterReps";
            btnHeadCounterReps.Padding = new Padding(35, 0, 0, 0);
            btnHeadCounterReps.Size = new Size(233, 40);
            btnHeadCounterReps.TabIndex = 3;
            btnHeadCounterReps.Text = "HeadCounter";
            btnHeadCounterReps.TextAlign = ContentAlignment.MiddleLeft;
            btnHeadCounterReps.UseVisualStyleBackColor = true;
            btnHeadCounterReps.Click += btnHeadCounterReps_Click;
            // 
            // btnNomReps
            // 
            btnNomReps.Dock = DockStyle.Top;
            btnNomReps.FlatAppearance.BorderSize = 0;
            btnNomReps.FlatStyle = FlatStyle.Flat;
            btnNomReps.ForeColor = Color.FromArgb(226, 232, 240);
            btnNomReps.Location = new Point(0, 0);
            btnNomReps.Name = "btnNomReps";
            btnNomReps.Padding = new Padding(35, 0, 0, 0);
            btnNomReps.Size = new Size(233, 40);
            btnNomReps.TabIndex = 2;
            btnNomReps.Text = "Nómina";
            btnNomReps.TextAlign = ContentAlignment.MiddleLeft;
            btnNomReps.UseVisualStyleBackColor = true;
            btnNomReps.Click += btnNomReps_Click;
            // 
            // btnReps
            // 
            btnReps.Dock = DockStyle.Top;
            btnReps.FlatAppearance.BorderSize = 0;
            btnReps.FlatStyle = FlatStyle.Flat;
            btnReps.ForeColor = Color.FromArgb(241, 245, 249);
            btnReps.Location = new Point(0, 612);
            btnReps.Name = "btnReps";
            btnReps.Padding = new Padding(10, 0, 0, 0);
            btnReps.Size = new Size(233, 45);
            btnReps.TabIndex = 6;
            btnReps.Text = "Reportes";
            btnReps.TextAlign = ContentAlignment.MiddleLeft;
            btnReps.UseVisualStyleBackColor = true;
            btnReps.Click += btnReps_Click;
            // 
            // btnINFONAVIT
            // 
            btnINFONAVIT.Dock = DockStyle.Top;
            btnINFONAVIT.FlatAppearance.BorderSize = 0;
            btnINFONAVIT.FlatStyle = FlatStyle.Flat;
            btnINFONAVIT.ForeColor = Color.FromArgb(241, 245, 249);
            btnINFONAVIT.Location = new Point(0, 567);
            btnINFONAVIT.Name = "btnINFONAVIT";
            btnINFONAVIT.Padding = new Padding(10, 0, 0, 0);
            btnINFONAVIT.Size = new Size(233, 45);
            btnINFONAVIT.TabIndex = 5;
            btnINFONAVIT.Text = "INFONAVIT";
            btnINFONAVIT.TextAlign = ContentAlignment.MiddleLeft;
            btnINFONAVIT.UseVisualStyleBackColor = true;
            btnINFONAVIT.Click += btnINFONAVIT_Click;
            // 
            // btnIMSS
            // 
            btnIMSS.Dock = DockStyle.Top;
            btnIMSS.FlatAppearance.BorderSize = 0;
            btnIMSS.FlatStyle = FlatStyle.Flat;
            btnIMSS.ForeColor = Color.FromArgb(241, 245, 249);
            btnIMSS.Location = new Point(0, 522);
            btnIMSS.Name = "btnIMSS";
            btnIMSS.Padding = new Padding(10, 0, 0, 0);
            btnIMSS.Size = new Size(233, 45);
            btnIMSS.TabIndex = 4;
            btnIMSS.Text = "IMSS";
            btnIMSS.TextAlign = ContentAlignment.MiddleLeft;
            btnIMSS.UseVisualStyleBackColor = true;
            btnIMSS.Click += btnIMSS_Click;
            // 
            // btnCFDI
            // 
            btnCFDI.Dock = DockStyle.Top;
            btnCFDI.FlatAppearance.BorderSize = 0;
            btnCFDI.FlatStyle = FlatStyle.Flat;
            btnCFDI.ForeColor = Color.FromArgb(241, 245, 249);
            btnCFDI.Location = new Point(0, 477);
            btnCFDI.Name = "btnCFDI";
            btnCFDI.Padding = new Padding(10, 0, 0, 0);
            btnCFDI.Size = new Size(233, 45);
            btnCFDI.TabIndex = 3;
            btnCFDI.Text = "Timbrado / CFDI";
            btnCFDI.TextAlign = ContentAlignment.MiddleLeft;
            btnCFDI.UseVisualStyleBackColor = true;
            btnCFDI.Click += btnCFDI_Click;
            // 
            // btnNomProcesses
            // 
            btnNomProcesses.Dock = DockStyle.Top;
            btnNomProcesses.FlatAppearance.BorderSize = 0;
            btnNomProcesses.FlatStyle = FlatStyle.Flat;
            btnNomProcesses.ForeColor = Color.FromArgb(241, 245, 249);
            btnNomProcesses.Location = new Point(0, 432);
            btnNomProcesses.Name = "btnNomProcesses";
            btnNomProcesses.Padding = new Padding(10, 0, 0, 0);
            btnNomProcesses.Size = new Size(233, 45);
            btnNomProcesses.TabIndex = 2;
            btnNomProcesses.Text = "Procesos de Nómina";
            btnNomProcesses.TextAlign = ContentAlignment.MiddleLeft;
            btnNomProcesses.UseVisualStyleBackColor = true;
            btnNomProcesses.Click += btnNomProcesses_Click;
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FromArgb(30, 41, 59);
            panelPrincipal.Controls.Add(pictureBox1);
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(250, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(684, 561);
            panelPrincipal.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(229, 174);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(233, 216);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 561);
            Controls.Add(panelPrincipal);
            Controls.Add(panelSideMenu);
            Font = new Font("Verdana", 10F);
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(950, 600);
            Name = "frmPrincipal";
            Text = "FinKuma";
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelCatsSubMenu.ResumeLayout(false);
            panelSideMenu.ResumeLayout(false);
            panelRepsSubMenu.ResumeLayout(false);
            panelPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLogo;
        private Button btnHome;
        private Button btnCatalogs;
        private Panel panelCatsSubMenu;
        private Button btnDepartsCats;
        private Button btnEmployCats;
        private Button btnCompaniesCats;
        private Panel panelSideMenu;
        private Button btnAccoPassCats;
        private Button btnPerDedCats;
        private Button btnFunsClasCats;
        private Panel panelRepsSubMenu;
        private Button btnPerDedReps;
        private Button btnHeadCounterReps;
        private Button btnNomReps;
        private Button btnReps;
        private Button btnINFONAVIT;
        private Button btnIMSS;
        private Button btnCFDI;
        private Button btnNomProcesses;
        private Button btnHelp;
        private Button btnSecurity;
        private Button btnSettings;
        private Panel panelPrincipal;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
    }
}
