using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VCTools
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void button_Count_Click(object sender, EventArgs e)
		{
            String message = Utility.StripIllegalChars(textBox_Message.Text);
            if (message.Length != 0)
            {
                FrequencyCountForm frm = new FrequencyCountForm(message);
                frm.Show();
                this.Location = new Point(50, 50);
            }
            else
            {
                MessageBox.Show("Please enter some text to analyze first!");
            }
		}

        private void button_EncipherDecipher_Click(object sender, EventArgs e)
        {
            EncipherDecipherForm frm = new EncipherDecipherForm(Utility.StripIllegalChars(textBox_Message.Text));
            frm.Show();
            frm.Location = new Point(this.Location.X+1, this.Location.Y + this.Size.Height+1);
        }

        private void button_StripAlphabets_Click(object sender, EventArgs e)
        {
            String message = Utility.StripIllegalChars(textBox_Message.Text);
            if (message.Length != 0)
            {
                StripAlphabetsForm frm = new StripAlphabetsForm(message);
                frm.Show();
                frm.Location = new Point(this.Location.X + this.Size.Width + 1, this.Location.Y + /*size of sliding*/160 + 1);
            }
            else
            {
                MessageBox.Show("Please enter some text to analyze first!");
            }
        }

        private void button_Sliding_Click(object sender, EventArgs e)
        {
            String message = Utility.StripIllegalChars(textBox_Message.Text);
            if (message.Length != 0)
            {
                if (message.Length > 1500)
                {
                    DialogResult result = MessageBox.Show("The Sliding Viginere dialog does not work very well with text larger than 1500 characters." +
                        "\nWould you still like to use the Sliding Viginere dialog?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == System.Windows.Forms.DialogResult.Cancel)
                        return;
                }
                SlidingForm frm = new SlidingForm(message);
                frm.Show();
                frm.Location = new Point(this.Location.X + this.Size.Width + 1, this.Location.Y + 1);
            }
            else
            {
                MessageBox.Show("Please enter some text to analyze first!");
            }
        }

        private void button_Friedman_Click(object sender, EventArgs e)
        {
            String message = Utility.StripIllegalChars(textBox_Message.Text);
            if (message.Length != 0)
            {
                double fval = Utility.GetFriedman(message);
                MessageBox.Show("Index of Coincidence:  " + fval.ToString() + "\n\nEnglish ≈ 0.0656", "Index of Coincidence", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Please enter some text to analyze first!");
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_Message.Text = "";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Location = new Point(25, 25);
        }
	}
}
