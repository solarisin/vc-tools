namespace VCTools
{
    partial class StripAlphabetsForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StripAlphabetsForm));
			this.button_Strip = new System.Windows.Forms.Button();
			this.textBox_Alphabets = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel_Tabs = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox_IC = new System.Windows.Forms.TextBox();
			this.textBox_AvgIC = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button_Strip
			// 
			this.button_Strip.Location = new System.Drawing.Point(15, 51);
			this.button_Strip.Name = "button_Strip";
			this.button_Strip.Size = new System.Drawing.Size(75, 23);
			this.button_Strip.TabIndex = 0;
			this.button_Strip.Text = "Strip";
			this.button_Strip.UseVisualStyleBackColor = true;
			this.button_Strip.Click += new System.EventHandler(this.button_Strip_Click);
			// 
			// textBox_Alphabets
			// 
			this.textBox_Alphabets.Location = new System.Drawing.Point(15, 25);
			this.textBox_Alphabets.Name = "textBox_Alphabets";
			this.textBox_Alphabets.Size = new System.Drawing.Size(75, 20);
			this.textBox_Alphabets.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Alphabets to Strip";
			// 
			// panel_Tabs
			// 
			this.panel_Tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel_Tabs.Location = new System.Drawing.Point(108, 12);
			this.panel_Tabs.Name = "panel_Tabs";
			this.panel_Tabs.Size = new System.Drawing.Size(464, 273);
			this.panel_Tabs.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 143);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Average I.C";
			// 
			// textBox_IC
			// 
			this.textBox_IC.Location = new System.Drawing.Point(15, 114);
			this.textBox_IC.Name = "textBox_IC";
			this.textBox_IC.ReadOnly = true;
			this.textBox_IC.Size = new System.Drawing.Size(75, 20);
			this.textBox_IC.TabIndex = 5;
			// 
			// textBox_AvgIC
			// 
			this.textBox_AvgIC.Location = new System.Drawing.Point(15, 159);
			this.textBox_AvgIC.Name = "textBox_AvgIC";
			this.textBox_AvgIC.ReadOnly = true;
			this.textBox_AvgIC.Size = new System.Drawing.Size(75, 20);
			this.textBox_AvgIC.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 98);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(20, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "I.C";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 205);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(86, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "English ≈ 0.0656";
			// 
			// StripAlphabetsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 297);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox_AvgIC);
			this.Controls.Add(this.textBox_IC);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel_Tabs);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox_Alphabets);
			this.Controls.Add(this.button_Strip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(432, 207);
			this.Name = "StripAlphabetsForm";
			this.Text = "Strip Alphabets";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Strip;
        private System.Windows.Forms.TextBox textBox_Alphabets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_Tabs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_IC;
        private System.Windows.Forms.TextBox textBox_AvgIC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}