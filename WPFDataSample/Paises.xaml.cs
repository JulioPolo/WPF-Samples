using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFDataSample
{
    /// <summary>
    /// Interaction logic for Paises.xaml
    /// </summary>
    public partial class Paises : Window
    {
        public Paises()
        {
            InitializeComponent();
        }

        private void Paises1_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource util_PaisesViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("util_PaisesViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // util_PaisesViewSource.Source = [generic data source]
        }
    }
}
