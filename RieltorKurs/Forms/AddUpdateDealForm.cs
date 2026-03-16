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
    public partial class AddUpdateDealForm : ParentFrom
    {
        private Model1 model;
        private Deal deal;
        private List<Clients> ourien;
        private List<Clients> buyer_Tanant;
        private List<Placement> placementslistbox;
        public AddUpdateDealForm(Model1 model)
        {
            InitializeComponent();
            this.model = model;
            deal = null;
            placementslistbox = new List<Placement>();
            LoadData();
        }
        public AddUpdateDealForm(Model1 model, Deal deal)
        {
            InitializeComponent();
            this.model = model;
            this.deal = deal;
            buttonSave.Text = "Изменить";
            placementslistbox = new List<Placement>();
            LoadData();
            UpdateDataLoad();
        }

        private void AddUpdateDealForm_Load(object sender, EventArgs e)
        {
            LoadDataUser();
        }

        private void LoadData()
        {
            List<Placement> placements = new List<Placement>();
            foreach (var place in model.Placement)
            {
                if (!model.Realest_Placement.Any(x => x.Placement_ID == place.ID))
                {
                    placements.Add(place);
                }
            }
            placementBindingSource.DataSource = placements;

            buyer_Tanant_IDComboBox.Items.Clear();
            buyer_Tanant = model.Clients.Where(x => x.Type_Clients == 1).ToList();
            foreach (var byer in buyer_Tanant)
            {
                string text = byer.ID + " " +
                    byer.FirstName + " " + byer.SeconName + " " + byer.ThirdName;
                buyer_Tanant_IDComboBox.Items.Add(text);
            }

            ourien_IDComboBox.Items.Clear();
            ourien = model.Clients.Where(x => x.Type_Clients == 2).ToList();
            foreach (var main in ourien)
            {
                string text = main.ID + " " +
                    main.FirstName + " " + main.SeconName + " " + main.ThirdName;
                ourien_IDComboBox.Items.Add(text);
            }
            typeDealBindingSource.DataSource = model.Type_Deal.ToList();
        }

        private void UpdateDataLoad()
        {
            buyer_Tanant_IDComboBox.SelectedIndex = buyer_Tanant.FindIndex(x => x.ID == deal.Buyer_Tanant_ID);
            ourien_IDComboBox.SelectedIndex = ourien.FindIndex(x => x.ID == deal.Ourien_ID);
            type_DealComboBox.SelectedValue = deal.Type_Deal;
            foreach (var item in deal.Realest_Placement)
            {
                Placement placement = item.Placement;
                placementBindingSource.Remove(placement);
                placementslistbox.Add(placement);
            }
            listBoxPlacements.DataSource = placementslistbox;
            listBoxPlacements.DisplayMember = "Address";
            listBoxPlacements.ValueMember = "ID";

            costPerMonthTextBox.Text = deal.CostPerMonth.ToString();
            comissionTextBox.Text = deal.Comission.ToString();
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comissionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ',')
                e.Handled = true;
        }

        private void placementDataGridView_DoubleClick(object sender, EventArgs e)
        {
            Placement placement = (Placement)placementBindingSource.Current;
            placementBindingSource.Remove(placement);
            placementslistbox.Add(placement);
            listBoxPlacements.DataSource = null;
            listBoxPlacements.DataSource = placementslistbox;
            listBoxPlacements.DisplayMember = "Address";
            listBoxPlacements.ValueMember = "ID";
            if (type_DealComboBox.SelectedIndex == 0)
            {
                if (listBoxPlacements.Items.Count > 0)
                {
                    double summ = (double)placementslistbox.Select(x => x.MarketValue).Sum();
                    comissionTextBox.Text = summ.ToString();
                }
                else
                {
                    MessageBox.Show("Добавьте недвижимость в сделку!");
                }
            }
        }
        private void costPerMonthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (type_DealComboBox.SelectedIndex == 1)
            {
                if (comboBoxCommission.SelectedIndex != -1)
                {
                    bool isdouble = double.TryParse(costPerMonthTextBox.Text, out double costPerMonth);
                    if (isdouble)
                    {
                        double procent = Convert.ToDouble(((string)comboBoxCommission.SelectedItem).Replace("%", ""));
                        double commiission = costPerMonth * (procent / 100);
                        comissionTextBox.Text = commiission.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Стоимость в месяц не вещественное число");
                    }
                }
            }
        }

        private void comboBoxCommission_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (type_DealComboBox.SelectedIndex == 0)
            {
                if (listBoxPlacements.Items.Count > 0)
                {
                    double summ = (double)placementslistbox.Select(x => x.MarketValue).Sum();
                    comissionTextBox.Text = summ.ToString();
                }
                else
                {
                    MessageBox.Show("Добавьте недвижимость в сделку!");
                }
            }
            else if (type_DealComboBox.SelectedIndex == 1)
            {
                bool isdouble = double.TryParse(costPerMonthTextBox.Text, out double costPerMonth);
                if (isdouble)
                {
                    double procent = Convert.ToDouble(((string)comboBoxCommission.SelectedItem).Replace("%", ""));
                    double commiission = costPerMonth * (procent / 100);
                    comissionTextBox.Text = commiission.ToString();
                }
                else
                {
                    MessageBox.Show("Стоимость в месяц не вещественное число");
                }
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (ourien_IDComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите Продавца/Арендодателя!");
                return;
            }
            if (buyer_Tanant_IDComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите Покупателя/Арендатора!");
                return;
            }

            bool isdouble_costpermonth = double.TryParse(costPerMonthTextBox.Text, out double costpermounth);
            if (type_DealComboBox.SelectedIndex == 2 &&
                (!isdouble_costpermonth ||
                 costpermounth == 0))
            {
                MessageBox.Show("Заполните стоимость в месяц!");
                return;
            }

            bool isdouble_commisiion = double.TryParse(comissionTextBox.Text, out double commisiion);
            if (string.IsNullOrWhiteSpace(comissionTextBox.Text) || !isdouble_commisiion)
            {
                MessageBox.Show("Выберите комиссию!");
                return;
            }
            if (listBoxPlacements.Items.Count == 0)
            {
                MessageBox.Show("Выберите недвижимость!");
                return;
            }

            if (deal == null)
            {
                deal = new Deal();
                deal.Realtor_ID = AutorizationForm.Enter_User.ID;
            }

            deal.Ourien_ID = ourien[ourien_IDComboBox.SelectedIndex].ID;
            deal.Buyer_Tanant_ID = buyer_Tanant[buyer_Tanant_IDComboBox.SelectedIndex].ID;
            deal.CostPerMonth = costpermounth;
            deal.Comission = commisiion;
            deal.Type_Deal = (int)type_DealComboBox.SelectedValue;

            if (deal == null)
            {
                model.Deal.Add(deal);
            }

            model.SaveChanges();

            foreach (var placement in placementslistbox)
            {
                Realest_Placement realest_Placement = model.Realest_Placement.FirstOrDefault
                    (x => x.Placement_ID == placement.ID && x.Deal_ID == deal.ID);
                if (realest_Placement == null)
                {
                    realest_Placement = new Realest_Placement();
                    realest_Placement.Placement_ID = placement.ID;
                    realest_Placement.Deal_ID = deal.ID;

                    model.Realest_Placement.Add(realest_Placement);
                    model.SaveChanges();
                }
            }
            Close();
        }


    }
}
