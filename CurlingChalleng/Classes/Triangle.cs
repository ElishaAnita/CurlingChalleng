namespace CurlingChalleng.Classes
{
    public class Triangle: Disk
    {
        public double SideR { get; set; }
        public double SideL { get; set; }
        public double Base { get; set; }
        public double Hight { get; set; }
        public Triangle(double sideR, double sideL,  double b, double hieght, int x, double y)
        {
            Name = "Triangle";
            SideR = sideR;
            SideL = sideL;
            Base = b;
            Hight = hieght;
            XCoordinate = x;
            YCoordinate = y;
        }
        public Triangle() { }
        public override void Draw()
        {
            // Code to draw a circle...
       
            base.Draw();
        }

        public override double GetArea()
        {
            return (0.5 * Base) * Hight;
        }

        public override double GetPerimeter()
        {
            return  SideR + SideL + Base;
        }
    }
}
