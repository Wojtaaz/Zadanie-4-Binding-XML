using System.Windows;
using WpfApp2.Model;

namespace WpfApp2
{
    public partial class PodkategoriaWindow : Window
    {
        public PodkategoriaWindow(Podkategoria podkategoria)
        {
            InitializeComponent();
            DataContext = podkategoria;
        }
    }
}
