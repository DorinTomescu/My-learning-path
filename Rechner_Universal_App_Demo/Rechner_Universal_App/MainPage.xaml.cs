using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Rechner_Universal_App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        int aktiveEingabe;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void eingabe1_GotFocus(object sender, RoutedEventArgs e)
        {
            aktiveEingabe = 1;
        }

        private void eingabe2_GotFocus(object sender, RoutedEventArgs e)
        {
            aktiveEingabe = 2;
        }

        private void Button_Click_Ziffer(object sender, RoutedEventArgs e)
        {
            Anzeigen((sender as Button).Content.ToString());
        }

        private void Button_Click_Rechnung(object sender, RoutedEventArgs e)
        {
            try
            {
                Rechnen((sender as Button).Content.ToString());
            }
            catch
            {
                FehlerMeldung();
            }
        }

        private void Rechnen(string eingabe)
        {
            float zahl1, zahl2, ergebnis = 0;
            zahl1 = Convert.ToSingle(eingabe1.Text);
            zahl2 = Convert.ToSingle(eingabe2.Text);

            if (zahl2 == 0 && eingabe == "/")
            {
                ausgabe.Text = "Null";
                return;
            }

            switch (eingabe)
            {
                case "+":
                    ergebnis = zahl1 + zahl2;
                    break;
                case "-":
                    ergebnis = zahl1 - zahl2;
                    break;
                case "*":
                    ergebnis = zahl1 * zahl2;
                    break;
                case "/":
                    ergebnis = zahl1 / zahl2;
                    break;
            }
            
            ausgabe.Text = ergebnis.ToString();
            
        }

        private void Anzeigen(string eingabe)
        {
            //die Eingabe speichern
            string tempText;
            if (aktiveEingabe == 1)
                tempText = eingabe1.Text;
            else
                tempText = eingabe2.Text;

            //falls das Komma angeklickt wurde, pruefen wir erstmal, ob bereits ein komma gibt
            if (eingabe == "," && tempText.Contains(","))
                return;
            else
                tempText = tempText + eingabe;

            //den geaenderten Text wieder zurueckkopieren
            if (aktiveEingabe == 1)
                eingabe1.Text = tempText;
            else
                eingabe2.Text = tempText;

        }

        private async void FehlerMeldung()
        {
            MessageDialog meinDialog = new MessageDialog("Es ist ein Problem aufgetreten");
            await meinDialog.ShowAsync();
        }

        private void Button_Click_Loeschen(object sender, RoutedEventArgs e)
        {
            eingabe1.Text = string.Empty;
            eingabe2.Text = string.Empty;
            ausgabe.Text = string.Empty;
        }

        public void Speichern()
        {
            //den Container erzeugen
            ApplicationDataContainer lokaleDaten = ApplicationData.Current.LocalSettings;

            //die Daten schreiben
            lokaleDaten.Values["eingabe1"] = eingabe1.Text;
            lokaleDaten.Values["eingabe2"] = eingabe2.Text;
            lokaleDaten.Values["ausgabe"] = ausgabe.Text;
        }

        public void Laden()
        {
            //den Container erzeugen
            ApplicationDataContainer lokaleDaten = ApplicationData.Current.LocalSettings;

            //Falls daten gibt, dann laden
            if (lokaleDaten.Values["eingabe1"] != null)
                eingabe1.Text = lokaleDaten.Values["eingabe1"].ToString();
            if (lokaleDaten.Values["eingabe2"] != null)
                eingabe2.Text = lokaleDaten.Values["eingabe2"].ToString();
            if (lokaleDaten.Values["ausgabe"] != null)
                ausgabe.Text = lokaleDaten.Values["ausgabe"].ToString();
        }


    }
}
