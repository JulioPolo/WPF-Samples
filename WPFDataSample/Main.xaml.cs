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
using WPFDataSample.Models;

namespace WPFDataSample
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        EFSampleContext _dataContext;
        CollectionViewSource contactViewSource;
        public Main()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _dataContext = new EFSampleContext();
            contactViewSource = ((CollectionViewSource)(this.FindResource("contactViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            var query = _dataContext.Contacts.Include("Addresses").Where(c => c.Addresses.Any());
            contactViewSource.Source = query.ToList();
            contactViewSource.View.MoveCurrentToLast();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _dataContext.SaveChanges();
                contactViewSource.View.Refresh();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void Primero_Click(object sender, RoutedEventArgs e)
        {
            contactViewSource.View.MoveCurrentToFirst();
        }

        private void AnteriorButton_Click(object sender, RoutedEventArgs e)
        {
            if (!contactViewSource.View.IsCurrentBeforeFirst)
            {
            contactViewSource.View.MoveCurrentToPrevious();
            }
        }

        private void SiguienteButton_Click(object sender, RoutedEventArgs e)
        {
            if (!contactViewSource.View.IsCurrentAfterLast)
            {
            contactViewSource.View.MoveCurrentToNext();
            }
        }

        private void UltimoButton_Click(object sender, RoutedEventArgs e)
        {
            contactViewSource.View.MoveCurrentToLast();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _dataContext.Dispose();
        }
    }
}
