using System;

namespace PetApi.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Habitat { get; set; } = string.Empty;
        public string FeedingSchedule { get; set; } = string.Empty; 
        public DateTime VaccinationDate { get; set; }
        public string CleaningSchedule { get; set; } = string.Empty;
        public string Age { get; set; } // Permite valores nulos

    }
}
