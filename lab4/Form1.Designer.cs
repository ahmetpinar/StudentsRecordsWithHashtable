namespace lab4
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtStudentNo = new System.Windows.Forms.TextBox();
            this.lblStudentNo = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchHashValue = new System.Windows.Forms.TextBox();
            this.lblSearchHashValue = new System.Windows.Forms.Label();
            this.txtSearchHashKey = new System.Windows.Forms.TextBox();
            this.lblSearchHashKey = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtDeleteHashValue = new System.Windows.Forms.TextBox();
            this.lblDeleteHashValue = new System.Windows.Forms.Label();
            this.txtDeleteHashKey = new System.Windows.Forms.TextBox();
            this.lblDeleteHashKey = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnListByYear = new System.Windows.Forms.Button();
            this.txtRange = new System.Windows.Forms.TextBox();
            this.lblRange = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtStudentNo);
            this.groupBox1.Controls.Add(this.lblStudentNo);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "STUDENT INFORMATION";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(130, 77);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(122, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtStudentNo
            // 
            this.txtStudentNo.Location = new System.Drawing.Point(109, 51);
            this.txtStudentNo.Name = "txtStudentNo";
            this.txtStudentNo.Size = new System.Drawing.Size(143, 20);
            this.txtStudentNo.TabIndex = 3;
            this.txtStudentNo.TextChanged += new System.EventHandler(this.txtStudentNo_TextChanged);
            // 
            // lblStudentNo
            // 
            this.lblStudentNo.AutoSize = true;
            this.lblStudentNo.Location = new System.Drawing.Point(7, 51);
            this.lblStudentNo.Name = "lblStudentNo";
            this.lblStudentNo.Size = new System.Drawing.Size(61, 13);
            this.lblStudentNo.TabIndex = 2;
            this.lblStudentNo.Text = "Student No";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(109, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(143, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name/Surname";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.txtSearchHashValue);
            this.groupBox2.Controls.Add(this.lblSearchHashValue);
            this.groupBox2.Controls.Add(this.txtSearchHashKey);
            this.groupBox2.Controls.Add(this.lblSearchHashKey);
            this.groupBox2.Location = new System.Drawing.Point(25, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 110);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SEARCH";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(130, 77);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(122, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchHashValue
            // 
            this.txtSearchHashValue.Location = new System.Drawing.Point(109, 51);
            this.txtSearchHashValue.Name = "txtSearchHashValue";
            this.txtSearchHashValue.Size = new System.Drawing.Size(143, 20);
            this.txtSearchHashValue.TabIndex = 3;
            // 
            // lblSearchHashValue
            // 
            this.lblSearchHashValue.AutoSize = true;
            this.lblSearchHashValue.Location = new System.Drawing.Point(7, 51);
            this.lblSearchHashValue.Name = "lblSearchHashValue";
            this.lblSearchHashValue.Size = new System.Drawing.Size(62, 13);
            this.lblSearchHashValue.TabIndex = 2;
            this.lblSearchHashValue.Text = "Hash Value";
            // 
            // txtSearchHashKey
            // 
            this.txtSearchHashKey.Location = new System.Drawing.Point(109, 20);
            this.txtSearchHashKey.Name = "txtSearchHashKey";
            this.txtSearchHashKey.Size = new System.Drawing.Size(143, 20);
            this.txtSearchHashKey.TabIndex = 1;
            // 
            // lblSearchHashKey
            // 
            this.lblSearchHashKey.AutoSize = true;
            this.lblSearchHashKey.Location = new System.Drawing.Point(7, 20);
            this.lblSearchHashKey.Name = "lblSearchHashKey";
            this.lblSearchHashKey.Size = new System.Drawing.Size(53, 13);
            this.lblSearchHashKey.TabIndex = 0;
            this.lblSearchHashKey.Text = "Hash Key";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.txtDeleteHashValue);
            this.groupBox3.Controls.Add(this.lblDeleteHashValue);
            this.groupBox3.Controls.Add(this.txtDeleteHashKey);
            this.groupBox3.Controls.Add(this.lblDeleteHashKey);
            this.groupBox3.Location = new System.Drawing.Point(25, 256);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(270, 110);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DELETE";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(130, 77);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtDeleteHashValue
            // 
            this.txtDeleteHashValue.Location = new System.Drawing.Point(109, 51);
            this.txtDeleteHashValue.Name = "txtDeleteHashValue";
            this.txtDeleteHashValue.Size = new System.Drawing.Size(143, 20);
            this.txtDeleteHashValue.TabIndex = 3;
            // 
            // lblDeleteHashValue
            // 
            this.lblDeleteHashValue.AutoSize = true;
            this.lblDeleteHashValue.Location = new System.Drawing.Point(7, 51);
            this.lblDeleteHashValue.Name = "lblDeleteHashValue";
            this.lblDeleteHashValue.Size = new System.Drawing.Size(62, 13);
            this.lblDeleteHashValue.TabIndex = 2;
            this.lblDeleteHashValue.Text = "Hash Value";
            // 
            // txtDeleteHashKey
            // 
            this.txtDeleteHashKey.Location = new System.Drawing.Point(109, 20);
            this.txtDeleteHashKey.Name = "txtDeleteHashKey";
            this.txtDeleteHashKey.Size = new System.Drawing.Size(143, 20);
            this.txtDeleteHashKey.TabIndex = 1;
            // 
            // lblDeleteHashKey
            // 
            this.lblDeleteHashKey.AutoSize = true;
            this.lblDeleteHashKey.Location = new System.Drawing.Point(7, 20);
            this.lblDeleteHashKey.Name = "lblDeleteHashKey";
            this.lblDeleteHashKey.Size = new System.Drawing.Size(53, 13);
            this.lblDeleteHashKey.TabIndex = 0;
            this.lblDeleteHashKey.Text = "Hash Key";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnListByYear);
            this.groupBox4.Controls.Add(this.txtRange);
            this.groupBox4.Controls.Add(this.lblRange);
            this.groupBox4.Location = new System.Drawing.Point(25, 372);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(270, 83);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "LIST BY YEAR";
            // 
            // btnListByYear
            // 
            this.btnListByYear.Location = new System.Drawing.Point(130, 49);
            this.btnListByYear.Name = "btnListByYear";
            this.btnListByYear.Size = new System.Drawing.Size(122, 23);
            this.btnListByYear.TabIndex = 4;
            this.btnListByYear.Text = "List";
            this.btnListByYear.UseVisualStyleBackColor = true;
            this.btnListByYear.Click += new System.EventHandler(this.btnListByYear_Click);
            // 
            // txtRange
            // 
            this.txtRange.Location = new System.Drawing.Point(109, 20);
            this.txtRange.Name = "txtRange";
            this.txtRange.Size = new System.Drawing.Size(143, 20);
            this.txtRange.TabIndex = 1;
            // 
            // lblRange
            // 
            this.lblRange.AutoSize = true;
            this.lblRange.Location = new System.Drawing.Point(7, 20);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new System.Drawing.Size(67, 13);
            this.lblRange.TabIndex = 0;
            this.lblRange.Text = "Enter Range";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(320, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(298, 381);
            this.listBox1.TabIndex = 6;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(470, 413);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(148, 31);
            this.btnDisplay.TabIndex = 7;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 464);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtStudentNo;
        private System.Windows.Forms.Label lblStudentNo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchHashValue;
        private System.Windows.Forms.Label lblSearchHashValue;
        private System.Windows.Forms.TextBox txtSearchHashKey;
        private System.Windows.Forms.Label lblSearchHashKey;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtDeleteHashValue;
        private System.Windows.Forms.Label lblDeleteHashValue;
        private System.Windows.Forms.TextBox txtDeleteHashKey;
        private System.Windows.Forms.Label lblDeleteHashKey;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnListByYear;
        private System.Windows.Forms.TextBox txtRange;
        private System.Windows.Forms.Label lblRange;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnDisplay;
    }
}

