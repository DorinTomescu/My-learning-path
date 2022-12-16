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
    public partial class Fahrzeugeinzel : Form
    {
        public Fahrzeugeinzel()
        {
            InitializeComponent();
        }

        private void fahrzeugBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fahrzeugBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autoDataSet);

        }

        private void Fahrzeugeinzel_Load(object sender, EventArgs e)
        {
            this.fahrzeugTableAdapter.Fill(this.autoDataSet.Fahrzeug);
        }

    }
}
