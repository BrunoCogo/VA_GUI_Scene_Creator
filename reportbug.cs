using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VA_GUI
{
    public partial class reportbug : Form
    {
        public reportbug()
        {
            InitializeComponent();
        }

        // Report via FA
        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.furaffinity.net/newpm/cogo");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/BrunoCogo/VA_GUI_Scene_Creator/issues/new");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
