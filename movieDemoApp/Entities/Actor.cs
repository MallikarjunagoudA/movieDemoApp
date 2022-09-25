using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace movieDemoApp.Entities
{
    public class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Biograpy { get; set; }
        //[Column(TypeName ="Date")]
        public Nullable<DateTime> DOB { get; set; }
    }
}
