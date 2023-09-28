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
            textBox3 = new TextBox();
            label5 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
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
            // textBox3
            // 
            textBox3.Location = new Point(91, 290);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(158, 27);
            textBox3.TabIndex = 49;
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
            // textBox1
            // 
            textBox1.Location = new Point(91, 188);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(158, 27);
            textBox1.TabIndex = 47;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.Location = new Point(91, 380);
            button1.Name = "button1";
            button1.Size = new Size(158, 29);
            button1.TabIndex = 53;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(368, 495);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label14);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label14;
        private Label label3;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox1;
        private Button button1;
    }
}