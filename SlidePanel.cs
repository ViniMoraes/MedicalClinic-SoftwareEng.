using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalClinic
{
    public abstract class SlidePanel
    {
        public enum Slide
        {
            None = -1,
            Left,
            Right,
            Up,
            Down
        };

        public static void setPanel(Slide slide, MetroPanel newPanel, MetroPanel oldPanel)
        {
            Point finalPoint = newPanel.Location;
            int speedX = 0, speedY = 0;

            //            oldPanel.Container.Add(newPanel);

            if (slide == Slide.Left)
            {
                speedX = -15;
                newPanel.Location = new Point(newPanel.Location.X + oldPanel.Size.Width, newPanel.Location.Y);
                while (newPanel.Location.X + speedX > finalPoint.X)
                {
                    newPanel.Location = new Point(newPanel.Location.X + speedX, newPanel.Location.Y);
                    oldPanel.Location = new Point(oldPanel.Location.X + speedX, oldPanel.Location.Y);
                    newPanel.Refresh();
                    oldPanel.Refresh();
                }
            }

            if (slide == Slide.Right)
            {
                speedX = 15;
                newPanel.Location = new Point(newPanel.Location.X - oldPanel.Size.Width, newPanel.Location.Y);
                while (newPanel.Location.X + speedX < finalPoint.X)
                {
                    newPanel.Location = new Point(newPanel.Location.X + speedX, newPanel.Location.Y);
                    oldPanel.Location = new Point(oldPanel.Location.X + speedX, oldPanel.Location.Y);
                    newPanel.Refresh();
                    oldPanel.Refresh();
                }
            }

            if (slide == Slide.Up)
            {
                speedY = -10;
                newPanel.Location = new Point(newPanel.Location.X, newPanel.Location.Y + oldPanel.Size.Height);
                while (newPanel.Location.Y + speedY > finalPoint.Y)
                {
                    newPanel.Location = new Point(newPanel.Location.X, newPanel.Location.Y + speedY);
                    oldPanel.Location = new Point(oldPanel.Location.X, oldPanel.Location.Y + speedY);
                    newPanel.Refresh();
                    oldPanel.Refresh();
                }
            }

            if (slide == Slide.Down)
            {
                speedY = 10;
                newPanel.Location = new Point(newPanel.Location.X, newPanel.Location.Y - oldPanel.Size.Height);
                while (newPanel.Location.Y + speedY < finalPoint.Y)
                {
                    newPanel.Location = new Point(newPanel.Location.X, newPanel.Location.Y + speedY);
                    oldPanel.Location = new Point(oldPanel.Location.X, oldPanel.Location.Y + speedY);
                    newPanel.Refresh();
                    oldPanel.Refresh();
                }
            }
            newPanel.Location = finalPoint;
            //   oldPanel.Container.Remove(oldPanel);
            //    oldPanel.Dispose();             
        }
    }
}
