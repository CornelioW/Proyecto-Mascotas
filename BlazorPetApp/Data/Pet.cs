namespace BlazorPetApp.Data
{
    public class Pet
    {
        public int Id { get; set; }
        public required string Name { get; set; } = string.Empty;
        public required string Type { get; set; } = string.Empty;
        public required string Habitat { get; set; } = string.Empty;
        public required string FeedingSchedule { get; set; } = string.Empty;
        public required string VaccinationDate { get; set; } = string.Empty;
        public required string CleaningSchedule { get; set; } = string.Empty;
        public required string PhotoPath { get; set; } = string.Empty;
    }
}
