using System.Collections.Generic;

namespace ChefsBatch.Repository.Models
{
    public class Chef
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specialty { get; set; }
        public double Rating { get; set; }
        public int Experience { get; set; }
        public string Bio { get; set; }
        public List<Meal> Menu { get; set; }
        public string Availability { get; set; }
        public string ContactInfo { get; set; }
        public string ProfilePictureUrl { get; set; }
    }

    public class Meal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
