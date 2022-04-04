using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pong_Spiel
{
    public partial class NameDialog : Form
    {
        public NameDialog()
        {
            InitializeComponent();
        }

        public string LiefereName()
        {
            return textBoxNameDialogNamen.Text;
        }

    }
}
