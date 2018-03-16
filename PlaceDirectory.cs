using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VA_GUI
{
    public class PlaceDirectory
    {
        public Dictionary<string, List<Node>> Dir;

        public PlaceDirectory()
        {
            Dir = new Dictionary<string, List<Node>>();
        }

        /// <summary>
        /// Takes PlaceDirectory b and traveses thru each key,
        /// If key not found, PlaceDirectory will add that key and the contents of said key from PlaceDirectory b to 'this' PlaceDir.
        /// </summary>
        public void Merge(PlaceDirectory b)
        {
            if(b != null && b.Dir.Count > 0)
            { 
            foreach (string k in b.Dir.Keys)
            {
                //Mergin missing keys
                if (!Dir.ContainsKey(k))
                {
                    Dir.Add(k, b.Dir[k]);

                    /*Delete This comment in case it shadow-copies the list
                    
                    List<Node> list = new List<Node>();
                    
                    //Create Deep Copy of nodes
                    foreach (Node n in b.Dir[k])
                    {
                        list.Add(n);
                    }
                    //Add Key and value
                    Dir.Add(k, list);
                    */
                }
                //If key is not missing, Load the entierty of the list*
                //* only if it has more or the same as to avoid data lost
                else
                {
                    if(b.Dir[k].Count >= Dir[k].Count)
                    { 
                        Dir[k] = b.Dir[k];
                    }
                }
            }
            }
        }

    }
}
