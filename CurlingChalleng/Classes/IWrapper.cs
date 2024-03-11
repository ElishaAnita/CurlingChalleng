namespace CurlingChalleng.Classes
{
    /// <summary>
    /// An interface for DataAccess
    /// </summary>
    public interface IWrapper
    {
         List<int> GenerateX_Coordinate(int count);
         List<Disk> GetY_Coordinate(List<int> xx, int d, string shape);
    }

    public class Wrapper : IWrapper
    {
        public List<int> GenerateX_Coordinate(int count) => GenerateX_Coordinate(count);
        

        public List<Disk> GetY_Coordinate(List<int> xc, int d, string shape) => GetY_Coordinate(xc, d, shape);
      

      
    }
}
