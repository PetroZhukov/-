namespace RieltorKurs.Forms
{
    partial class AddUpdateDealForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label buyer_Tanant_IDLabel;
            System.Windows.Forms.Label comissionLabel;
            System.Windows.Forms.Label costPerMonthLabel;
            System.Windows.Forms.Label ourien_IDLabel;
            System.Windows.Forms.Label type_DealLabel;
            this.buyer_Tanant_IDComboBox = new System.Windows.Forms.ComboBox();
            this.comissionTextBox = new System.Windows.Forms.TextBox();
            this.costPerMonthTextBox = new System.Windows.Forms.TextBox();
            this.ourien_IDComboBox = new System.Windows.Forms.ComboBox();
            this.type_DealComboBox = new System.Windows.Forms.ComboBox();
            this.typeDealBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSave = new System.Windows.Forms.Button();
            this.placementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.placementDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBoxPlacements = new System.Windows.Forms.ListBox();
            buyer_Tanant_IDLabel = new System.Windows.Forms.Label();
            comissionLabel = new System.Windows.Forms.Label();
            costPerMonthLabel = new System.Windows.Forms.Label();
            ourien_IDLabel = new System.Windows.Forms.Label();
            type_DealLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeDealBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placementDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1027, 11);
            // 
            // buttonBack
            // 
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Location = new System.Drawing.Point(904, 14);
            // 
            // labelNameForm
            // 
            this.labelNameForm.Size = new System.Drawing.Size(631, 45);
            // 
            // labelUserData
            // 
            this.labelUserData.Size = new System.Drawing.Size(859, 45);
            // 
            // buyer_Tanant_IDLabel
            // 
            buyer_Tanant_IDLabel.AutoSize = true;
            buyer_Tanant_IDLabel.Location = new System.Drawing.Point(28, 222);
            buyer_Tanant_IDLabel.Name = "buyer_Tanant_IDLabel";
            buyer_Tanant_IDLabel.Size = new System.Drawing.Size(137, 21);
            buyer_Tanant_IDLabel.TabIndex = 6;
            buyer_Tanant_IDLabel.Text = "Buyer Tanant ID:";
            // 
            // comissionLabel
            // 
            comissionLabel.AutoSize = true;
            comissionLabel.Location = new System.Drawing.Point(28, 292);
            comissionLabel.Name = "comissionLabel";
            comissionLabel.Size = new System.Drawing.Size(94, 21);
            comissionLabel.TabIndex = 8;
            comissionLabel.Text = "Comission:";
            // 
            // costPerMonthLabel
            // 
            costPerMonthLabel.AutoSize = true;
            costPerMonthLabel.Location = new System.Drawing.Point(28, 327);
            costPerMonthLabel.Name = "costPerMonthLabel";
            costPerMonthLabel.Size = new System.Drawing.Size(134, 21);
            costPerMonthLabel.TabIndex = 10;
            costPerMonthLabel.Text = "Cost Per Month:";
            // 
            // ourien_IDLabel
            // 
            ourien_IDLabel.AutoSize = true;
            ourien_IDLabel.Location = new System.Drawing.Point(28, 187);
            ourien_IDLabel.Name = "ourien_IDLabel";
            ourien_IDLabel.Size = new System.Drawing.Size(88, 21);
            ourien_IDLabel.TabIndex = 12;
            ourien_IDLabel.Text = "Ourien ID:";
            // 
            // type_DealLabel
            // 
            type_DealLabel.AutoSize = true;
            type_DealLabel.Location = new System.Drawing.Point(28, 257);
            type_DealLabel.Name = "type_DealLabel";
            type_DealLabel.Size = new System.Drawing.Size(90, 21);
            type_DealLabel.TabIndex = 16;
            type_DealLabel.Text = "Type Deal:";
            // 
            // buyer_Tanant_IDComboBox
            // 
            this.buyer_Tanant_IDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.buyer_Tanant_IDComboBox.FormattingEnabled = true;
            this.buyer_Tanant_IDComboBox.Location = new System.Drawing.Point(171, 219);
            this.buyer_Tanant_IDComboBox.Name = "buyer_Tanant_IDComboBox";
            this.buyer_Tanant_IDComboBox.Size = new System.Drawing.Size(283, 29);
            this.buyer_Tanant_IDComboBox.TabIndex = 7;
            // 
            // comissionTextBox
            // 
            this.comissionTextBox.Location = new System.Drawing.Point(171, 289);
            this.comissionTextBox.Name = "comissionTextBox";
            this.comissionTextBox.Size = new System.Drawing.Size(283, 29);
            this.comissionTextBox.TabIndex = 9;
            this.comissionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comissionTextBox_KeyPress);
            // 
            // costPerMonthTextBox
            // 
            this.costPerMonthTextBox.Location = new System.Drawing.Point(171, 324);
            this.costPerMonthTextBox.Name = "costPerMonthTextBox";
            this.costPerMonthTextBox.Size = new System.Drawing.Size(283, 29);
            this.costPerMonthTextBox.TabIndex = 11;
            this.costPerMonthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comissionTextBox_KeyPress);
            // 
            // ourien_IDComboBox
            // 
            this.ourien_IDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ourien_IDComboBox.FormattingEnabled = true;
            this.ourien_IDComboBox.Location = new System.Drawing.Point(171, 184);
            this.ourien_IDComboBox.Name = "ourien_IDComboBox";
            this.ourien_IDComboBox.Size = new System.Drawing.Size(283, 29);
            this.ourien_IDComboBox.TabIndex = 13;
            // 
            // type_DealComboBox
            // 
            this.type_DealComboBox.DataSource = this.typeDealBindingSource;
            this.type_DealComboBox.DisplayMember = "Name";
            this.type_DealComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type_DealComboBox.FormattingEnabled = true;
            this.type_DealComboBox.Location = new System.Drawing.Point(171, 254);
            this.type_DealComboBox.Name = "type_DealComboBox";
            this.type_DealComboBox.Size = new System.Drawing.Size(283, 29);
            this.type_DealComboBox.TabIndex = 17;
            this.type_DealComboBox.ValueMember = "ID";
            // 
            // typeDealBindingSource
            // 
            this.typeDealBindingSource.DataSource = typeof(RieltorKurs.Model.Type_Deal);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSave.Location = new System.Drawing.Point(767, 254);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(169, 44);
            this.buttonSave.TabIndex = 18;
            this.buttonSave.Text = "Добавить";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // placementBindingSource
            // 
            this.placementBindingSource.DataSource = typeof(RieltorKurs.Model.Placement);
            // 
            // placementDataGridView
            // 
            this.placementDataGridView.AllowUserToAddRows = false;
            this.placementDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.placementDataGridView.AutoGenerateColumns = false;
            this.placementDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.placementDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.placementDataGridView.DataSource = this.placementBindingSource;
            this.placementDataGridView.Location = new System.Drawing.Point(36, 389);
            this.placementDataGridView.Name = "placementDataGridView";
            this.placementDataGridView.ReadOnly = true;
            this.placementDataGridView.Size = new System.Drawing.Size(930, 169);
            this.placementDataGridView.TabIndex = 18;
            this.placementDataGridView.DoubleClick += new System.EventHandler(this.placementDataGridView_DoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn2.HeaderText = "Address";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Square";
            this.dataGridViewTextBoxColumn3.HeaderText = "Square";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CadastralValue";
            this.dataGridViewTextBoxColumn4.HeaderText = "CadastralValue";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MarketValue";
            this.dataGridViewTextBoxColumn5.HeaderText = "MarketValue";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Rooms";
            this.dataGridViewTextBoxColumn6.HeaderText = "Rooms";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Floors";
            this.dataGridViewTextBoxColumn7.HeaderText = "Floors";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Type_Placement_ID";
            this.dataGridViewTextBoxColumn8.HeaderText = "Type_Placement_ID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Dascription";
            this.dataGridViewTextBoxColumn9.HeaderText = "Dascription";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Type_Placement";
            this.dataGridViewTextBoxColumn10.HeaderText = "Type_Placement";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Realest_Placement";
            this.dataGridViewTextBoxColumn11.HeaderText = "Realest_Placement";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // listBoxPlacements
            // 
            this.listBoxPlacements.FormattingEnabled = true;
            this.listBoxPlacements.ItemHeight = 21;
            this.listBoxPlacements.Location = new System.Drawing.Point(495, 184);
            this.listBoxPlacements.Name = "listBoxPlacements";
            this.listBoxPlacements.Size = new System.Drawing.Size(199, 172);
            this.listBoxPlacements.TabIndex = 19;
            this.listBoxPlacements.DoubleClick += new System.EventHandler(this.listBoxPlacements_DoubleClick);
            // 
            // AddUpdateDealForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 583);
            this.Controls.Add(this.listBoxPlacements);
            this.Controls.Add(this.placementDataGridView);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(buyer_Tanant_IDLabel);
            this.Controls.Add(this.buyer_Tanant_IDComboBox);
            this.Controls.Add(comissionLabel);
            this.Controls.Add(this.comissionTextBox);
            this.Controls.Add(costPerMonthLabel);
            this.Controls.Add(this.costPerMonthTextBox);
            this.Controls.Add(ourien_IDLabel);
            this.Controls.Add(this.ourien_IDComboBox);
            this.Controls.Add(type_DealLabel);
            this.Controls.Add(this.type_DealComboBox);
            this.Name = "AddUpdateDealForm";
            this.Text = "AddUpdateDealForm";
            this.Load += new System.EventHandler(this.AddUpdateDealForm_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.buttonBack, 0);
            this.Controls.SetChildIndex(this.pictureBoxIcon, 0);
            this.Controls.SetChildIndex(this.labelNameForm, 0);
            this.Controls.SetChildIndex(this.labelUserData, 0);
            this.Controls.SetChildIndex(this.type_DealComboBox, 0);
            this.Controls.SetChildIndex(type_DealLabel, 0);
            this.Controls.SetChildIndex(this.ourien_IDComboBox, 0);
            this.Controls.SetChildIndex(ourien_IDLabel, 0);
            this.Controls.SetChildIndex(this.costPerMonthTextBox, 0);
            this.Controls.SetChildIndex(costPerMonthLabel, 0);
            this.Controls.SetChildIndex(this.comissionTextBox, 0);
            this.Controls.SetChildIndex(comissionLabel, 0);
            this.Controls.SetChildIndex(this.buyer_Tanant_IDComboBox, 0);
            this.Controls.SetChildIndex(buyer_Tanant_IDLabel, 0);
            this.Controls.SetChildIndex(this.buttonSave, 0);
            this.Controls.SetChildIndex(this.placementDataGridView, 0);
            this.Controls.SetChildIndex(this.listBoxPlacements, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeDealBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placementDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox buyer_Tanant_IDComboBox;
        private System.Windows.Forms.TextBox comissionTextBox;
        private System.Windows.Forms.TextBox costPerMonthTextBox;
        private System.Windows.Forms.ComboBox ourien_IDComboBox;
        private System.Windows.Forms.ComboBox type_DealComboBox;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.BindingSource typeDealBindingSource;
        private System.Windows.Forms.BindingSource placementBindingSource;
        private System.Windows.Forms.DataGridView placementDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.ListBox listBoxPlacements;
    }
}