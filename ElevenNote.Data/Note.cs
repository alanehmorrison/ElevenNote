using System;
using System.ComponentModel.DataAnnotations;

namespace ElevenNot.Data
{
    public class Note
    {
        [Key]
        public int NoteID { get; set; }

        [Required]
        public Guid OwnerID { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public DateTimeOffset CreatedUTC { get; set; }

        public DateTimeOffset? MotifiedUtc { get; set; }
    }
}