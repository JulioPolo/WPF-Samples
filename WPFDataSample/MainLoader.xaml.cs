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
    /// Interaction logic for MainLoader.xaml
    /// </summary>
    public partial class MainLoader : Window
    {
        public MainLoader()
        {
            InitializeComponent();
        }

        private void PaisesButton_Click(object sender, RoutedEventArgs e)
        {
            var newWindow = new Paises();
            newWindow.Show();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
