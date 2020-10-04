using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Maths_Toolkit
{
    public partial class BracketExpander : Form
    {
        public BracketExpander()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            var _menu = new Menu();
            _menu.Show();
            this.Close();
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {

        }
    }
}
