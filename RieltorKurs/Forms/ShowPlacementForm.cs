using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RieltorKurs.Model;
using System.Data.Entity;

namespace RieltorKurs.Forms
{
    public partial class ShowPlacementForm : ParentFrom
    {
        public ShowPlacementForm()
        {
            InitializeComponent();
        }
        private Model1 model = new Model1(); 
        private void buttonBack_Click(object sender, EventArgs e)
        {
            RieltorForm rieltorForm = new RieltorForm();
            rieltorForm.Show();
            Close();
        }

        private void ShowPlacementForm_Load(object sender, EventArgs e)
        {
            LoadDataUser();
            StartLoadData();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void placementBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (type_Placement_IDComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите тип недвижимсоти!");
                return;
            }


            SaveData();
        }


        private void StartLoadData()
        {
            model.Placement.Load();
            typePlacementBindingSource.DataSource = model.Type_Placement.ToList();
            placementBindingSource.DataSource = model.Placement.Local.ToBindingList();
        }

        private void SaveData()
        {
            try
            {
                Validate();
                placementBindingSource.EndEdit();
                placementBindingSource.ResetBindings(true);
                model.SaveChanges();
                MessageBox.Show("Данные сохранены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                StartLoadData();
            }
        }

        private void squareTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ',')
                e.Handled = true;
        }
    }
}
