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
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // btDoi
            // 
            btDoi.BackColor = SystemColors.Control;
            btDoi.FlatAppearance.MouseOverBackColor = Color.Aquamarine;
            btDoi.FlatStyle = FlatStyle.Flat;
            btDoi.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btDoi.Location = new Point(159, 118);
            btDoi.Name = "btDoi";
            btDoi.Size = new Size(165, 122);
            btDoi.TabIndex = 3;
            btDoi.Text = "Đổi";
            btDoi.UseVisualStyleBackColor = false;
            // 
            // btXoa
            // 
            btXoa.BackColor = SystemColors.Control;
            btXoa.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            btXoa.FlatStyle = FlatStyle.Flat;
            btXoa.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btXoa.Location = new Point(159, 294);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(165, 122);
            btXoa.TabIndex = 4;
            btXoa.Text = "Xóa";
            btXoa.UseVisualStyleBackColor = false;
            // 
            // btExit
            // 
            btExit.BackColor = SystemColors.Control;
            btExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            btExit.FlatStyle = FlatStyle.Flat;
            btExit.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btExit.Location = new Point(159, 468);
            btExit.Name = "btExit";
            btExit.Size = new Size(165, 122);
            btExit.TabIndex = 5;
            btExit.Text = "Thoát";
            btExit.UseVisualStyleBackColor = false;
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
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(511, 361);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(250, 33);
            comboBox1.TabIndex = 8;
            // 
            // bai4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1241, 751);
            Controls.Add(comboBox1);
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
        private ComboBox comboBox1;
    }
}