namespace Monager
{
    partial class ViewIncomes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewIncomes));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            label15 = new Label();
            IncomeDGV = new DataGridView();
            pictureBox3 = new PictureBox();
            IncomeSearchBtn = new Button();
            IncomeCatCb = new ComboBox();
            label11 = new Label();
            label12 = new Label();
            IncomeNameTb = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IncomeDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 633);
            panel1.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(31, 579);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 77;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkSlateGray;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(41, 345);
            label1.Name = "label1";
            label1.Size = new Size(111, 32);
            label1.TabIndex = 6;
            label1.Text = "Expenses";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(41, 460);
            label2.Name = "label2";
            label2.Size = new Size(169, 32);
            label2.TabIndex = 5;
            label2.Text = "View Expenses";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Teal;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(41, 403);
            label3.Name = "label3";
            label3.Size = new Size(151, 32);
            label3.TabIndex = 4;
            label3.Text = "View Income";
            label3.TextAlign = ContentAlignment.TopCenter;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.DarkSlateGray;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(41, 288);
            label5.Name = "label5";
            label5.Size = new Size(103, 32);
            label5.TabIndex = 2;
            label5.Text = "Incomes";
            label5.TextAlign = ContentAlignment.TopCenter;
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(41, 212);
            label6.Name = "label6";
            label6.Size = new Size(129, 32);
            label6.TabIndex = 1;
            label6.Text = "Dashboard";
            label6.TextAlign = ContentAlignment.TopCenter;
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Perpetua Titling MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(31, 19);
            label7.Name = "label7";
            label7.Size = new Size(184, 36);
            label7.TabIndex = 0;
            label7.Text = "Monager";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(0, 390);
            panel2.Name = "panel2";
            panel2.Size = new Size(249, 59);
            panel2.TabIndex = 7;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(708, 69);
            label15.Name = "label15";
            label15.Size = new Size(151, 32);
            label15.TabIndex = 53;
            label15.Text = "View Income";
            label15.TextAlign = ContentAlignment.TopCenter;
            // 
            // IncomeDGV
            // 
            IncomeDGV.BackgroundColor = Color.MintCream;
            IncomeDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            IncomeDGV.GridColor = Color.LightCyan;
            IncomeDGV.Location = new Point(271, 210);
            IncomeDGV.Name = "IncomeDGV";
            IncomeDGV.RowHeadersWidth = 51;
            IncomeDGV.RowTemplate.Height = 29;
            IncomeDGV.Size = new Size(1091, 407);
            IncomeDGV.TabIndex = 62;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1337, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 63;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // IncomeSearchBtn
            // 
            IncomeSearchBtn.Location = new Point(1115, 145);
            IncomeSearchBtn.Name = "IncomeSearchBtn";
            IncomeSearchBtn.Size = new Size(94, 29);
            IncomeSearchBtn.TabIndex = 76;
            IncomeSearchBtn.Text = "Search";
            IncomeSearchBtn.UseVisualStyleBackColor = true;
            IncomeSearchBtn.Click += IncomeSearchBtn_Click_1;
            // 
            // IncomeCatCb
            // 
            IncomeCatCb.FormattingEnabled = true;
            IncomeCatCb.Items.AddRange(new object[] { "Salary", "Gifts", "Other" });
            IncomeCatCb.Location = new Point(880, 145);
            IncomeCatCb.Name = "IncomeCatCb";
            IncomeCatCb.Size = new Size(151, 28);
            IncomeCatCb.TabIndex = 75;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(746, 145);
            label11.Name = "label11";
            label11.Size = new Size(80, 20);
            label11.TabIndex = 74;
            label11.Text = "Categories";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(410, 142);
            label12.Name = "label12";
            label12.Size = new Size(107, 20);
            label12.TabIndex = 73;
            label12.Text = "Expense Name";
            // 
            // IncomeNameTb
            // 
            IncomeNameTb.Location = new Point(547, 142);
            IncomeNameTb.Name = "IncomeNameTb";
            IncomeNameTb.Size = new Size(125, 27);
            IncomeNameTb.TabIndex = 72;
            // 
            // ViewIncomes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1383, 633);
            Controls.Add(IncomeSearchBtn);
            Controls.Add(IncomeCatCb);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(IncomeNameTb);
            Controls.Add(pictureBox3);
            Controls.Add(IncomeDGV);
            Controls.Add(label15);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewIncomes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewIncomes";
            Load += ViewIncomes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)IncomeDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel panel2;
        private Label label15;
        private DataGridView IncomeDGV;
        private PictureBox pictureBox3;
        private Button IncomeSearchBtn;
        private ComboBox IncomeCatCb;
        private Label label11;
        private Label label12;
        private TextBox IncomeNameTb;
        private PictureBox pictureBox1;
    }
}