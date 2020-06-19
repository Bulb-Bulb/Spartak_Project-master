using System;
using System.Windows.Forms;

namespace Spartak_Project
{
    public partial class FormOrders : Form
    {
        public FormOrders()
        {
            InitializeComponent();
            ShowClients();
            ShowStaff();
            ShowMaterials();
            ShowOrders();
            SetDate();
        }

        private void listViewOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewOrders.SelectedItems.Count == 1)
            {
                OrdersSet orders = listViewOrders.SelectedItems[0].Tag as OrdersSet;
                comboBoxMaterials.SelectedIndex = comboBoxMaterials.FindString(orders.IdNameMaterial.ToString());
                comboBoxClients.SelectedIndex = comboBoxClients.FindString(orders.IdClient.ToString());
                comboBoxStaff.SelectedIndex = comboBoxStaff.FindString(orders.IdStaff.ToString());
                textBoxDate.Text = orders.Date;
            }
            else
            {
                comboBoxMaterials.SelectedItem = null;
                comboBoxClients.SelectedItem = null;
                comboBoxStaff.SelectedItem = null;
                textBoxDate.Text = "";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxMaterials.SelectedItem != null && comboBoxStaff.SelectedItem != null && comboBoxClients.SelectedItem != null && textBoxDate.Text != "")
            {
                OrdersSet orders = new OrdersSet();
                orders.IdNameMaterial = Convert.ToInt32(comboBoxMaterials.SelectedItem.ToString().Split('.')[0]);
                orders.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                orders.IdStaff = Convert.ToInt32(comboBoxStaff.SelectedItem.ToString().Split('.')[0]);
                orders.Date = textBoxDate.Text;
                Program.Spartak_Project.OrdersSet.Add(orders);
                Program.Spartak_Project.SaveChanges();
                ShowOrders();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewOrders.SelectedItems.Count == 1)
            {
                if (comboBoxMaterials.SelectedItem != null && comboBoxStaff.SelectedItem != null && comboBoxClients.SelectedItem != null && textBoxDate.Text != "")
                {
                    OrdersSet orders = listViewOrders.SelectedItems[0].Tag as OrdersSet;
                    orders.IdNameMaterial = Convert.ToInt32(comboBoxMaterials.SelectedItem.ToString().Split('.')[0]);
                    orders.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                    orders.IdStaff = Convert.ToInt32(comboBoxStaff.SelectedItem.ToString().Split('.')[0]);
                    orders.Date = textBoxDate.Text;
                    Program.Spartak_Project.SaveChanges();
                    ShowOrders();
                }
                else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewOrders.SelectedItems.Count == 1)
                {
                    OrdersSet orders = listViewOrders.SelectedItems[0].Tag as OrdersSet;
                    Program.Spartak_Project.OrdersSet.Remove(orders);
                    Program.Spartak_Project.SaveChanges();
                    ShowOrders();
                }
                comboBoxMaterials.SelectedItem = null;
                comboBoxClients.SelectedItem = null;
                comboBoxStaff.SelectedItem = null;
                textBoxDate.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void ShowMaterials()
        {
            comboBoxMaterials.Items.Clear();
            foreach (MaterialsSet materialsSet in Program.Spartak_Project.MaterialsSet)
            {
                string[] item = { materialsSet.Id.ToString() + ".", materialsSet.NameMaterial + " | Количество - ", materialsSet.Price.ToString() };
                comboBoxMaterials.Items.Add(string.Join(" ", item));
            }
        }
        void ShowClients()
        {
            comboBoxClients.Items.Clear();
            foreach (ClientsSet clientsSet in Program.Spartak_Project.ClientsSet)
            {
                string[] item = { clientsSet.Id.ToString() + ".", clientsSet.FirstName, clientsSet.MiddleName, clientsSet.LastName };

                comboBoxClients.Items.Add(string.Join(" ", item));
            }
        }
        void ShowStaff()
        {
            comboBoxStaff.Items.Clear();
            foreach (StaffSet staffSet in Program.Spartak_Project.StaffSet)
            {
                string[] item = { staffSet.Id.ToString() + ".", staffSet.FirstName, staffSet.MiddleName, staffSet.LastName };

                comboBoxStaff.Items.Add(string.Join(" ", item));
            }
        }
        void ShowOrders()
        {
            listViewOrders.Items.Clear();
            foreach (OrdersSet orders in Program.Spartak_Project.OrdersSet)
            {
                ListViewItem item = new ListViewItem(new string[] {

                   orders.MaterialsSet.NameMaterial,
                   orders.MaterialsSet.Price.ToString(),
                   orders.ClientsSet.LastName+" "+orders.ClientsSet.FirstName+" "+orders.ClientsSet.MiddleName,
                   orders.StaffSet.LastName+" "+orders.StaffSet.FirstName+" "+orders.StaffSet.MiddleName,
                   orders.Date
                });
                item.Tag = orders;
                listViewOrders.Items.Add(item);
            }
            listViewOrders.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        void SetDate()
        {
            if (textBoxDate.Text == "")
            {
                textBoxDate.Text = DateTime.Now.ToString("dd.MM.yyyy");
            }
        }

        private void FormOrders_Load(object sender, EventArgs e)
        {

        }
    }
}
