using System;
using System.Windows.Forms;
using System.Drawing;

namespace VCTools
{
    public class FrequencyCountPanel : Panel
    {
        private int[] letterValues = null;
        public FrequencyCountPanel(int[] letterValues)
            : base()
        {
            this.letterValues = letterValues;
            this.Paint += new PaintEventHandler(FrequencyCountPanel_Paint);
        }

        void FrequencyCountPanel_Paint(object sender, PaintEventArgs e)
        {
            if (letterValues == null)
                return;

            int maxValue = 0;
            foreach (int i in letterValues)
            {
                if (i > maxValue)
                    maxValue = i;
            }

            Graphics g = e.Graphics;
            Brush b = Brushes.Blue;
            String countstr = "";
            int w = 0;
            int h = 0;
            int x = 0;
            int y = 0;

            w = calcBarWidth(this.Width);
            for (int n = 0; n < 26; n++)
            {
                if (letterValues[n] == maxValue)
                    b = Brushes.LightPink;
                else
                    b = Brushes.Azure;
                h = calcBarHeight(this.Height, letterValues[n], maxValue);
                x = calcBarXPos(this.Width, n);
                y = calcBarYPos(this.Height, h);
                g.FillRectangle(b, x, y, w, h);
                g.DrawRectangle(new Pen(Color.Black), x, y, w, h);
                g.DrawString(char.ConvertFromUtf32(n + 65).ToString(), new Font("Arial", 10f), Brushes.Black, x + (w / 2) - 6, this.Height - 13);
                if( w > 20 && h > 25)
                {
                    countstr = letterValues[n].ToString();
                    g.DrawString(countstr, new Font("Arial", 10f), Brushes.Black, x + (w / 2) - 6 - ((countstr.Length-1)*3), y + 8);
                }
            }
        }

        private int calcBarXPos(int panelWidth, int letter)
        {
            return letter * (panelWidth / 26);
        }

        private int calcBarYPos(int panelHeight, int barHeight)
        {
            return (panelHeight - barHeight - 13);
        }

        private int calcBarWidth(int panelWidth)
        {
            return ((panelWidth - 100) / 26);
        }

        private int calcBarHeight(int panelHeight, int value, int maxValue)
        {
            double valueratio = Convert.ToDouble(value) / Convert.ToDouble(maxValue);
            int result = Convert.ToInt32(Convert.ToDouble(panelHeight - 13) * valueratio);
            return result;
        }
    }
}
