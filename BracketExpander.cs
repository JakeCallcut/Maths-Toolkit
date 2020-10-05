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
            bool working = true;

            try //input testing
            {
                int x = Convert.ToInt16(txtcoeff1.Text);
                int y = Convert.ToInt16(txtconst1.Text);
                int z = Convert.ToInt16(txtcoeff2.Text);
                int w = Convert.ToInt16(txtconst2.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Please enter integers into the textboxes to continue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                working = false;
            }

            if (working == true)
            {
                int _coeff1 = Convert.ToInt16(txtcoeff1.Text);
                int _const1 = Convert.ToInt16(txtconst1.Text);
                int _coeff2 = Convert.ToInt16(txtcoeff2.Text);
                int _const2 = Convert.ToInt16(txtconst2.Text);

                MessageBox.Show(Expand(_coeff1, _const1, _coeff2, _const2));
            }
        }
        
        public static string Expand(int coeff1, int const1, int coeff2, int const2)
        {
            string coeffxsqr;
            string coeffx;
            string constant;

            coeffxsqr = Convert.ToString(coeff1 * coeff2);
            coeffx = Convert.ToString(coeff1 * const2 + coeff2 * const1);
            constant = Convert.ToString(const1 * const2);

            string finalstr = $"{coeffxsqr}x^2 + {coeffx}x + {constant}";
            return finalstr;
        }
    }
}
