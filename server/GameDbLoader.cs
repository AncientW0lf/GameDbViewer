using System.IO;
using System.Xml.Serialization;

namespace GameDbViewer
{
    public class GameDbLoader
    {
        public GameDb Load()
        {
            using var file = File.Open(@".\wwwroot\db\wii\wiitdb.xml", FileMode.Open, FileAccess.Read, FileShare.Read);

            return (GameDb)new XmlSerializer(typeof(GameDb)).Deserialize(file);
        }
    }
}