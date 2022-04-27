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
    public partial class SlidingForm : Form
    {
        private String text;
        private String slidingText;
        private int curIndex = 0;

        public SlidingForm(String text)
        {
            this.text = text;
            this.slidingText = text;
            InitializeComponent();
        }

        private void SlidingForm_Load(object sender, EventArgs e)
        {
            richTextBox_Messages.Multiline = true;
            richTextBox_Messages.WordWrap = false;
            richTextBox_Messages.ReadOnly = true;
            richTextBox_Messages.Font = new Font("Courier New", 20);
            updateText();
        }

        private void button_SlideLeft_Click(object sender, EventArgs e)
        {
            String str1 = slidingText.Substring(0, 1);
            slidingText = slidingText.Remove(0, 1) + str1;
            curIndex--;
            updateText();
        }

        private void button_SlideRight_Click(object sender, EventArgs e)
        {
            String str1 = slidingText.Substring(slidingText.Length-1, 1);
            slidingText = str1 + slidingText.Remove(slidingText.Length - 1, 1);
            curIndex++;
            updateText();
        }

        private void updateText()
        {
            richTextBox_Messages.Text = text + System.Environment.NewLine + slidingText;

            // Change the background of the matching letters...
            char[] strarry1 = text.ToCharArray();
            char[] strarry2 = slidingText.ToCharArray();

            // Mark everything as white...
            richTextBox_Messages.SelectAll();
            richTextBox_Messages.SelectionBackColor = Color.White;

            Color selectclr = Color.White;
            int dupecount = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (strarry1[i] == strarry2[i])
                {
                    selectclr = Color.LightSalmon;
                    richTextBox_Messages.Select(i, 1);
                    richTextBox_Messages.SelectionBackColor = selectclr;
                    richTextBox_Messages.Select(i + text.Length + 1, 1);
                    richTextBox_Messages.SelectionBackColor = selectclr;  
                    dupecount++;
                }
            }
            richTextBox_Messages.Select(0, 0);

            // Update count display and index display
            label_DuplicateCount.Text = dupecount.ToString();
            curIndex = (curIndex + text.Length) % text.Length;
            label_CurrentIndex.Text = ((curIndex+text.Length) % text.Length).ToString();
        }
    }
}
