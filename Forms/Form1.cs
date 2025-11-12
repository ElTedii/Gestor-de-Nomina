namespace Gestor_de_Nomina
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            customizeDesign();
            openChildForm(new frmHome());
        }

        private void customizeDesign()
        {
            panelCatsSubMenu.Visible = false;
            panelRepsSubMenu.Visible = false;
            //..
        }

        private void hideSubMenu()
        {
            if (panelCatsSubMenu.Visible == true)
                panelCatsSubMenu.Visible = false;
            if (panelRepsSubMenu.Visible == true)
                panelRepsSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

            openChildForm(new frmHome());
            hideSubMenu();
        }

        private void btnCatalogs_Click(object sender, EventArgs e)
        {
            showSubMenu(panelCatsSubMenu);
        }

        private void btnCompaniesCats_Click(object sender, EventArgs e)
        {
            openChildForm(new frmCompanies());
            hideSubMenu();
        }

        private void btnEmployCats_Click(object sender, EventArgs e)
        {
            openChildForm(new frmEmployeesCat());
            hideSubMenu();
        }

        private void btnDepartsCats_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDepartsCat());
            hideSubMenu();
        }

        private void btnFunsClasCats_Click(object sender, EventArgs e)
        {
            openChildForm(new frmPuestosCat());
            hideSubMenu();
        }

        private void btnPerDedCats_Click(object sender, EventArgs e)
        {
            openChildForm(new frmPercepDedCat());
            hideSubMenu();
        }

        private void btnAccoPassCats_Click(object sender, EventArgs e)
        {
            openChildForm(new frmAccountsPass());
            hideSubMenu();
        }

        private void btnNomProcesses_Click(object sender, EventArgs e)
        {
            openChildForm(new frmProccesesNom());
            hideSubMenu();
        }

        private void btnCFDI_Click(object sender, EventArgs e)
        {
            openChildForm(new frmCFDI());
            hideSubMenu();
        }

        private void btnIMSS_Click(object sender, EventArgs e)
        {
            openChildForm(new frmIMSS());
            hideSubMenu();
        }

        private void btnINFONAVIT_Click(object sender, EventArgs e)
        {
            openChildForm(new frmINFONAVIT());
            hideSubMenu();
        }

        private void btnReps_Click(object sender, EventArgs e)
        {
            showSubMenu(panelRepsSubMenu);
        }

        private void btnNomReps_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnHeadCounterReps_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnPerDedReps_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnSecurity_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(childForm);
            panelPrincipal.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}