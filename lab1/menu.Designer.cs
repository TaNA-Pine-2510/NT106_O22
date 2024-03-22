namespace lab1
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            bt1 = new Button();
            bt2 = new Button();
            bt3 = new Button();
            bt4 = new Button();
            bt5 = new Button();
            SuspendLayout();
            // 
            // bt1
            // 
            bt1.BackColor = Color.FromArgb(255, 248, 243);
            bt1.FlatAppearance.BorderColor = Color.White;
            bt1.FlatAppearance.BorderSize = 0;
            bt1.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            bt1.FlatStyle = FlatStyle.Flat;
            bt1.Font = new Font("Cooper Black", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt1.Location = new Point(351, 74);
            bt1.Name = "bt1";
            bt1.Size = new Size(112, 66);
            bt1.TabIndex = 0;
            bt1.Text = "Bài 1";
            bt1.UseVisualStyleBackColor = false;
            bt1.Click += bt1_Click;
            // 
            // bt2
            // 
            bt2.BackColor = Color.FromArgb(255, 248, 243);
            bt2.FlatAppearance.BorderSize = 0;
            bt2.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            bt2.FlatStyle = FlatStyle.Flat;
            bt2.Font = new Font("Cooper Black", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt2.ForeColor = SystemColors.ActiveCaptionText;
            bt2.Location = new Point(351, 218);
            bt2.Name = "bt2";
            bt2.Size = new Size(112, 66);
            bt2.TabIndex = 1;
            bt2.Text = "Bài 2";
            bt2.UseVisualStyleBackColor = false;
            bt2.Click += bt2_Click;
            // 
            // bt3
            // 
            bt3.BackColor = Color.FromArgb(255, 248, 243);
            bt3.FlatAppearance.BorderColor = Color.White;
            bt3.FlatAppearance.BorderSize = 0;
            bt3.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            bt3.FlatStyle = FlatStyle.Flat;
            bt3.Font = new Font("Cooper Black", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt3.Location = new Point(351, 364);
            bt3.Name = "bt3";
            bt3.Size = new Size(112, 66);
            bt3.TabIndex = 2;
            bt3.Text = "Bài 3";
            bt3.UseVisualStyleBackColor = false;
            bt3.Click += bt3_Click;
            // 
            // bt4
            // 
            bt4.BackColor = Color.FromArgb(255, 248, 243);
            bt4.FlatAppearance.BorderColor = Color.White;
            bt4.FlatAppearance.BorderSize = 0;
            bt4.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            bt4.FlatStyle = FlatStyle.Flat;
            bt4.Font = new Font("Cooper Black", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt4.Location = new Point(565, 154);
            bt4.Name = "bt4";
            bt4.Size = new Size(112, 66);
            bt4.TabIndex = 3;
            bt4.Text = "Bài 4";
            bt4.UseVisualStyleBackColor = false;
            bt4.Click += bt4_Click;
            // 
            // bt5
            // 
            bt5.BackColor = Color.FromArgb(255, 248, 243);
            bt5.FlatAppearance.BorderSize = 0;
            bt5.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            bt5.FlatStyle = FlatStyle.Flat;
            bt5.Font = new Font("Cooper Black", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt5.Location = new Point(565, 303);
            bt5.Name = "bt5";
            bt5.Size = new Size(112, 66);
            bt5.TabIndex = 4;
            bt5.Text = "Bài 5";
            bt5.UseVisualStyleBackColor = false;
            bt5.Click += bt5_Click;
            // 
            // menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(794, 516);
            Controls.Add(bt5);
            Controls.Add(bt4);
            Controls.Add(bt3);
            Controls.Add(bt2);
            Controls.Add(bt1);
            Name = "menu";
            Text = "menu";
            ResumeLayout(false);
        }

        #endregion

        private Button bt1;
        private Button bt2;
        private Button bt3;
        private Button bt4;
        private Button bt5;
    }
}