using System.Xml.Serialization;

namespace WpfApp2.Model
{
    [XmlRoot("Model")]
    public class Model
    {
        [XmlAttribute("Nazwa")]
        public string Nazwa { get; set; }

        [XmlAttribute("RokProdukcji")]
        public int RokProdukcji { get; set; }

        [XmlAttribute("PojemnoscSilnika")]
        public string PojemnoscSilnika { get; set; }

        [XmlAttribute("RodzajNapędu")]
        public string RodzajNapędu { get; set; }
    }
}
