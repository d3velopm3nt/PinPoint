namespace Pin_Control.User_Controls
{
    partial class uc_Suppliers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_Suppliers));
            System.Windows.Forms.Label supplierLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label contact_PersonLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label cellLabel;
            System.Windows.Forms.Label faxLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label statusLabel;
            this.pinDBDataSet = new Pin_Control.PinDBDataSet();
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suppliersTableAdapter = new Pin_Control.PinDBDataSetTableAdapters.SuppliersTableAdapter();
            this.tableAdapterManager = new Pin_Control.PinDBDataSetTableAdapters.TableAdapterManager();
            this.suppliersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.suppliersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.supplierTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.contact_PersonTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.cellTextBox = new System.Windows.Forms.TextBox();
            this.faxTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.suppliersDataGridView = new System.Windows.Forms.DataGridView();
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
            supplierLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            contact_PersonLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            cellLabel = new System.Windows.Forms.Label();
            faxLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pinDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingNavigator)).BeginInit();
            this.suppliersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pinDBDataSet
            // 
            this.pinDBDataSet.DataSetName = "PinDBDataSet";
            this.pinDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataMember = "Suppliers";
            this.suppliersBindingSource.DataSource = this.pinDBDataSet;
            // 
            // suppliersTableAdapter
            // 
            this.suppliersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Asset_CurrentLocationTableAdapter = null;
            this.tableAdapterManager.Asset_RegisterTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.Category_TypeTableAdapter = null;
            this.tableAdapterManager.DevicesTableAdapter = null;
            this.tableAdapterManager.Inventory_RegisterTableAdapter = null;
            this.tableAdapterManager.LocationTableAdapter = null;
            this.tableAdapterManager.Reader_EventsTableAdapter = null;
            this.tableAdapterManager.StatusTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = this.suppliersTableAdapter;
            this.tableAdapterManager.System_LogTableAdapter = null;
            this.tableAdapterManager.Track_EventsTableAdapter = null;
            this.tableAdapterManager.UnitOfMeasureTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Pin_Control.PinDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.User_RolesTableAdapter = null;
            this.tableAdapterManager.User_TrackEventsTableAdapter = null;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // suppliersBindingNavigator
            // 
            this.suppliersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.suppliersBindingNavigator.BindingSource = this.suppliersBindingSource;
            this.suppliersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.suppliersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.suppliersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.suppliersBindingNavigatorSaveItem});
            this.suppliersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.suppliersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.suppliersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.suppliersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.suppliersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.suppliersBindingNavigator.Name = "suppliersBindingNavigator";
            this.suppliersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.suppliersBindingNavigator.Size = new System.Drawing.Size(1080, 25);
            this.suppliersBindingNavigator.TabIndex = 0;
            this.suppliersBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // suppliersBindingNavigatorSaveItem
            // 
            this.suppliersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.suppliersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("suppliersBindingNavigatorSaveItem.Image")));
            this.suppliersBindingNavigatorSaveItem.Name = "suppliersBindingNavigatorSaveItem";
            this.suppliersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.suppliersBindingNavigatorSaveItem.Text = "Save Data";
            this.suppliersBindingNavigatorSaveItem.Click += new System.EventHandler(this.suppliersBindingNavigatorSaveItem_Click);
            // 
            // supplierLabel
            // 
            supplierLabel.AutoSize = true;
            supplierLabel.Location = new System.Drawing.Point(24, 69);
            supplierLabel.Name = "supplierLabel";
            supplierLabel.Size = new System.Drawing.Size(48, 13);
            supplierLabel.TabIndex = 1;
            supplierLabel.Text = "Supplier:";
            // 
            // supplierTextBox
            // 
            this.supplierTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "Supplier", true));
            this.supplierTextBox.Location = new System.Drawing.Point(113, 66);
            this.supplierTextBox.Name = "supplierTextBox";
            this.supplierTextBox.Size = new System.Drawing.Size(281, 20);
            this.supplierTextBox.TabIndex = 2;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(24, 95);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(27, 13);
            cityLabel.TabIndex = 3;
            cityLabel.Text = "City:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(113, 92);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(281, 20);
            this.cityTextBox.TabIndex = 4;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(24, 121);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 5;
            addressLabel.Text = "Address:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(113, 118);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(281, 20);
            this.addressTextBox.TabIndex = 6;
            // 
            // contact_PersonLabel
            // 
            contact_PersonLabel.AutoSize = true;
            contact_PersonLabel.Location = new System.Drawing.Point(428, 69);
            contact_PersonLabel.Name = "contact_PersonLabel";
            contact_PersonLabel.Size = new System.Drawing.Size(83, 13);
            contact_PersonLabel.TabIndex = 7;
            contact_PersonLabel.Text = "Contact Person:";
            // 
            // contact_PersonTextBox
            // 
            this.contact_PersonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "Contact_Person", true));
            this.contact_PersonTextBox.Location = new System.Drawing.Point(517, 66);
            this.contact_PersonTextBox.Name = "contact_PersonTextBox";
            this.contact_PersonTextBox.Size = new System.Drawing.Size(281, 20);
            this.contact_PersonTextBox.TabIndex = 8;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(428, 95);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(41, 13);
            phoneLabel.TabIndex = 9;
            phoneLabel.Text = "Phone:";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(517, 92);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(281, 20);
            this.phoneTextBox.TabIndex = 10;
            // 
            // cellLabel
            // 
            cellLabel.AutoSize = true;
            cellLabel.Location = new System.Drawing.Point(428, 121);
            cellLabel.Name = "cellLabel";
            cellLabel.Size = new System.Drawing.Size(27, 13);
            cellLabel.TabIndex = 11;
            cellLabel.Text = "Cell:";
            // 
            // cellTextBox
            // 
            this.cellTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "Cell", true));
            this.cellTextBox.Location = new System.Drawing.Point(517, 118);
            this.cellTextBox.Name = "cellTextBox";
            this.cellTextBox.Size = new System.Drawing.Size(281, 20);
            this.cellTextBox.TabIndex = 12;
            // 
            // faxLabel
            // 
            faxLabel.AutoSize = true;
            faxLabel.Location = new System.Drawing.Point(428, 147);
            faxLabel.Name = "faxLabel";
            faxLabel.Size = new System.Drawing.Size(27, 13);
            faxLabel.TabIndex = 13;
            faxLabel.Text = "Fax:";
            // 
            // faxTextBox
            // 
            this.faxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "Fax", true));
            this.faxTextBox.Location = new System.Drawing.Point(517, 144);
            this.faxTextBox.Name = "faxTextBox";
            this.faxTextBox.Size = new System.Drawing.Size(281, 20);
            this.faxTextBox.TabIndex = 14;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(24, 166);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 15;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(113, 163);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(281, 20);
            this.emailTextBox.TabIndex = 16;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(24, 192);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(40, 13);
            statusLabel.TabIndex = 17;
            statusLabel.Text = "Status:";
            // 
            // statusComboBox
            // 
            this.statusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "Status", true));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(113, 189);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(281, 21);
            this.statusComboBox.TabIndex = 18;
            // 
            // suppliersDataGridView
            // 
            this.suppliersDataGridView.AutoGenerateColumns = false;
            this.suppliersDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.suppliersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suppliersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.suppliersDataGridView.DataSource = this.suppliersBindingSource;
            this.suppliersDataGridView.Location = new System.Drawing.Point(14, 235);
            this.suppliersDataGridView.Name = "suppliersDataGridView";
            this.suppliersDataGridView.Size = new System.Drawing.Size(1050, 372);
            this.suppliersDataGridView.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Supplier";
            this.dataGridViewTextBoxColumn2.HeaderText = "Supplier";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "City";
            this.dataGridViewTextBoxColumn3.HeaderText = "City";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn4.HeaderText = "Address";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Contact_Person";
            this.dataGridViewTextBoxColumn5.HeaderText = "Contact_Person";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn6.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Cell";
            this.dataGridViewTextBoxColumn7.HeaderText = "Cell";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Fax";
            this.dataGridViewTextBoxColumn8.HeaderText = "Fax";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn9.HeaderText = "Email";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn10.HeaderText = "Status";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // uc_Suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.suppliersDataGridView);
            this.Controls.Add(supplierLabel);
            this.Controls.Add(this.supplierTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(contact_PersonLabel);
            this.Controls.Add(this.contact_PersonTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(cellLabel);
            this.Controls.Add(this.cellTextBox);
            this.Controls.Add(faxLabel);
            this.Controls.Add(this.faxTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.suppliersBindingNavigator);
            this.Name = "uc_Suppliers";
            this.Size = new System.Drawing.Size(1080, 621);
            this.Load += new System.EventHandler(this.uc_Suppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pinDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingNavigator)).EndInit();
            this.suppliersBindingNavigator.ResumeLayout(false);
            this.suppliersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PinDBDataSet pinDBDataSet;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private PinDBDataSetTableAdapters.SuppliersTableAdapter suppliersTableAdapter;
        private PinDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator suppliersBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton suppliersBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox supplierTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox contact_PersonTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox cellTextBox;
        private System.Windows.Forms.TextBox faxTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.DataGridView suppliersDataGridView;
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
    }
}
