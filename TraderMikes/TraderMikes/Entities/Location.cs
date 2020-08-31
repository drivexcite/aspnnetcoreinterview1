using System;

namespace TraderMikes.Entities
{
    public class Location
    {
        public int LocationId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
