using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace VA_GUI
{
    public class SessionLS
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SessionLS()
        {
        }

        //From Xml to program
        public SessionSeriasable LoadPreviousSession()
        {
            SessionSeriasable session = new SessionSeriasable();
            log.Info("Xml Serializer iniziated: Recovering last session.");
            string path = Environment.CurrentDirectory + "\\session.xml";

            if (!File.Exists(path)) return new SessionSeriasable();
            StreamReader sessionFile = new StreamReader(path);
            try
            {
                
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(SessionSeriasable));

                log.Debug("Loading Session Stored at: " + path);
                                  
                    log.Info("Session Dound and ready for loading");
                    SessionSeriasable sac = (SessionSeriasable)xmlSerializer.Deserialize(sessionFile);
                    sessionFile.Close();
                    return sac;
               

            }
            catch (Exception ex)
            {
                sessionFile.Close();
                log.Error("Fatal error loading session. Returning empty session Data\n", ex);
                return new SessionSeriasable();
            }
        }

        //From Program to xml
        public void SaveSession(PlaceDirectory a)
        {

            string path = Environment.CurrentDirectory + "\\session.xml";
            SessionSeriasable session = new SessionSeriasable(a);
            StreamWriter writer = new StreamWriter(path);

            XmlSerializer serializer = new XmlSerializer(session.GetType());

            serializer.Serialize(writer, session);
            writer.Close();
        }

    }
}
