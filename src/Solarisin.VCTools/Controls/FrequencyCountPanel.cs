using System;
using System.Windows.Forms;
using System.Drawing;

namespace Solarisin.VCTools.Controls
{
    public class FrequencyCountPanel : Panel
    {
        private readonly int[] _letterValues;
        
        public FrequencyCountPanel(int[] letterValues)
        {
            _letterValues = letterValues;
            Paint += FrequencyCountPanel_Paint;
        }

        private void FrequencyCountPanel_Paint(object sender, PaintEventArgs e)
        {
            if (_letterValues == null)
                return;

            int maxValue = 0;
            foreach (int i in _letterValues)
            {
                if (i > maxValue)
                    maxValue = i;
            }

            Graphics g = e.Graphics;

            var w = CalcBarWidth(Width);
            for (int n = 0; n < 26; n++)
            {
                Brush b = _letterValues[n] == maxValue ? Brushes.LightPink : Brushes.Azure;
                var h = CalcBarHeight(Height, _letterValues[n], maxValue);
                var x = CalcBarXPos(Width, n);
                var y = CalcBarYPos(Height, h);
                g.FillRectangle(b, x, y, w, h);
                g.DrawRectangle(new Pen(Color.Black), x, y, w, h);
                g.DrawString(char.ConvertFromUtf32(n + 65).ToString(), new Font("Arial", 10f), Brushes.Black, x + (w / 2) - 6, Height - 13);
                if( w > 20 && h > 25)
                {
                    var countString = _letterValues[n].ToString();
                    g.DrawString(countString, new Font("Arial", 10f), Brushes.Black, x + (w / 2) - 6 - ((countString.Length-1)*3), y + 8);
                }
            }
        }

        private static int CalcBarXPos(int panelWidth, int letter)
        {
            return letter * (panelWidth / 26);
        }

        private static int CalcBarYPos(int panelHeight, int barHeight)
        {
            return (panelHeight - barHeight - 13);
        }

        private static int CalcBarWidth(int panelWidth)
        {
            return ((panelWidth - 100) / 26);
        }

        private static int CalcBarHeight(int panelHeight, int value, int maxValue)
        {
            double valueRatio = Convert.ToDouble(value) / Convert.ToDouble(maxValue);
            int result = Convert.ToInt32(Convert.ToDouble(panelHeight - 13) * valueRatio);
            return result;
        }
    }
}
