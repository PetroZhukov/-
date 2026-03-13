namespace RieltorKurs.Forms
{
    partial class ShowPlacementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowPlacementForm));
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label cadastralValueLabel;
            System.Windows.Forms.Label dascriptionLabel;
            System.Windows.Forms.Label floorsLabel;
            System.Windows.Forms.Label marketValueLabel;
            System.Windows.Forms.Label roomsLabel;
            System.Windows.Forms.Label squareLabel;
            System.Windows.Forms.Label type_Placement_IDLabel;
            this.placementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.placementBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.placementBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
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
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.cadastralValueTextBox = new System.Windows.Forms.TextBox();
            this.dascriptionTextBox = new System.Windows.Forms.TextBox();
            this.floorsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.marketValueTextBox = new System.Windows.Forms.TextBox();
            this.roomsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.squareTextBox = new System.Windows.Forms.TextBox();
            this.type_Placement_IDComboBox = new System.Windows.Forms.ComboBox();
            this.typePlacementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            addressLabel = new System.Windows.Forms.Label();
            cadastralValueLabel = new System.Windows.Forms.Label();
            dascriptionLabel = new System.Windows.Forms.Label();
            floorsLabel = new System.Windows.Forms.Label();
            marketValueLabel = new System.Windows.Forms.Label();
            roomsLabel = new System.Windows.Forms.Label();
            squareLabel = new System.Windows.Forms.Label();
            type_Placement_IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placementBindingNavigator)).BeginInit();
            this.placementBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.placementDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typePlacementBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1931, 11);
            // 
            // buttonBack
            // 
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Location = new System.Drawing.Point(1808, 14);
            // 
            // labelNameForm
            // 
            this.labelNameForm.Size = new System.Drawing.Size(1571, 45);
            this.labelNameForm.Text = "Недвижимость";
            // 
            // labelUserData
            // 
            this.labelUserData.Size = new System.Drawing.Size(1763, 45);
            // 
            // placementBindingSource
            // 
            this.placementBindingSource.DataSource = typeof(RieltorKurs.Model.Placement);
            // 
            // placementBindingNavigator
            // 
            this.placementBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.placementBindingNavigator.AutoSize = false;
            this.placementBindingNavigator.BindingSource = this.placementBindingSource;
            this.placementBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.placementBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.placementBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.placementBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.placementBindingNavigatorSaveItem});
            this.placementBindingNavigator.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.placementBindingNavigator.Location = new System.Drawing.Point(437, 160);
            this.placementBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.placementBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.placementBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.placementBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.placementBindingNavigator.Name = "placementBindingNavigator";
            this.placementBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.placementBindingNavigator.Size = new System.Drawing.Size(65, 257);
            this.placementBindingNavigator.TabIndex = 5;
            this.placementBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(63, 20);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(63, 20);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(63, 6);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(63, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(63, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(63, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(63, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(63, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(63, 20);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(63, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // placementBindingNavigatorSaveItem
            // 
            this.placementBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.placementBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("placementBindingNavigatorSaveItem.Image")));
            this.placementBindingNavigatorSaveItem.Name = "placementBindingNavigatorSaveItem";
            this.placementBindingNavigatorSaveItem.Size = new System.Drawing.Size(63, 20);
            this.placementBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.placementBindingNavigatorSaveItem.Click += new System.EventHandler(this.placementBindingNavigatorSaveItem_Click);
            // 
            // placementDataGridView
            // 
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
            this.dataGridViewTextBoxColumn9});
            this.placementDataGridView.DataSource = this.placementBindingSource;
            this.placementDataGridView.Location = new System.Drawing.Point(517, 160);
            this.placementDataGridView.Name = "placementDataGridView";
            this.placementDataGridView.Size = new System.Drawing.Size(1377, 394);
            this.placementDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn2.HeaderText = "Address";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Square";
            this.dataGridViewTextBoxColumn3.HeaderText = "Square";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CadastralValue";
            this.dataGridViewTextBoxColumn4.HeaderText = "CadastralValue";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MarketValue";
            this.dataGridViewTextBoxColumn5.HeaderText = "MarketValue";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Rooms";
            this.dataGridViewTextBoxColumn6.HeaderText = "Rooms";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Floors";
            this.dataGridViewTextBoxColumn7.HeaderText = "Floors";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Type_Placement_ID";
            this.dataGridViewTextBoxColumn8.HeaderText = "Type_Placement_ID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Dascription";
            this.dataGridViewTextBoxColumn9.HeaderText = "Dascription";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(40, 181);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(77, 21);
            addressLabel.TabIndex = 7;
            addressLabel.Text = "Address:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.placementBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(203, 178);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(215, 29);
            this.addressTextBox.TabIndex = 8;
            // 
            // cadastralValueLabel
            // 
            cadastralValueLabel.AutoSize = true;
            cadastralValueLabel.Location = new System.Drawing.Point(40, 216);
            cadastralValueLabel.Name = "cadastralValueLabel";
            cadastralValueLabel.Size = new System.Drawing.Size(129, 21);
            cadastralValueLabel.TabIndex = 9;
            cadastralValueLabel.Text = "Cadastral Value:";
            // 
            // cadastralValueTextBox
            // 
            this.cadastralValueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.placementBindingSource, "CadastralValue", true));
            this.cadastralValueTextBox.Location = new System.Drawing.Point(203, 213);
            this.cadastralValueTextBox.Name = "cadastralValueTextBox";
            this.cadastralValueTextBox.Size = new System.Drawing.Size(215, 29);
            this.cadastralValueTextBox.TabIndex = 10;
            this.cadastralValueTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.squareTextBox_KeyPress);
            // 
            // dascriptionLabel
            // 
            dascriptionLabel.AutoSize = true;
            dascriptionLabel.Location = new System.Drawing.Point(40, 426);
            dascriptionLabel.Name = "dascriptionLabel";
            dascriptionLabel.Size = new System.Drawing.Size(100, 21);
            dascriptionLabel.TabIndex = 11;
            dascriptionLabel.Text = "Dascription:";
            // 
            // dascriptionTextBox
            // 
            this.dascriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.placementBindingSource, "Dascription", true));
            this.dascriptionTextBox.Location = new System.Drawing.Point(203, 423);
            this.dascriptionTextBox.Multiline = true;
            this.dascriptionTextBox.Name = "dascriptionTextBox";
            this.dascriptionTextBox.Size = new System.Drawing.Size(215, 131);
            this.dascriptionTextBox.TabIndex = 12;
            // 
            // floorsLabel
            // 
            floorsLabel.AutoSize = true;
            floorsLabel.Location = new System.Drawing.Point(40, 248);
            floorsLabel.Name = "floorsLabel";
            floorsLabel.Size = new System.Drawing.Size(63, 21);
            floorsLabel.TabIndex = 13;
            floorsLabel.Text = "Floors:";
            // 
            // floorsNumericUpDown
            // 
            this.floorsNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.placementBindingSource, "Floors", true));
            this.floorsNumericUpDown.Location = new System.Drawing.Point(203, 248);
            this.floorsNumericUpDown.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.floorsNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.floorsNumericUpDown.Name = "floorsNumericUpDown";
            this.floorsNumericUpDown.Size = new System.Drawing.Size(215, 29);
            this.floorsNumericUpDown.TabIndex = 14;
            this.floorsNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // marketValueLabel
            // 
            marketValueLabel.AutoSize = true;
            marketValueLabel.Location = new System.Drawing.Point(40, 286);
            marketValueLabel.Name = "marketValueLabel";
            marketValueLabel.Size = new System.Drawing.Size(111, 21);
            marketValueLabel.TabIndex = 15;
            marketValueLabel.Text = "Market Value:";
            // 
            // marketValueTextBox
            // 
            this.marketValueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.placementBindingSource, "MarketValue", true));
            this.marketValueTextBox.Location = new System.Drawing.Point(203, 283);
            this.marketValueTextBox.Name = "marketValueTextBox";
            this.marketValueTextBox.Size = new System.Drawing.Size(215, 29);
            this.marketValueTextBox.TabIndex = 16;
            this.marketValueTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.squareTextBox_KeyPress);
            // 
            // roomsLabel
            // 
            roomsLabel.AutoSize = true;
            roomsLabel.Location = new System.Drawing.Point(40, 318);
            roomsLabel.Name = "roomsLabel";
            roomsLabel.Size = new System.Drawing.Size(69, 21);
            roomsLabel.TabIndex = 17;
            roomsLabel.Text = "Rooms:";
            // 
            // roomsNumericUpDown
            // 
            this.roomsNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.placementBindingSource, "Rooms", true));
            this.roomsNumericUpDown.Location = new System.Drawing.Point(203, 318);
            this.roomsNumericUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.roomsNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.roomsNumericUpDown.Name = "roomsNumericUpDown";
            this.roomsNumericUpDown.Size = new System.Drawing.Size(215, 29);
            this.roomsNumericUpDown.TabIndex = 18;
            this.roomsNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // squareLabel
            // 
            squareLabel.AutoSize = true;
            squareLabel.Location = new System.Drawing.Point(40, 356);
            squareLabel.Name = "squareLabel";
            squareLabel.Size = new System.Drawing.Size(66, 21);
            squareLabel.TabIndex = 19;
            squareLabel.Text = "Square:";
            // 
            // squareTextBox
            // 
            this.squareTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.placementBindingSource, "Square", true));
            this.squareTextBox.Location = new System.Drawing.Point(203, 353);
            this.squareTextBox.Name = "squareTextBox";
            this.squareTextBox.Size = new System.Drawing.Size(215, 29);
            this.squareTextBox.TabIndex = 20;
            this.squareTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.squareTextBox_KeyPress);
            // 
            // type_Placement_IDLabel
            // 
            type_Placement_IDLabel.AutoSize = true;
            type_Placement_IDLabel.Location = new System.Drawing.Point(40, 391);
            type_Placement_IDLabel.Name = "type_Placement_IDLabel";
            type_Placement_IDLabel.Size = new System.Drawing.Size(157, 21);
            type_Placement_IDLabel.TabIndex = 21;
            type_Placement_IDLabel.Text = "Type Placement ID:";
            // 
            // type_Placement_IDComboBox
            // 
            this.type_Placement_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.placementBindingSource, "Type_Placement_ID", true));
            this.type_Placement_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.placementBindingSource, "Type_Placement_ID", true));
            this.type_Placement_IDComboBox.DataSource = this.typePlacementBindingSource;
            this.type_Placement_IDComboBox.DisplayMember = "Name";
            this.type_Placement_IDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type_Placement_IDComboBox.FormattingEnabled = true;
            this.type_Placement_IDComboBox.Location = new System.Drawing.Point(203, 388);
            this.type_Placement_IDComboBox.Name = "type_Placement_IDComboBox";
            this.type_Placement_IDComboBox.Size = new System.Drawing.Size(215, 29);
            this.type_Placement_IDComboBox.TabIndex = 22;
            this.type_Placement_IDComboBox.ValueMember = "ID";
            // 
            // typePlacementBindingSource
            // 
            this.typePlacementBindingSource.DataSource = typeof(RieltorKurs.Model.Type_Placement);
            // 
            // ShowPlacementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1922, 566);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(cadastralValueLabel);
            this.Controls.Add(this.cadastralValueTextBox);
            this.Controls.Add(dascriptionLabel);
            this.Controls.Add(this.dascriptionTextBox);
            this.Controls.Add(floorsLabel);
            this.Controls.Add(this.floorsNumericUpDown);
            this.Controls.Add(marketValueLabel);
            this.Controls.Add(this.marketValueTextBox);
            this.Controls.Add(roomsLabel);
            this.Controls.Add(this.roomsNumericUpDown);
            this.Controls.Add(squareLabel);
            this.Controls.Add(this.squareTextBox);
            this.Controls.Add(type_Placement_IDLabel);
            this.Controls.Add(this.type_Placement_IDComboBox);
            this.Controls.Add(this.placementDataGridView);
            this.Controls.Add(this.placementBindingNavigator);
            this.Name = "ShowPlacementForm";
            this.Text = "ShowPlacementForm";
            this.Load += new System.EventHandler(this.ShowPlacementForm_Load);
            this.Controls.SetChildIndex(this.placementBindingNavigator, 0);
            this.Controls.SetChildIndex(this.placementDataGridView, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.buttonBack, 0);
            this.Controls.SetChildIndex(this.pictureBoxIcon, 0);
            this.Controls.SetChildIndex(this.labelNameForm, 0);
            this.Controls.SetChildIndex(this.labelUserData, 0);
            this.Controls.SetChildIndex(this.type_Placement_IDComboBox, 0);
            this.Controls.SetChildIndex(type_Placement_IDLabel, 0);
            this.Controls.SetChildIndex(this.squareTextBox, 0);
            this.Controls.SetChildIndex(squareLabel, 0);
            this.Controls.SetChildIndex(this.roomsNumericUpDown, 0);
            this.Controls.SetChildIndex(roomsLabel, 0);
            this.Controls.SetChildIndex(this.marketValueTextBox, 0);
            this.Controls.SetChildIndex(marketValueLabel, 0);
            this.Controls.SetChildIndex(this.floorsNumericUpDown, 0);
            this.Controls.SetChildIndex(floorsLabel, 0);
            this.Controls.SetChildIndex(this.dascriptionTextBox, 0);
            this.Controls.SetChildIndex(dascriptionLabel, 0);
            this.Controls.SetChildIndex(this.cadastralValueTextBox, 0);
            this.Controls.SetChildIndex(cadastralValueLabel, 0);
            this.Controls.SetChildIndex(this.addressTextBox, 0);
            this.Controls.SetChildIndex(addressLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placementBindingNavigator)).EndInit();
            this.placementBindingNavigator.ResumeLayout(false);
            this.placementBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.placementDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typePlacementBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource placementBindingSource;
        private System.Windows.Forms.BindingNavigator placementBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton placementBindingNavigatorSaveItem;
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
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox cadastralValueTextBox;
        private System.Windows.Forms.TextBox dascriptionTextBox;
        private System.Windows.Forms.NumericUpDown floorsNumericUpDown;
        private System.Windows.Forms.TextBox marketValueTextBox;
        private System.Windows.Forms.NumericUpDown roomsNumericUpDown;
        private System.Windows.Forms.TextBox squareTextBox;
        private System.Windows.Forms.ComboBox type_Placement_IDComboBox;
        private System.Windows.Forms.BindingSource typePlacementBindingSource;
    }
}