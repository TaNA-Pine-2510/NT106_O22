namespace lab1
{
    partial class bai2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            btExit = new Button();
            btDel = new Button();
            btTim = new Button();
            tbMax = new TextBox();
            tbMin = new TextBox();
            tbs1 = new TextBox();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            tbs2 = new TextBox();
            tbs3 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.MistyRose;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(505, 244);
            button1.Name = "button1";
            button1.Size = new Size(138, 51);
            button1.TabIndex = 0;
            button1.TabStop = false;
            button1.Text = "Số lớn nhất";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.MistyRose;
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(668, 244);
            button2.Name = "button2";
            button2.Size = new Size(144, 51);
            button2.TabIndex = 1;
            button2.TabStop = false;
            button2.Text = "Số nhỏ nhất";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.PaleTurquoise;
            button3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(505, 173);
            button3.Name = "button3";
            button3.Size = new Size(307, 51);
            button3.TabIndex = 2;
            button3.TabStop = false;
            button3.Text = "Kết Quả";
            button3.UseVisualStyleBackColor = false;
            // 
            // btExit
            // 
            btExit.BackColor = Color.LightCoral;
            btExit.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btExit.Location = new Point(556, 430);
            btExit.Name = "btExit";
            btExit.Size = new Size(193, 51);
            btExit.TabIndex = 5;
            btExit.Text = "Thoát";
            btExit.UseVisualStyleBackColor = false;
            btExit.Click += btExit_Click;
            // 
            // btDel
            // 
            btDel.BackColor = Color.MistyRose;
            btDel.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btDel.Location = new Point(232, 401);
            btDel.Name = "btDel";
            btDel.Size = new Size(193, 51);
            btDel.TabIndex = 4;
            btDel.Text = "Xóa";
            btDel.UseVisualStyleBackColor = false;
            btDel.Click += btDel_Click;
            // 
            // btTim
            // 
            btTim.BackColor = Color.PaleTurquoise;
            btTim.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btTim.Location = new Point(44, 401);
            btTim.Name = "btTim";
            btTim.Size = new Size(144, 51);
            btTim.TabIndex = 3;
            btTim.Text = "Tìm";
            btTim.UseVisualStyleBackColor = false;
            btTim.Click += btTim_Click;
            // 
            // tbMax
            // 
            tbMax.BorderStyle = BorderStyle.None;
            tbMax.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbMax.Location = new Point(510, 322);
            tbMax.Multiline = true;
            tbMax.Name = "tbMax";
            tbMax.Size = new Size(125, 67);
            tbMax.TabIndex = 6;
            tbMax.TabStop = false;
            tbMax.TextAlign = HorizontalAlignment.Center;
            // 
            // tbMin
            // 
            tbMin.BorderStyle = BorderStyle.None;
            tbMin.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbMin.Location = new Point(680, 322);
            tbMin.Multiline = true;
            tbMin.Name = "tbMin";
            tbMin.Size = new Size(125, 67);
            tbMin.TabIndex = 7;
            tbMin.TabStop = false;
            tbMin.TextAlign = HorizontalAlignment.Center;
            // 
            // tbs1
            // 
            tbs1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbs1.Location = new Point(232, 132);
            tbs1.Multiline = true;
            tbs1.Name = "tbs1";
            tbs1.Size = new Size(193, 51);
            tbs1.TabIndex = 0;
            tbs1.TextAlign = HorizontalAlignment.Center;
            tbs1.TextChanged += tbs1_TextChanged;
            // 
            // button4
            // 
            button4.BackColor = Color.MistyRose;
            button4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(44, 132);
            button4.Name = "button4";
            button4.Size = new Size(144, 51);
            button4.TabIndex = 9;
            button4.TabStop = false;
            button4.Text = "Số thứ 1";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.MistyRose;
            button5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(44, 229);
            button5.Name = "button5";
            button5.Size = new Size(144, 51);
            button5.TabIndex = 10;
            button5.TabStop = false;
            button5.Text = "Số thứ 2";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.MistyRose;
            button6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(44, 322);
            button6.Name = "button6";
            button6.Size = new Size(144, 51);
            button6.TabIndex = 11;
            button6.TabStop = false;
            button6.Text = "Số thứ 3";
            button6.UseVisualStyleBackColor = false;
            // 
            // tbs2
            // 
            tbs2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbs2.Location = new Point(232, 229);
            tbs2.Multiline = true;
            tbs2.Name = "tbs2";
            tbs2.Size = new Size(193, 51);
            tbs2.TabIndex = 1;
            tbs2.TextAlign = HorizontalAlignment.Center;
            tbs2.TextChanged += tbs2_TextChanged;
            // 
            // tbs3
            // 
            tbs3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbs3.Location = new Point(232, 322);
            tbs3.Multiline = true;
            tbs3.Name = "tbs3";
            tbs3.Size = new Size(193, 51);
            tbs3.TabIndex = 2;
            tbs3.TextAlign = HorizontalAlignment.Center;
            tbs3.TextChanged += tbs3_TextChanged;
            // 
            // bai2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ảnh_3;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(934, 570);
            Controls.Add(tbs3);
            Controls.Add(tbs2);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(tbs1);
            Controls.Add(tbMin);
            Controls.Add(tbMax);
            Controls.Add(btTim);
            Controls.Add(btDel);
            Controls.Add(btExit);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "bai2";
            Text = "bai2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button btExit;
        private Button btDel;
        private Button btTim;
        private TextBox tbMax;
        private TextBox tbMin;
        private TextBox tbs1;
        private Button button4;
        private Button button5;
        private Button button6;
        private TextBox tbs2;
        private TextBox tbs3;
    }
}