using System.Windows;
using WpfApp2.Model;

namespace WpfApp2
{
    public partial class KategoriaWindow : Window
    {
        public KategoriaWindow(Kategoria kategoria)
        {
            InitializeComponent();
            DataContext = kategoria;
        }

        private void ListBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                Podkategoria selectedPodkategoria = (Podkategoria)e.AddedItems[0];
                PodkategoriaWindow podkategoriaWindow = new PodkategoriaWindow(selectedPodkategoria);
                podkategoriaWindow.Show();
            }
        }
    }
}
