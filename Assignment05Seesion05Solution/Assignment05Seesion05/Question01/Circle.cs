using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Assignment05Seesion05.Question01
{
    internal class Circle : ICircle
    {
        public int Radius { get; set; }
        public int Area { get; set; }

        public Circle( int raduis )
        {
            Radius = raduis;
            Area = (int)Math.PI * raduis * raduis;
        }
        public void DispalyShapeInfo()
        {
            Console.WriteLine($"Circle : \n Radius = {Radius}\n Area = {Area} ");
            
        }

    }
}
