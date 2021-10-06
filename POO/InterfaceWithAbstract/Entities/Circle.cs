using System;
using System.Globalization;
namespace InterfaceWithAbstract.Entities
{
    public class Circle : Shape
    {
        public double Radius {get; set;}
        
        public override double Area() : AbstractShape{
            return Math.PI * Radius * Radius;
        }

        public override string ToString(){
            return "Circle color = "
                    + Color 
                    + ", radius = "
                    + Radius.ToString("F2", CultureInfo.InvariantCulture)
                    + ", area = "
                    + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}