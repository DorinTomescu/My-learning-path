using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner_lite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonBeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //method to assure that the user input is a number.
        private float Cnvt(TextBox textbox)
        {
            float zahl;
            try
            {
                zahl = Convert.ToSingle(textbox.Text);
            }
            catch (FormatException)
            {                
                MessageBox.Show($"Sie haben: '{textbox.Text}' eingegeben und es ist ungültig.", "Konvertierungsfehler");
                textbox.Select();
                throw new Exception("Hier enden wir die berechnung");
            }
            return zahl;
        }
        private void buttonBerechnen_Click(object sender, EventArgs e)
        {
            float zahl1, zahl2, ergebnis = 0;
            bool divDurchNull = false;

            try
            {
                zahl1 = Cnvt(textBoxZahl1);
                zahl2 = Cnvt(textBoxZahl2);

                if (comboBoxOperationen.SelectedIndex == 0)
                {
                    ergebnis = zahl1 + zahl2;
                }
                if (comboBoxOperationen.SelectedIndex == 1)
                    ergebnis = zahl1 - zahl2;
                if (comboBoxOperationen.SelectedIndex == 3)
                    ergebnis = zahl1 * zahl2;
                if (comboBoxOperationen.SelectedIndex == 2)
                {
                    if (zahl2 == 0)
                        divDurchNull = true;
                    else
                        ergebnis = zahl1 / zahl2;
                }

                if (divDurchNull == true)
                    labelAnzeige.Text = "Nicht definiert!";
                else
                    labelAnzeige.Text = Convert.ToString(ergebnis);
            }
            catch
            {
                labelAnzeige.Text = "Geben Sie bitte ein Zahl ein.";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxOperationen.SelectedIndex = 0;
        }
    }
}
