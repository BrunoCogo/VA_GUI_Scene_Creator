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
    public partial class Credits : Form
    {
        public CREDIT cred = new CREDIT();

        public Credits()
        {
            InitializeComponent();
        }

        private void Done_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            cred.mainAuthor = tb_Author.Text.Trim();
            cred.EnemyAuthors = tb_enemyAutors.Text.Trim();
            cred.Editors = tb_Ene.Text.Trim();
            cred.SpecialTanks = tb_specialThx.Text.Trim();

        }
    }

    public class CREDIT
    {
        public string mainAuthor;
        public string EnemyAuthors;
        public string Editors;
        public string SpecialTanks;
    }
}
