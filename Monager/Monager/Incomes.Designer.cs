namespace Monager
{
    partial class Incomes
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
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            panel3 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 747);
            panel1.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.DarkSlateGray;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(41, 345);
            label8.Name = "label8";
            label8.Size = new Size(111, 32);
            label8.TabIndex = 6;
            label8.Text = "Expenses";
            label8.TextAlign = ContentAlignment.TopCenter;
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(41, 460);
            label9.Name = "label9";
            label9.Size = new Size(169, 32);
            label9.TabIndex = 5;
            label9.Text = "View Expenses";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(41, 403);
            label10.Name = "label10";
            label10.Size = new Size(151, 32);
            label10.TabIndex = 4;
            label10.Text = "View Income";
            label10.TextAlign = ContentAlignment.TopCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(41, 345);
            label11.Name = "label11";
            label11.Size = new Size(111, 32);
            label11.TabIndex = 3;
            label11.Text = "Expenses";
            label11.TextAlign = ContentAlignment.TopCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Teal;
            label12.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(41, 288);
            label12.Name = "label12";
            label12.Size = new Size(103, 32);
            label12.TabIndex = 2;
            label12.Text = "Incomes";
            label12.TextAlign = ContentAlignment.TopCenter;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(41, 212);
            label13.Name = "label13";
            label13.Size = new Size(129, 32);
            label13.TabIndex = 1;
            label13.Text = "Dashboard";
            label13.TextAlign = ContentAlignment.TopCenter;
            label13.Click += label13_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Perpetua Titling MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(31, 19);
            label14.Name = "label14";
            label14.Size = new Size(184, 36);
            label14.TabIndex = 0;
            label14.Text = "Monager";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Teal;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Location = new Point(0, 277);
            panel3.Name = "panel3";
            panel3.Size = new Size(249, 59);
            panel3.TabIndex = 7;
            // 
            // Incomes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1522, 747);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Incomes";
            Text = "Income";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Panel panel3;
    }
}