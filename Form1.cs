using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SunshineSubdivision
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[][] designs = {
                new string[] {"Peacock", "Palm tree", "Rose"},
                new string[] {"Race car", "Star", "Moon"},
                new string[] {"Palm tee", "Moon"},
                new string[] {"Peacock", "Moon"}};
            listBox2.Items.Clear();
            label3.Text = "";
            listBox2.Visible = true;
            for (int x = 0; x < listBox1.Items.Count; ++x)
                if (listBox1.GetSelected(x))
                    for (int y = 0; y < designs[x].Length; ++y )
                        listBox2.Items.Add(designs[x][y]);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Text = "Good choice!";
            listBox2.Visible = false;
        }
    }
}