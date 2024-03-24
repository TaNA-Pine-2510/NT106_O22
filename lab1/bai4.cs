using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab1
{
    public partial class bai4 : Form
    {
        public bai4()
        {
            InitializeComponent();
            cb1.Text = "Binary";
            cb2.Text = "Hexdeccimal";
        }

        private void tbNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void btDoi_Click(object sender, EventArgs e)
        {
            if (tbNhap.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập thông tin");
            }
            else
            {
                try
                {
                    if (cb1.Text == "Binary" && cb2.Text == "Decimal")
                        tbkq.Text = Convert.ToInt32(tbNhap.Text, 2).ToString();

                    else if (cb1.Text == "Binary" && cb2.Text == "Hexadecimal")
                        tbkq.Text = Convert.ToString(Convert.ToInt32(tbNhap.Text, 2), 16);

                    else if (cb1.Text == "Decimal" && cb2.Text == "Binary")
                        tbkq.Text = Convert.ToString(int.Parse(tbNhap.Text), 2);

                    else if (cb1.Text == "Decimal" && cb2.Text == "Hexadecimal")
                        tbkq.Text = Convert.ToString(int.Parse(tbNhap.Text), 16);

                    else if (cb1.Text == "Hexadecimal" && cb2.Text == "Binary")
                        tbkq.Text = Convert.ToString(Convert.ToInt32(tbNhap.Text, 16), 2);

                    else if (cb1.Text == "Hexadecimal" && cb2.Text == "Decimal")
                        tbkq.Text = Convert.ToInt32(tbNhap.Text, 16).ToString();

                    else
                        MessageBox.Show("Không hỗ trợ chuyển đổi từ " + cb1.Text + " sang " + cb2.Text, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Giá trị nhập vào không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            tbkq.Text = tbNhap.Text = "";
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
