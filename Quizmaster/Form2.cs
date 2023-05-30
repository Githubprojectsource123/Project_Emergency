using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;
using static System.Windows.Forms.DataFormats;
using System.IO;
using System.Net;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Reflection.Metadata;

namespace Quizmaster
{
    public partial class Form2 : Form
    {

        public static Form2 instance;
        public static Form2 ins;
        public static Form2 message;
        public static Form2 message2;
        public static Form2 message3;
        public Label lab1;
        public int sc;
        public int pr;
        public int scx;
        public int prx;
        public int prxx;
        public int mr;
        public int mrx;
        public int mrxx;
        public string grade;
        public string gradex;
        public string gradexx;


        public Form2()
        {
            InitializeComponent();
            instance = this;
            message = this;
            message2 = this;
            message3 = this;
            ins = this;
            lab1 = label1;
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void labusername_Click(object sender, EventArgs e)
        {

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout ?", "QuizMaster", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Form1 f = new Form1();
                f.Show();
                this.Hide();
            }
        }

      




        private void btnmarks_Click(object sender, EventArgs e)
        {
            panel8.Height = 0;
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            panel8.Height = panel3.Height;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
 
        }
    }
    }

