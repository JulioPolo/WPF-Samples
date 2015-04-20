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
        SIGACEntities db;
        System.Windows.Data.CollectionViewSource util_PaisesViewSource;

        public Paises()
        {
            InitializeComponent();
        }

        private void Paises1_Loaded(object sender, RoutedEventArgs e)
        {
            db = new SIGACEntities();
            util_PaisesViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("util_PaisesViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            var query = db.Util_Paises;
            util_PaisesViewSource.Source = query.ToList();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
        }

        private void Paises_form_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            db = null;
            util_PaisesViewSource = null;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            //util_PaisesViewSource.View
        }
    }
}
