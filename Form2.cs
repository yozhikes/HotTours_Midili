using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace HotTours_Midili
{
    public partial class Form2 : Form
    {
        public Tour tour;
        public Form2()
        {
            InitializeComponent();
            tour=new Tour();
        }
        public Form2(Tour izm) : this()
        {
            comboBox1.Text = izm.Direction;
            dateTimePicker1.Value = izm.Date;
            numericUpDown1.Value = izm.Nights;
            numericUpDown2.Value = izm.Qty;
            textBox1.Text = izm.Price.ToString();
            textBox2.Text = izm.Dop.ToString();
            checkBox1.Checked = izm.Wifi;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            tour.Direction = comboBox1.Text;
            tour.Date = dateTimePicker1.Value.Date;
            tour.Nights = int.Parse(numericUpDown1.Value.ToString());
            tour.Price = int.Parse(textBox1.Text);
            tour.Qty = int.Parse(numericUpDown2.Value.ToString());
            tour.Wifi = checkBox1.Checked;
            tour.Dop = int.Parse(textBox2.Text);
            tour.Sum = tour.Nights * tour.Price * tour.Qty + tour.Dop;
            DialogResult = DialogResult.OK;
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "Турция";
            dateTimePicker1.Value = DateTime.Today.Date;
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            textBox1.Text = "0";
            textBox2.Text = "0";
            checkBox1.Checked = false;
            tour.Direction = "Турция";
            tour.Date = DateTime.Today.Date;
            tour.Nights = 0;
            tour.Price = 0;
            tour.Qty = 0;
            tour.Wifi = false;
            tour.Dop = 0;
            tour.Sum = 0;
        }
    }
}
