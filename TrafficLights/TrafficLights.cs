using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLights
{
    public class TrafficLights
    {
        private LightCircle[] circles;
        private int activePosition;
        private Graphics graphics;
        private int width;
        private int height;

        public TrafficLights(Graphics g, int width, int height, int circleRadius) 
        {
            circles = new LightCircle[4];
            graphics = g;
            this.width = width;
            this.height = height;

            int space = (height - (2 * circleRadius) * 3) / 4; //відступ (margin)
            int currentCenterPos = space + circleRadius;

            for (int i = 0; i < circles.Length; i++)
            {
                Color color = Color.Red;
                switch(i)
                {
                    case 0: color = Color.Red; break;
                    case 1: color = Color.Yellow; break;
                    case 2: color = Color.Green; break;

                }

                circles[i] = new LightCircle(g, width / 2, currentCenterPos, circleRadius, color);
                currentCenterPos += 2 * circleRadius + space;
            }

            circles[3] = circles[1];

            activePosition = 0;
            circles[activePosition].SwitchOn();
            circles[activePosition].Draw();
        }

        public void Draw()
        {
            Brush brush = new SolidBrush(Color.Black);
            graphics.FillRectangle(brush, 0, 0, width, height);

            for (int i = 0; i < circles.Length - 1; i++)
            {
                circles[i].Draw();
            }
        }

        public void Start()
        {
            circles[activePosition].SwitchOff();
            circles[activePosition].Draw();

            activePosition += 1;
            activePosition %= circles.Length;

            circles[activePosition].SwitchOn();
            circles[activePosition].Draw();
        }

        public void SetInterval(int position, int duration)
        {
            circles[position].Duration = duration;
        }

        public int GetInterval()
        {
            return circles[activePosition].Duration;
        }
    }
}
