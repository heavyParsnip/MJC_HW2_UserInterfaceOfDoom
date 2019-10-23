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
    public partial class Prime2 : Form
    {
        //Form1 field
        Form1 form1;

        public Prime2()
        {
            InitializeComponent();
        }
        public Prime2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        //Cancel button
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            form1.LogEntry("Closed Prime2 form.");
        }

        //Number buttons
        private void button2_Click(object sender, EventArgs e)
        {
            form1.Integer2Box = ("2" + $"{form1.Integer2Box}");
            form1.LogEntry("Pressed 2.");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            form1.Integer2Box = ("3" + $"{form1.Integer2Box}");
            form1.LogEntry("Pressed 3.");
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            form1.Integer2Box = ("5" + $"{form1.Integer2Box}");
            form1.LogEntry("Pressed 5.");
        }
        private void button7_Click(object sender, EventArgs e)
        {
            form1.Integer2Box = ("7" + $"{form1.Integer2Box}");
            form1.LogEntry("Pressed 7.");
        }
    }
}
