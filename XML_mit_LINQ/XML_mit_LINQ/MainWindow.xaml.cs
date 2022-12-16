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
using System.Xml.Linq;

namespace XML_mit_LINQ
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string xmlPfad = "c:\\test\\testliste.xml";
        XElement bestenliste;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void LadenButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bestenliste = XElement.Load(xmlPfad);
                bestenlisteGrid.DataContext = bestenliste;
            }
            catch
            {
                MessageBox.Show($"There was a error loading the file", "ERROR", MessageBoxButton.OK);
            }
            
        }

        private void SpeichernButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bestenliste.Save(xmlPfad);
            }
            catch
            {
                MessageBox.Show($"There was a error saving the file", "ERROR", MessageBoxButton.OK);
            }
        }

        private void NeuerEintragButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bestenliste.Add(new XElement("eintrag", new XElement("name", "<leer>"), new XElement("punkte", "<leer>")));
            }
            catch
            {
                MessageBox.Show($"There was a error Adding a new line to the file ", "ERROR", MessageBoxButton.OK);
            }
        }
        
    }
}
