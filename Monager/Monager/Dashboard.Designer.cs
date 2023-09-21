namespace Monager
{
    partial class Dashboard
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
            panel1 = new Panel();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            IncomeLabel = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(IncomeLabel);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 747);
            panel1.TabIndex = 0;
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
            label4.Click += label4_Click;
            // 
            // IncomeLabel
            // 
            IncomeLabel.AutoSize = true;
            IncomeLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            IncomeLabel.Location = new Point(41, 288);
            IncomeLabel.Name = "IncomeLabel";
            IncomeLabel.Size = new Size(93, 32);
            IncomeLabel.TabIndex = 2;
            IncomeLabel.Text = "Income";
            IncomeLabel.TextAlign = ContentAlignment.TopCenter;
            IncomeLabel.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Teal;
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
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(1, 201);
            panel2.Name = "panel2";
            panel2.Size = new Size(249, 59);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.PaleTurquoise;
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(250, 135);
            panel3.Name = "panel3";
            panel3.Size = new Size(623, 277);
            panel3.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.PaleTurquoise;
            label9.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(36, 210);
            label9.Name = "label9";
            label9.Size = new Size(239, 32);
            label9.TabIndex = 8;
            label9.Text = "Last Transaction Date";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.PaleTurquoise;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(36, 93);
            label8.Name = "label8";
            label8.Size = new Size(100, 32);
            label8.TabIndex = 7;
            label8.Text = "Amount";
            label8.TextAlign = ContentAlignment.TopCenter;
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.PaleTurquoise;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(36, 33);
            label7.Name = "label7";
            label7.Size = new Size(151, 32);
            label7.TabIndex = 6;
            label7.Text = "Total Income";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel4
            // 
            panel4.Location = new Point(625, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(623, 277);
            panel4.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightCyan;
            panel5.Controls.Add(label10);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(label12);
            panel5.Location = new Point(873, 135);
            panel5.Name = "panel5";
            panel5.Size = new Size(623, 277);
            panel5.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.LightCyan;
            label10.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(54, 210);
            label10.Name = "label10";
            label10.Size = new Size(239, 32);
            label10.TabIndex = 11;
            label10.Text = "Last Transaction Date";
            label10.TextAlign = ContentAlignment.TopCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.LightCyan;
            label11.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(54, 93);
            label11.Name = "label11";
            label11.Size = new Size(100, 32);
            label11.TabIndex = 10;
            label11.Text = "Amount";
            label11.TextAlign = ContentAlignment.TopCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.LightCyan;
            label12.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(54, 33);
            label12.Name = "label12";
            label12.Size = new Size(151, 32);
            label12.TabIndex = 9;
            label12.Text = "Total Income";
            label12.TextAlign = ContentAlignment.TopCenter;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1522, 747);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label6;
        private Label label4;
        private Label IncomeLabel;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
    }
}