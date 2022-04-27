using System;
using System.ComponentModel;
using System.Windows.Forms;
using Solarisin.VCTools.Controls;

namespace Solarisin.VCTools.Forms
{
    public partial class StripAlphabetsForm : Form
    {
        private readonly string _letters;
        private TabControl _tabCtrl;

        public StripAlphabetsForm(string text)
        {
            InitializeComponent();
            Load += StripAlphabetsForm_Load;
            textBox_Alphabets.Validating += TextBox_Alphabets_Validating;
            _letters = text;
        }

        private void TextBox_Alphabets_Validating(object sender, CancelEventArgs e)
        {
            if (Utility.IsValidInteger(textBox_Alphabets.Text)) return;
            e.Cancel = true;
            textBox_Alphabets.Select(0, textBox_Alphabets.Text.Length);
        }

        private void StripAlphabetsForm_Load(object sender, EventArgs e)
        {
            // Lets default to 6...
            textBox_Alphabets.Text = "6";
            string[] alphabets = StripAlphabets(6);
            UpdateIc();
            UpdateAvgIc(alphabets);
        }

        private string[] StripAlphabets(int num)
        {
            // Remove all previous controls...
            panel_Tabs.Controls.Clear();

            // Create the new tab control...
            _tabCtrl = new TabControl {
                Dock = DockStyle.Fill
            };

            // strip alphabets
            string[] alphabets = Utility.StripAlphabets(_letters, num);

            // Add pages...
            for (int i = 0; i < num; i++)
            {
                // Create a new page...
                var page = new TabPage((i + 1).ToString());

                var fcPanel = new FrequencyCountPanel(Utility.CountLetters(alphabets[i]));
                page.Controls.Add(fcPanel);
                fcPanel.Dock = DockStyle.Fill;

                // Add this page to the tab control...
                _tabCtrl.TabPages.Add(page);
            }

            // Add the tab control to the panel...
            panel_Tabs.Controls.Add(_tabCtrl);

            // Register the index change event
            _tabCtrl.SelectedIndexChanged += TabCtrl_SelectedIndexChanged;

            return alphabets;
        }

        private void Button_Strip_Click(object sender, EventArgs e)
        {            
            string[] alphabets = StripAlphabets(int.Parse(textBox_Alphabets.Text));
            UpdateAvgIc(alphabets);
        }

        private void TabCtrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateIc();
        }

        private void UpdateIc()
        {
            int num = int.Parse(textBox_Alphabets.Text);
            int idx = _tabCtrl.SelectedIndex;
            string[] alphabets = Utility.StripAlphabets(_letters, num);
            double friedman = Utility.GetFriedman(alphabets[idx]);
            string formatString = "0.####";
            textBox_IC.Text = friedman.ToString(formatString);
        }

        private void UpdateAvgIc(string[] alphabets)
        {
            double sum = 0;
            string formatString = "0.####";

            // Update Average IC value
            foreach (var alphabet in alphabets)
            {
                sum += Utility.GetFriedman(alphabet);
            }

            textBox_AvgIC.Text = (sum / alphabets.Length).ToString(formatString);
        }
    }
}

