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
        CollectionViewSource util_PaisesViewSource;
        bool IsNewRecord = false;
        public Paises()
        {
            InitializeComponent();
        }

        private void Paises1_Loaded(object sender, RoutedEventArgs e)
        {
            db = new SIGACEntities();
            util_PaisesViewSource = ((CollectionViewSource)(this.FindResource("util_PaisesViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            var query = db.Util_Paises;
            util_PaisesViewSource.Source = query.ToList();
      
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        
        private void Paises_form_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            db = null;
            util_PaisesViewSource = null;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (IsNewRecord)
            {
                util_PaisesViewSource.View.MoveCurrentToLast();
            }
            db.SaveChanges();
        }

        private void NewButton_Click(object sender, RoutedEventArgs e)
        {
            CleanForm();
            
        }

        private void CleanForm()
        {
            paisIdTextBox.Text = "";
            nombrePaisTextBox.Text = "";
            iSO2TextBox.Text = "";
            iSO3TextBox.Text = "";
            uNTextBox.Text = "";
            webTextBox.Text = "";
            phoneTextBox.Text = "";
            
            
            IsNewRecord = true;
        }

        private void PreviousButton_Click(object sender, RoutedEventArgs e)
        {
            util_PaisesViewSource.View.MoveCurrentToPrevious();
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            util_PaisesViewSource.View.MoveCurrentToNext();
        }
    }
}
