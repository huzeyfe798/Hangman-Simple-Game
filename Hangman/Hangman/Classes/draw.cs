using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman.Classes
{
    class draw
    {
        public Graphics graph;
        

        Pen mypen = new Pen(System.Drawing.Color.Black, 3);


        public void gallows()
        {
            
            graph.DrawLine(mypen, 560, 80, 640, 80);
            graph.DrawLine(mypen, 560, 80, 560, 250);
            graph.DrawLine(mypen, 540, 250, 580, 250);
            graph.DrawLine(mypen, 640, 80, 640, 100);

        }

        public void head()
        {
            Rectangle rec = new Rectangle(625, 100, 30, 30);

            graph.DrawEllipse(mypen, rec);            
        }

        public void body()
        {
            graph.DrawLine(mypen, 640, 130, 640, 180);
        }

        public void rightArm()
        {
            graph.DrawLine(mypen, 640, 130, 620, 150);
        }

        public void leftArm()
        {
            graph.DrawLine(mypen, 640, 130, 660, 150);
        }
        public void rightLeg()
        {
            graph.DrawLine(mypen, 640, 180, 620, 200);
        }

        public void leftLeg()
        {
            graph.DrawLine(mypen, 640, 180, 660, 200);
        }

        public void drawMan(int k)
        {
            switch (k)
            {
                case 1:
                    head();
                    break;

                case 2:
                    body();
                    break;

                case 3:
                    rightArm();
                    break;

                case 4:
                    leftArm();
                    break;

                case 5:
                    rightLeg();
                    break;

                case 6:
                    leftLeg();
                    break;
                default:

                    break;

            }
        }



    }
}
