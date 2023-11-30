namespace Monager
{
    partial class ViewExpenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewExpenses));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            ExpenseDGV = new DataGridView();
            label15 = new Label();
            ExpenseCatCb = new ComboBox();
            label11 = new Label();
            label12 = new Label();
            ExpenseNameTb = new TextBox();
            pictureBox3 = new PictureBox();
            ExpenseSearchBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ExpenseDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 633);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(31, 579);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 80;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.DarkSlateGray;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(41, 345);
            label7.Name = "label7";
            label7.Size = new Size(111, 32);
            label7.TabIndex = 6;
            label7.Text = "Expenses";
            label7.TextAlign = ContentAlignment.TopCenter;
            label7.Click += label7_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Teal;
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
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(1, 448);
            panel2.Name = "panel2";
            panel2.Size = new Size(249, 59);
            panel2.TabIndex = 7;
            // 
            // ExpenseDGV
            // 
            ExpenseDGV.BackgroundColor = Color.MintCream;
            ExpenseDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ExpenseDGV.GridColor = Color.LightCyan;
            ExpenseDGV.Location = new Point(271, 210);
            ExpenseDGV.Name = "ExpenseDGV";
            ExpenseDGV.RowHeadersWidth = 51;
            ExpenseDGV.RowTemplate.Height = 29;
            ExpenseDGV.Size = new Size(1091, 407);
            ExpenseDGV.TabIndex = 68;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(708, 69);
            label15.Name = "label15";
            label15.Size = new Size(169, 32);
            label15.TabIndex = 63;
            label15.Text = "View Expenses";
            label15.TextAlign = ContentAlignment.TopCenter;
            // 
            // ExpenseCatCb
            // 
            ExpenseCatCb.FormattingEnabled = true;
            ExpenseCatCb.Items.AddRange(new object[] { "Food", "College", "Travel", "Other" });
            ExpenseCatCb.Location = new Point(881, 144);
            ExpenseCatCb.Name = "ExpenseCatCb";
            ExpenseCatCb.Size = new Size(151, 28);
            ExpenseCatCb.TabIndex = 67;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(747, 144);
            label11.Name = "label11";
            label11.Size = new Size(80, 20);
            label11.TabIndex = 66;
            label11.Text = "Categories";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(411, 141);
            label12.Name = "label12";
            label12.Size = new Size(107, 20);
            label12.TabIndex = 65;
            label12.Text = "Expense Name";
            // 
            // ExpenseNameTb
            // 
            ExpenseNameTb.Location = new Point(548, 141);
            ExpenseNameTb.Name = "ExpenseNameTb";
            ExpenseNameTb.Size = new Size(125, 27);
            ExpenseNameTb.TabIndex = 64;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1337, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 69;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // ExpenseSearchBtn
            // 
            ExpenseSearchBtn.Location = new Point(1116, 144);
            ExpenseSearchBtn.Name = "ExpenseSearchBtn";
            ExpenseSearchBtn.Size = new Size(94, 29);
            ExpenseSearchBtn.TabIndex = 71;
            ExpenseSearchBtn.Text = "Search";
            ExpenseSearchBtn.UseVisualStyleBackColor = true;
            ExpenseSearchBtn.Click += ExpenseSearchBtn_Click;
            // 
            // ViewExpenses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1383, 633);
            Controls.Add(ExpenseSearchBtn);
            Controls.Add(pictureBox3);
            Controls.Add(ExpenseDGV);
            Controls.Add(label15);
            Controls.Add(ExpenseCatCb);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(ExpenseNameTb);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewExpenses";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewExpenses";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ExpenseDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label7;
        private Label label5;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private DataGridView ExpenseDGV;
        private Label label15;
        private ComboBox ExpenseCatCb;
        private Label label11;
        private Label label12;
        private TextBox ExpenseNameTb;
        private PictureBox pictureBox3;
        private Button ExpenseSearchBtn;
        private PictureBox pictureBox1;
    }
}