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
    class FileManager
    {

        public static void ChangeOption(string option, int index)
        {
            string filePath = @"G:\Programming\C#\Maths-Toolkit\Dependencies\Options.txt";          //change to relative 

            if (File.Exists(filePath) == false)
            {
                MessageBox.Show(@"File Dependencies\Options.txt not found", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (option.ToUpper() == "THEME")
                {
                    if (index == 1)             //if dark theme is selected
                    {
                        using (StreamWriter sw = File.CreateText(filePath))
                        {
                            sw.WriteLine("theme");
                            sw.WriteLine("dark");
                        }
                    }
                    else if (index == 2)            // if light theme selected
                    {
                        using (StreamWriter sw = File.CreateText(filePath))
                        {
                            sw.WriteLine("theme");
                            sw.WriteLine("light");
                        }
                    }
                }
            }
        }

        public static void ApplyOption()
        {

        }

    }
}
