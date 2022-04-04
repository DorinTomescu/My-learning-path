using System;
using System.Collections.Generic;
using System.Text;

namespace Pong_Spiel
{
    class Score
    {
        //die Felder
        int punkte;
        //die Anzahl der Einträge in der Liste
        int anzahl = 10;
        //für die Liste
        Liste[] besteliste;
        //die Methoden
        //der Konstruktor
        public Score()
        {
            punkte = 0;
            //eine neue Instanz der liste erstellen
            besteliste = new Liste[anzahl];
            //die Elemente initialisieren
            for (int i = 0; i < anzahl; i++)
            {
                besteliste[i] = new Liste();
            }
        }

        public bool NeuerEintrag()
        {
            string tempName = string.Empty;
            //wenn die aktuelle Punktzahl größer ist als der letzte Eintrag der Liste,
            //wird der letzte Eintrag der Liste überschrieben und die Listet neu sortiert
            if (punkte > besteliste[anzahl - 1].GetPunkte())
            {
                //den Namen beschaffen
                NameDialog neuerName = new NameDialog();
                if (neuerName.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    tempName = neuerName.LiefereName();
                neuerName.Close();
                besteliste[anzahl - 1].SetzeEintrag(punkte, tempName);
                Array.Sort(besteliste);
                return true;
            }
            else
                return false;
        }

        public void ListeAusgeben(System.Drawing.Graphics zeichenflaeche, System.Drawing.RectangleF flaeche)
        {
            //ein temporärer Pinsel
            System.Drawing.SolidBrush tempPinsel = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            //die Schriftart setzen
            System.Drawing.Font tempSchrift = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);
            //die Ausgabe zentrieren
            System.Drawing.StringFormat ausrichtung = new System.Drawing.StringFormat();
            //Koordinaten für die Ausgabe
            float punkteX, nameX, y;
            punkteX = flaeche.Width / 2 + 50;
            nameX = flaeche.Width / 2 - 50;
            y = flaeche.Height / 2 - 120;
            //die Ausrichtung zentrieren
            ausrichtung.Alignment = System.Drawing.StringAlignment.Center;
            //die zeichenflaeche loeschen
            zeichenflaeche.Clear(System.Drawing.Color.Black);
            //den Titel ausgeben
            zeichenflaeche.DrawString("Bestenliste", tempSchrift, tempPinsel, flaeche.Width / 2, y, ausrichtung);
            //die Liste selbst ausgeben
            for (int i = 0; i < anzahl; i++)
            {
                y += 20;
                //name ausgeben
                zeichenflaeche.DrawString(Convert.ToString(besteliste[i].GetName()), tempSchrift, tempPinsel, nameX, y);
                //punkte ausgeben
                zeichenflaeche.DrawString(Convert.ToString(besteliste[i].GetPunkte()), tempSchrift, tempPinsel, punkteX, y);

            }

        }

        public int GetPunkte()
        {
            return punkte;
        }

        //zum Verändern der Punkte
        public int VeraenderePunkte(int anzahl)
        {
            punkte = punkte + anzahl;
            if (punkte < 0)
                punkte = 0;
            return punkte;
        }
        //zum Zurücksetzen der Punkte
        public void LoeschePunkte()
        {
            punkte = 0;
        }
    }

    //die Klasse für die Liste implementiert mit IComparable
    class Liste : IComparable
    {
        //die Felder
        int listePunkte;
        string listeName;

        //die Methoden
        //der Konstruktor
        public Liste()
        {
            //er setzt die Punkte und den Namen auf Standardwerte
            listePunkte = 0;
            listeName = "Nobody";
        }

        //die Vergleichsmethode von IComparable
        public int CompareTo(object obj)
        {
            Liste tempListe = (Liste)(obj);
            if (this.listePunkte < tempListe.listePunkte)
                return 1;
            if (this.listePunkte > tempListe.listePunkte)
                return -1;
            else
                return 0;
        }

        //die Methode zum Setzen von Einträgen
        public void SetzeEintrag(int punkte, string name)
        {
            listePunkte = punkte;
            listeName = name;
        }

        //die Methode zum Liferen der Punkte
        public int GetPunkte()
        {
            return listePunkte;
        }

        //die Methode zum lifern des Namens
        public string GetName()
        {
            return listeName;
        }

    }
}
