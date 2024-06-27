using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Xml.Serialization;
using WpfApp2.Model;

namespace WpfApp2.ViewModel
{
    public class KategorieViewModel
    {
        public ObservableCollection<Kategoria> Kategorie { get; set; }

        public KategorieViewModel()
        {
            Kategorie = new ObservableCollection<Kategoria>();
            LoadData();
        }

        private void LoadData()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Kategorie));
            using (FileStream fs = new FileStream("dane.xml", FileMode.Open))
            {
                Kategorie kategorie = (Kategorie)serializer.Deserialize(fs);
                foreach (var kategoria in kategorie.ListaKategorii)
                {
                    Kategorie.Add(kategoria);
                }
            }
        }
    }

    [XmlRoot("Kategorie")]
    public class Kategorie
    {
        [XmlElement("Kategoria")]
        public List<Kategoria> ListaKategorii { get; set; }
    }
}
