using InterfaceWithAbstract.Enums;
namespace InterfaceWithAbstract.Entities
{
    public abstract class Shape
    {
        public Color Color {get; set;}
        public abstract double Area();
    }
}