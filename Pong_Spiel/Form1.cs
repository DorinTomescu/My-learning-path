using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong_Spiel
{
    public partial class Form1 : Form
    {
        struct SpielBall
        {
            //wenn die Richtung true ist, geht es nach oben bzw. nach rechts,
            //sonts nach unten bzw. nach links
            public bool richtungX;
            public bool richtungY;

            //für die Veränderung des Bewegungswinkels
            public int winkel;
        }

        //fuer die Punkte
        int punkteMehr, punkteWeniger;
        //fuer die Veraenderung des Winkels
        int winkelZufall;

        Score spielPunkte;
        //für die Zeichenfläche
        Graphics zeichenflaeche;
        //für das Spielfeld
        Rectangle spielfeldGroesse;
        int spielfeldMaxX, spielfeldMaxY, spielfeldMinX, spielfeldMinY;
        int spielfeldLinienBreite;

        //felder für Pause und Spielzeit
        public bool spielPause;
        public int aktuelleSpielZeit;

        Font schrift;

        //für den Schläger
        int schlaegerGroesse;
        //für den Ball
        SpielBall ballPosition;
        //zum Zeichnen
        SolidBrush pinsel;

        //
        //Aufgabe 2.
        //
        //fuer die Rahmenfarbe
        Color rahmenFarbe;

        public Form1()
        {
            InitializeComponent();

            //die Breite der Linien
            spielfeldLinienBreite = 10;
            //die Größe des Schlägers
            schlaegerGroesse = 50;
            //erst einmal geht der Ball nach rechts und oben mit dem Winkel 0
            ballPosition.richtungX = true;
            ballPosition.richtungY = true;
            ballPosition.winkel = 15;
            //den Pinsel erzeugen
            pinsel = new SolidBrush(Color.Black);
            //die Zeichenfläche beschaffen
            zeichenflaeche = spielFeld.CreateGraphics();
            //das Spielfeld bekommt einen schwarzen Hintergrund
            spielFeld.BackColor = Color.LightBlue;

            //
            //Aufgabe 2.
            //
            //die Farben fuer die Rahmen setzen
            rahmenFarbe = Color.Green;

            SetzeSpielfeld();
            NeuerBall();
            punkteMehr = 2;
            punkteWeniger = -8;
            winkelZufall = 5;

            pauseToolStripMenuItem.Enabled = false;
            spielPunkte = new Score();
            spielPause = true;

            aktuelleSpielZeit = Convert.ToInt32(timerSpiel.Interval) / 1000;
            schrift = new Font("Arial", 12, FontStyle.Bold);

            //alle drei Timer sind zunächst angehalten
            timerBall.Enabled = false;
            timerSpiel.Enabled = false;
            timerSekunde.Enabled = false;
        }

        //einen Dialog zum Neustart erzeugen und das Ergebnis zurück liefern
        private bool NeuesSpiel()
        {
            bool ergebnis = false;
            pauseToolStripMenuItem.Enabled = true;
            spielPunkte.LoeschePunkte();
            ZeichnePunkte("0");

            if (MessageBox.Show("Neues Spiel starten?", "Neues Spiel", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //die Spielzeit neu starten
                aktuelleSpielZeit = 120;
                //alles neu zeichnen
                ZeichneSpielfeld();
                NeuerBall();
                ZeichneZeit(Convert.ToString(aktuelleSpielZeit));
                ergebnis = true;
            }

            return ergebnis;
        }

        //setzt die Einstellungen fuer den Schwierigkeitsgrad
        private void SetzeEinstellungen(int schlaeger, int mehr, int weniger, int winkel)
        {
            schlaegerGroesse = schlaeger;
            punkteMehr = mehr;
            punkteWeniger = weniger;
            winkelZufall = winkel;
        }

        private void ZeichnePunkte(string punkte)
        {
            //zuerst die alte Anzeige überschreiben
            pinsel.Color = spielFeld.BackColor;
            zeichenflaeche.FillRectangle(pinsel, spielfeldMaxX - 50, spielfeldMinY + 40, 30, 20);
            //die Rahmenfarbe fuer den Schrift
            pinsel.Color = rahmenFarbe;
            //die Einstellungen für die Schrift werden beim Erstellen des Spielfelds gesetzt
            zeichenflaeche.DrawString(punkte, schrift, pinsel, new Point(spielfeldMaxX - 50, spielfeldMinY + 40));
        }

        private void ZeichneZeit(string restzeit)
        {
            //zuerst die alte Anzeige "überschreiben"
            pinsel.Color = spielFeld.BackColor;
            zeichenflaeche.FillRectangle(pinsel, spielfeldMaxX - 50, spielfeldMinY + 20, 30, 20);
            //in weißer Schrift
            pinsel.Color = rahmenFarbe;
            //die Auszeichnungen für die Schrift werden beim Erstellen des Spielfelds gesetzt
            zeichenflaeche.DrawString(restzeit, schrift, pinsel, new Point(spielfeldMaxX - 50, spielfeldMinY + 20));
        }

        private void SetzeSpielfeld()
        {
            spielfeldGroesse = spielFeld.ClientRectangle;
            //die minimalen und die maximalen Ränder festlegen
            //dabei werden die Linien berücksichtigt
            spielfeldMaxX = spielfeldGroesse.Right - spielfeldLinienBreite;
            //den linken Rand verschieben wir ein Pixel nach rechts
            spielfeldMinX = spielfeldGroesse.Left + spielfeldLinienBreite + 1;
            spielfeldMaxY = spielfeldGroesse.Bottom - spielfeldLinienBreite;
            spielfeldMinY = spielfeldGroesse.Top + spielfeldLinienBreite;
        }

        private void ZeichneSpielfeld()
        {
            //die Begrenzungen
            pinsel.Color = rahmenFarbe;
            //ein Rechteck oben
            zeichenflaeche.FillRectangle(pinsel, 0, 0, spielfeldMaxX, spielfeldLinienBreite);
            //ein Rechteck rechts
            zeichenflaeche.FillRectangle(pinsel, spielfeldMaxX, 0, spielfeldLinienBreite, spielfeldMaxY + spielfeldLinienBreite);
            //ein Rechteck unten
            zeichenflaeche.FillRectangle(pinsel, 0, spielfeldMaxY, spielfeldMaxX, spielfeldLinienBreite);

            //eine graue Linie in die Mitte
            pinsel.Color = Color.Gray;
            zeichenflaeche.FillRectangle(pinsel, spielfeldMaxX/ 2, spielfeldMinY, spielfeldLinienBreite, spielfeldMaxY - spielfeldLinienBreite);
        }

        //setzt die Position des Balls
        private void ZeichneBall(Point position)
        {
            //zufallszahl erzeugen
            Random zufall = new Random();
            ball.Location = position;

            //wenn der Ball rechts anstößt, ändern wir die Richtung
            if (position.X + ball.Width >= spielfeldMaxX)
                ballPosition.richtungX = false; 
            //stößt er unten bzw. oben an, ebenfalls
            if (position.Y + ball.Height >= spielfeldMaxY)
                ballPosition.richtungY = true;
            else if (position.Y <= spielfeldMinY)
                ballPosition.richtungY = false;
            //ist er wieder links, prüfen wir, ob der Schläger in der Nähe ist
            if (position.X == spielfeldMinX && schlaeger.Top <= position.Y + ball.Height && schlaeger.Bottom >= position.Y)
            {
                if (ballPosition.richtungX == false)
                {
                    //einen Punkt dazu und die Punkte ausgeben
                    ZeichnePunkte(Convert.ToString(spielPunkte.VeraenderePunkte(punkteMehr)));
                    //sound play
                    System.Media.SystemSounds.Asterisk.Play();
                }                    
                //die richtung ändern
                ballPosition.richtungX = true;
                //und den Winkel
                ballPosition.winkel = zufall.Next(winkelZufall);                
            }
            //ist der Ball hinter dem Schläger
            if (position.X < spielfeldMinX)
            {
                //fünf Punkte abziehen und die Punkte ausgeben
                ZeichnePunkte(Convert.ToString(spielPunkte.VeraenderePunkte(punkteWeniger)));
                
                //eine kurze Pause einlegen
                System.Threading.Thread.Sleep(1000);

                //alles neu starten
                ballPosition.richtungX = true;
                ZeichneBall(new Point(spielfeldMinX, position.Y));
            }                
        }

        //setzt die Y-Position des Schlägers
        private void ZeichneSchlaeger(int y)
        {
            schlaeger.BackColor = rahmenFarbe;
            if (y + schlaegerGroesse < spielfeldMaxY && y > spielfeldMinY)
                schlaeger.Top = y;
        }

        private void spielFeld_Paint(object sender, PaintEventArgs e)
        {
            ZeichneSpielfeld();
            ZeichnePunkte(spielPunkte.GetPunkte().ToString());
        }

        private void schlaeger_MouseMove(object sender, MouseEventArgs e)
        {
            if (spielPause == true)
            {
                return;
            }
            if (e.Button == MouseButtons.Left)
            {
                ZeichneSchlaeger(e.Y + schlaeger.Top);
            }
        }

        private void timerBall_Tick(object sender, EventArgs e)
        {
            int neuX = 0;
            int neuY = 0;
            //abhängig von der Bewegungsrichtung die Koortinaten neu setzen
            if (ballPosition.richtungX == true)
                neuX = ball.Left + 10;
            else
                neuX = ball.Left - 10;

            if (ballPosition.richtungY == true)
                neuY = ball.Top - ballPosition.winkel;
            else
                neuY = ball.Top + ballPosition.winkel;
            //den Ball neu zeichnen
            ZeichneBall(new Point(neuX, neuY));
        }

        private void timerSekunde_Tick(object sender, EventArgs e)
        {
            //eine sekunde abziehen
            aktuelleSpielZeit -= 1;
            //zeit ausgeben
            ZeichneZeit(Convert.ToString(aktuelleSpielZeit));
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //erstmal prüfen, ob das Spiel läuft
            if (spielPause == false)
            {
                //alle Timer anhalten
                timerBall.Enabled = false;
                timerSekunde.Enabled = false;
                timerSpiel.Enabled = false;
                //die Markierung im Menü einschalten
                pauseToolStripMenuItem.Checked = true;
                //den Text in der Titelleiste ändern
                this.Text = "Pong - Das Spiel ist angehalten!";
                spielPause = true;
            }
            else
            {
                //das Intervall für die verbleibende Spielzeit setzen
                timerSpiel.Interval = aktuelleSpielZeit * 1000;
                //aller Timer wieder an
                timerBall.Enabled = true;
                timerSekunde.Enabled = true;
                timerSpiel.Enabled = true;
                //die Markierung im Menü abschalten
                pauseToolStripMenuItem.Checked = false;
                //den Text in der Titelleiste ändern
                this.Text = "Pong";
                spielPause = false;
            }

        }

        private void neuesSpielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //falls ein Spiel gerade läuft, erstmal den Spiel pausieren
            if (spielPause == false)
            {
                pauseToolStripMenuItem_Click(sender, e);
                //den Dialog anzeigen
                NeuesSpiel();
                //und weiter spielen
                pauseToolStripMenuItem_Click(sender, e);
            }
            //wenn kein Spiel läuft, starten wir ein neues falls gewünscht ist
            else
            {
                if (NeuesSpiel() == true)
                {
                    pauseToolStripMenuItem_Click(sender, e);
                }
            }
        }

        private void timerSpiel_Tick(object sender, EventArgs e)
        {
            //das Spiel anhalten
            pauseToolStripMenuItem_Click(sender, e);
            //eine Meldung anzeigen
            MessageBox.Show("Die Zeit is um", "Spielende", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //nachsehen, ob ein neuer Eintrag in der Bestenliste erfolgen kann
            if (spielPunkte.NeuerEintrag() == true)
            {
                //Ball und Schlaeger verstecken
                ball.Hide();
                schlaeger.Hide();
                //die Liste ausgeben
                spielPunkte.ListeAusgeben(zeichenflaeche, spielfeldGroesse);
                //paar Sekunden warten
                System.Threading.Thread.Sleep(5000);
                //die Zeichenflaeche loeschen
                //
                //
                zeichenflaeche.Clear(spielFeld.BackColor);
                //Ball und Schlaeger wieder anzeigen
                ball.Show();
                schlaeger.Show();
                SpielBeenden();
            }

            //Abfrage, ob ein neues Spiel gestartet werden soll
            if (NeuesSpiel() == true)
            {
                //das Spiel fortsetzen
                pauseToolStripMenuItem_Click(sender, e);                
            }
            else
            {
                pauseToolStripMenuItem_Click(sender, e);
                //das Spiel beenden und das Feld zeichnen
                SpielBeenden();
            }
        }

        private void SpielBeenden()
        {
            ZeichneSpielfeld();
            NeuerBall();
            pauseToolStripMenuItem.Enabled = false;

            spielPause = true;
            aktuelleSpielZeit = Convert.ToInt32(timerSpiel.Interval) / 1000;

            schrift = new Font("Arial", 12, FontStyle.Bold);
            //alle drei Timer sind zunächst angehalten
            timerBall.Enabled = false;
            timerSpiel.Enabled = false;
            timerSekunde.Enabled = false;
        }

        private void sehrEinfachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //das Intervall fuer den Ball setzen
            timerBall.Interval = 150;
            //die Einstellungen setzen
            SetzeEinstellungen(100, 1, -15, 2);
            //die Markierungen
            
            sehrEinfachToolStripMenuItem.Checked = true;
            einfachToolStripMenuItem.Checked = false;
            mittelToolStripMenuItem.Checked = false;
            schwerToolStripMenuItem.Checked = false;
            sehrSchwerToolStripMenuItem.Checked = false;
        }

        private void einfachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //das Intervall fuer den Ball setzen
            timerBall.Interval = 100;
            //die Einstellungen setzen
            SetzeEinstellungen(50, 2, -8, 5);
            //die Markierungen

            sehrEinfachToolStripMenuItem.Checked = false;
            einfachToolStripMenuItem.Checked = true;
            mittelToolStripMenuItem.Checked = false;
            schwerToolStripMenuItem.Checked = false;
            sehrSchwerToolStripMenuItem.Checked = false;
        }

        private void mittelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //das Intervall fuer den Ball setzen
            timerBall.Interval = 75;
            //die Einstellungen setzen
            SetzeEinstellungen(50, 4, -5, 15);
            //die Markierungen

            sehrEinfachToolStripMenuItem.Checked = false;
            einfachToolStripMenuItem.Checked = false;
            mittelToolStripMenuItem.Checked = true;
            schwerToolStripMenuItem.Checked = false;
            sehrSchwerToolStripMenuItem.Checked = false;
        }
        
        private void schwerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //das Intervall fuer den Ball setzen
            timerBall.Interval = 45;
            //die Einstellungen setzen
            SetzeEinstellungen(50, 8, -3, 25);
            //die Markierungen

            sehrEinfachToolStripMenuItem.Checked = false;
            einfachToolStripMenuItem.Checked = false;
            mittelToolStripMenuItem.Checked = false;
            schwerToolStripMenuItem.Checked = true;
            sehrSchwerToolStripMenuItem.Checked = false;
        }

        private void sehrSchwerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //das Intervall fuer den Ball setzen
            timerBall.Interval = 15;
            //die Einstellungen setzen
            SetzeEinstellungen(50, 10, -5, 40);
            //die Markierungen
            schwerToolStripMenuItem.Checked = false;
            sehrEinfachToolStripMenuItem.Checked = false;
            einfachToolStripMenuItem.Checked = false;
            mittelToolStripMenuItem.Checked = false;
            sehrSchwerToolStripMenuItem.Checked = true;
        }

        private void spielfeldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point neueGroesse = new Point(this.Width, this.Height);
            EinstellungenDialog neueWerte = new EinstellungenDialog();

            //
            //Aufgabe 1.
            //
            //wir geben die aktuelle Größe ein und aktivieren das entsprechende Optionsfeld
            neueWerte.SetRadioButton(neueGroesse).Checked = true;

            //
            //Aufgabe 2.
            //
            //wir geben die aktuelle farbe des Spiels zur Vorschau an
            neueWerte.SetFarben(spielFeld.BackColor, rahmenFarbe);

            //wenn der Dialog ueber die "OK"-Schaltflaeche beendet wird
            if (neueWerte.ShowDialog() == DialogResult.OK)
            {
                //
                //Aufgabe 2.
                //
                //die Farben setzen
                spielFeld.BackColor = neueWerte.GetFarbeSpielfeld();
                rahmenFarbe = neueWerte.GetFarbeRahmen();

                //die neue Groesse holen
                neueGroesse = neueWerte.LiefereWert();
                //den Dialog wieder schliessen
                neueWerte.Close();

                this.Width = neueGroesse.X;
                this.Height = neueGroesse.Y;
                //neu ausrichten
                this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
                this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
                //die Zeichenflaeche neu beschaffen
                zeichenflaeche = spielFeld.CreateGraphics();
                //das Spielfeld neu setzen
                SetzeSpielfeld();

                //Spielfeld loeschen
                zeichenflaeche.Clear(spielFeld.BackColor);
                //einen neuen Ball und einen neuen schlaeger zeichnen
                NeuerBall();
                //das Spielfeld neu zeichnen
                ZeichneSpielfeld();
                //Refresh();
            }
        }

        private void bestenlisteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //zur Unterscheidung zwischen einem laufenden und einem nicht gestarteten Spiel
            bool weiter = false;
            //läuft ein Spiel? dann zuerst das Spiel pausieren
            if (spielPause == false)
            {
                pauseToolStripMenuItem_Click(sender, e);
                weiter = true;
            }
            //Ball und Schläger verstecken
            ball.Hide();
            schlaeger.Hide();
            //die Liste ausgeben
            spielPunkte.ListeAusgeben(zeichenflaeche, spielfeldGroesse);
            //fünf Sekunden warten
            System.Threading.Thread.Sleep(5000);
            //die Zeichenfläche löschen
            zeichenflaeche.Clear(spielFeld.BackColor);
            //Ball und Schläger wieder anzeigen
            ball.Show();
            schlaeger.Show();
            //das Spiel wieder fortsetzen, wenn wir es angehalten haben
            if (weiter == true)
                pauseToolStripMenuItem_Click(sender, e);
        }

        //setzt die Einstellungen für einen neuen Ball und einen neuen Schläger
        private void NeuerBall()
        {
            //die Größe des Balls setzen
            ball.Width = 10;
            ball.Height = 10;

            //die Größe des Schlägers setzen
            schlaeger.Width = spielfeldLinienBreite;
            schlaeger.Height = schlaegerGroesse;
            //
            //Aufgabe 2.
            //
            //der Schlaeger und das Ball auf Farbe des Spielfelds setzen
            ball.BackColor = rahmenFarbe;
            schlaeger.BackColor = rahmenFarbe;
            //den Schläger positionieren links an den Rand
            schlaeger.Left = 2;
            //ungefähr in die Mitte
            ZeichneSchlaeger((spielfeldMaxY / 2) - (schlaegerGroesse / 2));
            //der Ball kommt vor den Schläger ungefähr in die Mitte
            ZeichneBall(new Point(spielfeldMinX, spielfeldMaxY / 2));
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
