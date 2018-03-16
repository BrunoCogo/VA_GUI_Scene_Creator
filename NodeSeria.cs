using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VA_GUI
{
    public class NodeSeria
    {
        //Same as node but does not implement a IDictionary
        public enum NodeType { nothing, noncombat, combat }
        public string ID;
        public string Name;
        public string Title;
        public NodeType Type;
        public int OptionCount;
        /// <summary>This dictionary stores the node. it uses the Name attribute in the propety as a key/// </summary>
        //public Dictionary<string, Node> OptionLinking = new Dictionary<string, Node>();
        List<string> oLKeys = new List<string>();//not needed as we can rely on optionidlink
        List<string> oLNode = new List<string>();//Will save Name instead of node for later linking;
        public List<string> OptionIDLink = new List<string>();
        public string EnemyToFight;
        public string Description;
        public bool ProticeStart;
        public bool BattleDescr;
        public double chance;

        public NodeSeria()
        {
                ID = "";
                Type = NodeType.nothing;
                ProticeStart = false;
            
        }

        public NodeSeria(Node n)
        {
            ID = n.ID;
            Name = n.Name;
            Title = n.Title;
            Type = (NodeType)n.Type;
            OptionCount = n.OptionCount;
            /*foreach (string ke in n.OptionLinking.Keys)
            {
                oLKeys.Add(ke);
                oLNode.Add(n.OptionLinking[ke].Name);//Not that important as it will need to tied with the Option ID Link below
            }*/

            OptionIDLink = n.GetIDLinkingList();
            EnemyToFight = n.EnemyToFight;
            Description = n.Description;
            ProticeStart = n.ProticeStart;
            BattleDescr = n.BattleDescr;
            chance = n.chance;
        }

        public Node ToNode()
        {
            Node n = new Node();
            n.ID = ID;
            n.Name = Name;
            n.Title = Title;
            n.Type = (Node.NodeType)Type;
            n.OptionCount = OptionCount;
            n.OptionIDLink = OptionIDLink;
            n.EnemyToFight = EnemyToFight;
            n.Description = Description;
            n.ProticeStart = ProticeStart;
            n.BattleDescr = BattleDescr;
            n.chance = chance;
            return n;
        }
    }
}
