namespace Pin_Control.User_Controls
{
    partial class uc_RegisterReader
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtRFID = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.ComboBox_COM = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.OpenPort = new System.Windows.Forms.Button();
            this.ClosePort = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboBox_AlreadyOpenCOM = new System.Windows.Forms.ComboBox();
            this.label47 = new System.Windows.Forms.Label();
            this.ComboBox_baud2 = new System.Windows.Forms.ComboBox();
            this.Edit_CmdComAddr = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnActivate = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtRFID);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.ComboBox_COM);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.OpenPort);
            this.groupBox1.Controls.Add(this.ClosePort);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ComboBox_AlreadyOpenCOM);
            this.groupBox1.Controls.Add(this.label47);
            this.groupBox1.Controls.Add(this.ComboBox_baud2);
            this.groupBox1.Controls.Add(this.Edit_CmdComAddr);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnActivate);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 371);
            this.groupBox1.TabIndex = 188;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection Settings";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(319, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 25);
            this.button2.TabIndex = 191;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(319, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 25);
            this.button1.TabIndex = 190;
            this.button1.Text = "Link to Asset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtRFID
            // 
            this.txtRFID.Location = new System.Drawing.Point(24, 294);
            this.txtRFID.Name = "txtRFID";
            this.txtRFID.Size = new System.Drawing.Size(289, 22);
            this.txtRFID.TabIndex = 188;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnStart.Location = new System.Drawing.Point(24, 258);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(137, 30);
            this.btnStart.TabIndex = 188;
            this.btnStart.Text = "Start Scan";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnStop.Location = new System.Drawing.Point(167, 258);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(146, 30);
            this.btnStop.TabIndex = 189;
            this.btnStop.Text = "Stop Scan";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(24, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 172;
            this.label9.Text = "Power Level:";
            // 
            // ComboBox_COM
            // 
            this.ComboBox_COM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_COM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_COM.FormattingEnabled = true;
            this.ComboBox_COM.Items.AddRange(new object[] {
            "AUTO",
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12"});
            this.ComboBox_COM.Location = new System.Drawing.Point(24, 58);
            this.ComboBox_COM.Name = "ComboBox_COM";
            this.ComboBox_COM.Size = new System.Drawing.Size(228, 21);
            this.ComboBox_COM.TabIndex = 159;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button4.Location = new System.Drawing.Point(24, 132);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(444, 23);
            this.button4.TabIndex = 153;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(24, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 158;
            this.label5.Text = "COM Port";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "5",
            "7",
            "10",
            "13",
            "15",
            "18",
            "20",
            "23",
            "25",
            "28",
            "30"});
            this.comboBox1.Location = new System.Drawing.Point(27, 218);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(110, 21);
            this.comboBox1.TabIndex = 170;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.progressBar1.Location = new System.Drawing.Point(157, 218);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(311, 20);
            this.progressBar1.TabIndex = 171;
            // 
            // OpenPort
            // 
            this.OpenPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenPort.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.OpenPort.Location = new System.Drawing.Point(24, 86);
            this.OpenPort.Name = "OpenPort";
            this.OpenPort.Size = new System.Drawing.Size(110, 25);
            this.OpenPort.TabIndex = 160;
            this.OpenPort.Text = "Open COM Port";
            this.OpenPort.UseVisualStyleBackColor = true;
            this.OpenPort.Click += new System.EventHandler(this.OpenPort_Click);
            // 
            // ClosePort
            // 
            this.ClosePort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClosePort.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ClosePort.Location = new System.Drawing.Point(140, 86);
            this.ClosePort.Name = "ClosePort";
            this.ClosePort.Size = new System.Drawing.Size(112, 25);
            this.ClosePort.TabIndex = 161;
            this.ClosePort.Text = "ClosePort";
            this.ClosePort.UseVisualStyleBackColor = true;
            this.ClosePort.Click += new System.EventHandler(this.ClosePort_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(266, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 162;
            this.label3.Text = "Opened COM Port:";
            // 
            // ComboBox_AlreadyOpenCOM
            // 
            this.ComboBox_AlreadyOpenCOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_AlreadyOpenCOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_AlreadyOpenCOM.FormattingEnabled = true;
            this.ComboBox_AlreadyOpenCOM.Location = new System.Drawing.Point(369, 53);
            this.ComboBox_AlreadyOpenCOM.Name = "ComboBox_AlreadyOpenCOM";
            this.ComboBox_AlreadyOpenCOM.Size = new System.Drawing.Size(99, 21);
            this.ComboBox_AlreadyOpenCOM.TabIndex = 163;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label47.Location = new System.Drawing.Point(302, 95);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(61, 13);
            this.label47.TabIndex = 164;
            this.label47.Text = "Baud Rate:";
            // 
            // ComboBox_baud2
            // 
            this.ComboBox_baud2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_baud2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_baud2.FormattingEnabled = true;
            this.ComboBox_baud2.Items.AddRange(new object[] {
            "9600bps",
            "19200bps",
            "38400bps",
            "57600bps",
            "115200bps"});
            this.ComboBox_baud2.Location = new System.Drawing.Point(369, 92);
            this.ComboBox_baud2.Name = "ComboBox_baud2";
            this.ComboBox_baud2.Size = new System.Drawing.Size(99, 21);
            this.ComboBox_baud2.TabIndex = 165;
            this.ComboBox_baud2.SelectedIndexChanged += new System.EventHandler(this.ComboBox_baud2_SelectedIndexChanged);
            // 
            // Edit_CmdComAddr
            // 
            this.Edit_CmdComAddr.BackColor = System.Drawing.SystemColors.Window;
            this.Edit_CmdComAddr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_CmdComAddr.Location = new System.Drawing.Point(401, 17);
            this.Edit_CmdComAddr.MaxLength = 2;
            this.Edit_CmdComAddr.Name = "Edit_CmdComAddr";
            this.Edit_CmdComAddr.Size = new System.Drawing.Size(28, 20);
            this.Edit_CmdComAddr.TabIndex = 166;
            this.Edit_CmdComAddr.Text = "FF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(312, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 167;
            this.label7.Text = "Reader Address";
            // 
            // btnActivate
            // 
            this.btnActivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnActivate.Location = new System.Drawing.Point(24, 161);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(444, 25);
            this.btnActivate.TabIndex = 168;
            this.btnActivate.Text = "Activate";
            this.btnActivate.UseVisualStyleBackColor = true;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // uc_RegisterReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "uc_RegisterReader";
            this.Size = new System.Drawing.Size(501, 377);
            this.Load += new System.EventHandler(this.uc_RegisterReader_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Button button2;
        internal System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtRFID;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label9;
        internal System.Windows.Forms.ComboBox ComboBox_COM;
        private System.Windows.Forms.Button button4;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        internal System.Windows.Forms.Button OpenPort;
        internal System.Windows.Forms.Button ClosePort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboBox_AlreadyOpenCOM;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.ComboBox ComboBox_baud2;
        internal System.Windows.Forms.TextBox Edit_CmdComAddr;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.Timer timer1;
    }
}
