using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MJC_HW2_UserInterfaceOfDoom
{
    public partial class Prime1 : Form
    {
        //Form1 field
        Form1 form1;

        public Prime1()
        {
            InitializeComponent();
        }
        public Prime1(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        //Cancel button
        private void clearButton_Click(object sender, EventArgs e)
        {
            this.Close();
            form1.LogEntry("Closed Prime1 form.");
        }

        //Number buttons
        private void button2_Click(object sender, EventArgs e)
        {
            form1.Integer1Box = ("2" + $"{form1.Integer1Box}");
            form1.LogEntry("Pressed 2.");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            form1.Integer1Box = ("5" + $"{form1.Integer1Box}");
            form1.LogEntry("Pressed 5.");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            form1.Integer1Box = ("3" + $"{form1.Integer1Box}");
            form1.LogEntry("Pressed 3.");
        }
        private void button7_Click(object sender, EventArgs e)
        {
            form1.Integer1Box = ("7" + $"{form1.Integer1Box}");
            form1.LogEntry("Pressed 7.");
        }
    }
}
