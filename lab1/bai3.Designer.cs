namespace lab1
{
    partial class bai3
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
            Button btExit;
            Button btDel;
            Button btDoc;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bai3));
            tbNhap = new TextBox();
            tbkq = new TextBox();
            label1 = new Label();
            btExit = new Button();
            btDel = new Button();
            btDoc = new Button();
            SuspendLayout();
            // 
            // btExit
            // 
            btExit.BackColor = Color.Transparent;
            btExit.FlatAppearance.BorderColor = SystemColors.ControlLightLight;
            btExit.FlatAppearance.BorderSize = 0;
            btExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            btExit.FlatStyle = FlatStyle.Flat;
            btExit.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btExit.Location = new Point(318, 413);
            btExit.Name = "btExit";
            btExit.Size = new Size(102, 83);
            btExit.TabIndex = 3;
            btExit.Text = "Thoát";
            btExit.UseVisualStyleBackColor = false;
            btExit.Click += btExit_Click;
            // 
            // btDel
            // 
            btDel.BackColor = Color.Transparent;
            btDel.FlatAppearance.BorderColor = SystemColors.ControlLightLight;
            btDel.FlatAppearance.BorderSize = 0;
            btDel.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            btDel.FlatStyle = FlatStyle.Flat;
            btDel.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btDel.Location = new Point(185, 413);
            btDel.Name = "btDel";
            btDel.Size = new Size(102, 83);
            btDel.TabIndex = 2;
            btDel.Text = "Xóa";
            btDel.UseVisualStyleBackColor = false;
            btDel.Click += btDel_Click;
            // 
            // btDoc
            // 
            btDoc.BackColor = Color.Transparent;
            btDoc.FlatAppearance.BorderColor = SystemColors.ControlLightLight;
            btDoc.FlatAppearance.BorderSize = 0;
            btDoc.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 226, 244);
            btDoc.FlatStyle = FlatStyle.Flat;
            btDoc.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btDoc.Location = new Point(54, 413);
            btDoc.Name = "btDoc";
            btDoc.Size = new Size(102, 83);
            btDoc.TabIndex = 1;
            btDoc.Text = "Đọc";
            btDoc.UseVisualStyleBackColor = false;
            btDoc.Click += btDoc_Click;
            // 
            // tbNhap
            // 
            tbNhap.BackColor = Color.FromArgb(209, 226, 244);
            tbNhap.BorderStyle = BorderStyle.None;
            tbNhap.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbNhap.Location = new Point(94, 229);
            tbNhap.Multiline = true;
            tbNhap.Name = "tbNhap";
            tbNhap.Size = new Size(265, 70);
            tbNhap.TabIndex = 0;
            tbNhap.TextChanged += tbNhap_TextChanged;
            // 
            // tbkq
            // 
            tbkq.BackColor = Color.FromArgb(239, 240, 233);
            tbkq.BorderStyle = BorderStyle.None;
            tbkq.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbkq.Location = new Point(518, 395);
            tbkq.Multiline = true;
            tbkq.Name = "tbkq";
            tbkq.Size = new Size(372, 89);
            tbkq.TabIndex = 3;
            tbkq.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Location = new Point(140, 291);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 4;
            // 
            // bai3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1009, 642);
            Controls.Add(label1);
            Controls.Add(tbkq);
            Controls.Add(tbNhap);
            Controls.Add(btDoc);
            Controls.Add(btDel);
            Controls.Add(btExit);
            Name = "bai3";
            Text = "bai3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btExit;
        private TextBox tbNhap;
        private TextBox tbkq;
        private Label label1;
    }
}