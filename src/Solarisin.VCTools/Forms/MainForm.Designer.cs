namespace Solarisin.VCTools.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textBox_Message = new System.Windows.Forms.TextBox();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Count = new System.Windows.Forms.Button();
            this.button_EncipherDecipher = new System.Windows.Forms.Button();
            this.button_StripAlphabets = new System.Windows.Forms.Button();
            this.button_Sliding = new System.Windows.Forms.Button();
            this.button_Friedman = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Message
            // 
            this.textBox_Message.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Message.Location = new System.Drawing.Point(138, 12);
            this.textBox_Message.Multiline = true;
            this.textBox_Message.Name = "textBox_Message";
            this.textBox_Message.Size = new System.Drawing.Size(334, 168);
            this.textBox_Message.TabIndex = 1;
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(12, 157);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(120, 23);
            this.button_Clear.TabIndex = 2;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.Button_Clear_Click);
            // 
            // button_Count
            // 
            this.button_Count.Location = new System.Drawing.Point(12, 12);
            this.button_Count.Name = "button_Count";
            this.button_Count.Size = new System.Drawing.Size(120, 23);
            this.button_Count.TabIndex = 2;
            this.button_Count.Text = "Frequency Count";
            this.button_Count.UseVisualStyleBackColor = true;
            this.button_Count.Click += new System.EventHandler(this.Button_Count_Click);
            // 
            // button_EncipherDecipher
            // 
            this.button_EncipherDecipher.Location = new System.Drawing.Point(12, 99);
            this.button_EncipherDecipher.Name = "button_EncipherDecipher";
            this.button_EncipherDecipher.Size = new System.Drawing.Size(119, 23);
            this.button_EncipherDecipher.TabIndex = 3;
            this.button_EncipherDecipher.Text = "Encipher/Decipher";
            this.button_EncipherDecipher.UseVisualStyleBackColor = true;
            this.button_EncipherDecipher.Click += new System.EventHandler(this.Button_EncipherDecipher_Click);
            // 
            // button_StripAlphabets
            // 
            this.button_StripAlphabets.Location = new System.Drawing.Point(12, 70);
            this.button_StripAlphabets.Name = "button_StripAlphabets";
            this.button_StripAlphabets.Size = new System.Drawing.Size(119, 23);
            this.button_StripAlphabets.TabIndex = 4;
            this.button_StripAlphabets.Text = "Strip Alphabets";
            this.button_StripAlphabets.UseVisualStyleBackColor = true;
            this.button_StripAlphabets.Click += new System.EventHandler(this.Button_StripAlphabets_Click);
            // 
            // button_Sliding
            // 
            this.button_Sliding.Location = new System.Drawing.Point(12, 41);
            this.button_Sliding.Name = "button_Sliding";
            this.button_Sliding.Size = new System.Drawing.Size(119, 23);
            this.button_Sliding.TabIndex = 5;
            this.button_Sliding.Text = "Sliding";
            this.button_Sliding.UseVisualStyleBackColor = true;
            this.button_Sliding.Click += new System.EventHandler(this.Button_Sliding_Click);
            // 
            // button_Friedman
            // 
            this.button_Friedman.Location = new System.Drawing.Point(12, 128);
            this.button_Friedman.Name = "button_Friedman";
            this.button_Friedman.Size = new System.Drawing.Size(119, 23);
            this.button_Friedman.TabIndex = 6;
            this.button_Friedman.Text = "Calculate I.C.";
            this.button_Friedman.UseVisualStyleBackColor = true;
            this.button_Friedman.Click += new System.EventHandler(this.Button_Friedman_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 192);
            this.Controls.Add(this.button_Friedman);
            this.Controls.Add(this.button_Sliding);
            this.Controls.Add(this.button_StripAlphabets);
            this.Controls.Add(this.button_EncipherDecipher);
            this.Controls.Add(this.button_Count);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.textBox_Message);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(500, 230);
            this.MinimumSize = new System.Drawing.Size(500, 230);
            this.Name = "MainForm";
            this.Text = "VCTools by Rob Longbottom";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Message;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Count;
        private System.Windows.Forms.Button button_EncipherDecipher;
        private System.Windows.Forms.Button button_StripAlphabets;
        private System.Windows.Forms.Button button_Sliding;
        private System.Windows.Forms.Button button_Friedman;
    }
}

