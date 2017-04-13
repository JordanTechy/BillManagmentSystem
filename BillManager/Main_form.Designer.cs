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
            this.TB_SaveToFile = new System.Windows.Forms.Button();
            this.BT_ReadFile = new System.Windows.Forms.Button();
            this.BT_TestButton = new System.Windows.Forms.Button();
            this.BT_Testevent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(62, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(450, 386);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(772, 57);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(399, 471);
            this.textBox1.TabIndex = 1;
            // 
            // BT_Delete
            // 
            this.BT_Delete.Location = new System.Drawing.Point(1050, 540);
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
            this.TB_PersonName.Location = new System.Drawing.Point(126, 561);
            this.TB_PersonName.Name = "TB_PersonName";
            this.TB_PersonName.Size = new System.Drawing.Size(100, 29);
            this.TB_PersonName.TabIndex = 3;
            // 
            // TB_BillsName
            // 
            this.TB_BillsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_BillsName.Location = new System.Drawing.Point(252, 561);
            this.TB_BillsName.Name = "TB_BillsName";
            this.TB_BillsName.Size = new System.Drawing.Size(100, 29);
            this.TB_BillsName.TabIndex = 4;
            // 
            // TB_BillCost
            // 
            this.TB_BillCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_BillCost.Location = new System.Drawing.Point(372, 561);
            this.TB_BillCost.Name = "TB_BillCost";
            this.TB_BillCost.Size = new System.Drawing.Size(100, 29);
            this.TB_BillCost.TabIndex = 5;
            // 
            // BT_AddBill
            // 
            this.BT_AddBill.Location = new System.Drawing.Point(236, 444);
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
            this.label1.Location = new System.Drawing.Point(135, 534);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Persons name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 534);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Bills name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 534);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Bills Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 624);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "payment date";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(178, 652);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(198, 20);
            this.dateTimePicker.TabIndex = 13;
            // 
            // TB_deletebill
            // 
            this.TB_deletebill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_deletebill.Location = new System.Drawing.Point(1041, 596);
            this.TB_deletebill.Name = "TB_deletebill";
            this.TB_deletebill.Size = new System.Drawing.Size(118, 29);
            this.TB_deletebill.TabIndex = 14;
            // 
            // BT_printbillList
            // 
            this.BT_printbillList.Location = new System.Drawing.Point(909, 540);
            this.BT_printbillList.Name = "BT_printbillList";
            this.BT_printbillList.Size = new System.Drawing.Size(90, 50);
            this.BT_printbillList.TabIndex = 15;
            this.BT_printbillList.Text = "print all bills";
            this.BT_printbillList.UseVisualStyleBackColor = true;
            this.BT_printbillList.Click += new System.EventHandler(this.BT_printbillList_Click);
            // 
            // BT_totalweekcost
            // 
            this.BT_totalweekcost.Location = new System.Drawing.Point(782, 540);
            this.BT_totalweekcost.Name = "BT_totalweekcost";
            this.BT_totalweekcost.Size = new System.Drawing.Size(90, 50);
            this.BT_totalweekcost.TabIndex = 16;
            this.BT_totalweekcost.Text = "total weekley cost";
            this.BT_totalweekcost.UseVisualStyleBackColor = true;
            this.BT_totalweekcost.Click += new System.EventHandler(this.BT_totalweekcost_Click);
            // 
            // TB_SaveToFile
            // 
            this.TB_SaveToFile.Location = new System.Drawing.Point(579, 192);
            this.TB_SaveToFile.Name = "TB_SaveToFile";
            this.TB_SaveToFile.Size = new System.Drawing.Size(90, 50);
            this.TB_SaveToFile.TabIndex = 17;
            this.TB_SaveToFile.Text = "Save to file";
            this.TB_SaveToFile.UseVisualStyleBackColor = true;
            this.TB_SaveToFile.Click += new System.EventHandler(this.TB_SaveToFile_Click);
            // 
            // BT_ReadFile
            // 
            this.BT_ReadFile.Location = new System.Drawing.Point(579, 277);
            this.BT_ReadFile.Name = "BT_ReadFile";
            this.BT_ReadFile.Size = new System.Drawing.Size(90, 50);
            this.BT_ReadFile.TabIndex = 18;
            this.BT_ReadFile.Text = "Read from file";
            this.BT_ReadFile.UseVisualStyleBackColor = true;
            this.BT_ReadFile.Click += new System.EventHandler(this.BT_ReadFile_Click);
            // 
            // BT_TestButton
            // 
            this.BT_TestButton.Location = new System.Drawing.Point(579, 534);
            this.BT_TestButton.Name = "BT_TestButton";
            this.BT_TestButton.Size = new System.Drawing.Size(90, 50);
            this.BT_TestButton.TabIndex = 19;
            this.BT_TestButton.Text = "TestButton";
            this.BT_TestButton.UseVisualStyleBackColor = true;
            this.BT_TestButton.Click += new System.EventHandler(this.BT_TestButton_Click);
            // 
            // BT_Testevent
            // 
            this.BT_Testevent.Location = new System.Drawing.Point(579, 604);
            this.BT_Testevent.Name = "BT_Testevent";
            this.BT_Testevent.Size = new System.Drawing.Size(90, 50);
            this.BT_Testevent.TabIndex = 20;
            this.BT_Testevent.Text = "Testevent";
            this.BT_Testevent.UseVisualStyleBackColor = true;
            this.BT_Testevent.Click += new System.EventHandler(this.BT_Testevent_Click);
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1494, 849);
            this.Controls.Add(this.BT_Testevent);
            this.Controls.Add(this.BT_TestButton);
            this.Controls.Add(this.BT_ReadFile);
            this.Controls.Add(this.TB_SaveToFile);
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
            this.Name = "Main_form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button TB_SaveToFile;
        private System.Windows.Forms.Button BT_ReadFile;
        private System.Windows.Forms.Button BT_TestButton;
        private System.Windows.Forms.Button BT_Testevent;
    }
}

