using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VA_GUI
{
    [System.Serializable]
    public class SessionSeriasable
    {
        public List<string> keys = new List<string>();//Places
        public List<List<NodeSeria>> NSerias = new List<List<NodeSeria>>();//NodesFromPlaces [index of key related][list of node][node]

        public SessionSeriasable(PlaceDirectory a)
        {
            GetSessionFrom(a);
        }
        public SessionSeriasable()
        {
        }

        /// <summary>
        /// Get's all session data and translate it into a seriasable form.
        /// </summary>
        /// <param name="placeDirectory"></param>
        void GetSessionFrom(PlaceDirectory placeDirectory)
        {
            foreach (string k in placeDirectory.Dir.Keys)
            {
                
                List<NodeSeria> nl = new List<NodeSeria>();
                foreach (Node item in placeDirectory.Dir[k])
                {
                    nl.Add(new NodeSeria(item));
                }
                keys.Add(k);
                NSerias.Add(nl);
            }
        }

        public PlaceDirectory ToPlaceDirectory()
        {
            PlaceDirectory pd = new PlaceDirectory();
            pd.Dir = new Dictionary<string, List<Node>>();

            for (int i = 0; i < keys.Count; i ++)
            {
                string k = keys[i];
                //Create nodes and add them to the list
                pd.Dir.Add(k, new List<Node>());
                foreach (NodeSeria node in NSerias[i])//for each node in the list of sernodes
                {
                    pd.Dir[k].Add(node.ToNode());
                }
            }

            return pd;
        }
    }

    
}
