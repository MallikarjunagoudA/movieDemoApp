using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;

namespace movieDemoApp.Entities
{
    public class Cinema
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //[Precision(precision:9, scale:2)]
        public decimal price { get; set; }
        
        public Point location { get; set; }
    }
}
