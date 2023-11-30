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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Incomes));
            panel1 = new Panel();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            panel3 = new Panel();
            label1 = new Label();
            incDate = new DateTimePicker();
            incCatCb = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            incAmountTb = new TextBox();
            label4 = new Label();
            incDescTb = new TextBox();
            label5 = new Label();
            incNameTb = new TextBox();
            panel2 = new Panel();
            TotalIncomeLbl = new Label();
            label7 = new Label();
            label15 = new Label();
            saveBtn = new Button();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(pictureBox1);
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
            panel1.Size = new Size(250, 633);
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
            label9.Click += label9_Click;
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
            label10.Click += label10_Click;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(721, 314);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 50;
            label1.Text = "Description";
            // 
            // incDate
            // 
            incDate.CustomFormat = "";
            incDate.Location = new Point(845, 245);
            incDate.Name = "incDate";
            incDate.Size = new Size(250, 27);
            incDate.TabIndex = 49;
            incDate.Value = new DateTime(2023, 11, 30, 9, 28, 50, 0);
            // 
            // incCatCb
            // 
            incCatCb.FormattingEnabled = true;
            incCatCb.Items.AddRange(new object[] { "Salary", "Gifts", "Other" });
            incCatCb.Location = new Point(845, 142);
            incCatCb.Name = "incCatCb";
            incCatCb.Size = new Size(151, 28);
            incCatCb.TabIndex = 48;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(845, 212);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 47;
            label2.Text = "Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(566, 212);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 46;
            label3.Text = "Amount\r\n";
            // 
            // incAmountTb
            // 
            incAmountTb.Location = new Point(566, 245);
            incAmountTb.Name = "incAmountTb";
            incAmountTb.Size = new Size(125, 27);
            incAmountTb.TabIndex = 45;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(845, 110);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 44;
            label4.Text = "Categories";
            // 
            // incDescTb
            // 
            incDescTb.Location = new Point(647, 350);
            incDescTb.Multiline = true;
            incDescTb.Name = "incDescTb";
            incDescTb.Size = new Size(243, 89);
            incDescTb.TabIndex = 43;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(566, 110);
            label5.Name = "label5";
            label5.Size = new Size(102, 20);
            label5.TabIndex = 42;
            label5.Text = "Income Name";
            // 
            // incNameTb
            // 
            incNameTb.Location = new Point(566, 143);
            incNameTb.Name = "incNameTb";
            incNameTb.Size = new Size(125, 27);
            incNameTb.TabIndex = 41;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PaleTurquoise;
            panel2.Controls.Add(TotalIncomeLbl);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(293, 491);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 95);
            panel2.TabIndex = 40;
            // 
            // TotalIncomeLbl
            // 
            TotalIncomeLbl.AutoSize = true;
            TotalIncomeLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TotalIncomeLbl.Location = new Point(58, 49);
            TotalIncomeLbl.Name = "TotalIncomeLbl";
            TotalIncomeLbl.Size = new Size(168, 28);
            TotalIncomeLbl.TabIndex = 26;
            TotalIncomeLbl.Text = "AmountInRupiahs";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(16, 12);
            label7.Name = "label7";
            label7.Size = new Size(134, 28);
            label7.TabIndex = 0;
            label7.Text = "Total Income";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(674, 41);
            label15.Name = "label15";
            label15.Size = new Size(172, 32);
            label15.TabIndex = 27;
            label15.Text = "Income Details";
            label15.TextAlign = ContentAlignment.TopCenter;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.Teal;
            saveBtn.Location = new Point(694, 491);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(152, 29);
            saveBtn.TabIndex = 52;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1337, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 53;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(31, 579);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 79;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Incomes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1383, 633);
            Controls.Add(pictureBox3);
            Controls.Add(saveBtn);
            Controls.Add(label15);
            Controls.Add(label1);
            Controls.Add(incDate);
            Controls.Add(incCatCb);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(incAmountTb);
            Controls.Add(label4);
            Controls.Add(incDescTb);
            Controls.Add(label5);
            Controls.Add(incNameTb);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Incomes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Income";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Label label1;
        private DateTimePicker incDate;
        private ComboBox incCatCb;
        private Label label2;
        private Label label3;
        private TextBox incAmountTb;
        private Label label4;
        private TextBox incDescTb;
        private Label label5;
        private TextBox incNameTb;
        private Panel panel2;
        private Label TotalIncomeLbl;
        private Label label7;
        private Label label15;
        private Button saveBtn;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
    }
}