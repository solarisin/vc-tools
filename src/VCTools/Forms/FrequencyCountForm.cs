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
    public partial class FrequencyCountForm : Form
    {
        private FrequencyCountPanel panel = null;

        public FrequencyCountForm(String text)
        {
            InitializeComponent();
            this.Load += new EventHandler(FrequencyCountForm_Load);
            this.Resize += new EventHandler(FrequencyCountForm_Resize);
            panel = new FrequencyCountPanel(Utility.CountLetters(text));
            this.Controls.Add(panel);
        }

        void FrequencyCountForm_Load(object sender, EventArgs e)
        {
            this.panel.Size = new Size(this.Width-20, this.Height-60);            
            this.panel.Location = new System.Drawing.Point(10, 10);
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.Name = "freq_panel";
            this.panel.TabIndex = 0;
        }

        void FrequencyCountForm_Resize(object sender, EventArgs e)
        {
            panel.Refresh();
        }
    }
}