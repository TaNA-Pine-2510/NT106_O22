namespace lab1
{
    partial class bai4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bai4));
            btDoi = new Button();
            btXoa = new Button();
            btExit = new Button();
            tbNhap = new TextBox();
            tbkq = new TextBox();
            cb1 = new ComboBox();
            cb2 = new ComboBox();
            SuspendLayout();
            // 
            // btDoi
            // 
            btDoi.BackColor = Color.Transparent;
            btDoi.FlatAppearance.MouseOverBackColor = Color.Aquamarine;
            btDoi.FlatStyle = FlatStyle.Flat;
            btDoi.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btDoi.Location = new Point(159, 118);
            btDoi.Name = "btDoi";
            btDoi.Size = new Size(165, 122);
            btDoi.TabIndex = 3;
            btDoi.Text = "Đổi";
            btDoi.UseVisualStyleBackColor = false;
            btDoi.Click += btDoi_Click;
            // 
            // btXoa
            // 
            btXoa.BackColor = Color.Transparent;
            btXoa.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            btXoa.FlatStyle = FlatStyle.Flat;
            btXoa.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btXoa.Location = new Point(159, 294);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(165, 122);
            btXoa.TabIndex = 4;
            btXoa.Text = "Xóa";
            btXoa.UseVisualStyleBackColor = false;
            btXoa.Click += btXoa_Click;
            // 
            // btExit
            // 
            btExit.BackColor = Color.Transparent;
            btExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            btExit.FlatStyle = FlatStyle.Flat;
            btExit.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btExit.Location = new Point(159, 468);
            btExit.Name = "btExit";
            btExit.Size = new Size(165, 122);
            btExit.TabIndex = 5;
            btExit.Text = "Thoát";
            btExit.UseVisualStyleBackColor = false;
            btExit.Click += btExit_Click;
            // 
            // tbNhap
            // 
            tbNhap.BackColor = Color.FromArgb(250, 230, 212);
            tbNhap.BorderStyle = BorderStyle.None;
            tbNhap.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbNhap.Location = new Point(511, 183);
            tbNhap.Multiline = true;
            tbNhap.Name = "tbNhap";
            tbNhap.Size = new Size(659, 78);
            tbNhap.TabIndex = 0;
            tbNhap.TextChanged += tbNhap_TextChanged;
            // 
            // tbkq
            // 
            tbkq.BackColor = Color.FromArgb(250, 230, 212);
            tbkq.BorderStyle = BorderStyle.None;
            tbkq.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbkq.Location = new Point(500, 526);
            tbkq.Multiline = true;
            tbkq.Name = "tbkq";
            tbkq.Size = new Size(675, 78);
            tbkq.TabIndex = 7;
            tbkq.TabStop = false;
            tbkq.KeyPress += tbkq_KeyPress;
            // 
            // cb1
            // 
            cb1.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cb1.FormattingEnabled = true;
            cb1.Items.AddRange(new object[] { "Binary", "Decimal", "Hexadecimal" });
            cb1.Location = new Point(511, 361);
            cb1.Name = "cb1";
            cb1.Size = new Size(250, 40);
            cb1.TabIndex = 8;
            // 
            // cb2
            // 
            cb2.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cb2.FormattingEnabled = true;
            cb2.Items.AddRange(new object[] { "Binary", "Decimal", "Hexadecimal" });
            cb2.Location = new Point(912, 361);
            cb2.Name = "cb2";
            cb2.Size = new Size(263, 40);
            cb2.TabIndex = 9;
            // 
            // bai4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1241, 751);
            Controls.Add(cb2);
            Controls.Add(cb1);
            Controls.Add(tbkq);
            Controls.Add(tbNhap);
            Controls.Add(btExit);
            Controls.Add(btXoa);
            Controls.Add(btDoi);
            Name = "bai4";
            Text = "bai4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btDoi;
        private Button btXoa;
        private Button btExit;
        private TextBox tbNhap;
        private TextBox tbkq;
        private ComboBox cb1;
        private ComboBox cb2;
    }
}