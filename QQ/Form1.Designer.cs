namespace QQ
{
    partial class qqlog
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Password_Box = new System.Windows.Forms.TextBox();
            this.rmpassword_Button = new System.Windows.Forms.RadioButton();
            this.Autolog_radioButton = new System.Windows.Forms.RadioButton();
            this.log_button = new System.Windows.Forms.Button();
            this.register_label = new System.Windows.Forms.Label();
            this.Findpassword_label = new System.Windows.Forms.Label();
            this.log_comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Minimized_label = new System.Windows.Forms.Label();
            this.Close_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Password_Box
            // 
            this.Password_Box.Location = new System.Drawing.Point(114, 225);
            this.Password_Box.Name = "Password_Box";
            this.Password_Box.PasswordChar = '*';
            this.Password_Box.Size = new System.Drawing.Size(175, 21);
            this.Password_Box.TabIndex = 3;
            // 
            // rmpassword_Button
            // 
            this.rmpassword_Button.AutoSize = true;
            this.rmpassword_Button.ForeColor = System.Drawing.SystemColors.GrayText;
            this.rmpassword_Button.Location = new System.Drawing.Point(114, 254);
            this.rmpassword_Button.Name = "rmpassword_Button";
            this.rmpassword_Button.Size = new System.Drawing.Size(71, 16);
            this.rmpassword_Button.TabIndex = 6;
            this.rmpassword_Button.TabStop = true;
            this.rmpassword_Button.Text = "记住密码";
            this.rmpassword_Button.UseVisualStyleBackColor = true;
            // 
            // Autolog_radioButton
            // 
            this.Autolog_radioButton.AutoSize = true;
            this.Autolog_radioButton.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Autolog_radioButton.Location = new System.Drawing.Point(218, 254);
            this.Autolog_radioButton.Name = "Autolog_radioButton";
            this.Autolog_radioButton.Size = new System.Drawing.Size(71, 16);
            this.Autolog_radioButton.TabIndex = 7;
            this.Autolog_radioButton.TabStop = true;
            this.Autolog_radioButton.Text = "自动登录";
            this.Autolog_radioButton.UseVisualStyleBackColor = true;
            this.Autolog_radioButton.CheckedChanged += new System.EventHandler(this.Autolog_radioButton_CheckedChanged);
            // 
            // log_button
            // 
            this.log_button.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.log_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.log_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.log_button.Location = new System.Drawing.Point(114, 287);
            this.log_button.Name = "log_button";
            this.log_button.Size = new System.Drawing.Size(175, 31);
            this.log_button.TabIndex = 8;
            this.log_button.Text = "登  录";
            this.log_button.UseVisualStyleBackColor = false;
            this.log_button.Click += new System.EventHandler(this.log_button_Click);
            this.log_button.MouseEnter += new System.EventHandler(this.log_button_MouseEnter);
            this.log_button.MouseLeave += new System.EventHandler(this.log_button_MouseLeave);
            // 
            // register_label
            // 
            this.register_label.AutoSize = true;
            this.register_label.ForeColor = System.Drawing.Color.DodgerBlue;
            this.register_label.Location = new System.Drawing.Point(306, 199);
            this.register_label.Name = "register_label";
            this.register_label.Size = new System.Drawing.Size(53, 12);
            this.register_label.TabIndex = 9;
            this.register_label.Text = "注册账号";
            this.register_label.Click += new System.EventHandler(this.register_label_Click);
            this.register_label.MouseEnter += new System.EventHandler(this.register_label_MouseEnter);
            this.register_label.MouseLeave += new System.EventHandler(this.register_label_MouseLeave);
            this.register_label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.register_label_MouseMove);
            // 
            // Findpassword_label
            // 
            this.Findpassword_label.AutoSize = true;
            this.Findpassword_label.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Findpassword_label.Location = new System.Drawing.Point(306, 228);
            this.Findpassword_label.Name = "Findpassword_label";
            this.Findpassword_label.Size = new System.Drawing.Size(53, 12);
            this.Findpassword_label.TabIndex = 10;
            this.Findpassword_label.Text = "找回密码";
            this.Findpassword_label.MouseEnter += new System.EventHandler(this.Findpassword_label_MouseEnter);
            this.Findpassword_label.MouseLeave += new System.EventHandler(this.Findpassword_label_MouseLeave);
            this.Findpassword_label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Findpassword_label_MouseMove);
            // 
            // log_comboBox
            // 
            this.log_comboBox.FormattingEnabled = true;
            this.log_comboBox.Location = new System.Drawing.Point(114, 196);
            this.log_comboBox.Name = "log_comboBox";
            this.log_comboBox.Size = new System.Drawing.Size(175, 20);
            this.log_comboBox.TabIndex = 11;
            this.log_comboBox.SelectedIndexChanged += new System.EventHandler(this.log_comboBox_SelectedIndexChanged);
            this.log_comboBox.SelectedValueChanged += new System.EventHandler(this.log_comboBox_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.Image = global::QQ.Properties.Resources.QQ;
            this.label2.Location = new System.Drawing.Point(26, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 83);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // Minimized_label
            // 
            this.Minimized_label.BackColor = System.Drawing.Color.Transparent;
            this.Minimized_label.Image = global::QQ.Properties.Resources.QQ_mini;
            this.Minimized_label.Location = new System.Drawing.Point(368, -1);
            this.Minimized_label.Name = "Minimized_label";
            this.Minimized_label.Size = new System.Drawing.Size(33, 30);
            this.Minimized_label.TabIndex = 13;
            this.Minimized_label.Text = "fgfg";
            this.Minimized_label.Click += new System.EventHandler(this.Minimized_label_Click);
            this.Minimized_label.MouseEnter += new System.EventHandler(this.Minimized_label_MouseEnter);
            this.Minimized_label.MouseLeave += new System.EventHandler(this.Minimized_label_MouseLeave);
            // 
            // Close_label
            // 
            this.Close_label.BackColor = System.Drawing.Color.Transparent;
            this.Close_label.Image = global::QQ.Properties.Resources.QQ_close;
            this.Close_label.Location = new System.Drawing.Point(398, -1);
            this.Close_label.Name = "Close_label";
            this.Close_label.Size = new System.Drawing.Size(31, 30);
            this.Close_label.TabIndex = 14;
            this.Close_label.Text = "lab";
            this.Close_label.Click += new System.EventHandler(this.Close_label_Click_1);
            this.Close_label.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Close_label_MouseClick_1);
            this.Close_label.MouseEnter += new System.EventHandler(this.Close_label_MouseEnter);
            this.Close_label.MouseLeave += new System.EventHandler(this.Close_label_MouseLeave);
            // 
            // qqlog
            // 
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImage = global::QQ.Properties.Resources.QQtop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(429, 352);
            this.Controls.Add(this.Close_label);
            this.Controls.Add(this.Minimized_label);
            this.Controls.Add(this.log_comboBox);
            this.Controls.Add(this.Findpassword_label);
            this.Controls.Add(this.register_label);
            this.Controls.Add(this.log_button);
            this.Controls.Add(this.Autolog_radioButton);
            this.Controls.Add(this.rmpassword_Button);
            this.Controls.Add(this.Password_Box);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "qqlog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.qqlog_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.qqlog_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.qqlog_MouseUp);
            this.Move += new System.EventHandler(this.qqlog_Move);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox qqid_comboBox;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.Button findpassword_button2;
        private System.Windows.Forms.RadioButton remindword_radioButton;
        private System.Windows.Forms.RadioButton autolog_radioButton2;
        private System.Windows.Forms.Label Image_label1;
        private System.Windows.Forms.Label Headportrait_label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Password_Box;
        private System.Windows.Forms.RadioButton rmpassword_Button;
        private System.Windows.Forms.RadioButton Autolog_radioButton;
        private System.Windows.Forms.Button log_button;
        private System.Windows.Forms.Label register_label;
        private System.Windows.Forms.Label Findpassword_label;
        private System.Windows.Forms.ComboBox log_comboBox;
        private System.Windows.Forms.Label Minimized_label;
        private System.Windows.Forms.Label Close_label;

    }
}

