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
    public partial class Form1 : Form
    {
        string dummy;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
     
        }

        private void button1_Click(object sender, EventArgs e) //log in button
        {
            if (this.TextID.Text == "")
            {
                MessageBox.Show("Please enter your UserID");
                return;
            }
           
            //load the .txt file;
            System.IO.StreamReader LoadVideo;
            LoadVideo = new System.IO.StreamReader(gl.filename);

            //get the line from txt file with userID;
            dummy = LoadVideo.ReadLine();
            while ((dummy != null) && (!dummy.Contains(this.TextID.Text)) )
            {
                dummy = LoadVideo.ReadLine();
            }
            LoadVideo.Close();

            if (dummy == null)
            {
                MessageBox.Show("No such UserID");
                return;
            }
            
            //put the substring into Clips;
           
            gl.Clips = dummy.Split(',');
            if (!((System.IO.File.Exists(gl.clipPath + "\\" + gl.Clips[1] + gl.movEx))&& (System.IO.File.Exists(gl.clipPath + "\\" + gl.Clips[2] + gl.movEx))&& (System.IO.File.Exists(gl.clipPath + "\\" + gl.Clips[3] + gl.movEx))))
            {
                MessageBox.Show("Cannot load the video clips. Please check the video extension or the video clip path");
                return;
            }

            //change the user interface to clips;
            
            this.button1.Hide();
            this.TextID.Enabled = false;
            this.button6.Show();
            this.AcceptButton = button6;
            this.button5.Hide();
            this.button2.Show();
            this.button3.Show();
            this.button4.Show();
            this.button7.Show();
        }

        private void button2_Click(object sender, EventArgs e) //Play Clip1
        {
            this.button6.Visible = false;
            this.button7.Visible = false;
            gl.currentClip = gl.Clips[1];
            gl.currentMode = gl.Clips[4];
            gl.writeName = gl.currentMode + gl.Clips[0] + "_" + gl.currentClip;
            this.AcceptButton = button3;
            this.button2.Enabled = false;
            Form2 Clip1 = new Form2();

            if (gl.currentMode == "A")
            {
                Clip1.label5.Text = gl.A[0];
                Clip1.label4.Text = gl.A[1];
            }
            else if (gl.currentMode == "B")
            {
                Clip1.label5.Text = gl.B[0];
                Clip1.label4.Text = gl.B[1];
            }

            Clip1.userID.Text = this.TextID.Text;
            Clip1.Show();
        }

        private void button3_Click(object sender, EventArgs e) // Clip2
        {
            gl.currentClip = gl.Clips[2];
            gl.currentMode = gl.Clips[5];
            gl.writeName = gl.currentMode + gl.Clips[0] + "_" + gl.currentClip; // no extension
            this.AcceptButton = button4;
            this.button3.Enabled = false;
            Form2 Clip2 = new Form2();

            if (gl.currentMode == "A")
            {
                Clip2.label5.Text = gl.A[0];
                Clip2.label4.Text = gl.A[1];
            }
            else if (gl.currentMode == "B")
            {
                Clip2.label5.Text = gl.B[0];
                Clip2.label4.Text = gl.B[1];
            }
            Clip2.userID.Text = this.TextID.Text;
            Clip2.Show();
        }

        private void button4_Click(object sender, EventArgs e) // Clip3
        {
            gl.currentClip = gl.Clips[3];
            gl.currentMode = gl.Clips[6];
            gl.writeName = gl.currentMode + gl.Clips[0] + "_" + gl.currentClip;
            this.button4.Enabled = false;
            Form2 Clip3 = new Form2();

            if (gl.currentMode == "A")
            {
                Clip3.label5.Text = gl.A[0];
                Clip3.label4.Text = gl.A[1];
            }
            else if (gl.currentMode == "B")
            {
                Clip3.label5.Text = gl.B[0];
                Clip3.label4.Text = gl.B[1];
            }

            Clip3.userID.Text = this.TextID.Text;
            Clip3.Show();
        }

        private void button5_Click(object sender, EventArgs e) // Set the paths
        {
            Form3 setPath = new Form3();
            setPath.Show();
        }

        private void button6_Click(object sender, EventArgs e) // The example
        {
            this.button7.Focus();
            
            Form4 example = new Form4();
            example.label5.Text = gl.A[0];
            example.label4.Text = gl.A[1];
            gl.example = gl.exampleA;
            gl.currentMode = "A";
            example.Show();
            example.userID.Text = this.TextID.Text;
        }

        private void button7_Click(object sender, EventArgs e) // mode B example
        {
            this.button2.Focus();

            Form4 example = new Form4();
            example.label5.Text = gl.B[0];
            example.label4.Text = gl.B[1];
            gl.example = gl.exampleB;
            gl.currentMode = "B";
            example.Show();
            example.userID.Text = this.TextID.Text;
        }
    }
}
