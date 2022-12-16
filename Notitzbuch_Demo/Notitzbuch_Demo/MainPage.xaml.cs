using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Notitzbuch_Demo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void liste_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //den Eintrag aus dem markierten Listenelement kopieren
            if (liste.SelectedIndex != -1)
            {
                anzeige.Text = ((ListViewItem)(liste.SelectedItem)).Content.ToString();
            }
        }

        private void anzeige_TextChanged(object sender, TextChangedEventArgs e)
        {
            //den Eintrag aus dem Textfeld in das Listenelement kopieren
            if (liste.SelectedIndex != -1)
            {
                ((ListViewItem)(liste.SelectedItem)).Content = anzeige.Text;
            }
        }

        private void Neu_Click(object sender, RoutedEventArgs e)
        {
            //einen neuen Eintrag erzeugen und anhängen
            ListViewItem eintrag = new ListViewItem();
            eintrag.Content = "<leer>";
            liste.Items.Add(eintrag);
            //den Eintrag markieren
            liste.SelectedIndex = liste.Items.Count - 1;
        }

        private async void Speichern_Click(object sender, RoutedEventArgs e)
        {
            //lokalen Ordner beschaffen
            StorageFolder lokalerOrdner = ApplicationData.Current.LocalFolder;

            //die Datei erzeugen und ggf. ueberschreiben
            StorageFile datei = await lokalerOrdner.CreateFileAsync("notizen.txt", CreationCollisionOption.ReplaceExisting);

            //ist die Datei angelegt ?
            if (datei != null)
            {
                //die Eintraege anhaengen
                List<string> tempListe = new List<string>();

                foreach (ListViewItem eintrag in liste.Items)
                    tempListe.Add(eintrag.Content.ToString());

                //die Zeilen in die Datei schreiben
                await FileIO.WriteLinesAsync(datei, tempListe);
            }

        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                //den lokalen Ordner beschaffen
                StorageFolder lokalerOrdner = ApplicationData.Current.LocalFolder;
                //die Datei beschaffen
                StorageFile datei = await lokalerOrdner.GetFileAsync("notizen.txt");

                if (datei != null)
                {
                    IList<string> tempListe = new List<string>();
                    tempListe = await FileIO.ReadLinesAsync(datei);

                    foreach (string eintragText in tempListe)
                    {
                        //einen neuen Eintrag erzeugen und anhaengen
                        ListViewItem eintrag = new ListViewItem();
                        eintrag.Content = eintragText;
                        liste.Items.Add(eintrag);
                    }
                }

                //Eintrag markieren
                liste.SelectedIndex = liste.Items.Count - 1;
            }
            catch
            {
                //falls ein Problem augetreten ist, haengen wir einen leeren Eintrag and die Liste an
                Neu_Click(sender, e);
            }

        }


    }
}
