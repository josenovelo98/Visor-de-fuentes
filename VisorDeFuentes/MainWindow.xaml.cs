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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VisorDeFuentes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void fuentecombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (fuentecombobox.SelectedItem != null) 
            { string fuente = (string)(fuentecombobox.SelectedItem as ComboBoxItem).Content; 
                leyendatextblock.FontFamily = new FontFamily(familyName: fuente); }
        }

        private void cursivacheckbox_Checked(object sender, RoutedEventArgs e)
        {
            leyendatextblock.FontStyle = FontStyles.Italic;
        }
    

        private void cursivacheckbox_Unchecked(object sender, RoutedEventArgs e)
        {
            leyendatextblock.FontStyle = FontStyles.Normal;

        }

        private void negritascheckbox_Checked(object sender, RoutedEventArgs e)
        {
            leyendatextblock.FontWeight = FontWeights.Bold;

        }

        private void negritascheckbox_Unchecked(object sender, RoutedEventArgs e)
        {
            leyendatextblock.FontWeight = FontWeights.Normal;
        }

        private void tamañoradiobuttom_Checked(object sender, RoutedEventArgs e)
        {
            if (smallradiobutton.IsChecked == true) { leyendatextblock.FontSize = 12; } 
            else if (mediumradiobutton.IsChecked == true) { leyendatextblock.FontSize = 18; } 
            else { leyendatextblock.FontSize = 24; }
        }
    }
}
