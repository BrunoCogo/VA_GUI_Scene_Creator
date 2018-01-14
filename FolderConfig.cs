using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VA_GUI
{
    class FolderConfig
    {
        public List<Node> NodeLibraryList = new List<Node>();


        FolderConfig(List<Node> _nodes)
        {
            NodeLibraryList.AddRange(_nodes);
        }
    }
}
