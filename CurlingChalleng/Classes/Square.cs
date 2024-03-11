using System.Xml.Linq;

namespace CurlingChalleng.Classes
{
    public class Square : Disk
    {
        public double Hieght { get; set; }
        public Square(double hieght, int x, double y)
        {
            Name = "Square";
            Hieght = hieght;
            XCoordinate = x;
            YCoordinate = y;
        }
        public Square() { }
        public override void Draw()
        {
            // Code to draw a circle...
        
            base.Draw();
        }

        public override double GetArea()
        {
            return Hieght * Hieght;
        }

        public override double GetPerimeter()
      
        {
            return Hieght * 4;
        }
    }
}
