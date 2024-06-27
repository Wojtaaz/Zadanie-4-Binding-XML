using System.Collections.Generic;
using System.Xml.Serialization;

namespace WpfApp2.Model
{
    [XmlRoot("Podkategoria")]
    public class Podkategoria
    {
        [XmlAttribute("Nazwa")]
        public string Nazwa { get; set; }

        [XmlElement("Opis")]
        public string Opis { get; set; }

        [XmlArray("Modele")]
        [XmlArrayItem("Model")]
        public List<Model> Modele { get; set; }
    }
}
