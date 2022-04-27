namespace Solarisin.VCTools.Forms
{
    partial class SlidingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SlidingForm));
            this.richTextBox_Messages = new System.Windows.Forms.RichTextBox();
            this.button_SlideRight = new System.Windows.Forms.Button();
            this.button_SlideLeft = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_CurrentIndex = new System.Windows.Forms.Label();
            this.label_DuplicateCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox_Messages
            // 
            this.richTextBox_Messages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_Messages.Location = new System.Drawing.Point(48, 12);
            this.richTextBox_Messages.Multiline = false;
            this.richTextBox_Messages.Name = "richTextBox_Messages";
            this.richTextBox_Messages.Size = new System.Drawing.Size(488, 82);
            this.richTextBox_Messages.TabIndex = 0;
            this.richTextBox_Messages.Text = "";
            this.richTextBox_Messages.WordWrap = false;
            // 
            // button_SlideRight
            // 
            this.button_SlideRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_SlideRight.Location = new System.Drawing.Point(542, 12);
            this.button_SlideRight.Name = "button_SlideRight";
            this.button_SlideRight.Size = new System.Drawing.Size(30, 82);
            this.button_SlideRight.TabIndex = 1;
            this.button_SlideRight.Text = ">";
            this.button_SlideRight.UseVisualStyleBackColor = true;
            this.button_SlideRight.Click += new System.EventHandler(this.button_SlideRight_Click);
            // 
            // button_SlideLeft
            // 
            this.button_SlideLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button_SlideLeft.Location = new System.Drawing.Point(12, 12);
            this.button_SlideLeft.Name = "button_SlideLeft";
            this.button_SlideLeft.Size = new System.Drawing.Size(30, 82);
            this.button_SlideLeft.TabIndex = 1;
            this.button_SlideLeft.Text = "<";
            this.button_SlideLeft.UseVisualStyleBackColor = true;
            this.button_SlideLeft.Click += new System.EventHandler(this.button_SlideLeft_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Current Shift:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(307, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Duplicate Count:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_CurrentIndex
            // 
            this.label_CurrentIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_CurrentIndex.AutoSize = true;
            this.label_CurrentIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CurrentIndex.Location = new System.Drawing.Point(213, 97);
            this.label_CurrentIndex.Name = "label_CurrentIndex";
            this.label_CurrentIndex.Size = new System.Drawing.Size(0, 20);
            this.label_CurrentIndex.TabIndex = 5;
            // 
            // label_DuplicateCount
            // 
            this.label_DuplicateCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_DuplicateCount.AutoSize = true;
            this.label_DuplicateCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DuplicateCount.Location = new System.Drawing.Point(440, 97);
            this.label_DuplicateCount.Name = "label_DuplicateCount";
            this.label_DuplicateCount.Size = new System.Drawing.Size(0, 20);
            this.label_DuplicateCount.TabIndex = 5;
            // 
            // SlidingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 122);
            this.Controls.Add(this.label_DuplicateCount);
            this.Controls.Add(this.label_CurrentIndex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_SlideLeft);
            this.Controls.Add(this.button_SlideRight);
            this.Controls.Add(this.richTextBox_Messages);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 160);
            this.MinimumSize = new System.Drawing.Size(600, 160);
            this.Name = "SlidingForm";
            this.Text = "Sliding Vigenère";
            this.Load += new System.EventHandler(this.SlidingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_Messages;
        private System.Windows.Forms.Button button_SlideRight;
        private System.Windows.Forms.Button button_SlideLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_CurrentIndex;
        private System.Windows.Forms.Label label_DuplicateCount;

    }
}