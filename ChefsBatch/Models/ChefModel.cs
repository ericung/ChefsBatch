using System.Collections.Generic;

namespace ChefsBatch.Models
{
    public class ChefModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specialty { get; set; }
        public double Rating { get; set; }
        public int Experience { get; set; }
        public string Bio { get; set; }
        public List<DishModel> Menu { get; set; }
        public string Availability { get; set; }
        public string ContactInfo { get; set; }
        public string ProfilePictureUrl { get; set; }
    }
}
