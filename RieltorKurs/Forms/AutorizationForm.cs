using RieltorKurs.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace RieltorKurs.Forms
{
    public partial class AutorizationForm : Form
    {
        public AutorizationForm()
        {
            InitializeComponent();
        }
        public static Users Enter_User;
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            Enter_User = null;
            Model1 model1 = new Model1();
            // поиск пользователя по логину и паролю
            Enter_User = model1.Users.FirstOrDefault(x => x.Login == textBoxLogin.Text && x.Password == textBoxPassword.Text);
            if (Enter_User != null)
            {
                switch (Enter_User.Role_ID) // переход по формам в зависимости от роли
                {
                    case 1:
                        AdministratorForm formManager = new AdministratorForm();
                        formManager.Show();
                        Visible = false;
                        break;
                    case 2:
                        RieltorForm formSeller = new RieltorForm();
                        formSeller.Show();
                        Visible = false;
                        break;
                    default: throw new Exception("Роль не найдена!");
                }
            }
        }

        private void buttonRieltor_Click(object sender, EventArgs e)
        {
            textBoxLogin.Text = "anna.smirnova";
            textBoxPassword.Text = "12345";
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            textBoxLogin.Text = "ivan.petrov";
            textBoxPassword.Text = "12345";
        }

        private void AutorizationForm_Load(object sender, EventArgs e)
        {
            Text = "Агенство по недвижимости";
        }
    }
}
