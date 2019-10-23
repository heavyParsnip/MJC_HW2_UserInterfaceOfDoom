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
    public partial class Other1 : Form
    {
        //Form 1 field
        Form1 form1;

        public Other1()
        {
            InitializeComponent();
        }
        public Other1(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        //Cancel button
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            form1.LogEntry("Closed Other1 form.");
        }

        //Number buttons
        private void button1_Click(object sender, EventArgs e)
        {
            form1.Integer1Box = ("1" + $"{form1.Integer1Box}");
            form1.LogEntry("Pressed 1.");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            form1.Integer1Box = ("4" + $"{form1.Integer1Box}");
            form1.LogEntry("Pressed 4.");
        }
        private void button6_Click(object sender, EventArgs e)
        {
            form1.Integer1Box = ("6" + $"{form1.Integer1Box}");
            form1.LogEntry("Pressed 6.");
        }
        private void button8_Click(object sender, EventArgs e)
        {
            form1.Integer1Box = ("8" + $"{form1.Integer1Box}");
            form1.LogEntry("Pressed 8.");
        }
        private void button9_Click(object sender, EventArgs e)
        {
            form1.Integer1Box = ("9" + $"{form1.Integer1Box}");
            form1.LogEntry("Pressed 9.");
        }
        private void button0_Click(object sender, EventArgs e)
        {
            form1.Integer1Box = ("0" + $"{form1.Integer1Box}");
            form1.LogEntry("Pressed 0.");
        }


    }
}
