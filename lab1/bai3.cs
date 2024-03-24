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
    public partial class bai3 : Form
    {
        public bai3()
        {
            InitializeComponent();
        }
        private void tbNhap_TextChanged(object sender, EventArgs e)
        {
            int txt;
            bool s1 = Int32.TryParse(tbNhap.Text, out txt);
            if (s1 == false && tbNhap.Text != "")
            {
                MessageBox.Show("Vui lòng số nguyên từ 0 - 10000!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                tbNhap.Text = "";
            }
        }

        private void btDoc_Click(object sender, EventArgs e)
        {
            string[] donvi = { "Không", "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín", "Mười" };
            string[] muoi = { "Mười", "Mười Một", "Mười Hai", "Mười Ba", "Mười Bốn", "Mười Lăm", "Mười Sáu", "Mười Bảy", "Mười Tám", "Mười Chín" };
            string[] chuc = { "", "Hai Mươi", "Ba Mươi", "Bốn Mươi", "Năm Mươi", "Sáu Mươi", "Bảy Mươi", "Tám Mươi", "Chín Mươi" };

            int Number = int.Parse(tbNhap.Text);
            int num = Number;
            string numText = "";
            if (num < 0 || num > 10000)
            {
                MessageBox.Show("Vui lòng số nguyên từ 0 - 10000!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                tbNhap.Text = "";
            }
            if (num == 10000)
            {
                numText = "Mười Ngàn";
            }
            if (num > 999 && num < 10000)
            {
                int i = num / 1000;
                numText = numText + donvi[i] + " Ngàn ";
                num = num % 1000;
                if (num < 10)
                {
                    numText = numText + "Không Trăm Lẻ " + donvi[num];
                    num = 0;
                }
                else if (num < 100)
                {
                    numText = numText + "Không Trăm ";
                }
            }

            if (num > 99 && num < 1000)
            {
                int i = num / 100;
                numText = numText + donvi[i] + " Trăm ";
                num = num % 100;
                if (num < 10)
                {
                    numText = numText + "Lẻ " + donvi[num];
                    num = 0;
                }
            }

            if (num > 19 && num < 100)
            {

                int i = num / 10;
                numText = numText + chuc[i - 1] + " ";
                num = num % 10;

            }

            if (num > 9 && num < 20)
            {
                int i = num - 10;
                numText = numText + muoi[i];
            }

            if (num > 0 && num < 10 && Number > 9)
            {
                if (num == 1)
                {
                    numText = numText + "Mốt";
                }
                else if (num == 5)
                {
                    numText = numText + "Lăm";
                }
                else if (num != 1 && num != 5)
                {
                    numText = numText + donvi[num];
                }
            }
            else if (Number < 10)
            {
                numText = donvi[num];
            }

            tbkq.Text = numText;
        }
        private void btDel_Click(object sender, EventArgs e)
        {
            tbkq.Text = tbNhap.Text = "";
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbkq_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbkq_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}

