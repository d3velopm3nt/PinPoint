namespace Pin_Control.User_Controls
{
    partial class uc_Devices
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label deviceLabel;
            System.Windows.Forms.Label iP_AddressLabel;
            System.Windows.Forms.Label portLabel;
            System.Windows.Forms.Label location_IDLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label attenuationLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label timeLimitLabel;
            System.Windows.Forms.Label timeLimitTypeLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_Devices));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.devicesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.devicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pinDBDataSet = new Pin_Control.PinDBDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.devicesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.deviceTextBox = new System.Windows.Forms.TextBox();
            this.iP_AddressTextBox = new System.Windows.Forms.TextBox();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.location_IDTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.attenuationTextBox = new System.Windows.Forms.TextBox();
            this.devicesDataGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attenuationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inOutDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.timeLimitTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeLimitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxLocation = new System.Windows.Forms.ComboBox();
            this.timeLimitTextBox = new System.Windows.Forms.TextBox();
            this.devicesTableAdapter = new Pin_Control.PinDBDataSetTableAdapters.DevicesTableAdapter();
            this.tableAdapterManager = new Pin_Control.PinDBDataSetTableAdapters.TableAdapterManager();
            this.timeLimitTypeComboBox = new System.Windows.Forms.ComboBox();
            deviceLabel = new System.Windows.Forms.Label();
            iP_AddressLabel = new System.Windows.Forms.Label();
            portLabel = new System.Windows.Forms.Label();
            location_IDLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            attenuationLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            timeLimitLabel = new System.Windows.Forms.Label();
            timeLimitTypeLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.devicesBindingNavigator)).BeginInit();
            this.devicesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.devicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devicesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // deviceLabel
            // 
            deviceLabel.AutoSize = true;
            deviceLabel.Location = new System.Drawing.Point(45, 62);
            deviceLabel.Name = "deviceLabel";
            deviceLabel.Size = new System.Drawing.Size(44, 13);
            deviceLabel.TabIndex = 3;
            deviceLabel.Text = "Device:";
            // 
            // iP_AddressLabel
            // 
            iP_AddressLabel.AutoSize = true;
            iP_AddressLabel.Location = new System.Drawing.Point(28, 88);
            iP_AddressLabel.Name = "iP_AddressLabel";
            iP_AddressLabel.Size = new System.Drawing.Size(61, 13);
            iP_AddressLabel.TabIndex = 5;
            iP_AddressLabel.Text = "IP Address:";
            // 
            // portLabel
            // 
            portLabel.AutoSize = true;
            portLabel.Location = new System.Drawing.Point(43, 114);
            portLabel.Name = "portLabel";
            portLabel.Size = new System.Drawing.Size(46, 13);
            portLabel.TabIndex = 7;
            portLabel.Text = "Port No:";
            // 
            // location_IDLabel
            // 
            location_IDLabel.AutoSize = true;
            location_IDLabel.Enabled = false;
            location_IDLabel.Location = new System.Drawing.Point(562, 189);
            location_IDLabel.Name = "location_IDLabel";
            location_IDLabel.Size = new System.Drawing.Size(65, 13);
            location_IDLabel.TabIndex = 9;
            location_IDLabel.Text = "Location ID:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(49, 166);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(40, 13);
            statusLabel.TabIndex = 11;
            statusLabel.Text = "Status:";
            // 
            // attenuationLabel
            // 
            attenuationLabel.AutoSize = true;
            attenuationLabel.Location = new System.Drawing.Point(25, 192);
            attenuationLabel.Name = "attenuationLabel";
            attenuationLabel.Size = new System.Drawing.Size(64, 13);
            attenuationLabel.TabIndex = 13;
            attenuationLabel.Text = "Attenuation:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(8, 140);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(81, 13);
            label1.TabIndex = 17;
            label1.Text = "Select Location";
            // 
            // timeLimitLabel
            // 
            timeLimitLabel.AutoSize = true;
            timeLimitLabel.Location = new System.Drawing.Point(588, 73);
            timeLimitLabel.Name = "timeLimitLabel";
            timeLimitLabel.Size = new System.Drawing.Size(57, 13);
            timeLimitLabel.TabIndex = 20;
            timeLimitLabel.Text = "Time Limit:";
            // 
            // timeLimitTypeLabel1
            // 
            timeLimitTypeLabel1.AutoSize = true;
            timeLimitTypeLabel1.Location = new System.Drawing.Point(561, 46);
            timeLimitTypeLabel1.Name = "timeLimitTypeLabel1";
            timeLimitTypeLabel1.Size = new System.Drawing.Size(84, 13);
            timeLimitTypeLabel1.TabIndex = 21;
            timeLimitTypeLabel1.Text = "Time Limit Type:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // devicesBindingNavigator
            // 
            this.devicesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.devicesBindingNavigator.BindingSource = this.devicesBindingSource;
            this.devicesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.devicesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.devicesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.devicesBindingNavigatorSaveItem});
            this.devicesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.devicesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.devicesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.devicesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.devicesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.devicesBindingNavigator.Name = "devicesBindingNavigator";
            this.devicesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.devicesBindingNavigator.Size = new System.Drawing.Size(895, 25);
            this.devicesBindingNavigator.TabIndex = 0;
            this.devicesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // devicesBindingSource
            // 
            this.devicesBindingSource.DataMember = "Devices";
            this.devicesBindingSource.DataSource = this.pinDBDataSet;
            // 
            // pinDBDataSet
            // 
            this.pinDBDataSet.DataSetName = "PinDBDataSet";
            this.pinDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // devicesBindingNavigatorSaveItem
            // 
            this.devicesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.devicesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("devicesBindingNavigatorSaveItem.Image")));
            this.devicesBindingNavigatorSaveItem.Name = "devicesBindingNavigatorSaveItem";
            this.devicesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.devicesBindingNavigatorSaveItem.Text = "Save Data";
            this.devicesBindingNavigatorSaveItem.Click += new System.EventHandler(this.devicesBindingNavigatorSaveItem_Click);
            // 
            // deviceTextBox
            // 
            this.deviceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.devicesBindingSource, "Device", true));
            this.deviceTextBox.Location = new System.Drawing.Point(95, 59);
            this.deviceTextBox.Name = "deviceTextBox";
            this.deviceTextBox.Size = new System.Drawing.Size(350, 20);
            this.deviceTextBox.TabIndex = 4;
            // 
            // iP_AddressTextBox
            // 
            this.iP_AddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.devicesBindingSource, "IP_Address", true));
            this.iP_AddressTextBox.Location = new System.Drawing.Point(95, 85);
            this.iP_AddressTextBox.Name = "iP_AddressTextBox";
            this.iP_AddressTextBox.Size = new System.Drawing.Size(350, 20);
            this.iP_AddressTextBox.TabIndex = 6;
            // 
            // portTextBox
            // 
            this.portTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.devicesBindingSource, "Port", true));
            this.portTextBox.Location = new System.Drawing.Point(95, 111);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(350, 20);
            this.portTextBox.TabIndex = 8;
            // 
            // location_IDTextBox
            // 
            this.location_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.devicesBindingSource, "Location_ID", true));
            this.location_IDTextBox.Enabled = false;
            this.location_IDTextBox.Location = new System.Drawing.Point(642, 185);
            this.location_IDTextBox.Name = "location_IDTextBox";
            this.location_IDTextBox.Size = new System.Drawing.Size(215, 20);
            this.location_IDTextBox.TabIndex = 10;
            this.location_IDTextBox.TextChanged += new System.EventHandler(this.location_IDTextBox_TextChanged);
            // 
            // statusTextBox
            // 
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.devicesBindingSource, "Status", true));
            this.statusTextBox.Location = new System.Drawing.Point(95, 163);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(350, 20);
            this.statusTextBox.TabIndex = 12;
            // 
            // attenuationTextBox
            // 
            this.attenuationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.devicesBindingSource, "Attenuation", true));
            this.attenuationTextBox.Location = new System.Drawing.Point(95, 189);
            this.attenuationTextBox.Name = "attenuationTextBox";
            this.attenuationTextBox.Size = new System.Drawing.Size(350, 20);
            this.attenuationTextBox.TabIndex = 14;
            // 
            // devicesDataGridView
            // 
            this.devicesDataGridView.AllowUserToAddRows = false;
            this.devicesDataGridView.AllowUserToDeleteRows = false;
            this.devicesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.devicesDataGridView.AutoGenerateColumns = false;
            this.devicesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.devicesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.devicesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.deviceDataGridViewTextBoxColumn,
            this.iPAddressDataGridViewTextBoxColumn,
            this.portDataGridViewTextBoxColumn,
            this.locationIDDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.attenuationDataGridViewTextBoxColumn,
            this.inOutDataGridViewCheckBoxColumn,
            this.timeLimitTypeDataGridViewTextBoxColumn,
            this.timeLimitDataGridViewTextBoxColumn});
            this.devicesDataGridView.DataSource = this.devicesBindingSource;
            this.devicesDataGridView.Location = new System.Drawing.Point(11, 226);
            this.devicesDataGridView.Name = "devicesDataGridView";
            this.devicesDataGridView.Size = new System.Drawing.Size(859, 310);
            this.devicesDataGridView.TabIndex = 15;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // deviceDataGridViewTextBoxColumn
            // 
            this.deviceDataGridViewTextBoxColumn.DataPropertyName = "Device";
            this.deviceDataGridViewTextBoxColumn.HeaderText = "Device";
            this.deviceDataGridViewTextBoxColumn.Name = "deviceDataGridViewTextBoxColumn";
            // 
            // iPAddressDataGridViewTextBoxColumn
            // 
            this.iPAddressDataGridViewTextBoxColumn.DataPropertyName = "IP_Address";
            this.iPAddressDataGridViewTextBoxColumn.HeaderText = "IP_Address";
            this.iPAddressDataGridViewTextBoxColumn.Name = "iPAddressDataGridViewTextBoxColumn";
            // 
            // portDataGridViewTextBoxColumn
            // 
            this.portDataGridViewTextBoxColumn.DataPropertyName = "Port";
            this.portDataGridViewTextBoxColumn.HeaderText = "Port";
            this.portDataGridViewTextBoxColumn.Name = "portDataGridViewTextBoxColumn";
            // 
            // locationIDDataGridViewTextBoxColumn
            // 
            this.locationIDDataGridViewTextBoxColumn.DataPropertyName = "Location_ID";
            this.locationIDDataGridViewTextBoxColumn.HeaderText = "Location_ID";
            this.locationIDDataGridViewTextBoxColumn.Name = "locationIDDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // attenuationDataGridViewTextBoxColumn
            // 
            this.attenuationDataGridViewTextBoxColumn.DataPropertyName = "Attenuation";
            this.attenuationDataGridViewTextBoxColumn.HeaderText = "Attenuation";
            this.attenuationDataGridViewTextBoxColumn.Name = "attenuationDataGridViewTextBoxColumn";
            // 
            // inOutDataGridViewCheckBoxColumn
            // 
            this.inOutDataGridViewCheckBoxColumn.DataPropertyName = "In_Out";
            this.inOutDataGridViewCheckBoxColumn.HeaderText = "In_Out";
            this.inOutDataGridViewCheckBoxColumn.Name = "inOutDataGridViewCheckBoxColumn";
            // 
            // timeLimitTypeDataGridViewTextBoxColumn
            // 
            this.timeLimitTypeDataGridViewTextBoxColumn.DataPropertyName = "TimeLimitType";
            this.timeLimitTypeDataGridViewTextBoxColumn.HeaderText = "TimeLimitType";
            this.timeLimitTypeDataGridViewTextBoxColumn.Name = "timeLimitTypeDataGridViewTextBoxColumn";
            // 
            // timeLimitDataGridViewTextBoxColumn
            // 
            this.timeLimitDataGridViewTextBoxColumn.DataPropertyName = "TimeLimit";
            this.timeLimitDataGridViewTextBoxColumn.HeaderText = "TimeLimit";
            this.timeLimitDataGridViewTextBoxColumn.Name = "timeLimitDataGridViewTextBoxColumn";
            // 
            // cbxLocation
            // 
            this.cbxLocation.FormattingEnabled = true;
            this.cbxLocation.Location = new System.Drawing.Point(95, 137);
            this.cbxLocation.Name = "cbxLocation";
            this.cbxLocation.Size = new System.Drawing.Size(350, 21);
            this.cbxLocation.TabIndex = 16;
            this.cbxLocation.SelectedIndexChanged += new System.EventHandler(this.cbxLocation_SelectedIndexChanged);
            // 
            // timeLimitTextBox
            // 
            this.timeLimitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.devicesBindingSource, "TimeLimit", true));
            this.timeLimitTextBox.Location = new System.Drawing.Point(651, 70);
            this.timeLimitTextBox.Name = "timeLimitTextBox";
            this.timeLimitTextBox.Size = new System.Drawing.Size(215, 20);
            this.timeLimitTextBox.TabIndex = 21;
            // 
            // devicesTableAdapter
            // 
            this.devicesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Asset_CurrentLocationTableAdapter = null;
            this.tableAdapterManager.Asset_RegisterTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.Category_TypeTableAdapter = null;
            this.tableAdapterManager.DevicesTableAdapter = this.devicesTableAdapter;
            this.tableAdapterManager.Inventory_RegisterTableAdapter = null;
            this.tableAdapterManager.LocationTableAdapter = null;
            this.tableAdapterManager.Reader_EventsTableAdapter = null;
            this.tableAdapterManager.StatusTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.System_LogTableAdapter = null;
            this.tableAdapterManager.Track_EventsTableAdapter = null;
            this.tableAdapterManager.UnitOfMeasureTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Pin_Control.PinDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.User_RolesTableAdapter = null;
            this.tableAdapterManager.User_TrackEventsTableAdapter = null;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // timeLimitTypeComboBox
            // 
            this.timeLimitTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.devicesBindingSource, "TimeLimitType", true));
            this.timeLimitTypeComboBox.FormattingEnabled = true;
            this.timeLimitTypeComboBox.Items.AddRange(new object[] {
            "Seconds",
            "Minutes",
            "Hours",
            "Days"});
            this.timeLimitTypeComboBox.Location = new System.Drawing.Point(651, 43);
            this.timeLimitTypeComboBox.Name = "timeLimitTypeComboBox";
            this.timeLimitTypeComboBox.Size = new System.Drawing.Size(215, 21);
            this.timeLimitTypeComboBox.TabIndex = 22;
            // 
            // uc_Devices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(timeLimitTypeLabel1);
            this.Controls.Add(this.timeLimitTypeComboBox);
            this.Controls.Add(timeLimitLabel);
            this.Controls.Add(this.timeLimitTextBox);
            this.Controls.Add(label1);
            this.Controls.Add(this.cbxLocation);
            this.Controls.Add(this.devicesDataGridView);
            this.Controls.Add(deviceLabel);
            this.Controls.Add(this.deviceTextBox);
            this.Controls.Add(iP_AddressLabel);
            this.Controls.Add(this.iP_AddressTextBox);
            this.Controls.Add(portLabel);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(location_IDLabel);
            this.Controls.Add(this.location_IDTextBox);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(attenuationLabel);
            this.Controls.Add(this.attenuationTextBox);
            this.Controls.Add(this.devicesBindingNavigator);
            this.Name = "uc_Devices";
            this.Size = new System.Drawing.Size(895, 554);
            this.Load += new System.EventHandler(this.uc_Devices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.devicesBindingNavigator)).EndInit();
            this.devicesBindingNavigator.ResumeLayout(false);
            this.devicesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.devicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devicesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private PinDBDataSet pinDBDataSet;
        private System.Windows.Forms.BindingSource devicesBindingSource;
        private PinDBDataSetTableAdapters.DevicesTableAdapter devicesTableAdapter;
        private PinDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator devicesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton devicesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox deviceTextBox;
        private System.Windows.Forms.TextBox iP_AddressTextBox;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.TextBox location_IDTextBox;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.TextBox attenuationTextBox;
        private System.Windows.Forms.DataGridView devicesDataGridView;
        private System.Windows.Forms.ComboBox cbxLocation;
        private System.Windows.Forms.TextBox timeLimitTextBox;
        private System.Windows.Forms.ComboBox timeLimitTypeComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn portDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attenuationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn inOutDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeLimitTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeLimitDataGridViewTextBoxColumn;
    }
}
