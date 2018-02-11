using System;
using System.Collections;
using System.Collections.Generic;

using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VA_GUI
{
    public class Node
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        public enum NodeType { nothing, noncombat, combat }

        public string ID;
        public string Name;
        public string Title;

        public NodeType Type;
        public int OptionCount;

        /// <summary>This dictionary stores the node. it uses the Name attribute in the propety as a key/// </summary>
        public Dictionary<string, Node> OptionLinking = new Dictionary<string, Node>();
        private List<string> OptionIDLink = new List<string>();


        public string EnemyToFight;

        public string Description;

        public bool ProticeStart;
        public bool BattleDescr;

        public double chance;

        //To use for line interpretation only
        enum LineType { ID, Name, Title, Type, OptionCount, Description, Option, Chance, Enemy, Comment, DescribeCombat };

        public Node()
        {
            ID = "Place";
            Type = NodeType.nothing;
            ProticeStart = false;
        }

        public Node(string _id, string _name, string _title, NodeType _type)
        {
            ID = _id;
            Name = _name;
            Title = _title;
            Type = _type;
            ProticeStart = false;
        }
        public Node(string _id, string _name, string _title, NodeType _type, string _description)
        {
            ID = _id;
            Name = _name;
            Title = _title;
            Type = _type;
            Description = _description;
            ProticeStart = false;
        }
        public Node(string _id, string _name, string _title, NodeType _type, string _description, bool StartAdventure, decimal _chance)
        {
            ID = _id;
            Name = _name;
            Title = _title;
            Type = _type;
            Description = _description;
            ProticeStart = StartAdventure;
            chance = (double)_chance;
        }

        public Dictionary<string, Node> GetOptions(Form1 source)
        {
            Dictionary<string, Node> Options = new Dictionary<string, Node>();
            if ((source.dgv_Olinking.Rows[0].Cells[0].Value != null) && (source.dgv_Olinking.Rows[0].Cells[1].Value != null))
            {
                for (int i = 0; i < source.dgv_Olinking.Rows.Count; i++)
                {
                    try
                    {
                        Options.Add(source.dgv_Olinking.Rows[i].Cells[1].Value.ToString(),
                        GetFromList(source, source.dgv_Olinking.Rows[i].Cells[1].Value.ToString()));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    
                }

            }
            return Options;
        }

        public Node GetFromList(Form1 source, string target)
        {
            for (int i = 0; i < source.NodeLibraryList.Count; i++)
            {
                if (source.NodeLibraryList[i].Name == target)
                {
                    return source.NodeLibraryList[i];
                }
            }
            return null;
        }

        public Node GetFromList(List<Node> WorkingList, string target)
        {

            for (int i = 0; i < WorkingList.Count; i++)
            {
                string breakBug = WorkingList[i].Name;
                if (WorkingList[i].Name == target)
                {
                    return WorkingList[i];
                }
            }
            return null;
        }

        public void RelateOptions(List<Node> workList)
        {
            log.Debug("Linking Options of nodes for " + Name);
            for (int i = 0; i < OptionIDLink.Count; i++)
            {
                OptionLinking.Add(OptionIDLink[i], GetFromList(workList, OptionIDLink[i]));
            }
            log.Debug("Finish Linking Options for" + Name);

        }

        /// <summary>
        /// Obtains Node data from exterm of text   
        /// </summary>
        /// <param name="fileSection">Extrap of text separaded node</param>
        public void InterpretNode(List<string> fileSection)
        {
            try
            {
                for (int li = 0; li < fileSection.Count; li++)
                {
                    if (!fileSection[li].StartsWith("#") || fileSection[li].Length != 0)
                    {
                        string data;
                        NodeType Typedata;
                        switch (GetLineType(fileSection[li]))
                        {
                            case LineType.ID:
                                data = fileSection[li].Replace("[", "").Replace(" ", "");
                                ID = data;
                                break;
                            case LineType.Name:
                                data = fileSection[li].Replace("name:", "").Replace(";", "").Replace(" ", "");
                                Name = data;
                                break;
                            case LineType.Title:
                                data = fileSection[li].Replace("title:", "").Replace(";", "");
                                Title = data;
                                break;
                            case LineType.Type:
                                data = fileSection[li].Replace("type:", "").Replace(";", "").Replace(" ", "");
                                if (data == "noncombat") Typedata = NodeType.noncombat;
                                else if (data == "combat") Typedata = NodeType.combat;
                                else Typedata = NodeType.nothing;
                                Type = Typedata;
                                break;

                            case LineType.OptionCount:
                                data = fileSection[li].Replace("optioncount:", "").Replace(";", "").Replace(" ", "");
                                OptionCount = Convert.ToInt16(data);
                                break;

                            case LineType.Description:
                                data = fileSection[li].Replace("description:", "").Replace(";", "");
                                Description = data;
                                break;

                            case LineType.Option:
                                data = fileSection[li].Replace("option:", "").Replace(";", "").Replace(" ", "");
                                OptionIDLink.Add(data);
                                break;

                            case LineType.Chance:
                                data = fileSection[li].Replace("chance:", "").Replace(";", "").Replace(" ", "");
                                chance = Convert.ToDouble(data);
                                ProticeStart = true;
                                break;

                            case LineType.DescribeCombat:
                                data = fileSection[li].Replace("describe:", "").Replace(";", "").Replace(" ", "");
                                BattleDescr = bool.Parse(data);

                                break;
                            case LineType.Enemy:
                                data = fileSection[li].Replace("enemy:", "").Replace(";", "").Replace(" ", "");
                                EnemyToFight = data;
                                break;
                            case LineType.Comment:
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error("THERE WAS AN ERROR TRYING TO READ A NODE", ex);
            }
            
        }

        LineType GetLineType(string line)
        {
            if (line.Contains("["))
            {
                return LineType.ID;
            }
            else if (line.StartsWith("name:"))
            {
                return LineType.Name;
            }
            else if (line.StartsWith("title:"))
            { return LineType.Title; }
            else if (line.StartsWith("type:"))
            { return LineType.Type; }
            else if (line.StartsWith("optioncount:"))
            { return LineType.OptionCount; }
            else if (line.StartsWith("description:"))
            { return LineType.Description; }
            else if (line.StartsWith("option:"))
            { return LineType.Option; }
            else if (line.StartsWith("chance:"))
            { return LineType.Chance; }
            else if (line.StartsWith("enemy:"))
            { return LineType.Enemy; }
            else if (line.StartsWith("describe:"))
            { return LineType.DescribeCombat; }

            //describe
            else
            { return LineType.Comment; }

        }

        public NodeType GetType(Form1 source)
        {
            switch (source.cb_Type.Text)
            {
                case "noncombat":
                    return NodeType.noncombat;
                case "combat":
                    return NodeType.combat;
                case "nothing":
                    return NodeType.nothing;
                default:
                    return NodeType.nothing;
            }
        }
        public NodeType GetType(string m)
        {
            switch (m)
            {
                case "noncombat":
                    return NodeType.noncombat;
                case "combat":
                    return NodeType.combat;
                case "nothing":
                    return NodeType.nothing;
                default:
                    return NodeType.nothing;
            }
        }

        public override string ToString()
        {
            string s;
            s = "Node Name:" + Name + "\n" +
               "Node ID:" + ID + "\n" +
               "Node type" + Type.ToString() + "\n";


            return s;
        }
    }
}
