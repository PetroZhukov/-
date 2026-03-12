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
    public partial class ShowDealForm : ParentFrom
    {
        public ShowDealForm()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            RieltorForm rieltorForm = new RieltorForm();
            rieltorForm.Show();
            Close();
        }

        private void ShowDealForm_Load(object sender, EventArgs e)
        {
            LoadDataUser();
        }
    }
}
