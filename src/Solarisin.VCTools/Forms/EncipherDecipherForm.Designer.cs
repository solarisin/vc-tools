namespace Solarisin.VCTools.Forms
{
    partial class EncipherDecipherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EncipherDecipherForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_PlainText = new System.Windows.Forms.TextBox();
            this.textBox_CipherText = new System.Windows.Forms.TextBox();
            this.button_Encipher = new System.Windows.Forms.Button();
            this.button_Decipher = new System.Windows.Forms.Button();
            this.textBox_Key = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Plaintext";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ciphertext";
            // 
            // textBox_PlainText
            // 
            this.textBox_PlainText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_PlainText.Location = new System.Drawing.Point(15, 25);
            this.textBox_PlainText.Multiline = true;
            this.textBox_PlainText.Name = "textBox_PlainText";
            this.textBox_PlainText.Size = new System.Drawing.Size(454, 180);
            this.textBox_PlainText.TabIndex = 5;
            // 
            // textBox_CipherText
            // 
            this.textBox_CipherText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_CipherText.Location = new System.Drawing.Point(15, 240);
            this.textBox_CipherText.Multiline = true;
            this.textBox_CipherText.Name = "textBox_CipherText";
            this.textBox_CipherText.Size = new System.Drawing.Size(454, 180);
            this.textBox_CipherText.TabIndex = 6;
            // 
            // button_Encipher
            // 
            this.button_Encipher.Location = new System.Drawing.Point(15, 211);
            this.button_Encipher.Name = "button_Encipher";
            this.button_Encipher.Size = new System.Drawing.Size(75, 23);
            this.button_Encipher.TabIndex = 7;
            this.button_Encipher.Text = "↓ Encipher";
            this.button_Encipher.UseVisualStyleBackColor = true;
            this.button_Encipher.Click += new System.EventHandler(this.Button_Encipher_Click);
            // 
            // button_Decipher
            // 
            this.button_Decipher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Decipher.Location = new System.Drawing.Point(394, 211);
            this.button_Decipher.Name = "button_Decipher";
            this.button_Decipher.Size = new System.Drawing.Size(75, 23);
            this.button_Decipher.TabIndex = 7;
            this.button_Decipher.Text = "Decipher ↑";
            this.button_Decipher.UseVisualStyleBackColor = true;
            this.button_Decipher.Click += new System.EventHandler(this.Button_Decipher_Click);
            // 
            // textBox_Key
            // 
            this.textBox_Key.Location = new System.Drawing.Point(188, 213);
            this.textBox_Key.Name = "textBox_Key";
            this.textBox_Key.Size = new System.Drawing.Size(132, 20);
            this.textBox_Key.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Key";
            // 
            // EncipherDecipherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 445);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Key);
            this.Controls.Add(this.button_Decipher);
            this.Controls.Add(this.button_Encipher);
            this.Controls.Add(this.textBox_CipherText);
            this.Controls.Add(this.textBox_PlainText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 483);
            this.MinimumSize = new System.Drawing.Size(500, 483);
            this.Name = "EncipherDecipherForm";
            this.Text = "Encipher/Decipher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_PlainText;
        private System.Windows.Forms.TextBox textBox_CipherText;
        private System.Windows.Forms.Button button_Encipher;
        private System.Windows.Forms.Button button_Decipher;
        private System.Windows.Forms.TextBox textBox_Key;
        private System.Windows.Forms.Label label3;
    }
}