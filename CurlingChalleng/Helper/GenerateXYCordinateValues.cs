using CurlingChalleng.Classes;

namespace CurlingChalleng.Helper
{
    public class GenerateXYCordinateValues
    {
        readonly IWrapper _wrapper;
        public GenerateXYCordinateValues(IWrapper wrapper)
        {
            _wrapper = wrapper;
        }
        //Method for generate random x_coordinate
        public static List<int> GenerateX_Coordinate(int count)
        {
            Random random = new Random();
            List<int> values = new List<int>();

            for (int i = 0; i < count; ++i)
                values.Add(random.Next());

            return values;
        }

        //Method for get y_coordinate
        public static List<Disk> GetY_Coordinate(List<int> x, int d, string shape)
        {
            //List<int> x = new List<int>();
            //x.Add(5);
            //x.Add(5);
            //x.Add(6);
            //x.Add(8);
            //x.Add(3);
            //x.Add(12);
            List<Disk> disk = new List<Disk>();
            List<double> y = new List<double>();
            double tag;
            for (var i = 0; i < x.Count; i++)
                y.Add(d);
            for (var i = 0; i < x.Count; i++)
            {
                for (var j = 0; j < i; j++)
                    if (0 <= 4.0 * d * d - (x[i] - x[j]) * (x[i] - x[j]))
                    {
                        tag = y[j] + Math.Sqrt(4.0 * d * d - (x[i] - x[j]) * (x[i] - x[j]));
                        if (tag > y[i])
                            y[i] = tag;
                    }
                if (shape == "Circle")
                {
                    disk.Add(new Circle { Name = "Circle", Radius = d, XCoordinate = x[i], YCoordinate = y[i] });
                }
                if (shape == "Square")
                {
                    disk.Add(new Square { Name = "Square", Hieght = d, XCoordinate = x[i], YCoordinate = y[i] });
                }
                if (shape == "Triangle")
                {
                    disk.Add(new Triangle { Name = "Triangle", SideL = d, XCoordinate = x[i], YCoordinate = y[i] });

                }

            }

            return disk;
        }
        public static List<Disk> GetDiskShapeList(int dim, List<int> x_center, List<double> y_center)
        {
            var result = new List<Disk>();
            //switch (shapeName)
            //{
            //    case "Circle":

            //        break;
            //    case "Square":
                  
            //        break;
            //    case "Triangle":
                  
            //        break;
            //    default:
            //        // code block
            //        break;
            //}
            return result;
        }
    }
}
