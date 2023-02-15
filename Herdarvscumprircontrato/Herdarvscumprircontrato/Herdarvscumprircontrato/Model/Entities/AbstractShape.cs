using Herdarvscumprircontrato.Model.Enums;


namespace Herdarvscumprircontrato.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }

}
