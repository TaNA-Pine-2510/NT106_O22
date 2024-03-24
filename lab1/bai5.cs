using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace lab1
{
    public partial class bai5 : Form
    {
        private string name;
        private double[] scores;
        public bai5()
        {
            InitializeComponent();
            lbtb.Text = "";
            lbxloai.Text = "";
            lbmin.Text = "";
            lbmax.Text = "";
            lbrot.Text = "";
            lbdau.Text = "";
            flowLayoutPanel1.Controls.Clear();

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbnhap_TextChanged(object sender, EventArgs e)
        {
            if (tbnhap.Text.Contains(','))
            {
                MessageBox.Show("Vui lòng sử dụng dấu chấm '.' cho số thập phân.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btxuat_Click(object sender, EventArgs e)
        {

            string[] input = tbnhap.Text.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            if (input.Length < 2)
            {
                MessageBox.Show("Đã nhập sai format", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            name = input[0].Trim();
            flowLayoutPanel1.Controls.Clear();
            //Label labelName = new Label();
            // flowLayoutPanel1.Controls.Add(labelName);
            scores = input.Skip(1).Select(double.Parse).ToArray();

            int numSJ = input.Length - 1;
            // scores = new double[numSJ];
            tbten.Text = name + "\r\n";
            for (int i = 0; i < scores.Length; i++)
            {

                Label label = new Label();
                label.Text = $"Môn {i + 1}: {scores[i].ToString()}";
                label.AutoSize = true;
                label.Top = 20 + i * 25;
                flowLayoutPanel1.Controls.Add(label);
            }

           
            double diemTB = scores.Average();
            lbtb.Text = $"{diemTB.ToString()}";


            double diemCaoNhat = scores.Max();
            double diemThapNhat = scores.Min();
            lbmax.Text = $"{diemCaoNhat.ToString()}"+"đ";
            lbmin.Text = $"{diemThapNhat.ToString()}"+"đ";


            int somondau = scores.Count(x => x >= 5);
            int somontruot = scores.Length - somondau;
            lbdau.Text = $"{somondau.ToString()}";
            lbrot.Text = $"{somontruot.ToString()}";



            string hocluc;
            if (diemTB >= 8 && scores.All(x => x >= 6.5))
            {
                hocluc = "Giỏi";
            }
            else if (diemTB >= 6.5 && scores.All(x => x >= 5))
            {
                hocluc = "Khá";
            }
            else if (diemTB >= 5 && scores.All(x => x >= 3.5))
            {
                hocluc = "Trung bình";
            }
            else if (diemTB >= 3.5 && scores.All(x => x >= 2))
            {
                hocluc = "Yếu";
            }
            else
            {
                hocluc = "Kém";
            }
            lbxloai.Text = $"{hocluc}";
        }

        private void tbten_TextChanged(object sender, EventArgs e)
        {

        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            tbnhap.Text = "";
            lbtb.Text = lbxloai.Text = lbrot.Text = lbdau.Text = lbmin.Text = lbmax.Text =tbten.Text= "";
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbten_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

        }
    }
}