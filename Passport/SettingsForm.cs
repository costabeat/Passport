using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Passport
{
    public partial class SettingsForm : Form
    {
        public string passKey = string.Empty;

        public SettingsForm(string pass)
        {
            InitializeComponent();

            passKey = pass;
        }
    }
}
