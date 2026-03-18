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

namespace RieltorKurs.Forms
{
    public partial class ShowDealForm : ParentFrom
    {
        public ShowDealForm()
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

        private void ShowDealForm_Load(object sender, EventArgs e)
        {
            LoadDataUser();
            dealBindingSource.DataSource = model.Deal.ToList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddUpdateDealForm form = new AddUpdateDealForm(model);
            form.ShowDialog();
            dealBindingSource.DataSource = model.Deal.ToList();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            AddUpdateDealForm form = new AddUpdateDealForm(model, (Deal)dealBindingSource.Current);
            form.ShowDialog();
            dealBindingSource.DataSource = model.Deal.ToList();

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dealBindingSource.Count > 0)
            {
                Deal deal = (Deal)dealBindingSource.Current;
                DialogResult result = MessageBox.Show($"Вы действительно хотитете удалить запись с Id {deal.ID}",
                    $"Сообщение",
                    MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {

                    foreach (var repl in deal.Realest_Placement.Reverse())
                    {
                        model.Realest_Placement.Remove(repl);
                    }
                    model.SaveChanges();
                    model.Deal.Remove(deal);
                    model.SaveChanges();
                    dealBindingSource.DataSource = model.Deal.ToList();
                }
            }
            }
        }
}
