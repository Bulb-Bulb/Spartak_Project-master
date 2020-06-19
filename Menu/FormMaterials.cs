using System;
using System.Windows.Forms;

namespace Spartak_Project
{
    public partial class FormMaterials : Form
    {
        public FormMaterials()
        {
            InitializeComponent();
            ShowMaterials();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNameMaterial.Text != "" && textBoxPrice.Text != ""
                    && textBoxCount.Text != "" && textBoxWeight.Text != ""
                    && textBoxSupplier.Text != "")
                {
                    MaterialsSet materialsSet = new MaterialsSet();
                    materialsSet.NameMaterial = textBoxNameMaterial.Text;
                    materialsSet.Price = Convert.ToInt32(textBoxPrice.Text);
                    materialsSet.Count = Convert.ToInt32(textBoxCount.Text);
                    materialsSet.Weight = Convert.ToInt32(textBoxWeight.Text);
                    materialsSet.Supplier = textBoxSupplier.Text;
                    Program.Spartak_Project.MaterialsSet.Add(materialsSet);
                    Program.Spartak_Project.SaveChanges();
                    ShowMaterials();
                }

                else MessageBox.Show("Заполните все поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxNameMaterial.Text != "" && textBoxPrice.Text != ""
                && textBoxCount.Text != "" && textBoxWeight.Text != ""
                && textBoxSupplier.Text != "")
            {
                if (listViewMaterials.SelectedItems.Count == 1)
                {
                    MaterialsSet materialsSet = listViewMaterials.SelectedItems[0].Tag as MaterialsSet;
                    materialsSet.NameMaterial = textBoxNameMaterial.Text;
                    materialsSet.Price = Convert.ToInt32(textBoxPrice.Text);
                    materialsSet.Count = Convert.ToInt32(textBoxCount.Text);
                    materialsSet.Weight = Convert.ToInt32(textBoxWeight.Text);
                    materialsSet.Supplier = textBoxSupplier.Text;
                    Program.Spartak_Project.SaveChanges();
                    ShowMaterials();
                }
            }
            else MessageBox.Show("Заполните все поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewMaterials.SelectedItems.Count == 1)
                {
                    MaterialsSet materialsSet = listViewMaterials.SelectedItems[0].Tag as MaterialsSet;
                    Program.Spartak_Project.MaterialsSet.Remove(materialsSet);
                    Program.Spartak_Project.SaveChanges();
                    ShowMaterials();
                }
                textBoxNameMaterial.Text = "";
                textBoxPrice.Text = "";
                textBoxCount.Text = "";
                textBoxWeight.Text = "";
                textBoxSupplier.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewMaterials_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewMaterials.SelectedItems.Count == 1)
            {
                MaterialsSet materialsSet = listViewMaterials.SelectedItems[0].Tag as MaterialsSet;
                textBoxNameMaterial.Text = materialsSet.NameMaterial;
                textBoxPrice.Text = materialsSet.Price.ToString();
                textBoxCount.Text = materialsSet.Count.ToString();
                textBoxWeight.Text = materialsSet.Weight.ToString();
                textBoxSupplier.Text = materialsSet.Supplier;

            }
            else
            {
                textBoxNameMaterial.Text = "";
                textBoxPrice.Text = "";
                textBoxCount.Text = "";
                textBoxWeight.Text = "";
                textBoxSupplier.Text = "";
            }
        }
        void ShowMaterials()
        {
            listViewMaterials.Items.Clear();
            foreach (MaterialsSet materialsSet in Program.Spartak_Project.MaterialsSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                        materialsSet.Id.ToString(), materialsSet.NameMaterial, materialsSet.Price.ToString(),materialsSet.Count.ToString(),
                        materialsSet.Weight.ToString(),materialsSet.Supplier
                    }
                    );
                item.Tag = materialsSet;
                listViewMaterials.Items.Add(item);
            }
            listViewMaterials.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8) //цифры и backspace
            {
                e.Handled = true;
            }
        }

        private void FormMaterials_Load(object sender, EventArgs e)
        {

        }
    }
}
