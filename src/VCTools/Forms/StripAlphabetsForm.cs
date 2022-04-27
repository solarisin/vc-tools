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
    public partial class StripAlphabetsForm : Form
    {
        private String letters;
        private TabControl tabCtrl = null;

        public StripAlphabetsForm(String text)
        {
            InitializeComponent();
            this.Load += new EventHandler(StripAlphabetsForm_Load);
            textBox_Alphabets.Validating += new CancelEventHandler(textBox_Alphabets_Validating);
            this.letters = text;
        }

        void textBox_Alphabets_Validating(object sender, CancelEventArgs e)
        {
            if (!Utility.IsValidInteger(textBox_Alphabets.Text))
            {
                e.Cancel = true;
                textBox_Alphabets.Select(0, textBox_Alphabets.Text.Length);
            }
        }

        void StripAlphabetsForm_Load(object sender, EventArgs e)
        {
            // Lets default to 6...
            this.textBox_Alphabets.Text = "6";
            string[] alphabets = this.stripAlphabets(6);
            updateIC();
            updateAvgIC(alphabets);
        }

        private String[] stripAlphabets(int num)
        {
            // Get the array of characters...
            char[] lettersArry = letters.ToCharArray();

            // Remove all previous controls...
            panel_Tabs.Controls.Clear();

            // Create the new tab control...
            tabCtrl = new TabControl();
            tabCtrl.Dock = DockStyle.Fill;

            // strip alphabets
            String[] alphabets = Utility.StripAlphabets(letters, num);

            // Add pages...
            TabPage page = null;
            FrequencyCountPanel fcPanel = null;
            for (int i = 0; i < num; i++)
            {
                // Create a new page...
                page = new TabPage((i + 1).ToString());

                fcPanel = new FrequencyCountPanel(Utility.CountLetters(alphabets[i]));
                page.Controls.Add(fcPanel);
                fcPanel.Dock = DockStyle.Fill;

                // Add this page to the tab control...
                tabCtrl.TabPages.Add(page);
            }

            // Add the tab control to the panel...
            panel_Tabs.Controls.Add(tabCtrl);

            // Register the index change event
            tabCtrl.SelectedIndexChanged += new EventHandler(tabCtrl_SelectedIndexChanged);

            return alphabets;
        }

        private void button_Strip_Click(object sender, EventArgs e)
        {            
            string[] alphabets = this.stripAlphabets(int.Parse(textBox_Alphabets.Text));
            updateAvgIC(alphabets);
        }

        private void tabCtrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateIC();
        }

        private void updateIC()
        {
            int num = int.Parse(textBox_Alphabets.Text);
            int idx = tabCtrl.SelectedIndex;
            String[] alphabets = Utility.StripAlphabets(letters, num);
            double friedman = Utility.GetFriedman(alphabets[idx]);
            String formatString = "0.####";
            textBox_IC.Text = friedman.ToString(formatString);
        }

        private void updateAvgIC(string[] alphabets)
        {
            double sum = 0;
            string formatString = "0.####";

            // Update Average IC value
            for (int i = 0; i < alphabets.Length; i++)
            {
                sum += Utility.GetFriedman(alphabets[i]);
            }

            textBox_AvgIC.Text = (sum / alphabets.Length).ToString(formatString);
        }
    }
}

