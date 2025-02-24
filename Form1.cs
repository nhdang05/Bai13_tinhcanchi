using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai13_tinhcanchi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            string[] canArr = { "Canh", "Tân", "Nhâm", "Canh", "Tân", "Nhâm","Canh", "Tân", "Nhâm","Canh", "Tân", "Nhâm","Nhâm" };
            string[] chiArr = { "thân", "dậu", "tuất", "Canh", "Tân", "Nhâm","Canh", "Tân", "Nhâm","Canh", "Tân", "Nhâm" };

            string giatritrave = canArr[Convert.ToInt32(txtNam.Text) % 10] + " " + chiArr[Convert.ToInt32(txtNam.Text) % 12];
            txtCanChi.Text = giatritrave;   
        }
    }
}
