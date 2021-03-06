﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VA_GUI
{
    public partial class Output_Previewer : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        string myName = "";

        List<string> Aveilable_enemies;

        List<Node> NodeCollection;
        List<string> WasNotReferencedList;
        List<string> WasReferencedList;

        List<string> EnemiesUsed;

        CREDIT c = new CREDIT();

        List<string> InvalidReferencedList;

        const string L = "\r\n";

        public Output_Previewer(List<Node> placeNodes, string PlaceName, List<string> Enemies)
        {
            Aveilable_enemies = Enemies;
            log.Debug("Initiating Output Preview");
            if (placeNodes.Count == 0)
            {
                log.Warn("WARNING - There is no nodes on the previwer to preview");
            }
            InitializeComponent();
            NodeCollection = placeNodes;
            myName = PlaceName;

            c.mainAuthor = "";
            c.EnemyAuthors = "";
            c.Editors = "";
            c.SpecialTanks = "";
        }

        private void Output_Previewer_Load(object sender, EventArgs e)
        {
            log.Debug("");
            GenerateFile();
        }

        void GetReferencesValue()
        {
            if(WasNotReferencedList != null)
            { 
            WasNotReferencedList.Clear();
            }
            else
            {
                WasNotReferencedList = new List<string>();
            }
            foreach (Node item in NodeCollection)
            {
                WasNotReferencedList.Add(item.Name);

                //foreach (string option in item.OptionLinking.Keys)
                //{
                //    if(!WasNotReferencedList.Contains(option))
                //    { 
                //        if (!InvalidReferencedList.Contains(option))
                //        {
                //            InvalidReferencedList.Add(option);
                //        }
                //    }
                //}
            }
            foreach (Node item in NodeCollection)
            {
                foreach (string option in item.OptionLinking.Keys)
                {
                    if (!WasNotReferencedList.Contains(option))
                    {
                        if (!InvalidReferencedList.Contains(option))
                        {
                            InvalidReferencedList.Add(option);
                        }
                    }
                }
            }


        }

        void GenerateFile()
        {
            bool hasstarter = false;
            Textbox_PREVIEW.Text += "2.0.0\r\n";
            Textbox_PREVIEW.Text += "#File Created in VA_GUI by Cogo";
            Textbox_PREVIEW.Text += L;

            //Credits Go here//
            Textbox_PREVIEW.Text += "#_______________Credits_________________" + L;
            if (c.mainAuthor.Count() > 0)
            {
                Textbox_PREVIEW.Text += "#Author: " + c.mainAuthor + L + L;
            }
            if (c.EnemyAuthors.Count() > 0)
            {
                Textbox_PREVIEW.Text += "#Enemy Author:" + c.EnemyAuthors.Replace("\n","  ") + L + L ;
            }
            if (c.Editors.Count() > 0)
            {
                Textbox_PREVIEW.Text += "#Editor: " + c.Editors.Replace("\n", "  ") + L+ L;
            }
            if (c.SpecialTanks.Count() > 0)
            {
                Textbox_PREVIEW.Text += "#Special Thanks: " + c.SpecialTanks.Replace("\n", "  ") + L + L;
            }
            Textbox_PREVIEW.Text += "#__________End Credits____________________" + L + L;

            //
          

            WasReferencedList = new List<string>();
            InvalidReferencedList = new List<string>();
            EnemiesUsed = new List<string>();
            GetReferencesValue();

            foreach (Node node in NodeCollection)
            {
                if (node.ProticeStart) { hasstarter = true; }
                TranslateNode(node);
            }
            HasStarter.Checked = hasstarter;
            lb_nodeCount.Text = NodeCollection.Count.ToString();
            lb_charcount.Text = Textbox_PREVIEW.Text.Length.ToString() + " Characters";
            log.Info("This place \""+ myName +"\" has finish being interpreted as a vgp file, Output on textbox");

            UpdateSideAssistaint();
        }

        void SetReference(string name)
        {
            foreach (string item in WasNotReferencedList)
            {
                if (item == name)
                {
                    WasReferencedList.Add(item);
                    WasNotReferencedList.Remove(item);
                    return;
                }
            }
            //InvalidReferencedList.Add(name);
        }

        public List<string> TranslateNode(Node thisNode)
        {
            List<string> stringNodes = new List<string>();
            Textbox_PREVIEW.Text += thisNode.ID + " [" + L;
            switch (thisNode.Type)
            {
                case Node.NodeType.combat:
                    Textbox_PREVIEW.Text += "name:" + thisNode.Name + ";" + L;
                    Textbox_PREVIEW.Text += "title:" + thisNode.Title + ";" + L;
                    Textbox_PREVIEW.Text += "type:" + "combat" + ";" + L;
                    if(thisNode.EnemyToFight.Trim() != "")
                    { 
                    Textbox_PREVIEW.Text += "enemy:" + thisNode.EnemyToFight + ";" + L;

                        //Check that we do have an enemy
                        if (Aveilable_enemies.Contains(thisNode.EnemyToFight))//!EnemiesUsed.Contains(thisNode.EnemyToFight.ToString()) || )
                        {
                            //check if enemy has been added
                            if(!EnemiesUsed.Contains(thisNode.EnemyToFight.ToString()))
                            EnemiesUsed.Add(thisNode.EnemyToFight);
                        }
                        else
                        {
                            if (MessageBox.Show("Enemy refer is not in enemy librery, do you still want to continue using this enemy?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                EnemiesUsed.Add(thisNode.EnemyToFight + "(Not know in library)");
                            }
                        }
                    }
                    else
                    {
                        log.Error("tried implementing a combat node with no enemy attached");
                        MessageBox.Show("There was an error with node : " + thisNode.ToString() + "\nThis node has no enemy or known enemy on a combat node. Closeing Previewer."); this.Close();
                    }

                    Textbox_PREVIEW.Text += "describe:" + thisNode.BattleDescr.ToString().ToLower() + ";" + L;
                    //Textbox_PREVIEW.Text += "description:" + thisNode.Description.Replace("\"","'") + ";" + L;
                    if (thisNode.ProticeStart)
                    {
                        SetReference(thisNode.Name);
                        Textbox_PREVIEW.Text += "chance: " + thisNode.chance.ToString() + ";" + L;
                    }



                    break;

                case Node.NodeType.nothing:
                    Textbox_PREVIEW.Text += "name:" + thisNode.Name + ";" + L;
                    Textbox_PREVIEW.Text += "title:" + thisNode.Title + ";" + L;
                    Textbox_PREVIEW.Text += "type:" + "nothing" + ";" + L;
                    Textbox_PREVIEW.Text += "description:" + thisNode.Description.Replace("\"", "'") + ";" + L;
                    if (thisNode.ProticeStart)
                    {
                        SetReference(thisNode.Name);
                        Textbox_PREVIEW.Text += "chance: " + thisNode.chance.ToString() + ";" + L;
                    }


                    break;

                case Node.NodeType.noncombat:
                    Textbox_PREVIEW.Text += "name:" + thisNode.Name + ";" + L;
                    Textbox_PREVIEW.Text += "title:" + thisNode.Title + ";" + L;
                    Textbox_PREVIEW.Text += "type:" + "noncombat" + ";" + L;
                    Textbox_PREVIEW.Text += "optioncount:" + thisNode.OptionCount + ";" + L;
                    Textbox_PREVIEW.Text += "description:" + thisNode.Description.Replace("\"", "'") + ";" + L;

                    foreach (KeyValuePair<string,Node> item in thisNode.OptionLinking)
                    {
                        Textbox_PREVIEW.Text += "option:"+ item.Key+ ";" + L;
                        SetReference(item.Key);
                    }
                    if(thisNode.ProticeStart)
                    {
                        SetReference(thisNode.Name);
                        Textbox_PREVIEW.Text += "chance: " + thisNode.chance.ToString() + ";" + L;
                    }

                    break;
               
                default:
                    MessageBox.Show("No type Node detected. Error imminent");
                    log.Error("No Type Node Detected");
                    break;
            }
            Textbox_PREVIEW.Text += "];" + L + L;

            return stringNodes;
        }

        public void UpdateSideAssistaint()
        {
            log.Debug("Updating Node");
            UpdateNodeRef();
            UpdateInvalid();
            UpdateUsedEnemies();
            log.Debug("Finish Updating Node");
        }

        public void UpdateNodeRef()
        {
            tb_Nodes.Text = "";

            foreach (string node in WasNotReferencedList)
            {
                log.Warn(node + " not used by another node");
                tb_Nodes.Text += node + L;
            }
        }

        public void UpdateInvalid()
        {

            tb_Invalid.Text = "";

            foreach (string inv in InvalidReferencedList)
            {
                log.Warn(inv + " not in list");
                tb_Invalid.Text += inv + L;
            }
        }

        public void UpdateUsedEnemies()
        {
            tb_Enemies.Text = "";

            foreach (string enemy in EnemiesUsed)
            {
                tb_Enemies.Text += enemy + L;
            }
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            log.Debug("Previewer was closed by User");
            this.Close();
        }

        private void bt_saveFile_Click(object sender, EventArgs e)
        {
            log.Debug("Saving: " + myName);
            string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\voreadventure\\custom\\places\\" + myName + ".vgp";
            MessageBox.Show(path);
            StreamWriter NewFile = new StreamWriter(path);
            NewFile.Write(Textbox_PREVIEW.Text);
            NewFile.Close();
            log.Info("Save Complete");
        }

        private void bt_Credits_Click(object sender, EventArgs e)
        {
            log.Debug("Iniciating Credit Form");
            Credits cs = new Credits();
            if (cs.ShowDialog() == DialogResult.OK)
            {
                c.mainAuthor = cs.cred.mainAuthor;
                c.EnemyAuthors = cs.cred.EnemyAuthors;
                c.Editors = cs.cred.Editors;
                c.SpecialTanks = cs.cred.SpecialTanks;

                Textbox_PREVIEW.Text = "";
                cs.Close();
                log.Info("Credits Finish Succesfully");
                GenerateFile();
            }
        }
    }
}
