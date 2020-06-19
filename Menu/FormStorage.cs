using System;
using System.Windows.Forms;

namespace Spartak_Project
{
    public partial class FormStorage : Form
    {
        public FormStorage()
        {
            InitializeComponent();
            ShowMaterials();
            ShowStorage();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxMaterials.SelectedItem != null && textBoxLocation.Text != "")
            {
                StorageSet storage = new StorageSet();
                storage.idNameMaterial = Convert.ToInt32(comboBoxMaterials.SelectedItem.ToString().Split('.')[0]);
                storage.Location = textBoxLocation.Text;
                Program.Spartak_Project.StorageSet.Add(storage);
                Program.Spartak_Project.SaveChanges();
                ShowStorage();
            }
            else MessageBox.Show("Выберите данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewStorage.SelectedItems.Count == 1)
                {
                    StorageSet storage = listViewStorage.SelectedItems[0].Tag as StorageSet;
                    Program.Spartak_Project.StorageSet.Remove(storage);
                    Program.Spartak_Project.SaveChanges();
                    ShowStorage();
                }
                comboBoxMaterials.SelectedItem = null;
                textBoxLocation.Text = "";
            }


            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewStorage.SelectedItems.Count == 1)
            {
                if (comboBoxMaterials.SelectedItem != null && textBoxLocation.Text != "")
                {
                    StorageSet storage = listViewStorage.SelectedItems[0].Tag as StorageSet;
                    storage.idNameMaterial = Convert.ToInt32(comboBoxMaterials.SelectedItem.ToString().Split('.')[0]);
                    storage.Location = textBoxLocation.Text;
                    Program.Spartak_Project.SaveChanges();
                    ShowStorage();
                }
            }
        }

        private void listViewStorage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewStorage.SelectedItems.Count == 1)
            {
                StorageSet storage = listViewStorage.SelectedItems[0].Tag as StorageSet;
                comboBoxMaterials.SelectedIndex = comboBoxMaterials.FindString(storage.idNameMaterial.ToString());
                textBoxLocation.Text = storage.Location;
            }
            else
            {
                comboBoxMaterials.SelectedItem = null;
                textBoxLocation.Text = "";
            }
        }
        void ShowMaterials()
        {
            comboBoxMaterials.Items.Clear();
            foreach (MaterialsSet materialsSet in Program.Spartak_Project.MaterialsSet)
            {
                string[] item = { materialsSet.Id.ToString() + ".", materialsSet.NameMaterial + " | Количество - ", materialsSet.Count.ToString() + " | Вес - ", materialsSet.Weight.ToString() };
                comboBoxMaterials.Items.Add(string.Join(" ", item));
            }
        }
        void ShowStorage()
        {
            listViewStorage.Items.Clear();
            foreach (StorageSet storage in Program.Spartak_Project.StorageSet)
            {
                 ListViewItem item = new ListViewItem(new string[]
                 {
                 storage.Id.ToString(), storage.MaterialsSet.NameMaterial,storage.MaterialsSet.Count.ToString() ,
                 storage.MaterialsSet.Weight.ToString(),
                 storage.Location
                 });
                 item.Tag = storage;
                 listViewStorage.Items.Add(item);
            }
        }

        private void FormStorage_Load(object sender, EventArgs e)
        {

        }
    }
}
