using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RieltorKurs.Forms
{
    public partial class ParentFrom : Form
    {
        public ParentFrom()
        {
            InitializeComponent();
        }

        protected void LoadDataUser()
        {
            Text = "Агенство по недвижимости";
            labelUserData.Text =
            AutorizationForm.Enter_User.FirstName + " " +
            AutorizationForm.Enter_User.SecondName + " " +
            AutorizationForm.Enter_User.ThirdName + " | " +
            AutorizationForm.Enter_User.Roles.Name;
        }
    }
}
