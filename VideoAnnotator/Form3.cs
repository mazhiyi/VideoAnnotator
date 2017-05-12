using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoAnnotator
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.button1.Focus();
        }

        private void label1_Click(object sender, EventArgs e) //Video Path Label
        {

        }

        private void label2_Click(object sender, EventArgs e) //Output Path Label
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) //Video Path textbox
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) //Output Path textbox
        {

        }

        private void button4_Click(object sender, EventArgs e) //Change video path
        {
            FolderBrowserDialog videopath = new FolderBrowserDialog();
            if (videopath.ShowDialog() == DialogResult.OK)
            {
                gl.clipPath = @videopath.SelectedPath + "\\";
                this.textBox1.Text = gl.clipPath;
            }
        }

        private void button2_Click(object sender, EventArgs e) //change output file path
        {
            FolderBrowserDialog writename = new FolderBrowserDialog();
            if (writename.ShowDialog() == DialogResult.OK)
            {
                gl.writePath = @writename.SelectedPath + "\\";
                this.textBox2.Text = gl.writePath;
            }
        }

        private void label3_Click(object sender, EventArgs e) //VideoList label
        {

        }

        private void button3_Click(object sender, EventArgs e) //Change VideoList path
        {
            OpenFileDialog videolist = videolist = new OpenFileDialog();
            if (videolist.ShowDialog() == DialogResult.OK)
            {
                gl.filename = @videolist.FileName;
                this.textBox3.Text = gl.filename;
            }
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e) // VideoList path textbox
        {

        }

        private void button1_Click(object sender, EventArgs e) //Quit
        {
            gl.movEx = this.textBox4.Text;
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e) // Change the movEx
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e) // Change extension
        {
            this.textBox4.Enabled = true;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = @gl.clipPath + "\\";
            this.textBox2.Text = @gl.writePath + "\\";
            this.textBox3.Text = @gl.filename;
            this.textBox4.Text = gl.movEx;
        }
    }
}
