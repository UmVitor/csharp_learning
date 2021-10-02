using ClasseAbstrataArea.Entities.Enums;
namespace ClasseAbstrataArea.Entities
{
    public abstract  class Shape
    {
        public Color Color { get; set; }
        
        
        public Shape(Color color){
            Color = color;
        }
        
        public abstract double Area();

    }
}