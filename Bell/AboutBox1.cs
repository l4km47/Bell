using System;
using System.Windows.Forms;
using RcisSchoolBell.lib;
using RcisSchoolBell.lib.MaterialSkin;

namespace RcisSchoolBell
{
    sealed partial class AboutBox1 :Form
    {
        public AboutBox1()
        {
            InitializeComponent();
            Text = string.Format("About {0}", Assemblyinfo.AssemblyTitle);
            title.Text = Text;
            BackColor = MaterialSkinManager.BackgroundDark;

            materialLabel2.Text = string.Format("{0}", Assemblyinfo.AssemblyProduct);
            materialLabel3.Text = String.Format("v{0}r1", Assemblyinfo.AssemblyVersion);
            //materialLabel1.Text = AssemblyCopyright;
            materialLabel4.Text = string.Format("{0}", Assemblyinfo.AssemblyCompany);
            materialLabel5.Text = string.Format("{0}", Assemblyinfo.AssemblyCopyright);
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
