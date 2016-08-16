namespace Pin_Control
{
    partial class frmPinPoint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPinPoint));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPinPoint = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panelNav = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDeviceController = new System.Windows.Forms.Button();
            this.btnEventManager = new System.Windows.Forms.Button();
            this.btnConfiguration = new System.Windows.Forms.Button();
            this.btnAssetRegister = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnAlerts = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer_Alerts = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.panel2);
            this.pnlMain.Controls.Add(this.pictureBox6);
            this.pnlMain.Controls.Add(this.panelNav);
            this.pnlMain.Controls.Add(this.flowLayoutPanel1);
            this.pnlMain.Controls.Add(this.menuStrip1);
            this.pnlMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1072, 555);
            this.pnlMain.TabIndex = 0;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.lblPinPoint);
            this.panel2.Location = new System.Drawing.Point(24, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 43);
            this.panel2.TabIndex = 5;
            // 
            // lblPinPoint
            // 
            this.lblPinPoint.AutoSize = true;
            this.lblPinPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPinPoint.ForeColor = System.Drawing.Color.White;
            this.lblPinPoint.Location = new System.Drawing.Point(9, 9);
            this.lblPinPoint.Name = "lblPinPoint";
            this.lblPinPoint.Size = new System.Drawing.Size(244, 25);
            this.lblPinPoint.TabIndex = 0;
            this.lblPinPoint.Text = "PIN-POINT TRACKING ";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(281, 30);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(47, 43);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 4;
            this.pictureBox6.TabStop = false;
            // 
            // panelNav
            // 
            this.panelNav.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNav.BackColor = System.Drawing.Color.White;
            this.panelNav.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelNav.Location = new System.Drawing.Point(281, 76);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(779, 476);
            this.panelNav.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.btnDeviceController);
            this.flowLayoutPanel1.Controls.Add(this.btnEventManager);
            this.flowLayoutPanel1.Controls.Add(this.btnConfiguration);
            this.flowLayoutPanel1.Controls.Add(this.btnAssetRegister);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.btnReports);
            this.flowLayoutPanel1.Controls.Add(this.btnAlerts);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(21, 76);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(254, 478);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnDeviceController
            // 
            this.btnDeviceController.BackColor = System.Drawing.Color.White;
            this.btnDeviceController.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnDeviceController.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnDeviceController.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnDeviceController.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeviceController.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeviceController.Image = ((System.Drawing.Image)(resources.GetObject("btnDeviceController.Image")));
            this.btnDeviceController.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeviceController.Location = new System.Drawing.Point(3, 3);
            this.btnDeviceController.Name = "btnDeviceController";
            this.btnDeviceController.Size = new System.Drawing.Size(247, 48);
            this.btnDeviceController.TabIndex = 0;
            this.btnDeviceController.Text = "Device Controller";
            this.btnDeviceController.UseVisualStyleBackColor = false;
            this.btnDeviceController.Click += new System.EventHandler(this.btnDeviceController_Click);
            // 
            // btnEventManager
            // 
            this.btnEventManager.BackColor = System.Drawing.Color.White;
            this.btnEventManager.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEventManager.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnEventManager.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnEventManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEventManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventManager.Image = ((System.Drawing.Image)(resources.GetObject("btnEventManager.Image")));
            this.btnEventManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEventManager.Location = new System.Drawing.Point(3, 57);
            this.btnEventManager.Name = "btnEventManager";
            this.btnEventManager.Size = new System.Drawing.Size(247, 45);
            this.btnEventManager.TabIndex = 1;
            this.btnEventManager.Text = "Event Viewer";
            this.btnEventManager.UseVisualStyleBackColor = false;
            this.btnEventManager.Click += new System.EventHandler(this.btnEventManager_Click);
            // 
            // btnConfiguration
            // 
            this.btnConfiguration.BackColor = System.Drawing.Color.White;
            this.btnConfiguration.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConfiguration.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnConfiguration.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnConfiguration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguration.Image = ((System.Drawing.Image)(resources.GetObject("btnConfiguration.Image")));
            this.btnConfiguration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguration.Location = new System.Drawing.Point(3, 108);
            this.btnConfiguration.Name = "btnConfiguration";
            this.btnConfiguration.Size = new System.Drawing.Size(247, 45);
            this.btnConfiguration.TabIndex = 3;
            this.btnConfiguration.Text = "Configuration";
            this.btnConfiguration.UseVisualStyleBackColor = false;
            this.btnConfiguration.Click += new System.EventHandler(this.btnConfiguration_Click);
            // 
            // btnAssetRegister
            // 
            this.btnAssetRegister.BackColor = System.Drawing.Color.White;
            this.btnAssetRegister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAssetRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnAssetRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnAssetRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssetRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssetRegister.Image = ((System.Drawing.Image)(resources.GetObject("btnAssetRegister.Image")));
            this.btnAssetRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssetRegister.Location = new System.Drawing.Point(3, 159);
            this.btnAssetRegister.Name = "btnAssetRegister";
            this.btnAssetRegister.Size = new System.Drawing.Size(247, 45);
            this.btnAssetRegister.TabIndex = 6;
            this.btnAssetRegister.Text = "Asset Register";
            this.btnAssetRegister.UseVisualStyleBackColor = false;
            this.btnAssetRegister.Click += new System.EventHandler(this.btnAssetRegister_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "Inventory Control";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(3, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(247, 45);
            this.button2.TabIndex = 8;
            this.button2.Text = "Inspections";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.White;
            this.btnReports.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Image = ((System.Drawing.Image)(resources.GetObject("btnReports.Image")));
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(3, 312);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(247, 45);
            this.btnReports.TabIndex = 5;
            this.btnReports.Text = " Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnAlerts
            // 
            this.btnAlerts.BackColor = System.Drawing.Color.White;
            this.btnAlerts.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAlerts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnAlerts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnAlerts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlerts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlerts.Image = ((System.Drawing.Image)(resources.GetObject("btnAlerts.Image")));
            this.btnAlerts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlerts.Location = new System.Drawing.Point(3, 363);
            this.btnAlerts.Name = "btnAlerts";
            this.btnAlerts.Size = new System.Drawing.Size(247, 45);
            this.btnAlerts.TabIndex = 4;
            this.btnAlerts.Text = "Alerts";
            this.btnAlerts.UseVisualStyleBackColor = false;
            this.btnAlerts.Click += new System.EventHandler(this.btnAlerts_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(3, 414);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(247, 45);
            this.button3.TabIndex = 9;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1072, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // timer_Alerts
            // 
            this.timer_Alerts.Enabled = true;
            this.timer_Alerts.Interval = 10000;
            this.timer_Alerts.Tick += new System.EventHandler(this.timer_Alerts_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(488, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // frmPinPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 555);
            this.Controls.Add(this.pnlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPinPoint";
            this.Text = "Pin Point Tracking Solution";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPinPoint_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnDeviceController;
        private System.Windows.Forms.Button btnEventManager;
        private System.Windows.Forms.Button btnConfiguration;
        private System.Windows.Forms.Button btnAlerts;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPinPoint;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btnAssetRegister;
        private System.Windows.Forms.Timer timer_Alerts;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
    }
}

