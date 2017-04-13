namespace BillManager
{
    partial class Main_form
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
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BT_Delete = new System.Windows.Forms.Button();
            this.TB_PersonName = new System.Windows.Forms.TextBox();
            this.TB_BillsName = new System.Windows.Forms.TextBox();
            this.TB_BillCost = new System.Windows.Forms.TextBox();
            this.BT_AddBill = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TB_deletebill = new System.Windows.Forms.TextBox();
            this.BT_printbillList = new System.Windows.Forms.Button();
            this.BT_totalweekcost = new System.Windows.Forms.Button();
            this.BT_TestButton = new System.Windows.Forms.Button();
            this.BT_Testevent = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.readFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(64, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(450, 386);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(750, 55);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(399, 471);
            this.textBox1.TabIndex = 1;
            // 
            // BT_Delete
            // 
            this.BT_Delete.Location = new System.Drawing.Point(976, 639);
            this.BT_Delete.Name = "BT_Delete";
            this.BT_Delete.Size = new System.Drawing.Size(90, 50);
            this.BT_Delete.TabIndex = 2;
            this.BT_Delete.Text = "Delete";
            this.BT_Delete.UseVisualStyleBackColor = true;
            this.BT_Delete.Click += new System.EventHandler(this.BT_Delete_Click);
            // 
            // TB_PersonName
            // 
            this.TB_PersonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_PersonName.Location = new System.Drawing.Point(236, 579);
            this.TB_PersonName.Name = "TB_PersonName";
            this.TB_PersonName.Size = new System.Drawing.Size(100, 29);
            this.TB_PersonName.TabIndex = 3;
            // 
            // TB_BillsName
            // 
            this.TB_BillsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_BillsName.Location = new System.Drawing.Point(109, 579);
            this.TB_BillsName.Name = "TB_BillsName";
            this.TB_BillsName.Size = new System.Drawing.Size(100, 29);
            this.TB_BillsName.TabIndex = 4;
            // 
            // TB_BillCost
            // 
            this.TB_BillCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_BillCost.Location = new System.Drawing.Point(356, 579);
            this.TB_BillCost.Name = "TB_BillCost";
            this.TB_BillCost.Size = new System.Drawing.Size(100, 29);
            this.TB_BillCost.TabIndex = 5;
            // 
            // BT_AddBill
            // 
            this.BT_AddBill.Location = new System.Drawing.Point(236, 471);
            this.BT_AddBill.Name = "BT_AddBill";
            this.BT_AddBill.Size = new System.Drawing.Size(98, 58);
            this.BT_AddBill.TabIndex = 7;
            this.BT_AddBill.Text = "Add Bill";
            this.BT_AddBill.UseVisualStyleBackColor = true;
            this.BT_AddBill.Click += new System.EventHandler(this.BT_AddBill_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 552);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Persons name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 558);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Bills name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 552);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Bills Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 642);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "payment date";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(180, 670);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(198, 20);
            this.dateTimePicker.TabIndex = 13;
            // 
            // TB_deletebill
            // 
            this.TB_deletebill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_deletebill.Location = new System.Drawing.Point(967, 695);
            this.TB_deletebill.Name = "TB_deletebill";
            this.TB_deletebill.Size = new System.Drawing.Size(118, 29);
            this.TB_deletebill.TabIndex = 14;
            // 
            // BT_printbillList
            // 
            this.BT_printbillList.Location = new System.Drawing.Point(835, 639);
            this.BT_printbillList.Name = "BT_printbillList";
            this.BT_printbillList.Size = new System.Drawing.Size(90, 50);
            this.BT_printbillList.TabIndex = 15;
            this.BT_printbillList.Text = "print all bills";
            this.BT_printbillList.UseVisualStyleBackColor = true;
            this.BT_printbillList.Click += new System.EventHandler(this.BT_printbillList_Click);
            // 
            // BT_totalweekcost
            // 
            this.BT_totalweekcost.Location = new System.Drawing.Point(708, 639);
            this.BT_totalweekcost.Name = "BT_totalweekcost";
            this.BT_totalweekcost.Size = new System.Drawing.Size(90, 50);
            this.BT_totalweekcost.TabIndex = 16;
            this.BT_totalweekcost.Text = "total weekley cost";
            this.BT_totalweekcost.UseVisualStyleBackColor = true;
            this.BT_totalweekcost.Click += new System.EventHandler(this.BT_totalweekcost_Click);
            // 
            // BT_TestButton
            // 
            this.BT_TestButton.Location = new System.Drawing.Point(1199, 608);
            this.BT_TestButton.Name = "BT_TestButton";
            this.BT_TestButton.Size = new System.Drawing.Size(90, 50);
            this.BT_TestButton.TabIndex = 19;
            this.BT_TestButton.Text = "TestButton";
            this.BT_TestButton.UseVisualStyleBackColor = true;
            this.BT_TestButton.Click += new System.EventHandler(this.BT_TestButton_Click);
            // 
            // BT_Testevent
            // 
            this.BT_Testevent.Location = new System.Drawing.Point(1199, 678);
            this.BT_Testevent.Name = "BT_Testevent";
            this.BT_Testevent.Size = new System.Drawing.Size(90, 50);
            this.BT_Testevent.TabIndex = 20;
            this.BT_Testevent.Text = "Testevent";
            this.BT_Testevent.UseVisualStyleBackColor = true;
            this.BT_Testevent.Click += new System.EventHandler(this.BT_Testevent_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1494, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.readFromFileToolStripMenuItem,
            this.saveFromFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "FIle";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // readFromFileToolStripMenuItem
            // 
            this.readFromFileToolStripMenuItem.Name = "readFromFileToolStripMenuItem";
            this.readFromFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.readFromFileToolStripMenuItem.Text = "Read from file";
            this.readFromFileToolStripMenuItem.Click += new System.EventHandler(this.readFromFileToolStripMenuItem_Click);
            // 
            // saveFromFileToolStripMenuItem
            // 
            this.saveFromFileToolStripMenuItem.Name = "saveFromFileToolStripMenuItem";
            this.saveFromFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveFromFileToolStripMenuItem.Text = "Save to file";
            this.saveFromFileToolStripMenuItem.Click += new System.EventHandler(this.saveFromFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1494, 849);
            this.Controls.Add(this.BT_Testevent);
            this.Controls.Add(this.BT_TestButton);
            this.Controls.Add(this.BT_totalweekcost);
            this.Controls.Add(this.BT_printbillList);
            this.Controls.Add(this.TB_deletebill);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_AddBill);
            this.Controls.Add(this.TB_BillCost);
            this.Controls.Add(this.TB_BillsName);
            this.Controls.Add(this.TB_PersonName);
            this.Controls.Add(this.BT_Delete);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BT_Delete;
        private System.Windows.Forms.TextBox TB_PersonName;
        private System.Windows.Forms.TextBox TB_BillsName;
        private System.Windows.Forms.TextBox TB_BillCost;
        private System.Windows.Forms.Button BT_AddBill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox TB_deletebill;
        private System.Windows.Forms.Button BT_printbillList;
        private System.Windows.Forms.Button BT_totalweekcost;
        private System.Windows.Forms.Button BT_TestButton;
        private System.Windows.Forms.Button BT_Testevent;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem readFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

