using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _2DGameApp
{
    internal class obstacle
    {

        //obstacle characteristics
        public Image obsImage;

        public int X = 400;
        public int Y = 250;
        public int height;
        public int width;
        public int obsSpeed = 20;

        public obstacle()
        {
            // randomize the type of obstacle
            Random randType = new Random();
            int obstType = randType.Next(0, 3);

            //define the obstacle types
            if (obstType == 0)
            {
                obsImage = Properties.Resources.obs1;
                height = 70;
                width = 34;
                Y = 275;

            }
            else if (obstType == 1)
            {
                obsImage = Properties.Resources.obs2;
                Y = 295;
                height = 50;
                width = 80;

            }
            else if (obstType == 2)
            {
                obsImage = Properties.Resources.obs3;
                height = 96;
                width = 50;
                Y = 250;
            }

        }
        public void Move()
        {
            //move the obstacles
            X -= obsSpeed;
        }
    }
}
