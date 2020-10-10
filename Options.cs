using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Maths_Toolkit
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        private void grpTheme_Enter(object sender, EventArgs e)
        {

        }  

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (rdbLight.Checked == true)
            {
                OptionsManager.ChangeOption("THEME", 2);
            }
            else if (rdbDark.Checked == true)
            {
                OptionsManager.ChangeOption("THEME", 1);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var _menu = new Menu();
            _menu.Show();
            OptionsManager.ApplyOption("Theme");
            this.Close();
        }
        
        
    }
}
