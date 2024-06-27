using System.Windows;
using WpfApp2.Model;
using WpfApp2.ViewModel;

namespace WpfApp2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                Kategoria selectedKategoria = (Kategoria)e.AddedItems[0];
                KategoriaWindow kategoriaWindow = new KategoriaWindow(selectedKategoria);
                kategoriaWindow.Show();
            }
        }
    }
}
