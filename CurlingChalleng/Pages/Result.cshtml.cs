using CurlingChalleng.Classes;
using CurlingChalleng.Helper;
using CurlingChalleng.PageModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Syncfusion.EJ2.Diagrams;

namespace CurlingChalleng.Pages
{
    public class ResultModel : PageModel
    {
        [BindProperty]
        public DiskModel disk { get; set; }
        [BindProperty]
        public List<Disk> y_coordinates { get; set; }
        public void OnGet(DiskModel dsikModel)
        {
            int index = 0;
            disk = dsikModel;
            List<int> values = new List<int>();           
            values = GenerateXYCordinateValues.GenerateX_Coordinate(disk.Number);
           
            y_coordinates = new List<Disk>();
            y_coordinates = GenerateXYCordinateValues.GetY_Coordinate(values, disk.Dim, disk.Shape);
            List<DiagramNode> nodes = new List<DiagramNode>();
            foreach (var coord in y_coordinates) {
              
                index++;  
            switch (coord.Name)
            {
                case "Circle":
                  
                    nodes.Add(new DiagramNode()
                    {
                        Id = "node"+index,
                        Width = disk.Dim * 2,
                        Height = disk.Dim * 2,
                        OffsetX = coord.XCoordinate,
                        OffsetY = coord.YCoordinate, 
                        Shape = new { type = "Basic", shape = "Ellipse", cornerRadius = 0 },
                    });
                    ViewData["nodes"] = nodes;
                    break;
                case "Square":               
                    nodes.Add(new DiagramNode()
                    {
                        Id = "node" + index,
                        Width = disk.Dim * 2,
                        Height = disk.Dim * 2,
                        OffsetX = coord.XCoordinate,
                        OffsetY = coord.YCoordinate,
                        Shape = new { type = "Basic", shape = "Rectangle", cornerRadius = 0 },
                    });
                    ViewData["nodes"] = nodes;
                    break;
                case "Triangle":
                  
                    nodes.Add(new DiagramNode()
                    {
                        Id = "node" + index,
                        Width = disk.Dim * 2,
                        Height = disk.Dim * 2,
                        OffsetX = coord.XCoordinate,
                        OffsetY = coord.YCoordinate,
                        Shape = new { type = "Basic", shape = "Triangle", cornerRadius = 0 },
                    });
                    ViewData["nodes"] = nodes;
                    break;
                default:
                    // code block
                    break;
            }

            }





        }

    }
}
