using System;
using System.Windows.Forms;

namespace Spartak_Project
{
    public partial class FormClients : Form
    {
        public FormClients()
        {
            InitializeComponent();
            ShowClients();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text != "" && textBoxLastName.Text != "" && textBoxMiddleName.Text != "" && textBoxPhone.Text != "")
            {
                ClientsSet clientsSet = new ClientsSet();
                clientsSet.FirstName = textBoxFirstName.Text;
                clientsSet.MiddleName = textBoxMiddleName.Text;
                clientsSet.LastName = textBoxLastName.Text;
                clientsSet.Phone = textBoxPhone.Text;
                clientsSet.Email = textBoxEmail.Text;
                Program.Spartak_Project.ClientsSet.Add(clientsSet);
                Program.Spartak_Project.SaveChanges();
                ShowClients();
            }
            else { MessageBox.Show("Поля ФИО и Телефон должны быть обязательно заполнены!","Ошибка!",MessageBoxButtons.OK,MessageBoxIcon.Warning); }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewClient.SelectedItems.Count == 1)
            {
                if (textBoxFirstName.Text != "" && textBoxLastName.Text != "" && textBoxMiddleName.Text != "" && textBoxPhone.Text != "")
                {
                    ClientsSet clientsSet = listViewClient.SelectedItems[0].Tag as ClientsSet;
                    clientsSet.FirstName = textBoxFirstName.Text;
                    clientsSet.MiddleName = textBoxMiddleName.Text;
                    clientsSet.LastName = textBoxLastName.Text;
                    clientsSet.Phone = textBoxPhone.Text;
                    clientsSet.Email = textBoxEmail.Text;
                    Program.Spartak_Project.SaveChanges();
                    ShowClients();
                }
                else { MessageBox.Show("Поля ФИО и Телефон должны быть обязательно заполнены!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewClient.SelectedItems.Count == 1)
                {
                    ClientsSet clientsSet = listViewClient.SelectedItems[0].Tag as ClientsSet;
                    Program.Spartak_Project.ClientsSet.Remove(clientsSet);
                    Program.Spartak_Project.SaveChanges();
                    ShowClients();
                }
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void ShowClients()
        {
            listViewClient.Items.Clear();
            foreach (ClientsSet clientsSet in Program.Spartak_Project.ClientsSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                        clientsSet.Id.ToString(), clientsSet.FirstName,clientsSet.MiddleName,
                        clientsSet.LastName,clientsSet.Phone,clientsSet.Email
                    }
                    );
                item.Tag = clientsSet;
                listViewClient.Items.Add(item);
            }
            listViewClient.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listViewClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewClient.SelectedItems.Count == 1)
            {
                ClientsSet clientsSet = listViewClient.SelectedItems[0].Tag as ClientsSet;
                textBoxFirstName.Text = clientsSet.FirstName;
                textBoxMiddleName.Text = clientsSet.MiddleName;
                textBoxLastName.Text = clientsSet.LastName;
                textBoxPhone.Text = clientsSet.Phone;
                textBoxEmail.Text = clientsSet.Email;

            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }
        }

        private void FormClients_Load(object sender, EventArgs e)
        {

        }
    }
}
