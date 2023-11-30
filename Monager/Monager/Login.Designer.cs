namespace Monager
{
    partial class Login
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
            label14 = new Label();
            label3 = new Label();
            passwordTb = new TextBox();
            label5 = new Label();
            usernameTb = new TextBox();
            loginBtn = new Button();
            RegisterBtn = new Label();
            SuspendLayout();
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Perpetua Titling MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(83, 50);
            label14.Name = "label14";
            label14.Size = new Size(184, 36);
            label14.TabIndex = 1;
            label14.Text = "Monager";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 267);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 50;
            label3.Text = "Password";
            // 
            // passwordTb
            // 
            passwordTb.BackColor = SystemColors.Window;
            passwordTb.BorderStyle = BorderStyle.FixedSingle;
            passwordTb.Location = new Point(91, 290);
            passwordTb.Name = "passwordTb";
            passwordTb.PasswordChar = '*';
            passwordTb.Size = new Size(158, 27);
            passwordTb.TabIndex = 49;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(91, 165);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 48;
            label5.Text = "Username";
            // 
            // usernameTb
            // 
            usernameTb.BorderStyle = BorderStyle.FixedSingle;
            usernameTb.Location = new Point(91, 188);
            usernameTb.Name = "usernameTb";
            usernameTb.Size = new Size(158, 27);
            usernameTb.TabIndex = 47;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.Teal;
            loginBtn.Location = new Point(91, 380);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(158, 29);
            loginBtn.TabIndex = 53;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // RegisterBtn
            // 
            RegisterBtn.AutoSize = true;
            RegisterBtn.Location = new Point(12, 466);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(63, 20);
            RegisterBtn.TabIndex = 54;
            RegisterBtn.Text = "Register";
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(368, 495);
            Controls.Add(RegisterBtn);
            Controls.Add(loginBtn);
            Controls.Add(label3);
            Controls.Add(passwordTb);
            Controls.Add(label5);
            Controls.Add(usernameTb);
            Controls.Add(label14);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label14;
        private Label label3;
        private TextBox passwordTb;
        private Label label5;
        private TextBox usernameTb;
        private Button loginBtn;
        private Label RegisterBtn;
    }
}