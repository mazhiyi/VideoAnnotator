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

namespace VideoAnnotator
{
    public partial class Form4 : Form
    {
        //Start of form
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Start playing the current clip
        {
            axWindowsMediaPlayer1.URL = gl.example;
            axWindowsMediaPlayer1.Ctlcontrols.play();
            this.button1.Enabled = false;
            this.trackBar1.Enabled = true;
            this.trackBar1.Focus();
            this.label2.ForeColor = System.Drawing.Color.Red;
        }

        private void button5_Click(object sender, EventArgs e) // Pause the current video
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            this.button3.Focus();
        }

        private void button3_Click(object sender, EventArgs e) // Resume the current video
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
            this.trackBar1.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) //Displaying the userID;
        {

        }

        private void button7_Click(object sender, EventArgs e) // Confirm the current clip is finished and save the output file.
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                this.Hide();
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e) // The annotation trackbar for clip1
        {
            if (this.trackBar1.Value > 0)
            {
                this.label5.ForeColor = System.Drawing.Color.Red;
                if (gl.currentMode == "A")
                    this.label5.Text = gl.A[0] + " " + this.trackBar1.Value;
                else if (gl.currentMode == "B")
                    this.label5.Text = gl.B[0] + " " + this.trackBar1.Value;
                this.label4.ForeColor = SystemColors.ControlText;
                this.label2.ForeColor = SystemColors.ControlText;
            }
            else if (this.trackBar1.Value < 0)
            {
                this.label4.ForeColor = System.Drawing.Color.Red;
                if (gl.currentMode == "A")
                    this.label4.Text = gl.A[1] + " " + -this.trackBar1.Value;
                else if (gl.currentMode == "B")
                    this.label4.Text = gl.B[1] + " " + -this.trackBar1.Value;
                this.label2.ForeColor = SystemColors.ControlText;
                this.label5.ForeColor = SystemColors.ControlText;
            }
            else
            {
                this.label2.ForeColor = System.Drawing.Color.Red;
                this.label5.ForeColor = SystemColors.ControlText;
                this.label4.ForeColor = SystemColors.ControlText;
                if (gl.currentMode == "A")
                {
                    this.label5.Text = gl.A[0];
                    this.label4.Text = gl.A[1];
                }
                else if (gl.currentMode == "B")
                {
                    this.label5.Text = gl.B[0];
                    this.label4.Text = gl.B[1];
                }

            }
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        { 
            Application.Exit();
        }

        private void trackBar1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.trackBar1.Value = 0;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label5.ForeColor = SystemColors.ControlText;
            this.label4.ForeColor = SystemColors.ControlText;
            if (gl.currentMode == "A")
            {
                this.label5.Text = gl.A[0];
                this.label4.Text = gl.A[1];
            }
            else if (gl.currentMode == "B")
            {
                this.label5.Text = gl.B[0];
                this.label4.Text = gl.B[1];
            }
        }

        private void label2_Click(object sender, EventArgs e) //Show Trackbar Value
        {
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            if (gl.currentMode == "A")
            {
                MessageBox.Show("In this video you will be annotating " + gl.A[0] + " and " + gl.A[1] + ".\n\nThe emotions that represent the corresponding mental states are: \n    Happy: Comfortable, Happy\n    Bothered: Frustrated, Nervous, Bothered\n\nPress -> on keyboard to increase a level, <- to decrease.\n\nIf you see none of these emotions, press <space> bar on keyboard to choose \"other\".\n\nWhen you finish, click\"Exit Current Clip\" button to exit.\n\nIf you have any questions during annotation, please click \"Pause\" button on the left and call one of the experimenters.\n\nHave Fun!");
            }
            else if (gl.currentMode == "B")
            {
                MessageBox.Show("In this video you will be annotating " + gl.B[0] + " and " + gl.B[1] + ".\n\nThe emotions that represent the corresponding mental states are: \n    Concentrated: Thinking, Concentrated\n    Confused: Unsure, Confused\n\nPress -> on keyboard to increase a level, <- to decrease.\n\nIf you see none of these emotions, press <space> bar on keyboard to choose \"other\".\n\nWhen you finish, click\"Exit Current Clip\" button to exit.\n\nIf you have any questions during annotation, please click \"Pause\" button on the left and call one of the experimenters.\n\nHave Fun!");
            }
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            this.axWindowsMediaPlayer1.uiMode = "full";
            this.axWindowsMediaPlayer1.Location = new Point(this.Width - this.axWindowsMediaPlayer1.Width - 40, 40);
            this.label2.Location = new Point(this.Width/2 - this.label2.Width / 2, this.Height - this.trackBar1.Height * 2);
            this.label4.Location = new Point(40, this.Height - this.trackBar1.Height * 2);
            this.label5.Location = new Point(this.Width - this.label5.Width - 40, this.Height - this.trackBar1.Height * 2);
        }
    }
}
