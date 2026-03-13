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
        private List<Clients> clients;
        private List<Placement> placementslistbox;
        public AddUpdateDealForm(Model1 model)
        {
            InitializeComponent();
            this.model = model;
            deal = null;
            clients = model.Clients.ToList();
            placementslistbox = new List<Placement>();
            LoadData();
        }
        public AddUpdateDealForm(Model1 model, Deal deal)
        {
            InitializeComponent();
            this.model = model;
            this.deal = deal;
            buttonSave.Text = "Изменить";
            clients = model.Clients.ToList();
            placementslistbox = new List<Placement>();
            LoadData();


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
            foreach (var byer in clients.Where(x=>x.Type_Clients == 1 || x.Type_Clients == 3))
            {
                string text = byer.ID + " "+ 
                    byer.FirstName + " " + byer.SeconName + " " + byer.ThirdName;
                buyer_Tanant_IDComboBox.Items.Add(text);
            }

            ourien_IDComboBox.Items.Clear();
            foreach (var main in clients.Where(x => x.Type_Clients == 2 || x.Type_Clients == 4))
            {
                string text = main.ID + " " +
                    main.FirstName + " " + main.SeconName + " " + main.ThirdName;
                ourien_IDComboBox.Items.Add(text);
            }
            typeDealBindingSource.DataSource = model.Type_Deal.ToList();
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
            
            Placement placement =  (Placement) placementBindingSource.Current;
            placementBindingSource.Remove(placement);
            placementslistbox.Add(placement);
            listBoxPlacements.DataSource = placementslistbox;
            listBoxPlacements.DisplayMember = "Address";
            listBoxPlacements.ValueMember = "ID";
        }

        private void listBoxPlacements_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
