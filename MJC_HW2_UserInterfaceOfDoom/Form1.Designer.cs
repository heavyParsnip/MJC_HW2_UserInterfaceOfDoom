namespace MJC_HW2_UserInterfaceOfDoom
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fillErUpButton = new System.Windows.Forms.Button();
            this.instructionsBox = new System.Windows.Forms.ComboBox();
            this.fillerBar = new System.Windows.Forms.ProgressBar();
            this.emptyErOut = new System.Windows.Forms.Button();
            this.integer2Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.primeButton1 = new System.Windows.Forms.Button();
            this.integer1Box = new System.Windows.Forms.TextBox();
            this.primeButton2 = new System.Windows.Forms.Button();
            this.otherButton1 = new System.Windows.Forms.Button();
            this.otherButton2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.clearButton1 = new System.Windows.Forms.Button();
            this.clearButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fillErUpButton
            // 
            this.fillErUpButton.Font = new System.Drawing.Font("Corbel", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillErUpButton.Location = new System.Drawing.Point(12, 692);
            this.fillErUpButton.Name = "fillErUpButton";
            this.fillErUpButton.Size = new System.Drawing.Size(224, 74);
            this.fillErUpButton.TabIndex = 0;
            this.fillErUpButton.Text = "FILL ER UP";
            this.fillErUpButton.UseVisualStyleBackColor = true;
            this.fillErUpButton.Click += new System.EventHandler(this.fillErUpButton_Click);
            // 
            // instructionsBox
            // 
            this.instructionsBox.FormattingEnabled = true;
            this.instructionsBox.Items.AddRange(new object[] {
            "INSTRUCTIONS (click to read)",
            "This is a very nice simple addition calculator.",
            "Press the buttons at the bottom to fill up or empty the bar.",
            "Controls can only be accessed when the bar is at specific values.",
            "Select a number within the buttons to add it to the leftmost numeral spot.",
            "If you wish to exit the program, make a calculation with a sum of 88."});
            this.instructionsBox.Location = new System.Drawing.Point(12, 12);
            this.instructionsBox.Name = "instructionsBox";
            this.instructionsBox.Size = new System.Drawing.Size(806, 33);
            this.instructionsBox.TabIndex = 1;
            this.instructionsBox.Text = "INSTRUCTIONS (click to read)";
            this.instructionsBox.SelectedIndexChanged += new System.EventHandler(this.instructionsBox_SelectedIndexChanged);
            // 
            // fillerBar
            // 
            this.fillerBar.Location = new System.Drawing.Point(12, 795);
            this.fillerBar.Name = "fillerBar";
            this.fillerBar.Size = new System.Drawing.Size(807, 41);
            this.fillerBar.TabIndex = 7;
            // 
            // emptyErOut
            // 
            this.emptyErOut.Font = new System.Drawing.Font("Corbel", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyErOut.Location = new System.Drawing.Point(559, 692);
            this.emptyErOut.Name = "emptyErOut";
            this.emptyErOut.Size = new System.Drawing.Size(261, 74);
            this.emptyErOut.TabIndex = 8;
            this.emptyErOut.Text = "EMPTY ER OUT";
            this.emptyErOut.UseVisualStyleBackColor = true;
            this.emptyErOut.Click += new System.EventHandler(this.emptyErOut_Click);
            // 
            // integer2Box
            // 
            this.integer2Box.BackColor = System.Drawing.SystemColors.Window;
            this.integer2Box.Location = new System.Drawing.Point(278, 275);
            this.integer2Box.Name = "integer2Box";
            this.integer2Box.ReadOnly = true;
            this.integer2Box.Size = new System.Drawing.Size(218, 31);
            this.integer2Box.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(502, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 31);
            this.label2.TabIndex = 12;
            this.label2.Text = "=";
            // 
            // outputBox
            // 
            this.outputBox.BackColor = System.Drawing.SystemColors.Window;
            this.outputBox.Location = new System.Drawing.Point(538, 275);
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.Size = new System.Drawing.Size(252, 31);
            this.outputBox.TabIndex = 13;
            // 
            // primeButton1
            // 
            this.primeButton1.BackColor = System.Drawing.SystemColors.Control;
            this.primeButton1.Enabled = false;
            this.primeButton1.Location = new System.Drawing.Point(58, 349);
            this.primeButton1.Name = "primeButton1";
            this.primeButton1.Size = new System.Drawing.Size(127, 98);
            this.primeButton1.TabIndex = 14;
            this.primeButton1.Text = "Prime Numbers";
            this.primeButton1.UseVisualStyleBackColor = false;
            this.primeButton1.Click += new System.EventHandler(this.primeButton1_Click);
            // 
            // integer1Box
            // 
            this.integer1Box.BackColor = System.Drawing.SystemColors.Window;
            this.integer1Box.Location = new System.Drawing.Point(12, 275);
            this.integer1Box.Name = "integer1Box";
            this.integer1Box.ReadOnly = true;
            this.integer1Box.Size = new System.Drawing.Size(224, 31);
            this.integer1Box.TabIndex = 15;
            // 
            // primeButton2
            // 
            this.primeButton2.BackColor = System.Drawing.SystemColors.Control;
            this.primeButton2.Enabled = false;
            this.primeButton2.Location = new System.Drawing.Point(322, 349);
            this.primeButton2.Name = "primeButton2";
            this.primeButton2.Size = new System.Drawing.Size(127, 98);
            this.primeButton2.TabIndex = 16;
            this.primeButton2.Text = "Prime Numbers";
            this.primeButton2.UseVisualStyleBackColor = false;
            this.primeButton2.Click += new System.EventHandler(this.primeButton2_Click);
            // 
            // otherButton1
            // 
            this.otherButton1.BackColor = System.Drawing.SystemColors.Control;
            this.otherButton1.Enabled = false;
            this.otherButton1.Location = new System.Drawing.Point(58, 469);
            this.otherButton1.Name = "otherButton1";
            this.otherButton1.Size = new System.Drawing.Size(127, 98);
            this.otherButton1.TabIndex = 17;
            this.otherButton1.Text = "The other numbers";
            this.otherButton1.UseVisualStyleBackColor = false;
            this.otherButton1.Click += new System.EventHandler(this.otherButton1_Click);
            // 
            // otherButton2
            // 
            this.otherButton2.BackColor = System.Drawing.SystemColors.Control;
            this.otherButton2.Enabled = false;
            this.otherButton2.Location = new System.Drawing.Point(322, 469);
            this.otherButton2.Name = "otherButton2";
            this.otherButton2.Size = new System.Drawing.Size(127, 98);
            this.otherButton2.TabIndex = 18;
            this.otherButton2.Text = "The other numbers";
            this.otherButton2.UseVisualStyleBackColor = false;
            this.otherButton2.Click += new System.EventHandler(this.otherButton2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Papyrus", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 58);
            this.label3.TabIndex = 19;
            this.label3.Text = "Integer 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label4.Location = new System.Drawing.Point(303, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 45);
            this.label4.TabIndex = 20;
            this.label4.Text = "Integer 2";
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.SystemColors.Control;
            this.calculateButton.Enabled = false;
            this.calculateButton.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(559, 349);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(210, 68);
            this.calculateButton.TabIndex = 21;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(289, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(480, 28);
            this.label5.TabIndex = 22;
            this.label5.Text = "very nice simple addition calculator";
            // 
            // clearButton1
            // 
            this.clearButton1.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton1.Location = new System.Drawing.Point(58, 586);
            this.clearButton1.Name = "clearButton1";
            this.clearButton1.Size = new System.Drawing.Size(127, 50);
            this.clearButton1.TabIndex = 23;
            this.clearButton1.Text = "Clear";
            this.clearButton1.UseVisualStyleBackColor = true;
            this.clearButton1.Click += new System.EventHandler(this.clearButton1_Click);
            // 
            // clearButton2
            // 
            this.clearButton2.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton2.Location = new System.Drawing.Point(322, 586);
            this.clearButton2.Name = "clearButton2";
            this.clearButton2.Size = new System.Drawing.Size(127, 50);
            this.clearButton2.TabIndex = 24;
            this.clearButton2.Text = "Clear";
            this.clearButton2.UseVisualStyleBackColor = true;
            this.clearButton2.Click += new System.EventHandler(this.clearButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 855);
            this.Controls.Add(this.clearButton2);
            this.Controls.Add(this.clearButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.otherButton2);
            this.Controls.Add(this.otherButton1);
            this.Controls.Add(this.primeButton2);
            this.Controls.Add(this.integer1Box);
            this.Controls.Add(this.primeButton1);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.integer2Box);
            this.Controls.Add(this.emptyErOut);
            this.Controls.Add(this.fillerBar);
            this.Controls.Add(this.instructionsBox);
            this.Controls.Add(this.fillErUpButton);
            this.Name = "Form1";
            this.Text = "it\'s real nice";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fillErUpButton;
        private System.Windows.Forms.ComboBox instructionsBox;
        private System.Windows.Forms.ProgressBar fillerBar;
        private System.Windows.Forms.Button emptyErOut;
        private System.Windows.Forms.TextBox integer2Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Button primeButton1;
        private System.Windows.Forms.TextBox integer1Box;
        private System.Windows.Forms.Button primeButton2;
        private System.Windows.Forms.Button otherButton1;
        private System.Windows.Forms.Button otherButton2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button clearButton1;
        private System.Windows.Forms.Button clearButton2;
    }
}

