using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Kundenliste kunden = new Kundenliste();
        Kundeneinzel kundeneinzel = new Kundeneinzel();

        Fahrzeugliste fahrzeug = new Fahrzeugliste();
        Fahrzeugeinzel fahrzeugeinzel = new Fahrzeugeinzel();
        FahrzeugListenanzeige fahrzeugListenanzeige = new FahrzeugListenanzeige();

        public Form1()
        {
            InitializeComponent();
        }

        private void Listenansicht_Click(object sender, EventArgs e)
        {
            kunden.ShowDialog();
        }

        private void Einzelansicht_Click(object sender, EventArgs e)
        {
            kundeneinzel.ShowDialog();
        }

        private void FzListenAnsicht_Click(object sender, EventArgs e)
        {
            fahrzeug.ShowDialog();
        }

        private void FzEinzelansicht_Click(object sender, EventArgs e)
        {
            fahrzeugeinzel.ShowDialog();
        }

        private void Fahrzeugliste_Click(object sender, EventArgs e)
        {
            fahrzeugListenanzeige.ShowDialog();
        }
    }
}
