using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

namespace Maths_Toolkit
{
    class OptionsManager
    {
        readonly static string filePath = @"G:\Programming\C#\Maths-Toolkit\Dependencies\Options.txt";          //change to relative 

        public static void ChangeOption(string option, int index)
        {
            if (File.Exists(filePath) == true)
            {
                if (option.ToUpper() == "THEME")
                {
                    if (index == 1)             //if dark theme is selected
                    {
                        using (StreamWriter sw = File.CreateText(filePath))
                        {
                            sw.WriteLine("THEME");
                            sw.WriteLine("DARK");
                        }
                    }
                    else if (index == 2)            // if light theme selected
                    {
                        using (StreamWriter sw = File.CreateText(filePath))
                        {
                            sw.WriteLine("THEME");
                            sw.WriteLine("LIGHT");
                        }
                    }
                } 
            }
            else
            {
                MessageBox.Show(@"File Dependencies\Options.txt not found", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ApplyOption(string option)
        {
            string s;
            if (File.Exists(filePath) == true)
            {
                if (option.ToUpper() == "THEME")
                {
                    using (StreamReader sr = File.OpenText(filePath))
                    {
                        s = sr.ReadLine();
                        s = sr.ReadLine();
                    }
                    if (s.ToUpper() == "LIGHT")
                    {
                        Menu.ActiveForm.BackColor = Color.FromArgb(244, 244, 244);            
                        BracketExpander.ActiveForm.BackColor = Color.FromArgb(244, 244, 244);          //white-ish
                        Options.ActiveForm.BackColor = Color.FromArgb(244, 244, 244);         

                        Menu.ActiveForm.
                    }
                    else if (s.ToUpper() == "DARK")
                    {
                        Menu.ActiveForm.BackColor = Color.FromArgb(68, 68, 68);
                        BracketExpander.ActiveForm.BackColor = Color.FromArgb(68, 68, 68);              //gray
                        Options.ActiveForm.BackColor = Color.FromArgb(68, 68, 68);
                    }
                }
            }
            else
            {
                MessageBox.Show(@"File Dependencies\Options.txt not found", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ApplyOption()        //overload to apply all options
        {
            ApplyOption("THEME");
        }
    }
}
