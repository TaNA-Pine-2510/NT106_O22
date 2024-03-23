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
    public partial class bai1 : Form
    {
        public bai1()
        {
            InitializeComponent();
        }


        private void tbst1_TextChanged(object sender, EventArgs e)
        {
            int txt;
            bool s1 = Int32.TryParse(tbst1.Text, out txt);
            if (s1 == false && tbst1.Text != "" && tbst1.Text != "-")
            {
                MessageBox.Show("Vui lòng số nguyên!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                tbst1.Text = "";
            }
            int temp;

        }

        private void tbst2_TextChanged(object sender, EventArgs e)
        {
            int txt;
            bool s2 = Int32.TryParse(tbst2.Text, out txt);
            if (s2 == false && tbst2.Text != "" && tbst2.Text != "-")
            {
                MessageBox.Show("Vui lòng số nguyên!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                tbst2.Text = "";
            }
        }

        private void btTinh_Click(object sender, EventArgs e)
        {
            int sum = 0;
            int so1 = Int32.Parse(tbst1.Text);
            int so2 = Int32.Parse(tbst2.Text);
            sum += so1 + so2;
            tbkq.Text = Convert.ToString(sum);
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            tbst1.Text = "";
            tbst2.Text = "";
            tbkq.Text = "";

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbkq_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
