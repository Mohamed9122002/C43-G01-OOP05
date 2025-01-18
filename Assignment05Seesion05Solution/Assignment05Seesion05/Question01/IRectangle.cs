using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment05Seesion05.Question01
{
    internal interface IRectangle:IShape
    {
        int Width { get; set; }
        int Height { get; set; }
    }
}
