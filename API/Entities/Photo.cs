using System.ComponentModel.DataAnnotations.Schema;

namespace API.Controllers.Entities
{
    [Table("Photos")]
    public class Photo
    {
        public int Id { get; set; }
        public required string Url { get; set; }
        public bool IsMain { get; set; }
        public string? PublicId { get; set; }

        // Navigation properties - setup a required one-to-many realationship
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; } = null!;
    }
}