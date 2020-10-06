using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maths_Toolkit
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure?","Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var _bracketExpander = new BracketExpander();
            _bracketExpander.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var _options = new Options();
            _options.Show();
            this.Close();
        }
    }
}
