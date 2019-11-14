namespace Session5
{
    public class ShapeService
    {
        private IShape _shape;

        public ShapeService(string shapeType)
        {
            switch (shapeType)
            {
                case "Square":
                    _shape = new Square(int.MinValue);
                    break;
                case "Triangle":
                    _shape = new Triangle();
                    break;
                case "Circle":
                    _shape = new Circle();
                    break;
            }
        }

        public void PrintProperties()
        {
            var area = _shape.Area;
            var volume = _shape.Volume;
        }
    }
}