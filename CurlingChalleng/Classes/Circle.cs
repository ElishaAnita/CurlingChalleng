namespace CurlingChalleng.Classes
{
    public class Circle : Disk
    {
        public double Radius { get; set; }
        public Circle(double radius, int x, double y)
        {
            Name = "Circle";
            Radius = radius;
            XCoordinate = x;
            YCoordinate = y;
        }
        public Circle() { }
        public override void Draw()
        {
            // Code to draw a circle...
         
            base.Draw();

        }
         
        public override double GetArea()
        {
           return (Math.Pow(Radius,0.2)) * Math.PI;
        }

        public override double GetPerimeter()
        {
            throw new NotImplementedException();
        }
    }
}
