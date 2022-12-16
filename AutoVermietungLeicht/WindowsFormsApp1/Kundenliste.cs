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
    public partial class Kundenliste : Form
    {
        Color alteFarbe;

        public Kundenliste()
        {
            InitializeComponent();
        }

        private void kundeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.kundeBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.autoDataSet);
            }
            catch
            {
                MessageBox.Show("Beim Specichern ist ein Fehler augetreten! \nBitte ueberpruefen Sie Ihre Eingaben.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Kundenliste_Load(object sender, EventArgs e)
        {
            this.kundeTableAdapter.Fill(this.autoDataSet.Kunde);

        }

        private void kundeDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            bool fehlerKeinEintrag = false;

            if ((e.ColumnIndex > 0) && (e.ColumnIndex < 6))
            {
                //falls der Eintrag leer ist
                if (e.FormattedValue.ToString() == string.Empty)
                {
                    //eine Meldung anzeigen
                    MessageBox.Show("Sie müssen einen Wert fuer " + kundeDataGridView.Columns[e.ColumnIndex].HeaderText + " eingeben.");
                    //Fehlertext setzen
                    kundeDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "Die Zelle darf nicht leer sein!";
                    //Aktion abbrechen
                    e.Cancel = true;
                    //falls ein Eintrag leer ist, setzen wir unsere bool auf true, weil die Pruefung fuer die PLZ nicht mehr nötig ist
                    fehlerKeinEintrag = true;
                }
            }

            //die Pruefung fuer der Preis
            if ((e.ColumnIndex == 3) && (fehlerKeinEintrag == false))
            {
                if (Int32.TryParse(e.FormattedValue.ToString(), out int _) == false)
                {
                    MessageBox.Show("Das format der PLZ ist ungueltig!");
                    e.Cancel = true;
                }
            }
        }

        private void kundeDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (kundeDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText != string.Empty)
                kundeDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = string.Empty;
        }

        private void kundeDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Beim Specichern ist ein Fehler augetreten! \nBitte ueberpruefen Sie Ihre Eingaben.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void kundeDataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex != -1) && (e.RowIndex != -1))
            {
                DataGridViewCell zelle = kundeDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                alteFarbe = zelle.Style.BackColor;
                zelle.Style.BackColor = Color.LightBlue;
            }
        }

        private void kundeDataGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex != -1) && (e.RowIndex != -1))
            {
                DataGridViewCell zelle = kundeDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                zelle.Style.BackColor = alteFarbe;
            }
        }
    }
}
