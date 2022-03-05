using Adam_Miskal_Assignment_3.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adam_Miskal_Assignment_3.Models
{
    public class TShirt
    {
        public Color Color { get; set; }
        public Fabric Fabric { get; set; }
        public Size Size;
        public decimal Price { get; set; }

        public TShirt(Color color, Fabric fabric, Size size)
        {
            Color = color;
            Fabric = fabric;
            Size = size;
        }

    }
}
