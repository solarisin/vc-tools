using System;
using System.Windows.Forms;

namespace Solarisin.VCTools.Forms
{
    public partial class EncipherDecipherForm : Form
    {
        public EncipherDecipherForm(string text)
        {
            InitializeComponent();
            textBox_PlainText.Text = text.ToUpper();
            textBox_CipherText.Text = text.ToUpper();
        }

        private void Button_Encipher_Click(object sender, EventArgs e)
        {
            string str = "";
            string pt = Utility.StripIllegalChars(textBox_PlainText.Text.ToUpper());
            string key = Utility.StripIllegalChars(textBox_Key.Text.ToUpper());
            int i = 0;
            int j = key.Length;

            if (j == 0)
            {
                MessageBox.Show("Key field is empty!");
                return;
            }           

            foreach ( char c in pt)
            {
                int m = c - 65;
                int n = key.Substring(i, 1).ToCharArray()[0] - 65;
                var result = (m + n) % 26;
                i = (i + 1) % j;
                str += (char)(result + 65);
            }

            textBox_CipherText.Text = str;
        }

        private void Button_Decipher_Click(object sender, EventArgs e)
        {
            string str = "";
            string pt = Utility.StripIllegalChars(textBox_CipherText.Text.ToUpper());
            string key = Utility.StripIllegalChars(textBox_Key.Text.ToUpper());
            int i = 0;
            int j = key.Length;

            if (j == 0)
            {
                MessageBox.Show("Key field is empty!");
                return;
            }

            foreach (char c in pt)
            {
                int m = c - 65;
                int n = key.Substring(i, 1).ToCharArray()[0] - 65;
                var result = (m - n + 26) % 26;
                i = (i + 1) % j;
                str += (char)(result + 65);
            }

            textBox_PlainText.Text = str;
        }
    }
}
