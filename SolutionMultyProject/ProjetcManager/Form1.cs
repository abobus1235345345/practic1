using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetcManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Calendar.Main();
            Process.Start("ProjectOne.exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
                ProjectTwo.Form1 form1 = new ProjectTwo.Form1();
                form1.Show();
        }
    }
}
