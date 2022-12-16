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

namespace SQL_mit_LINQ
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private KontakteDataContext kontext;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void DatenLaden()
        {
            //Kontext erstellen
            kontext = new KontakteDataContext();

            //die Daten laden
            var kontakte = from kontakt in kontext.Kontakte
                           select kontakt;

            //als Quelle setzen
            KontakteGrid.ItemsSource = kontakte;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DatenLaden();
        }

        private void buttonNeuerEintrag_Click(object sender, RoutedEventArgs e)
        {
            kontext.SubmitChanges();
        }

        private void buttonAktualisieren_Click(object sender, RoutedEventArgs e)
        {
            //die markierte Zeile setzen
            Kontakte kontaktZeile = KontakteGrid.SelectedItem as Kontakte;
            
            //die Nummer beschaffen
            int suche = kontaktZeile.kNummer;
            
            //den Eintrag selektieren
            Kontakte kontakt = (from eintrag in kontext.Kontakte
                                where eintrag.kNummer == kontaktZeile.kNummer
                                select eintrag).Single();

            //die Daten setzen
            kontakt.nachname = kontaktZeile.nachname;
            kontakt.vorname = kontaktZeile.vorname;
            kontakt.postleitzahl = kontaktZeile.postleitzahl;
            kontakt.ort = kontaktZeile.ort;
            kontakt.strasse = kontaktZeile.strasse;
            kontakt.telefon = kontaktZeile.telefon;
            kontakt.email = kontaktZeile.email;

            //ändern
            kontext.SubmitChanges();

        }

        private void buttonLoeschen_Click(object sender, RoutedEventArgs e)
        {
            //die markierte Zeile setzen
            Kontakte kontaktZeile = KontakteGrid.SelectedItem as Kontakte;

            //die Nummer beschaffen
            int suche = kontaktZeile.kNummer;

            //den Eintrag selektieren
            Kontakte kontakt = (from eintrag in kontext.Kontakte
                                where eintrag.kNummer == kontaktZeile.kNummer
                                select eintrag).Single();

            //die Daten löschen
            kontext.Kontakte.DeleteOnSubmit(kontakt);

            //ändern
            kontext.SubmitChanges();

            //die Daten neu laden
            DatenLaden();
        }
    }
}
