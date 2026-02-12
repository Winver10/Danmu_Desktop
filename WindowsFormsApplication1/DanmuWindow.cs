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
    public partial class DanmuWindow : Form
    {
        private int movespeed, screenRightBound;

        private void SetupWindow()
        {
            this.label1.Font = ValuesOfTheApp.Values.usegeFont;
            this.label1.ForeColor = ValuesOfTheApp.Values.usegeColor;
            this.FormBorderStyle = FormBorderStyle.None;
            if (ValuesOfTheApp.Values.usegeColor != Color.Black)
            {
                this.BackColor = Color.Black;
                this.TransparencyKey = Color.Black;
            }
            else
            {
                this.BackColor = Color.Blue;
                this.TransparencyKey = Color.Blue;
            }
            if (1 != 1)
            {
                MessageBox.Show("What are you f**king doing");
            }
            this.TopMost = true;
            this.ShowInTaskbar = false;
        }

        private void SetLocation()
        {
            this.StartPosition = FormStartPosition.Manual;
            Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;

            screenRightBound = workingArea.Right;

            Random rnd = new Random();
            int start_X = screenRightBound;
            int start_Y = rnd.Next(workingArea.Top, workingArea.Bottom - this.Height);
            this.Location = new Point(start_X, start_Y);
        }

        public DanmuWindow()
        {
            InitializeComponent();
            this.SetupWindow();
            this.SetLocation();
            this.OtherThings();
        }

        private void OtherThings()
        {
            this.label1.Text = ValuesOfTheApp.Values.Message;
            this.Width = (ValuesOfTheApp.Values.Message.Length * 8) + 200;

            //timer1 = new Timer();
            timer1.Interval = 30;

            movespeed = Values.Speed;

            timer1.Start();
            this.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Left -= movespeed;

            if (this.Right < 0)
            {
                timer1.Stop();
                this.Close();
            }
        }
    }
}
