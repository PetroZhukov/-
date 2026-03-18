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
    public partial class AdministratorForm : ParentFrom
    {
        public AdministratorForm()
        {
            InitializeComponent();
        }

        private void AdministratorForm_Load(object sender, EventArgs e)
        {
            LoadDataUser();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
            Application.OpenForms[0].Visible = true;
        }

        private void buttonClients_Click(object sender, EventArgs e)
        {
            ShowUsersForm form = new ShowUsersForm();
            form.Show();
            Close();
        }
    }
}
