using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Controls;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Threading;

namespace VA_GUI
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// A collection of nodes
        /// </summary>
        /// 
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SessionLS lSe = new SessionLS();
        public PlaceDirectory prevSession;

        public List<Node> NodeLibraryList = new List<Node>();
        private List<string> EnemyLibrary = new List<string>();
        public List<string> PlacesName;
        public PlaceDirectory PlaceDir = new PlaceDirectory();

        private List<List<string>> RawNodeCollection;

        private int indexNode = 0;

        public Form1()
        {
            log.Debug("Inicated: Form1 - Main VAGUI Window");
            InitializeComponent();
            LoadCustom();
            LoadSession();
        }

        public void LoadSession()
        {
            log.Info("Loading intizialided");
            prevSession = lSe.LoadPreviousSession().ToPlaceDirectory();
            //Merge already loaded PlaceDir with prev session list

            PlaceDir.Merge(prevSession);
            foreach (string key in PlaceDir.Dir.Keys)
            {
                foreach (Node n in PlaceDir.Dir[key])
                {
                    n.RelateOptions(PlaceDir.Dir[key]);
                }
            }
            UpdateWorkspace();
        }

        public void SaveSession()
        {

        }

        #region Funcionality Methods
        /// <summary>Adds current list of nodes into the combo box "place"</summary>
        public void UpdateWorkspace()
        {
            cb_place.Items.Clear();
            foreach (string place in PlaceDir.Dir.Keys.ToList())
            {
                cb_place.Items.Add(place.Replace("\\custom\\places\\", ""));
            }
        }

        /// <summary>Modifies the node library by the one selected in the "Places" combobox.</summary>
        public void ModifyWorkspace(object sender, EventArgs e)
        {
            log.Info("Changing places");
            try
            {
                NodeLibraryList.Clear();
                foreach (Node node in PlaceDir.Dir[cb_place.SelectedItem.ToString()])
                {
                    NodeLibraryList.Add(node);
                }

                cb_CurrentNode.Items.Clear();

                foreach (Node item in NodeLibraryList)
                {
                    cb_CurrentNode.Items.Add(item.ID);
                }
                ModifyDGVOptions();

                cb_CurrentNode.Text = "";
                tb_Title.Text = "";
                tb_Name.Text = "";
                tb_ID.Text = "";
                tb_Desc.Text = "";
                cb_Type.Text = "";
                cb_StarterAdeventure.Checked = false;
                tb_chance.Value = 0;
                Num_Chance.Value = 0;
                dgv_Olinking.Rows.Clear();
                num_OptionCount.Value = 0;
                cb_EnemyLink.Text = "";

                label_Enemy.Visible = false;
                cb_EnemyLink.Visible = false;
                cb_battleDesc.Visible = false;
                label2.Visible = false;
                num_OptionCount.Visible = false;
                dgv_Olinking.Visible = false;
                label6.Visible = false;

                cb_CurrentNode.SelectedIndex = cb_CurrentNode.Items.IndexOf(cb_CurrentNode.Items.Count - 1);
            }
            catch (Exception ex)
            {
                log.Error("Error changing places", ex);
                MessageBox.Show("Error " + ex.ToString());
            }

        }

        public void ModifyDGVOptions()
        {
            cl_OptionLink.Items.Clear();
            cb_CurrentNode.Items.Clear();
            foreach (Node optionNode in NodeLibraryList)
            {
                cl_OptionLink.Items.Add(optionNode.ID);
                cb_CurrentNode.Items.Add(optionNode.ID);
            }
        }

        public void addNewNodeToList()
        {
            log.Debug("Adding Node to Node Directory");
            #region verification
            try
            {
                if (cb_place.Text.ToString() != "")
                {

                    if (tb_Name.Text.Trim() != "" && tb_Title.Text.Trim() != "" && tb_Title.Text.Trim() != "" && cb_Type.SelectedItem.ToString().Trim() != "")
                    {
                        //Successful node

                        Node newNode = new Node(tb_ID.Text, tb_Name.Text, tb_Title.Text, InterpretNodeType(cb_Type.SelectedItem.ToString()), tb_Desc.Text, cb_StarterAdeventure.Checked, Num_Chance.Value);

                        Node found = null;
                        bool isFound = false;
                        bool byName = false;
                        bool byID = false;
                        foreach (Node node in NodeLibraryList)
                        {
                            if (node.Name == newNode.Name)
                            {
                                found = node;
                                isFound = true;
                                byName = true;
                                break;
                            }
                            if (node.ID == newNode.ID)
                            {
                                found = node;
                                isFound = true;
                                byID = true;
                                break;
                            }
                        }
                        if (!isFound)
                        {
                            log.Debug("No Node Dups Found, procceding with Adding node to Node Directory");
                            newNode.GetOptions(this);
                            if (cb_EnemyLink.SelectedItem == null)
                            {
                                newNode.EnemyToFight = "";
                            }
                            else
                            {
                                newNode.EnemyToFight = cb_EnemyLink.SelectedItem.ToString();
                            }
                            NodeLibraryList.Add(new Node(tb_ID.Text, tb_Name.Text, tb_Title.Text, InterpretNodeType(cb_Type.SelectedItem.ToString()), tb_Desc.Text, cb_StarterAdeventure.Checked, Num_Chance.Value));
                            cb_CurrentNode.Items.Add(newNode.ID);
                            cb_CurrentNode.SelectedIndex = cb_CurrentNode.Items.IndexOf(newNode.ID);
                            ModifyDGVOptions();

                        }
                        else
                        {

                            string Mess;
                            string Cap;
                            if (byName && !byID)
                            {
                                Mess = "Failed to add node: A Node with the same Name has been detected:\n" +
                                    found.ToString() + "\n";
                                Cap = "Duplicated Name";
                            }
                            else if (!byName && byID)
                            {
                                Mess = "Failed to add node: A Node With the same ID has been detected:\n";
                                Cap = "Duplicated ID";
                            }
                            else
                            {
                                Mess = "Failed to add node: A Node With the same ID and Name has been detected";
                                Cap = "Duplicated Name & Id";
                            }
                            log.Warn(Cap + " - " + Mess);
                            MessageBox.Show(Mess, Cap);
                        }

                    }
                    else
                    {
                        MessageBox.Show("A Value of the Node is unfilled and it can not be represented as a 'good node'\n" +
                                        "Please make sure that the following fields are filled:\n" +
                                        "ID\n" +
                                        "Name\n" +
                                        "Title\n" +
                                        "Type\n\n" +
                                        "The Node will not be added while any of these are unfilled. Fill them and try again.", "Error Creating Node");
                        log.Error("Failed To Add Node - A field was not filled");

                    }

                }
                else { MessageBox.Show("No place selected to place node with. Process canceled."); log.Warn("tried to add node to an non-existant place"); return; }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("An error occured while trying to add a Node; please fill in all main fields \n" +
                    "{ID, Name, Title and or Type} are not filled");
                log.Error("An error occured while trying to add a Node", ex);
            }
  

            #endregion
        }

        Node.NodeType InterpretNodeType(string s)
        {
            switch (s)
            {
                case "combat":
                    return Node.NodeType.combat;
                case "noncombat":
                    return Node.NodeType.noncombat;
                default:
                    return Node.NodeType.nothing;

            }

        }

        /// <summary>
        /// Goes thru the file specified at given path and processes it for future code.Returns a list of raw node strings. Separate nodes from each other
        /// </summary>
        /// <param name="_path">The path of the file to be read</param>
        /// <returns>A list of raw node separation</returns>
        List<List<string>> ReadFile(string _path)
        {
            StreamReader File = new StreamReader(_path);
            List<string> Node = new List<string>();
            List<List<string>> NodeCollection = new List<List<string>>();
            bool NodeStart = false;
            string line;
            int lineNum = 0;


            int nodeRead = 0;
            log.Debug("Reading File: " + _path);

            while ((line = File.ReadLine()) != null)
            {
                lineNum++;

                if (line.Contains("[") && NodeStart == false)
                {
                    nodeRead++;
                    log.Debug("Starting to read node #" + nodeRead);
                    NodeStart = true;
                }
                else if(line.Contains("[") && NodeStart == false)
                {
                    MessageBox.Show("Error reading a node\nAnother node was started but didn't reach the end before trying to read another node");
                    log.Error("Error reading a file: \n" + Path.GetFileNameWithoutExtension(_path) + "\n" + "Line: " + lineNum);
                }

                if (NodeStart == true)
                {
                    Node.Add(line);
                }

                if (line.Contains("];"))
                {
                    log.Debug("Finish reading node #" + nodeRead);
                    NodeCollection.Add(Node.ToList<string>());
                    NodeStart = false;
                    Node.Clear();
                }
            }

            log.Info("File Successfully closed");
            File.Close();
            return NodeCollection;

        }

        /// <summary>
        /// Gets enemy list to add to the enemy_combo box
        /// </summary>
        /// <param name="path">Path of the Direcoty where the enemies are stored</param>
        /// <returns></returns>
        List<string> GetEnemies(string path)
        {
            log.Debug("Loading Custom Enemies");
            List<string> Enemies = new List<string>();
            foreach (string enemyFile in Directory.EnumerateFiles(path))
            {
                Enemies.Add(enemyFile.Replace(path + "\\", "").Replace(".vgm", ""));
                log.Debug("Enemy Found: " + enemyFile.Replace(path + "\\", "").Replace(".vgm", "") + " Added");
            }
            log.Debug("Finished Adding Enemies");
            return Enemies;

        }

        public Node GetFromListID(string IDTarget)
        {
            try
            {
                for (int i = 0; i < NodeLibraryList.Count; i++)
                            {
                                if (NodeLibraryList[i].ID == IDTarget)
                                {
                                    log.Info("Successfully obtained Node with ID of: " + IDTarget);
                                    return NodeLibraryList[i];
                                }
                            }
                            log.Info("No Node with ID of: " + IDTarget + " was found");

                            return null;
            }
            catch (Exception ex)
            {
                log.Error("There was an error trying to get ID: " + IDTarget + " from list from list. Possible Index out of Range",ex);
                MessageBox.Show("There was an error trying to get ID: " + IDTarget + " from list from list.");
                return null;
            }
            
        }

        public Node GetFromListName(string NameTarget)
        {
            try
            {

                for (int i = 0; i < NodeLibraryList.Count; i++)
                            {
                                if (NodeLibraryList[i].Name == NameTarget)
                                {
                                    return NodeLibraryList[i];
                                }
                            }
                            return null;
            }
            catch (Exception ex)
            {
                log.Error("There was an error trying to get Name: \"" + NameTarget + "\" from list from list. Possible Index out of Range", ex);
                MessageBox.Show("There was an error trying to get name: \"" + NameTarget + "\" from list from list");
                return null;
            }
            
        }

        //<summary>Adds an empty place in the place directory</summary>
        public void AddPlace(string NewPlaceName)
        {
            log.Debug("Adding " + NewPlaceName);
            if (!PlaceDir.Dir.ContainsKey(NewPlaceName))
            {
                PlaceDir.Dir.Add(NewPlaceName, new List<Node>());
            }
            else {
                log.Warn("There is a Place already in the list with that name");
                MessageBox.Show("Failed to add place. There is a Place already in the list with that name");
            }
        }

        private void LoadCustom()
        {
            
            string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\voreadventure";
            const string PlacesPathAddon = @"\custom\places";

            const string EnemyPathAddon = @"\custom\monsters";

            try
            {
                PlacesName = Directory.EnumerateFiles(path + PlacesPathAddon).ToList();
            }
            catch (Exception ex)
            {
                if (ex is DirectoryNotFoundException)
                {
                    log.Error("Error while trying to read a non-existent path.",ex);
                    MessageBox.Show("No Vore Adventure data has been detected.\nCreating the vore adventure path on " + path);
                    //implement path creaion

                    Directory.CreateDirectory(path + PlacesPathAddon);
                    Directory.CreateDirectory(path + EnemyPathAddon);
                }
            }
            log.Info("EnemyList Cleared");
            EnemyLibrary.Clear();
            EnemyLibrary = GetEnemies(path + EnemyPathAddon);
            #region Place Processing
            log.Debug("Loading Custom Places");
            foreach (string placeFile in Directory.EnumerateFiles(path + PlacesPathAddon))
            {
                
                if (Path.GetExtension(placeFile) == ".vgp")
                {
                    log.Debug("Translating File: " + placeFile.Replace(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),""));
                    RawNodeCollection = ReadFile(placeFile);

                    List<Node> placeNodes = new List<Node>();

                    //for each place file...

                    for (int i = 0; i < RawNodeCollection.Count; i++)
                    {
                        //for each node in file...
                        // placeNodes.Clear();
                        Node newNode = new Node();
                        newNode.InterpretNode(RawNodeCollection[i]);
                        placeNodes.Add(newNode);
                        //MessageBox.Show(placeNodes.ToString());
                    }
                    //Relate The Nodes options in each node
                    for (int i = 0; i < placeNodes.Count; i++)
                    {
                        placeNodes[i].RelateOptions(placeNodes);
                    }

                    if (!PlaceDir.Dir.ContainsKey(placeFile.Replace(path, "").Replace(".vgp", "")))
                    {
                        log.Debug("Added " + placeFile.Replace(path, "").Replace("\\custom\\places\\", "").Replace(".vgp", ""));
                        PlaceDir.Dir.Add(placeFile.Replace(path, "").Replace("\\custom\\places\\", "").Replace(".vgp", ""), placeNodes.ToList());
                    }
                }
            }
            #endregion
            //process node linking options
            log.Debug("Form - Added Enemies to Enemy Linked List");
            cb_EnemyLink.Items.AddRange(EnemyLibrary.ToArray());
            //Update Workspace
            UpdateWorkspace();
        }

        #endregion


        #region ---->Form Interactions Events<----

        public void dgv_Olinking_CellValueChanged(object sender, DataGridViewCellEventArgs e)

        {
            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                
                string test = dgv_Olinking.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                log.Debug("Setting Node Option - " + test);
                dgv_Olinking.Rows[e.RowIndex].Cells[0].Value = GetFromListID(dgv_Olinking.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()).Name;
            }
            if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {
                log.Debug("Removing option " + dgv_Olinking.Rows[e.RowIndex].Cells[0].Value.ToString());
                dgv_Olinking.Rows.RemoveAt(e.RowIndex);
            }
            num_OptionCount.Value = dgv_Olinking.RowCount - 1;
        }

        private void bt_AddNode_Click(object sender, EventArgs e)
        {
            log.Info("Added Node");
            addNewNodeToList();
            UpdatePlaceDir();
        }


        private void bt_newNode_Click(object sender, EventArgs e)
        {
            cb_CurrentNode.Text = "";
            tb_Title.Text = "";
            tb_Name.Text = "";
            tb_ID.Text = "";
            tb_Desc.Text = "";
            cb_Type.Text = Node.NodeType.nothing.ToString();
            cb_StarterAdeventure.Checked = false;
            tb_chance.Value = 0;
            Num_Chance.Value = 0;
            dgv_Olinking.Rows.Clear();
            num_OptionCount.Value = 0;
            cb_EnemyLink.Text = "";
        }

        /// <summary>
        /// Triggers if "Delete Node" button has been click
        /// </summary>
        private void ct_Delete_Click(object sender, EventArgs e)
        {
            if (Interaction.MsgBox("Are you sure you want to delete node '"+cb_CurrentNode.Text+"'? if it wasn't saved before you wont be able to recover the work in the node", MsgBoxStyle.YesNo) == MsgBoxResult.Yes)
            {
                try
                {
                    NodeLibraryList.Remove(GetFromListName(cb_CurrentNode.SelectedItem.ToString()));
                    if (indexNode - 1 > 0)
                    {
                        cb_CurrentNode.SelectedIndex = indexNode - 1;
                    }
                    else if (indexNode + 1 < cb_CurrentNode.Items.Count)
                    {
                        cb_CurrentNode.SelectedIndex = indexNode + 1;
                    }
                    else
                    {
                        cb_CurrentNode.SelectedIndex = -1;
                    }

                    ModifyDGVOptions();
                }
                catch (Exception)
                {
                    MessageBox.Show("Please Select a node on the 'current node' Selector before deleting a node");
                }
            }
        }

        /// <summary>
        /// Set Current node information by the one in form 1. 
        /// </summary>
        private void bt_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                Node currentNode = GetFromListID(cb_CurrentNode.SelectedItem.ToString());

                if (currentNode == null)
                {
                    currentNode = GetFromListName(cb_CurrentNode.SelectedItem.ToString());
                }

                //TODO Finish Edit Node [Chance, Enemy, Comment]
                currentNode.ID = tb_ID.Text;
                //ddcurrentNode.Name = tb_Name.Text;
                currentNode.Title = tb_Title.Text;
                currentNode.Description = tb_Desc.Text;

                //this 3 lines modifies only the type
                if (cb_Type.SelectedItem.ToString() == "noncombat") currentNode.Type = Node.NodeType.noncombat;
                else if (cb_Type.SelectedItem.ToString() == "combat") currentNode.Type = Node.NodeType.combat;
                else currentNode.Type = Node.NodeType.nothing;

                currentNode.OptionLinking.Clear();
                for (int i = 0; i < dgv_Olinking.RowCount - 1; i++)
                {
                    //UNDONE finish this method
                    //currentNode.OptionLinking.Add();
                    currentNode.OptionLinking.Add(dgv_Olinking.Rows[i].Cells[0].Value.ToString(), GetFromListName(dgv_Olinking.Rows[i].Cells[0].Value.ToString()));
                }
                currentNode.OptionCount = dgv_Olinking.RowCount - 1;
                currentNode.chance = double.Parse( tb_chance.Value.ToString()) / 100;
                currentNode.ProticeStart = cb_StarterAdeventure.Checked;
                if (cb_EnemyLink.SelectedItem == null)
                {
                    currentNode.EnemyToFight = "";
                }
                else
                {
                    currentNode.EnemyToFight = cb_EnemyLink.SelectedItem.ToString();
                }

                UpdatePlaceDir();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
                log.Error("Error while editing node: ", ex);
            }



        }

        //<summary>triggers event if the Current node has been changed</summary>
        private void cb_CurrentNode_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cb_CurrentNode.SelectedIndex.ToString());
            indexNode = cb_CurrentNode.SelectedIndex;
            Node currentNode;
            if (cb_CurrentNode.SelectedItem != null)
            {
                string test = cb_CurrentNode.SelectedItem.ToString();
                currentNode = GetFromListID(cb_CurrentNode.SelectedItem.ToString());
                if(currentNode ==  null)
                { 
                   currentNode = GetFromListName(cb_CurrentNode.SelectedItem.ToString());
                }
            }
            else
            {
                currentNode = new Node();
            }
            tb_ID.Text = currentNode.ID;
            tb_Name.Text = currentNode.Name;
            tb_Title.Text = currentNode.Title;
            tb_Desc.Text = currentNode.Description;
            cb_Type.SelectedItem = currentNode.Type.ToString();
            cb_Type.SelectedIndex = cb_Type.Items.IndexOf(currentNode.Type.ToString().ToLower());
            cb_Type.Text = cb_Type.SelectedItem.ToString();
            num_OptionCount.Value = currentNode.OptionCount;

            dgv_Olinking.Rows.Clear();
            cl_OptionLink.Items.Clear();

            foreach (Node node in NodeLibraryList)
            {
                cl_OptionLink.Items.Add(node.ID);
            }
            foreach (string key in currentNode.OptionLinking.Keys)
            {
                dgv_Olinking.Rows.Add(key);
            }
            // dgv_Olinking
            cb_EnemyLink.Text = currentNode.EnemyToFight;
            tb_chance.Value = Convert.ToInt16(currentNode.chance) * 100;
            Num_Chance.Value = Convert.ToInt16(currentNode.chance);
            cb_StarterAdeventure.Checked = currentNode.ProticeStart;
            
        }

        /// <summary>
        /// This function runs thru the custom directory and Processes both places and enemies.
        /// </summary>
        private void bt_LoadCustom_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\voreadventure";
            const string PlacesPathAddon = @"\custom\places";

            const string EnemyPathAddon = @"\custom\monsters";

            PlaceDir.Dir.Clear();
            PlacesName = Directory.EnumerateFiles(path + PlacesPathAddon).ToList<string>();

            EnemyLibrary.Clear();
            EnemyLibrary = GetEnemies(path + EnemyPathAddon);
            #region Place Processing
            foreach (string placeFile in Directory.EnumerateFiles(path + PlacesPathAddon))
            {
                if (Path.GetExtension(placeFile) == ".vgp")
                {
                    RawNodeCollection = ReadFile(placeFile);

                    List<Node> placeNodes = new List<Node>();

                    //for each place file...

                    for (int i = 0; i < RawNodeCollection.Count; i++)
                    {
                        //for each node in file...
                        // placeNodes.Clear();
                        Node newNode = new Node();
                        newNode.InterpretNode(RawNodeCollection[i]);
                        placeNodes.Add(newNode);
                        //MessageBox.Show(placeNodes.ToString());
                    }
                    //Relate The Nodes options in each node
                    for (int i = 0; i < placeNodes.Count; i++)
                    {
                        placeNodes[i].RelateOptions(placeNodes);
                    }

                    if (!PlaceDir.Dir.ContainsKey(placeFile.Replace(path, "").Replace(".vgp", "")))
                    {
                        PlaceDir.Dir.Add(placeFile.Replace(path, "").Replace("\\custom\\places\\", "").Replace(".vgp", ""), placeNodes.ToList());
                    }
                }
            }
            #endregion
            //process node linking options
            cb_EnemyLink.Items.AddRange(EnemyLibrary.ToArray());
            //Update Workspace
            UpdateWorkspace();
        }

        private void bt_AddPlace_Click(object sender, EventArgs e)
        {
            if (cb_place.Text == "")
            {
                cb_place.Text = Microsoft.VisualBasic.Interaction.InputBox("Please Enter the name for the new place:", "Place nameing","My Place");
            }
            AddPlace(cb_place.Text);
            UpdateWorkspace();
            cb_place.SelectedIndex = cb_place.Items.IndexOf(cb_place.Text);
        }


        #endregion

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            tb_chance.Value = (int)(Num_Chance.Value * 100);
            //if ((int)Num_Chance.Value != 0)
            //{
            //    cb_StarterAdeventure.Checked = true;
            //}
            //else
            //{
            //    cb_StarterAdeventure.Checked = false;
            //}

        }

        private void tb_chance_Scroll(object sender, EventArgs e)
        {
            Num_Chance.Value = (decimal)(tb_chance.Value / 100f);
            //if (tb_chance.Value != 0)
            //{
            //    cb_StarterAdeventure.Checked = true;
            //}
            //else
            //{
            //    cb_StarterAdeventure.Checked = false;
            //}
        }

        private void cb_StarterAdeventure_CheckedChanged(object sender, EventArgs e)
        {
            log.Debug("Started Adventure for node ID:" + tb_ID + " has been set to: " + cb_StarterAdeventure.Checked.ToString());
            tb_chance.Visible = cb_StarterAdeventure.Checked;
            Num_Chance.Visible = cb_StarterAdeventure.Checked;
            label_Chance.Visible = cb_StarterAdeventure.Checked;
            if (cb_StarterAdeventure.Checked == false)
            {

                Num_Chance.Value = 0;
                tb_chance.Value = 0;
                
            }
            else
            {

            }

        }

        private void Bt_ExportCustom_Click(object sender, EventArgs e)
        {
            try
            {
                log.Info("Opening Previewer");
            Output_Previewer preview = new Output_Previewer(NodeLibraryList, cb_place.SelectedItem.ToString(), EnemyLibrary);
            preview.ShowDialog();
            }
            catch (Exception)
            {
                log.Warn("Opening Place Previewer with no place attached. Canceling preview");
                MessageBox.Show("Do you have a place selected on the Working Place menu?\nif not, It would be advisable to created... just sain... that's how I know what to process... \n. 3 .");
               
            }
           
        }

        private void cb_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*noncombat
            combat
            nothing*/
#pragma warning disable CS0252 // Possible unintended reference comparison; left hand side needs cast
            log.Debug(tb_ID + " type changed to " + cb_Type.SelectedItem );
            if (cb_Type.SelectedItem == "noncombat")
            {
                label_Enemy.Visible = false;
                cb_EnemyLink.Visible = false;
                cb_battleDesc.Visible = false;
                label2.Visible = true;
                num_OptionCount.Visible = true;
                dgv_Olinking.Visible = true;
                label6.Visible = true;
                tb_Desc.Visible = true;
            }
            else if (cb_Type.SelectedItem == "combat")
            {
                label_Enemy.Visible = true;
                cb_EnemyLink.Visible = true;
                cb_battleDesc.Visible = true;
                label2.Visible = false;
                num_OptionCount.Visible = false;
                dgv_Olinking.Visible = false;
                label6.Visible = false;
                tb_Desc.Visible = false;
            }
            else if (cb_Type.SelectedItem == "nothing")
            {
                label_Enemy.Visible = false;
                cb_EnemyLink.Visible = false;
                cb_battleDesc.Visible = false;
                label2.Visible = false;
                num_OptionCount.Visible = false;
                dgv_Olinking.Visible = false;
                label6.Visible = false;
                tb_Desc.Visible = true;
            }
#pragma warning restore CS0252 // Possible unintended reference comparison; left hand side needs cast

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cb_battleDesc_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label_Chance_Click(object sender, EventArgs e)
        {

        }

        private void tb_Desc_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tb_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_EnemyLink_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void num_OptionCount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tb_Title_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label_Enemy_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void lb_CurrentID_Click(object sender, EventArgs e)
        {

        }

        private void lb_CurrentType_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void bt_delPlace_Click(object sender, EventArgs e)
        {
            try
            {
                if (Interaction.MsgBox("Are you sure you want to delete '" + cb_place.Text + "' from the directory? No files will be afected but if you didn't had a file of this place before, it will not be recoverable.", MsgBoxStyle.YesNo) == MsgBoxResult.Yes)
                {
                    log.Debug("Deleting place: " + cb_place.SelectedItem.ToString());
                    PlaceDir.Dir.Remove(cb_place.SelectedItem.ToString());

                    cb_place.Text = "";
                    UpdateWorkspace();
                }
            }
            catch (Exception ex)
            {
                log.Error("Error Deleting Place", ex);
                throw;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            log.Debug("Opening donation Window");
            if (MessageBox.Show("Hi There!,\nFirst of all Thank you for even downloading this app :3\nA donation, while not obligatory, does help a lot.\n\nAre you sure you want to donate?\nA browser window will open with the Paypal Donation page.", "Donating?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                string url = "";

                string business = "BrunoCogo@outlook.com";  // your paypal email
                string description = "Donation";            // '%20' represents a space. remember HTML!
                string country = "US";                  // AU, US, etc.
                string currency = "USD";                 // AUD, USD, etc.

                url += "https://www.paypal.com/cgi-bin/webscr" +
                    "?cmd=" + "_donations" +
                    "&business=" + business +
                    "&lc=" + country +
                    "&item_name=" + description +
                    "&currency_code=" + currency +
                    "&bn=" + "PP%2dDonationsBF";

                System.Diagnostics.Process.Start(url);
            }


        }


        private void UpdatePlaceDir()
        {
            log.Debug(" Updating place directory ");
            if (PlaceDir.Dir.Keys.Contains(cb_place.Text))
            {
                PlaceDir.Dir[cb_place.Text].Clear();
                PlaceDir.Dir[cb_place.Text].AddRange(NodeLibraryList);
            }
            else
            {
                log.Debug("Place added to directory");
                PlaceDir.Dir.Add(cb_place.Text, NodeLibraryList);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            log.Info("Launching Exporter");
            ZipperForm z = new ZipperForm(PlaceDir.Dir,EnemyLibrary);

            if (z.ShowDialog() == DialogResult.OK)
            {
                log.Info("Zipper Closeing, Export Assumed to succeed");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void standaloneRelateOptions()
        {
            foreach (string key in PlaceDir.Dir.Keys)
            {
                List<Node> placeNodes = PlaceDir.Dir[key];
                for (int i = 0; i < placeNodes.Count; i++)
                {
                    placeNodes[i].RelateOptions(placeNodes);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            lSe.SaveSession(PlaceDir);
        }

        private void cb_CurrentNode_Validating(object sender, CancelEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            log.Info("Opening Node wizard");
            if (cb_place.Text == "")
            {
                if (Interaction.MsgBox("No place has been selected, would you like to launch the 'add place' wizard?", MsgBoxStyle.YesNo) == MsgBoxResult.Yes)
                {
                    if (cb_place.Text == "")
                    {
                        cb_place.Text = Microsoft.VisualBasic.Interaction.InputBox("Please Enter the name for the new place:", "Place nameing", "My Place");
                    }
                    AddPlace(cb_place.Text);
                    UpdateWorkspace();
                    cb_place.SelectedIndex = cb_place.Items.IndexOf(cb_place.Text);

                    Interaction.MsgBox("Place added succesfully, continuing the 'Node Creation' wizard", MsgBoxStyle.Information);
                }
                else
                {

                    log.Info("Exiting Node wizard early: No place to add node created");
                    Interaction.MsgBox("Canceling wizard.");

                }
            }

            //Add node Wizard
            Interaction.MsgBox("This is a guided a Node Creation series of interactions, ready to continue?");
            tb_ID.Text = Interaction.InputBox("Please Input the ID.\nAn ID will not affect the inner workings of the game, This only helps you keep track\nof what this node is.\n Most be text (no simbols like '#', '%', '≥', etc.)", "ID");
            tb_Name.Text = Interaction.InputBox("Please Input the name of the node,\nThis is the part the nodes refer when linking options","Name");
            tb_Title.Text = Interaction.InputBox("Please Input the Title of the node.\nThis is the text that shows in the in-game's buttons, most will appear as the button's that link to node\n(Ex. \"Drop down the hole\")", "Title");
            string typeSel = Interaction.InputBox("Please Input the Node Type by inputing the number corresponding with the Desired type.\n" +
                "1.) Non-combat: This type says there will be a choise from the player, this is node is responsable to link other nodes (ex. Do you approach the hole?)\n" +
                "2.) Combat: This node says that there will be a confrontation between the player and a monster.\n" +
                "3.) nothing: This marks the end of an adventure. All branches are required to have this to allow the player to continue playing.\n" +
                "\nPlease Enter a corresponding number","Type");
            if (typeSel.Trim() == "1")
            {
                cb_Type.Text = Node.NodeType.noncombat.ToString();
                Interaction.MsgBox("All linking with other nodes must be done thru the main interface.\nAfter creating the nodes that are going to be linked to this node, select this node on the Current node drop box and use the Option linking tool to link other nodes.\nOnce finished, click \"Edit button\".", MsgBoxStyle.Information, "Note on Linking");
            }
            else if (typeSel.Trim() == "2")
            {
                cb_Type.Text = Node.NodeType.combat.ToString();

                string EnemyList = "Please Select enemy to fight:\n";
                for (int i = 1; i <= EnemyLibrary.Count; i++)
                {
                    EnemyList += String.Format("{0}.) {1}\n", i, EnemyLibrary[i - 1]);
                }
                EnemyList += "\nPlease Input number of enemy to fight.";

                cb_EnemyLink.Text = EnemyLibrary[int.Parse(Interaction.InputBox(EnemyList, "Enemy").Trim()) - 1];

                MsgBoxResult r = Interaction.MsgBox("Will the description of the node be played before encounter?", MsgBoxStyle.YesNo);
                switch (r)
                {
                    case MsgBoxResult.Yes:
                        cb_battleDesc.Checked = true;
                        break;
                    case MsgBoxResult.No:
                        cb_battleDesc.Checked = false;
                        break;

                    default:
                        cb_battleDesc.Checked = false;
                        break;
                }
            }
            else
            {
                cb_Type.Text = Node.NodeType.nothing.ToString();
            }
            tb_Desc.Text = Interaction.InputBox("Description of node.\n(Can be edited later thru the 'edit button')", "Description");

            log.Debug("Added Node thru wizard");
            addNewNodeToList();
            UpdatePlaceDir();
        }

        private void bt_importZip_Click(object sender, EventArgs e)
        {
            log.Info("Importing a zip!");
            try
            {

                OpenFileDialog zipSelection = new OpenFileDialog();
                zipSelection.Title = "Select ZIP created with VA_GUI";
                zipSelection.Filter = "Zip files (*.zip)|*.zip";

                string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\voreadventure";

                if (zipSelection.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(zipSelection.FileName) && zipSelection.FileName.EndsWith("zip"))
                    {
                        ZipFile.Open(zipSelection.FileName, ZipArchiveMode.Read).ExtractToDirectory(path, true);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error importing ZIP, check log for details");
                log.Error("Error importing Zip", ex);
            }
        }

        private void tb_Desc_TextChanged_1(object sender, EventArgs e)
        {
        }

        //Report a bug
        private void button4_Click(object sender, EventArgs e)
        {
            new reportbug().ShowDialog();
        }
    }



    public static class ZipArchiveExtensions
    {
#pragma warning disable 0246
        public static void ExtractToDirectory(this ZipArchive archive, string destinationDirectoryName, bool overwrite)
        {
            if (!overwrite)
            {
                archive.ExtractToDirectory(destinationDirectoryName);
                return;
            }
            foreach (ZipArchiveEntry file in archive.Entries)
            {
                string completeFileName = Path.Combine(destinationDirectoryName, file.FullName);
                if (file.Name == "")
                {// Assuming Empty for Directory
                    Directory.CreateDirectory(Path.GetDirectoryName(completeFileName));
                    continue;
                }
                if (!Directory.Exists(Path.GetDirectoryName(file.Name))) Directory.CreateDirectory(Path.GetDirectoryName(completeFileName));
                file.ExtractToFile(completeFileName, true);
            }
        }
    }
}
