using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace canvas_project_10._2._19
{
    public class MyCanvas
    {
        public const int MAX_WIDTH= 800;
        public const int MAX_HIGHT = 600;
        private static int buttonIndex = 0;
        private static MyButton[] buttons = new MyButton[MaxButtons];
        private static int MaxButtons = 3;

        public static bool CreateNewButton(int x1,int x2,int y1,int y2)
        {
            if(buttonIndex<MaxButtons)
            {
                MyButton button = new MyButton(new Point(x1, y1), new Point(x2, y2));
                button = buttons[buttonIndex];
                buttonIndex++;
                return true;
            }
            return false;
                 
        }

        public static bool MoveButton(int buttonNumber,int x, int y)
        {
            int a = buttons[buttonNumber].GetTopLeft().GetX() + x;
            int b = buttons[buttonNumber].GetTopLeft().GetY() + y;
            int c= buttons[buttonNumber].GetBottomRight().GetX() + x;
            int d= buttons[buttonNumber].GetBottomRight().GetY() + y;
            buttons[buttonNumber] = new MyButton(new Point(a, b), new Point(c, d));

        }

        public static bool DeleteLastButton()
        {
            if (buttonIndex > 0)
            {
                buttons[buttonIndex] = new MyButton(new Point(0, 0), new Point(0, 0));
                buttonIndex = buttonIndex - 1;
                return true;
            }
            else
                return false;
        }
        public static void ClearAllButtons()
        {
            while(buttonIndex>0)
            {
                buttons[buttonIndex] = new MyButton(new Point(0, 0), new Point(0, 0));
                buttonIndex = buttonIndex - 1;
            }

        }
        public static int GetCurrentNumberOfButtons()
        {
            return MyCanvas.buttonIndex;
        }
        public static int GetMaxNumberOfButtons()
        {
            return MyCanvas.MaxButtons;
        }
        public static int GetTheMaxWidthOfAButton()
        {
            int maxWidth=0;
            while(buttonIndex>0)
            {
                int b = buttons[buttonIndex].GetWidth();
                if (b>maxWidth)
                {
                    maxWidth = b;
                }
                buttonIndex = buttonIndex - 1;
            }
            return maxWidth;
        }
        public static int GetTheMaxHightOfAButton()
        {
            int maxHight = 0;
            while (buttonIndex > 0)
            {
                int b = buttons[buttonIndex].GetHight();
                if (b > maxHight)
                {
                    maxHight = b;
                }
                buttonIndex = buttonIndex - 1;
            }
            return maxHight;
        }
        public static bool IsPointInsideAButton(int x,int y)
        {

        }
        public static bool CheckIfAnyButtonIsOverLapping()
        {

        }

        public override string ToString()
        {
            return $"";
        }
        public void Print()
        {
            for (int i = 0; i <buttons.Length; i++)
            {
                Console.WriteLine($"{buttons[i].GetWidth()},{buttons[i].GetHight()}");
            }
        }
    }

}
