namespace FinalProject.Models
{
    public class Mod
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string FileName { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}