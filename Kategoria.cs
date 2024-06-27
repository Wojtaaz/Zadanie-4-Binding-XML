using System.Collections.Generic;
using System.Xml.Serialization;

namespace WpfApp2.Model
{
    [XmlRoot("Kategoria")]
    public class Kategoria
    {
        [XmlAttribute("Nazwa")]
        public string Nazwa { get; set; }

        [XmlElement("Opis")]
        public string Opis { get; set; }

        [XmlArray("Podkategorie")]
        [XmlArrayItem("Podkategoria")]
        public List<Podkategoria> Podkategorie { get; set; }
    }
}
