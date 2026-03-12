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
using System.Text.RegularExpressions;

namespace RieltorKurs.Forms
{
    public partial class ShowClientForm : ParentFrom
    {
        public ShowClientForm()
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

        private void ShowClientForm_Load(object sender, EventArgs e)
        {
            LoadDataUser();
            StartLoadData();

        }

        private void passportNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void clientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (
                 !Regex.IsMatch(firstNameTextBox.Text, @"^[а-яА-Я]+$") ||
                 !Regex.IsMatch(seconNameTextBox.Text, @"^[а-яА-Я]+$") ||
                 !Regex.IsMatch(thirdNameTextBox.Text, @"^[а-яА-Я]+$"))
            {
                MessageBox.Show("В полях ФИО должны быть только буквы!");
                return;
            }
            if (!passportNumberMaskedTextBox.MaskCompleted ||
                !passportSeriesMaskedTextBox.MaskCompleted)
            {
                MessageBox.Show("Заполните поля серия номер паспорта!");
                return;
            }
            if (type_ClientsComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите тип пользователя");
                return;
            }
            DateTime selectedDate = dateOfBirthDateTimePicker.Value;
            var days = (DateTime.Now - selectedDate).TotalDays;
            int fullage = Convert.ToInt32( days / 365);
            if (fullage < 14)
            {
                MessageBox.Show("Нельзя ввести пользователя возрастом меньше 14 лет!");
                return;
            }

            SaveData();
        }

        private void StartLoadData()
        {
            model.Clients.Load();
            typeClientsBindingSource.DataSource = model.Type_Clients.ToList();
            clientsBindingSource.DataSource = model.Clients.Local.ToBindingList();
        }

        private void SaveData()
        {
            try
            {
                Validate();
                clientsBindingSource.EndEdit();
                clientsBindingSource.ResetBindings(true);
                model.SaveChanges();
                MessageBox.Show("Данные сохранены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                StartLoadData();
            }
        }
    }
}
