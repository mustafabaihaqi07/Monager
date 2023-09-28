namespace Monager
{
    partial class Expenses
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
            panel1 = new Panel();
            label7 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label8 = new Label();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            textBox3 = new TextBox();
            label11 = new Label();
            textBox2 = new TextBox();
            label12 = new Label();
            textBox1 = new TextBox();
            panel3 = new Panel();
            label13 = new Label();
            label14 = new Label();
            button1 = new Button();
            label15 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 633);
            panel1.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Teal;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(41, 345);
            label7.Name = "label7";
            label7.Size = new Size(111, 32);
            label7.TabIndex = 6;
            label7.Text = "Expenses";
            label7.TextAlign = ContentAlignment.TopCenter;
            label7.Click += label7_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(1, 334);
            panel2.Name = "panel2";
            panel2.Size = new Size(249, 59);
            panel2.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(41, 460);
            label5.Name = "label5";
            label5.Size = new Size(169, 32);
            label5.TabIndex = 5;
            label5.Text = "View Expenses";
            label5.TextAlign = ContentAlignment.TopCenter;
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(41, 403);
            label6.Name = "label6";
            label6.Size = new Size(151, 32);
            label6.TabIndex = 4;
            label6.Text = "View Income";
            label6.TextAlign = ContentAlignment.TopCenter;
            label6.Click += label6_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(41, 345);
            label4.Name = "label4";
            label4.Size = new Size(111, 32);
            label4.TabIndex = 3;
            label4.Text = "Expenses";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(41, 288);
            label3.Name = "label3";
            label3.Size = new Size(103, 32);
            label3.TabIndex = 2;
            label3.Text = "Incomes";
            label3.TextAlign = ContentAlignment.TopCenter;
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(41, 212);
            label2.Name = "label2";
            label2.Size = new Size(129, 32);
            label2.TabIndex = 1;
            label2.Text = "Dashboard";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua Titling MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(31, 19);
            label1.Name = "label1";
            label1.Size = new Size(184, 36);
            label1.TabIndex = 0;
            label1.Text = "Monager";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(721, 314);
            label8.Name = "label8";
            label8.Size = new Size(85, 20);
            label8.TabIndex = 50;
            label8.Text = "Description";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(845, 245);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(241, 27);
            dateTimePicker1.TabIndex = 49;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Salary", "Gifts", "Other" });
            comboBox1.Location = new Point(845, 142);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 48;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(845, 212);
            label9.Name = "label9";
            label9.Size = new Size(118, 23);
            label9.TabIndex = 47;
            label9.Text = "Income Name";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(566, 212);
            label10.Name = "label10";
            label10.Size = new Size(72, 23);
            label10.TabIndex = 46;
            label10.Text = "Amount\r\n";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(566, 245);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 45;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(845, 110);
            label11.Name = "label11";
            label11.Size = new Size(91, 23);
            label11.TabIndex = 44;
            label11.Text = "Categories";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(647, 350);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(243, 89);
            textBox2.TabIndex = 43;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(566, 110);
            label12.Name = "label12";
            label12.Size = new Size(118, 23);
            label12.TabIndex = 42;
            label12.Text = "Income Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(566, 143);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 41;
            // 
            // panel3
            // 
            panel3.BackColor = Color.PaleTurquoise;
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label14);
            panel3.Location = new Point(293, 491);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 95);
            panel3.TabIndex = 40;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(58, 49);
            label13.Name = "label13";
            label13.Size = new Size(126, 20);
            label13.TabIndex = 26;
            label13.Text = "AmountInRupiahs";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(16, 12);
            label14.Name = "label14";
            label14.Size = new Size(123, 28);
            label14.TabIndex = 0;
            label14.Text = "Total Income";
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.Location = new Point(695, 491);
            button1.Name = "button1";
            button1.Size = new Size(152, 29);
            button1.TabIndex = 51;
            button1.Text = "Save Expenses";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(685, 40);
            label15.Name = "label15";
            label15.Size = new Size(180, 32);
            label15.TabIndex = 8;
            label15.Text = "Expense Details";
            label15.TextAlign = ContentAlignment.TopCenter;
            // 
            // Expenses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1383, 633);
            Controls.Add(label15);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(textBox3);
            Controls.Add(label11);
            Controls.Add(textBox2);
            Controls.Add(label12);
            Controls.Add(textBox1);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Expenses";
            Text = "Expenses";
            Load += Expenses_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private Panel panel2;
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Label label9;
        private Label label10;
        private TextBox textBox3;
        private Label label11;
        private TextBox textBox2;
        private Label label12;
        private TextBox textBox1;
        private Panel panel3;
        private Label label13;
        private Label label14;
        private Button button1;
        private Label label15;
    }
}