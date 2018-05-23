using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                    //Check if file still exist
                    if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\voreadventure\\custom\\places\\" + k))
                    {
                        if (MessageBox.Show("The place \"" + k + "\" does not exits, but there was a reference in the pass session,\n would you like to keep the data of this place?", "Missing place referd - Previous session", MessageBoxButtons.YesNo) == DialogResult.No)
                        {
                            continue;
                        }
                    }
                //Mergin missing keys
                if (!Dir.ContainsKey(k))
                {
                    Dir.Add(k, b.Dir[k]);
                        
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
