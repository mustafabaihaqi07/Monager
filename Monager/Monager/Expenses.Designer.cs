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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Expenses));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label8 = new Label();
            expDate = new DateTimePicker();
            expCatCb = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            expAmountTb = new TextBox();
            label11 = new Label();
            expDescTb = new TextBox();
            label12 = new Label();
            expNameTb = new TextBox();
            panel3 = new Panel();
            ExpTotalAmount = new Label();
            label14 = new Label();
            saveExpBtn = new Button();
            label15 = new Label();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(pictureBox1);
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
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(31, 579);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 78;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
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
            // expDate
            // 
            expDate.Location = new Point(845, 245);
            expDate.Name = "expDate";
            expDate.Size = new Size(241, 27);
            expDate.TabIndex = 49;
            // 
            // expCatCb
            // 
            expCatCb.FormattingEnabled = true;
            expCatCb.Items.AddRange(new object[] { "Food", "College", "Travel", "Other" });
            expCatCb.Location = new Point(845, 142);
            expCatCb.Name = "expCatCb";
            expCatCb.Size = new Size(151, 28);
            expCatCb.TabIndex = 48;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(845, 212);
            label9.Name = "label9";
            label9.Size = new Size(46, 23);
            label9.TabIndex = 47;
            label9.Text = "Date";
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
            // expAmountTb
            // 
            expAmountTb.Location = new Point(566, 245);
            expAmountTb.Name = "expAmountTb";
            expAmountTb.Size = new Size(125, 27);
            expAmountTb.TabIndex = 45;
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
            // expDescTb
            // 
            expDescTb.Location = new Point(647, 350);
            expDescTb.Multiline = true;
            expDescTb.Name = "expDescTb";
            expDescTb.Size = new Size(243, 89);
            expDescTb.TabIndex = 43;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(566, 110);
            label12.Name = "label12";
            label12.Size = new Size(123, 23);
            label12.TabIndex = 42;
            label12.Text = "Expense Name";
            // 
            // expNameTb
            // 
            expNameTb.Location = new Point(566, 143);
            expNameTb.Name = "expNameTb";
            expNameTb.Size = new Size(125, 27);
            expNameTb.TabIndex = 41;
            // 
            // panel3
            // 
            panel3.BackColor = Color.PaleTurquoise;
            panel3.Controls.Add(ExpTotalAmount);
            panel3.Controls.Add(label14);
            panel3.Location = new Point(293, 491);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 95);
            panel3.TabIndex = 40;
            // 
            // ExpTotalAmount
            // 
            ExpTotalAmount.AutoSize = true;
            ExpTotalAmount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ExpTotalAmount.Location = new Point(58, 49);
            ExpTotalAmount.Name = "ExpTotalAmount";
            ExpTotalAmount.Size = new Size(168, 28);
            ExpTotalAmount.TabIndex = 26;
            ExpTotalAmount.Text = "AmountInRupiahs";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(16, 12);
            label14.Name = "label14";
            label14.Size = new Size(142, 28);
            label14.TabIndex = 0;
            label14.Text = "Total Expense";
            // 
            // saveExpBtn
            // 
            saveExpBtn.BackColor = Color.Teal;
            saveExpBtn.Location = new Point(695, 491);
            saveExpBtn.Name = "saveExpBtn";
            saveExpBtn.Size = new Size(152, 29);
            saveExpBtn.TabIndex = 51;
            saveExpBtn.Text = "Save Expenses";
            saveExpBtn.UseVisualStyleBackColor = false;
            saveExpBtn.Click += button1_Click;
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
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1337, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 52;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // Expenses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1383, 633);
            Controls.Add(pictureBox3);
            Controls.Add(label15);
            Controls.Add(saveExpBtn);
            Controls.Add(label8);
            Controls.Add(expDate);
            Controls.Add(expCatCb);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(expAmountTb);
            Controls.Add(label11);
            Controls.Add(expDescTb);
            Controls.Add(label12);
            Controls.Add(expNameTb);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Expenses";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Expenses";
            Load += Expenses_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private DateTimePicker expDate;
        private ComboBox expCatCb;
        private Label label9;
        private Label label10;
        private TextBox expAmountTb;
        private Label label11;
        private TextBox expDescTb;
        private Label label12;
        private TextBox expNameTb;
        private Panel panel3;
        private Label ExpTotalAmount;
        private Label label14;
        private Button saveExpBtn;
        private Label label15;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
    }
}