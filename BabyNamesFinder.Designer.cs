namespace BabyNames
{
    partial class BabyNamesFinder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, 

false.</param>
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Gender";
            // 
            // cboGender
            // 
            this.cboGender.DropDownStyle = 

System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Both"});
            this.cboGender.Location = new System.Drawing.Point(81, 69);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(140, 21);
            this.cboGender.TabIndex = 1;
            // 
            // cboYear
            // 
            this.cboYear.DropDownStyle = 

System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(257, 69);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(140, 21);
            this.cboYear.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select the Year";
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = 

System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "10",
            "20",
            "50",
            "100"});
            this.cboType.Location = new System.Drawing.Point(451, 69);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(140, 21);
            this.cboType.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(462, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Top Name Selection Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Top Baby Names Filtered";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, 

System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(46, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(284, 44);
            this.button1.TabIndex = 8;
            this.button1.Text = "List The Top Names";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(224, 229);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(227, 186);
            this.listBox1.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, 

System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(336, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(284, 44);
            this.button2.TabIndex = 10;
            this.button2.Text = "View Year wise Graphical Anaysis";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BabyNamesFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 460);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboGender);
            this.Controls.Add(this.label1);
            this.Name = "BabyNamesFinder";
            this.Text = "Top Baby Name Finder Tool";
            this.Load += new System.EventHandler(this.BabyNamesFinder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
    }
}

