using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ValuesOfTheApp;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
    
        public Form1()
        {
            InitializeComponent();
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("This program will exit");
        //    Application.Exit();
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            ValuesOfTheApp.Values.Message = textBox1.Text;

            if (string.IsNullOrEmpty(ValuesOfTheApp.Values.Message))
            {
                MessageBox.Show("Your Danmu is Empty!");
            }
            else
            {
                var danmuWindow =new DanmuWindow();
            }
        }

        //private void trackBar1_Scroll(object sender, EventArgs e)
        //{
        //    Values.Speed = trackBar1.Value;
        //}

        private void AdvancrButton_Click(object sender, EventArgs e)
        {
            var setting = new AdvanceInterface();
            setting.Show();
        }

        
    }
}
