using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace MJC_HW2_UserInterfaceOfDoom
{
    public partial class Form1 : Form
    {
        //FIELDS
        Prime1 prime1;
        Prime2 prime2;
        Other1 other1;
        Other2 other2;
        Stopwatch sw;
        DateTime time;
        string timeFormat;

        //Initialize an integer for later use
        int calcInt = 0;

        //Properties for accessing the integer boxes
        public string Integer1Box
        {
            get { return integer1Box.Text; }
            set { integer1Box.Text = value; }
        }
        public string Integer2Box
        {
            get { return integer2Box.Text; }
            set { integer2Box.Text = value; }
        }

        //CONSTRUCTOR
        public Form1()
        {
            InitializeComponent();
            //Initialize other forms
            prime1 = new Prime1(this);
            prime2 = new Prime2(this);
            other1 = new Other1(this);
            other2 = new Other2(this);

            //Start a timer!
            sw = new Stopwatch();
            sw.Start();

            time = DateTime.Now;
            timeFormat = "MMM d HH:mm";

            //Initialize log
            using (StreamWriter writer = new StreamWriter("..\\..\\log.txt"))
            {
                writer.WriteLine($"[{time.ToString(timeFormat)}] (Form1) Application initialized.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //Method for filling up the bar incrementally
        private void fillErUpButton_Click(object sender, EventArgs e)
        {
            //Fill up the bar a bit if it isn't full
            if (fillerBar.Value < 100)
            {
                fillerBar.Value += 10;
            }
            //Determine which controls should be rendered active or inactive based on how full the bar is
            switch (fillerBar.Value)
            {
                //Instructions are active at 0
                case 0:
                    instructionsBox.Enabled = true;
                    instructionsBox.BackColor = SystemColors.Window;
                    primeButton1.Enabled = false;
                    primeButton1.BackColor = SystemColors.Control;
                    primeButton2.Enabled = false;
                    primeButton2.BackColor = SystemColors.Control;
                    otherButton1.Enabled = false;
                    otherButton1.BackColor = SystemColors.Control;
                    otherButton2.Enabled = false;
                    otherButton2.BackColor = SystemColors.Control;
                    calculateButton.Enabled = false;
                    calculateButton.BackColor = SystemColors.Control;
                    break;
                //First non-prime button is active at 20
                case 20:
                    instructionsBox.Enabled = false;
                    instructionsBox.BackColor = SystemColors.Control;
                    primeButton1.Enabled = false;
                    primeButton1.BackColor = SystemColors.Control;
                    primeButton2.Enabled = false;
                    primeButton2.BackColor = SystemColors.Control;
                    otherButton1.Enabled = true;
                    otherButton1.BackColor = SystemColors.ControlLight;
                    otherButton2.Enabled = false;
                    otherButton2.BackColor = SystemColors.Control;
                    calculateButton.Enabled = false;
                    calculateButton.BackColor = SystemColors.Control;
                    break;
                //Calculate button is active at 30
                case 30:
                    instructionsBox.Enabled = false;
                    instructionsBox.BackColor = SystemColors.Control;
                    primeButton1.Enabled = false;
                    primeButton1.BackColor = SystemColors.Control;
                    primeButton2.Enabled = false;
                    primeButton2.BackColor = SystemColors.Control;
                    otherButton1.Enabled = false;
                    otherButton1.BackColor = SystemColors.Control;
                    otherButton2.Enabled = false;
                    otherButton2.BackColor = SystemColors.Control;
                    calculateButton.Enabled = true;
                    calculateButton.BackColor = SystemColors.ControlLight;
                    break;
                //Second prime button is active at 50
                case 50:
                    instructionsBox.Enabled = false;
                    instructionsBox.BackColor = SystemColors.Control;
                    primeButton1.Enabled = false;
                    primeButton1.BackColor = SystemColors.Control;
                    primeButton2.Enabled = true;
                    primeButton2.BackColor = SystemColors.ControlLight;
                    otherButton1.Enabled = false;
                    otherButton1.BackColor = SystemColors.Control;
                    otherButton2.Enabled = false;
                    otherButton2.BackColor = SystemColors.Control;
                    calculateButton.Enabled = false;
                    calculateButton.BackColor = SystemColors.Control;
                    break;
                //Second non-prime button is active at 70
                case 70:
                    instructionsBox.Enabled = false;
                    instructionsBox.BackColor = SystemColors.Control;
                    primeButton1.Enabled = false;
                    primeButton1.BackColor = SystemColors.Control;
                    primeButton2.Enabled = false;
                    primeButton2.BackColor = SystemColors.Control;
                    otherButton1.Enabled = false;
                    otherButton1.BackColor = SystemColors.Control;
                    otherButton2.Enabled = true;
                    otherButton2.BackColor = SystemColors.ControlLight;
                    calculateButton.Enabled = false;
                    calculateButton.BackColor = SystemColors.Control;
                    break;
                //First prime button is active at 100
                case 100:
                    instructionsBox.Enabled = false;
                    instructionsBox.BackColor = SystemColors.Control;
                    primeButton1.Enabled = true;
                    primeButton1.BackColor = SystemColors.ControlLight;
                    primeButton2.Enabled = false;
                    primeButton2.BackColor = SystemColors.Control;
                    otherButton1.Enabled = false;
                    otherButton1.BackColor = SystemColors.Control;
                    otherButton2.Enabled = false;
                    otherButton2.BackColor = SystemColors.Control;
                    calculateButton.Enabled = false;
                    calculateButton.BackColor = SystemColors.Control;
                    break;
                default:
                    break;
            }

            //Log action
            LogEntry("(fillErUpButton_Click) Progress bar filled.");
        }

        //Empty out the progress bar
        private void emptyErOut_Click(object sender, EventArgs e)
        {
            fillerBar.Value = 0;
            instructionsBox.Enabled = true;
            instructionsBox.BackColor = SystemColors.Window;
            primeButton1.Enabled = false;
            primeButton1.BackColor = SystemColors.Control;
            primeButton2.Enabled = false;
            primeButton2.BackColor = SystemColors.Control;
            otherButton1.Enabled = false;
            otherButton1.BackColor = SystemColors.Control;
            otherButton2.Enabled = false;
            otherButton2.BackColor = SystemColors.Control;
            calculateButton.Enabled = false;
            calculateButton.BackColor = SystemColors.Control;

            LogEntry("(emptyErOut_Click) Progress bar emptied.");
        }

        //Pair of methods for clearing the integer fields
        private void clearButton1_Click(object sender, EventArgs e)
        {
            integer1Box.Text = "";

            LogEntry("(clearButton1_Click) Integer box 1 cleared.");
        }
        private void clearButton2_Click(object sender, EventArgs e)
        {
            integer2Box.Text = "";

            LogEntry("(clearButton2_Click) Integer box 2 cleared.");
        }

        //Set of methods for displaying the other forms
        private void primeButton1_Click(object sender, EventArgs e)
        {
            LogEntry("(primeButton1_Click) Opened Prime1 form.");
            prime1.ShowDialog();
        }
        private void otherButton1_Click(object sender, EventArgs e)
        {
            LogEntry("(otherButton1_Click) Opened Other1 form.");
            other1.ShowDialog();
        }
        private void primeButton2_Click(object sender, EventArgs e)
        {
            LogEntry("(primeButton2_Click) Opened Prime2 form.");
            prime2.ShowDialog();
        }
        private void otherButton2_Click(object sender, EventArgs e)
        {
            LogEntry("(otherButton2_Click) Opened Other2 form.");
            other2.ShowDialog();
        }

        //Calculate the sum of the two integers
        private void calculateButton_Click(object sender, EventArgs e)
        {
            //but be annoying first
            switch (calcInt)
            {
                case 0:
                    calculateButton.Width = calculateButton.Width += 10;
                    calculateButton.Height = calculateButton.Height += 5;
                    calcInt++;
                    calculateButton.Text = "Calculate?";

                    LogEntry("(calculateButton_Click) Started calculation.");
                    break;
                case 1:
                    calculateButton.Width = calculateButton.Width -= 10;
                    calculateButton.Height = calculateButton.Width -= 5;
                    try
                    {
                        //Parse integer field texts into actual integers
                        int int1 = int.Parse(integer1Box.Text);
                        int int2 = int.Parse(integer2Box.Text);

                        outputBox.Text = ($"{int1 + int2}");

                        //If the sum is 88, record it and close the application
                        if(int1+int2 == 88)
                        {
                            sw.Stop();
                            LogEntry("(calculateButton_Click) Computed a sum of 88. Closing program.");
                            using (StreamWriter writer = new StreamWriter("..\\..\\log.txt", true))
                            {
                                writer.WriteLine($"[{time.ToString(timeFormat)}] " + "Time since application started: {0:hh\\:mm\\:ss}", sw.Elapsed);
                            }

                            this.Close();
                        }
                    }
                    catch
                    {
                        //Error text
                        outputBox.Text = "integer missing...";
                        LogEntry("Error while calculating. Probably missing an integer.");
                    }
                    calcInt--;
                    calculateButton.Text = "Calculate";

                    LogEntry("(calculateButton_Click) Finished calculation.");
                    break;
                default:
                    calcInt = 0;
                    LogEntry("(calculateButton_Click) Calculation anomaly occurred.");
                    break;
            }            
        }

        private void instructionsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LogEntry("(instructionsBox_SelectedIndexChanged) Read some instructions.");
        }

        //Method for logging actions
        public void LogEntry(string text)
        {
            //Log action
            using (StreamWriter writer = new StreamWriter("..\\..\\log.txt", true))
            {
                writer.WriteLine($"[{time.ToString(timeFormat)}] {text}");
            }
        }
    }
}
