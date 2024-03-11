namespace CurlingChalleng.Classes
{
    public abstract class Disk : IItem
    {
        // Disk shape
        public string Name { get; set; }
        // X_Center Coordinate
        public int XCoordinate { get; set; }
        // Y_Center Coordinate 
        public double YCoordinate { get; set; }
        //public int Height { get; set; }
        //public int Width { get; set; }

        // Virtual method
        public virtual void Draw()
        {
            
        }

        public abstract double GetArea();
        public abstract double GetPerimeter();

        public string ItemInfo()
        {
            return "The item is Disk";
        }
    }
}
