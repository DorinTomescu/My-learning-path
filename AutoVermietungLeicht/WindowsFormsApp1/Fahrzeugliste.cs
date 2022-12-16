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
    public partial class Fahrzeugliste : Form
    {
        Color alteFarbe;

        public Fahrzeugliste()
        {
            InitializeComponent();
        }

        private void kundeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kundeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autoDataSet);

        }

        private void Fahrzeugliste_Load(object sender, EventArgs e)
        {
            this.fahrzeugTableAdapter.Fill(this.autoDataSet.Fahrzeug);

            this.kundeTableAdapter.Fill(this.autoDataSet.Kunde);
        }

        private void fahrzeugDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            bool fehlerKeinEintrag = false;

            if ((e.ColumnIndex > 0) && (e.ColumnIndex < 6))
            {
                //falls der Eintrag leer ist
                if (e.FormattedValue.ToString() == string.Empty)
                {
                    //eine Meldung anzeigen
                    MessageBox.Show("Sie müssen einen Wert fuer " + fahrzeugDataGridView.Columns[e.ColumnIndex].HeaderText + " eingeben.");
                    //Fehlertext setzen
                    fahrzeugDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "Die Zelle darf nicht leer sein!";
                    //Aktion abbrechen
                    e.Cancel = true;
                    //falls ein Eintrag leer ist, setzen wir unsere bool auf true, weil die Pruefung fuer die PLZ nicht mehr nötig ist
                    fehlerKeinEintrag = true;
                }
            }

            //die Pruefung fuer die PLZ
            if ((e.ColumnIndex == 3) && (fehlerKeinEintrag == false))
            {
                if (Int32.TryParse(e.FormattedValue.ToString(), out int _) == false)
                {
                    MessageBox.Show("Das format der Preis ist ungueltig!");
                    e.Cancel = true;
                }
            }
        }

        private void fahrzeugDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (fahrzeugDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText != string.Empty)
                fahrzeugDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = string.Empty;
        }

        private void fahrzeugDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Beim Specichern ist ein Fehler augetreten! \nBitte ueberpruefen Sie Ihre Eingaben.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void fahrzeugDataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex != -1) && (e.RowIndex != -1))
            {
                DataGridViewCell zelle = fahrzeugDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                alteFarbe = zelle.Style.BackColor;
                zelle.Style.BackColor = Color.LightBlue;
            }
        }

        private void fahrzeugDataGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex != -1) && (e.RowIndex != -1))
            {
                DataGridViewCell zelle = fahrzeugDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                zelle.Style.BackColor = alteFarbe;
            }
        }

    }
}
