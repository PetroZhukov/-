using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using RieltorKurs.Model;
using System.Text.RegularExpressions;

namespace RieltorKurs.Forms
{
    public partial class ShowUsersForm : ParentFrom
    {
        public ShowUsersForm()
        {
            InitializeComponent();
        }
        private Model1 model = new Model1();
        private void ShowClients_Load(object sender, EventArgs e)
        {
            LoadDataUser();
            StartLoadData();
        }

        private void StartLoadData()
        {
            model.Users.Load();
            rolesBindingSource.DataSource = model.Roles.ToList();
            usersBindingSource.DataSource = model.Users.Local.ToBindingList();
        }

        private void SaveData()
        {
            try
            {
                Validate();
                usersBindingSource.EndEdit();
                usersBindingSource.ResetBindings(true);
                model.SaveChanges();
                MessageBox.Show("Данные сохранены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                StartLoadData();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            AdministratorForm form = new AdministratorForm();
            form.Show();
            Close();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (role_IDComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите тип недвижимсоти!");
                return;
            }
            if (
               !Regex.IsMatch(firstNameTextBox.Text, @"^[а-яА-Я]+$") ||
               !Regex.IsMatch(secondNameTextBox.Text, @"^[а-яА-Я]+$") ||
               !Regex.IsMatch(thirdNameTextBox.Text, @"^[а-яА-Я]+$"))
            {
                MessageBox.Show("В полях ФИО должны быть только буквы!");
                return;
            }

            if (String.IsNullOrWhiteSpace( loginTextBox.Text) && loginTextBox.Text.Length <= 30)
            { 
                MessageBox.Show("Логин должен не быть и не длиннее 30 символов!");
                return;
            }

            if (passwordTextBox.Text != passwordTextBoxSecond.Text)
            {
                MessageBox.Show("Пароли не совпадают!");
                return;
            }

            if (String.IsNullOrWhiteSpace(passwordTextBox.Text) && passwordTextBox.Text.Length <= 70)
            {
                MessageBox.Show("Логин должен не быть и не длиннее 70 символов!");
                return;
            }

            SaveData();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            SaveData();

        }
    }
}
