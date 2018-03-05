using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;


namespace VA_GUI
{
    public partial class ZipperForm : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        public Dictionary<string, List<Node>> PlaceDir = new Dictionary<string, List<Node>>();
        public List<string> EnemyList;

        public ZipperForm(Dictionary<string, List<Node>> PlaceDirectory, List<string> Enemies )
        {
            InitializeComponent();
            PlaceDir = PlaceDirectory;
            EnemyList = Enemies;
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ZipperForm_Load(object sender, EventArgs e)
        {
            log.Debug("Loading Places to Zipper");
            for (int i = 0; i < PlaceDir.Count; i++)
            {
                log.Debug("Loading " + PlaceDir.ElementAt(i).Key);
                PlacesCheckList.Items.Add(PlaceDir.ElementAt(i).Key);
            }

            for (int i = 0; i < EnemyList.Count; i++)
            {
                EnemyChecklist.Items.Add(EnemyList[i]);
            }

        }

        List<string> GetEnemiesList(List<Node> list)
        {
            List<string> EnemyList = new List<string>();

            foreach (Node n in list)
            {
                if (n.Type == Node.NodeType.combat)
                {
                    if (!EnemyList.Contains(n.EnemyToFight))
                    {
                        EnemyList.Add(n.EnemyToFight);
                    }
                }
            }

            return EnemyList;
        }

        //Called when 
        void SelectEnemiesWithPlace( ItemCheckEventArgs e)
        {
            List<Node> Place = PlaceDir[PlacesCheckList.Items[e.Index].ToString()];

            List<string> EnemiesToMark = GetEnemiesList(Place);

            bool mode;

            if (e.NewValue == CheckState.Checked)
            {
                mode = true;
            }
            else if (e.NewValue == CheckState.Unchecked)
            {
                mode = false;
            }
            else
            {
                log.Error("No Inderemine allowed. Cancelling Call");
                return;
            }
            log.Info("Obtained " + EnemyChecklist.Items.Count + " to the enemy list");

            int f = 0;
            foreach (string s in EnemiesToMark)
            {
                int i = EnemyChecklist.Items.IndexOf(s);
                if(EnemyChecklist.GetItemChecked(i) != mode)
                {
                    f++;
                    log.Debug(String.Format("Changed Enemy \"{0}\" to {1}",EnemyChecklist.Items[i].ToString(), mode.ToString()));
                    EnemyChecklist.SetItemChecked(i, mode);
                }
            }

            log.Info("Changed tick of " + f + " in the enemy list");


        }

        private void PlacesCheckList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            log.Info("A place has been checked, Procedding to select enemies linked with place");
            SelectEnemiesWithPlace(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Export Zip'

            log.Info("Export Inizializated, Isolating Selected Elements");
            string temp = MoveToTemp();
            if (temp == "")
            {
                log.Error("Error when moving to temp. Canceling Export");
                this.DialogResult = DialogResult.Abort;
                this.Close();
                return;
            }

            log.Info("Creating Save Dialog File.");
            SaveFileDialog n = new SaveFileDialog();
            n.DefaultExt = ".zip";
            n.Filter = "Zip File|.zip";
            if (n.ShowDialog() == DialogResult.OK)
            {

                ZipFile.CreateFromDirectory(temp, n.FileName);

                //Make Fourm successful
                log.Info("Result ok, Zip created, Deleting Temporal Folder");
                Directory.Delete(temp, true);
                this.DialogResult = DialogResult.OK;
                //exit

                
            }
            else
            {

                log.Info("Result Cancel, No save file selected or error when selecting");
                MessageBox.Show("Export cancel");
                this.DialogResult = DialogResult.Cancel;
            }
            this.Close();
        }

        private List<string> BuildplaceFileListing()
        {
            List<string> fileList = new List<string>();
            //Iterate thru items to detect places
            for (int i = 0; i < PlacesCheckList.Items.Count; i++)
            {
                if (PlacesCheckList.GetItemCheckState(i) == CheckState.Checked)
                {
                    fileList.Add(GetPlaceFilePath(  PlacesCheckList.Items[i].ToString()));
                }
            }

            return fileList;
        }

        private List<string> BuildmonsterFileListing()
        {
            List<string> fileList = new List<string>();
            //Iterate thru items to detect mosters
            for (int i = 0; i < EnemyChecklist.Items.Count; i++)
            {
                if (EnemyChecklist.GetItemCheckState(i) == CheckState.Checked)
                {
                    fileList.Add(GetEnemyFilePath(EnemyChecklist.Items[i].ToString()));
                }
            }
            return fileList;
        }


        private string MoveToTemp()
        {
            try
            {
                log.Debug("Getting Temp path");
                string path = Path.GetTempPath() + @"voreadventure";

                //Get PlacePaths
                log.Debug("Building Place File table");
                List<string> PlaceList = BuildplaceFileListing();

                //Get EnemnyPaths
                log.Debug("Building Enemy File table");
                List<string> EnemyList = BuildmonsterFileListing();

                log.Debug("Creating Customs in Temp folder");
                Directory.CreateDirectory((path + @"\customs\places"));
                Directory.CreateDirectory((path + @"\customs\monsters"));
                foreach (string p in PlaceList)
                {
                    log.Debug("Copying " + p + " to temporal files");
                    File.Copy(p, path + @"\customs\places\" + Path.GetFileName(p), true);
                }

                foreach (string e in EnemyList)
                {
                    log.Debug("Copying " + e + " to temporal files");
                    File.Copy(e, path + @"\customs\monsters\" + Path.GetFileName(e),true);
                }

                log.Info("Isolation Process Succeeded");
                return path;
            }
            catch (Exception ex)
            {
                log.Error("Fatal Error when isolating the files.",ex);
                return "";
            }
        }

        private string GetPlaceFilePath(string name)
        {

            string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\voreadventure";
            const string PlacesPathAddon = @"\custom\places\";
            
            return path + PlacesPathAddon + name + ".vgp";
        }

        private string GetEnemyFilePath(string name)
        {

            string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\voreadventure";
                        const string EnemyPathAddon = @"\custom\monsters\";

            return path + EnemyPathAddon + name + ".vgm";
        }
    }
}
