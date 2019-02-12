using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace canvas_project_10._2._19
{
   internal class Point
    {
        int x;
        int y;

        internal Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        internal int GetX()
        {
            return this.x;
        }
        internal int GetY()
        {
            return this.y;
        }
        internal void SetX(int x)
        {
            if (x < 0 || x > 800)
            {
                Console.WriteLine("The width is off limit");
            }
            else
                this.x = x;
        }
        internal void SetY(int y)
        {
            if (y < 0 || y > 600)
            {
                Console.WriteLine("The hight is off limit");
            }
            else
                this.y = y;
        }

        public override string ToString()
        {
            return $"The width is:{x} and the hight is:{y}";
        }
       
    }
}
