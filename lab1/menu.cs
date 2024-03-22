using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace lab1
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            new bai1().ShowDialog();
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            new bai2().ShowDialog();
        }


        private void bt3_Click(object sender, EventArgs e)
        {
            new bai3().ShowDialog();
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            new bai4().ShowDialog();
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            new bai5().ShowDialog();
        }
    }
}
