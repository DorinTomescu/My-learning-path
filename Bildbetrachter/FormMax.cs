using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bildbetrachter
{
    public partial class FormMax : Form
    {
        public FormMax()
        {
            InitializeComponent();
        }

        public void BildLaden(string bildName)
        {
            pictureBoxFormMax.Load(bildName);            
        }

    }
}
