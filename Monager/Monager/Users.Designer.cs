namespace Monager
{
    partial class Users
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
            RegisterBtn = new Button();
            label3 = new Label();
            PasswordTb = new TextBox();
            label5 = new Label();
            PhoneTb = new TextBox();
            label14 = new Label();
            label1 = new Label();
            UnameTb = new Label();
            UsernameTb = new TextBox();
            DOB = new DateTimePicker();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            AddressTb = new TextBox();
            SuspendLayout();
            // 
            // RegisterBtn
            // 
            RegisterBtn.BackColor = Color.Teal;
            RegisterBtn.Location = new Point(100, 416);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(158, 29);
            RegisterBtn.TabIndex = 59;
            RegisterBtn.Text = "Register";
            RegisterBtn.UseVisualStyleBackColor = false;
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 262);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 58;
            label3.Text = "Password";
            // 
            // PasswordTb
            // 
            PasswordTb.Location = new Point(100, 285);
            PasswordTb.Name = "PasswordTb";
            PasswordTb.PasswordChar = '*';
            PasswordTb.Size = new Size(158, 27);
            PasswordTb.TabIndex = 57;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(100, 209);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 56;
            label5.Text = "Phone";
            label5.Click += label5_Click;
            // 
            // PhoneTb
            // 
            PhoneTb.Location = new Point(100, 232);
            PhoneTb.Name = "PhoneTb";
            PhoneTb.Size = new Size(158, 27);
            PhoneTb.TabIndex = 55;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Perpetua Titling MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(91, 20);
            label14.Name = "label14";
            label14.Size = new Size(184, 36);
            label14.TabIndex = 54;
            label14.Text = "Monager";
            label14.Click += label14_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 156);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 63;
            label1.Text = "Date Of Birth";
            label1.Click += label1_Click;
            // 
            // UnameTb
            // 
            UnameTb.AutoSize = true;
            UnameTb.Location = new Point(100, 103);
            UnameTb.Name = "UnameTb";
            UnameTb.Size = new Size(75, 20);
            UnameTb.TabIndex = 61;
            UnameTb.Text = "Username";
            UnameTb.Click += label2_Click;
            // 
            // UsernameTb
            // 
            UsernameTb.Location = new Point(100, 126);
            UsernameTb.Name = "UsernameTb";
            UsernameTb.Size = new Size(158, 27);
            UsernameTb.TabIndex = 60;
            UsernameTb.TextChanged += textBox4_TextChanged;
            // 
            // DOB
            // 
            DOB.Format = DateTimePickerFormat.Short;
            DOB.Location = new Point(100, 179);
            DOB.Name = "DOB";
            DOB.Size = new Size(158, 27);
            DOB.TabIndex = 64;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(91, 56);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 65;
            label4.Text = "Register";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(156, 458);
            label6.Name = "label6";
            label6.Size = new Size(40, 20);
            label6.TabIndex = 66;
            label6.Text = "Back";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(100, 319);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 68;
            label7.Text = "Address";
            // 
            // AddressTb
            // 
            AddressTb.Location = new Point(100, 342);
            AddressTb.Multiline = true;
            AddressTb.Name = "AddressTb";
            AddressTb.Size = new Size(158, 50);
            AddressTb.TabIndex = 67;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(368, 495);
            Controls.Add(label7);
            Controls.Add(AddressTb);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(DOB);
            Controls.Add(label1);
            Controls.Add(UnameTb);
            Controls.Add(UsernameTb);
            Controls.Add(RegisterBtn);
            Controls.Add(label3);
            Controls.Add(PasswordTb);
            Controls.Add(label5);
            Controls.Add(PhoneTb);
            Controls.Add(label14);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Users";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RegisterBtn;
        private Label label3;
        private TextBox PasswordTb;
        private Label label5;
        private TextBox PhoneTb;
        private Label label14;
        private Label label1;
        private Label UnameTb;
        private TextBox UsernameTb;
        private DateTimePicker DOB;
        private Label label4;
        private Label label6;
        private Label label7;
        private TextBox AddressTb;
    }
}