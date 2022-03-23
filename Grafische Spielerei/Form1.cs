using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafische_Spielerei
{
    public partial class Form1 : Form
    {
        Graphics zeichnenflaeche;
        Color linienfarbe;
        Color hintergrundfarbe;

        System.Drawing.Drawing2D.DashStyle[] linienstil =
        {
            System.Drawing.Drawing2D.DashStyle.Solid,
            System.Drawing.Drawing2D.DashStyle.Dash,
            System.Drawing.Drawing2D.DashStyle.DashDot,
            System.Drawing.Drawing2D.DashStyle.DashDotDot,
            System.Drawing.Drawing2D.DashStyle.Dot
        };

        System.Drawing.Drawing2D.HatchStyle[] fuellstil =
        {
            System.Drawing.Drawing2D.HatchStyle.BackwardDiagonal,
            System.Drawing.Drawing2D.HatchStyle.Cross,
            System.Drawing.Drawing2D.HatchStyle.DottedGrid,
            System.Drawing.Drawing2D.HatchStyle.ForwardDiagonal,
            System.Drawing.Drawing2D.HatchStyle.Sphere,
            System.Drawing.Drawing2D.HatchStyle.Vertical,
            System.Drawing.Drawing2D.HatchStyle.Wave,
            System.Drawing.Drawing2D.HatchStyle.ZigZag
        };
                
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // die farbe des Linies auf schwarz setzen
            linienfarbe = Color.Black;

            // die farbe des Hintergrunds auf schwarz setzen
            hintergrundfarbe = Color.Black;

            // die farbe des Vorschauspanel auf linienfarbe setzen
            panelLinieFarbeVorschau.BackColor = linienfarbe;

            // die farbe des Vorschauspanel auf HintergrundFarbe setzen
            panelHintergrundFarbeVorschau.BackColor = hintergrundfarbe;

            zeichnenflaeche = panel1.CreateGraphics();

            //Linienstilelemente erstellen
            foreach (System.Drawing.Drawing2D.DashStyle element in linienstil)
            {
                listBoxLinieStil.Items.Add("");
            }

            //Elemente für das Muster erstellen
            foreach (System.Drawing.Drawing2D.HatchStyle element in fuellstil)
            {
                listBoxHintergrundMuster.Items.Add("");
            }
            
        }

        private void buttonLoeschen_Click(object sender, EventArgs e)
        {
            zeichnenflaeche.Clear(panel1.BackColor);
        }

        private void buttonBeenden_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            //lokale Variable fuer die Grosse
            int groesse = 0;

            //lokale Variable fuer die dicke des stiftes
            int stiftGroesse = Convert.ToInt32(numericUpDownLinieStaerke.Value);

            //Stift mit der ausgewählten Farbe und Größe erzeugen
            Pen stift = new Pen(linienfarbe, stiftGroesse);

            //Pinsel in der ausgewählten Farbe erzeugen
            SolidBrush pinsel = new SolidBrush(hintergrundfarbe);
            
            //switch-case für die Größe der Figur ermitteln
            switch (trackBar1.Value)
            {
                case 1:
                    groesse = 125;
                    break;
                case 2:
                    groesse = 100;
                    break;
                case 3:
                    groesse = 75;
                    break;
            }

            //den Linienstil ermitteln
            if (listBoxLinieStil.SelectedIndex >= 0)
            {
                stift.DashStyle = linienstil[listBoxLinieStil.SelectedIndex];
            }

            //Figur ermitteln
            //für Kreis und Rechteck auch die Füllung überprüfen
            if (radioButtonFigurKreis.Checked == true)
            {
                if (radioButtonHintergrundOhne.Checked == true)
                {
                    zeichnenflaeche.DrawEllipse(stift,
                        panel1.ClientRectangle.Left + groesse,
                        panel1.ClientRectangle.Top + groesse,
                        panel1.ClientRectangle.Width - (groesse * 2),
                        panel1.ClientRectangle.Height - (groesse * 2));
                }
                if (radioButtonHintergrundFarbe.Checked == true)
                {
                    zeichnenflaeche.FillEllipse(pinsel,
                        panel1.ClientRectangle.Left + groesse,
                        panel1.ClientRectangle.Top + groesse,
                        panel1.ClientRectangle.Width - (groesse * 2),
                        panel1.ClientRectangle.Height - (groesse * 2));
                }
                //soll mit Muster gezeichnet werden und ist ein Muster ausgewählt_
                if (radioButtonHintergrundMuster.Checked == true && listBoxHintergrundMuster.SelectedIndex >= 0)
                {
                    //einen neuen Pinsel für das Muster erzeugen
                    //die Vordergrundfarbe kommt vom Stift, der Hintergrund ist immer weiß
                    System.Drawing.Drawing2D.HatchBrush musterPinsel = new System.Drawing.Drawing2D.HatchBrush(
                        fuellstil[listBoxHintergrundMuster.SelectedIndex], stift.Color, Color.White);
                    zeichnenflaeche.FillEllipse(musterPinsel,
                        panel1.ClientRectangle.Left + groesse,
                        panel1.ClientRectangle.Top + groesse,
                        panel1.ClientRectangle.Width - (groesse * 2),
                        panel1.ClientRectangle.Height - (groesse * 2));
                }
            }
            if (radioButtonFigurRechteck.Checked == true)
            {
                if (radioButtonHintergrundOhne.Checked == true)
                {
                    zeichnenflaeche.DrawRectangle(stift,
                        panel1.ClientRectangle.Left + groesse,
                        panel1.ClientRectangle.Top + groesse,
                        panel1.ClientRectangle.Width - (groesse * 2),
                        panel1.ClientRectangle.Height - (groesse * 2));
                }
                if (radioButtonHintergrundFarbe.Checked == true)
                {
                    zeichnenflaeche.FillRectangle(pinsel,
                        panel1.ClientRectangle.Left + groesse,
                        panel1.ClientRectangle.Top + groesse,
                        panel1.ClientRectangle.Width - (groesse * 2),
                        panel1.ClientRectangle.Height - (groesse * 2));
                }
                //soll mit Muster gezeichnet werden und ist ein Muster ausgewählt?
                if (radioButtonHintergrundMuster.Checked == true && listBoxHintergrundMuster.SelectedIndex >= 0)
                {
                    //einen neuen Pinsel für das Muster erzeugen
                    //die Vordergrundfarbe kommt vom Stift, der Hintergrund ist immer weiß
                    System.Drawing.Drawing2D.HatchBrush musterPinsel = new System.Drawing.Drawing2D.HatchBrush(
                        fuellstil[listBoxHintergrundMuster.SelectedIndex], stift.Color, Color.White);
                    zeichnenflaeche.FillRectangle(musterPinsel,
                        panel1.ClientRectangle.Left + groesse,
                        panel1.ClientRectangle.Top + groesse,
                        panel1.ClientRectangle.Width - (groesse * 2),
                        panel1.ClientRectangle.Height - (groesse * 2));
                }
            }
            if (radioButtonFigurLinie.Checked == true)
            {
                zeichnenflaeche.DrawLine(stift,
                    panel1.ClientRectangle.Left + groesse,
                    panel1.ClientRectangle.Height / 2,
                    panel1.ClientRectangle.Right - groesse,
                    panel1.ClientRectangle.Height / 2);
            }
            
        }

        private void buttonSpielerei_Click(object sender, EventArgs e)
        {
            //Variable fuer die Wiederholungen
            int wiederholung = Convert.ToInt32(numericUpDownAnimWiederholung.Value);

            //Variable fuer die Geschwindigkeit
            int geschwindigkeit = Convert.ToInt32(numericUpDownAnimGeschwindigkeit.Value);

            //groesse des Zeichnens
            int groesse = 0;

            int stiftWidth = Convert.ToInt32(numericUpDownLinieStaerke.Value);
            Pen stift = new Pen(linienfarbe, stiftWidth);

            switch (trackBar1.Value)
            {
                case 1:
                    groesse = 135;
                    break;
                case 2:
                    groesse = 95;
                    break;
                case 3:
                    groesse = 55;
                    break;
            }

            //den Linienstil ermitteln
            if (listBoxLinieStil.SelectedIndex >= 0)
            {
                stift.DashStyle = linienstil[listBoxLinieStil.SelectedIndex];
            }

            //Wir prüfen, welche Art von Element wir animieren müssen
            //zuerst, ob ein Kreis ausgewählt ist
            if (radioButtonFigurKreis.Checked == true)
            {
                if (radioButtonHintergrundOhne.Checked == true)
                {
                    DrawElipseSpiel(stift, groesse, geschwindigkeit, wiederholung);
                }
            }

            //dann, ob ein Recheck
            if (radioButtonFigurRechteck.Checked == true)
            {
                if (radioButtonHintergrundOhne.Checked == true)
                {
                    DrawRectangleSpiel(stift, groesse, geschwindigkeit, wiederholung);
                }                
            }

            //und am ende, ob eine Linie
            if (radioButtonFigurLinie.Checked == true)
            {
                DrawLinieSpiel(stift, groesse, geschwindigkeit, wiederholung);
            }

        }

        private void buttonLinieFarbe_Click(object sender, EventArgs e)
        {
            //den Dialog zur Farbeauswahl anzeigen
            if (colorDialogFarbeLinie.ShowDialog() == DialogResult.OK)
            {
                //die Hintergrundfarbe für das Panel auf die ausgewählte Farbe setzen
                panelLinieFarbeVorschau.BackColor = colorDialogFarbeLinie.Color;
                //die Linienfarbe auf die ausgewählte Farbe setzen
                linienfarbe = colorDialogFarbeLinie.Color;
            }
        }

        private void buttonHintergrundFarbe_Click(object sender, EventArgs e)
        {
            //den Dialog zur Farbauswahl anzeigen
            if (colorDialogFarbeLinie.ShowDialog() == DialogResult.OK)
            {
                //die Hintergrundfarbe für das Panel auf die ausgewählte Farbe setzen
                panelHintergrundFarbeVorschau.BackColor = colorDialogFarbeLinie.Color;
                //die Hintergrundfarbe auf die ausgewählte Farbe setzen
                hintergrundfarbe = colorDialogFarbeLinie.Color;
                //die Auswahl Farbe aktivieren
                radioButtonHintergrundFarbe.Checked = true;
            }
        }

        private void listBoxLinieStil_DrawItem(object sender, DrawItemEventArgs e)
        {
            //die Mitte des Boxes für LinieMusterBox berechnen
            int y = (e.Bounds.Top + e.Bounds.Bottom) / 2; ;

            //lokaler Stift erzeugen
            Pen boxStift = new Pen(Color.Black);

            //den Hintergrund zeichnen
            e.DrawBackground();

            //die Linie zeichnen
            boxStift.DashStyle = linienstil[e.Index];
            e.Graphics.DrawLine(boxStift, e.Bounds.Left + 1, y, e.Bounds.Right - 1, y);
           
        }

        private void listBoxHintergrundMuster_DrawItem(object sender, DrawItemEventArgs e)
        {
            //lokaler Pinsel für das Muster
            System.Drawing.Drawing2D.HatchBrush boxPinsel = new System.Drawing.Drawing2D.HatchBrush(fuellstil[e.Index], Color.Black, Color.White);

            //den Hintergrund zeichnen
            e.DrawBackground();

            //Die Mustern zeichnen
            e.Graphics.FillRectangle(boxPinsel, e.Bounds.Left + 1, e.Bounds.Top + 1, e.Bounds.Width - 1, e.Bounds.Height - 1);
        }

        private void DrawLinieSpiel(Pen stift, int groesse, int geschwindigkeit, int wiederholung)
        {
            //die aktuelle Millisekunden, die unser Programm warten muss
            //bevor er neue Elemente in unsere Animation zeichnet
            int timer = 1000 / geschwindigkeit;

            //die Punkte von die Linie speichern 
            Point punkt1 = new Point(panel1.ClientRectangle.Left + groesse,
                                        panel1.ClientRectangle.Height / 2);

            Point punkt2 = new Point(panel1.ClientRectangle.Right - groesse,
                                        panel1.ClientRectangle.Height / 2);

            //die erste Linie zeichnen
            zeichnenflaeche.DrawLine(stift, punkt1, punkt2);

            //Ich habe die for-Schleife verwendet, um die Animation zu erstellen,
            //abhängig von der Wahl des Benutzers, mehrmals ausgeführt zu werden
            for (int i = 0; i < wiederholung; i++)
            {
                //zwei Variablen von Typ Point erstellen damit wir unsere
                //Startposition behalten 
                Point p1 = punkt1;
                Point p2 = punkt2;

                //die linie nach unten bewegen
                while (p1.Y < panel1.ClientRectangle.Height)
                {
                    // abhängig von der vom Benutzer gewählten Geschwindigkeit
                    // die Sleep methode wird ausgefuehrt und der Programm wartet
                    // bevor er weiter geht. Wir benutzen die Methode an diese Stelle
                    // damit wir auch die erst gezeichnete Linie sehen koennen
                    Thread.Sleep(timer);

                    //die vorher gezeichnete Element loeschen
                    //ich habe Color.White als argument benutzt um sicher zu gehen
                    //das die Zeichnenflaeche Weiß bleibt
                    zeichnenflaeche.Clear(Color.White);

                    //die Y-Koordinate des Punktes ist der Abstand des Punktes
                    //von der Oberkante. Wir verschieben die Linie nach unten,
                    //indem wir die beiden Punkte nach unten verschieben
                    p1.Y += 1;
                    p2.Y += 1;

                    //die linie zwischen die Punkte zeichnen
                    zeichnenflaeche.DrawLine(stift, p1, p2);
                }

                //die linie nach oben bewegen
                while (p1.Y > 0)
                {
                    Thread.Sleep(timer);

                    zeichnenflaeche.Clear(Color.White);

                    p1.Y -= 1;
                    p2.Y -= 1;

                    zeichnenflaeche.DrawLine(stift, p1, p2);
                }

                //um die linie in die startposition zu bringen,
                //vergleichen wir die aktuelle Y-Koordinate des Linies
                //mit die Y-Koordinate von der erst gezeichnete Linie
                while (p1.Y < punkt1.Y)
                {
                    Thread.Sleep(timer);

                    zeichnenflaeche.Clear(Color.White);

                    p1.Y += 1;
                    p2.Y += 1;

                    zeichnenflaeche.DrawLine(stift, p1, p2);
                }

            }

        }

        private void DrawRectangleSpiel(Pen stift, int  groesse, int geschwindigkeit, int wiederholung)
        {
            int timer = 1000 / geschwindigkeit;

            //die Koordinate und groesse des Rechtecks individuell speichern
            int x = panel1.ClientRectangle.Left + groesse;
            int y = panel1.ClientRectangle.Top + groesse;
            int width = panel1.ClientRectangle.Width - (groesse * 2);
            int height = panel1.ClientRectangle.Height - (groesse * 2);

            zeichnenflaeche.Clear(Color.White);

            //wir speichern das Rechteck in einer Rectangle-Variablen
            Rectangle rectangle = new Rectangle(x, y, width, height);

            //das Rechteck zeichnen
            zeichnenflaeche.DrawRectangle(stift, rectangle);

            for (int i = 0; i < wiederholung; i++)
            {
                //wir vergleichen das gezeichnete Rechteck mit unsere zeichnen
                //flaeche. Soweit unser Rechteck kleiner ist, vergroeßern wir es
                //von der Mitte nach außen.
                while (x > panel1.ClientRectangle.Left &&
                    y > panel1.ClientRectangle.Top &&
                    width < panel1.ClientRectangle.Width &&
                    height < panel1.ClientRectangle.Height)
                {
                    Thread.Sleep(timer);

                    //die X und Y-Koordinate werden mit eins reduziert damit das Rechteck
                    //mit einem pixel nach Links und Oben sich bewegt.
                    x -= 1;
                    y -= 1;
                    //die Breite und Hoehe erhoehen wir um zwei damit unser Rechteck sich
                    //auch nach Rechts und Unten sich vergroeßert aber das Zentrum bleibt gleich 
                    width += 2;
                    height += 2;
                    
                    //zuerst stellen wir sicher das alle die Elemente werden geloescht
                    zeichnenflaeche.Clear(Color.White);

                    //die Rectangle zeichnen
                    zeichnenflaeche.DrawRectangle(stift, x, y, width, height);
                }

                //wir vergleichen hier das gezeichnete Rechteck mit unsere geschpeicherten.
                //soweit unser Rechteck größer ist, verkleinern wir es nach innen
                while (x < rectangle.Left &&
                    y < rectangle.Top &&
                    width > rectangle.Width &&
                    height > rectangle.Height)
                {
                    Thread.Sleep(timer);

                    x += 1;
                    y += 1;
                    width -= 2;
                    height -= 2;

                    zeichnenflaeche.Clear(Color.White);

                    zeichnenflaeche.DrawRectangle(stift, x, y, width, height);
                }
            }

        }

        private void DrawElipseSpiel(Pen stift, int groesse, int geschwindigkeit, int wiederholung)
        {
            int timer = 1000 / geschwindigkeit;

            //die Punkte fuer Rechteck speichern weil der Kreis in der Rechteck gezeichnet wird
            int x = panel1.ClientRectangle.Left + groesse;
            int y = panel1.ClientRectangle.Top + groesse;
            int width = panel1.ClientRectangle.Width - (groesse * 2);
            int height = panel1.ClientRectangle.Height - (groesse * 2);

            zeichnenflaeche.Clear(Color.White);

            //die erste rectangle erstellen
            Rectangle rectangle = new Rectangle(x, y, width, height);

            //die Rectangle zeichnen
            zeichnenflaeche.DrawEllipse(stift, rectangle);

            for (int i = 0; i < wiederholung; i++)
            {
                //die lokale Rectangle erstellen damit wir unsere
                //stelle fuer die Rectangle behalten                

                while (x > panel1.ClientRectangle.Left &&
                    y > panel1.ClientRectangle.Top &&
                    width < panel1.ClientRectangle.Width &&
                    height < panel1.ClientRectangle.Height)
                {
                    Thread.Sleep(timer);

                    x -= 1;
                    y -= 1;
                    width += 2;
                    height += 2;

                    //zuerst stellen wir sicher, dass alle die Elemente werden geloescht
                    zeichnenflaeche.Clear(Color.White);

                    //die Rectangle zeichnen
                    zeichnenflaeche.DrawEllipse(stift, x, y, width, height);
                }

                while (x < rectangle.Left &&
                    y < rectangle.Top &&
                    width > rectangle.Width &&
                    height > rectangle.Height)
                {
                    Thread.Sleep(timer);

                    x += 1;
                    y += 1;
                    width -= 2;
                    height -= 2;

                    zeichnenflaeche.Clear(Color.White);

                    zeichnenflaeche.DrawEllipse(stift, x, y, width, height);
                }
            }
        }

    }
} 
