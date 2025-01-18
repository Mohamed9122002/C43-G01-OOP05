using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment05Seesion05.Question01
{
    internal class Rectangle : IRectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int Area { get ; set; }

        public Rectangle( int width , int height )
        {
             Width = width;
            Height = height;
            Area = width * height;
        }
        public void DispalyShapeInfo()
        {
            Console.WriteLine($"Recatangle:\n Width = {Width}\n Height = {Height} \n Area ={Area}");
        }
    }
}
