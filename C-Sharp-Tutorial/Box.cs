using System;
using System.Collections.Generic;
using System.Text;

namespace Properties
{
	public class Box
	{
        // member variable
		private int length;
        public int height;
        public int width;
        public int volume;

        public void SetLength(int length)
        {
            if(length < 0)
            {
                throw new Exception("Length should be higher than 0");
            }
            this.length = length;
        }

        public int GetLength()
        {
            return length;
        }

        public int GetVolume()
        {
            return this.length * this.height * this.width;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0} and height is {1} and width is {2}" +
                " so the volume is {3}", length, height, width,
                volume = length * height * width);
        }
    }
}

