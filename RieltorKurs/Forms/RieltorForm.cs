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
    public partial class RieltorForm : ParentFrom
    {
        public RieltorForm()
        {
            InitializeComponent();
        }

        private void RieltorForm_Load(object sender, EventArgs e)
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
            ShowClientForm form = new ShowClientForm();
            form.Show();
            Close();
        }

        private void buttonDeal_Click(object sender, EventArgs e)
        {
            ShowDealForm form = new ShowDealForm();
            form.Show();
            Close();
        }

        private void buttonPlacement_Click(object sender, EventArgs e)
        {
            ShowPlacementForm form = new ShowPlacementForm();
            form.Show();
            Close();
        }
    }
}
