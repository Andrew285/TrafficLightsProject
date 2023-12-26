using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLights
{
    public class LightCircle
    {
        private Graphics graphics;
        private Color colorSwitchedOn;  //коли включений
        private Color colorSwitchedOff; //коли виключений
        private int centerX;
        private int centerY;
        private int radius;
        private bool isSwitchedOn;
        public int Duration { get; set; }

        public LightCircle(Graphics g, int cX, int cY, int r, Color c)
        {
            graphics = g;
            centerX = cX;
            centerY = cY;
            radius = r;
            colorSwitchedOn = c;
            colorSwitchedOff = Color.Gray;
            SwitchOff();
        }


        public void SwitchOn()
        {
            isSwitchedOn = true;
        }

        public void SwitchOff()
        {
            isSwitchedOn = false;
        }

        public void Draw()
        {
            //DrawRectangle() - контури  -  Pen
            //FillRectangle() - заповнює -  Brush

            Color currentColor = isSwitchedOn ? colorSwitchedOn : colorSwitchedOff;

            Brush brush = new SolidBrush(currentColor);
            graphics.FillEllipse(brush, centerX - radius, centerY - radius, radius + radius, radius + radius);
        }
    }
}
