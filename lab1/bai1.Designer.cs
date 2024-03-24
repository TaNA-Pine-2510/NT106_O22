namespace lab1
{
    partial class bai1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btExit = new Button();
            label1 = new Label();
            tbst1 = new TextBox();
            btDel = new Button();
            btTinh = new Button();
            tbst2 = new TextBox();
            tbkq = new TextBox();
            btsum = new Button();
            button4 = new Button();
            button5 = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btExit
            // 
            btExit.BackColor = Color.MistyRose;
            btExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btExit.Location = new Point(588, 384);
            btExit.Name = "btExit";
            btExit.Size = new Size(112, 67);
            btExit.TabIndex = 0;
            btExit.Text = "Thoát";
            btExit.UseVisualStyleBackColor = false;
            btExit.Click += btExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Brown;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.Black;
            label1.Image = Properties.Resources.ảnh_2;
            label1.Location = new Point(146, 60);
            label1.Name = "label1";
            label1.Size = new Size(318, 41);
            label1.TabIndex = 1;
            label1.Text = "TÍNH TỔNG 2 SỐ ";
            // 
            // tbst1
            // 
            tbst1.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbst1.Location = new Point(352, 195);
            tbst1.Multiline = true;
            tbst1.Name = "tbst1";
            tbst1.Size = new Size(188, 57);
            tbst1.TabIndex = 4;
            tbst1.TextChanged += tbst1_TextChanged;
            // 
            // btDel
            // 
            btDel.BackColor = Color.LightSteelBlue;
            btDel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btDel.Location = new Point(588, 236);
            btDel.Name = "btDel";
            btDel.Size = new Size(112, 65);
            btDel.TabIndex = 8;
            btDel.Text = "Xóa";
            btDel.UseVisualStyleBackColor = false;
            btDel.Click += btDel_Click;
            // 
            // btTinh
            // 
            btTinh.BackColor = Color.Pink;
            btTinh.BackgroundImageLayout = ImageLayout.Stretch;
            btTinh.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btTinh.Location = new Point(156, 349);
            btTinh.Name = "btTinh";
            btTinh.Size = new Size(384, 53);
            btTinh.TabIndex = 9;
            btTinh.Text = "Tính";
            btTinh.UseVisualStyleBackColor = false;
            btTinh.Click += btTinh_Click;
            // 
            // tbst2
            // 
            tbst2.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbst2.Location = new Point(352, 275);
            tbst2.Multiline = true;
            tbst2.Name = "tbst2";
            tbst2.Size = new Size(188, 55);
            tbst2.TabIndex = 10;
            tbst2.TextChanged += tbst2_TextChanged;
            // 
            // tbkq
            // 
            tbkq.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbkq.Location = new Point(352, 418);
            tbkq.Multiline = true;
            tbkq.Name = "tbkq";
            tbkq.Size = new Size(188, 57);
            tbkq.TabIndex = 11;
            tbkq.KeyPress += tbkq_KeyPress;
            // 
            // btsum
            // 
            btsum.BackColor = Color.PapayaWhip;
            btsum.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btsum.Location = new Point(156, 418);
            btsum.Name = "btsum";
            btsum.Size = new Size(155, 57);
            btsum.TabIndex = 12;
            btsum.Text = "Tổng";
            btsum.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.PapayaWhip;
            button4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(156, 195);
            button4.Name = "button4";
            button4.Size = new Size(155, 57);
            button4.TabIndex = 13;
            button4.Text = "Số thứ nhất";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.PapayaWhip;
            button5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(156, 275);
            button5.Name = "button5";
            button5.Size = new Size(155, 57);
            button5.TabIndex = 14;
            button5.Text = "Số thứ hai";
            button5.UseVisualStyleBackColor = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // bai1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.ảnh_2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(813, 572);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(btsum);
            Controls.Add(tbkq);
            Controls.Add(tbst2);
            Controls.Add(btTinh);
            Controls.Add(btDel);
            Controls.Add(tbst1);
            Controls.Add(label1);
            Controls.Add(btExit);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "bai1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btExit;
        private Label label1;
        private TextBox tbst1;
        private Button btDel;
        private Button btTinh;
        private TextBox tbst2;
        private TextBox tbkq;
        private Button btsum;
        private Button button4;
        private Button button5;
        private ErrorProvider errorProvider1;
    }
}
