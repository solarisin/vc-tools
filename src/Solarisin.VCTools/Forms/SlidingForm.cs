using System;
using System.Drawing;
using System.Windows.Forms;

namespace Solarisin.VCTools.Forms
{
    public partial class SlidingForm : Form
    {
        private readonly string _text;
        private string _slidingText;
        private int _curIndex;

        public SlidingForm(string text)
        {
            _text = text;
            _slidingText = text;
            InitializeComponent();
        }

        private void SlidingForm_Load(object sender, EventArgs e)
        {
            richTextBox_Messages.Multiline = true;
            richTextBox_Messages.WordWrap = false;
            richTextBox_Messages.ReadOnly = true;
            richTextBox_Messages.Font = new Font("Courier New", 20);
            UpdateText();
        }

        private void button_SlideLeft_Click(object sender, EventArgs e)
        {
            string str1 = _slidingText.Substring(0, 1);
            _slidingText = _slidingText.Remove(0, 1) + str1;
            _curIndex--;
            UpdateText();
        }

        private void button_SlideRight_Click(object sender, EventArgs e)
        {
            string str1 = _slidingText.Substring(_slidingText.Length-1, 1);
            _slidingText = str1 + _slidingText.Remove(_slidingText.Length - 1, 1);
            _curIndex++;
            UpdateText();
        }

        private void UpdateText()
        {
            richTextBox_Messages.Text = _text + Environment.NewLine + _slidingText;

            // Change the background of the matching letters...
            char[] array1 = _text.ToCharArray();
            char[] array2 = _slidingText.ToCharArray();

            // Mark everything as white...
            richTextBox_Messages.SelectAll();
            richTextBox_Messages.SelectionBackColor = Color.White;

            int duplicateCount = 0;
            for (int i = 0; i < _text.Length; i++)
            {
                if (array1 [i] == array2[i])
                {
                    var selectedColor = Color.LightSalmon;
                    richTextBox_Messages.Select(i, 1);
                    richTextBox_Messages.SelectionBackColor = selectedColor;
                    richTextBox_Messages.Select(i + _text.Length + 1, 1);
                    richTextBox_Messages.SelectionBackColor = selectedColor;  
                    duplicateCount++;
                }
            }
            richTextBox_Messages.Select(0, 0);

            // Update count display and index display
            label_DuplicateCount.Text = duplicateCount.ToString();
            _curIndex = (_curIndex + _text.Length) % _text.Length;
            label_CurrentIndex.Text = ((_curIndex+_text.Length) % _text.Length).ToString();
        }
    }
}
