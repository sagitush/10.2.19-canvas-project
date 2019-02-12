using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace canvas_project_10._2._19
{
    internal class MyButton
    {
        protected Point topLeft;
        protected Point bottomRight;
        int width;
        int hight;

        internal MyButton(Point topLeft, Point bottomRight)
        {
            this.topLeft = topLeft;
            this.bottomRight = bottomRight;
        }

        internal int GetWidth()
        {
            return this.width;
        }

        internal int GetHight()
        {
            return this.hight;
        }

        internal bool SetTopLeft(Point topLeft)
        {
            if (topLeft.GetX() > bottomRight.GetX() || topLeft.GetY() < bottomRight.GetY())
            {
                return false;
            }
            else
            {
                this.topLeft = topLeft;
                this.width = width;
                this.hight = hight;
                return true;
            }
                     
        }

        internal bool SetBottomRight(Point bottomRight)
        {
            if (bottomRight.GetX() < topLeft.GetX() || bottomRight.GetY() > topLeft.GetY())
            {
                return false;
            }
            else
            {
                this.topLeft = topLeft;
                this.width = width;
                this.hight = hight;
                return true;
            }
        }

        internal Point GetTopLeft()
        {
           return this.topLeft;
        }

        internal Point GetBottomRight()
        {
            return this.bottomRight;
        }

        public override string ToString()
        {
            return $"The point top left is{topLeft.ToString()} and the point bottom right is{bottomRight.ToString()}";
        }
    }
}
