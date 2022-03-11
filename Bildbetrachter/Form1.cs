using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bildbetrachter
{
    public partial class Form1 : Form
    {
        private FormMax fensterBilderschau;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBeenden_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAnzeigen_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty)
            {
                if (System.IO.File.Exists(textBox1.Text))
                {
                    pictureBox1.Load(textBox1.Text);

                    if (checkBoxNeuesFenster.Checked == true)
                    {
                        FormMax neuesFormular = new FormMax();
                        neuesFormular.BildLaden(textBox1.Text);
                        neuesFormular.Text += $"Große Darstellung – {textBox1.Text}";
                        neuesFormular.ShowDialog();                        
                    }
                }
                else
                    MessageBox.Show("Die Datei existiert nicht!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBoxOptimaleGrosse_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOptimaleGrosse.Checked == true)
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void buttonOffnen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();         
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            textBox1.Text = openFileDialog1.FileName;
            buttonAnzeigen_Click(sender, e);
            pictureBox1.Load(openFileDialog1.FileName);
        }

        private void buttonBeenden1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAuswaehlen_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        private void buttonStarten_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Sie muessen erst Dateien auswaehlen!", "Fehler", MessageBoxButtons.OK);
                return;
            }

            if (listBox1.SelectedIndex == -1)
                listBox1.SelectedIndex = 0;

            fensterBilderschau = new FormMax();
            fensterBilderschau.ControlBox = false;
            fensterBilderschau.Show();
            fensterBilderschau.Text = $"Bilderschau – Bild {listBox1.SelectedIndex + 1} von {listBox1.Items.Count} {listBox1.SelectedItem.ToString()}";
            fensterBilderschau.BildLaden(listBox1.SelectedItem.ToString());

            timer1.Interval = Convert.ToInt32(numericUpDown1.Value) * 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < listBox1.Items.Count - 1)
            {
                listBox1.SelectedIndex++;
                fensterBilderschau.Text = $"Bilderschau – Bild {listBox1.SelectedIndex + 1} von {listBox1.Items.Count} {listBox1.SelectedItem.ToString()}";
                fensterBilderschau.BildLaden(listBox1.SelectedItem.ToString());
                System.Media.SystemSounds.Asterisk.Play();
            }
            else
            {
                listBox1.SelectedIndex = -1;
                timer1.Stop();
                fensterBilderschau.Close();
            }
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            string[] dateien = openFileDialog2.FileNames;
            if (listBox1.Items.Count != 0)
                listBox1.Items.Clear();
            foreach (string datei in dateien)
                listBox1.Items.Add(datei);
        }

        private void tabPageEinzel_Enter(object sender, EventArgs e)
        {
            AcceptButton = buttonAnzeigen;
        }

        private void tabPageSchau_Enter(object sender, EventArgs e)
        {
            AcceptButton = buttonStarten;
        }
    }
}
