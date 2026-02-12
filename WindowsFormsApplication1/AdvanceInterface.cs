using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class AdvanceInterface : Form
    {
        public AdvanceInterface()
        {
            InitializeComponent();
            trackBar1.Value = ValuesOfTheApp.Values.Speed;
            label2.Text = ValuesOfTheApp.Values.Speed.ToString();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            ValuesOfTheApp.Values.Speed = trackBar1.Value;
            label2.Text = ValuesOfTheApp.Values.Speed.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowApply = true;
            fontDialog1.FontMustExist = true;
            fontDialog1.AllowSimulations = false;
            fontDialog1.ShowColor = true;
            fontDialog1.Color = ValuesOfTheApp.Values.usegeColor;
            fontDialog1.Font = ValuesOfTheApp.Values.usegeFont;
            fontDialog1.ShowDialog();
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            ValuesOfTheApp.Values.usegeFont = fontDialog1.Font;
            ValuesOfTheApp.Values.usegeColor = fontDialog1.Color;
        }
    }
}
