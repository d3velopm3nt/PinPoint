namespace Pin_Control.User_Controls
{
    partial class uc_Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_Reports));
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblCategoryType = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxEmployee = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.chkDate = new System.Windows.Forms.CheckBox();
            this.cbxUser = new System.Windows.Forms.CheckBox();
            this.chkName = new System.Windows.Forms.CheckBox();
            this.rbnTrackEvents = new System.Windows.Forms.RadioButton();
            this.rbnUserEvents = new System.Windows.Forms.RadioButton();
            this.rbnAlerts = new System.Windows.Forms.RadioButton();
            this.pinDBDataSet = new Pin_Control.PinDBDataSet();
            this.assetRegisterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asset_RegisterTableAdapter = new Pin_Control.PinDBDataSetTableAdapters.Asset_RegisterTableAdapter();
            this.lblAsset = new System.Windows.Forms.Label();
            this.cbxAsset = new System.Windows.Forms.ComboBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.pbCategory = new System.Windows.Forms.PictureBox();
            this.pbType = new System.Windows.Forms.PictureBox();
            this.pbAsset = new System.Windows.Forms.PictureBox();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.pbDate = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetRegisterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAsset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDate)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(30, 80);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(200, 21);
            this.cbxCategory.TabIndex = 0;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // cbxType
            // 
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(30, 132);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(200, 21);
            this.cbxType.TabIndex = 1;
            this.cbxType.SelectedIndexChanged += new System.EventHandler(this.cbxType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Create Report";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(27, 62);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(58, 15);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Category:";
            // 
            // lblCategoryType
            // 
            this.lblCategoryType.AutoSize = true;
            this.lblCategoryType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryType.Location = new System.Drawing.Point(27, 114);
            this.lblCategoryType.Name = "lblCategoryType";
            this.lblCategoryType.Size = new System.Drawing.Size(87, 15);
            this.lblCategoryType.TabIndex = 4;
            this.lblCategoryType.Text = "Category Type:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(33, 332);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(33, 380);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 6;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Start Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "End Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Employee Name:";
            // 
            // cbxEmployee
            // 
            this.cbxEmployee.FormattingEnabled = true;
            this.cbxEmployee.Location = new System.Drawing.Point(31, 260);
            this.cbxEmployee.Name = "cbxEmployee";
            this.cbxEmployee.Size = new System.Drawing.Size(200, 21);
            this.cbxEmployee.TabIndex = 9;
            this.cbxEmployee.SelectedIndexChanged += new System.EventHandler(this.cbxEmployee_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 544);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(30, 573);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(268, 62);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(665, 534);
            this.dataGridView2.TabIndex = 12;
            // 
            // chkDate
            // 
            this.chkDate.AutoSize = true;
            this.chkDate.Checked = true;
            this.chkDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDate.Location = new System.Drawing.Point(126, 406);
            this.chkDate.Name = "chkDate";
            this.chkDate.Size = new System.Drawing.Size(107, 17);
            this.chkDate.TabIndex = 17;
            this.chkDate.Text = "Include in search";
            this.chkDate.UseVisualStyleBackColor = true;
            this.chkDate.CheckedChanged += new System.EventHandler(this.chkDate_CheckedChanged);
            // 
            // cbxUser
            // 
            this.cbxUser.AutoSize = true;
            this.cbxUser.Checked = true;
            this.cbxUser.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxUser.Location = new System.Drawing.Point(123, 287);
            this.cbxUser.Name = "cbxUser";
            this.cbxUser.Size = new System.Drawing.Size(107, 17);
            this.cbxUser.TabIndex = 18;
            this.cbxUser.Text = "Include in search";
            this.cbxUser.UseVisualStyleBackColor = true;
            this.cbxUser.CheckedChanged += new System.EventHandler(this.cbxUser_CheckedChanged);
            // 
            // chkName
            // 
            this.chkName.AutoSize = true;
            this.chkName.Checked = true;
            this.chkName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkName.Location = new System.Drawing.Point(124, 210);
            this.chkName.Name = "chkName";
            this.chkName.Size = new System.Drawing.Size(107, 17);
            this.chkName.TabIndex = 19;
            this.chkName.Text = "Include in search";
            this.chkName.UseVisualStyleBackColor = true;
            this.chkName.CheckedChanged += new System.EventHandler(this.chkName_CheckedChanged);
            // 
            // rbnTrackEvents
            // 
            this.rbnTrackEvents.AutoSize = true;
            this.rbnTrackEvents.Checked = true;
            this.rbnTrackEvents.Location = new System.Drawing.Point(33, 462);
            this.rbnTrackEvents.Name = "rbnTrackEvents";
            this.rbnTrackEvents.Size = new System.Drawing.Size(89, 17);
            this.rbnTrackEvents.TabIndex = 20;
            this.rbnTrackEvents.TabStop = true;
            this.rbnTrackEvents.Text = "Track Events";
            this.rbnTrackEvents.UseVisualStyleBackColor = true;
            this.rbnTrackEvents.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbnUserEvents
            // 
            this.rbnUserEvents.AutoSize = true;
            this.rbnUserEvents.Location = new System.Drawing.Point(33, 485);
            this.rbnUserEvents.Name = "rbnUserEvents";
            this.rbnUserEvents.Size = new System.Drawing.Size(184, 17);
            this.rbnUserEvents.TabIndex = 21;
            this.rbnUserEvents.TabStop = true;
            this.rbnUserEvents.Text = "User Events (Asset filter not used)";
            this.rbnUserEvents.UseVisualStyleBackColor = true;
            this.rbnUserEvents.CheckedChanged += new System.EventHandler(this.rbnUserEvents_CheckedChanged);
            // 
            // rbnAlerts
            // 
            this.rbnAlerts.AutoSize = true;
            this.rbnAlerts.Location = new System.Drawing.Point(33, 508);
            this.rbnAlerts.Name = "rbnAlerts";
            this.rbnAlerts.Size = new System.Drawing.Size(51, 17);
            this.rbnAlerts.TabIndex = 22;
            this.rbnAlerts.TabStop = true;
            this.rbnAlerts.Text = "Alerts";
            this.rbnAlerts.UseVisualStyleBackColor = true;
            this.rbnAlerts.CheckedChanged += new System.EventHandler(this.rbnAlerts_CheckedChanged);
            // 
            // pinDBDataSet
            // 
            this.pinDBDataSet.DataSetName = "PinDBDataSet";
            this.pinDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assetRegisterBindingSource
            // 
            this.assetRegisterBindingSource.DataMember = "Asset_Register";
            this.assetRegisterBindingSource.DataSource = this.pinDBDataSet;
            // 
            // asset_RegisterTableAdapter
            // 
            this.asset_RegisterTableAdapter.ClearBeforeFill = true;
            // 
            // lblAsset
            // 
            this.lblAsset.AutoSize = true;
            this.lblAsset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsset.Location = new System.Drawing.Point(29, 165);
            this.lblAsset.Name = "lblAsset";
            this.lblAsset.Size = new System.Drawing.Size(36, 15);
            this.lblAsset.TabIndex = 24;
            this.lblAsset.Text = "Asset";
            // 
            // cbxAsset
            // 
            this.cbxAsset.FormattingEnabled = true;
            this.cbxAsset.Location = new System.Drawing.Point(32, 183);
            this.cbxAsset.Name = "cbxAsset";
            this.cbxAsset.Size = new System.Drawing.Size(200, 21);
            this.cbxAsset.TabIndex = 23;
            this.cbxAsset.SelectedIndexChanged += new System.EventHandler(this.cbxAsset_SelectedIndexChanged);
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(265, 43);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(99, 16);
            this.lblResults.TabIndex = 25;
            this.lblResults.Text = "Search Results";
            // 
            // pbCategory
            // 
            this.pbCategory.Image = ((System.Drawing.Image)(resources.GetObject("pbCategory.Image")));
            this.pbCategory.Location = new System.Drawing.Point(236, 80);
            this.pbCategory.Name = "pbCategory";
            this.pbCategory.Size = new System.Drawing.Size(18, 21);
            this.pbCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCategory.TabIndex = 184;
            this.pbCategory.TabStop = false;
            // 
            // pbType
            // 
            this.pbType.Image = ((System.Drawing.Image)(resources.GetObject("pbType.Image")));
            this.pbType.Location = new System.Drawing.Point(236, 132);
            this.pbType.Name = "pbType";
            this.pbType.Size = new System.Drawing.Size(18, 21);
            this.pbType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbType.TabIndex = 185;
            this.pbType.TabStop = false;
            // 
            // pbAsset
            // 
            this.pbAsset.Image = ((System.Drawing.Image)(resources.GetObject("pbAsset.Image")));
            this.pbAsset.Location = new System.Drawing.Point(236, 183);
            this.pbAsset.Name = "pbAsset";
            this.pbAsset.Size = new System.Drawing.Size(18, 21);
            this.pbAsset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAsset.TabIndex = 186;
            this.pbAsset.TabStop = false;
            // 
            // pbUser
            // 
            this.pbUser.Image = ((System.Drawing.Image)(resources.GetObject("pbUser.Image")));
            this.pbUser.Location = new System.Drawing.Point(236, 260);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(18, 21);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUser.TabIndex = 187;
            this.pbUser.TabStop = false;
            // 
            // pbDate
            // 
            this.pbDate.Image = ((System.Drawing.Image)(resources.GetObject("pbDate.Image")));
            this.pbDate.Location = new System.Drawing.Point(236, 331);
            this.pbDate.Name = "pbDate";
            this.pbDate.Size = new System.Drawing.Size(18, 21);
            this.pbDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDate.TabIndex = 188;
            this.pbDate.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 440);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 190;
            this.label2.Text = "Search By:";
            // 
            // uc_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbDate);
            this.Controls.Add(this.pbUser);
            this.Controls.Add(this.pbAsset);
            this.Controls.Add(this.pbType);
            this.Controls.Add(this.pbCategory);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.lblAsset);
            this.Controls.Add(this.cbxAsset);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.rbnAlerts);
            this.Controls.Add(this.rbnUserEvents);
            this.Controls.Add(this.rbnTrackEvents);
            this.Controls.Add(this.chkName);
            this.Controls.Add(this.cbxUser);
            this.Controls.Add(this.chkDate);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxEmployee);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblCategoryType);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxType);
            this.Controls.Add(this.cbxCategory);
            this.Name = "uc_Reports";
            this.Size = new System.Drawing.Size(956, 620);
            this.Load += new System.EventHandler(this.uc_Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetRegisterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAsset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblCategoryType;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxEmployee;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.CheckBox chkDate;
        private System.Windows.Forms.CheckBox cbxUser;
        private System.Windows.Forms.CheckBox chkName;
        private System.Windows.Forms.RadioButton rbnTrackEvents;
        private System.Windows.Forms.RadioButton rbnUserEvents;
        private System.Windows.Forms.RadioButton rbnAlerts;
        private System.Windows.Forms.BindingSource assetRegisterBindingSource;
        private PinDBDataSet pinDBDataSet;
        private PinDBDataSetTableAdapters.Asset_RegisterTableAdapter asset_RegisterTableAdapter;
        private System.Windows.Forms.Label lblAsset;
        private System.Windows.Forms.ComboBox cbxAsset;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.PictureBox pbCategory;
        private System.Windows.Forms.PictureBox pbType;
        private System.Windows.Forms.PictureBox pbAsset;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.PictureBox pbDate;
        private System.Windows.Forms.Label label2;
    }
}
