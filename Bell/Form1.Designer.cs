using RcisSchoolBell.Controls;
using RcisSchoolBell.lib.MaterialSkin;

namespace RcisSchoolBell
{
    partial class Form1
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
        private void 
            InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bell = new System.Windows.Forms.Timer(this.components);
            this.end = new RcisSchoolBell.Controls.MaterialSingleLineTextField();
            this.end0 = new RcisSchoolBell.Controls.MaterialSingleLineTextField();
            this.yo = new RcisSchoolBell.Controls.MaterialSingleLineTextField();
            this.f3 = new RcisSchoolBell.Controls.MaterialSingleLineTextField();
            this.label18 = new RcisSchoolBell.Controls.MaterialLabel();
            this.f2 = new RcisSchoolBell.Controls.MaterialSingleLineTextField();
            this.label17 = new RcisSchoolBell.Controls.MaterialLabel();
            this.f1 = new RcisSchoolBell.Controls.MaterialSingleLineTextField();
            this.label16 = new RcisSchoolBell.Controls.MaterialLabel();
            this.classmanagment = new RcisSchoolBell.Controls.MaterialSingleLineTextField();
            this.label15 = new RcisSchoolBell.Controls.MaterialLabel();
            this.attendtime = new RcisSchoolBell.Controls.MaterialSingleLineTextField();
            this.start = new RcisSchoolBell.Controls.MaterialSingleLineTextField();
            this.end8 = new RcisSchoolBell.Controls.MaterialSingleLineTextField();
            this.label14 = new RcisSchoolBell.Controls.MaterialLabel();
            this.label13 = new RcisSchoolBell.Controls.MaterialLabel();
            this.label11 = new RcisSchoolBell.Controls.MaterialLabel();
            this.p8 = new RcisSchoolBell.Controls.MaterialSingleLineTextField();
            this.label7 = new RcisSchoolBell.Controls.MaterialLabel();
            this.label5 = new RcisSchoolBell.Controls.MaterialLabel();
            this.p7 = new RcisSchoolBell.Controls.MaterialSingleLineTextField();
            this.label10 = new RcisSchoolBell.Controls.MaterialLabel();
            this.lunch = new RcisSchoolBell.Controls.MaterialSingleLineTextField();
            this.label9 = new RcisSchoolBell.Controls.MaterialLabel();
            this.p6 = new RcisSchoolBell.Controls.MaterialSingleLineTextField();
            this.label8 = new RcisSchoolBell.Controls.MaterialLabel();
            this.p5 = new RcisSchoolBell.Controls.MaterialSingleLineTextField();
            this.interval = new RcisSchoolBell.Controls.MaterialSingleLineTextField();
            this.label6 = new RcisSchoolBell.Controls.MaterialLabel();
            this.p4 = new RcisSchoolBell.Controls.MaterialSingleLineTextField();
            this.label4 = new RcisSchoolBell.Controls.MaterialLabel();
            this.p3 = new RcisSchoolBell.Controls.MaterialSingleLineTextField();
            this.p2 = new RcisSchoolBell.Controls.MaterialSingleLineTextField();
            this.label2 = new RcisSchoolBell.Controls.MaterialLabel();
            this.p1 = new RcisSchoolBell.Controls.MaterialSingleLineTextField();
            this.label1 = new RcisSchoolBell.Controls.MaterialLabel();
            this.materialLabel1 = new RcisSchoolBell.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialRaisedButton1 = new RcisSchoolBell.Controls.MaterialRaisedButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel17 = new RcisSchoolBell.Controls.MaterialLabel();
            this.materialLabel16 = new RcisSchoolBell.Controls.MaterialLabel();
            this.materialLabel15 = new RcisSchoolBell.Controls.MaterialLabel();
            this.materialLabel14 = new RcisSchoolBell.Controls.MaterialLabel();
            this.materialLabel13 = new RcisSchoolBell.Controls.MaterialLabel();
            this.materialLabel12 = new RcisSchoolBell.Controls.MaterialLabel();
            this.materialLabel11 = new RcisSchoolBell.Controls.MaterialLabel();
            this.materialLabel10 = new RcisSchoolBell.Controls.MaterialLabel();
            this.materialLabel9 = new RcisSchoolBell.Controls.MaterialLabel();
            this.materialLabel8 = new RcisSchoolBell.Controls.MaterialLabel();
            this.materialLabel7 = new RcisSchoolBell.Controls.MaterialLabel();
            this.materialLabel6 = new RcisSchoolBell.Controls.MaterialLabel();
            this.materialLabel5 = new RcisSchoolBell.Controls.MaterialLabel();
            this.materialLabel4 = new RcisSchoolBell.Controls.MaterialLabel();
            this.materialLabel3 = new RcisSchoolBell.Controls.MaterialLabel();
            this.label3 = new RcisSchoolBell.Controls.MaterialLabel();
            this.materialLabel2 = new RcisSchoolBell.Controls.MaterialLabel();
            this.materialLabel18 = new RcisSchoolBell.Controls.MaterialLabel();
            this.fd = new RcisSchoolBell.Controls.MaterialSingleLineTextField();
            this.nowplaying = new RcisSchoolBell.Controls.MaterialLabel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.materialRaisedButton2 = new RcisSchoolBell.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // bell
            // 
            this.bell.Enabled = true;
            this.bell.Interval = 1000;
            this.bell.Tick += new System.EventHandler(this.bell_Tick);
            // 
            // end
            // 
            this.end.Depth = 0;
            this.end.Enabled = false;
            this.end.Hint = "";
            this.end.Location = new System.Drawing.Point(691, 219);
            this.end.MaxLength = 32767;
            this.end.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.end.Name = "end";
            this.end.PasswordChar = '\0';
            this.end.ReadOnly = false;
            this.end.SelectedText = "";
            this.end.SelectionLength = 0;
            this.end.SelectionStart = 0;
            this.end.Size = new System.Drawing.Size(19, 23);
            this.end.TabIndex = 43;
            this.end.TabStop = false;
            this.end.UseSystemPasswordChar = false;
            this.end.Visible = false;
            // 
            // end0
            // 
            this.end0.Depth = 0;
            this.end0.Enabled = false;
            this.end0.Hint = "";
            this.end0.Location = new System.Drawing.Point(691, 190);
            this.end0.MaxLength = 32767;
            this.end0.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.end0.Name = "end0";
            this.end0.PasswordChar = '\0';
            this.end0.ReadOnly = false;
            this.end0.SelectedText = "";
            this.end0.SelectionLength = 0;
            this.end0.SelectionStart = 0;
            this.end0.Size = new System.Drawing.Size(23, 23);
            this.end0.TabIndex = 42;
            this.end0.TabStop = false;
            this.end0.UseSystemPasswordChar = false;
            this.end0.Visible = false;
            // 
            // yo
            // 
            this.yo.Depth = 0;
            this.yo.Enabled = false;
            this.yo.Hint = "";
            this.yo.Location = new System.Drawing.Point(691, 245);
            this.yo.MaxLength = 32767;
            this.yo.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.yo.Name = "yo";
            this.yo.PasswordChar = '\0';
            this.yo.ReadOnly = false;
            this.yo.SelectedText = "";
            this.yo.SelectionLength = 0;
            this.yo.SelectionStart = 0;
            this.yo.Size = new System.Drawing.Size(19, 23);
            this.yo.TabIndex = 44;
            this.yo.TabStop = false;
            this.yo.UseSystemPasswordChar = false;
            this.yo.Visible = false;
            // 
            // f3
            // 
            this.f3.Depth = 0;
            this.f3.Dock = System.Windows.Forms.DockStyle.Top;
            this.f3.Hint = "";
            this.f3.Location = new System.Drawing.Point(197, 119);
            this.f3.MaxLength = 32767;
            this.f3.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.f3.Name = "f3";
            this.f3.PasswordChar = '\0';
            this.f3.ReadOnly = false;
            this.f3.SelectedText = "";
            this.f3.SelectionLength = 0;
            this.f3.SelectionStart = 0;
            this.f3.Size = new System.Drawing.Size(191, 23);
            this.f3.TabIndex = 4;
            this.f3.TabStop = false;
            this.f3.UseSystemPasswordChar = false;
            this.f3.Enter += new System.EventHandler(this.start_Enter);
            // 
            // label18
            // 
            this.label18.Depth = 0;
            this.label18.Dock = System.Windows.Forms.DockStyle.Top;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label18.Location = new System.Drawing.Point(3, 116);
            this.label18.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(173, 18);
            this.label18.TabIndex = 77;
            this.label18.Text = "Third bell";
            // 
            // f2
            // 
            this.f2.Depth = 0;
            this.f2.Dock = System.Windows.Forms.DockStyle.Top;
            this.f2.Hint = "";
            this.f2.Location = new System.Drawing.Point(197, 90);
            this.f2.MaxLength = 32767;
            this.f2.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.f2.Name = "f2";
            this.f2.PasswordChar = '\0';
            this.f2.ReadOnly = false;
            this.f2.SelectedText = "";
            this.f2.SelectionLength = 0;
            this.f2.SelectionStart = 0;
            this.f2.Size = new System.Drawing.Size(191, 23);
            this.f2.TabIndex = 3;
            this.f2.TabStop = false;
            this.f2.UseSystemPasswordChar = false;
            this.f2.Enter += new System.EventHandler(this.start_Enter);
            // 
            // label17
            // 
            this.label17.Depth = 0;
            this.label17.Dock = System.Windows.Forms.DockStyle.Top;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label17.Location = new System.Drawing.Point(3, 87);
            this.label17.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(173, 18);
            this.label17.TabIndex = 75;
            this.label17.Text = "Second bell";
            // 
            // f1
            // 
            this.f1.Depth = 0;
            this.f1.Dock = System.Windows.Forms.DockStyle.Top;
            this.f1.Hint = "";
            this.f1.Location = new System.Drawing.Point(197, 61);
            this.f1.MaxLength = 32767;
            this.f1.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.f1.Name = "f1";
            this.f1.PasswordChar = '\0';
            this.f1.ReadOnly = false;
            this.f1.SelectedText = "";
            this.f1.SelectionLength = 0;
            this.f1.SelectionStart = 0;
            this.f1.Size = new System.Drawing.Size(191, 23);
            this.f1.TabIndex = 2;
            this.f1.TabStop = false;
            this.f1.UseSystemPasswordChar = false;
            this.f1.Enter += new System.EventHandler(this.start_Enter);
            // 
            // label16
            // 
            this.label16.Depth = 0;
            this.label16.Dock = System.Windows.Forms.DockStyle.Top;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label16.Location = new System.Drawing.Point(3, 58);
            this.label16.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(173, 18);
            this.label16.TabIndex = 73;
            this.label16.Text = "First bell";
            // 
            // classmanagment
            // 
            this.classmanagment.Depth = 0;
            this.classmanagment.Dock = System.Windows.Forms.DockStyle.Top;
            this.classmanagment.Hint = "";
            this.classmanagment.Location = new System.Drawing.Point(197, 32);
            this.classmanagment.MaxLength = 32767;
            this.classmanagment.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.classmanagment.Name = "classmanagment";
            this.classmanagment.PasswordChar = '\0';
            this.classmanagment.ReadOnly = false;
            this.classmanagment.SelectedText = "";
            this.classmanagment.SelectionLength = 0;
            this.classmanagment.SelectionStart = 0;
            this.classmanagment.Size = new System.Drawing.Size(191, 23);
            this.classmanagment.TabIndex = 1;
            this.classmanagment.TabStop = false;
            this.classmanagment.UseSystemPasswordChar = false;
            this.classmanagment.Enter += new System.EventHandler(this.start_Enter);
            // 
            // label15
            // 
            this.label15.Depth = 0;
            this.label15.Dock = System.Windows.Forms.DockStyle.Top;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label15.Location = new System.Drawing.Point(3, 29);
            this.label15.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(173, 18);
            this.label15.TabIndex = 71;
            this.label15.Text = "Class room arrangement";
            // 
            // attendtime
            // 
            this.attendtime.Depth = 0;
            this.attendtime.Dock = System.Windows.Forms.DockStyle.Top;
            this.attendtime.Hint = "";
            this.attendtime.Location = new System.Drawing.Point(197, 177);
            this.attendtime.MaxLength = 32767;
            this.attendtime.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.attendtime.Name = "attendtime";
            this.attendtime.PasswordChar = '\0';
            this.attendtime.ReadOnly = false;
            this.attendtime.SelectedText = "";
            this.attendtime.SelectionLength = 0;
            this.attendtime.SelectionStart = 0;
            this.attendtime.Size = new System.Drawing.Size(191, 23);
            this.attendtime.TabIndex = 6;
            this.attendtime.TabStop = false;
            this.attendtime.UseSystemPasswordChar = false;
            this.attendtime.Enter += new System.EventHandler(this.start_Enter);
            // 
            // start
            // 
            this.start.Depth = 0;
            this.start.Dock = System.Windows.Forms.DockStyle.Top;
            this.start.Hint = "";
            this.start.Location = new System.Drawing.Point(197, 3);
            this.start.MaxLength = 32767;
            this.start.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.start.Name = "start";
            this.start.PasswordChar = '\0';
            this.start.ReadOnly = false;
            this.start.SelectedText = "";
            this.start.SelectionLength = 0;
            this.start.SelectionStart = 0;
            this.start.Size = new System.Drawing.Size(191, 23);
            this.start.TabIndex = 0;
            this.start.TabStop = false;
            this.start.UseSystemPasswordChar = false;
            this.start.Enter += new System.EventHandler(this.start_Enter);
            // 
            // end8
            // 
            this.end8.Depth = 0;
            this.end8.Dock = System.Windows.Forms.DockStyle.Top;
            this.end8.Hint = "";
            this.end8.Location = new System.Drawing.Point(478, 206);
            this.end8.MaxLength = 32767;
            this.end8.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.end8.Name = "end8";
            this.end8.PasswordChar = '\0';
            this.end8.ReadOnly = false;
            this.end8.SelectedText = "";
            this.end8.SelectionLength = 0;
            this.end8.SelectionStart = 0;
            this.end8.Size = new System.Drawing.Size(203, 23);
            this.end8.TabIndex = 16;
            this.end8.TabStop = false;
            this.end8.UseSystemPasswordChar = false;
            this.end8.Enter += new System.EventHandler(this.start_Enter);
            // 
            // label14
            // 
            this.label14.Depth = 0;
            this.label14.Dock = System.Windows.Forms.DockStyle.Top;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(3, 0);
            this.label14.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(173, 18);
            this.label14.TabIndex = 68;
            this.label14.Text = "Day start";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Depth = 0;
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(394, 203);
            this.label13.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 18);
            this.label13.TabIndex = 66;
            this.label13.Text = "Day end";
            // 
            // label11
            // 
            this.label11.Depth = 0;
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(3, 174);
            this.label11.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(173, 18);
            this.label11.TabIndex = 65;
            this.label11.Text = "Time for attend";
            // 
            // p8
            // 
            this.p8.Depth = 0;
            this.p8.Dock = System.Windows.Forms.DockStyle.Top;
            this.p8.Hint = "";
            this.p8.Location = new System.Drawing.Point(478, 177);
            this.p8.MaxLength = 32767;
            this.p8.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.p8.Name = "p8";
            this.p8.PasswordChar = '\0';
            this.p8.ReadOnly = false;
            this.p8.SelectedText = "";
            this.p8.SelectionLength = 0;
            this.p8.SelectionStart = 0;
            this.p8.Size = new System.Drawing.Size(203, 23);
            this.p8.TabIndex = 15;
            this.p8.TabStop = false;
            this.p8.UseSystemPasswordChar = false;
            this.p8.Enter += new System.EventHandler(this.start_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Depth = 0;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(394, 174);
            this.label7.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 18);
            this.label7.TabIndex = 63;
            this.label7.Text = "Period 8";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Depth = 0;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(394, 58);
            this.label5.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 18);
            this.label5.TabIndex = 62;
            this.label5.Text = "Period 5";
            // 
            // p7
            // 
            this.p7.Depth = 0;
            this.p7.Dock = System.Windows.Forms.DockStyle.Top;
            this.p7.Hint = "";
            this.p7.Location = new System.Drawing.Point(478, 148);
            this.p7.MaxLength = 32767;
            this.p7.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.p7.Name = "p7";
            this.p7.PasswordChar = '\0';
            this.p7.ReadOnly = false;
            this.p7.SelectedText = "";
            this.p7.SelectionLength = 0;
            this.p7.SelectionStart = 0;
            this.p7.Size = new System.Drawing.Size(203, 23);
            this.p7.TabIndex = 14;
            this.p7.TabStop = false;
            this.p7.UseSystemPasswordChar = false;
            this.p7.Enter += new System.EventHandler(this.start_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Depth = 0;
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(394, 145);
            this.label10.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 18);
            this.label10.TabIndex = 60;
            this.label10.Text = "Period 7";
            // 
            // lunch
            // 
            this.lunch.Depth = 0;
            this.lunch.Dock = System.Windows.Forms.DockStyle.Top;
            this.lunch.Hint = "";
            this.lunch.Location = new System.Drawing.Point(478, 119);
            this.lunch.MaxLength = 32767;
            this.lunch.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.lunch.Name = "lunch";
            this.lunch.PasswordChar = '\0';
            this.lunch.ReadOnly = false;
            this.lunch.SelectedText = "";
            this.lunch.SelectionLength = 0;
            this.lunch.SelectionStart = 0;
            this.lunch.Size = new System.Drawing.Size(203, 23);
            this.lunch.TabIndex = 13;
            this.lunch.TabStop = false;
            this.lunch.UseSystemPasswordChar = false;
            this.lunch.Enter += new System.EventHandler(this.start_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Depth = 0;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(394, 116);
            this.label9.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 18);
            this.label9.TabIndex = 58;
            this.label9.Text = "Lunch";
            // 
            // p6
            // 
            this.p6.Depth = 0;
            this.p6.Dock = System.Windows.Forms.DockStyle.Top;
            this.p6.Hint = "";
            this.p6.Location = new System.Drawing.Point(478, 90);
            this.p6.MaxLength = 32767;
            this.p6.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.p6.Name = "p6";
            this.p6.PasswordChar = '\0';
            this.p6.ReadOnly = false;
            this.p6.SelectedText = "";
            this.p6.SelectionLength = 0;
            this.p6.SelectionStart = 0;
            this.p6.Size = new System.Drawing.Size(203, 23);
            this.p6.TabIndex = 12;
            this.p6.TabStop = false;
            this.p6.UseSystemPasswordChar = false;
            this.p6.Enter += new System.EventHandler(this.start_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Depth = 0;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(394, 87);
            this.label8.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 18);
            this.label8.TabIndex = 56;
            this.label8.Text = "Period 6";
            // 
            // p5
            // 
            this.p5.Depth = 0;
            this.p5.Dock = System.Windows.Forms.DockStyle.Top;
            this.p5.Hint = "";
            this.p5.Location = new System.Drawing.Point(478, 61);
            this.p5.MaxLength = 32767;
            this.p5.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.p5.Name = "p5";
            this.p5.PasswordChar = '\0';
            this.p5.ReadOnly = false;
            this.p5.SelectedText = "";
            this.p5.SelectionLength = 0;
            this.p5.SelectionStart = 0;
            this.p5.Size = new System.Drawing.Size(203, 23);
            this.p5.TabIndex = 11;
            this.p5.TabStop = false;
            this.p5.UseSystemPasswordChar = false;
            this.p5.Enter += new System.EventHandler(this.start_Enter);
            // 
            // interval
            // 
            this.interval.Depth = 0;
            this.interval.Dock = System.Windows.Forms.DockStyle.Top;
            this.interval.Hint = "";
            this.interval.Location = new System.Drawing.Point(478, 32);
            this.interval.MaxLength = 32767;
            this.interval.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.interval.Name = "interval";
            this.interval.PasswordChar = '\0';
            this.interval.ReadOnly = false;
            this.interval.SelectedText = "";
            this.interval.SelectionLength = 0;
            this.interval.SelectionStart = 0;
            this.interval.Size = new System.Drawing.Size(203, 23);
            this.interval.TabIndex = 10;
            this.interval.TabStop = false;
            this.interval.UseSystemPasswordChar = false;
            this.interval.Enter += new System.EventHandler(this.start_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Depth = 0;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(394, 29);
            this.label6.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 18);
            this.label6.TabIndex = 53;
            this.label6.Text = "Interval";
            // 
            // p4
            // 
            this.p4.Depth = 0;
            this.p4.Dock = System.Windows.Forms.DockStyle.Top;
            this.p4.Hint = "";
            this.p4.Location = new System.Drawing.Point(478, 3);
            this.p4.MaxLength = 32767;
            this.p4.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.p4.Name = "p4";
            this.p4.PasswordChar = '\0';
            this.p4.ReadOnly = false;
            this.p4.SelectedText = "";
            this.p4.SelectionLength = 0;
            this.p4.SelectionStart = 0;
            this.p4.Size = new System.Drawing.Size(203, 23);
            this.p4.TabIndex = 9;
            this.p4.TabStop = false;
            this.p4.UseSystemPasswordChar = false;
            this.p4.Click += new System.EventHandler(this.p4_Click);
            this.p4.Enter += new System.EventHandler(this.start_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Depth = 0;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(394, 0);
            this.label4.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 18);
            this.label4.TabIndex = 51;
            this.label4.Text = "Period 4";
            // 
            // p3
            // 
            this.p3.Depth = 0;
            this.p3.Dock = System.Windows.Forms.DockStyle.Top;
            this.p3.Hint = "";
            this.p3.Location = new System.Drawing.Point(197, 235);
            this.p3.MaxLength = 32767;
            this.p3.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.p3.Name = "p3";
            this.p3.PasswordChar = '\0';
            this.p3.ReadOnly = false;
            this.p3.SelectedText = "";
            this.p3.SelectionLength = 0;
            this.p3.SelectionStart = 0;
            this.p3.Size = new System.Drawing.Size(191, 23);
            this.p3.TabIndex = 8;
            this.p3.TabStop = false;
            this.p3.UseSystemPasswordChar = false;
            this.p3.Enter += new System.EventHandler(this.start_Enter);
            // 
            // p2
            // 
            this.p2.Depth = 0;
            this.p2.Dock = System.Windows.Forms.DockStyle.Top;
            this.p2.Hint = "";
            this.p2.Location = new System.Drawing.Point(197, 206);
            this.p2.MaxLength = 32767;
            this.p2.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.p2.Name = "p2";
            this.p2.PasswordChar = '\0';
            this.p2.ReadOnly = false;
            this.p2.SelectedText = "";
            this.p2.SelectionLength = 0;
            this.p2.SelectionStart = 0;
            this.p2.Size = new System.Drawing.Size(191, 23);
            this.p2.TabIndex = 7;
            this.p2.TabStop = false;
            this.p2.UseSystemPasswordChar = false;
            this.p2.Enter += new System.EventHandler(this.start_Enter);
            // 
            // label2
            // 
            this.label2.Depth = 0;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(3, 203);
            this.label2.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 18);
            this.label2.TabIndex = 47;
            this.label2.Text = "Period 2";
            // 
            // p1
            // 
            this.p1.Depth = 0;
            this.p1.Dock = System.Windows.Forms.DockStyle.Top;
            this.p1.Hint = "";
            this.p1.Location = new System.Drawing.Point(197, 148);
            this.p1.MaxLength = 32767;
            this.p1.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.p1.Name = "p1";
            this.p1.PasswordChar = '\0';
            this.p1.ReadOnly = false;
            this.p1.SelectedText = "";
            this.p1.SelectionLength = 0;
            this.p1.SelectionStart = 0;
            this.p1.Size = new System.Drawing.Size(191, 23);
            this.p1.TabIndex = 5;
            this.p1.TabStop = false;
            this.p1.UseSystemPasswordChar = false;
            this.p1.Enter += new System.EventHandler(this.start_Enter);
            // 
            // label1
            // 
            this.label1.Depth = 0;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(3, 145);
            this.label1.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 18);
            this.label1.TabIndex = 45;
            this.label1.Text = "Period 1";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(0, 456);
            this.materialLabel1.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(680, 24);
            this.materialLabel1.TabIndex = 80;
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(512, 29);
            this.materialRaisedButton1.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(75, 23);
            this.materialRaisedButton1.TabIndex = 84;
            this.materialRaisedButton1.Text = "Settings";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(271, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(135, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 85;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(503, 61);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(28, 31);
            this.player.TabIndex = 86;
            this.player.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.materialLabel17, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel16, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel15, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel14, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel13, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel12, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel11, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel10, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel9, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel8, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel7, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel6, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel5, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel3, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.p3, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.p8, 5, 6);
            this.tableLayoutPanel1.Controls.Add(this.lunch, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.p7, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.p5, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.p6, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.interval, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.p4, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.p2, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.p1, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.f3, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.f2, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label9, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.attendtime, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.label5, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label10, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.f1, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label16, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label17, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label18, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.classmanagment, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.start, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.label13, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.end8, 5, 7);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel18, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.fd, 4, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 193);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(680, 263);
            this.tableLayoutPanel1.TabIndex = 87;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // materialLabel17
            // 
            this.materialLabel17.AutoSize = true;
            this.materialLabel17.Depth = 0;
            this.materialLabel17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel17.Location = new System.Drawing.Point(463, 203);
            this.materialLabel17.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.materialLabel17.Name = "materialLabel17";
            this.materialLabel17.Size = new System.Drawing.Size(9, 18);
            this.materialLabel17.TabIndex = 94;
            this.materialLabel17.Text = ":";
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel16.Location = new System.Drawing.Point(182, 203);
            this.materialLabel16.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(9, 18);
            this.materialLabel16.TabIndex = 93;
            this.materialLabel16.Text = ":";
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel15.Location = new System.Drawing.Point(463, 174);
            this.materialLabel15.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(9, 18);
            this.materialLabel15.TabIndex = 92;
            this.materialLabel15.Text = ":";
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel14.Location = new System.Drawing.Point(182, 174);
            this.materialLabel14.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(9, 18);
            this.materialLabel14.TabIndex = 91;
            this.materialLabel14.Text = ":";
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(463, 145);
            this.materialLabel13.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(9, 18);
            this.materialLabel13.TabIndex = 90;
            this.materialLabel13.Text = ":";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(182, 145);
            this.materialLabel12.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(9, 18);
            this.materialLabel12.TabIndex = 89;
            this.materialLabel12.Text = ":";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(463, 116);
            this.materialLabel11.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(9, 18);
            this.materialLabel11.TabIndex = 88;
            this.materialLabel11.Text = ":";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(182, 116);
            this.materialLabel10.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(9, 18);
            this.materialLabel10.TabIndex = 87;
            this.materialLabel10.Text = ":";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(463, 87);
            this.materialLabel9.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(9, 18);
            this.materialLabel9.TabIndex = 86;
            this.materialLabel9.Text = ":";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(182, 87);
            this.materialLabel8.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(9, 18);
            this.materialLabel8.TabIndex = 85;
            this.materialLabel8.Text = ":";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(463, 58);
            this.materialLabel7.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(9, 18);
            this.materialLabel7.TabIndex = 84;
            this.materialLabel7.Text = ":";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(182, 58);
            this.materialLabel6.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(9, 18);
            this.materialLabel6.TabIndex = 83;
            this.materialLabel6.Text = ":";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(463, 29);
            this.materialLabel5.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(9, 18);
            this.materialLabel5.TabIndex = 82;
            this.materialLabel5.Text = ":";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(182, 29);
            this.materialLabel4.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(9, 18);
            this.materialLabel4.TabIndex = 81;
            this.materialLabel4.Text = ":";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(463, 0);
            this.materialLabel3.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(9, 18);
            this.materialLabel3.TabIndex = 80;
            this.materialLabel3.Text = ":";
            // 
            // label3
            // 
            this.label3.Depth = 0;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(3, 232);
            this.label3.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 18);
            this.label3.TabIndex = 49;
            this.label3.Text = "Period 3";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(182, 0);
            this.materialLabel2.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(9, 18);
            this.materialLabel2.TabIndex = 79;
            this.materialLabel2.Text = ":";
            // 
            // materialLabel18
            // 
            this.materialLabel18.AutoSize = true;
            this.materialLabel18.Depth = 0;
            this.materialLabel18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel18.Location = new System.Drawing.Point(182, 232);
            this.materialLabel18.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.materialLabel18.Name = "materialLabel18";
            this.materialLabel18.Size = new System.Drawing.Size(9, 18);
            this.materialLabel18.TabIndex = 95;
            this.materialLabel18.Text = ":";
            // 
            // fd
            // 
            this.fd.Depth = 0;
            this.fd.Hint = "";
            this.fd.Location = new System.Drawing.Point(463, 235);
            this.fd.MaxLength = 32767;
            this.fd.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.fd.Name = "fd";
            this.fd.PasswordChar = '\0';
            this.fd.ReadOnly = false;
            this.fd.SelectedText = "";
            this.fd.SelectionLength = 0;
            this.fd.SelectionStart = 0;
            this.fd.Size = new System.Drawing.Size(9, 23);
            this.fd.TabIndex = 17;
            this.fd.TabStop = false;
            this.fd.UseSystemPasswordChar = false;
            this.fd.Visible = false;
            // 
            // nowplaying
            // 
            this.nowplaying.AutoSize = true;
            this.nowplaying.Depth = 0;
            this.nowplaying.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nowplaying.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nowplaying.Location = new System.Drawing.Point(12, 147);
            this.nowplaying.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.nowplaying.Name = "nowplaying";
            this.nowplaying.Size = new System.Drawing.Size(0, 18);
            this.nowplaying.TabIndex = 88;
            this.nowplaying.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::RcisSchoolBell.Properties.Resources.lakmal;
            this.pictureBox3.Location = new System.Drawing.Point(2, 64);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(680, 115);
            this.pictureBox3.TabIndex = 90;
            this.pictureBox3.TabStop = false;
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(593, 29);
            this.materialRaisedButton2.MouseState = RcisSchoolBell.lib.MaterialSkin.MouseState.Hover;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(75, 23);
            this.materialRaisedButton2.TabIndex = 91;
            this.materialRaisedButton2.Text = "About";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(680, 480);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.nowplaying);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.yo);
            this.Controls.Add(this.end);
            this.Controls.Add(this.end0);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pictureBox3);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Sizable = false;
            this.Text = "Bell";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer bell;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSingleLineTextField end;
        private MaterialSingleLineTextField end0;
        private MaterialSingleLineTextField yo;
        private MaterialSingleLineTextField f3;
        private MaterialLabel label18;
        private MaterialSingleLineTextField f2;
        private MaterialLabel label17;
        private MaterialSingleLineTextField f1;
        private MaterialLabel label16;
        private MaterialSingleLineTextField classmanagment;
        private MaterialLabel label15;
        private MaterialSingleLineTextField attendtime;
        private MaterialSingleLineTextField start;
        private MaterialSingleLineTextField end8;
        private MaterialLabel label14;
        private MaterialLabel label13;
        private MaterialLabel label11;
        private MaterialSingleLineTextField p8;
        private MaterialLabel label7;
        private MaterialLabel label5;
        private MaterialSingleLineTextField p7;
        private MaterialLabel label10;
        private MaterialSingleLineTextField lunch;
        private MaterialLabel label9;
        private MaterialSingleLineTextField p6;
        private MaterialLabel label8;
        private MaterialSingleLineTextField p5;
        private MaterialSingleLineTextField interval;
        private MaterialLabel label6;
        private MaterialSingleLineTextField p4;
        private MaterialLabel label4;
        private MaterialSingleLineTextField p3;
        private MaterialSingleLineTextField p2;
        private MaterialLabel label2;
        private MaterialSingleLineTextField p1;
        private MaterialLabel label1;
        private MaterialLabel materialLabel1;
        private MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialLabel materialLabel17;
        private MaterialLabel materialLabel16;
        private MaterialLabel materialLabel15;
        private MaterialLabel materialLabel14;
        private MaterialLabel materialLabel13;
        private MaterialLabel materialLabel12;
        private MaterialLabel materialLabel11;
        private MaterialLabel materialLabel10;
        private MaterialLabel materialLabel9;
        private MaterialLabel materialLabel8;
        private MaterialLabel materialLabel7;
        private MaterialLabel materialLabel6;
        private MaterialLabel materialLabel5;
        private MaterialLabel materialLabel4;
        private MaterialLabel materialLabel3;
        private MaterialLabel materialLabel2;
        private MaterialLabel label3;
        private MaterialLabel materialLabel18;
        private MaterialSingleLineTextField fd;
        private MaterialLabel nowplaying;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MaterialRaisedButton materialRaisedButton2;
    
    }
}