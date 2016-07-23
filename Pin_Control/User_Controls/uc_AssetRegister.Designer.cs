namespace Pin_Control.User_Controls
{
    partial class uc_AssetRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_AssetRegister));
            this.tcAssetRegister = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pbRFID = new System.Windows.Forms.PictureBox();
            this.pbType = new System.Windows.Forms.PictureBox();
            this.pbSerial = new System.Windows.Forms.PictureBox();
            this.pbCategory = new System.Windows.Forms.PictureBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtRFID = new System.Windows.Forms.TextBox();
            this.lblRFID = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.lblSerial = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rFIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assetRegisterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pinDBDataSet = new Pin_Control.PinDBDataSet();
            this.asset_RegisterTableAdapter = new Pin_Control.PinDBDataSetTableAdapters.Asset_RegisterTableAdapter();
            this.tcAssetRegister.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRFID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSerial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCategory)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetRegisterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tcAssetRegister
            // 
            this.tcAssetRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcAssetRegister.Controls.Add(this.tabPage1);
            this.tcAssetRegister.Controls.Add(this.tabPage2);
            this.tcAssetRegister.Controls.Add(this.tabPage3);
            this.tcAssetRegister.Location = new System.Drawing.Point(3, 3);
            this.tcAssetRegister.Name = "tcAssetRegister";
            this.tcAssetRegister.SelectedIndex = 0;
            this.tcAssetRegister.Size = new System.Drawing.Size(989, 576);
            this.tcAssetRegister.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(981, 550);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Get RFID";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pbRFID);
            this.tabPage2.Controls.Add(this.pbType);
            this.tabPage2.Controls.Add(this.pbSerial);
            this.tabPage2.Controls.Add(this.pbCategory);
            this.tabPage2.Controls.Add(this.txtMessage);
            this.tabPage2.Controls.Add(this.txtDescription);
            this.tabPage2.Controls.Add(this.btnClear);
            this.tabPage2.Controls.Add(this.btnSave);
            this.tabPage2.Controls.Add(this.txtRFID);
            this.tabPage2.Controls.Add(this.lblRFID);
            this.tabPage2.Controls.Add(this.lblDescription);
            this.tabPage2.Controls.Add(this.cbxType);
            this.tabPage2.Controls.Add(this.lblType);
            this.tabPage2.Controls.Add(this.cbxCategory);
            this.tabPage2.Controls.Add(this.lblCategory);
            this.tabPage2.Controls.Add(this.txtSerial);
            this.tabPage2.Controls.Add(this.lblSerial);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(981, 550);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Asset Details";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pbRFID
            // 
            this.pbRFID.Image = ((System.Drawing.Image)(resources.GetObject("pbRFID.Image")));
            this.pbRFID.Location = new System.Drawing.Point(695, 19);
            this.pbRFID.Name = "pbRFID";
            this.pbRFID.Size = new System.Drawing.Size(18, 21);
            this.pbRFID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRFID.TabIndex = 185;
            this.pbRFID.TabStop = false;
            // 
            // pbType
            // 
            this.pbType.Image = ((System.Drawing.Image)(resources.GetObject("pbType.Image")));
            this.pbType.Location = new System.Drawing.Point(343, 87);
            this.pbType.Name = "pbType";
            this.pbType.Size = new System.Drawing.Size(18, 21);
            this.pbType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbType.TabIndex = 184;
            this.pbType.TabStop = false;
            // 
            // pbSerial
            // 
            this.pbSerial.Image = ((System.Drawing.Image)(resources.GetObject("pbSerial.Image")));
            this.pbSerial.Location = new System.Drawing.Point(343, 21);
            this.pbSerial.Name = "pbSerial";
            this.pbSerial.Size = new System.Drawing.Size(18, 21);
            this.pbSerial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSerial.TabIndex = 183;
            this.pbSerial.TabStop = false;
            // 
            // pbCategory
            // 
            this.pbCategory.Image = ((System.Drawing.Image)(resources.GetObject("pbCategory.Image")));
            this.pbCategory.Location = new System.Drawing.Point(343, 53);
            this.pbCategory.Name = "pbCategory";
            this.pbCategory.Size = new System.Drawing.Size(18, 21);
            this.pbCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCategory.TabIndex = 182;
            this.pbCategory.TabStop = false;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(100, 331);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(591, 20);
            this.txtMessage.TabIndex = 181;
            this.txtMessage.Text = "Register a new asset ";
            this.txtMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(100, 120);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(589, 143);
            this.txtDescription.TabIndex = 180;
            this.txtDescription.Text = "";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(222, 280);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 27);
            this.btnClear.TabIndex = 179;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(98, 280);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 27);
            this.btnSave.TabIndex = 178;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtRFID
            // 
            this.txtRFID.BackColor = System.Drawing.SystemColors.Window;
            this.txtRFID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRFID.Location = new System.Drawing.Point(453, 20);
            this.txtRFID.MaxLength = 24;
            this.txtRFID.Name = "txtRFID";
            this.txtRFID.Size = new System.Drawing.Size(236, 20);
            this.txtRFID.TabIndex = 177;
            this.txtRFID.TextChanged += new System.EventHandler(this.txtRFID_TextChanged);
            // 
            // lblRFID
            // 
            this.lblRFID.AutoSize = true;
            this.lblRFID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRFID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRFID.Location = new System.Drawing.Point(403, 22);
            this.lblRFID.Name = "lblRFID";
            this.lblRFID.Size = new System.Drawing.Size(35, 15);
            this.lblRFID.TabIndex = 176;
            this.lblRFID.Text = "RFID";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDescription.Location = new System.Drawing.Point(16, 120);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(69, 15);
            this.lblDescription.TabIndex = 174;
            this.lblDescription.Text = "Description";
            // 
            // cbxType
            // 
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(100, 87);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(237, 21);
            this.cbxType.TabIndex = 173;
            this.cbxType.SelectedIndexChanged += new System.EventHandler(this.cbxType_SelectedIndexChanged);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblType.Location = new System.Drawing.Point(16, 87);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(33, 15);
            this.lblType.TabIndex = 172;
            this.lblType.Text = "Type";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(100, 53);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(237, 21);
            this.cbxCategory.TabIndex = 171;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCategory.Location = new System.Drawing.Point(16, 53);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(55, 15);
            this.lblCategory.TabIndex = 170;
            this.lblCategory.Text = "Category";
            // 
            // txtSerial
            // 
            this.txtSerial.BackColor = System.Drawing.SystemColors.Window;
            this.txtSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerial.Location = new System.Drawing.Point(100, 21);
            this.txtSerial.MaxLength = 50;
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(237, 20);
            this.txtSerial.TabIndex = 169;
            this.txtSerial.TextChanged += new System.EventHandler(this.txtSerial_TextChanged);
            // 
            // lblSerial
            // 
            this.lblSerial.AutoSize = true;
            this.lblSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerial.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSerial.Location = new System.Drawing.Point(16, 21);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(58, 15);
            this.lblSerial.TabIndex = 168;
            this.lblSerial.Text = "Serial No";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(981, 550);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Asset Register";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.rFIDDataGridViewTextBoxColumn,
            this.ownerDataGridViewTextBoxColumn,
            this.categoryTypeIDDataGridViewTextBoxColumn,
            this.serialNoDataGridViewTextBoxColumn,
            this.dateTimeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.currentLocationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.assetRegisterBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(972, 541);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rFIDDataGridViewTextBoxColumn
            // 
            this.rFIDDataGridViewTextBoxColumn.DataPropertyName = "RFID";
            this.rFIDDataGridViewTextBoxColumn.HeaderText = "RFID";
            this.rFIDDataGridViewTextBoxColumn.Name = "rFIDDataGridViewTextBoxColumn";
            // 
            // ownerDataGridViewTextBoxColumn
            // 
            this.ownerDataGridViewTextBoxColumn.DataPropertyName = "Owner";
            this.ownerDataGridViewTextBoxColumn.HeaderText = "Owner";
            this.ownerDataGridViewTextBoxColumn.Name = "ownerDataGridViewTextBoxColumn";
            // 
            // categoryTypeIDDataGridViewTextBoxColumn
            // 
            this.categoryTypeIDDataGridViewTextBoxColumn.DataPropertyName = "Category_Type_ID";
            this.categoryTypeIDDataGridViewTextBoxColumn.HeaderText = "Category_Type_ID";
            this.categoryTypeIDDataGridViewTextBoxColumn.Name = "categoryTypeIDDataGridViewTextBoxColumn";
            // 
            // serialNoDataGridViewTextBoxColumn
            // 
            this.serialNoDataGridViewTextBoxColumn.DataPropertyName = "Serial_No";
            this.serialNoDataGridViewTextBoxColumn.HeaderText = "Serial_No";
            this.serialNoDataGridViewTextBoxColumn.Name = "serialNoDataGridViewTextBoxColumn";
            // 
            // dateTimeDataGridViewTextBoxColumn
            // 
            this.dateTimeDataGridViewTextBoxColumn.DataPropertyName = "Date_Time";
            this.dateTimeDataGridViewTextBoxColumn.HeaderText = "Date_Time";
            this.dateTimeDataGridViewTextBoxColumn.Name = "dateTimeDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // currentLocationDataGridViewTextBoxColumn
            // 
            this.currentLocationDataGridViewTextBoxColumn.DataPropertyName = "Current_Location";
            this.currentLocationDataGridViewTextBoxColumn.HeaderText = "Current_Location";
            this.currentLocationDataGridViewTextBoxColumn.Name = "currentLocationDataGridViewTextBoxColumn";
            // 
            // assetRegisterBindingSource
            // 
            this.assetRegisterBindingSource.DataMember = "Asset_Register";
            this.assetRegisterBindingSource.DataSource = this.pinDBDataSet;
            // 
            // pinDBDataSet
            // 
            this.pinDBDataSet.DataSetName = "PinDBDataSet";
            this.pinDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // asset_RegisterTableAdapter
            // 
            this.asset_RegisterTableAdapter.ClearBeforeFill = true;
            // 
            // uc_AssetRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcAssetRegister);
            this.Name = "uc_AssetRegister";
            this.Size = new System.Drawing.Size(995, 589);
            this.Load += new System.EventHandler(this.uc_AssetRegister_Load);
            this.tcAssetRegister.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRFID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSerial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCategory)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetRegisterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcAssetRegister;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblSerial;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblCategory;
        internal System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.TextBox txtRFID;
        private System.Windows.Forms.Label lblRFID;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rFIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentLocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource assetRegisterBindingSource;
        private PinDBDataSet pinDBDataSet;
        private PinDBDataSetTableAdapters.Asset_RegisterTableAdapter asset_RegisterTableAdapter;
        private System.Windows.Forms.PictureBox pbType;
        private System.Windows.Forms.PictureBox pbSerial;
        private System.Windows.Forms.PictureBox pbCategory;
        private System.Windows.Forms.PictureBox pbRFID;
    }
}
