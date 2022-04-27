using System;
using System.Drawing;
using System.Windows.Forms;
using Solarisin.VCTools.Controls;

namespace Solarisin.VCTools.Forms
{
    public partial class FrequencyCountForm : Form
    {
        private readonly FrequencyCountPanel _panel;

        public FrequencyCountForm(string text)
        {
            InitializeComponent();
            Load += FrequencyCountForm_Load;
            Resize += FrequencyCountForm_Resize;
            _panel = new FrequencyCountPanel(Utility.CountLetters(text));
            Controls.Add(_panel);
        }

        private void FrequencyCountForm_Load(object sender, EventArgs e)
        {
            _panel.Size = new Size(Width-20, Height-60);            
            _panel.Location = new Point(10, 10);
            _panel.Anchor = ((AnchorStyles.Top
                            | AnchorStyles.Bottom)
                            | AnchorStyles.Left)
                            | AnchorStyles.Right;
            _panel.Name = "freq_panel";
            _panel.TabIndex = 0;
        }

        private void FrequencyCountForm_Resize(object sender, EventArgs e)
        {
            _panel.Refresh();
        }
    }
}