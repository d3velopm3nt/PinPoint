namespace Pin_Control.User_Controls
{
    partial class uc_UnitofMeasure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_UnitofMeasure));
            System.Windows.Forms.Label unitMeasureLabel;
            this.pinDBDataSet = new Pin_Control.PinDBDataSet();
            this.unitOfMeasureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unitOfMeasureTableAdapter = new Pin_Control.PinDBDataSetTableAdapters.UnitOfMeasureTableAdapter();
            this.tableAdapterManager = new Pin_Control.PinDBDataSetTableAdapters.TableAdapterManager();
            this.unitOfMeasureBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.unitOfMeasureBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.unitMeasureTextBox = new System.Windows.Forms.TextBox();
            this.unitOfMeasureDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            unitMeasureLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pinDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfMeasureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfMeasureBindingNavigator)).BeginInit();
            this.unitOfMeasureBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfMeasureDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pinDBDataSet
            // 
            this.pinDBDataSet.DataSetName = "PinDBDataSet";
            this.pinDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // unitOfMeasureBindingSource
            // 
            this.unitOfMeasureBindingSource.DataMember = "UnitOfMeasure";
            this.unitOfMeasureBindingSource.DataSource = this.pinDBDataSet;
            // 
            // unitOfMeasureTableAdapter
            // 
            this.unitOfMeasureTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.System_LogTableAdapter = null;
            this.tableAdapterManager.Track_EventsTableAdapter = null;
            this.tableAdapterManager.UnitOfMeasureTableAdapter = this.unitOfMeasureTableAdapter;
            this.tableAdapterManager.UpdateOrder = Pin_Control.PinDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.User_RolesTableAdapter = null;
            this.tableAdapterManager.User_TrackEventsTableAdapter = null;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // unitOfMeasureBindingNavigator
            // 
            this.unitOfMeasureBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.unitOfMeasureBindingNavigator.BindingSource = this.unitOfMeasureBindingSource;
            this.unitOfMeasureBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.unitOfMeasureBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.unitOfMeasureBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.unitOfMeasureBindingNavigatorSaveItem});
            this.unitOfMeasureBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.unitOfMeasureBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.unitOfMeasureBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.unitOfMeasureBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.unitOfMeasureBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.unitOfMeasureBindingNavigator.Name = "unitOfMeasureBindingNavigator";
            this.unitOfMeasureBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.unitOfMeasureBindingNavigator.Size = new System.Drawing.Size(643, 25);
            this.unitOfMeasureBindingNavigator.TabIndex = 0;
            this.unitOfMeasureBindingNavigator.Text = "bindingNavigator1";
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
            // unitOfMeasureBindingNavigatorSaveItem
            // 
            this.unitOfMeasureBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.unitOfMeasureBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("unitOfMeasureBindingNavigatorSaveItem.Image")));
            this.unitOfMeasureBindingNavigatorSaveItem.Name = "unitOfMeasureBindingNavigatorSaveItem";
            this.unitOfMeasureBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.unitOfMeasureBindingNavigatorSaveItem.Text = "Save Data";
            this.unitOfMeasureBindingNavigatorSaveItem.Click += new System.EventHandler(this.unitOfMeasureBindingNavigatorSaveItem_Click);
            // 
            // unitMeasureLabel
            // 
            unitMeasureLabel.AutoSize = true;
            unitMeasureLabel.Location = new System.Drawing.Point(35, 66);
            unitMeasureLabel.Name = "unitMeasureLabel";
            unitMeasureLabel.Size = new System.Drawing.Size(73, 13);
            unitMeasureLabel.TabIndex = 1;
            unitMeasureLabel.Text = "Unit Measure:";
            // 
            // unitMeasureTextBox
            // 
            this.unitMeasureTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unitOfMeasureBindingSource, "UnitMeasure", true));
            this.unitMeasureTextBox.Location = new System.Drawing.Point(114, 63);
            this.unitMeasureTextBox.Name = "unitMeasureTextBox";
            this.unitMeasureTextBox.Size = new System.Drawing.Size(155, 20);
            this.unitMeasureTextBox.TabIndex = 2;
            // 
            // unitOfMeasureDataGridView
            // 
            this.unitOfMeasureDataGridView.AutoGenerateColumns = false;
            this.unitOfMeasureDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.unitOfMeasureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.unitOfMeasureDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.unitOfMeasureDataGridView.DataSource = this.unitOfMeasureBindingSource;
            this.unitOfMeasureDataGridView.Location = new System.Drawing.Point(295, 63);
            this.unitOfMeasureDataGridView.Name = "unitOfMeasureDataGridView";
            this.unitOfMeasureDataGridView.Size = new System.Drawing.Size(248, 406);
            this.unitOfMeasureDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "UnitMeasure";
            this.dataGridViewTextBoxColumn2.HeaderText = "UnitMeasure";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // uc_UnitofMeasure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.unitOfMeasureDataGridView);
            this.Controls.Add(unitMeasureLabel);
            this.Controls.Add(this.unitMeasureTextBox);
            this.Controls.Add(this.unitOfMeasureBindingNavigator);
            this.Name = "uc_UnitofMeasure";
            this.Size = new System.Drawing.Size(643, 491);
            this.Load += new System.EventHandler(this.uc_UnitofMeasure_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pinDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfMeasureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfMeasureBindingNavigator)).EndInit();
            this.unitOfMeasureBindingNavigator.ResumeLayout(false);
            this.unitOfMeasureBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfMeasureDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PinDBDataSet pinDBDataSet;
        private System.Windows.Forms.BindingSource unitOfMeasureBindingSource;
        private PinDBDataSetTableAdapters.UnitOfMeasureTableAdapter unitOfMeasureTableAdapter;
        private PinDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator unitOfMeasureBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton unitOfMeasureBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox unitMeasureTextBox;
        private System.Windows.Forms.DataGridView unitOfMeasureDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}
