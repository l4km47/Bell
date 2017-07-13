using RcisSchoolBell.Controls;
using RcisSchoolBell.lib.MaterialSkin;

namespace RcisSchoolBell
{
    partial class FrmSettings
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
            this.btncancel = new RcisSchoolBell.Controls.MaterialRaisedButton();
            this.btnok = new RcisSchoolBell.Controls.MaterialRaisedButton();
            this.materialRaisedButton3 = new RcisSchoolBell.Controls.MaterialRaisedButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.materialTabControl1 = new RcisSchoolBell.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel1 = new RcisSchoolBell.Controls.MaterialLabel();
            this.list = new RcisSchoolBell.Controls.MaterialLabel();
            this.materialLabel7 = new RcisSchoolBell.Controls.MaterialLabel();
            this.start = new RcisSchoolBell.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new RcisSchoolBell.Controls.MaterialLabel();
            this.ptime = new RcisSchoolBell.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new RcisSchoolBell.Controls.MaterialLabel();
            this.stime = new RcisSchoolBell.Controls.MaterialSingleLineTextField();
            this.lunch = new RcisSchoolBell.Controls.MaterialSingleLineTextField();
            this.btnbrows = new RcisSchoolBell.Controls.MaterialFlatButton();
            this.inttime = new RcisSchoolBell.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new RcisSchoolBell.Controls.MaterialLabel();
            this.materialLabel4 = new RcisSchoolBell.Controls.MaterialLabel();
            this.materialLabel8 = new RcisSchoolBell.Controls.MaterialLabel();
            this.startup = new RcisSchoolBell.Controls.MaterialCheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialLabel6 = new RcisSchoolBell.Controls.MaterialLabel();
            this.themedark = new RcisSchoolBell.Controls.MaterialRadioButton();
            this.themelight = new RcisSchoolBell.Controls.MaterialRadioButton();
            this.materialTabSelector1 = new RcisSchoolBell.Controls.MaterialTabSelector();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncancel
            // 
            this.btncancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancel.Depth = 0;
            this.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancel.Location = new System.Drawing.Point(366, 365);
            
            this.btncancel.Name = "btncancel";
            this.btncancel.Primary = false;
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 3;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // btnok
            // 
            this.btnok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnok.Depth = 0;
            this.btnok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnok.Location = new System.Drawing.Point(201, 365);
            
            this.btnok.Name = "btnok";
            this.btnok.Primary = true;
            this.btnok.Size = new System.Drawing.Size(75, 23);
            this.btnok.TabIndex = 4;
            this.btnok.Text = "Apply";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Location = new System.Drawing.Point(285, 365);
            
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = false;
            this.materialRaisedButton3.Size = new System.Drawing.Size(75, 23);
            this.materialRaisedButton3.TabIndex = 5;
            this.materialRaisedButton3.Text = "Defult";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            this.materialRaisedButton3.Click += new System.EventHandler(this.materialRaisedButton3_Click);
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 59);
            
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(449, 287);
            this.materialTabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(441, 261);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Application settings";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.materialLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.list, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.start, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ptime, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.stime, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lunch, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.btnbrows, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.inttime, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel5, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel4, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel8, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.startup, 1, 9);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(435, 255);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(3, 0);
            
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(179, 29);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Start time";
            // 
            // list
            // 
            this.list.Depth = 0;
            this.list.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.list.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.list.Location = new System.Drawing.Point(188, 87);
            
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(244, 29);
            this.list.TabIndex = 15;
            // 
            // materialLabel7
            // 
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(3, 87);
            
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(179, 29);
            this.materialLabel7.TabIndex = 16;
            this.materialLabel7.Text = "Morning Songs list";
            // 
            // start
            // 
            this.start.Depth = 0;
            this.start.Hint = "";
            this.start.Location = new System.Drawing.Point(188, 3);
            this.start.MaxLength = 32767;
            
            this.start.Name = "start";
            this.start.PasswordChar = '\0';
            this.start.ReadOnly = false;
            this.start.SelectedText = "";
            this.start.SelectionLength = 0;
            this.start.SelectionStart = 0;
            this.start.Size = new System.Drawing.Size(142, 23);
            this.start.TabIndex = 2;
            this.start.TabStop = false;
            this.start.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(3, 29);
            
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(179, 29);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "Fime for a peroid";
            // 
            // ptime
            // 
            this.ptime.Depth = 0;
            this.ptime.Hint = "";
            this.ptime.Location = new System.Drawing.Point(188, 32);
            this.ptime.MaxLength = 2;
            
            this.ptime.Name = "ptime";
            this.ptime.PasswordChar = '\0';
            this.ptime.ReadOnly = false;
            this.ptime.SelectedText = "";
            this.ptime.SelectionLength = 0;
            this.ptime.SelectionStart = 0;
            this.ptime.Size = new System.Drawing.Size(39, 23);
            this.ptime.TabIndex = 7;
            this.ptime.TabStop = false;
            this.ptime.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(3, 58);
            
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(179, 29);
            this.materialLabel3.TabIndex = 8;
            this.materialLabel3.Text = "Morning Songs start time";
            // 
            // stime
            // 
            this.stime.Depth = 0;
            this.stime.Hint = "";
            this.stime.Location = new System.Drawing.Point(188, 61);
            this.stime.MaxLength = 32767;
            
            this.stime.Name = "stime";
            this.stime.PasswordChar = '\0';
            this.stime.ReadOnly = false;
            this.stime.SelectedText = "";
            this.stime.SelectionLength = 0;
            this.stime.SelectionStart = 0;
            this.stime.Size = new System.Drawing.Size(142, 23);
            this.stime.TabIndex = 9;
            this.stime.TabStop = false;
            this.stime.UseSystemPasswordChar = false;
            // 
            // lunch
            // 
            this.lunch.Depth = 0;
            this.lunch.Hint = "";
            this.lunch.Location = new System.Drawing.Point(188, 183);
            this.lunch.MaxLength = 32767;
            
            this.lunch.Name = "lunch";
            this.lunch.PasswordChar = '\0';
            this.lunch.ReadOnly = false;
            this.lunch.SelectedText = "";
            this.lunch.SelectionLength = 0;
            this.lunch.SelectionStart = 0;
            this.lunch.Size = new System.Drawing.Size(142, 23);
            this.lunch.TabIndex = 13;
            this.lunch.TabStop = false;
            this.lunch.UseSystemPasswordChar = false;
            // 
            // btnbrows
            // 
            this.btnbrows.Depth = 0;
            this.btnbrows.Location = new System.Drawing.Point(189, 122);
            this.btnbrows.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            
            this.btnbrows.Name = "btnbrows";
            this.btnbrows.Primary = false;
            this.btnbrows.Size = new System.Drawing.Size(75, 23);
            this.btnbrows.TabIndex = 14;
            this.btnbrows.Text = "Brows..";
            this.btnbrows.UseVisualStyleBackColor = true;
            this.btnbrows.Click += new System.EventHandler(this.btnbrows_Click);
            // 
            // inttime
            // 
            this.inttime.Depth = 0;
            this.inttime.Hint = "";
            this.inttime.Location = new System.Drawing.Point(188, 154);
            this.inttime.MaxLength = 32767;
            
            this.inttime.Name = "inttime";
            this.inttime.PasswordChar = '\0';
            this.inttime.ReadOnly = false;
            this.inttime.SelectedText = "";
            this.inttime.SelectionLength = 0;
            this.inttime.SelectionStart = 0;
            this.inttime.Size = new System.Drawing.Size(142, 23);
            this.inttime.TabIndex = 11;
            this.inttime.TabStop = false;
            this.inttime.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(3, 180);
            
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(179, 29);
            this.materialLabel5.TabIndex = 12;
            this.materialLabel5.Text = "Time for a lunch";
            // 
            // materialLabel4
            // 
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(3, 151);
            
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(179, 29);
            this.materialLabel4.TabIndex = 10;
            this.materialLabel4.Text = "Time for a interval";
            // 
            // materialLabel8
            // 
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(3, 209);
            
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(179, 46);
            this.materialLabel8.TabIndex = 17;
            this.materialLabel8.Text = "Start with windows";
            // 
            // startup
            // 
            this.startup.AutoSize = true;
            this.startup.Checked = true;
            this.startup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.startup.Depth = 0;
            this.startup.Font = new System.Drawing.Font("Roboto", 10F);
            this.startup.Location = new System.Drawing.Point(185, 209);
            this.startup.Margin = new System.Windows.Forms.Padding(0);
            this.startup.MouseLocation = new System.Drawing.Point(-1, -1);
            
            this.startup.Name = "startup";
            this.startup.Ripple = true;
            this.startup.Size = new System.Drawing.Size(26, 30);
            this.startup.TabIndex = 18;
            this.startup.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.materialLabel6);
            this.tabPage2.Controls.Add(this.themedark);
            this.tabPage2.Controls.Add(this.themelight);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(441, 261);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Skin";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(8, 8);
            
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(62, 18);
            this.materialLabel6.TabIndex = 2;
            this.materialLabel6.Text = "Theme :";
            // 
            // themedark
            // 
            this.themedark.AutoSize = true;
            this.themedark.Checked = true;
            this.themedark.Depth = 0;
            this.themedark.Enabled = false;
            this.themedark.Font = new System.Drawing.Font("Roboto", 10F);
            this.themedark.Location = new System.Drawing.Point(76, 33);
            this.themedark.Margin = new System.Windows.Forms.Padding(0);
            this.themedark.MouseLocation = new System.Drawing.Point(-1, -1);
            
            this.themedark.Name = "themedark";
            this.themedark.Ripple = true;
            this.themedark.Size = new System.Drawing.Size(57, 30);
            this.themedark.TabIndex = 1;
            this.themedark.TabStop = true;
            this.themedark.Text = "Dark";
            this.themedark.UseVisualStyleBackColor = true;
            this.themedark.CheckedChanged += new System.EventHandler(this.materialRadioButton2_CheckedChanged);
            // 
            // themelight
            // 
            this.themelight.AutoSize = true;
            this.themelight.Depth = 0;
            this.themelight.Enabled = false;
            this.themelight.Font = new System.Drawing.Font("Roboto", 10F);
            this.themelight.Location = new System.Drawing.Point(74, 3);
            this.themelight.Margin = new System.Windows.Forms.Padding(0);
            this.themelight.MouseLocation = new System.Drawing.Point(-1, -1);
            
            this.themelight.Name = "themelight";
            this.themelight.Ripple = true;
            this.themelight.Size = new System.Drawing.Size(59, 30);
            this.themelight.TabIndex = 0;
            this.themelight.Text = "Light";
            this.themelight.UseVisualStyleBackColor = true;
            this.themelight.CheckedChanged += new System.EventHandler(this.themelight_CheckedChanged);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(117, 30);
            
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(285, 23);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.TabStop = false;
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btncancel;
            this.ClientSize = new System.Drawing.Size(453, 400);
            this.ControlBox = false;
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialRaisedButton3);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.btncancel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSettings";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSettings_FormClosing);
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.MaterialRaisedButton btncancel;
        private Controls.MaterialRaisedButton btnok;
        private Controls.MaterialRaisedButton materialRaisedButton3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Controls.MaterialLabel materialLabel1;
        private Controls.MaterialLabel list;
        private Controls.MaterialLabel materialLabel7;
        private Controls.MaterialSingleLineTextField start;
        private Controls.MaterialLabel materialLabel2;
        private Controls.MaterialSingleLineTextField ptime;
        private Controls.MaterialLabel materialLabel3;
        private Controls.MaterialSingleLineTextField stime;
        private Controls.MaterialSingleLineTextField lunch;
        private Controls.MaterialFlatButton btnbrows;
        private Controls.MaterialSingleLineTextField inttime;
        private Controls.MaterialLabel materialLabel5;
        private Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.TabPage tabPage2;
        private Controls.MaterialTabSelector materialTabSelector1;
        private Controls.MaterialLabel materialLabel6;
        private Controls.MaterialRadioButton themedark;
        private Controls.MaterialRadioButton themelight;
        private Controls.MaterialLabel materialLabel8;
        private Controls.MaterialCheckBox startup;
    }
}