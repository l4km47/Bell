using System;
using System.Windows.Forms;
using RcisSchoolBell.lib.UHWID;

namespace RcisSchoolBell
{
    public sealed partial class Activation : Form
    {
        public Activation()
        {
            InitializeComponent();
            Text = string.Format("Activation {0}", lib.Assemblyinfo.AssemblyTitle);
            title.Text = Text;
            var uhid = new UhwidEngine();
            materialSingleLineTextField1.ReadOnly = true;
            materialSingleLineTextField1.SelectAll();
            materialSingleLineTextField1.Text = uhid.AdvancedUid;
        }

        private void Activation_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
