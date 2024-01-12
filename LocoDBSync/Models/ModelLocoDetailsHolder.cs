using System.IO;
using System.Xml.Serialization;

namespace LocoDBSync.Models
{
    public class ModelLocoDetailsHolder
    {
        public const string FileName = @"E:\temp\LocoDetails.xml";
        public List<ModelLocoDetails> ModelLocoDetails = new List<ModelLocoDetails>();

        public static ModelLocoDetailsHolder Load()
        {
            var xmlData = File.ReadAllText(FileName);

            var serializer = new XmlSerializer(typeof(ModelLocoDetailsHolder));

            ModelLocoDetailsHolder result;

            using (var reader = new StringReader(xmlData))
            {
                result = (ModelLocoDetailsHolder)serializer.Deserialize(reader);
            }
            return result;
        }

        public static void Save(ModelLocoDetailsHolder modelLocoDetailsHolder)
        {
            XmlSerializer xs = new XmlSerializer(typeof(ModelLocoDetailsHolder));

            using (TextWriter tw = new StreamWriter(FileName))
            {
                xs.Serialize(tw, modelLocoDetailsHolder);
            }
        }
    }
}