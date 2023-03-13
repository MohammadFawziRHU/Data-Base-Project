namespace Data_Base_Project.Forms
{
    partial class Form_DashBoard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DashBoard));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnViewSales = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.panelSide = new System.Windows.Forms.Panel();
            this.btnExpenses = new System.Windows.Forms.Button();
            this.btnPurchaseItems = new System.Windows.Forms.Button();
            this.btnSaleBooks = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.panelLeft.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panelLeft.Controls.Add(this.btnSettings);
            this.panelLeft.Controls.Add(this.btnViewSales);
            this.panelLeft.Controls.Add(this.btnUsers);
            this.panelLeft.Controls.Add(this.panelSide);
            this.panelLeft.Controls.Add(this.btnExpenses);
            this.panelLeft.Controls.Add(this.btnPurchaseItems);
            this.panelLeft.Controls.Add(this.btnSaleBooks);
            this.panelLeft.Controls.Add(this.btnHome);
            this.panelLeft.Controls.Add(this.panel3);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(218, 720);
            this.panelLeft.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 500);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(218, 60);
            this.btnSettings.TabIndex = 9;
            this.btnSettings.Text = "   Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnViewSales
            // 
            this.btnViewSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewSales.FlatAppearance.BorderSize = 0;
            this.btnViewSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewSales.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnViewSales.ForeColor = System.Drawing.Color.White;
            this.btnViewSales.Image = ((System.Drawing.Image)(resources.GetObject("btnViewSales.Image")));
            this.btnViewSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewSales.Location = new System.Drawing.Point(0, 440);
            this.btnViewSales.Name = "btnViewSales";
            this.btnViewSales.Size = new System.Drawing.Size(218, 60);
            this.btnViewSales.TabIndex = 8;
            this.btnViewSales.Text = "     View Sales";
            this.btnViewSales.UseVisualStyleBackColor = true;
            this.btnViewSales.Click += new System.EventHandler(this.btnViewSales_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnUsers.Image")));
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(0, 380);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(218, 60);
            this.btnUsers.TabIndex = 7;
            this.btnUsers.Text = "  Users";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnusers_Click);
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.White;
            this.panelSide.Location = new System.Drawing.Point(0, 140);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(7, 56);
            this.panelSide.TabIndex = 3;
            this.panelSide.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // btnExpenses
            // 
            this.btnExpenses.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExpenses.FlatAppearance.BorderSize = 0;
            this.btnExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpenses.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExpenses.ForeColor = System.Drawing.Color.White;
            this.btnExpenses.Image = ((System.Drawing.Image)(resources.GetObject("btnExpenses.Image")));
            this.btnExpenses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpenses.Location = new System.Drawing.Point(0, 320);
            this.btnExpenses.Name = "btnExpenses";
            this.btnExpenses.Size = new System.Drawing.Size(218, 60);
            this.btnExpenses.TabIndex = 6;
            this.btnExpenses.Text = "     Expenses";
            this.btnExpenses.UseVisualStyleBackColor = true;
            this.btnExpenses.Click += new System.EventHandler(this.btnExpenses_Click);
            // 
            // btnPurchaseItems
            // 
            this.btnPurchaseItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPurchaseItems.FlatAppearance.BorderSize = 0;
            this.btnPurchaseItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchaseItems.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPurchaseItems.ForeColor = System.Drawing.Color.White;
            this.btnPurchaseItems.Image = ((System.Drawing.Image)(resources.GetObject("btnPurchaseItems.Image")));
            this.btnPurchaseItems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurchaseItems.Location = new System.Drawing.Point(0, 260);
            this.btnPurchaseItems.Name = "btnPurchaseItems";
            this.btnPurchaseItems.Size = new System.Drawing.Size(218, 60);
            this.btnPurchaseItems.TabIndex = 5;
            this.btnPurchaseItems.Text = "      Purchase Items";
            this.btnPurchaseItems.UseVisualStyleBackColor = true;
            this.btnPurchaseItems.Click += new System.EventHandler(this.btnPurchaseItems_Click);
            // 
            // btnSaleBooks
            // 
            this.btnSaleBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSaleBooks.FlatAppearance.BorderSize = 0;
            this.btnSaleBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaleBooks.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaleBooks.ForeColor = System.Drawing.Color.White;
            this.btnSaleBooks.Image = ((System.Drawing.Image)(resources.GetObject("btnSaleBooks.Image")));
            this.btnSaleBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaleBooks.Location = new System.Drawing.Point(0, 200);
            this.btnSaleBooks.Name = "btnSaleBooks";
            this.btnSaleBooks.Size = new System.Drawing.Size(218, 60);
            this.btnSaleBooks.TabIndex = 4;
            this.btnSaleBooks.Text = "     Sale Books";
            this.btnSaleBooks.UseVisualStyleBackColor = true;
            this.btnSaleBooks.Click += new System.EventHandler(this.btnSaleBooks_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 140);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(218, 60);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(218, 140);
            this.panel3.TabIndex = 1;
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(161, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(49, 56);
            this.button8.TabIndex = 3;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(38, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lebanon Beirut";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "North Books Shop";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(70, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(218, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(982, 62);
            this.panel2.TabIndex = 1;
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Right;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.Location = new System.Drawing.Point(919, 0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(63, 62);
            this.button9.TabIndex = 4;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(6, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(343, 46);
            this.label4.TabIndex = 3;
            this.label4.Text = "North Books Shop,NLI Markit Beirut\r\n\r\n";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel4.Controls.Add(this.labelTime);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(218, 62);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(982, 114);
            this.panel4.TabIndex = 2;
            // 
            // labelTime
            // 
            this.labelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(807, 55);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(106, 23);
            this.labelTime.TabIndex = 4;
            this.labelTime.Text = "HH:MM:SS";
            this.labelTime.Click += new System.EventHandler(this.labelTime_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(180, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Admin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(115, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "Role:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(180, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mohammd Fawzi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(64, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // Form_DashBoard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelLeft);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_DashBoard";
            this.Text = "Form_DashBoard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelLeft.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelLeft;
        private Button btnHome;
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panelSide;
        private Label label3;
        private Button btnSettings;
        private Button btnViewSales;
        private Button btnUsers;
        private Button btnExpenses;
        private Button btnPurchaseItems;
        private Button btnSaleBooks;
        private Label label4;
        private Button button8;
        private Label label5;
        private Button button9;
        private Label label6;
        private Label label7;
        private Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerTime;
    }
}