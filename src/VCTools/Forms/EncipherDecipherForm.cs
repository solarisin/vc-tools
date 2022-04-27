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
    public partial class EncipherDecipherForm : Form
    {
        public EncipherDecipherForm(String text)
        {
            InitializeComponent();
            textBox_PlainText.Text = text.ToUpper();
            textBox_CipherText.Text = text.ToUpper();
        }

        private void button_Encipher_Click(object sender, EventArgs e)
        {
            String str = "";
            String pt = Utility.StripIllegalChars(this.textBox_PlainText.Text.ToUpper());
            String key = Utility.StripIllegalChars(this.textBox_Key.Text.ToUpper());
            int i = 0;
            int j = key.Length;
            int result = 0;

            if (j == 0)
            {
                MessageBox.Show("Key field is empty!");
                return;
            }           

            foreach ( char c in pt)
            {
                int m = ((int)c) - 65;
                int n = ((int)key.Substring(i, 1).ToCharArray()[0]) - 65;
                result = (m + n) % 26;
                i = (i + 1) % j;
                str = str + (char)(result + 65);
            }

            this.textBox_CipherText.Text = str;
        }

        private void button_Decipher_Click(object sender, EventArgs e)
        {
            String str = "";
            String pt = Utility.StripIllegalChars(this.textBox_CipherText.Text.ToUpper());
            String key = Utility.StripIllegalChars(this.textBox_Key.Text.ToUpper());
            int i = 0;
            int j = key.Length;
            int result = 0;

            if (j == 0)
            {
                MessageBox.Show("Key field is empty!");
                return;
            }

            foreach (char c in pt)
            {
                int m = ((int)c) - 65;
                int n = ((int)key.Substring(i, 1).ToCharArray()[0]) - 65;
                result = (m - n + 26) % 26;
                i = (i + 1) % j;
                str = str + (char)(result + 65);
            }

            this.textBox_PlainText.Text = str;
        }
    }
}
