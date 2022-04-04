using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pong_Spiel
{
    public partial class EinstellungenDialog : Form
    {
        public EinstellungenDialog()
        {
            InitializeComponent();

        }

        private void buttonAbbrechen_Click(object sender, EventArgs e)
        {
            Close();
        }

        //die Methode liefert den ausgewählten Wert
        public Point LiefereWert()
        {
            Point rueckgabe = new Point(0, 0);

            if (radioButton320.Checked == true)
            {
                rueckgabe = new Point(320, 320);
            }
            if (radioButton640.Checked == true)
            {
                rueckgabe = new Point(640, 480);
            }
            if (radioButton1024.Checked == true)
            {
                rueckgabe = new Point(1024, 768);
            }
            if (radioButtonMaximal.Checked == true)
            {
                rueckgabe = new Point(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            }

            return rueckgabe;
        }

        //
        //Aufgabe 1.
        //
        //die Methode liefert den entsprechende Optionsfeld
        public RadioButton SetRadioButton(Point groesse)
        {
            RadioButton radioButon = new RadioButton();

            if (groesse == new Point(320, 320))
            {
                radioButon = radioButton320;
            }
            else if (groesse == new Point(640, 480))
            {
                radioButon = radioButton640;
            }
            else if (groesse == new Point(1024, 768))
            {
                radioButon = radioButton1024;
            }
            else if (groesse == new Point(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height))
            {
                radioButon = radioButtonMaximal;
            }
            return radioButon;
        }

        //
        //Aufgabe 2.
        //
        //die Methode aktualisiert unsere Spielvorschau
        public void SetFarben(Color spielFeld, Color rahmen)
        {
            panelSpielfeldVorschau.BackColor = spielFeld;

            panelRahmenVorschau.BackColor = rahmen;
            panelSchlaegerVorschau.BackColor = panelRahmenVorschau.BackColor;
            panelBallVorschau.BackColor = panelRahmenVorschau.BackColor;
        }

        //
        //Aufgabe 2.
        //
        //die Methoden liefern die benötigte Farben
        public Color GetFarbeSpielfeld()
        {
            return panelSpielfeldVorschau.BackColor;
        }

        public Color GetFarbeRahmen()
        {
            return panelRahmenVorschau.BackColor;
        }

        //
        //Aufgabe 2.
        //
        //die Methode setzt die Farbe fuer die Rahmen, der Schlaeger und das Ball
        private void buttonRahmenFarbe_Click(object sender, EventArgs e)
        {
            //wir stellen die hervorgehobene Farbe im Farbfenster auf die Farbe des Rahmens ein
            colorEinstellungenDialog.Color = panelRahmenVorschau.BackColor;

            if (colorEinstellungenDialog.ShowDialog() == DialogResult.OK)
            {
                panelRahmenVorschau.BackColor = colorEinstellungenDialog.Color;
                panelSchlaegerVorschau.BackColor = panelRahmenVorschau.BackColor;
                panelBallVorschau.BackColor = panelRahmenVorschau.BackColor;
            }
        }

        //
        //Aufgabe 2.
        //
        //die Methode setzt die Farbe fuer das Spielfeld
        private void buttonSpielfeldFarbe_Click(object sender, EventArgs e)
        {
            //wir stellen die hervorgehobene Farbe im Farbfenster auf die Farbe des Spielfeldes ein
            colorEinstellungenDialog.Color = panelSpielfeldVorschau.BackColor;

            if (colorEinstellungenDialog.ShowDialog() == DialogResult.OK)
            {
                panelSpielfeldVorschau.BackColor = colorEinstellungenDialog.Color;
            }
        }

    }
}
