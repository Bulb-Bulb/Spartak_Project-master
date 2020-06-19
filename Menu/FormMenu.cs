using System;
using System.Windows.Forms;

namespace Spartak_Project
{
    public partial class FormMenu : Form
    {
        private FormAuthorization authorization;
        public FormMenu(FormAuthorization authorization)
        {
            InitializeComponent();
            this.authorization = authorization;
            if (FormAuthorization.users.type == "employee")
            {
                buttonOpenStaff.Enabled = false;
            }
        }
        private void buttonClients_Click(object sender, EventArgs e)
        {
            Form formClients = new FormClients();
            formClients.Show();
        }

        private void buttonOpenMaterials_Click(object sender, EventArgs e)
        {
            Form formMaterials = new FormMaterials();
            formMaterials.Show();
        }

        private void buttonOpenStaff_Click(object sender, EventArgs e)
        {
            Form formStaff = new FormStaff();
            formStaff.Show();
        }

        private void buttonOpenStorage_Click(object sender, EventArgs e)
        {
            Form formStorage = new FormStorage();
            formStorage.Show();
        }

        private void buttonOpenOrders_Click(object sender, EventArgs e)
        {
            Form formOrders = new FormOrders();
            formOrders.Show();
        }

        private void FormMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            authorization.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
